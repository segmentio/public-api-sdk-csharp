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
    /// Returns a list of all Source catalog items contained within a given page.
    /// </summary>
    [DataContract(Name = "GetSourcesCatalogV1Output")]
    public partial class GetSourcesCatalogV1Output : IEquatable<GetSourcesCatalogV1Output>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSourcesCatalogV1Output" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetSourcesCatalogV1Output() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSourcesCatalogV1Output" /> class.
        /// </summary>
        /// <param name="sourcesCatalog">All Source catalog items contained within the requested page. (required).</param>
        /// <param name="pagination">pagination (required).</param>
        public GetSourcesCatalogV1Output(List<SourceMetadataV1> sourcesCatalog = default(List<SourceMetadataV1>), PaginationOutput pagination = default(PaginationOutput))
        {
            // to ensure "sourcesCatalog" is required (not null)
            if (sourcesCatalog == null)
            {
                throw new ArgumentNullException("sourcesCatalog is a required property for GetSourcesCatalogV1Output and cannot be null");
            }
            this.SourcesCatalog = sourcesCatalog;
            // to ensure "pagination" is required (not null)
            if (pagination == null)
            {
                throw new ArgumentNullException("pagination is a required property for GetSourcesCatalogV1Output and cannot be null");
            }
            this.Pagination = pagination;
        }

        /// <summary>
        /// All Source catalog items contained within the requested page.
        /// </summary>
        /// <value>All Source catalog items contained within the requested page.</value>
        [DataMember(Name = "sourcesCatalog", IsRequired = true, EmitDefaultValue = true)]
        public List<SourceMetadataV1> SourcesCatalog { get; set; }

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
            sb.Append("class GetSourcesCatalogV1Output {\n");
            sb.Append("  SourcesCatalog: ").Append(SourcesCatalog).Append("\n");
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
            return this.Equals(input as GetSourcesCatalogV1Output);
        }

        /// <summary>
        /// Returns true if GetSourcesCatalogV1Output instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSourcesCatalogV1Output to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSourcesCatalogV1Output input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SourcesCatalog == input.SourcesCatalog ||
                    this.SourcesCatalog != null &&
                    input.SourcesCatalog != null &&
                    this.SourcesCatalog.SequenceEqual(input.SourcesCatalog)
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
                if (this.SourcesCatalog != null)
                {
                    hashCode = (hashCode * 59) + this.SourcesCatalog.GetHashCode();
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
