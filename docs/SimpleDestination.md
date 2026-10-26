# Segment.PublicApi.Model.SimpleDestination

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the Integration. | 
**Name** | **string** | The name of the Destination. | [optional] 
**SourceId** | **string** | The Source of the Destination. | 
**Enabled** | **bool** | Whether the Integration is enabled or not. | 
**CreatedAt** | **string** | When the Integration connection was created. | 
**UpdatedAt** | **string** | When the Integration connection was last updated. | 
**Settings** | **Dictionary&lt;string, Object&gt;** | The Destination settings. | 
**DestinationId** | **string** | The Destination id. | 
**Metadata** | [**Metadata**](Metadata.md) |  | [optional] 
**IdSyncConfiguration** | [**List&lt;IDSyncConfigurationInput&gt;**](IDSyncConfigurationInput.md) | Identifier sync configuration. Defines which external ids to sync and their selection strategies. Maximum 5 items allowed. If omitted, the default will be last email and last user_id, or all email and all user_id depending on the Destination. | [optional] 
**ConnectionSettings** | **Object** | The settings that a Destination requires to create audiences on a third-party platform. These settings are Destination-specific. Use the List Supported Destinations from Audience endpoint to find the required connection settings. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

