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
    /// Business tools or apps that you can connect to the data flowing through Segment.  This is equal to the Destination object in Config API, with the following fields omitted: - catalogId - createTime - updateTime - connectionMode.
    /// </summary>
    [DataContract(Name = "DestinationV1")]
    public partial class DestinationV1 : IEquatable<DestinationV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DestinationV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationV1" /> class.
        /// </summary>
        /// <param name="id">The unique identifier of this instance of a Destination.  Config API note: analogous to &#x60;name&#x60;. (required).</param>
        /// <param name="name">The name of this instance of a Destination.  Config API note: equal to &#x60;displayName&#x60;..</param>
        /// <param name="enabled">Whether this instance of a Destination receives data. (required).</param>
        /// <param name="metadata">metadata (required).</param>
        /// <param name="sourceId">The id of a Source connected to this instance of a Destination.  Config API note: analogous to &#x60;parent&#x60;. (required).</param>
        /// <param name="settings">The collection of settings associated with a Destination.  Config API note: equal to &#x60;config&#x60;. (required).</param>
        public DestinationV1(string id = default(string), string name = default(string), bool enabled = default(bool), DestinationMetadataV1 metadata = default(DestinationMetadataV1), string sourceId = default(string), Dictionary<string, Object> settings = default(Dictionary<string, Object>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for DestinationV1 and cannot be null");
            }
            this.Id = id;
            this.Enabled = enabled;
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new ArgumentNullException("metadata is a required property for DestinationV1 and cannot be null");
            }
            this.Metadata = metadata;
            // to ensure "sourceId" is required (not null)
            if (sourceId == null)
            {
                throw new ArgumentNullException("sourceId is a required property for DestinationV1 and cannot be null");
            }
            this.SourceId = sourceId;
            // to ensure "settings" is required (not null)
            if (settings == null)
            {
                throw new ArgumentNullException("settings is a required property for DestinationV1 and cannot be null");
            }
            this.Settings = settings;
            this.Name = name;
        }

        /// <summary>
        /// The unique identifier of this instance of a Destination.  Config API note: analogous to &#x60;name&#x60;.
        /// </summary>
        /// <value>The unique identifier of this instance of a Destination.  Config API note: analogous to &#x60;name&#x60;.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The name of this instance of a Destination.  Config API note: equal to &#x60;displayName&#x60;.
        /// </summary>
        /// <value>The name of this instance of a Destination.  Config API note: equal to &#x60;displayName&#x60;.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Whether this instance of a Destination receives data.
        /// </summary>
        /// <value>Whether this instance of a Destination receives data.</value>
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", IsRequired = true, EmitDefaultValue = true)]
        public DestinationMetadataV1 Metadata { get; set; }

        /// <summary>
        /// The id of a Source connected to this instance of a Destination.  Config API note: analogous to &#x60;parent&#x60;.
        /// </summary>
        /// <value>The id of a Source connected to this instance of a Destination.  Config API note: analogous to &#x60;parent&#x60;.</value>
        [DataMember(Name = "sourceId", IsRequired = true, EmitDefaultValue = true)]
        public string SourceId { get; set; }

        /// <summary>
        /// The collection of settings associated with a Destination.  Config API note: equal to &#x60;config&#x60;.
        /// </summary>
        /// <value>The collection of settings associated with a Destination.  Config API note: equal to &#x60;config&#x60;.</value>
        [DataMember(Name = "settings", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> Settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinationV1 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
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
            return this.Equals(input as DestinationV1);
        }

        /// <summary>
        /// Returns true if DestinationV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinationV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinationV1 input)
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
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.SourceId != null)
                {
                    hashCode = (hashCode * 59) + this.SourceId.GetHashCode();
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
