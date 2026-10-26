# Segment.PublicApi.Model.ComputedTraitSummary
Defines a Computed trait.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Computed trait id. | 
**SpaceId** | **string** | Space id for the computed trait. | 
**Name** | **string** | Name of the computed trait. | 
**Description** | **string** | Description of the computed trait. | [optional] 
**Key** | **string** | Key for the computed trait. | 
**Enabled** | **bool** | Enabled/disabled status for the computed trait. | 
**Definition** | [**ComputedTraitsDefinition**](ComputedTraitsDefinition.md) |  | 
**Status** | **string** | Status for the computed trait.  Possible values: Backfilling, Computing, Failed, Live, Awaiting Destinations, Disabled. | [optional] 
**CreatedBy** | **string** | User id who created the computed trait. | 
**UpdatedBy** | **string** | User id who last updated the computed trait. | 
**CreatedAt** | **string** | The timestamp of the computed trait&#39;s creation. | 
**UpdatedAt** | **string** | The timestamp of the computed trait&#39;s last change. | 
**Options** | [**TraitOptions**](TraitOptions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

