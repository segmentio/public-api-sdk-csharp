/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 57.2.0
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
    /// Applies an existing label to an existing Source.
    /// </summary>
    [DataContract(Name = "AddLabelsToSourceV1Output")]
    public partial class AddLabelsToSourceV1Output : IEquatable<AddLabelsToSourceV1Output>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddLabelsToSourceV1Output" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddLabelsToSourceV1Output() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddLabelsToSourceV1Output" /> class.
        /// </summary>
        /// <param name="labels">All labels applied to the Source. (required).</param>
        public AddLabelsToSourceV1Output(List<LabelV1> labels = default(List<LabelV1>))
        {
            // to ensure "labels" is required (not null)
            if (labels == null)
            {
                throw new ArgumentNullException("labels is a required property for AddLabelsToSourceV1Output and cannot be null");
            }
            this.Labels = labels;
        }

        /// <summary>
        /// All labels applied to the Source.
        /// </summary>
        /// <value>All labels applied to the Source.</value>
        [DataMember(Name = "labels", IsRequired = true, EmitDefaultValue = true)]
        public List<LabelV1> Labels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddLabelsToSourceV1Output {\n");
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
            return this.Equals(input as AddLabelsToSourceV1Output);
        }

        /// <summary>
        /// Returns true if AddLabelsToSourceV1Output instances are equal
        /// </summary>
        /// <param name="input">Instance of AddLabelsToSourceV1Output to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddLabelsToSourceV1Output input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
