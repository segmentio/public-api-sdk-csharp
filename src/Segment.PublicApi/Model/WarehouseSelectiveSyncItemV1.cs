/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.13.0
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
    /// Represents an entry in the Warehouse Selective Sync schema for a Warehouse and Source pair.
    /// </summary>
    [DataContract(Name = "WarehouseSelectiveSyncItemV1")]
    public partial class WarehouseSelectiveSyncItemV1 : IEquatable<WarehouseSelectiveSyncItemV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseSelectiveSyncItemV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WarehouseSelectiveSyncItemV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseSelectiveSyncItemV1" /> class.
        /// </summary>
        /// <param name="sourceId">The Source id attached to this Warehouse. (required).</param>
        /// <param name="collection">The collection within the Source. (required).</param>
        /// <param name="warehouseId">The id of the Warehouse this sync belongs to. (required).</param>
        /// <param name="enabled">Whether this Selective Sync item is enabled. (required).</param>
        /// <param name="properties">A map that contains the properties within the collection to which the Warehouse should sync. (required).</param>
        public WarehouseSelectiveSyncItemV1(string sourceId = default(string), string collection = default(string), string warehouseId = default(string), bool enabled = default(bool), Dictionary<string, Object> properties = default(Dictionary<string, Object>))
        {
            // to ensure "sourceId" is required (not null)
            if (sourceId == null)
            {
                throw new ArgumentNullException("sourceId is a required property for WarehouseSelectiveSyncItemV1 and cannot be null");
            }
            this.SourceId = sourceId;
            // to ensure "collection" is required (not null)
            if (collection == null)
            {
                throw new ArgumentNullException("collection is a required property for WarehouseSelectiveSyncItemV1 and cannot be null");
            }
            this.Collection = collection;
            // to ensure "warehouseId" is required (not null)
            if (warehouseId == null)
            {
                throw new ArgumentNullException("warehouseId is a required property for WarehouseSelectiveSyncItemV1 and cannot be null");
            }
            this.WarehouseId = warehouseId;
            this.Enabled = enabled;
            // to ensure "properties" is required (not null)
            if (properties == null)
            {
                throw new ArgumentNullException("properties is a required property for WarehouseSelectiveSyncItemV1 and cannot be null");
            }
            this.Properties = properties;
        }

        /// <summary>
        /// The Source id attached to this Warehouse.
        /// </summary>
        /// <value>The Source id attached to this Warehouse.</value>
        [DataMember(Name = "sourceId", IsRequired = true, EmitDefaultValue = true)]
        public string SourceId { get; set; }

        /// <summary>
        /// The collection within the Source.
        /// </summary>
        /// <value>The collection within the Source.</value>
        [DataMember(Name = "collection", IsRequired = true, EmitDefaultValue = true)]
        public string Collection { get; set; }

        /// <summary>
        /// The id of the Warehouse this sync belongs to.
        /// </summary>
        /// <value>The id of the Warehouse this sync belongs to.</value>
        [DataMember(Name = "warehouseId", IsRequired = true, EmitDefaultValue = true)]
        public string WarehouseId { get; set; }

        /// <summary>
        /// Whether this Selective Sync item is enabled.
        /// </summary>
        /// <value>Whether this Selective Sync item is enabled.</value>
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// A map that contains the properties within the collection to which the Warehouse should sync.
        /// </summary>
        /// <value>A map that contains the properties within the collection to which the Warehouse should sync.</value>
        [DataMember(Name = "properties", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WarehouseSelectiveSyncItemV1 {\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  Collection: ").Append(Collection).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(input as WarehouseSelectiveSyncItemV1);
        }

        /// <summary>
        /// Returns true if WarehouseSelectiveSyncItemV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of WarehouseSelectiveSyncItemV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WarehouseSelectiveSyncItemV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.Collection == input.Collection ||
                    (this.Collection != null &&
                    this.Collection.Equals(input.Collection))
                ) && 
                (
                    this.WarehouseId == input.WarehouseId ||
                    (this.WarehouseId != null &&
                    this.WarehouseId.Equals(input.WarehouseId))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
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
                if (this.SourceId != null)
                {
                    hashCode = (hashCode * 59) + this.SourceId.GetHashCode();
                }
                if (this.Collection != null)
                {
                    hashCode = (hashCode * 59) + this.Collection.GetHashCode();
                }
                if (this.WarehouseId != null)
                {
                    hashCode = (hashCode * 59) + this.WarehouseId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
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
