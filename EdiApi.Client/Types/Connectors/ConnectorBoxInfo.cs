namespace SkbKontur.EdiApi.Client.Types.Connectors
{
    /// <summary>Информация о ящике коннектора</summary>
    public class ConnectorBoxInfo
    {
        /// <summary>Идентификатор ящика</summary>
        public string Id { get; set; }

        /// <summary>Идентификатор организации, которой принадлежит ящик</summary>
        public string PartyId { get; set; }

        /// <summary>Настройки ящика</summary>
        public ConnectorBoxSettings BoxSettings { get; set; }
    }

    /// <summary>Настройки ящика коннектора</summary>
    public class ConnectorBoxSettings
    {
        /// <summary>Имя коннектора</summary>
        public string Name { get; set; }

        /// <summary>Тип коннектора</summary>
        public ConnectorType ConnectorType { get; set; }
    }

    /// <summary>Тип коннектора</summary>
    public enum ConnectorType
    {
        /// <summary>Неизвестно</summary>
        Unknown,

        /// <summary>Роутер</summary>
        Router,

        /// <summary>Трансформер</summary>
        Transformer,

        /// <summary>Транспортер (предназначен для синхронизации файлов между разными источниками и приемниками файлов)</summary>
        Transporter,
    }
}