# Segment.PublicApi.Model.PreviewDestinationFilterV1
A simplified Destination filter that includes the if and actions for a DestinationFilterV1.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarIf** | **string** | A FQL statement which determines if the provided filter&#39;s actions will apply to the provided JSON payload. The literal string \&quot;all\&quot; will result in this filter to all events. For guidance on using FQL, see the Segment documentation site. | 
**Actions** | [**List&lt;DestinationFilterActionV1&gt;**](DestinationFilterActionV1.md) | The filtering action to take on events that match the \&quot;if\&quot; statement. Action types must be one of: \&quot;drop\&quot;, \&quot;allow_properties\&quot;, \&quot;drop_properties\&quot; or \&quot;sample\&quot;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

