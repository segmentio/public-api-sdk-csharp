# Segment.PublicApi.Model.CancelReverseETLSyncForModelOutput
CancelReverseETLSyncForModelOutput either will return an error or a \"CANCELLING\" status.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModelId** | **string** | The id of the Model. | 
**SyncId** | **string** | The id of the Sync. | 
**ErrorCode** | **string** | A place holder for a machine-friendly category for an error, if applicable. - \&quot;SyncAlreadyCanceled\&quot; - \&quot;SyncFinishedCannotCancel\&quot; | [optional] 
**ErrorMessage** | **string** | A place holder for a human-readable description of the error, if applicable. - \&quot;sync already canceled\&quot; - \&quot;sync already finished\&quot;. | [optional] 
**Status** | **string** | If no error, status will be CANCELLING, as the extract/load might take some time to cancel. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

