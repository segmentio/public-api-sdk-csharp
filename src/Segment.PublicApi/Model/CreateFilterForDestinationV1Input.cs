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
    /// Input for CreateDestinationFilterV1.
    /// </summary>
    [DataContract(Name = "CreateFilterForDestinationV1Input")]
    public partial class CreateFilterForDestinationV1Input : IEquatable<CreateFilterForDestinationV1Input>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFilterForDestinationV1Input" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateFilterForDestinationV1Input() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFilterForDestinationV1Input" /> class.
        /// </summary>
        /// <param name="sourceId">The id of the Source associated with this filter. (required).</param>
        /// <param name="varIf">The filter&#39;s condition. (required).</param>
        /// <param name="actions">Actions for the Destination filter. (required).</param>
        /// <param name="title">The title of the filter. (required).</param>
        /// <param name="description">The description of the filter..</param>
        /// <param name="enabled">When set to true, the Destination filter is active. (required).</param>
        public CreateFilterForDestinationV1Input(string sourceId = default(string), string varIf = default(string), List<DestinationFilterActionV1> actions = default(List<DestinationFilterActionV1>), string title = default(string), string description = default(string), bool enabled = default(bool))
        {
            // to ensure "sourceId" is required (not null)
            if (sourceId == null)
            {
                throw new ArgumentNullException("sourceId is a required property for CreateFilterForDestinationV1Input and cannot be null");
            }
            this.SourceId = sourceId;
            // to ensure "varIf" is required (not null)
            if (varIf == null)
            {
                throw new ArgumentNullException("varIf is a required property for CreateFilterForDestinationV1Input and cannot be null");
            }
            this.VarIf = varIf;
            // to ensure "actions" is required (not null)
            if (actions == null)
            {
                throw new ArgumentNullException("actions is a required property for CreateFilterForDestinationV1Input and cannot be null");
            }
            this.Actions = actions;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for CreateFilterForDestinationV1Input and cannot be null");
            }
            this.Title = title;
            this.Enabled = enabled;
            this.Description = description;
        }

        /// <summary>
        /// The id of the Source associated with this filter.
        /// </summary>
        /// <value>The id of the Source associated with this filter.</value>
        [DataMember(Name = "sourceId", IsRequired = true, EmitDefaultValue = true)]
        public string SourceId { get; set; }

        /// <summary>
        /// The filter&#39;s condition.
        /// </summary>
        /// <value>The filter&#39;s condition.</value>
        [DataMember(Name = "if", IsRequired = true, EmitDefaultValue = true)]
        public string VarIf { get; set; }

        /// <summary>
        /// Actions for the Destination filter.
        /// </summary>
        /// <value>Actions for the Destination filter.</value>
        [DataMember(Name = "actions", IsRequired = true, EmitDefaultValue = true)]
        public List<DestinationFilterActionV1> Actions { get; set; }

        /// <summary>
        /// The title of the filter.
        /// </summary>
        /// <value>The title of the filter.</value>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The description of the filter.
        /// </summary>
        /// <value>The description of the filter.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// When set to true, the Destination filter is active.
        /// </summary>
        /// <value>When set to true, the Destination filter is active.</value>
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateFilterForDestinationV1Input {\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  VarIf: ").Append(VarIf).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(input as CreateFilterForDestinationV1Input);
        }

        /// <summary>
        /// Returns true if CreateFilterForDestinationV1Input instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateFilterForDestinationV1Input to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateFilterForDestinationV1Input input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
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
                if (this.SourceId != null)
                {
                    hashCode = (hashCode * 59) + this.SourceId.GetHashCode();
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
