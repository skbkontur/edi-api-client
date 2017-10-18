using System;

namespace KonturEdi.Api.Types.Messages
{
    public enum MessageFormat
    {
        Unknown,
        Any,
        KonturXml,
        KorusXml,
        Eancom2002,
        EcrRusXml,

        [Obsolete("p.vostretsov (18.10.2017): Оставлено для совместимости")]
        CisLinkXml,
    }
}