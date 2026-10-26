# Segment.PublicApi.Model.DeliveryOverviewDestinationFilterBy
The `DeliveryOverviewDestinationFilterBy` object is a map of the filterable fields and their values.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiscardReason** | **List&lt;string&gt;** | A list of strings of discard reasons.  See [Discard Record Documentation](https://segment.com/docs/connections/delivery-overview/#troubleshooting) for valid error codes. | [optional] 
**EventName** | **List&lt;string&gt;** | A list of strings of event names. | [optional] 
**EventType** | **List&lt;string&gt;** | A list of strings of event types. Valid options are: &#x60;alias&#x60;, &#x60;group&#x60;, &#x60;identify&#x60;, &#x60;page&#x60;, &#x60;screen&#x60;, and &#x60;track&#x60;. | [optional] 
**AppVersion** | **List&lt;string&gt;** | A list of strings of app versions. | [optional] 
**SubscriptionId** | **List&lt;string&gt;** | A list of strings of subscription IDs for Actions Destinations. | [optional] 
**ActivationId** | **List&lt;string&gt;** | A list of strings of event context IDs from a Linked Audience mapping/activation. | [optional] 
**AudienceId** | **List&lt;string&gt;** | A list of strings of audience IDs for a Linked Audience. | [optional] 
**SpaceId** | **List&lt;string&gt;** | A list of strings of space IDs for a Linked Audience. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

