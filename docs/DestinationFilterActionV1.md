# Segment.PublicApi.Model.DestinationFilterActionV1
Represents a Destination filter action.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The kind of Transformation to apply to any matched properties. | 
**Fields** | **Dictionary&lt;string, Object&gt;** | A dictionary of paths to object keys that this filter applies to.  The literal string &#39;&#39; represents the top level of the object. | [optional] 
**Percent** | **decimal** | A decimal between 0 and 1 used for &#39;sample&#39; type events and influences the likelihood of sampling to occur. | [optional] 
**Path** | **string** | The JSON path to a property within a payload object from which Segment generates a deterministic sampling rate. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

