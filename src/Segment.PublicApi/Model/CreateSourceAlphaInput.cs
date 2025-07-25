/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.13.0
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
    /// Create a new Source based on a set of parameters.
    /// </summary>
    [DataContract(Name = "CreateSourceAlphaInput")]
    public partial class CreateSourceAlphaInput : IEquatable<CreateSourceAlphaInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSourceAlphaInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateSourceAlphaInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSourceAlphaInput" /> class.
        /// </summary>
        /// <param name="slug">The slug by which to identify the Source in the Segment app. (required).</param>
        /// <param name="enabled">Enable to allow this Source to send data. Defaults to true. (required).</param>
        /// <param name="name">An optional human-readable name for this Source..</param>
        /// <param name="metadataId">The id of the Source metadata from which this instance of the Source derives.  All Source metadata is available under &#x60;/catalog/sources&#x60;. (required).</param>
        /// <param name="settings">A key-value object that contains instance-specific settings for a Source.  The &#x60;options&#x60; field in the Source metadata defines the schema of this object..</param>
        public CreateSourceAlphaInput(string slug = default(string), bool enabled = default(bool), string name = default(string), string metadataId = default(string), Dictionary<string, Object> settings = default(Dictionary<string, Object>))
        {
            // to ensure "slug" is required (not null)
            if (slug == null)
            {
                throw new ArgumentNullException("slug is a required property for CreateSourceAlphaInput and cannot be null");
            }
            this.Slug = slug;
            this.Enabled = enabled;
            // to ensure "metadataId" is required (not null)
            if (metadataId == null)
            {
                throw new ArgumentNullException("metadataId is a required property for CreateSourceAlphaInput and cannot be null");
            }
            this.MetadataId = metadataId;
            this.Name = name;
            this.Settings = settings;
        }

        /// <summary>
        /// The slug by which to identify the Source in the Segment app.
        /// </summary>
        /// <value>The slug by which to identify the Source in the Segment app.</value>
        [DataMember(Name = "slug", IsRequired = true, EmitDefaultValue = true)]
        public string Slug { get; set; }

        /// <summary>
        /// Enable to allow this Source to send data. Defaults to true.
        /// </summary>
        /// <value>Enable to allow this Source to send data. Defaults to true.</value>
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// An optional human-readable name for this Source.
        /// </summary>
        /// <value>An optional human-readable name for this Source.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The id of the Source metadata from which this instance of the Source derives.  All Source metadata is available under &#x60;/catalog/sources&#x60;.
        /// </summary>
        /// <value>The id of the Source metadata from which this instance of the Source derives.  All Source metadata is available under &#x60;/catalog/sources&#x60;.</value>
        [DataMember(Name = "metadataId", IsRequired = true, EmitDefaultValue = true)]
        public string MetadataId { get; set; }

        /// <summary>
        /// A key-value object that contains instance-specific settings for a Source.  The &#x60;options&#x60; field in the Source metadata defines the schema of this object.
        /// </summary>
        /// <value>A key-value object that contains instance-specific settings for a Source.  The &#x60;options&#x60; field in the Source metadata defines the schema of this object.</value>
        [DataMember(Name = "settings", EmitDefaultValue = false)]
        public Dictionary<string, Object> Settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateSourceAlphaInput {\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MetadataId: ").Append(MetadataId).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
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
            return this.Equals(input as CreateSourceAlphaInput);
        }

        /// <summary>
        /// Returns true if CreateSourceAlphaInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSourceAlphaInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSourceAlphaInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.MetadataId == input.MetadataId ||
                    (this.MetadataId != null &&
                    this.MetadataId.Equals(input.MetadataId))
                ) && 
                (
                    this.Settings == input.Settings ||
                    this.Settings != null &&
                    input.Settings != null &&
                    this.Settings.SequenceEqual(input.Settings)
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
                if (this.Slug != null)
                {
                    hashCode = (hashCode * 59) + this.Slug.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.MetadataId != null)
                {
                    hashCode = (hashCode * 59) + this.MetadataId.GetHashCode();
                }
                if (this.Settings != null)
                {
                    hashCode = (hashCode * 59) + this.Settings.GetHashCode();
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
