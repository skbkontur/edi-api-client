using SkbKontur.EdiApi.Client.Types.Messages;

namespace SkbKontur.EdiApi.Client.Types.Boxes
{
    /// <summary>Настройки ящика</summary>
    public abstract class BoxSettings
    {
        /// <summary>Тип транспорта, используемый в ящике</summary>
        public TransportType TransportType { get; set; }
        /// <summary>Признак основного транспорта</summary>
        public bool IsMain { get; set; }
        /// <summary>Типы сообщений, настроенные для ящика. Значение “Any” означает, что данный ящик соответствует настройкам “Транспорт по умолчанию”</summary>
        public DocumentType[] DocumentTypes { get; set; }
        /// <summary>Форматы сообщений, настроенные для ящика. Значение “Any” означает, что данный ящик соответствует настройкам “Транспорт по умолчанию”</summary>
        public MessageFormat[] CustomMessageFormats { get; set; }
    }

    public class FtpBoxSettings : BoxSettings
    {
        public FtpBoxSettings()
        {
            TransportType = TransportType.Ftp;
        }

        /// <summary>Путь папки входящих сообщений на Ftp (заполняется только в том случае, если тип транспорта - “Ftp” и ящик используется для входящих сообщений)</summary>
        public string InboxRelativePath { get; set; }
        /// <summary>Путь папки исходящих сообщений на Ftp (заполняется только в том случае, если тип транспорта - “Ftp” и ящик используется для исходящих сообщений)</summary>
        public string OutboxRelativePath { get; set; }
    }

    public class ProviderBoxSettings : BoxSettings
    {
        public ProviderBoxSettings()
        {
            TransportType = TransportType.Provider;
        }

        /// <summary>Идентификатор ящика провайдера (заполняется только в том случае, если тип транспорта - “Provider”)</summary>
        public string ProviderTransportBoxId { get; set; }
    }

    public class As2BoxSettings : BoxSettings
    {
        public As2BoxSettings()
        {
            TransportType = TransportType.As2;
        }
    }

    public class WebBoxSettings : BoxSettings
    {
        public WebBoxSettings()
        {
            TransportType = TransportType.Web;
        }
    }

    public class ApiBoxSettings : BoxSettings
    {
        public ApiBoxSettings()
        {
            TransportType = TransportType.Api;
        }

        public bool DeliveryNotificationEnabled { get; set; }
    }

    public class UnknowBoxSettings : BoxSettings
    {
        public UnknowBoxSettings()
        {
            TransportType = TransportType.Unknown;
        }
    }
}