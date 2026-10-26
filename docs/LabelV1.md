# Segment.PublicApi.Model.LabelV1
A label lets Workspace owners assign permissions to users, and grant these users access to groups.  A Workspace owner may use labels to grant users access to groups of resources.  When you add a label to a Source or Personas Spaces, any users granted access to that label gain access to those resources.  All Workspaces include labels for Dev (development) and Prod (production) environments. On top of those, Free and Team plan customers may create up to five labels.  Customers with the Enterprise pricing package may create an unlimited number of labels.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The key that represents the name of this label. | 
**Value** | **string** | The value associated with the key of this label. | 
**Description** | **string** | An optional description of the purpose of this label. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

