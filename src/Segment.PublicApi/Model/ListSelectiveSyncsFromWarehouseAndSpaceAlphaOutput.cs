/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.2.0
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
    /// Results containing the Selective Sync configuration for a Space Warehouse Connection.
    /// </summary>
    [DataContract(Name = "ListSelectiveSyncsFromWarehouseAndSpaceAlphaOutput")]
    public partial class ListSelectiveSyncsFromWarehouseAndSpaceAlphaOutput : IEquatable<ListSelectiveSyncsFromWarehouseAndSpaceAlphaOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSelectiveSyncsFromWarehouseAndSpaceAlphaOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListSelectiveSyncsFromWarehouseAndSpaceAlphaOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSelectiveSyncsFromWarehouseAndSpaceAlphaOutput" /> class.
        /// </summary>
        /// <param name="items">Represents a list of collections and properties synced to the Warehouse. (required).</param>
        /// <param name="enableEventTables">Optional. Represents the enabled state of all event tables..</param>
        /// <param name="pagination">pagination (required).</param>
        public ListSelectiveSyncsFromWarehouseAndSpaceAlphaOutput(List<SpaceWarehouseSelectiveSyncItemAlpha> items = default(List<SpaceWarehouseSelectiveSyncItemAlpha>), bool enableEventTables = default(bool), PaginationOutput pagination = default(PaginationOutput))
        {
            // to ensure "items" is required (not null)
            if (items == null)
            {
                throw new ArgumentNullException("items is a required property for ListSelectiveSyncsFromWarehouseAndSpaceAlphaOutput and cannot be null");
            }
            this.Items = items;
            // to ensure "pagination" is required (not null)
            if (pagination == null)
            {
                throw new ArgumentNullException("pagination is a required property for ListSelectiveSyncsFromWarehouseAndSpaceAlphaOutput and cannot be null");
            }
            this.Pagination = pagination;
            this.EnableEventTables = enableEventTables;
        }

        /// <summary>
        /// Represents a list of collections and properties synced to the Warehouse.
        /// </summary>
        /// <value>Represents a list of collections and properties synced to the Warehouse.</value>
        [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = true)]
        public List<SpaceWarehouseSelectiveSyncItemAlpha> Items { get; set; }

        /// <summary>
        /// Optional. Represents the enabled state of all event tables.
        /// </summary>
        /// <value>Optional. Represents the enabled state of all event tables.</value>
        [DataMember(Name = "enableEventTables", EmitDefaultValue = true)]
        public bool EnableEventTables { get; set; }

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
            sb.Append("class ListSelectiveSyncsFromWarehouseAndSpaceAlphaOutput {\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  EnableEventTables: ").Append(EnableEventTables).Append("\n");
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
            return this.Equals(input as ListSelectiveSyncsFromWarehouseAndSpaceAlphaOutput);
        }

        /// <summary>
        /// Returns true if ListSelectiveSyncsFromWarehouseAndSpaceAlphaOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of ListSelectiveSyncsFromWarehouseAndSpaceAlphaOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListSelectiveSyncsFromWarehouseAndSpaceAlphaOutput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.EnableEventTables == input.EnableEventTables ||
                    this.EnableEventTables.Equals(input.EnableEventTables)
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
                if (this.Items != null)
                {
                    hashCode = (hashCode * 59) + this.Items.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EnableEventTables.GetHashCode();
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
