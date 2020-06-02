# История изменений

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
