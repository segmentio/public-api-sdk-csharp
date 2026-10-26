# Segment.PublicApi.Model.DestinationMetadataActionFieldV1
Represents a field used in configuring an action.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The primary key of the field. | 
**SortOrder** | **decimal** | The order this particular field is (used in the UI for displaying the fields in a specified order). | 
**FieldKey** | **string** | A unique machine-readable key for the field. Should ideally match the expected key in the action\\&#39;s API request. | 
**Label** | **string** | A human-readable label for this value. | 
**Type** | **string** | The data type for this value. | 
**Description** | **string** | A human-readable description of this value. You can use Markdown. | 
**Placeholder** | **string** | An example value displayed but not saved. | [optional] 
**DefaultValue** | **Object** | A default value that is saved the first time an action is created. | [optional] 
**Required** | **bool** | Whether this field is required. | 
**Multiple** | **bool** | Whether a user can provide multiples of this field. | 
**Choices** | **Object** | A list of machine-readable value/label pairs to populate a static dropdown. | [optional] 
**Dynamic** | **bool** | Whether this field should execute a dynamic request to fetch choices to populate a dropdown. When true, &#x60;choices&#x60; is ignored. | 
**AllowNull** | **bool** | Whether this field allows null values. | 
**Hidden** | **bool** | Whether the action field should be hidden or not. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

