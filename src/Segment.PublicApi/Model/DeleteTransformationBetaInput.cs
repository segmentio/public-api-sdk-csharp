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
    /// The input of delete Transformation.
    /// </summary>
    [DataContract(Name = "DeleteTransformationBetaInput")]
    public partial class DeleteTransformationBetaInput : IEquatable<DeleteTransformationBetaInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTransformationBetaInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeleteTransformationBetaInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTransformationBetaInput" /> class.
        /// </summary>
        /// <param name="transformationId">The Transformation id. (required).</param>
        public DeleteTransformationBetaInput(string transformationId = default(string))
        {
            // to ensure "transformationId" is required (not null)
            if (transformationId == null)
            {
                throw new ArgumentNullException("transformationId is a required property for DeleteTransformationBetaInput and cannot be null");
            }
            this.TransformationId = transformationId;
        }

        /// <summary>
        /// The Transformation id.
        /// </summary>
        /// <value>The Transformation id.</value>
        [DataMember(Name = "transformationId", IsRequired = true, EmitDefaultValue = true)]
        public string TransformationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeleteTransformationBetaInput {\n");
            sb.Append("  TransformationId: ").Append(TransformationId).Append("\n");
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
            return this.Equals(input as DeleteTransformationBetaInput);
        }

        /// <summary>
        /// Returns true if DeleteTransformationBetaInput instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteTransformationBetaInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteTransformationBetaInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TransformationId == input.TransformationId ||
                    (this.TransformationId != null &&
                    this.TransformationId.Equals(input.TransformationId))
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
                if (this.TransformationId != null)
                {
                    hashCode = (hashCode * 59) + this.TransformationId.GetHashCode();
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
