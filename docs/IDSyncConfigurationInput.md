# Segment.PublicApi.Model.IDSyncConfigurationInput
The identifier sync configuration input.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExternalId** | **string** | The id type to sync. Examples: user_id, email, anonymous_id. | 
**Strategy** | **string** | The rule for selecting which identifiers to sync from a profile.  Possible values: first: Syncs only the oldest recorded value. last: Syncs only the most recently updated value. all: Syncs every value found on the profile (sends multiple events). | 
**MapTo** | **string** | Optional destination-specific identifier to map to (for example, \&quot;Email_Address_c\&quot;). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

