# Segment.PublicApi.Model.AudiencePreview
An audience preview.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for tracking and retrieving results of an audience preview. | 
**AudienceType** | **string** | The audience type of the preview.  Possible values: USERS, ACCOUNTS, LINKED. | 
**Definition** | [**AudienceDefinition**](AudienceDefinition.md) |  | 
**Options** | [**ReadAudiencePreviewOptions**](ReadAudiencePreviewOptions.md) |  | 
**Status** | **string** | Status for the audience preview. | 
**Results** | [**List&lt;AudiencePreviewResult&gt;**](AudiencePreviewResult.md) | Sampled result membership for the audience preview. Only has a value if the status is &#39;COMPLETED&#39;. | [optional] 
**Size** | [**AudienceSize**](AudienceSize.md) |  | [optional] 
**FailureReason** | **string** | Explanation of why the audience preview failed. Only has a value if status is &#39;FAILED&#39;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

