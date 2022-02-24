namespace SkbKontur.EdiApi.Client.Types.Connectors
{
    /// <summary>Информация о доступных пользователю ящиках коннекторов</summary>
    public class ConnectorBoxesInfo
    {
        /// <summary>Список доступных ящиков коннекторов</summary>
        public ConnectorBoxInfo[] ConnectorBoxes { get; set; }
    }
}