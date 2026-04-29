namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.V2
{
    /// <summary>Состояние титула документа по участнику документооборота</summary>
    public class DiadocParticipantTitleState
    {
        /// <summary>Информация о титуле документа участника документооборота</summary>
        public DiadocParticipantTitle ParticipantTitle { get; set; }

        /// <summary>Список ответов участников документооборота на титул документа</summary>
        public DiadocParticipantTitleResponse[] ParticipantTitleResponses { get; set; }
    }
}