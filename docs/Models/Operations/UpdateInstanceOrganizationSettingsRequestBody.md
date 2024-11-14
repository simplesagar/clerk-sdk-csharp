# UpdateInstanceOrganizationSettingsRequestBody


## Fields

| Field                                                                                                                                        | Type                                                                                                                                         | Required                                                                                                                                     | Description                                                                                                                                  |
| -------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------- |
| `Enabled`                                                                                                                                    | *bool*                                                                                                                                       | :heavy_minus_sign:                                                                                                                           | N/A                                                                                                                                          |
| `MaxAllowedMemberships`                                                                                                                      | *long*                                                                                                                                       | :heavy_minus_sign:                                                                                                                           | N/A                                                                                                                                          |
| `AdminDeleteEnabled`                                                                                                                         | *bool*                                                                                                                                       | :heavy_minus_sign:                                                                                                                           | N/A                                                                                                                                          |
| `DomainsEnabled`                                                                                                                             | *bool*                                                                                                                                       | :heavy_minus_sign:                                                                                                                           | N/A                                                                                                                                          |
| `DomainsEnrollmentModes`                                                                                                                     | List<*string*>                                                                                                                               | :heavy_minus_sign:                                                                                                                           | Specify which enrollment modes to enable for your Organization Domains.<br/>Supported modes are 'automatic_invitation' & 'automatic_suggestion'. |
| `CreatorRoleId`                                                                                                                              | *string*                                                                                                                                     | :heavy_minus_sign:                                                                                                                           | Specify what the default organization role is for an organization creator.                                                                   |
| `DomainsDefaultRoleId`                                                                                                                       | *string*                                                                                                                                     | :heavy_minus_sign:                                                                                                                           | Specify what the default organization role is for the organization domains.                                                                  |