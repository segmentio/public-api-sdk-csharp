/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 54.2.0
 * Contact: friends@segment.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Segment.PublicApi.Client.OpenAPIDateConverter;

namespace Segment.PublicApi.Model
{
    /// <summary>
    /// Represents a Destination within Segment.  A Destination is a target for Segment to forward data to, and represents a tool or storage Destination.
    /// </summary>
    [DataContract(Name = "DestinationMetadataV1")]
    public partial class DestinationMetadataV1 : IEquatable<DestinationMetadataV1>, IValidatableObject
    {
        /// <summary>
        /// Support status of the Destination.
        /// </summary>
        /// <value>Support status of the Destination.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum DEPRECATED for value: DEPRECATED
            /// </summary>
            [EnumMember(Value = "DEPRECATED")]
            DEPRECATED = 1,

            /// <summary>
            /// Enum PRIVATEBETA for value: PRIVATE_BETA
            /// </summary>
            [EnumMember(Value = "PRIVATE_BETA")]
            PRIVATEBETA = 2,

            /// <summary>
            /// Enum PRIVATEBUILDING for value: PRIVATE_BUILDING
            /// </summary>
            [EnumMember(Value = "PRIVATE_BUILDING")]
            PRIVATEBUILDING = 3,

            /// <summary>
            /// Enum PRIVATESUBMITTED for value: PRIVATE_SUBMITTED
            /// </summary>
            [EnumMember(Value = "PRIVATE_SUBMITTED")]
            PRIVATESUBMITTED = 4,

            /// <summary>
            /// Enum PUBLIC for value: PUBLIC
            /// </summary>
            [EnumMember(Value = "PUBLIC")]
            PUBLIC = 5,

            /// <summary>
            /// Enum PUBLICBETA for value: PUBLIC_BETA
            /// </summary>
            [EnumMember(Value = "PUBLIC_BETA")]
            PUBLICBETA = 6,

            /// <summary>
            /// Enum UNAVAILABLE for value: UNAVAILABLE
            /// </summary>
            [EnumMember(Value = "UNAVAILABLE")]
            UNAVAILABLE = 7
        }


        /// <summary>
        /// Support status of the Destination.
        /// </summary>
        /// <value>Support status of the Destination.</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationMetadataV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DestinationMetadataV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationMetadataV1" /> class.
        /// </summary>
        /// <param name="id">The id of the Destination metadata.  Config API note: analogous to &#x60;name&#x60;. (required).</param>
        /// <param name="name">The user-friendly name of the Destination.  Config API note: equal to &#x60;displayName&#x60;. (required).</param>
        /// <param name="description">The description of the Destination. (required).</param>
        /// <param name="slug">The slug used to identify the Destination in the Segment app. (required).</param>
        /// <param name="logos">logos (required).</param>
        /// <param name="options">Options configured for the Destination. (required).</param>
        /// <param name="status">Support status of the Destination. (required).</param>
        /// <param name="previousNames">A list of names previously used by the Destination. (required).</param>
        /// <param name="categories">A list of categories with which the Destination is associated. (required).</param>
        /// <param name="website">A website URL for this Destination. (required).</param>
        /// <param name="components">A list of components this Destination provides. (required).</param>
        /// <param name="supportedFeatures">supportedFeatures (required).</param>
        /// <param name="supportedMethods">supportedMethods (required).</param>
        /// <param name="supportedPlatforms">supportedPlatforms (required).</param>
        /// <param name="actions">Actions available for the Destination. (required).</param>
        /// <param name="presets">Predefined Destination subscriptions that can optionally be applied when connecting a new instance of the Destination. (required).</param>
        /// <param name="contacts">Contact info for Integration Owners..</param>
        /// <param name="partnerOwned">Partner Owned flag..</param>
        /// <param name="supportedRegions">A list of supported regions for this Destination..</param>
        /// <param name="regionEndpoints">The list of regional endpoints for this Destination..</param>
        public DestinationMetadataV1(string id = default(string), string name = default(string), string description = default(string), string slug = default(string), LogosBeta logos = default(LogosBeta), List<IntegrationOptionBeta> options = default(List<IntegrationOptionBeta>), StatusEnum status = default(StatusEnum), List<string> previousNames = default(List<string>), List<string> categories = default(List<string>), string website = default(string), List<DestinationMetadataComponentV1> components = default(List<DestinationMetadataComponentV1>), DestinationMetadataFeaturesV1 supportedFeatures = default(DestinationMetadataFeaturesV1), DestinationMetadataMethodsV1 supportedMethods = default(DestinationMetadataMethodsV1), DestinationMetadataPlatformsV1 supportedPlatforms = default(DestinationMetadataPlatformsV1), List<DestinationMetadataActionV1> actions = default(List<DestinationMetadataActionV1>), List<DestinationMetadataSubscriptionPresetV1> presets = default(List<DestinationMetadataSubscriptionPresetV1>), List<Contact> contacts = default(List<Contact>), bool partnerOwned = default(bool), List<string> supportedRegions = default(List<string>), List<string> regionEndpoints = default(List<string>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for DestinationMetadataV1 and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for DestinationMetadataV1 and cannot be null");
            }
            this.Name = name;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for DestinationMetadataV1 and cannot be null");
            }
            this.Description = description;
            // to ensure "slug" is required (not null)
            if (slug == null)
            {
                throw new ArgumentNullException("slug is a required property for DestinationMetadataV1 and cannot be null");
            }
            this.Slug = slug;
            // to ensure "logos" is required (not null)
            if (logos == null)
            {
                throw new ArgumentNullException("logos is a required property for DestinationMetadataV1 and cannot be null");
            }
            this.Logos = logos;
            // to ensure "options" is required (not null)
            if (options == null)
            {
                throw new ArgumentNullException("options is a required property for DestinationMetadataV1 and cannot be null");
            }
            this.Options = options;
            this.Status = status;
            // to ensure "previousNames" is required (not null)
            if (previousNames == null)
            {
                throw new ArgumentNullException("previousNames is a required property for DestinationMetadataV1 and cannot be null");
            }
            this.PreviousNames = previousNames;
            // to ensure "categories" is required (not null)
            if (categories == null)
            {
                throw new ArgumentNullException("categories is a required property for DestinationMetadataV1 and cannot be null");
            }
            this.Categories = categories;
            // to ensure "website" is required (not null)
            if (website == null)
            {
                throw new ArgumentNullException("website is a required property for DestinationMetadataV1 and cannot be null");
            }
            this.Website = website;
            // to ensure "components" is required (not null)
            if (components == null)
            {
                throw new ArgumentNullException("components is a required property for DestinationMetadataV1 and cannot be null");
            }
            this.Components = components;
            // to ensure "supportedFeatures" is required (not null)
            if (supportedFeatures == null)
            {
                throw new ArgumentNullException("supportedFeatures is a required property for DestinationMetadataV1 and cannot be null");
            }
            this.SupportedFeatures = supportedFeatures;
            // to ensure "supportedMethods" is required (not null)
            if (supportedMethods == null)
            {
                throw new ArgumentNullException("supportedMethods is a required property for DestinationMetadataV1 and cannot be null");
            }
            this.SupportedMethods = supportedMethods;
            // to ensure "supportedPlatforms" is required (not null)
            if (supportedPlatforms == null)
            {
                throw new ArgumentNullException("supportedPlatforms is a required property for DestinationMetadataV1 and cannot be null");
            }
            this.SupportedPlatforms = supportedPlatforms;
            // to ensure "actions" is required (not null)
            if (actions == null)
            {
                throw new ArgumentNullException("actions is a required property for DestinationMetadataV1 and cannot be null");
            }
            this.Actions = actions;
            // to ensure "presets" is required (not null)
            if (presets == null)
            {
                throw new ArgumentNullException("presets is a required property for DestinationMetadataV1 and cannot be null");
            }
            this.Presets = presets;
            this.Contacts = contacts;
            this.PartnerOwned = partnerOwned;
            this.SupportedRegions = supportedRegions;
            this.RegionEndpoints = regionEndpoints;
        }

        /// <summary>
        /// The id of the Destination metadata.  Config API note: analogous to &#x60;name&#x60;.
        /// </summary>
        /// <value>The id of the Destination metadata.  Config API note: analogous to &#x60;name&#x60;.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The user-friendly name of the Destination.  Config API note: equal to &#x60;displayName&#x60;.
        /// </summary>
        /// <value>The user-friendly name of the Destination.  Config API note: equal to &#x60;displayName&#x60;.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The description of the Destination.
        /// </summary>
        /// <value>The description of the Destination.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The slug used to identify the Destination in the Segment app.
        /// </summary>
        /// <value>The slug used to identify the Destination in the Segment app.</value>
        [DataMember(Name = "slug", IsRequired = true, EmitDefaultValue = true)]
        public string Slug { get; set; }

        /// <summary>
        /// Gets or Sets Logos
        /// </summary>
        [DataMember(Name = "logos", IsRequired = true, EmitDefaultValue = true)]
        public LogosBeta Logos { get; set; }

        /// <summary>
        /// Options configured for the Destination.
        /// </summary>
        /// <value>Options configured for the Destination.</value>
        [DataMember(Name = "options", IsRequired = true, EmitDefaultValue = true)]
        public List<IntegrationOptionBeta> Options { get; set; }

        /// <summary>
        /// A list of names previously used by the Destination.
        /// </summary>
        /// <value>A list of names previously used by the Destination.</value>
        [DataMember(Name = "previousNames", IsRequired = true, EmitDefaultValue = true)]
        public List<string> PreviousNames { get; set; }

        /// <summary>
        /// A list of categories with which the Destination is associated.
        /// </summary>
        /// <value>A list of categories with which the Destination is associated.</value>
        [DataMember(Name = "categories", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// A website URL for this Destination.
        /// </summary>
        /// <value>A website URL for this Destination.</value>
        [DataMember(Name = "website", IsRequired = true, EmitDefaultValue = true)]
        public string Website { get; set; }

        /// <summary>
        /// A list of components this Destination provides.
        /// </summary>
        /// <value>A list of components this Destination provides.</value>
        [DataMember(Name = "components", IsRequired = true, EmitDefaultValue = true)]
        public List<DestinationMetadataComponentV1> Components { get; set; }

        /// <summary>
        /// Gets or Sets SupportedFeatures
        /// </summary>
        [DataMember(Name = "supportedFeatures", IsRequired = true, EmitDefaultValue = true)]
        public DestinationMetadataFeaturesV1 SupportedFeatures { get; set; }

        /// <summary>
        /// Gets or Sets SupportedMethods
        /// </summary>
        [DataMember(Name = "supportedMethods", IsRequired = true, EmitDefaultValue = true)]
        public DestinationMetadataMethodsV1 SupportedMethods { get; set; }

        /// <summary>
        /// Gets or Sets SupportedPlatforms
        /// </summary>
        [DataMember(Name = "supportedPlatforms", IsRequired = true, EmitDefaultValue = true)]
        public DestinationMetadataPlatformsV1 SupportedPlatforms { get; set; }

        /// <summary>
        /// Actions available for the Destination.
        /// </summary>
        /// <value>Actions available for the Destination.</value>
        [DataMember(Name = "actions", IsRequired = true, EmitDefaultValue = true)]
        public List<DestinationMetadataActionV1> Actions { get; set; }

        /// <summary>
        /// Predefined Destination subscriptions that can optionally be applied when connecting a new instance of the Destination.
        /// </summary>
        /// <value>Predefined Destination subscriptions that can optionally be applied when connecting a new instance of the Destination.</value>
        [DataMember(Name = "presets", IsRequired = true, EmitDefaultValue = true)]
        public List<DestinationMetadataSubscriptionPresetV1> Presets { get; set; }

        /// <summary>
        /// Contact info for Integration Owners.
        /// </summary>
        /// <value>Contact info for Integration Owners.</value>
        [DataMember(Name = "contacts", EmitDefaultValue = false)]
        public List<Contact> Contacts { get; set; }

        /// <summary>
        /// Partner Owned flag.
        /// </summary>
        /// <value>Partner Owned flag.</value>
        [DataMember(Name = "partnerOwned", EmitDefaultValue = true)]
        public bool PartnerOwned { get; set; }

        /// <summary>
        /// A list of supported regions for this Destination.
        /// </summary>
        /// <value>A list of supported regions for this Destination.</value>
        [DataMember(Name = "supportedRegions", EmitDefaultValue = false)]
        public List<string> SupportedRegions { get; set; }

        /// <summary>
        /// The list of regional endpoints for this Destination.
        /// </summary>
        /// <value>The list of regional endpoints for this Destination.</value>
        [DataMember(Name = "regionEndpoints", EmitDefaultValue = false)]
        public List<string> RegionEndpoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinationMetadataV1 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Logos: ").Append(Logos).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PreviousNames: ").Append(PreviousNames).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  Components: ").Append(Components).Append("\n");
            sb.Append("  SupportedFeatures: ").Append(SupportedFeatures).Append("\n");
            sb.Append("  SupportedMethods: ").Append(SupportedMethods).Append("\n");
            sb.Append("  SupportedPlatforms: ").Append(SupportedPlatforms).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Presets: ").Append(Presets).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  PartnerOwned: ").Append(PartnerOwned).Append("\n");
            sb.Append("  SupportedRegions: ").Append(SupportedRegions).Append("\n");
            sb.Append("  RegionEndpoints: ").Append(RegionEndpoints).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DestinationMetadataV1);
        }

        /// <summary>
        /// Returns true if DestinationMetadataV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinationMetadataV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinationMetadataV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && 
                (
                    this.Logos == input.Logos ||
                    (this.Logos != null &&
                    this.Logos.Equals(input.Logos))
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.PreviousNames == input.PreviousNames ||
                    this.PreviousNames != null &&
                    input.PreviousNames != null &&
                    this.PreviousNames.SequenceEqual(input.PreviousNames)
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.Website == input.Website ||
                    (this.Website != null &&
                    this.Website.Equals(input.Website))
                ) && 
                (
                    this.Components == input.Components ||
                    this.Components != null &&
                    input.Components != null &&
                    this.Components.SequenceEqual(input.Components)
                ) && 
                (
                    this.SupportedFeatures == input.SupportedFeatures ||
                    (this.SupportedFeatures != null &&
                    this.SupportedFeatures.Equals(input.SupportedFeatures))
                ) && 
                (
                    this.SupportedMethods == input.SupportedMethods ||
                    (this.SupportedMethods != null &&
                    this.SupportedMethods.Equals(input.SupportedMethods))
                ) && 
                (
                    this.SupportedPlatforms == input.SupportedPlatforms ||
                    (this.SupportedPlatforms != null &&
                    this.SupportedPlatforms.Equals(input.SupportedPlatforms))
                ) && 
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    input.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
                ) && 
                (
                    this.Presets == input.Presets ||
                    this.Presets != null &&
                    input.Presets != null &&
                    this.Presets.SequenceEqual(input.Presets)
                ) && 
                (
                    this.Contacts == input.Contacts ||
                    this.Contacts != null &&
                    input.Contacts != null &&
                    this.Contacts.SequenceEqual(input.Contacts)
                ) && 
                (
                    this.PartnerOwned == input.PartnerOwned ||
                    this.PartnerOwned.Equals(input.PartnerOwned)
                ) && 
                (
                    this.SupportedRegions == input.SupportedRegions ||
                    this.SupportedRegions != null &&
                    input.SupportedRegions != null &&
                    this.SupportedRegions.SequenceEqual(input.SupportedRegions)
                ) && 
                (
                    this.RegionEndpoints == input.RegionEndpoints ||
                    this.RegionEndpoints != null &&
                    input.RegionEndpoints != null &&
                    this.RegionEndpoints.SequenceEqual(input.RegionEndpoints)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Slug != null)
                {
                    hashCode = (hashCode * 59) + this.Slug.GetHashCode();
                }
                if (this.Logos != null)
                {
                    hashCode = (hashCode * 59) + this.Logos.GetHashCode();
                }
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.PreviousNames != null)
                {
                    hashCode = (hashCode * 59) + this.PreviousNames.GetHashCode();
                }
                if (this.Categories != null)
                {
                    hashCode = (hashCode * 59) + this.Categories.GetHashCode();
                }
                if (this.Website != null)
                {
                    hashCode = (hashCode * 59) + this.Website.GetHashCode();
                }
                if (this.Components != null)
                {
                    hashCode = (hashCode * 59) + this.Components.GetHashCode();
                }
                if (this.SupportedFeatures != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedFeatures.GetHashCode();
                }
                if (this.SupportedMethods != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedMethods.GetHashCode();
                }
                if (this.SupportedPlatforms != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedPlatforms.GetHashCode();
                }
                if (this.Actions != null)
                {
                    hashCode = (hashCode * 59) + this.Actions.GetHashCode();
                }
                if (this.Presets != null)
                {
                    hashCode = (hashCode * 59) + this.Presets.GetHashCode();
                }
                if (this.Contacts != null)
                {
                    hashCode = (hashCode * 59) + this.Contacts.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PartnerOwned.GetHashCode();
                if (this.SupportedRegions != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedRegions.GetHashCode();
                }
                if (this.RegionEndpoints != null)
                {
                    hashCode = (hashCode * 59) + this.RegionEndpoints.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}