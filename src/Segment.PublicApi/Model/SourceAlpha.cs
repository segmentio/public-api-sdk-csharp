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
    /// Defines a data Source for Segment data.
    /// </summary>
    [DataContract(Name = "SourceAlpha")]
    public partial class SourceAlpha : IEquatable<SourceAlpha>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceAlpha" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SourceAlpha() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceAlpha" /> class.
        /// </summary>
        /// <param name="id">The id of the Source.  Config API note: analogous to &#x60;name&#x60;. (required).</param>
        /// <param name="slug">The slug used to identify the Source in the Segment app.  Config API note: equal to &#x60;name&#x60;. (required).</param>
        /// <param name="name">The name of the Source.  Config API note: equal to &#x60;displayName&#x60;..</param>
        /// <param name="metadata">metadata (required).</param>
        /// <param name="workspaceId">The id of the Workspace that owns the Source.  Config API note: equal to &#x60;parent&#x60;. (required).</param>
        /// <param name="enabled">Enable to receive data from the Source. (required).</param>
        /// <param name="writeKeys">The write keys used to send data from the Source. This field is left empty when the current token does not have the &#39;source admin&#39; permission. (required).</param>
        /// <param name="settings">A key-value object that contains instance-specific settings for a Source.  The &#x60;options&#x60; field in the Source metadata defines the schema of this object..</param>
        /// <param name="labels">A list of labels applied to the Source. (required).</param>
        public SourceAlpha(string id = default(string), string slug = default(string), string name = default(string), SourceMetadataV1 metadata = default(SourceMetadataV1), string workspaceId = default(string), bool enabled = default(bool), List<string> writeKeys = default(List<string>), Dictionary<string, Object> settings = default(Dictionary<string, Object>), List<LabelV1> labels = default(List<LabelV1>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for SourceAlpha and cannot be null");
            }
            this.Id = id;
            // to ensure "slug" is required (not null)
            if (slug == null)
            {
                throw new ArgumentNullException("slug is a required property for SourceAlpha and cannot be null");
            }
            this.Slug = slug;
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new ArgumentNullException("metadata is a required property for SourceAlpha and cannot be null");
            }
            this.Metadata = metadata;
            // to ensure "workspaceId" is required (not null)
            if (workspaceId == null)
            {
                throw new ArgumentNullException("workspaceId is a required property for SourceAlpha and cannot be null");
            }
            this.WorkspaceId = workspaceId;
            this.Enabled = enabled;
            // to ensure "writeKeys" is required (not null)
            if (writeKeys == null)
            {
                throw new ArgumentNullException("writeKeys is a required property for SourceAlpha and cannot be null");
            }
            this.WriteKeys = writeKeys;
            // to ensure "labels" is required (not null)
            if (labels == null)
            {
                throw new ArgumentNullException("labels is a required property for SourceAlpha and cannot be null");
            }
            this.Labels = labels;
            this.Name = name;
            this.Settings = settings;
        }

        /// <summary>
        /// The id of the Source.  Config API note: analogous to &#x60;name&#x60;.
        /// </summary>
        /// <value>The id of the Source.  Config API note: analogous to &#x60;name&#x60;.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The slug used to identify the Source in the Segment app.  Config API note: equal to &#x60;name&#x60;.
        /// </summary>
        /// <value>The slug used to identify the Source in the Segment app.  Config API note: equal to &#x60;name&#x60;.</value>
        [DataMember(Name = "slug", IsRequired = true, EmitDefaultValue = true)]
        public string Slug { get; set; }

        /// <summary>
        /// The name of the Source.  Config API note: equal to &#x60;displayName&#x60;.
        /// </summary>
        /// <value>The name of the Source.  Config API note: equal to &#x60;displayName&#x60;.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", IsRequired = true, EmitDefaultValue = true)]
        public SourceMetadataV1 Metadata { get; set; }

        /// <summary>
        /// The id of the Workspace that owns the Source.  Config API note: equal to &#x60;parent&#x60;.
        /// </summary>
        /// <value>The id of the Workspace that owns the Source.  Config API note: equal to &#x60;parent&#x60;.</value>
        [DataMember(Name = "workspaceId", IsRequired = true, EmitDefaultValue = true)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// Enable to receive data from the Source.
        /// </summary>
        /// <value>Enable to receive data from the Source.</value>
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// The write keys used to send data from the Source. This field is left empty when the current token does not have the &#39;source admin&#39; permission.
        /// </summary>
        /// <value>The write keys used to send data from the Source. This field is left empty when the current token does not have the &#39;source admin&#39; permission.</value>
        [DataMember(Name = "writeKeys", IsRequired = true, EmitDefaultValue = true)]
        public List<string> WriteKeys { get; set; }

        /// <summary>
        /// A key-value object that contains instance-specific settings for a Source.  The &#x60;options&#x60; field in the Source metadata defines the schema of this object.
        /// </summary>
        /// <value>A key-value object that contains instance-specific settings for a Source.  The &#x60;options&#x60; field in the Source metadata defines the schema of this object.</value>
        [DataMember(Name = "settings", EmitDefaultValue = false)]
        public Dictionary<string, Object> Settings { get; set; }

        /// <summary>
        /// A list of labels applied to the Source.
        /// </summary>
        /// <value>A list of labels applied to the Source.</value>
        [DataMember(Name = "labels", IsRequired = true, EmitDefaultValue = true)]
        public List<LabelV1> Labels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SourceAlpha {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  WriteKeys: ").Append(WriteKeys).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
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
            return this.Equals(input as SourceAlpha);
        }

        /// <summary>
        /// Returns true if SourceAlpha instances are equal
        /// </summary>
        /// <param name="input">Instance of SourceAlpha to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourceAlpha input)
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
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.WorkspaceId == input.WorkspaceId ||
                    (this.WorkspaceId != null &&
                    this.WorkspaceId.Equals(input.WorkspaceId))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.WriteKeys == input.WriteKeys ||
                    this.WriteKeys != null &&
                    input.WriteKeys != null &&
                    this.WriteKeys.SequenceEqual(input.WriteKeys)
                ) && 
                (
                    this.Settings == input.Settings ||
                    this.Settings != null &&
                    input.Settings != null &&
                    this.Settings.SequenceEqual(input.Settings)
                ) && 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    input.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
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
                if (this.Slug != null)
                {
                    hashCode = (hashCode * 59) + this.Slug.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.WorkspaceId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkspaceId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.WriteKeys != null)
                {
                    hashCode = (hashCode * 59) + this.WriteKeys.GetHashCode();
                }
                if (this.Settings != null)
                {
                    hashCode = (hashCode * 59) + this.Settings.GetHashCode();
                }
                if (this.Labels != null)
                {
                    hashCode = (hashCode * 59) + this.Labels.GetHashCode();
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