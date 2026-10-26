# Segment.PublicApi.Model.UpdateActivationForAudienceAlphaInput
Input to update an activation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Determines whether an activation is enabled. | [optional] 
**ActivationName** | **string** | Activation name. For Warehouse Destinations, this is used as the table name. Omit this field to leave the name unchanged. An empty string is ignored rather than applied. | [optional] 
**DisplayName** | **string** | Optional human-readable label for the activation. Only supported for Warehouse Destinations. Send null to clear. When omitted, the activationName is used as the label. | [optional] 
**Personalization** | [**PersonalizationInput**](PersonalizationInput.md) |  | [optional] 
**DestinationMapping** | [**DestinationSubscriptionConfiguration**](DestinationSubscriptionConfiguration.md) |  | [optional] 
**PerformResync** | **bool** | Determines whether to perform a full resync after the update. If true, the entire audience is resent to the Destination using the updated configuration. If false, the update applies only to future syncs. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

