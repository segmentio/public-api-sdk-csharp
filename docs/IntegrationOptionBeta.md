# Segment.PublicApi.Model.IntegrationOptionBeta
Describes an Integration option field required to set up a Segment Integration such as Sources, Destinations, or warehouses.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name identifying this option in the context of a Segment Integration. | 
**Type** | **string** | Defines the type for this option in the schema. Types are most commonly strings, but may also represent other primitive types, such as booleans, and numbers, as well as complex types, such as objects and arrays. | 
**Required** | **bool** | Whether this is a required option when setting up the Integration. | 
**Description** | **string** | An optional short text description of the field. | [optional] 
**DefaultValue** | **Object** | An optional default value for the field. | [optional] 
**Label** | **string** | An optional label for this field. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

