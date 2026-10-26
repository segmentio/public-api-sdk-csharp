# Segment.PublicApi.Model.UpdateTransformationV1Input
The input to update a Transformation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the Transformation. | [optional] 
**SourceId** | **string** | The optional Source to be associated with the Transformation. | [optional] 
**DestinationMetadataId** | **string** | The optional Destination metadata to be associated with the Transformation. | [optional] 
**Enabled** | **bool** | If the Transformation should be enabled. | [optional] 
**VarIf** | **string** | If statement ([FQL](https://segment.com/docs/config-api/fql/)) to match events.  For standard event matchers, use the following:  Track -\\&gt; \&quot;event&#x3D;&#39;\\&lt;eventName\\&gt;&#39;\&quot;  Identify -\\&gt; \&quot;type&#x3D;&#39;identify&#39;\&quot;  Group -\\&gt; \&quot;type&#x3D;&#39;group&#39;\&quot; | [optional] 
**Drop** | **bool** | Optional boolean value if the Transformation should drop the event entirely when the if statement matches, ignores all other transforms. | [optional] 
**NewEventName** | **string** | Optional new event name for renaming events. Works only for &#39;track&#39; event type. | [optional] 
**PropertyRenames** | [**List&lt;PropertyRenameV1&gt;**](PropertyRenameV1.md) | Optional array for renaming properties collected by your events. | [optional] 
**PropertyValueTransformations** | [**List&lt;PropertyValueTransformationV1&gt;**](PropertyValueTransformationV1.md) | Optional array for transforming properties and values collected by your events. Limited to 10 properties. | [optional] 
**FqlDefinedProperties** | [**List&lt;FQLDefinedPropertyV1&gt;**](FQLDefinedPropertyV1.md) | Optional array for updating properties defined in [FQL](https://segment.com/docs/config-api/fql/). Currently limited to 1 property. | [optional] 
**AllowProperties** | **List&lt;string&gt;** | Optional array for allowing properties from your events. | [optional] 
**HashPropertiesConfiguration** | [**HashPropertiesConfiguration**](HashPropertiesConfiguration.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

