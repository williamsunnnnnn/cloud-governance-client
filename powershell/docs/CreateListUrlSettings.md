# CreateListUrlSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableContructUrl** | **Boolean** |  | [optional] 
**ContructUrlSetting** | [**ContructUrlSetting**](ContructUrlSetting.md) |  | [optional] 
**EnableUrlValidation** | **Boolean** |  | [optional] 
**TextValidationRule** | [**TextValidationRuleRef**](TextValidationRuleRef.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateListUrlSettings = New-Cloud.Governance.ClientCreateListUrlSettings  -EnableContructUrl null `
 -ContructUrlSetting null `
 -EnableUrlValidation null `
 -TextValidationRule null
```

- Convert the resource to JSON
```powershell
$CreateListUrlSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

