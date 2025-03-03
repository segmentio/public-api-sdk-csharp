/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 57.4.0
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
    /// Replaces all labels in a Source with a list of new labels.
    /// </summary>
    [DataContract(Name = "ReplaceLabelsInSourceAlphaInput")]
    public partial class ReplaceLabelsInSourceAlphaInput : IEquatable<ReplaceLabelsInSourceAlphaInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceLabelsInSourceAlphaInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReplaceLabelsInSourceAlphaInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceLabelsInSourceAlphaInput" /> class.
        /// </summary>
        /// <param name="labels">The list of labels to replace in the Source. (required).</param>
        public ReplaceLabelsInSourceAlphaInput(List<LabelAlpha> labels = default(List<LabelAlpha>))
        {
            // to ensure "labels" is required (not null)
            if (labels == null)
            {
                throw new ArgumentNullException("labels is a required property for ReplaceLabelsInSourceAlphaInput and cannot be null");
            }
            this.Labels = labels;
        }

        /// <summary>
        /// The list of labels to replace in the Source.
        /// </summary>
        /// <value>The list of labels to replace in the Source.</value>
        [DataMember(Name = "labels", IsRequired = true, EmitDefaultValue = true)]
        public List<LabelAlpha> Labels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReplaceLabelsInSourceAlphaInput {\n");
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
            return this.Equals(input as ReplaceLabelsInSourceAlphaInput);
        }

        /// <summary>
        /// Returns true if ReplaceLabelsInSourceAlphaInput instances are equal
        /// </summary>
        /// <param name="input">Instance of ReplaceLabelsInSourceAlphaInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplaceLabelsInSourceAlphaInput input)
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
