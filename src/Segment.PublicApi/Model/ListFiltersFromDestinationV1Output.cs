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
    /// Output for ListDestinationFiltersV1.
    /// </summary>
    [DataContract(Name = "ListFiltersFromDestinationV1Output")]
    public partial class ListFiltersFromDestinationV1Output : IEquatable<ListFiltersFromDestinationV1Output>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListFiltersFromDestinationV1Output" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListFiltersFromDestinationV1Output() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListFiltersFromDestinationV1Output" /> class.
        /// </summary>
        /// <param name="filters">A list of the filters that belong to the specified Destination instance. (required).</param>
        /// <param name="pagination">pagination (required).</param>
        public ListFiltersFromDestinationV1Output(List<DestinationFilterV1> filters = default(List<DestinationFilterV1>), PaginationOutput pagination = default(PaginationOutput))
        {
            // to ensure "filters" is required (not null)
            if (filters == null)
            {
                throw new ArgumentNullException("filters is a required property for ListFiltersFromDestinationV1Output and cannot be null");
            }
            this.Filters = filters;
            // to ensure "pagination" is required (not null)
            if (pagination == null)
            {
                throw new ArgumentNullException("pagination is a required property for ListFiltersFromDestinationV1Output and cannot be null");
            }
            this.Pagination = pagination;
        }

        /// <summary>
        /// A list of the filters that belong to the specified Destination instance.
        /// </summary>
        /// <value>A list of the filters that belong to the specified Destination instance.</value>
        [DataMember(Name = "filters", IsRequired = true, EmitDefaultValue = true)]
        public List<DestinationFilterV1> Filters { get; set; }

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
            sb.Append("class ListFiltersFromDestinationV1Output {\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
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
            return this.Equals(input as ListFiltersFromDestinationV1Output);
        }

        /// <summary>
        /// Returns true if ListFiltersFromDestinationV1Output instances are equal
        /// </summary>
        /// <param name="input">Instance of ListFiltersFromDestinationV1Output to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListFiltersFromDestinationV1Output input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Filters == input.Filters ||
                    this.Filters != null &&
                    input.Filters != null &&
                    this.Filters.SequenceEqual(input.Filters)
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
                if (this.Filters != null)
                {
                    hashCode = (hashCode * 59) + this.Filters.GetHashCode();
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
