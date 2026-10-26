# Segment.PublicApi.Model.DestinationMetadataV1
Represents a Destination within Segment.  A Destination is a target for Segment to forward data to, and represents a tool or storage Destination.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the Destination metadata.  Config API note: analogous to &#x60;name&#x60;. | 
**Name** | **string** | The user-friendly name of the Destination.  Config API note: equal to &#x60;displayName&#x60;. | 
**Description** | **string** | The description of the Destination. | 
**Slug** | **string** | The slug used to identify the Destination in the Segment app. | 
**Logos** | [**LogosBeta**](LogosBeta.md) |  | 
**Options** | [**List&lt;IntegrationOptionBeta&gt;**](IntegrationOptionBeta.md) | Options configured for the Destination. | 
**Status** | **string** | Support status of the Destination. | 
**PreviousNames** | **List&lt;string&gt;** | A list of names previously used by the Destination. | 
**Categories** | **List&lt;string&gt;** | A list of categories with which the Destination is associated. | 
**Website** | **string** | A website URL for this Destination. | 
**Components** | [**List&lt;DestinationMetadataComponentV1&gt;**](DestinationMetadataComponentV1.md) | A list of components this Destination provides. | 
**SupportedFeatures** | [**DestinationMetadataFeaturesV1**](DestinationMetadataFeaturesV1.md) |  | 
**SupportedMethods** | [**DestinationMetadataMethodsV1**](DestinationMetadataMethodsV1.md) |  | 
**SupportedPlatforms** | [**DestinationMetadataPlatformsV1**](DestinationMetadataPlatformsV1.md) |  | 
**Actions** | [**List&lt;DestinationMetadataActionV1&gt;**](DestinationMetadataActionV1.md) | Actions available for the Destination. | 
**Presets** | [**List&lt;DestinationMetadataSubscriptionPresetV1&gt;**](DestinationMetadataSubscriptionPresetV1.md) | Predefined Destination subscriptions that can optionally be applied when connecting a new instance of the Destination. | 
**Contacts** | [**List&lt;Contact&gt;**](Contact.md) | Contact info for Integration Owners. | [optional] 
**PartnerOwned** | **bool** | Partner Owned flag. | [optional] 
**SupportedRegions** | **List&lt;string&gt;** | A list of supported regions for this Destination. | [optional] 
**RegionEndpoints** | **List&lt;string&gt;** | The list of regional endpoints for this Destination. | [optional] 
**MultiInstanceSupportedVersion** | **string** | This Destination&#39;s support for multiple instance types. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

