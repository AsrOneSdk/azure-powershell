# Overall
This directory contains management plane service clients of Az.RecoveryServices SiteRecovery APIs.

## Run Generation
In this directory, run AutoRest:
```
autorest --reset
autorest --use:@autorest/powershell@4.x
```

### AutoRest Configuration
> see https://aka.ms/autorest
``` yaml
isSdkGenerator: true
powershell: true
clear-output-folder: true
reflect-api-versions: true
openapi-type: arm
azure-arm: true
license-header: MICROSOFT_MIT_NO_VERSION
payload-flattening-threshold: 2
```

###
``` yaml
commit: 100f67b7fdcd3460bb2b83ae525fa8a428f30fbb
input-file:
  - https://github.com/Azure/azure-rest-api-specs/blob/$(commit)/specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2024-10-01/service.json
  
output-folder: Generated

namespace: Microsoft.Azure.Management.RecoveryServices.SiteRecovery
directive:
  - from: swagger-document
    where: $.definitions
    transform: >
      if (!$.ProtectedClustersQueryParameter) {
        $.ProtectedClustersQueryParameter = {
          "description": "Query parameters for listing protected clusters",
          "type": "object",
          "properties": {
            "state": {
              "type": "string",
              "description": "The state to be used for getting or setting the state of the protected cluster"
            }
          }
        };
      }
```

