# Segment.PublicApi.Model.CreateDestinationSubscriptionAlphaInput
The basic input parameters for creating a Destination subscription.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | A user-defined name for the subscription. | 
**ActionId** | **string** | The associated action id the subscription should trigger. | 
**Trigger** | **string** | The FQL statement. | 
**Enabled** | **bool** | Is the subscription enabled. | 
**Settings** | **Dictionary&lt;string, Object&gt;** | Represents settings used to configure an action subscription. | [optional] 
**ModelId** | **string** | When creating a Reverse ETL connection, indicates the Model being used to extract data. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

