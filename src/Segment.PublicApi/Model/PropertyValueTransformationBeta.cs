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
    /// PropertyValueTransformationBeta
    /// </summary>
    [DataContract(Name = "PropertyValueTransformationBeta")]
    public partial class PropertyValueTransformationBeta : IEquatable<PropertyValueTransformationBeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyValueTransformationBeta" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PropertyValueTransformationBeta() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyValueTransformationBeta" /> class.
        /// </summary>
        /// <param name="propertyPaths">The property paths. The maximum number of paths is 10. (required).</param>
        /// <param name="propertyValue">The new value of the property paths. (required).</param>
        public PropertyValueTransformationBeta(List<string> propertyPaths = default(List<string>), string propertyValue = default(string))
        {
            // to ensure "propertyPaths" is required (not null)
            if (propertyPaths == null)
            {
                throw new ArgumentNullException("propertyPaths is a required property for PropertyValueTransformationBeta and cannot be null");
            }
            this.PropertyPaths = propertyPaths;
            // to ensure "propertyValue" is required (not null)
            if (propertyValue == null)
            {
                throw new ArgumentNullException("propertyValue is a required property for PropertyValueTransformationBeta and cannot be null");
            }
            this.PropertyValue = propertyValue;
        }

        /// <summary>
        /// The property paths. The maximum number of paths is 10.
        /// </summary>
        /// <value>The property paths. The maximum number of paths is 10.</value>
        [DataMember(Name = "propertyPaths", IsRequired = true, EmitDefaultValue = true)]
        public List<string> PropertyPaths { get; set; }

        /// <summary>
        /// The new value of the property paths.
        /// </summary>
        /// <value>The new value of the property paths.</value>
        [DataMember(Name = "propertyValue", IsRequired = true, EmitDefaultValue = true)]
        public string PropertyValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PropertyValueTransformationBeta {\n");
            sb.Append("  PropertyPaths: ").Append(PropertyPaths).Append("\n");
            sb.Append("  PropertyValue: ").Append(PropertyValue).Append("\n");
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
            return this.Equals(input as PropertyValueTransformationBeta);
        }

        /// <summary>
        /// Returns true if PropertyValueTransformationBeta instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertyValueTransformationBeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyValueTransformationBeta input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PropertyPaths == input.PropertyPaths ||
                    this.PropertyPaths != null &&
                    input.PropertyPaths != null &&
                    this.PropertyPaths.SequenceEqual(input.PropertyPaths)
                ) && 
                (
                    this.PropertyValue == input.PropertyValue ||
                    (this.PropertyValue != null &&
                    this.PropertyValue.Equals(input.PropertyValue))
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
                if (this.PropertyPaths != null)
                {
                    hashCode = (hashCode * 59) + this.PropertyPaths.GetHashCode();
                }
                if (this.PropertyValue != null)
                {
                    hashCode = (hashCode * 59) + this.PropertyValue.GetHashCode();
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