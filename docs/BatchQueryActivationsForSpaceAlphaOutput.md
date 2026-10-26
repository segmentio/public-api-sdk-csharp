# Segment.PublicApi.Model.BatchQueryActivationsForSpaceAlphaOutput
Output for listing activations in bulk across many audiences.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Activations** | [**List&lt;ActivationOutput&gt;**](ActivationOutput.md) | Activation results across all valid requested audiences. | 
**Errors** | [**List&lt;ErrorsInner&gt;**](ErrorsInner.md) | Audience IDs from the request that could not be resolved, with why - for example not found, or wrong space. When &#x60;audienceIds&#x60; was omitted from the request (space-scan mode), this never contains a caller-supplied bad id - there isn&#39;t one to be wrong - but it can still contain per-activation hydration failures, same as the &#x60;audienceIds&#x60;-provided path. | 
**Pagination** | [**PaginationOutput**](PaginationOutput.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

