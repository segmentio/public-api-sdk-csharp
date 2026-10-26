# Segment.PublicApi.Model.EntityPathAlpha

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the entity path. | 
**EntityName** | **string** | The display name of the entity. | 
**PathName** | **string** | The display name of the path (root → node). | 
**EntitySlug** | **string** | The slug of the entity. | 
**RelationshipSlugs** | **List&lt;string&gt;** | Ordered slugs for all relationships from root to this node. | 
**ChildRelationshipSlugs** | **List&lt;string&gt;** | Slugs of child relationships from this node. | 
**ParentRelationshipSlugPath** | **string** | Full slug path from root to this node, colon-delimited (for example \&quot;rel-a:rel-b\&quot;). Empty string for root nodes. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

