/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 57.1.0
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
    /// Overrides the enabled or disabled state of the specified collection and / or properties within the schema.
    /// </summary>
    [DataContract(Name = "SpaceWarehouseSchemaOverride")]
    public partial class SpaceWarehouseSchemaOverride : IEquatable<SpaceWarehouseSchemaOverride>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceWarehouseSchemaOverride" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SpaceWarehouseSchemaOverride() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceWarehouseSchemaOverride" /> class.
        /// </summary>
        /// <param name="collection">The collection within the Source. (required).</param>
        /// <param name="enabled">Represents the overridden enabled state for the listed collection and / or properties. (required).</param>
        /// <param name="property">A map that contains the properties within the collection to which the Warehouse should sync..</param>
        public SpaceWarehouseSchemaOverride(string collection = default(string), bool enabled = default(bool), string property = default(string))
        {
            // to ensure "collection" is required (not null)
            if (collection == null)
            {
                throw new ArgumentNullException("collection is a required property for SpaceWarehouseSchemaOverride and cannot be null");
            }
            this.Collection = collection;
            this.Enabled = enabled;
            this.Property = property;
        }

        /// <summary>
        /// The collection within the Source.
        /// </summary>
        /// <value>The collection within the Source.</value>
        [DataMember(Name = "collection", IsRequired = true, EmitDefaultValue = true)]
        public string Collection { get; set; }

        /// <summary>
        /// Represents the overridden enabled state for the listed collection and / or properties.
        /// </summary>
        /// <value>Represents the overridden enabled state for the listed collection and / or properties.</value>
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// A map that contains the properties within the collection to which the Warehouse should sync.
        /// </summary>
        /// <value>A map that contains the properties within the collection to which the Warehouse should sync.</value>
        [DataMember(Name = "property", EmitDefaultValue = false)]
        public string Property { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SpaceWarehouseSchemaOverride {\n");
            sb.Append("  Collection: ").Append(Collection).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
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
            return this.Equals(input as SpaceWarehouseSchemaOverride);
        }

        /// <summary>
        /// Returns true if SpaceWarehouseSchemaOverride instances are equal
        /// </summary>
        /// <param name="input">Instance of SpaceWarehouseSchemaOverride to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpaceWarehouseSchemaOverride input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Collection == input.Collection ||
                    (this.Collection != null &&
                    this.Collection.Equals(input.Collection))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Property == input.Property ||
                    (this.Property != null &&
                    this.Property.Equals(input.Property))
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
                if (this.Collection != null)
                {
                    hashCode = (hashCode * 59) + this.Collection.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.Property != null)
                {
                    hashCode = (hashCode * 59) + this.Property.GetHashCode();
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
