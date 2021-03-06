# PermissionObjectProperty
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteId** | **String** |  | [optional] 
**SiteUrl** | **String** |  | [optional] 
**WebId** | **String** |  | [optional] 
**WebServerRelativeUrl** | **String** |  | [optional] 
**ListTitle** | **String** |  | [optional] 
**ObjectUrl** | **String** |  | [optional] 
**IsInherit** | **Boolean** |  | [optional] 
**InheritNodeType** | [**TreeNodeType**](TreeNodeType.md) |  | [optional] 
**TopInheritUrl** | **String** |  | [optional] 
**CheckType** | [**TreeNodeType**](TreeNodeType.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$PermissionObjectProperty = New-Cloud.Governance.ClientPermissionObjectProperty  -SiteId null `
 -SiteUrl null `
 -WebId null `
 -WebServerRelativeUrl null `
 -ListTitle null `
 -ObjectUrl null `
 -IsInherit null `
 -InheritNodeType null `
 -TopInheritUrl null `
 -CheckType null
```

- Convert the resource to JSON
```powershell
$PermissionObjectProperty | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

