/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 57.0.1
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
    /// UpsertRuleV1
    /// </summary>
    [DataContract(Name = "UpsertRuleV1")]
    public partial class UpsertRuleV1 : IEquatable<UpsertRuleV1>, IValidatableObject
    {
        /// <summary>
        /// The type for this Tracking Plan rule.
        /// </summary>
        /// <value>The type for this Tracking Plan rule.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum COMMON for value: COMMON
            /// </summary>
            [EnumMember(Value = "COMMON")]
            COMMON = 1,

            /// <summary>
            /// Enum GROUP for value: GROUP
            /// </summary>
            [EnumMember(Value = "GROUP")]
            GROUP = 2,

            /// <summary>
            /// Enum IDENTIFY for value: IDENTIFY
            /// </summary>
            [EnumMember(Value = "IDENTIFY")]
            IDENTIFY = 3,

            /// <summary>
            /// Enum PAGE for value: PAGE
            /// </summary>
            [EnumMember(Value = "PAGE")]
            PAGE = 4,

            /// <summary>
            /// Enum SCREEN for value: SCREEN
            /// </summary>
            [EnumMember(Value = "SCREEN")]
            SCREEN = 5,

            /// <summary>
            /// Enum TRACK for value: TRACK
            /// </summary>
            [EnumMember(Value = "TRACK")]
            TRACK = 6
        }


        /// <summary>
        /// The type for this Tracking Plan rule.
        /// </summary>
        /// <value>The type for this Tracking Plan rule.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertRuleV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpsertRuleV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertRuleV1" /> class.
        /// </summary>
        /// <param name="newKey">This rule&#39;s new intended key..</param>
        /// <param name="type">The type for this Tracking Plan rule. (required).</param>
        /// <param name="key">Key to this rule (free-form string like &#39;Button clicked&#39;)..</param>
        /// <param name="jsonSchema">JSON Schema of this rule. (required).</param>
        /// <param name="varVersion">Version of this rule. (required).</param>
        public UpsertRuleV1(string newKey = default(string), TypeEnum type = default(TypeEnum), string key = default(string), Object jsonSchema = default(Object), decimal varVersion = default(decimal))
        {
            this.Type = type;
            // to ensure "jsonSchema" is required (not null)
            if (jsonSchema == null)
            {
                throw new ArgumentNullException("jsonSchema is a required property for UpsertRuleV1 and cannot be null");
            }
            this.JsonSchema = jsonSchema;
            this.VarVersion = varVersion;
            this.NewKey = newKey;
            this.Key = key;
        }

        /// <summary>
        /// This rule&#39;s new intended key.
        /// </summary>
        /// <value>This rule&#39;s new intended key.</value>
        [DataMember(Name = "newKey", EmitDefaultValue = false)]
        public string NewKey { get; set; }

        /// <summary>
        /// Key to this rule (free-form string like &#39;Button clicked&#39;).
        /// </summary>
        /// <value>Key to this rule (free-form string like &#39;Button clicked&#39;).</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// JSON Schema of this rule.
        /// </summary>
        /// <value>JSON Schema of this rule.</value>
        [DataMember(Name = "jsonSchema", IsRequired = true, EmitDefaultValue = true)]
        public Object JsonSchema { get; set; }

        /// <summary>
        /// Version of this rule.
        /// </summary>
        /// <value>Version of this rule.</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public decimal VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpsertRuleV1 {\n");
            sb.Append("  NewKey: ").Append(NewKey).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  JsonSchema: ").Append(JsonSchema).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
            return this.Equals(input as UpsertRuleV1);
        }

        /// <summary>
        /// Returns true if UpsertRuleV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of UpsertRuleV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpsertRuleV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NewKey == input.NewKey ||
                    (this.NewKey != null &&
                    this.NewKey.Equals(input.NewKey))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.JsonSchema == input.JsonSchema ||
                    (this.JsonSchema != null &&
                    this.JsonSchema.Equals(input.JsonSchema))
                ) && 
                (
                    this.VarVersion == input.VarVersion ||
                    this.VarVersion.Equals(input.VarVersion)
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
                if (this.NewKey != null)
                {
                    hashCode = (hashCode * 59) + this.NewKey.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                if (this.JsonSchema != null)
                {
                    hashCode = (hashCode * 59) + this.JsonSchema.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VarVersion.GetHashCode();
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
