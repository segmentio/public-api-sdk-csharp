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
    /// Returns a list of Warehouses connected to a Source.
    /// </summary>
    [DataContract(Name = "ListConnectedWarehousesFromSourceAlphaOutput")]
    public partial class ListConnectedWarehousesFromSourceAlphaOutput : IEquatable<ListConnectedWarehousesFromSourceAlphaOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListConnectedWarehousesFromSourceAlphaOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListConnectedWarehousesFromSourceAlphaOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListConnectedWarehousesFromSourceAlphaOutput" /> class.
        /// </summary>
        /// <param name="warehouses">A list that contains the Warehouses connected to the Source. (required).</param>
        /// <param name="pagination">pagination (required).</param>
        public ListConnectedWarehousesFromSourceAlphaOutput(List<WarehouseV1> warehouses = default(List<WarehouseV1>), PaginationOutput pagination = default(PaginationOutput))
        {
            // to ensure "warehouses" is required (not null)
            if (warehouses == null)
            {
                throw new ArgumentNullException("warehouses is a required property for ListConnectedWarehousesFromSourceAlphaOutput and cannot be null");
            }
            this.Warehouses = warehouses;
            // to ensure "pagination" is required (not null)
            if (pagination == null)
            {
                throw new ArgumentNullException("pagination is a required property for ListConnectedWarehousesFromSourceAlphaOutput and cannot be null");
            }
            this.Pagination = pagination;
        }

        /// <summary>
        /// A list that contains the Warehouses connected to the Source.
        /// </summary>
        /// <value>A list that contains the Warehouses connected to the Source.</value>
        [DataMember(Name = "warehouses", IsRequired = true, EmitDefaultValue = true)]
        public List<WarehouseV1> Warehouses { get; set; }

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
            sb.Append("class ListConnectedWarehousesFromSourceAlphaOutput {\n");
            sb.Append("  Warehouses: ").Append(Warehouses).Append("\n");
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
            return this.Equals(input as ListConnectedWarehousesFromSourceAlphaOutput);
        }

        /// <summary>
        /// Returns true if ListConnectedWarehousesFromSourceAlphaOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of ListConnectedWarehousesFromSourceAlphaOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListConnectedWarehousesFromSourceAlphaOutput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Warehouses == input.Warehouses ||
                    this.Warehouses != null &&
                    input.Warehouses != null &&
                    this.Warehouses.SequenceEqual(input.Warehouses)
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
                if (this.Warehouses != null)
                {
                    hashCode = (hashCode * 59) + this.Warehouses.GetHashCode();
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
