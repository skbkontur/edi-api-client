namespace SkbKontur.EdiApi.Client.Types.Boxes
{
    /// <summary>Информация о ящике</summary>
    public class BoxInfo
    {
        /// <summary>Идентификатор ящика</summary>
        public string Id { get; set; }
        /// <summary>Идентификатор организации, которой принадлежит ящик</summary>
        public string PartyId { get; set; }
        /// <summary>GLN ящика</summary>
        public string Gln { get; set; }
        /// <summary>Флаг, показывающий, что данный ящик является тестовым</summary>
        public bool IsTest { get; set; }
        /// <summary>Настройки ящика</summary>
        public BoxSettings BoxSettings { get; set; }
    }
}