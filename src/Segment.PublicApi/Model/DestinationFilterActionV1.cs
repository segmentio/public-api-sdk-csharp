/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 55.0.0
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
    /// Represents a Destination filter action.
    /// </summary>
    [DataContract(Name = "DestinationFilterActionV1")]
    public partial class DestinationFilterActionV1 : IEquatable<DestinationFilterActionV1>, IValidatableObject
    {
        /// <summary>
        /// The kind of Transformation to apply to any matched properties.
        /// </summary>
        /// <value>The kind of Transformation to apply to any matched properties.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum ALLOWPROPERTIES for value: ALLOW_PROPERTIES
            /// </summary>
            [EnumMember(Value = "ALLOW_PROPERTIES")]
            ALLOWPROPERTIES = 1,

            /// <summary>
            /// Enum DROP for value: DROP
            /// </summary>
            [EnumMember(Value = "DROP")]
            DROP = 2,

            /// <summary>
            /// Enum DROPPROPERTIES for value: DROP_PROPERTIES
            /// </summary>
            [EnumMember(Value = "DROP_PROPERTIES")]
            DROPPROPERTIES = 3,

            /// <summary>
            /// Enum SAMPLE for value: SAMPLE
            /// </summary>
            [EnumMember(Value = "SAMPLE")]
            SAMPLE = 4
        }


        /// <summary>
        /// The kind of Transformation to apply to any matched properties.
        /// </summary>
        /// <value>The kind of Transformation to apply to any matched properties.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationFilterActionV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DestinationFilterActionV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationFilterActionV1" /> class.
        /// </summary>
        /// <param name="type">The kind of Transformation to apply to any matched properties. (required).</param>
        /// <param name="fields">A dictionary of paths to object keys that this filter applies to.  The literal string &#39;&#39; represents the top level of the object..</param>
        /// <param name="percent">A decimal between 0 and 1 used for &#39;sample&#39; type events and influences the likelihood of sampling to occur..</param>
        /// <param name="path">The JSON path to a property within a payload object from which Segment generates a deterministic sampling rate..</param>
        public DestinationFilterActionV1(TypeEnum type = default(TypeEnum), Dictionary<string, Object> fields = default(Dictionary<string, Object>), decimal percent = default(decimal), string path = default(string))
        {
            this.Type = type;
            this.Fields = fields;
            this.Percent = percent;
            this.Path = path;
        }

        /// <summary>
        /// A dictionary of paths to object keys that this filter applies to.  The literal string &#39;&#39; represents the top level of the object.
        /// </summary>
        /// <value>A dictionary of paths to object keys that this filter applies to.  The literal string &#39;&#39; represents the top level of the object.</value>
        [DataMember(Name = "fields", EmitDefaultValue = false)]
        public Dictionary<string, Object> Fields { get; set; }

        /// <summary>
        /// A decimal between 0 and 1 used for &#39;sample&#39; type events and influences the likelihood of sampling to occur.
        /// </summary>
        /// <value>A decimal between 0 and 1 used for &#39;sample&#39; type events and influences the likelihood of sampling to occur.</value>
        [DataMember(Name = "percent", EmitDefaultValue = false)]
        public decimal Percent { get; set; }

        /// <summary>
        /// The JSON path to a property within a payload object from which Segment generates a deterministic sampling rate.
        /// </summary>
        /// <value>The JSON path to a property within a payload object from which Segment generates a deterministic sampling rate.</value>
        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinationFilterActionV1 {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Percent: ").Append(Percent).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
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
            return this.Equals(input as DestinationFilterActionV1);
        }

        /// <summary>
        /// Returns true if DestinationFilterActionV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinationFilterActionV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinationFilterActionV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.Percent == input.Percent ||
                    this.Percent.Equals(input.Percent)
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Fields != null)
                {
                    hashCode = (hashCode * 59) + this.Fields.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Percent.GetHashCode();
                if (this.Path != null)
                {
                    hashCode = (hashCode * 59) + this.Path.GetHashCode();
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
