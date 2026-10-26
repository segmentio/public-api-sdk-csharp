# Segment.PublicApi.Model.Config1
Config contains interval duration in case of periodic or day and hours in case of specific_days. Empty if strategy is MANUAL.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Interval** | **string** | Duration is specified as a string, EG: 15m, 3h25m30s. | 
**Days** | **List&lt;decimal&gt;** | Days of the week. | 
**Hours** | **List&lt;decimal&gt;** | Hours of the day. | 
**Timezone** | **string** | Timezone respected by the cron string. Format must be in IANA Timezone Identifier. Example: &#39;America/Los_Angeles&#39;. | 
**Spec** | **string** | 5 field cron string expression. The cron expression must be larger than 15 minutes. | 
**JobId** | **string** | The dbt Cloud job used to trigger a sync for a Reverse ETL Connection. | 
**AccountId** | **string** | The dbt Cloud account where the job belongs to. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

