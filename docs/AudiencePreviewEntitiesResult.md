# Segment.PublicApi.Model.AudiencePreviewEntitiesResult
Result membership object for an audience preview with `audienceType: USERS` or `audienceType: LINKED`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Entity id. | 
**IdProperty** | **string** | The entity primary key column name. | 
**RelationshipSlug** | **string** | The entity relationship slug. | 
**Properties** | **Dictionary&lt;string, Object&gt;** | Entity properties. | [optional] 
**Entities** | **Dictionary&lt;string, Object&gt;** | Related entities that are one level deeper will only be returned if those entities are referenced in the audience definition. | [optional] 
**Profiles** | [**List&lt;Profile&gt;**](Profile.md) | Related list of profiles. | [optional] 
**ProfilesTruncated** | **bool** | Indicates if only a subset of the profiles associated with the entity were returned. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

