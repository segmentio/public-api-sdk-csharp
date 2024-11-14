/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 57.0.1
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
    /// Filter output.
    /// </summary>
    [DataContract(Name = "Filter")]
    public partial class Filter : IEquatable<Filter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Filter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter" /> class.
        /// </summary>
        /// <param name="id">The newly created filter id. (required).</param>
        /// <param name="workspaceId">The Workspace id to create the filter. (required).</param>
        /// <param name="integrationId">The Integration id of the resource. (required).</param>
        /// <param name="enabled">Whether the filter is enabled..</param>
        /// <param name="name">The name of the filter..</param>
        /// <param name="description">The description of the filter..</param>
        /// <param name="varIf">The \&quot;if\&quot; statement for a filter..</param>
        /// <param name="drop">Whether the event is dropped..</param>
        /// <param name="dropProperties">Describes the properties to be dropped on events that match the \&quot;if\&quot; statement..</param>
        /// <param name="allowProperties">Describes the properties allowed on events that match the \&quot;if\&quot; statement..</param>
        /// <param name="createdAt">The timestamp of this filter&#39;s creation. (required).</param>
        /// <param name="updatedAt">The timestamp of this filter&#39;s last change. (required).</param>
        public Filter(string id = default(string), string workspaceId = default(string), string integrationId = default(string), bool enabled = default(bool), string name = default(string), string description = default(string), string varIf = default(string), bool drop = default(bool), List<string> dropProperties = default(List<string>), List<string> allowProperties = default(List<string>), string createdAt = default(string), string updatedAt = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Filter and cannot be null");
            }
            this.Id = id;
            // to ensure "workspaceId" is required (not null)
            if (workspaceId == null)
            {
                throw new ArgumentNullException("workspaceId is a required property for Filter and cannot be null");
            }
            this.WorkspaceId = workspaceId;
            // to ensure "integrationId" is required (not null)
            if (integrationId == null)
            {
                throw new ArgumentNullException("integrationId is a required property for Filter and cannot be null");
            }
            this.IntegrationId = integrationId;
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new ArgumentNullException("createdAt is a required property for Filter and cannot be null");
            }
            this.CreatedAt = createdAt;
            // to ensure "updatedAt" is required (not null)
            if (updatedAt == null)
            {
                throw new ArgumentNullException("updatedAt is a required property for Filter and cannot be null");
            }
            this.UpdatedAt = updatedAt;
            this.Enabled = enabled;
            this.Name = name;
            this.Description = description;
            this.VarIf = varIf;
            this.Drop = drop;
            this.DropProperties = dropProperties;
            this.AllowProperties = allowProperties;
        }

        /// <summary>
        /// The newly created filter id.
        /// </summary>
        /// <value>The newly created filter id.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The Workspace id to create the filter.
        /// </summary>
        /// <value>The Workspace id to create the filter.</value>
        [DataMember(Name = "workspaceId", IsRequired = true, EmitDefaultValue = true)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// The Integration id of the resource.
        /// </summary>
        /// <value>The Integration id of the resource.</value>
        [DataMember(Name = "integrationId", IsRequired = true, EmitDefaultValue = true)]
        public string IntegrationId { get; set; }

        /// <summary>
        /// Whether the filter is enabled.
        /// </summary>
        /// <value>Whether the filter is enabled.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// The name of the filter.
        /// </summary>
        /// <value>The name of the filter.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The description of the filter.
        /// </summary>
        /// <value>The description of the filter.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The \&quot;if\&quot; statement for a filter.
        /// </summary>
        /// <value>The \&quot;if\&quot; statement for a filter.</value>
        [DataMember(Name = "if", EmitDefaultValue = false)]
        public string VarIf { get; set; }

        /// <summary>
        /// Whether the event is dropped.
        /// </summary>
        /// <value>Whether the event is dropped.</value>
        [DataMember(Name = "drop", EmitDefaultValue = true)]
        public bool Drop { get; set; }

        /// <summary>
        /// Describes the properties to be dropped on events that match the \&quot;if\&quot; statement.
        /// </summary>
        /// <value>Describes the properties to be dropped on events that match the \&quot;if\&quot; statement.</value>
        [DataMember(Name = "dropProperties", EmitDefaultValue = false)]
        public List<string> DropProperties { get; set; }

        /// <summary>
        /// Describes the properties allowed on events that match the \&quot;if\&quot; statement.
        /// </summary>
        /// <value>Describes the properties allowed on events that match the \&quot;if\&quot; statement.</value>
        [DataMember(Name = "allowProperties", EmitDefaultValue = false)]
        public List<string> AllowProperties { get; set; }

        /// <summary>
        /// The timestamp of this filter&#39;s creation.
        /// </summary>
        /// <value>The timestamp of this filter&#39;s creation.</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// The timestamp of this filter&#39;s last change.
        /// </summary>
        /// <value>The timestamp of this filter&#39;s last change.</value>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Filter {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  VarIf: ").Append(VarIf).Append("\n");
            sb.Append("  Drop: ").Append(Drop).Append("\n");
            sb.Append("  DropProperties: ").Append(DropProperties).Append("\n");
            sb.Append("  AllowProperties: ").Append(AllowProperties).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as Filter);
        }

        /// <summary>
        /// Returns true if Filter instances are equal
        /// </summary>
        /// <param name="input">Instance of Filter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Filter input)
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
                    this.WorkspaceId == input.WorkspaceId ||
                    (this.WorkspaceId != null &&
                    this.WorkspaceId.Equals(input.WorkspaceId))
                ) && 
                (
                    this.IntegrationId == input.IntegrationId ||
                    (this.IntegrationId != null &&
                    this.IntegrationId.Equals(input.IntegrationId))
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.VarIf == input.VarIf ||
                    (this.VarIf != null &&
                    this.VarIf.Equals(input.VarIf))
                ) && 
                (
                    this.Drop == input.Drop ||
                    this.Drop.Equals(input.Drop)
                ) && 
                (
                    this.DropProperties == input.DropProperties ||
                    this.DropProperties != null &&
                    input.DropProperties != null &&
                    this.DropProperties.SequenceEqual(input.DropProperties)
                ) && 
                (
                    this.AllowProperties == input.AllowProperties ||
                    this.AllowProperties != null &&
                    input.AllowProperties != null &&
                    this.AllowProperties.SequenceEqual(input.AllowProperties)
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
                if (this.WorkspaceId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkspaceId.GetHashCode();
                }
                if (this.IntegrationId != null)
                {
                    hashCode = (hashCode * 59) + this.IntegrationId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.VarIf != null)
                {
                    hashCode = (hashCode * 59) + this.VarIf.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Drop.GetHashCode();
                if (this.DropProperties != null)
                {
                    hashCode = (hashCode * 59) + this.DropProperties.GetHashCode();
                }
                if (this.AllowProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AllowProperties.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
