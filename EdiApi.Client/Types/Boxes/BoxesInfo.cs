namespace SkbKontur.EdiApi.Client.Types.Boxes
{
    /// <summary>Информация о доступных пользователю ящиках</summary>
    public class BoxesInfo
    {
        /// <summary>Список доступных ящиков</summary>
        public BoxInfo[] Boxes { get; set; }
    }
}