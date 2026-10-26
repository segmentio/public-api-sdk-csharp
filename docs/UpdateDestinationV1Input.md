# Segment.PublicApi.Model.UpdateDestinationV1Input
Updates a single Destination by its id.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Defines the display name of the Destination.  Config API note: equal to &#x60;displayName&#x60;. | [optional] 
**Enabled** | **bool** | Whether this Destination should receive data. | [optional] 
**Settings** | **Dictionary&lt;string, Object&gt;** | An optional object that contains settings for the Destination based on the \&quot;required\&quot; and \&quot;advanced\&quot; settings present in the Destination metadata.  Config API note: equal to &#x60;config&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

