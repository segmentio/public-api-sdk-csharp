# Segment.PublicApi.Model.AudienceSummaryWithAudienceTypeAndLookback

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ComputeCadence** | [**AudienceComputeCadence**](AudienceComputeCadence.md) |  | 
**Size** | [**AudienceSize**](AudienceSize.md) |  | [optional] 
**Options** | [**AudienceOptionsWithLookback**](AudienceOptionsWithLookback.md) |  | [optional] 
**Schedules** | [**List&lt;AudienceSchedule&gt;**](AudienceSchedule.md) | List of schedules for the audience. | [optional] 
**Id** | **string** | Audience id. | 
**SpaceId** | **string** | Space id for the audience. | 
**Name** | **string** | Name of the audience. | 
**Description** | **string** | Description of the audience. | [optional] 
**Key** | **string** | Key for the audience. | 
**Enabled** | **bool** | Enabled/disabled status for the audience. | 
**Definition** | [**AudienceDefinition**](AudienceDefinition.md) |  | 
**Status** | **string** | Status for the audience.  Possible values: Backfilling, Computing, Disabled, Error, Failed, Live, Locked, Not Computing, Preparing, Awaiting Destinations. | [optional] 
**CreatedBy** | **string** | User id who created the audience. | 
**UpdatedBy** | **string** | User id who last updated the audience. | 
**CreatedAt** | **string** | Date the audience was created. | 
**UpdatedAt** | **string** | Date the audience was last updated. | 
**AudienceType** | **string** | Denotes the type of audience product. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

