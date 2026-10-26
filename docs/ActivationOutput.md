# Segment.PublicApi.Model.ActivationOutput
A class that encapsulates the complete activation output with full details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The activation id. | 
**Enabled** | **bool** | Activation Enabled Status. | 
**WorkspaceId** | **string** | The WORKSPACE id. | 
**SpaceId** | **string** | The space id. | 
**AudienceId** | **string** | The audience id. | 
**ConnectionId** | **string** | The connection id. | 
**ActivationType** | **string** | Determines when an event is sent to the Destination.  Possible values: - **Audience Entered**: Sends an event when a profile or entity enters the audience. - **Audience Exited**: Sends an event when a profile or entity exits the audience. - **Audience Membership Changed**: Sends an event for both entries and exits. This does not apply to entities. - **Entity Added**: Sends an event when an entity is added to the audience. - **Entity Removed**: Sends an event when an entity is removed from the audience. - **Entity Values Changed**: Sends an event when an entity&#39;s property values change. Restricted to freshness-enabled Destinations. - **All Events**: Sends events for all trigger conditions (enters, exits, and entity value changes for freshness Destinations; enters and exits only for non-freshness Destinations).  Note that events are sent for the profile, unless the audience is a Linked Audience. In that case, events are sent for the target entity defined for that audience. | 
**ActivationName** | **string** | Activation name. For Warehouse Destinations, this is the table name. | 
**DisplayName** | **string** | Human-readable label for the activation. Only present for Warehouse Destinations that have a display name configured. When null, the activationName serves as the label. | [optional] 
**Personalization** | [**PersonalizationOutput**](PersonalizationOutput.md) |  | 
**DestinationMapping** | [**DestinationSubscriptionConfiguration**](DestinationSubscriptionConfiguration.md) |  | [optional] 
**PerformResync** | **bool** | Indicates if a full resync is currently pending or in progress. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

