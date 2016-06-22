using System;

using KonturEdi.Api.Types.Messages;
using KonturEdi.Api.Types.Messages.BoxEventsContents;

namespace KonturEdi.Api.Types.Internal
{
    public class LinkedDocumentInfo
    {
        public DocumentId DocumentId { get; set; } // может быть не заполнено для связей, созданных до релиза avk/linkedDocumentsInApi
        public string DocumentCirculationId { get; set; }
        public DocumentType DocumentType { get; set; }
        public DateTime CreationDateTime { get; set; }
    }
}