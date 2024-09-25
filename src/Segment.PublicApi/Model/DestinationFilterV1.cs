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
    /// Represents a Destination filter.
    /// </summary>
    [DataContract(Name = "DestinationFilterV1")]
    public partial class DestinationFilterV1 : IEquatable<DestinationFilterV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationFilterV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DestinationFilterV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationFilterV1" /> class.
        /// </summary>
        /// <param name="id">The unique id of this filter. (required).</param>
        /// <param name="sourceId">The id of the Source associated with this filter. (required).</param>
        /// <param name="destinationId">The id of the Destination associated with this filter. (required).</param>
        /// <param name="varIf">A condition that defines whether to apply this filter to a payload. (required).</param>
        /// <param name="actions">A list of actions this filter performs. (required).</param>
        /// <param name="title">A title for this filter. (required).</param>
        /// <param name="description">A description for this filter..</param>
        /// <param name="enabled">When set to true, this filter is active. (required).</param>
        /// <param name="createdAt">The timestamp of this filter&#39;s creation. (required).</param>
        /// <param name="updatedAt">The timestamp of this filter&#39;s last change. (required).</param>
        public DestinationFilterV1(string id = default(string), string sourceId = default(string), string destinationId = default(string), string varIf = default(string), List<DestinationFilterActionV1> actions = default(List<DestinationFilterActionV1>), string title = default(string), string description = default(string), bool enabled = default(bool), string createdAt = default(string), string updatedAt = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for DestinationFilterV1 and cannot be null");
            }
            this.Id = id;
            // to ensure "sourceId" is required (not null)
            if (sourceId == null)
            {
                throw new ArgumentNullException("sourceId is a required property for DestinationFilterV1 and cannot be null");
            }
            this.SourceId = sourceId;
            // to ensure "destinationId" is required (not null)
            if (destinationId == null)
            {
                throw new ArgumentNullException("destinationId is a required property for DestinationFilterV1 and cannot be null");
            }
            this.DestinationId = destinationId;
            // to ensure "varIf" is required (not null)
            if (varIf == null)
            {
                throw new ArgumentNullException("varIf is a required property for DestinationFilterV1 and cannot be null");
            }
            this.VarIf = varIf;
            // to ensure "actions" is required (not null)
            if (actions == null)
            {
                throw new ArgumentNullException("actions is a required property for DestinationFilterV1 and cannot be null");
            }
            this.Actions = actions;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for DestinationFilterV1 and cannot be null");
            }
            this.Title = title;
            this.Enabled = enabled;
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new ArgumentNullException("createdAt is a required property for DestinationFilterV1 and cannot be null");
            }
            this.CreatedAt = createdAt;
            // to ensure "updatedAt" is required (not null)
            if (updatedAt == null)
            {
                throw new ArgumentNullException("updatedAt is a required property for DestinationFilterV1 and cannot be null");
            }
            this.UpdatedAt = updatedAt;
            this.Description = description;
        }

        /// <summary>
        /// The unique id of this filter.
        /// </summary>
        /// <value>The unique id of this filter.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The id of the Source associated with this filter.
        /// </summary>
        /// <value>The id of the Source associated with this filter.</value>
        [DataMember(Name = "sourceId", IsRequired = true, EmitDefaultValue = true)]
        public string SourceId { get; set; }

        /// <summary>
        /// The id of the Destination associated with this filter.
        /// </summary>
        /// <value>The id of the Destination associated with this filter.</value>
        [DataMember(Name = "destinationId", IsRequired = true, EmitDefaultValue = true)]
        public string DestinationId { get; set; }

        /// <summary>
        /// A condition that defines whether to apply this filter to a payload.
        /// </summary>
        /// <value>A condition that defines whether to apply this filter to a payload.</value>
        [DataMember(Name = "if", IsRequired = true, EmitDefaultValue = true)]
        public string VarIf { get; set; }

        /// <summary>
        /// A list of actions this filter performs.
        /// </summary>
        /// <value>A list of actions this filter performs.</value>
        [DataMember(Name = "actions", IsRequired = true, EmitDefaultValue = true)]
        public List<DestinationFilterActionV1> Actions { get; set; }

        /// <summary>
        /// A title for this filter.
        /// </summary>
        /// <value>A title for this filter.</value>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// A description for this filter.
        /// </summary>
        /// <value>A description for this filter.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// When set to true, this filter is active.
        /// </summary>
        /// <value>When set to true, this filter is active.</value>
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

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
            sb.Append("class DestinationFilterV1 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  DestinationId: ").Append(DestinationId).Append("\n");
            sb.Append("  VarIf: ").Append(VarIf).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(input as DestinationFilterV1);
        }

        /// <summary>
        /// Returns true if DestinationFilterV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinationFilterV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinationFilterV1 input)
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
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.DestinationId == input.DestinationId ||
                    (this.DestinationId != null &&
                    this.DestinationId.Equals(input.DestinationId))
                ) && 
                (
                    this.VarIf == input.VarIf ||
                    (this.VarIf != null &&
                    this.VarIf.Equals(input.VarIf))
                ) && 
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    input.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
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
                if (this.SourceId != null)
                {
                    hashCode = (hashCode * 59) + this.SourceId.GetHashCode();
                }
                if (this.DestinationId != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationId.GetHashCode();
                }
                if (this.VarIf != null)
                {
                    hashCode = (hashCode * 59) + this.VarIf.GetHashCode();
                }
                if (this.Actions != null)
                {
                    hashCode = (hashCode * 59) + this.Actions.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
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
