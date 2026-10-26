# Segment.PublicApi.Model.UpdateReverseEtlModelInput
Defines how to update an existing Model.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | A short, human-readable description of the Model. | [optional] 
**Description** | **string** | A longer, more descriptive explanation of the Model. | [optional] 
**Enabled** | **bool** | Indicates whether the Model should have syncs enabled. When disabled, no syncs will be triggered, regardless of the enabled status of the attached destinations/subscriptions. | [optional] 
**Query** | **string** | The SQL query that will be executed to extract data from the connected Source. | [optional] 
**QueryIdentifierColumn** | **string** | Indicates the column named in &#x60;query&#x60; that should be used to uniquely identify the extracted records. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

