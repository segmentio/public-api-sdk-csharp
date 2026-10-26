# Segment.PublicApi.Model.UsersPerSourceSnapshotV1
A snapshot of MTU metrics for a given Source within the given usage period.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceId** | **string** | The Source id. | 
**PeriodStart** | **decimal** | The start of the usage period, in unix time (seconds since epoch). | 
**PeriodEnd** | **decimal** | The end of the usage period, in unix time (seconds since epoch). | 
**Anonymous** | **string** | A bigint of the number of anonymous users in this snapshot. | 
**AnonymousIdentified** | **string** | A bigint of the number of anonymous identified users in this snapshot. | 
**Identified** | **string** | A bigint of the number of identified users in this snapshot. | 
**NeverIdentified** | **string** | A bigint of the number of never identified users in this snapshot. | 
**Timestamp** | **string** | The timestamp of this snapshot within the billing cycle, in the ISO-8601 format. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

