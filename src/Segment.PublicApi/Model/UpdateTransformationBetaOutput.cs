/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.1.1
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
    /// The output of an updated Transformation.
    /// </summary>
    [DataContract(Name = "UpdateTransformationBetaOutput")]
    public partial class UpdateTransformationBetaOutput : IEquatable<UpdateTransformationBetaOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTransformationBetaOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateTransformationBetaOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTransformationBetaOutput" /> class.
        /// </summary>
        /// <param name="transformation">transformation (required).</param>
        public UpdateTransformationBetaOutput(TransformationBeta transformation = default(TransformationBeta))
        {
            // to ensure "transformation" is required (not null)
            if (transformation == null)
            {
                throw new ArgumentNullException("transformation is a required property for UpdateTransformationBetaOutput and cannot be null");
            }
            this.Transformation = transformation;
        }

        /// <summary>
        /// Gets or Sets Transformation
        /// </summary>
        [DataMember(Name = "transformation", IsRequired = true, EmitDefaultValue = true)]
        public TransformationBeta Transformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateTransformationBetaOutput {\n");
            sb.Append("  Transformation: ").Append(Transformation).Append("\n");
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
            return this.Equals(input as UpdateTransformationBetaOutput);
        }

        /// <summary>
        /// Returns true if UpdateTransformationBetaOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateTransformationBetaOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateTransformationBetaOutput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Transformation == input.Transformation ||
                    (this.Transformation != null &&
                    this.Transformation.Equals(input.Transformation))
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
                if (this.Transformation != null)
                {
                    hashCode = (hashCode * 59) + this.Transformation.GetHashCode();
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
