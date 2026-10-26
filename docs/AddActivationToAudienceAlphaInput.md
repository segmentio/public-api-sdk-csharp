# Segment.PublicApi.Model.AddActivationToAudienceAlphaInput
Input to create an activation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Determines whether an activation is enabled. | [optional] 
**PerformResync** | **bool** | Determines whether to perform a full resync upon creation. If true, the entire audience is resent to the Destination from scratch. If false, only future changes will be synced. | 
**ActivationType** | **string** | Determines when an event is sent to the Destination.  Possible values:  - **Audience Entered**: Sends an event when a profile or entity enters the audience. - **Audience Exited**: Sends an event when a profile or entity exits the audience. - **Audience Membership Changed**: Sends an event for both entries and exits. This does not apply to entities. - **Entity Added**: Sends an event when an entity is added to the audience. - **Entity Removed**: Sends an event when an entity is removed from the audience. - **Entity Values Changed**: Sends an event when an entity&#39;s property values change. Restricted to freshness-enabled Destinations. - **All Events**: Sends events for all trigger conditions (enters, exits, and entity value changes for freshness Destinations; enters and exits only for non-freshness Destinations).  Note that events are sent for the profile, unless the audience is a Linked Audience. In that case, events are sent for the target entity defined for that audience.  Activations on Warehouse Destinations support only track-based activation types. **Audience Membership Changed** is identify-based, so requests using it for a Warehouse Destination are rejected. Use **Audience Entered** or **Audience Exited** instead. | 
**ActivationName** | **string** | Activation name. For Warehouse Destinations, this is used as the table name. | 
**DisplayName** | **string** | Optional human-readable label for the activation. Only supported for Warehouse Destinations. When omitted, the activationName is used as the label. | [optional] 
**Personalization** | [**PersonalizationInput**](PersonalizationInput.md) |  | [optional] 
**DestinationMapping** | [**DestinationSubscriptionConfiguration**](DestinationSubscriptionConfiguration.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

