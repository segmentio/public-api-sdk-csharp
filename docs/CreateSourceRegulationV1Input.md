# Segment.PublicApi.Model.CreateSourceRegulationV1Input
The input to create a Source-scoped regulation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RegulationType** | **string** | The regulation type to create. Please note that &#x60;DELETE_ARCHIVE_ONLY&#x60; is only supported for limited Workspaces for Source-scoped regulations. | 
**SubjectType** | **string** | The subject type. Note: &#x60;ANONYMOUS_ID&#x60; is only supported for limited Workspaces for Source-scoped regulations. &#x60;ANONYMOUS_ID&#x60; is only supported when regulationType is &#x60;DELETE_ARCHIVE_ONLY&#x60;. | 
**SubjectIds** | **List&lt;string&gt;** | The list of &#x60;userId&#x60; or &#x60;objectId&#x60; or &#x60;anonymousId&#x60; values of the subjects to regulate.  Config API note: equal to &#x60;parent&#x60; but allows an array. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

