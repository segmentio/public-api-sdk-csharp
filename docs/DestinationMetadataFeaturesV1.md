# Segment.PublicApi.Model.DestinationMetadataFeaturesV1
Represents features that a given Destination supports.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CloudModeInstances** | **string** | This Destination&#39;s support level for cloud mode instances. The values &#39;0&#39; and &#39;NONE&#39;, and &#39;1&#39; and &#39;SINGLE&#39; are equivalent. | [optional] 
**DeviceModeInstances** | **string** | This Destination&#39;s support level for device mode instances. Support for multiple device mode instances is currently not planned. The values &#39;0&#39; and &#39;NONE&#39;, and &#39;1&#39; and &#39;SINGLE&#39; are equivalent. | [optional] 
**Replay** | **bool** | Whether this Destination supports replays. | [optional] 
**BrowserUnbundling** | **bool** | Whether this Destination supports browser unbundling. | [optional] 
**BrowserUnbundlingPublic** | **bool** | Whether this Destination supports public browser unbundling. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

