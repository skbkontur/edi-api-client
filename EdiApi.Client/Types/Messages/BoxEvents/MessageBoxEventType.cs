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
    }
}