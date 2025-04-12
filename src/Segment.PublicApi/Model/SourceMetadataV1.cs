/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.2.0
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
    /// A website, server library, mobile SDK, or cloud application which can send data into Segment.
    /// </summary>
    [DataContract(Name = "SourceMetadataV1")]
    public partial class SourceMetadataV1 : IEquatable<SourceMetadataV1>, IValidatableObject
    {
        /// <summary>
        /// Support status of the Source.
        /// </summary>
        /// <value>Support status of the Source.</value>
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
        /// Support status of the Source.
        /// </summary>
        /// <value>Support status of the Source.</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceMetadataV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SourceMetadataV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceMetadataV1" /> class.
        /// </summary>
        /// <param name="id">The id for this Source metadata in the Segment catalog.  Config API note: analogous to &#x60;name&#x60;. (required).</param>
        /// <param name="name">The user-friendly name of this Source.  Config API note: equal to &#x60;displayName&#x60;. (required).</param>
        /// <param name="slug">The slug that identifies this Source in the Segment app.  Config API note: equal to &#x60;name&#x60;. (required).</param>
        /// <param name="description">The description of this Source. (required).</param>
        /// <param name="logos">logos (required).</param>
        /// <param name="options">Options for this Source. (required).</param>
        /// <param name="categories">A list of categories this Source belongs to. (required).</param>
        /// <param name="isCloudEventSource">True if this is a Cloud Event Source. (required).</param>
        /// <param name="status">Support status of the Source. (required).</param>
        /// <param name="partnerOwned">Partner Owned flag..</param>
        public SourceMetadataV1(string id = default(string), string name = default(string), string slug = default(string), string description = default(string), LogosBeta logos = default(LogosBeta), List<IntegrationOptionBeta> options = default(List<IntegrationOptionBeta>), List<string> categories = default(List<string>), bool isCloudEventSource = default(bool), StatusEnum status = default(StatusEnum), bool partnerOwned = default(bool))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for SourceMetadataV1 and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for SourceMetadataV1 and cannot be null");
            }
            this.Name = name;
            // to ensure "slug" is required (not null)
            if (slug == null)
            {
                throw new ArgumentNullException("slug is a required property for SourceMetadataV1 and cannot be null");
            }
            this.Slug = slug;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for SourceMetadataV1 and cannot be null");
            }
            this.Description = description;
            // to ensure "logos" is required (not null)
            if (logos == null)
            {
                throw new ArgumentNullException("logos is a required property for SourceMetadataV1 and cannot be null");
            }
            this.Logos = logos;
            // to ensure "options" is required (not null)
            if (options == null)
            {
                throw new ArgumentNullException("options is a required property for SourceMetadataV1 and cannot be null");
            }
            this.Options = options;
            // to ensure "categories" is required (not null)
            if (categories == null)
            {
                throw new ArgumentNullException("categories is a required property for SourceMetadataV1 and cannot be null");
            }
            this.Categories = categories;
            this.IsCloudEventSource = isCloudEventSource;
            this.Status = status;
            this.PartnerOwned = partnerOwned;
        }

        /// <summary>
        /// The id for this Source metadata in the Segment catalog.  Config API note: analogous to &#x60;name&#x60;.
        /// </summary>
        /// <value>The id for this Source metadata in the Segment catalog.  Config API note: analogous to &#x60;name&#x60;.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The user-friendly name of this Source.  Config API note: equal to &#x60;displayName&#x60;.
        /// </summary>
        /// <value>The user-friendly name of this Source.  Config API note: equal to &#x60;displayName&#x60;.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The slug that identifies this Source in the Segment app.  Config API note: equal to &#x60;name&#x60;.
        /// </summary>
        /// <value>The slug that identifies this Source in the Segment app.  Config API note: equal to &#x60;name&#x60;.</value>
        [DataMember(Name = "slug", IsRequired = true, EmitDefaultValue = true)]
        public string Slug { get; set; }

        /// <summary>
        /// The description of this Source.
        /// </summary>
        /// <value>The description of this Source.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Logos
        /// </summary>
        [DataMember(Name = "logos", IsRequired = true, EmitDefaultValue = true)]
        public LogosBeta Logos { get; set; }

        /// <summary>
        /// Options for this Source.
        /// </summary>
        /// <value>Options for this Source.</value>
        [DataMember(Name = "options", IsRequired = true, EmitDefaultValue = true)]
        public List<IntegrationOptionBeta> Options { get; set; }

        /// <summary>
        /// A list of categories this Source belongs to.
        /// </summary>
        /// <value>A list of categories this Source belongs to.</value>
        [DataMember(Name = "categories", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// True if this is a Cloud Event Source.
        /// </summary>
        /// <value>True if this is a Cloud Event Source.</value>
        [DataMember(Name = "isCloudEventSource", IsRequired = true, EmitDefaultValue = true)]
        public bool IsCloudEventSource { get; set; }

        /// <summary>
        /// Partner Owned flag.
        /// </summary>
        /// <value>Partner Owned flag.</value>
        [DataMember(Name = "partnerOwned", EmitDefaultValue = true)]
        public bool PartnerOwned { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SourceMetadataV1 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Logos: ").Append(Logos).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  IsCloudEventSource: ").Append(IsCloudEventSource).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PartnerOwned: ").Append(PartnerOwned).Append("\n");
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
            return this.Equals(input as SourceMetadataV1);
        }

        /// <summary>
        /// Returns true if SourceMetadataV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of SourceMetadataV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourceMetadataV1 input)
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
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.IsCloudEventSource == input.IsCloudEventSource ||
                    this.IsCloudEventSource.Equals(input.IsCloudEventSource)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.PartnerOwned == input.PartnerOwned ||
                    this.PartnerOwned.Equals(input.PartnerOwned)
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
                if (this.Slug != null)
                {
                    hashCode = (hashCode * 59) + this.Slug.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Logos != null)
                {
                    hashCode = (hashCode * 59) + this.Logos.GetHashCode();
                }
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
                }
                if (this.Categories != null)
                {
                    hashCode = (hashCode * 59) + this.Categories.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsCloudEventSource.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                hashCode = (hashCode * 59) + this.PartnerOwned.GetHashCode();
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
