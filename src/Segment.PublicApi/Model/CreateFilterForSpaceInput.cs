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
    /// Input for CreateFilter.
    /// </summary>
    [DataContract(Name = "CreateFilterForSpaceInput")]
    public partial class CreateFilterForSpaceInput : IEquatable<CreateFilterForSpaceInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFilterForSpaceInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateFilterForSpaceInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFilterForSpaceInput" /> class.
        /// </summary>
        /// <param name="integrationId">The Space id to filter on. (required).</param>
        /// <param name="enabled">Whether the filter is enabled..</param>
        /// <param name="name">The name of the filter. (required).</param>
        /// <param name="description">The description of the filter..</param>
        /// <param name="varIf">The \&quot;if\&quot; statement for a filter. (required).</param>
        /// <param name="drop">Whether the event is dropped..</param>
        public CreateFilterForSpaceInput(string integrationId = default(string), bool enabled = default(bool), string name = default(string), string description = default(string), string varIf = default(string), bool drop = default(bool))
        {
            // to ensure "integrationId" is required (not null)
            if (integrationId == null)
            {
                throw new ArgumentNullException("integrationId is a required property for CreateFilterForSpaceInput and cannot be null");
            }
            this.IntegrationId = integrationId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateFilterForSpaceInput and cannot be null");
            }
            this.Name = name;
            // to ensure "varIf" is required (not null)
            if (varIf == null)
            {
                throw new ArgumentNullException("varIf is a required property for CreateFilterForSpaceInput and cannot be null");
            }
            this.VarIf = varIf;
            this.Enabled = enabled;
            this.Description = description;
            this.Drop = drop;
        }

        /// <summary>
        /// The Space id to filter on.
        /// </summary>
        /// <value>The Space id to filter on.</value>
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
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
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
        [DataMember(Name = "if", IsRequired = true, EmitDefaultValue = true)]
        public string VarIf { get; set; }

        /// <summary>
        /// Whether the event is dropped.
        /// </summary>
        /// <value>Whether the event is dropped.</value>
        [DataMember(Name = "drop", EmitDefaultValue = true)]
        public bool Drop { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateFilterForSpaceInput {\n");
            sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  VarIf: ").Append(VarIf).Append("\n");
            sb.Append("  Drop: ").Append(Drop).Append("\n");
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
            return this.Equals(input as CreateFilterForSpaceInput);
        }

        /// <summary>
        /// Returns true if CreateFilterForSpaceInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateFilterForSpaceInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateFilterForSpaceInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
