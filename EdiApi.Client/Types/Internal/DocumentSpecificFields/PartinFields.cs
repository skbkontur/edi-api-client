﻿namespace SkbKontur.EdiApi.Client.Types.Internal.DocumentSpecificFields
{
    public class PartinFields
    {
        public string OwnerId { get; set; }

        public string[] BuyerOrPayerGlns { get; set; }
        public string[] ShipperOrConsigneeGlns { get; set; }
    }
}