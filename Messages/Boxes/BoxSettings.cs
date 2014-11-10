using System;

using KonturEdi.Api.Types.JsonConvertation;

using Newtonsoft.Json.Linq;

namespace KonturEdi.Api.Types.Messages.Boxes
{
    public abstract class BoxSettings
    {
        public TransportType TransportType { get; set; }
        public bool IsMain { get; set; }
    }

    public class FtpBoxSettings : BoxSettings
    {
        public FtpBoxSettings()
        {
            TransportType = TransportType.Ftp;
        }

        public string InboxRelativePath { get; set; }
        public string OutboxRelativePath { get; set; }
    }

    public class ProviderBoxSettings : BoxSettings
    {
        public ProviderBoxSettings()
        {
            TransportType = TransportType.Provider;
        }

        public string ProviderTransportBoxId { get; set; }
    }

    public class As2BoxSettings : BoxSettings
    {
        public As2BoxSettings()
        {
            TransportType = TransportType.As2;
        }
    }

    public class ApiBoxSettings : BoxSettings
    {
        public ApiBoxSettings()
        {
            TransportType = TransportType.Api;
        }
    }

    public class UnknowBoxSettings : BoxSettings
    {
        public UnknowBoxSettings()
        {
            TransportType = TransportType.Unknown;
        }
    }

    public class JsonBoxSettingsConvertor : JsonCreationConverter<BoxSettings>
    {
        protected override BoxSettings Create(Type objectType, JObject jObject)
        {
            var type = jObject["TransportType"] != null ? jObject["TransportType"].Value<string>() : null;
            TransportType transportType;
            if(Enum.TryParse(type, out transportType))
            {
                if(transportType == TransportType.Api)
                    return new ApiBoxSettings();
                if(transportType == TransportType.As2)
                    return new As2BoxSettings();
                if(transportType == TransportType.Ftp)
                    return new FtpBoxSettings();
                if(transportType == TransportType.Provider)
                    return new ProviderBoxSettings();
            }
            return null;
        }
    }
}