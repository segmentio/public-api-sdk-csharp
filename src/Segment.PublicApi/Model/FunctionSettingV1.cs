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
    /// FunctionSettingV1
    /// </summary>
    [DataContract(Name = "FunctionSettingV1")]
    public partial class FunctionSettingV1 : IEquatable<FunctionSettingV1>, IValidatableObject
    {
        /// <summary>
        /// The type of this Function Setting.
        /// </summary>
        /// <value>The type of this Function Setting.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum ARRAY for value: ARRAY
            /// </summary>
            [EnumMember(Value = "ARRAY")]
            ARRAY = 1,

            /// <summary>
            /// Enum BOOLEAN for value: BOOLEAN
            /// </summary>
            [EnumMember(Value = "BOOLEAN")]
            BOOLEAN = 2,

            /// <summary>
            /// Enum STRING for value: STRING
            /// </summary>
            [EnumMember(Value = "STRING")]
            STRING = 3,

            /// <summary>
            /// Enum TEXTMAP for value: TEXT_MAP
            /// </summary>
            [EnumMember(Value = "TEXT_MAP")]
            TEXTMAP = 4
        }


        /// <summary>
        /// The type of this Function Setting.
        /// </summary>
        /// <value>The type of this Function Setting.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionSettingV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FunctionSettingV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionSettingV1" /> class.
        /// </summary>
        /// <param name="name">The name of this Function Setting. (required).</param>
        /// <param name="label">The label for this Function Setting. (required).</param>
        /// <param name="description">A description of this Function Setting. (required).</param>
        /// <param name="type">The type of this Function Setting. (required).</param>
        /// <param name="required">Whether this Function Setting is required. (required).</param>
        /// <param name="sensitive">Whether this Function Setting contains sensitive information. (required).</param>
        public FunctionSettingV1(string name = default(string), string label = default(string), string description = default(string), TypeEnum type = default(TypeEnum), bool required = default(bool), bool sensitive = default(bool))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for FunctionSettingV1 and cannot be null");
            }
            this.Name = name;
            // to ensure "label" is required (not null)
            if (label == null)
            {
                throw new ArgumentNullException("label is a required property for FunctionSettingV1 and cannot be null");
            }
            this.Label = label;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for FunctionSettingV1 and cannot be null");
            }
            this.Description = description;
            this.Type = type;
            this.Required = required;
            this.Sensitive = sensitive;
        }

        /// <summary>
        /// The name of this Function Setting.
        /// </summary>
        /// <value>The name of this Function Setting.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The label for this Function Setting.
        /// </summary>
        /// <value>The label for this Function Setting.</value>
        [DataMember(Name = "label", IsRequired = true, EmitDefaultValue = true)]
        public string Label { get; set; }

        /// <summary>
        /// A description of this Function Setting.
        /// </summary>
        /// <value>A description of this Function Setting.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Whether this Function Setting is required.
        /// </summary>
        /// <value>Whether this Function Setting is required.</value>
        [DataMember(Name = "required", IsRequired = true, EmitDefaultValue = true)]
        public bool Required { get; set; }

        /// <summary>
        /// Whether this Function Setting contains sensitive information.
        /// </summary>
        /// <value>Whether this Function Setting contains sensitive information.</value>
        [DataMember(Name = "sensitive", IsRequired = true, EmitDefaultValue = true)]
        public bool Sensitive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FunctionSettingV1 {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Sensitive: ").Append(Sensitive).Append("\n");
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
            return this.Equals(input as FunctionSettingV1);
        }

        /// <summary>
        /// Returns true if FunctionSettingV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of FunctionSettingV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FunctionSettingV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Required == input.Required ||
                    this.Required.Equals(input.Required)
                ) && 
                (
                    this.Sensitive == input.Sensitive ||
                    this.Sensitive.Equals(input.Sensitive)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.Required.GetHashCode();
                hashCode = (hashCode * 59) + this.Sensitive.GetHashCode();
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
