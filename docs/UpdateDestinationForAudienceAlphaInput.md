# Segment.PublicApi.Model.UpdateDestinationForAudienceAlphaInput
Input to Update a Destination for an Audience. At least one of idSyncConfiguration or connectionSettings must be supplied, otherwise the request returns a 400 error.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdSyncConfiguration** | [**List&lt;IDSyncConfigurationInput&gt;**](IDSyncConfigurationInput.md) | Identifier sync configuration - array of external IDs to sync with their strategies. Maximum 5 items allowed. The supplied array replaces the entire stored configuration, so include every external id that should remain. Omitting mapTo on an entry clears any value stored for it. An empty array is treated the same as omitting the field and leaves the stored configuration unchanged. | [optional] 
**ConnectionSettings** | **Object** | The settings that a Destination requires to create audiences on a third-party platform. The supplied object replaces the stored settings outright, so include every setting that should remain. Settings that are omitted are removed. An empty object is treated the same as omitting the field and leaves the stored settings unchanged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

