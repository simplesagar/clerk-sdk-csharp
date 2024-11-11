# CreateSAMLConnectionRequestBody


## Fields

| Field                                                                                                                | Type                                                                                                                 | Required                                                                                                             | Description                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- |
| `Name`                                                                                                               | *string*                                                                                                             | :heavy_check_mark:                                                                                                   | The name to use as a label for this SAML Connection                                                                  |
| `Domain`                                                                                                             | *string*                                                                                                             | :heavy_check_mark:                                                                                                   | The domain of your organization. Sign in flows using an email with this domain, will use this SAML Connection.       |
| `Provider`                                                                                                           | [Provider](../../Models/Requests/Provider.md)                                                                        | :heavy_check_mark:                                                                                                   | The IdP provider of the connection.                                                                                  |
| `IdpEntityId`                                                                                                        | *string*                                                                                                             | :heavy_minus_sign:                                                                                                   | The Entity ID as provided by the IdP                                                                                 |
| `IdpSsoUrl`                                                                                                          | *string*                                                                                                             | :heavy_minus_sign:                                                                                                   | The Single-Sign On URL as provided by the IdP                                                                        |
| `IdpCertificate`                                                                                                     | *string*                                                                                                             | :heavy_minus_sign:                                                                                                   | The X.509 certificate as provided by the IdP                                                                         |
| `IdpMetadataUrl`                                                                                                     | *string*                                                                                                             | :heavy_minus_sign:                                                                                                   | The URL which serves the IdP metadata. If present, it takes priority over the corresponding individual properties    |
| `IdpMetadata`                                                                                                        | *string*                                                                                                             | :heavy_minus_sign:                                                                                                   | The XML content of the IdP metadata file. If present, it takes priority over the corresponding individual properties |
| `AttributeMapping`                                                                                                   | [Models.Requests.AttributeMapping](../../Models/Requests/AttributeMapping.md)                                        | :heavy_minus_sign:                                                                                                   | Define the attribute name mapping between Identity Provider and Clerk's user properties                              |