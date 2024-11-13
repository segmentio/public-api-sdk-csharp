/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 57.0.0
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
    /// Input to update a computed trait.
    /// </summary>
    [DataContract(Name = "UpdateComputedTraitForSpaceAlphaInput")]
    public partial class UpdateComputedTraitForSpaceAlphaInput : IEquatable<UpdateComputedTraitForSpaceAlphaInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateComputedTraitForSpaceAlphaInput" /> class.
        /// </summary>
        /// <param name="enabled">Enabled/disabled status for the computed trait..</param>
        /// <param name="name">The name of the computation..</param>
        /// <param name="description">The description of the computation..</param>
        /// <param name="definition">definition.</param>
        public UpdateComputedTraitForSpaceAlphaInput(bool enabled = default(bool), string name = default(string), string description = default(string), TraitDefinition definition = default(TraitDefinition))
        {
            this.Enabled = enabled;
            this.Name = name;
            this.Description = description;
            this.Definition = definition;
        }

        /// <summary>
        /// Enabled/disabled status for the computed trait.
        /// </summary>
        /// <value>Enabled/disabled status for the computed trait.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// The name of the computation.
        /// </summary>
        /// <value>The name of the computation.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The description of the computation.
        /// </summary>
        /// <value>The description of the computation.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Definition
        /// </summary>
        [DataMember(Name = "definition", EmitDefaultValue = false)]
        public TraitDefinition Definition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateComputedTraitForSpaceAlphaInput {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Definition: ").Append(Definition).Append("\n");
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
            return this.Equals(input as UpdateComputedTraitForSpaceAlphaInput);
        }

        /// <summary>
        /// Returns true if UpdateComputedTraitForSpaceAlphaInput instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateComputedTraitForSpaceAlphaInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateComputedTraitForSpaceAlphaInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.Definition == input.Definition ||
                    (this.Definition != null &&
                    this.Definition.Equals(input.Definition))
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
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Definition != null)
                {
                    hashCode = (hashCode * 59) + this.Definition.GetHashCode();
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
