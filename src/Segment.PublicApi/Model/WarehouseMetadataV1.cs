/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 56.0.0
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
    /// The metadata for an instance of Segment’s data Warehouse product.
    /// </summary>
    [DataContract(Name = "WarehouseMetadataV1")]
    public partial class WarehouseMetadataV1 : IEquatable<WarehouseMetadataV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseMetadataV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WarehouseMetadataV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseMetadataV1" /> class.
        /// </summary>
        /// <param name="id">The id of this object. (required).</param>
        /// <param name="name">The name of this object. (required).</param>
        /// <param name="slug">A human-readable, unique identifier for object. (required).</param>
        /// <param name="description">A description, in English, of this object. (required).</param>
        /// <param name="logos">logos (required).</param>
        /// <param name="options">The Integration options for this object. (required).</param>
        public WarehouseMetadataV1(string id = default(string), string name = default(string), string slug = default(string), string description = default(string), LogosBeta logos = default(LogosBeta), List<IntegrationOptionBeta> options = default(List<IntegrationOptionBeta>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for WarehouseMetadataV1 and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for WarehouseMetadataV1 and cannot be null");
            }
            this.Name = name;
            // to ensure "slug" is required (not null)
            if (slug == null)
            {
                throw new ArgumentNullException("slug is a required property for WarehouseMetadataV1 and cannot be null");
            }
            this.Slug = slug;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for WarehouseMetadataV1 and cannot be null");
            }
            this.Description = description;
            // to ensure "logos" is required (not null)
            if (logos == null)
            {
                throw new ArgumentNullException("logos is a required property for WarehouseMetadataV1 and cannot be null");
            }
            this.Logos = logos;
            // to ensure "options" is required (not null)
            if (options == null)
            {
                throw new ArgumentNullException("options is a required property for WarehouseMetadataV1 and cannot be null");
            }
            this.Options = options;
        }

        /// <summary>
        /// The id of this object.
        /// </summary>
        /// <value>The id of this object.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The name of this object.
        /// </summary>
        /// <value>The name of this object.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// A human-readable, unique identifier for object.
        /// </summary>
        /// <value>A human-readable, unique identifier for object.</value>
        [DataMember(Name = "slug", IsRequired = true, EmitDefaultValue = true)]
        public string Slug { get; set; }

        /// <summary>
        /// A description, in English, of this object.
        /// </summary>
        /// <value>A description, in English, of this object.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Logos
        /// </summary>
        [DataMember(Name = "logos", IsRequired = true, EmitDefaultValue = true)]
        public LogosBeta Logos { get; set; }

        /// <summary>
        /// The Integration options for this object.
        /// </summary>
        /// <value>The Integration options for this object.</value>
        [DataMember(Name = "options", IsRequired = true, EmitDefaultValue = true)]
        public List<IntegrationOptionBeta> Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WarehouseMetadataV1 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Logos: ").Append(Logos).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as WarehouseMetadataV1);
        }

        /// <summary>
        /// Returns true if WarehouseMetadataV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of WarehouseMetadataV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WarehouseMetadataV1 input)
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
