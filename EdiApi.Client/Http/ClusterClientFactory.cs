using System;
using System.Net;

using Vostok.Clusterclient.Core;
using Vostok.Clusterclient.Singular;
using Vostok.Clusterclient.Tracing;
using Vostok.Clusterclient.Transport;
using Vostok.Logging.Abstractions;
using Vostok.Tracing.Abstractions;

#nullable enable

namespace SkbKontur.EdiApi.Client.Http
{
    internal static class ClusterClientFactory
    {
        public static IClusterClient Get(
            Uri externalUri,
            int defaultRequestTimeoutMs,
            IWebProxy? proxy = null,
            ILog? log = null
        )
        {
            if (externalUri == null)
            {
                throw new ArgumentNullException(nameof(externalUri));
            }

            return new ClusterClient(log, configuration =>
                {
                    configuration.DefaultTimeout = TimeSpan.FromMilliseconds(defaultRequestTimeoutMs);
                    configuration.SetupExternalUrl(externalUri);
                    configuration.SetupUniversalTransport(
                        new UniversalTransportSettings
                            {
                                AllowAutoRedirect = false,
                                Proxy = proxy
                            });
                });
        }

        public static IClusterClient Get(
            string environmentName,
            int defaultRequestTimeoutMs,
            IWebProxy? proxy = null,
            ILog? log = null,
            ITracer? tracer = null
        )
        {
            if (string.IsNullOrEmpty(environmentName))
            {
                throw new ArgumentOutOfRangeException(nameof(environmentName));
            }

            return new ClusterClient(log, configuration =>
                {
                    configuration.DefaultTimeout = TimeSpan.FromMilliseconds(defaultRequestTimeoutMs);
                    configuration.SetupSingular(new SingularClientSettings(environmentName, "Catalogue_EDI_API_Front"));
                    configuration.SetupUniversalTransport(
                        new UniversalTransportSettings
                            {
                                AllowAutoRedirect = false,
                                Proxy = proxy
                            });

                    if (tracer != null)
                        configuration.SetupDistributedTracing(tracer);
                });
        }
    }
}