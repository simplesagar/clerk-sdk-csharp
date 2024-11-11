# Session


## Fields

| Field                                                                                  | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `Object`                                                                               | [SessionObject](../../Models/Components/SessionObject.md)                              | :heavy_check_mark:                                                                     | String representing the object's type. Objects of the same type share the same value.<br/> |
| `Id`                                                                                   | *string*                                                                               | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `UserId`                                                                               | *string*                                                                               | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `ClientId`                                                                             | *string*                                                                               | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `Actor`                                                                                | [Models.Components.Actor](../../Models/Components/Actor.md)                            | :heavy_minus_sign:                                                                     | N/A                                                                                    |
| `Status`                                                                               | [Models.Components.Status](../../Models/Components/Status.md)                          | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `LastActiveOrganizationId`                                                             | *string*                                                                               | :heavy_minus_sign:                                                                     | N/A                                                                                    |
| `LastActiveAt`                                                                         | *long*                                                                                 | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `LatestActivity`                                                                       | [LatestActivity](../../Models/Components/LatestActivity.md)                            | :heavy_minus_sign:                                                                     | N/A                                                                                    |
| `ExpireAt`                                                                             | *long*                                                                                 | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `AbandonAt`                                                                            | *long*                                                                                 | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `UpdatedAt`                                                                            | *long*                                                                                 | :heavy_check_mark:                                                                     | Unix timestamp of last update.<br/>                                                    |
| `CreatedAt`                                                                            | *long*                                                                                 | :heavy_check_mark:                                                                     | Unix timestamp of creation.<br/>                                                       |