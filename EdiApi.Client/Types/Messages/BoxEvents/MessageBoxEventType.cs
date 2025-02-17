namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEvents
{
    /// <summary>Тип события</summary>
    public enum MessageBoxEventType
    {
        /// <summary>Не определено</summary>
        Unknown,

        /// <summary>Новое исходящее сообщение</summary>
        NewOutboxMessage,

        /// <summary>Новое входящее сообщение</summary>
        NewInboxMessage,

        /// <summary>Исходящее сообщение разобрано и успешно определены его основные параметры (формат, тип, отправитель и получатель)</summary>
        RecognizeMessage,

        /// <summary>Новый исходящий документ</summary>
        NewOutboxDocument,

        /// <summary>Исходящее сообщение доставлено получателю</summary>
        MessageDelivered,

        /// <summary>Ошибка доставки исходящего сообщения получателю</summary>
        MessageUndelivered,

        /// <summary>Прочитано получателем</summary>
        MessageReadByPartner,

        /// <summary>Исходящее сообщение прошло проверку на стороне получателя</summary>
        MessageCheckingOk,

        /// <summary>Исходящее сообщение не прошло проверку на стороне получателя (обнаружены ошибки в сообщении)</summary>
        MessageCheckingFail,

        /// <summary>Пакет черновиков отправлен в Диадок</summary>
        DraftOfDocumentPackagePostedIntoDiadoc,

        /// <summary>Пакет черновиков подписан отправителем и отправлен в Диадок. Событие в ящике отправителя</summary>
        DraftOfDocumentPackageSignedByMe,

        /// <summary>Пакет черновиков подписан отправителем и отправлен в Диадок. Событие в ящике получателя</summary>
        DraftOfDocumentPackageSignedBySender,

        /// <summary>Пакет черновиков удален отправителем</summary>
        DraftOfDocumentPackageDeletedFromDiadoc,

        /// <summary>На стороне получателя были обнаружены ошибки в документах, сформированных на основании исходящего Invoic</summary>
        ReceivedDiadocRoamingError,

        /// <summary>Новый входящий документ</summary>
        NewInboxDocument,

        /// <summary>Успешно аннулирован документ в Диадоке, сформированный на основании исходящего Invoic. Событие в ящике отправителя</summary>
        DiadocRevocationAccepted,

        /// <summary>Успешно аннулирован документ в Диадоке, сформированный на основании входящего Invoic. Событие в ящике получателя</summary>
        DiadocRevocationAcceptedForBuyer,

        /// <summary>Сформирован отчёт о времени, затраченном на различные этапы обработки сообщения</summary>
        ProcessingTimesReport,

        /// <summary>Пакет документов подписан получателем в Диадоке. Событие в ящике отправителя</summary>
        DocumentPackageSignedByRecipientOk,

        /// <summary>Пакет документов подписан получателем в Диадоке. Событие в ящике получателя</summary>
        DocumentPackageSignedByMeOk,

        /// <summary>Получатель отказал в подписи пакета документов в Диадоке. Событие в ящике отправителя</summary>
        DocumentPackageSignedByRecipientFail,

        /// <summary>Получатель отказал в подписи пакета документов в Диадоке. Событие в ящике получателя</summary>
        DocumentPackageSignedByMeFail,

        /// <summary>Поступило уведомление об уточнении документа, сформированного на основании исходящего Invoic</summary>
        AmendmentRequested,

        /// <summary>Доставлен документ, сформированный в Диадоке на основании исходящего Invoic</summary>
        DiadocDocumentDelivered,

        /// <summary>Отправлен запрос на аннулирование в Диадоке</summary>
        DiadocRevocationRequested,

        /// <summary>Получатель подписал документы с разногласиями в Диадоке. Событие в ящике отправителя</summary>
        DocumentPackageSignedByRecipientPartiallyOk,

        /// <summary>Получатель подписал документы с разногласиями в Диадоке. Событие в ящике получателя</summary>
        DocumentPackageSignedByMePartiallyOk,

        /// <summary>Изменился статус проверки МЧД получателя документа в Диадоке. Событие в ящике отправителя</summary>
        OutboxDiadocDocumentRecipientPowerOfAttorneyStatusChanged,

        /// <summary>Изменился статус проверки МЧД отправителя документа в Диадоке. Событие в ящике отправителя</summary>
        OutboxDiadocDocumentSenderPowerOfAttorneyStatusChanged,

        /// <summary>Изменился статус проверки МЧД получателя документа в Диадоке. Событие в ящике получателя</summary>
        InboxDiadocDocumentRecipientPowerOfAttorneyStatusChanged,

        /// <summary>Изменился статус проверки МЧД отправителя документа в Диадоке. Событие в ящике получателя</summary>
        InboxDiadocDocumentSenderPowerOfAttorneyStatusChanged,

        // todo согласовать доку
        /// <summary>Изменился статус документа в ГИС МТ "Честный ЗНАК". Событие в ящике получателя</summary>
        InboxDiadocDocumentGisMtStatusChanged,

        /// <summary>Изменился статус запроса на аннулирование документа в ГИС МТ "Честный ЗНАК". Событие в ящике получателя</summary>
        InboxDiadocDocumentRevocationGisMtStatusChanged,

        /// <summary>Изменился статус документа в ГИС МТ "Честный ЗНАК". Событие в ящике отправителя</summary>
        OutboxDiadocDocumentGisMtStatusChanged,

        /// <summary>Изменился статус запроса на аннулирование документа в ГИС МТ "Честный ЗНАК". Событие в ящике отправителя</summary>
        OutboxDiadocDocumentRevocationGisMtStatusChanged,

        /// <summary>Отправитель подписал извещение о получении документа. Событие в ящике получателя</summary>
        InboxDiadocSenderReceiptFinished,

        /// <summary>Отправитель подписал извещение о получении документа. Событие в ящике отправителя</summary>
        OutboxDiadocSenderReceiptFinished,

        /// <summary>Прекратили отслеживать пакет документов в Диадоке. Событие в ящике отправителя</summary>
        OutboxDiadocDocumentPackageTraceabilityLost,

        /// <summary>Прекратили отслеживать пакет документов в Диадоке. Событие в ящике получателя</summary>
        InboxDiadocDocumentPackageTraceabilityLost,

        /// <summary>Изменился статус фиксации отгрузки в ГИС МТ "Честный знак" для документа, сформированного на основании исходящего Invoic</summary>
        OutboxDiadocDocumentFixationGisMtStatusChanged,

        /// <summary>Изменился статус отмены фиксации отгрузки в ГИС МТ "Честный знак" для документа, сформированного на основании входящего Invoic</summary>
        OutboxDiadocDocumentFixationCancellationGisMtStatusChanged,
    }
}