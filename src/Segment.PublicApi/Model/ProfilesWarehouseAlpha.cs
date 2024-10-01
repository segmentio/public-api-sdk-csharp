/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 54.3.0
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
    /// Defines a Profiles data Warehouse used as a Destination for Segment data.
    /// </summary>
    [DataContract(Name = "ProfilesWarehouseAlpha")]
    public partial class ProfilesWarehouseAlpha : IEquatable<ProfilesWarehouseAlpha>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesWarehouseAlpha" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProfilesWarehouseAlpha() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesWarehouseAlpha" /> class.
        /// </summary>
        /// <param name="id">The id of the Warehouse. (required).</param>
        /// <param name="spaceId">The Space id. (required).</param>
        /// <param name="metadata">metadata (required).</param>
        /// <param name="workspaceId">The id of the Workspace that owns this Warehouse. (required).</param>
        /// <param name="enabled">When set to true, this Warehouse receives data. (required).</param>
        /// <param name="settings">A key-value object that contains instance-specific Warehouse settings. (required).</param>
        /// <param name="schemaName">The custom schema name that Segment uses on the Warehouse side..</param>
        public ProfilesWarehouseAlpha(string id = default(string), string spaceId = default(string), WarehouseMetadataV1 metadata = default(WarehouseMetadataV1), string workspaceId = default(string), bool enabled = default(bool), Dictionary<string, Object> settings = default(Dictionary<string, Object>), string schemaName = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for ProfilesWarehouseAlpha and cannot be null");
            }
            this.Id = id;
            // to ensure "spaceId" is required (not null)
            if (spaceId == null)
            {
                throw new ArgumentNullException("spaceId is a required property for ProfilesWarehouseAlpha and cannot be null");
            }
            this.SpaceId = spaceId;
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new ArgumentNullException("metadata is a required property for ProfilesWarehouseAlpha and cannot be null");
            }
            this.Metadata = metadata;
            // to ensure "workspaceId" is required (not null)
            if (workspaceId == null)
            {
                throw new ArgumentNullException("workspaceId is a required property for ProfilesWarehouseAlpha and cannot be null");
            }
            this.WorkspaceId = workspaceId;
            this.Enabled = enabled;
            // to ensure "settings" is required (not null)
            if (settings == null)
            {
                throw new ArgumentNullException("settings is a required property for ProfilesWarehouseAlpha and cannot be null");
            }
            this.Settings = settings;
            this.SchemaName = schemaName;
        }

        /// <summary>
        /// The id of the Warehouse.
        /// </summary>
        /// <value>The id of the Warehouse.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The Space id.
        /// </summary>
        /// <value>The Space id.</value>
        [DataMember(Name = "spaceId", IsRequired = true, EmitDefaultValue = true)]
        public string SpaceId { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", IsRequired = true, EmitDefaultValue = true)]
        public WarehouseMetadataV1 Metadata { get; set; }

        /// <summary>
        /// The id of the Workspace that owns this Warehouse.
        /// </summary>
        /// <value>The id of the Workspace that owns this Warehouse.</value>
        [DataMember(Name = "workspaceId", IsRequired = true, EmitDefaultValue = true)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// When set to true, this Warehouse receives data.
        /// </summary>
        /// <value>When set to true, this Warehouse receives data.</value>
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// A key-value object that contains instance-specific Warehouse settings.
        /// </summary>
        /// <value>A key-value object that contains instance-specific Warehouse settings.</value>
        [DataMember(Name = "settings", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> Settings { get; set; }

        /// <summary>
        /// The custom schema name that Segment uses on the Warehouse side.
        /// </summary>
        /// <value>The custom schema name that Segment uses on the Warehouse side.</value>
        [DataMember(Name = "schemaName", EmitDefaultValue = false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProfilesWarehouseAlpha {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SpaceId: ").Append(SpaceId).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  SchemaName: ").Append(SchemaName).Append("\n");
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
            return this.Equals(input as ProfilesWarehouseAlpha);
        }

        /// <summary>
        /// Returns true if ProfilesWarehouseAlpha instances are equal
        /// </summary>
        /// <param name="input">Instance of ProfilesWarehouseAlpha to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfilesWarehouseAlpha input)
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
                    this.SpaceId == input.SpaceId ||
                    (this.SpaceId != null &&
                    this.SpaceId.Equals(input.SpaceId))
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
                    this.Settings == input.Settings ||
                    this.Settings != null &&
                    input.Settings != null &&
                    this.Settings.SequenceEqual(input.Settings)
                ) && 
                (
                    this.SchemaName == input.SchemaName ||
                    (this.SchemaName != null &&
                    this.SchemaName.Equals(input.SchemaName))
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
                if (this.SpaceId != null)
                {
                    hashCode = (hashCode * 59) + this.SpaceId.GetHashCode();
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
                if (this.Settings != null)
                {
                    hashCode = (hashCode * 59) + this.Settings.GetHashCode();
                }
                if (this.SchemaName != null)
                {
                    hashCode = (hashCode * 59) + this.SchemaName.GetHashCode();
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
