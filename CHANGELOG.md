# История изменений
## v2.16.5 - 2025.10.03
- Удалён GetUsersInfo API метод

## v2.15.2 - 2025.08.29
- Добавлено свойство DiadocPowerOfAttorneyFullId.RepresentativeInn ("ИНН представителя из МЧД")

## v2.14.2 - 2025.08.27
- Добавлено поле "Требуется подписать документ отмены фиксации" для событий AmendmentRequestedEventContent, MessageDiadocRevocationRequestedEventContent

## v2.13.3 - 2025.08.18
- Добавлен тип сообщения "PARTIN 2" для уведомления об изменении режима работы точки доставки

## v2.12.2 - 2025.08.14
- Добавлен статус "Ошибка отправки документа в ГИС МТ" в события статусами обработки в ГИС МТ

## v2.11 - 2025.06.26
- Добавлено поле "Требуется подписать документ отмены фиксации" для событий MessageDiadocRevocationAcceptedEvent, MessageDocumentPackageSignedByRecipientFailEvent

## v2.10.3 - 2025.05.12
- Добавлены статусы приложенности МЧД (приложена/не требуется/требуется) в события подписи документа

## v2.9.5 - 2025.04.14
- Интеграция с Контур.Логистикой:
  - Добавлен метод получения УИД транспортного документа `GetTransportationDocumentIdentifier`
  - Добавлено событие с отправкой титула транспортной накладной в Контур.Логистику `OutboxLogisticsWaybillTitlePostingStatus`
  - Добавлено событие с актуальным статусом транспортной накладной в Контур.Логистике `OutboxLogisticsWaybillStatusChanged`
- Некоторые поля отмечены как устаревшие
- Обновлены версии библиотек

## v2.8.2 - 2025.03.03
- Добавлены события со статусом фиксации отгрузки и отмены фиксации отгрузки в ГИС МТ "Честный ЗНАК"

## v2.7.2 - 2025.01.29
- Переход на новую структуру ошибок при проверке МЧД

## v2.6.3 - 2024.11.26
- Добавлена структура ForeignPartyInfo в данные об организации и точке доставки/отгрузки

## v2.5.3 - 2024.08.22
- Добавлены поля GlnStatus, GlnExpirationDate в данные об организации

## v2.4.3 - 2023.10.24
- Добавлены события OutboxDiadocDocumentPackageTraceabilityLost и InboxDiadocDocumentPackageTraceabilityLost, сигнализирующие о том, что прекращено отслеживание пакета документов в Диадоке

## v2.3.6 - 2023.10.10
- Добавлены поля IsPromotionalPrice и PromotionalDealNumber в CommonGoodItem

## v2.3.4 - 2023.08.16
- Добавлен OrdersRevisionNumber в OrdrspFields

## v2.3.1 - 2023.08.10
- Добавлен тип Notification в DocumentRevisionType

## v2.2.4 - 2023.04.04
- Добавлено свойство IsMdnPositive в структуру AS2SendDetails

## v2.2.3 - 2023.03.29
- Добавлено неструктурированное сообщение CONDRA
- Поддержана передача и получение вложенных файлов

## v2.1.7 - 2023.02.08
- Добавлены события со статусами обработки в ГИС МТ в Диадоке

## v2.0.12 - 2022.08.15
- Добавлены свойства InvoicFields.GovernmentContractId и CoinvoicFields.GovernmentContractId 

## v2.0.9 - 2022.04.18
- Добавлены события со статусами проверки МЧД в Диадоке
- Добавлено описание сущностей для документации

## v1.9.14 - 2021.12.03
- В событие MessageDocumentPackageSignedByRecipientPartiallyOkEventContent добавлено поле Reason, содержащее комментарий подписи с разногласиями получателем
- Перешли на .NET6

## v1.9.9 - 2021.11.26
- В событие MessageDocumentPackageSignedByRecipientFailEventContent добавлено поле Reason, содержащее комментарий отказа подписи документа получателем

## v1.9.5 - 2021.09.13
- Добавлено свойство RussianAddressInfo.Block для передачи корпуса в адресе

## v1.9.2 - 2021.08.12
- Добавлено свойство DiadocUrls.PriceListUrl для передачи ссылки на чистовик PriceList в Diadoc

## v1.9.1 - 2021.06.12
- Добавлены события для подписания документа в Диадоке с разногласиями

## v1.8.1 - 2021.05.11
- EdiApiClient переведен на ClusterClient
- Добавлены конструкторы для работы через Singular в классы `TransformerConnectorEdiApiClient`, `InternalEdiApiHttpClient` и `MessagesEdiApiHttpClient`.

## v1.7.10 - 2020.04.02
- Добавлен параметр `enableKeepAlive` в конструктор классов `TransformerConnectorEdiApiClient`, `InternalEdiApiHttpClient` и `MessagesEdiApiHttpClient`.

## v1.7.8 - 2020.04.02
- Добавлен параметр `enableKeepAlive` в конструктор класса `BaseEdiApiHttpClient`.

## v1.7.6 - 2020.10.28
- Добавлены: `enum PaidFeatureType`, `class PaidPeriod`, `class PaidFeatureInfo`.
- В `class PartyInfo` добавлено свойство `PaidFeatures`, обозначающее информацию о платных услугах для организации.

## v1.6 - 2020.06.15
- В `enum PartyType` добавлено значение `Provider`, обозначающее тип организации Провайдер.

## v1.5 - 2020.05.31
- Добавлено свойство `IsTest` в `InternalPartyInfo`. Обозначает, что организация является тестовой.

## v1.4 - 2020.04.28
- Исправлен баг в `InternalPartyInfo`. Свойство `InternalPartyInfo.PortalGroupId` не сериализовалась в XML с помощью `System.Xml.Serialization.XmlSerializer`. Теперь снова сериализуется.

## v1.3 - 2020.04.20
- Добавлено свойство `BillingAccountId` в `InternalPartyInfo`. Это тоже самое, что `PortalGroupId`. `PortalGroupId` теперь obsolete и будет удалено в будущих версиях.

## v1.2 - 2020.04.05
- Доработка метода `AddOrUpdateParty` для интеграции с Контур.Продажами (EDISUP-13100).
- Метод `AddEmployee` использует POST-запрос.

## v1.1 - 2020.03.05
- Добавлена информация о принятии организацией публичной оферты: свойство `LicenseAgreementAccepted` в `PartyInfo` (EDISUP-12819).
- Добавлена информация о стратегии маршрутизации EDI-сообщений: свойства `BuyerBoxSelectionStrategy`, `SupplierBoxSelectionStrategy` в `PartyInfo` (EDITSKS-2246).
- Добавлен GLN точки доставки сообщения в метод `GetInboxMessageMeta`: свойство `DeliveryPointGln` в `DocumentDetails` (EDITSKS-2244).

## v1.0 - 2020.01.28
- Выпустили первую версию API-клиента EDI.
