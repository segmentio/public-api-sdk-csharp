# Segment.PublicApi.Model.AudienceDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TargetEntity** | **string** | The target entity relationship slug, only applicable for linked audiences. Use &#x60;&#x60;&#x60;profile&#x60;&#x60;&#x60; when the targeting the profile.  Note that the value defaults to profile if not specified. Also note, that the value will be returned as null if the target entity is removed from the data graph. | [optional] 
**Query** | **string** | The query language string defining the audience segmentation criteria.  For guidance on using the query language, see the [Segment documentation site](https://segment.com/docs/api/public-api/query-language). | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

