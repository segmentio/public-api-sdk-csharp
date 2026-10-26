# Segment.PublicApi.Model.CreateInsertFunctionInstanceAlphaInput
Creates an insert Function instance.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FunctionId** | **string** | Insert Function id to which this instance is associated. Note: Remove the ifnd_/ifns_ prefix from the id. | 
**IntegrationId** | **string** | The Source or Destination id to be connected. | 
**Enabled** | **bool** | Whether this insert Function instance should be enabled for the Destination. | [optional] 
**Name** | **string** | Defines the display name of the insert Function instance. | 
**Settings** | **Dictionary&lt;string, Object&gt;** | An object that contains settings for this insert Function instance based on the settings present in the insert Function class. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

