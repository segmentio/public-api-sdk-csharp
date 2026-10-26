# Segment.PublicApi.Model.DestinationSubscription

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier for the subscription. | 
**Name** | **string** | The name of the subscription. | 
**ActionId** | **string** | The unique identifier for the Destination action to trigger. | 
**ActionSlug** | **string** | The URL-friendly key for the associated Destination action. | 
**DestinationId** | **string** | The associated Destination instance id. | 
**Enabled** | **bool** | Is the subscription enabled. | 
**Settings** | **Dictionary&lt;string, Object&gt;** | Represents settings used to configure an action subscription. | 
**Trigger** | **string** | FQL string that describes what events should trigger a Destination action. | 
**ModelId** | **string** | The unique identifier for the linked ReverseETLModel, if this part of a Reverse ETL connection. | [optional] 
**ReverseETLSchedule** | [**ReverseEtlScheduleDefinition**](ReverseEtlScheduleDefinition.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

