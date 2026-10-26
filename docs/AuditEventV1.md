# Segment.PublicApi.Model.AuditEventV1
Represents an Audit Trail event.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for this audit trail event. | 
**Timestamp** | **string** | The timestamp of this event in ISO-8601 format. | 
**Type** | **string** | The type of this event. | 
**Actor** | **string** | The user or API token that triggered this event. | 
**ActorEmail** | **string** | The email of the user that triggered this event. | [optional] 
**ResourceId** | **string** | The identifier of the resource affected by this event. | 
**ResourceType** | **string** | The kind of resource affected by this event. | 
**ResourceName** | **string** | The name of the resource affected by this event. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

