# Segment.PublicApi.Model.SourceMetadataV1
A website, server library, mobile SDK, or cloud application which can send data into Segment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id for this Source metadata in the Segment catalog.  Config API note: analogous to &#x60;name&#x60;. | 
**Name** | **string** | The user-friendly name of this Source.  Config API note: equal to &#x60;displayName&#x60;. | 
**Slug** | **string** | The slug that identifies this Source in the Segment app.  Config API note: equal to &#x60;name&#x60;. | 
**Description** | **string** | The description of this Source. | 
**Logos** | [**LogosBeta**](LogosBeta.md) |  | 
**Options** | [**List&lt;IntegrationOptionBeta&gt;**](IntegrationOptionBeta.md) | Options for this Source. | 
**Categories** | **List&lt;string&gt;** | A list of categories this Source belongs to. | 
**IsCloudEventSource** | **bool** | True if this is a Cloud Event Source. | 
**Status** | **string** | Support status of the Source. | 
**PartnerOwned** | **bool** | Partner Owned flag. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

