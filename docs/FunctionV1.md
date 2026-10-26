# Segment.PublicApi.Model.FunctionV1
Represents a Function.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | An identifier for this Function. | [optional] 
**ResourceType** | **string** | The Function type.  Config API note: equal to &#x60;type&#x60;. | [optional] 
**CreatedAt** | **string** | The time this Function was created. | [optional] 
**CreatedBy** | **string** | The id of the user who created this Function. | [optional] 
**Code** | **string** | The Function code. | [optional] 
**DeployedAt** | **string** | The time of this Function&#39;s last deployment. | [optional] 
**Settings** | [**List&lt;FunctionSettingV1&gt;**](FunctionSettingV1.md) | The list of settings for this Function. | [optional] 
**DisplayName** | **string** | A display name for this Function. | [optional] 
**Description** | **string** | A description for this Function. | [optional] 
**LogoUrl** | **string** | The URL of the logo for this Function. | [optional] 
**PreviewWebhookUrl** | **string** | The preview webhook URL for this Function. | [optional] 
**BatchMaxCount** | **decimal** | The max count of the batch for this Function. | [optional] 
**CatalogId** | **string** | The catalog id of this Function. | [optional] 
**IsLatestVersion** | **bool** | Whether the deployment of this Function is the latest version. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

