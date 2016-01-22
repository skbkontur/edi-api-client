using System;

namespace KonturEdi.Api.Types.BoxEvents
{
    public interface IBoxEventContent
    {
        [Obsolete("avk: удалю после перехода на новые рич бокс ивенты")]
        bool IsEmpty();
    }
}