namespace SkbKontur.EdiApi.Client.Types.Messages
{
    /// <summary>Тип сообщения</summary>
    public enum DocumentType
    {
        /// <summary>Неизвестно</summary>
        Unknown,
        /// <summary>Не задан тип сообщения. Значение может быть возвращено при вызове метода GetBoxesInfo в структуре BoxSettings</summary>
        Any,
        /// <summary>Заказ</summary>
        Orders,
        /// <summary>Подтверждение заказа</summary>
        Ordrsp,
        /// <summary>Уведомление об отгрузке</summary>
        Desadv,
        /// <summary>Уведомление о приемке</summary>
        Recadv,
        /// <summary>Счёт</summary>
        Invoic,
        /// <summary>Корректировка</summary>
        Coinvoic,
        /// <summary>Уведомление об отгрузке алкогольной продукции</summary>
        Alcrpt,
        /// <summary>Статусное сообщение</summary>
        Stsmsg,
        /// <summary>Уведомление о возврате</summary>
        Retann,
        /// <summary>Ответ на уведомление о возврате</summary>
        Retins,
        /// <summary>Уведомление об обратной отгрузке</summary>
        Retdes,
        /// <summary>Уведомление об обратной приемке</summary>
        Retrec,
        /// <summary>Обратный счёт</summary>
        Retinv,
        /// <summary>Обратный заказ</summary>
        POrders,
        /// <summary>Каталог</summary>
        Pricat,
        /// <summary>Ценовой лист</summary>
        PriceList,
        /// <summary>Информация о сторонах</summary>
        Partin,
        /// <summary>График поставок</summary>
        Delfor,
        /// <summary>Акт сверки взаиморасчётов</summary>
        Coacsu,
        /// <summary>Отчёт об остатках</summary>
        Invrpt,
        /// <summary>Отчёт о продажах</summary>
        Slsrpt,
        /// <summary>Заявка на транспортировку груза</summary>
        Iftmbf,
        /// <summary>Подтверждение заявки на транспортировку груза</summary>
        Iftmbc
    }
}