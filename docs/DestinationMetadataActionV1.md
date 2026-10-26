# Segment.PublicApi.Model.DestinationMetadataActionV1
Represents an Action, a building block of behavior that can be performed by the Destination.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The primary key of the action. | 
**Slug** | **string** | A machine-readable key unique to the action definition. | 
**Name** | **string** | A human-readable name for the action. | 
**Description** | **string** | A human-readable description of the action. May include Markdown. | 
**Platform** | **string** | The platform on which this action runs. | 
**Hidden** | **bool** | Whether the action should be hidden. | 
**DefaultTrigger** | **string** | The default value used as the trigger when connecting this action. | 
**Fields** | [**List&lt;DestinationMetadataActionFieldV1&gt;**](DestinationMetadataActionFieldV1.md) | The fields expected in order to perform the action. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

