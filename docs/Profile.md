# Segment.PublicApi.Model.Profile
The profile traits included in the event sent to the Destination. Applies to both Classic and Linked Audiences. For a Classic audience this is the only form of personalization available, whereas a Linked Audience can also personalize on entities.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Properties** | **List&lt;string&gt;** | The profile traits to include in the event sent to the Destination. | [optional] 
**Mapping** | **Dictionary&lt;string, string&gt;** | Maps a profile trait to the name it should be sent under. Each key is a trait, and each value is the name used in the event. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

