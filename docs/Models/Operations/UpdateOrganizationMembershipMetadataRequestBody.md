# UpdateOrganizationMembershipMetadataRequestBody


## Fields

| Field                                                                                                                                                    | Type                                                                                                                                                     | Required                                                                                                                                                 | Description                                                                                                                                              |
| -------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `PublicMetadata`                                                                                                                                         | [UpdateOrganizationMembershipMetadataPublicMetadata](../../Models/Operations/UpdateOrganizationMembershipMetadataPublicMetadata.md)                      | :heavy_minus_sign:                                                                                                                                       | Metadata saved on the organization membership, that is visible to both your frontend and backend.<br/>The new object will be merged with the existing value. |
| `PrivateMetadata`                                                                                                                                        | [UpdateOrganizationMembershipMetadataPrivateMetadata](../../Models/Operations/UpdateOrganizationMembershipMetadataPrivateMetadata.md)                    | :heavy_minus_sign:                                                                                                                                       | Metadata saved on the organization membership that is only visible to your backend.<br/>The new object will be merged with the existing value.           |