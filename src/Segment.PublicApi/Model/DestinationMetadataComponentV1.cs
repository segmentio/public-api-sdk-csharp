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
    /// Represents a component this Destination provides.
    /// </summary>
    [DataContract(Name = "DestinationMetadataComponentV1")]
    public partial class DestinationMetadataComponentV1 : IEquatable<DestinationMetadataComponentV1>, IValidatableObject
    {
        /// <summary>
        /// The component type.
        /// </summary>
        /// <value>The component type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum ANDROID for value: ANDROID
            /// </summary>
            [EnumMember(Value = "ANDROID")]
            ANDROID = 1,

            /// <summary>
            /// Enum BROWSER for value: BROWSER
            /// </summary>
            [EnumMember(Value = "BROWSER")]
            BROWSER = 2,

            /// <summary>
            /// Enum IOS for value: IOS
            /// </summary>
            [EnumMember(Value = "IOS")]
            IOS = 3,

            /// <summary>
            /// Enum SERVER for value: SERVER
            /// </summary>
            [EnumMember(Value = "SERVER")]
            SERVER = 4
        }


        /// <summary>
        /// The component type.
        /// </summary>
        /// <value>The component type.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// The owner of this component. Either &#39;SEGMENT&#39; or &#39;PARTNER&#39;.
        /// </summary>
        /// <value>The owner of this component. Either &#39;SEGMENT&#39; or &#39;PARTNER&#39;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OwnerEnum
        {
            /// <summary>
            /// Enum PARTNER for value: PARTNER
            /// </summary>
            [EnumMember(Value = "PARTNER")]
            PARTNER = 1,

            /// <summary>
            /// Enum SEGMENT for value: SEGMENT
            /// </summary>
            [EnumMember(Value = "SEGMENT")]
            SEGMENT = 2
        }


        /// <summary>
        /// The owner of this component. Either &#39;SEGMENT&#39; or &#39;PARTNER&#39;.
        /// </summary>
        /// <value>The owner of this component. Either &#39;SEGMENT&#39; or &#39;PARTNER&#39;.</value>
        [DataMember(Name = "owner", EmitDefaultValue = false)]
        public OwnerEnum? Owner { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationMetadataComponentV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DestinationMetadataComponentV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationMetadataComponentV1" /> class.
        /// </summary>
        /// <param name="type">The component type. (required).</param>
        /// <param name="code">Link to the repository hosting the code for this component. (required).</param>
        /// <param name="owner">The owner of this component. Either &#39;SEGMENT&#39; or &#39;PARTNER&#39;..</param>
        public DestinationMetadataComponentV1(TypeEnum type = default(TypeEnum), string code = default(string), OwnerEnum? owner = default(OwnerEnum?))
        {
            this.Type = type;
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for DestinationMetadataComponentV1 and cannot be null");
            }
            this.Code = code;
            this.Owner = owner;
        }

        /// <summary>
        /// Link to the repository hosting the code for this component.
        /// </summary>
        /// <value>Link to the repository hosting the code for this component.</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinationMetadataComponentV1 {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
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
            return this.Equals(input as DestinationMetadataComponentV1);
        }

        /// <summary>
        /// Returns true if DestinationMetadataComponentV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinationMetadataComponentV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinationMetadataComponentV1 input)
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
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Owner == input.Owner ||
                    this.Owner.Equals(input.Owner)
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Owner.GetHashCode();
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
