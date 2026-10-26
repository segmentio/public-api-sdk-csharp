# Segment.PublicApi.Model.DestinationSubscriptionUpdateInput
The input parameters for updating a Destination subscription.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The user-defined name for the subscription. | [optional] 
**Trigger** | **string** | The fql statement. | [optional] 
**Enabled** | **bool** | Is the subscription enabled. | [optional] 
**Settings** | **Dictionary&lt;string, Object&gt;** | Represents settings used to configure an action subscription. | [optional] 
**ReverseETLModelId** | **string** | (Reverse ETL only) The reverse ETL model to attach this subscription to. | [optional] 
**ReverseETLSchedule** | [**ReverseEtlScheduleDefinition**](ReverseEtlScheduleDefinition.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

