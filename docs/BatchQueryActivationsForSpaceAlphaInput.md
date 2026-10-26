# Segment.PublicApi.Model.BatchQueryActivationsForSpaceAlphaInput
Input to list activations in bulk across many audiences in one call (space-level read). Intended for callers pulling activation metadata for many audiences on a recurring schedule, to avoid one request per audience against the per-space rate limit.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AudienceIds** | **List&lt;string&gt;** | Audience IDs to list activations for. Max 100 IDs per call. Duplicates are de-duplicated server-side but still count toward the cap.  Omit (or pass an empty array) to scan every audience in the space instead - see the &#x60;pagination&#x60; doc below for how that changes what a \&quot;page\&quot; means. Omitting this list is materially higher latency per call than a scoped batch, since each page has to enumerate audiences before it can look up their activations. | [optional] 
**Pagination** | [**PaginationInput**](PaginationInput.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

