# Segment.PublicApi.Model.CreateCloudSourceRegulationV1Input
The input to create a Cloud Source-scoped regulation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RegulationType** | **string** | The regulation type to create. | 
**SubjectType** | **string** | The subject type. Must be &#x60;objectId&#x60; for Cloud Sources. | 
**SubjectIds** | **List&lt;string&gt;** | The list of &#x60;userId&#x60; or &#x60;objectId&#x60; values of the subjects to regulate.  Config API note: equal to &#x60;parent&#x60; but allows an array. | 
**Collection** | **string** | The Cloud Source collection to regulate. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

