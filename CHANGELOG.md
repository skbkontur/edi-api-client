# История изменений

## v1.2 - 2020.04.??
- Доработка метода `AddOrUpdateParty` для интеграции с Контур.Продажами (EDISUP-13100).

## v1.1 - 2020.03.05
- Добавлена информация о принятии организацией публичной оферты: свойство `LicenseAgreementAccepted` в `PartyInfo` (EDISUP-12819).
- Добавлена информация о стратегии маршрутизации EDI-сообщений: свойства `BuyerBoxSelectionStrategy`, `SupplierBoxSelectionStrategy` в `PartyInfo` (EDITSKS-2246).
- Добавлен GLN точки доставки сообщения в метод `GetInboxMessageMeta`: свойство `DeliveryPointGln` в `DocumentDetails` (EDITSKS-2244).

## v1.0 - 2020.01.28
- Выпустили первую версию API-клиента EDI.
