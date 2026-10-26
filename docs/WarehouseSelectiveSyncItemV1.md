# Segment.PublicApi.Model.WarehouseSelectiveSyncItemV1
Represents an entry in the Warehouse Selective Sync schema for a Warehouse and Source pair.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceId** | **string** | The Source id attached to this Warehouse. | 
**Collection** | **string** | The collection within the Source. | 
**WarehouseId** | **string** | The id of the Warehouse this sync belongs to. | 
**Enabled** | **bool** | Whether this Selective Sync item is enabled. | 
**Properties** | **Dictionary&lt;string, Object&gt;** | A map that contains the properties within the collection to which the Warehouse should sync. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

