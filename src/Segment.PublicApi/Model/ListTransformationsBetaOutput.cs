/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 56.0.0
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
    /// Lists the Transformations associated with the current Workspace.
    /// </summary>
    [DataContract(Name = "ListTransformationsBetaOutput")]
    public partial class ListTransformationsBetaOutput : IEquatable<ListTransformationsBetaOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListTransformationsBetaOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListTransformationsBetaOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListTransformationsBetaOutput" /> class.
        /// </summary>
        /// <param name="transformations">A paginated list of Transformations. (required).</param>
        /// <param name="pagination">pagination (required).</param>
        public ListTransformationsBetaOutput(List<TransformationBeta> transformations = default(List<TransformationBeta>), PaginationOutput pagination = default(PaginationOutput))
        {
            // to ensure "transformations" is required (not null)
            if (transformations == null)
            {
                throw new ArgumentNullException("transformations is a required property for ListTransformationsBetaOutput and cannot be null");
            }
            this.Transformations = transformations;
            // to ensure "pagination" is required (not null)
            if (pagination == null)
            {
                throw new ArgumentNullException("pagination is a required property for ListTransformationsBetaOutput and cannot be null");
            }
            this.Pagination = pagination;
        }

        /// <summary>
        /// A paginated list of Transformations.
        /// </summary>
        /// <value>A paginated list of Transformations.</value>
        [DataMember(Name = "transformations", IsRequired = true, EmitDefaultValue = true)]
        public List<TransformationBeta> Transformations { get; set; }

        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name = "pagination", IsRequired = true, EmitDefaultValue = true)]
        public PaginationOutput Pagination { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListTransformationsBetaOutput {\n");
            sb.Append("  Transformations: ").Append(Transformations).Append("\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
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
            return this.Equals(input as ListTransformationsBetaOutput);
        }

        /// <summary>
        /// Returns true if ListTransformationsBetaOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of ListTransformationsBetaOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListTransformationsBetaOutput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Transformations == input.Transformations ||
                    this.Transformations != null &&
                    input.Transformations != null &&
                    this.Transformations.SequenceEqual(input.Transformations)
                ) && 
                (
                    this.Pagination == input.Pagination ||
                    (this.Pagination != null &&
                    this.Pagination.Equals(input.Pagination))
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
                if (this.Transformations != null)
                {
                    hashCode = (hashCode * 59) + this.Transformations.GetHashCode();
                }
                if (this.Pagination != null)
                {
                    hashCode = (hashCode * 59) + this.Pagination.GetHashCode();
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
