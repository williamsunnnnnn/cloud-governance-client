# CgClient.GrantPermissionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**url** | [**GrantPermissionSPObject**](GrantPermissionSPObject.md) |  | [optional] 
**permissionSettings** | [**GrantPermissionRequestPermissionSettings**](GrantPermissionRequestPermissionSettings.md) |  | [optional] 
**permissionDurationSettings** | [**GrantPermissionRequestDurationSettings**](GrantPermissionRequestDurationSettings.md) |  | [optional] 
**selectedUsers** | [**[SharingEnabledUser]**](SharingEnabledUser.md) |  | [optional] 
**externalUserSharingSettings** | [**ExternalUserSharingSettings**](ExternalUserSharingSettings.md) |  | [optional] 
**welcomeEmailSettings** | [**WelcomeEmailSettings**](WelcomeEmailSettings.md) |  | [optional] 
**id** | **String** |  | [optional] 
**serviceId** | **String** |  | [optional] 
**department** | **String** |  | [optional] 
**summary** | **String** |  | [optional] 
**notesToApprovers** | **String** |  | [optional] 
**questionnaireId** | **String** |  | [optional] 
**metadatas** | [**[RequestMetadata]**](RequestMetadata.md) |  | [optional] 
**ticketNumber** | **Number** |  | [optional] [readonly] 
**type** | [**ServiceTypeNullable**](ServiceTypeNullable.md) |  | [optional] [readonly] 
**typeDescription** | **String** |  | [optional] [readonly] 
**requester** | **String** |  | [optional] [readonly] 
**status** | [**RequestStatusNullable**](RequestStatusNullable.md) |  | [optional] [readonly] 
**progressStatus** | **Number** |  | [optional] [readonly] 
**progressStatusDescription** | **String** |  | [optional] [readonly] 
**submittedTime** | **Date** |  | [optional] [readonly] 
**lastUpdated** | **Date** |  | [optional] [readonly] 
**createdTime** | **Date** |  | [optional] [readonly] 
**assignTo** | **String** |  | [optional] [readonly] 
**fullPath** | **String** |  | [optional] [readonly] 


