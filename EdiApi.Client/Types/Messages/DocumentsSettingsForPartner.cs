﻿namespace SkbKontur.EdiApi.Client.Types.Messages
{
    public class DocumentsSettingsForPartner
    {
        public Partner Partner { get; set; }
        public DocumentSettings[] DocumentSettings { get; set; }
    }
}