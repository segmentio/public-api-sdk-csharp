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
    /// Defines an Audience.
    /// </summary>
    [DataContract(Name = "AudienceSummary")]
    public partial class AudienceSummary : IEquatable<AudienceSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AudienceSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AudienceSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AudienceSummary" /> class.
        /// </summary>
        /// <param name="id">Audience id. (required).</param>
        /// <param name="spaceId">Space id for the audience. (required).</param>
        /// <param name="name">Name of the audience. (required).</param>
        /// <param name="description">Description of the audience..</param>
        /// <param name="key">Key for the audience. (required).</param>
        /// <param name="enabled">Enabled/disabled status for the audience. (required).</param>
        /// <param name="definition">definition (required).</param>
        /// <param name="status">Status for the audience.  Possible values: Backfilling, Computing, Failed, Live, Awaiting Destinations, Disabled..</param>
        /// <param name="createdBy">User id who created the audience. (required).</param>
        /// <param name="updatedBy">User id who last updated the audience. (required).</param>
        /// <param name="createdAt">Date the audience was created. (required).</param>
        /// <param name="updatedAt">Date the audience was last updated. (required).</param>
        /// <param name="options">options.</param>
        public AudienceSummary(string id = default(string), string spaceId = default(string), string name = default(string), string description = default(string), string key = default(string), bool enabled = default(bool), AudienceDefinition definition = default(AudienceDefinition), string status = default(string), string createdBy = default(string), string updatedBy = default(string), string createdAt = default(string), string updatedAt = default(string), AudienceOptions options = default(AudienceOptions))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for AudienceSummary and cannot be null");
            }
            this.Id = id;
            // to ensure "spaceId" is required (not null)
            if (spaceId == null)
            {
                throw new ArgumentNullException("spaceId is a required property for AudienceSummary and cannot be null");
            }
            this.SpaceId = spaceId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AudienceSummary and cannot be null");
            }
            this.Name = name;
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for AudienceSummary and cannot be null");
            }
            this.Key = key;
            this.Enabled = enabled;
            // to ensure "definition" is required (not null)
            if (definition == null)
            {
                throw new ArgumentNullException("definition is a required property for AudienceSummary and cannot be null");
            }
            this.Definition = definition;
            // to ensure "createdBy" is required (not null)
            if (createdBy == null)
            {
                throw new ArgumentNullException("createdBy is a required property for AudienceSummary and cannot be null");
            }
            this.CreatedBy = createdBy;
            // to ensure "updatedBy" is required (not null)
            if (updatedBy == null)
            {
                throw new ArgumentNullException("updatedBy is a required property for AudienceSummary and cannot be null");
            }
            this.UpdatedBy = updatedBy;
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new ArgumentNullException("createdAt is a required property for AudienceSummary and cannot be null");
            }
            this.CreatedAt = createdAt;
            // to ensure "updatedAt" is required (not null)
            if (updatedAt == null)
            {
                throw new ArgumentNullException("updatedAt is a required property for AudienceSummary and cannot be null");
            }
            this.UpdatedAt = updatedAt;
            this.Description = description;
            this.Status = status;
            this.Options = options;
        }

        /// <summary>
        /// Audience id.
        /// </summary>
        /// <value>Audience id.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Space id for the audience.
        /// </summary>
        /// <value>Space id for the audience.</value>
        [DataMember(Name = "spaceId", IsRequired = true, EmitDefaultValue = true)]
        public string SpaceId { get; set; }

        /// <summary>
        /// Name of the audience.
        /// </summary>
        /// <value>Name of the audience.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Description of the audience.
        /// </summary>
        /// <value>Description of the audience.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Key for the audience.
        /// </summary>
        /// <value>Key for the audience.</value>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Enabled/disabled status for the audience.
        /// </summary>
        /// <value>Enabled/disabled status for the audience.</value>
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Definition
        /// </summary>
        [DataMember(Name = "definition", IsRequired = true, EmitDefaultValue = true)]
        public AudienceDefinition Definition { get; set; }

        /// <summary>
        /// Status for the audience.  Possible values: Backfilling, Computing, Failed, Live, Awaiting Destinations, Disabled.
        /// </summary>
        /// <value>Status for the audience.  Possible values: Backfilling, Computing, Failed, Live, Awaiting Destinations, Disabled.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// User id who created the audience.
        /// </summary>
        /// <value>User id who created the audience.</value>
        [DataMember(Name = "createdBy", IsRequired = true, EmitDefaultValue = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// User id who last updated the audience.
        /// </summary>
        /// <value>User id who last updated the audience.</value>
        [DataMember(Name = "updatedBy", IsRequired = true, EmitDefaultValue = true)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Date the audience was created.
        /// </summary>
        /// <value>Date the audience was created.</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Date the audience was last updated.
        /// </summary>
        /// <value>Date the audience was last updated.</value>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public AudienceOptions Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AudienceSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SpaceId: ").Append(SpaceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Definition: ").Append(Definition).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as AudienceSummary);
        }

        /// <summary>
        /// Returns true if AudienceSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of AudienceSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AudienceSummary input)
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
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Definition == input.Definition ||
                    (this.Definition != null &&
                    this.Definition.Equals(input.Definition))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    (this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(input.UpdatedBy))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.Definition != null)
                {
                    hashCode = (hashCode * 59) + this.Definition.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                if (this.UpdatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedBy.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
