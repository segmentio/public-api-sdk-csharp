/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 55.1.0
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
    /// Defines the result of listing Models.
    /// </summary>
    [DataContract(Name = "ListReverseEtlModelsOutput")]
    public partial class ListReverseEtlModelsOutput : IEquatable<ListReverseEtlModelsOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListReverseEtlModelsOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListReverseEtlModelsOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListReverseEtlModelsOutput" /> class.
        /// </summary>
        /// <param name="models">A list of Models that belong to the Workspace. (required).</param>
        /// <param name="pagination">pagination (required).</param>
        public ListReverseEtlModelsOutput(List<ReverseEtlModel> models = default(List<ReverseEtlModel>), PaginationOutput pagination = default(PaginationOutput))
        {
            // to ensure "models" is required (not null)
            if (models == null)
            {
                throw new ArgumentNullException("models is a required property for ListReverseEtlModelsOutput and cannot be null");
            }
            this.Models = models;
            // to ensure "pagination" is required (not null)
            if (pagination == null)
            {
                throw new ArgumentNullException("pagination is a required property for ListReverseEtlModelsOutput and cannot be null");
            }
            this.Pagination = pagination;
        }

        /// <summary>
        /// A list of Models that belong to the Workspace.
        /// </summary>
        /// <value>A list of Models that belong to the Workspace.</value>
        [DataMember(Name = "models", IsRequired = true, EmitDefaultValue = true)]
        public List<ReverseEtlModel> Models { get; set; }

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
            sb.Append("class ListReverseEtlModelsOutput {\n");
            sb.Append("  Models: ").Append(Models).Append("\n");
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
            return this.Equals(input as ListReverseEtlModelsOutput);
        }

        /// <summary>
        /// Returns true if ListReverseEtlModelsOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of ListReverseEtlModelsOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListReverseEtlModelsOutput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Models == input.Models ||
                    this.Models != null &&
                    input.Models != null &&
                    this.Models.SequenceEqual(input.Models)
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
                if (this.Models != null)
                {
                    hashCode = (hashCode * 59) + this.Models.GetHashCode();
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
