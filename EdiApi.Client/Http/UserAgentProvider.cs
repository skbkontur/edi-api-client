#nullable enable
using System.Runtime.InteropServices;

namespace SkbKontur.EdiApi.Client.Http
{
    internal static class UserAgentProvider
    {
        static UserAgentProvider()
        {
            var sdkVersion = typeof(ClusterClientFactory).Assembly.GetName().Version.ToString();
            var dotnetDescription = RuntimeInformation.FrameworkDescription.Trim();
            var osDescription = RuntimeInformation.OSDescription.Trim();
            userAgentString = $"Kontur.EDI API SDK={sdkVersion};OS={osDescription};DOTNET={dotnetDescription}";
        }

        public static string GetUserAgent() => userAgentString;

        private static readonly string userAgentString;
    }
}