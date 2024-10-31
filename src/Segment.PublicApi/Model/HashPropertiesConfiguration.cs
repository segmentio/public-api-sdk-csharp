/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 55.2.0
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
    /// HashPropertiesConfiguration
    /// </summary>
    [DataContract(Name = "HashPropertiesConfiguration")]
    public partial class HashPropertiesConfiguration : IEquatable<HashPropertiesConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Optional encoding to use for the hashing.
        /// </summary>
        /// <value>Optional encoding to use for the hashing.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EncodingEnum
        {
            /// <summary>
            /// Enum BASE16 for value: BASE16
            /// </summary>
            [EnumMember(Value = "BASE16")]
            BASE16 = 1,

            /// <summary>
            /// Enum BASE64 for value: BASE64
            /// </summary>
            [EnumMember(Value = "BASE64")]
            BASE64 = 2,

            /// <summary>
            /// Enum BASE64URL for value: BASE64URL
            /// </summary>
            [EnumMember(Value = "BASE64URL")]
            BASE64URL = 3,

            /// <summary>
            /// Enum HEX for value: HEX
            /// </summary>
            [EnumMember(Value = "HEX")]
            HEX = 4
        }


        /// <summary>
        /// Optional encoding to use for the hashing.
        /// </summary>
        /// <value>Optional encoding to use for the hashing.</value>
        [DataMember(Name = "encoding", EmitDefaultValue = false)]
        public EncodingEnum? Encoding { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HashPropertiesConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HashPropertiesConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HashPropertiesConfiguration" /> class.
        /// </summary>
        /// <param name="algorithm">Which algorithm to use to hash to properties. (required).</param>
        /// <param name="key">Optional key to hash with..</param>
        /// <param name="encoding">Optional encoding to use for the hashing..</param>
        /// <param name="paths">The paths to the properties to be hashed. (required).</param>
        public HashPropertiesConfiguration(string algorithm = default(string), string key = default(string), EncodingEnum? encoding = default(EncodingEnum?), List<string> paths = default(List<string>))
        {
            // to ensure "algorithm" is required (not null)
            if (algorithm == null)
            {
                throw new ArgumentNullException("algorithm is a required property for HashPropertiesConfiguration and cannot be null");
            }
            this.Algorithm = algorithm;
            // to ensure "paths" is required (not null)
            if (paths == null)
            {
                throw new ArgumentNullException("paths is a required property for HashPropertiesConfiguration and cannot be null");
            }
            this.Paths = paths;
            this.Key = key;
            this.Encoding = encoding;
        }

        /// <summary>
        /// Which algorithm to use to hash to properties.
        /// </summary>
        /// <value>Which algorithm to use to hash to properties.</value>
        [DataMember(Name = "algorithm", IsRequired = true, EmitDefaultValue = true)]
        public string Algorithm { get; set; }

        /// <summary>
        /// Optional key to hash with.
        /// </summary>
        /// <value>Optional key to hash with.</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// The paths to the properties to be hashed.
        /// </summary>
        /// <value>The paths to the properties to be hashed.</value>
        [DataMember(Name = "paths", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Paths { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HashPropertiesConfiguration {\n");
            sb.Append("  Algorithm: ").Append(Algorithm).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Encoding: ").Append(Encoding).Append("\n");
            sb.Append("  Paths: ").Append(Paths).Append("\n");
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
            return this.Equals(input as HashPropertiesConfiguration);
        }

        /// <summary>
        /// Returns true if HashPropertiesConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of HashPropertiesConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HashPropertiesConfiguration input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Algorithm == input.Algorithm ||
                    (this.Algorithm != null &&
                    this.Algorithm.Equals(input.Algorithm))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Encoding == input.Encoding ||
                    this.Encoding.Equals(input.Encoding)
                ) && 
                (
                    this.Paths == input.Paths ||
                    this.Paths != null &&
                    input.Paths != null &&
                    this.Paths.SequenceEqual(input.Paths)
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
                if (this.Algorithm != null)
                {
                    hashCode = (hashCode * 59) + this.Algorithm.GetHashCode();
                }
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Encoding.GetHashCode();
                if (this.Paths != null)
                {
                    hashCode = (hashCode * 59) + this.Paths.GetHashCode();
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
