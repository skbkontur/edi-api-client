# История изменений

## v1.1 - 2020.02.26
- Добавлена информация о настройках взаимодействия c контрагентом в Диадоке в метод `GetBoxDocumentsSettings`: схема взаимодействия Invoic с Диадоком (`InvoicIntegrationScheme`) и тип документов при отправке в Диадок (`DiadocDocumentsType`).
- Добавлена информация о принятии организацией публичной оферты: свойство `LicenseAgreementAccepted` в `PartyInfo`.
- Добавлена информация о стратегии маршрутизации EDI-сообщений: свойства `BuyerBoxSelectionStrategy`, `SupplierBoxSelectionStrategy` в `PartyInfo`.
- Добавлен GLN точки доставки сообщения в метод `GetInboxMessageMeta`: свойство `DeliveryPartyGln` в `DocumentDetails`.

## v1.0 - 2020.01.28
- Выпустили первую версию API-клиента EDI.
