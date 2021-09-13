# История изменений

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
