# Segment.PublicApi.Model.PersonalizationInput
The Personalization Input Object.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Profile** | [**Profile**](Profile.md) |  | [optional] 
**Entities** | [**List&lt;PersonalizationInputEntity&gt;**](PersonalizationInputEntity.md) | The entities, and the properties of each entity, to include in the event sent to the Destination. Only applicable to Linked Audiences. Providing entities for a Classic audience returns a 400 error, as Classic audiences support profile properties only. | [optional] 
**SyncEntityPropertyChanges** | **bool** | Sync entity property changes to the Destination. Only applicable if activationType is \&quot;Audience Membership Changed\&quot;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

