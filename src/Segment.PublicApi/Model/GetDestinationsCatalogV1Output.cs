/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.0.0
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
    /// Returns a list of all Destination catalog items contained within a given page.
    /// </summary>
    [DataContract(Name = "GetDestinationsCatalogV1Output")]
    public partial class GetDestinationsCatalogV1Output : IEquatable<GetDestinationsCatalogV1Output>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDestinationsCatalogV1Output" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetDestinationsCatalogV1Output() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDestinationsCatalogV1Output" /> class.
        /// </summary>
        /// <param name="destinationsCatalog">All Destination catalog items contained within the requested page. (required).</param>
        /// <param name="pagination">pagination (required).</param>
        public GetDestinationsCatalogV1Output(List<DestinationMetadataV1> destinationsCatalog = default(List<DestinationMetadataV1>), PaginationOutput pagination = default(PaginationOutput))
        {
            // to ensure "destinationsCatalog" is required (not null)
            if (destinationsCatalog == null)
            {
                throw new ArgumentNullException("destinationsCatalog is a required property for GetDestinationsCatalogV1Output and cannot be null");
            }
            this.DestinationsCatalog = destinationsCatalog;
            // to ensure "pagination" is required (not null)
            if (pagination == null)
            {
                throw new ArgumentNullException("pagination is a required property for GetDestinationsCatalogV1Output and cannot be null");
            }
            this.Pagination = pagination;
        }

        /// <summary>
        /// All Destination catalog items contained within the requested page.
        /// </summary>
        /// <value>All Destination catalog items contained within the requested page.</value>
        [DataMember(Name = "destinationsCatalog", IsRequired = true, EmitDefaultValue = true)]
        public List<DestinationMetadataV1> DestinationsCatalog { get; set; }

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
            sb.Append("class GetDestinationsCatalogV1Output {\n");
            sb.Append("  DestinationsCatalog: ").Append(DestinationsCatalog).Append("\n");
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
            return this.Equals(input as GetDestinationsCatalogV1Output);
        }

        /// <summary>
        /// Returns true if GetDestinationsCatalogV1Output instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDestinationsCatalogV1Output to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDestinationsCatalogV1Output input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DestinationsCatalog == input.DestinationsCatalog ||
                    this.DestinationsCatalog != null &&
                    input.DestinationsCatalog != null &&
                    this.DestinationsCatalog.SequenceEqual(input.DestinationsCatalog)
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
                if (this.DestinationsCatalog != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationsCatalog.GetHashCode();
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
