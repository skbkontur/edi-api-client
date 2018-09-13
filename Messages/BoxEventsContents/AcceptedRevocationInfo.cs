namespace KonturEdi.Api.Types.Messages.BoxEventsContents
{
    //(n.kochnev) думается мне, что надо бы переименовать этот класс в RevocationInfo.
    //скажется ли это на апи?
    public class AcceptedRevocationInfo
    {
        public DiadocDocumentType DiadocDocumentType { get; set; }

        public string RevocationReason { get; set; }
    }
}