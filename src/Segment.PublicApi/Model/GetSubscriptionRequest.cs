/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 57.4.0
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
    /// GetSubscriptionRequest
    /// </summary>
    [DataContract(Name = "GetSubscriptionRequest")]
    public partial class GetSubscriptionRequest : IEquatable<GetSubscriptionRequest>, IValidatableObject
    {
        /// <summary>
        /// Type is communication medium used.
        /// </summary>
        /// <value>Type is communication medium used.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum ANDROIDPUSH for value: ANDROID_PUSH
            /// </summary>
            [EnumMember(Value = "ANDROID_PUSH")]
            ANDROIDPUSH = 1,

            /// <summary>
            /// Enum EMAIL for value: EMAIL
            /// </summary>
            [EnumMember(Value = "EMAIL")]
            EMAIL = 2,

            /// <summary>
            /// Enum IOSPUSH for value: IOS_PUSH
            /// </summary>
            [EnumMember(Value = "IOS_PUSH")]
            IOSPUSH = 3,

            /// <summary>
            /// Enum SMS for value: SMS
            /// </summary>
            [EnumMember(Value = "SMS")]
            SMS = 4,

            /// <summary>
            /// Enum WHATSAPP for value: WHATSAPP
            /// </summary>
            [EnumMember(Value = "WHATSAPP")]
            WHATSAPP = 5
        }


        /// <summary>
        /// Type is communication medium used.
        /// </summary>
        /// <value>Type is communication medium used.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriptionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetSubscriptionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriptionRequest" /> class.
        /// </summary>
        /// <param name="key">Key is the phone number or email. (required).</param>
        /// <param name="type">Type is communication medium used. (required).</param>
        public GetSubscriptionRequest(string key = default(string), TypeEnum type = default(TypeEnum))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for GetSubscriptionRequest and cannot be null");
            }
            this.Key = key;
            this.Type = type;
        }

        /// <summary>
        /// Key is the phone number or email.
        /// </summary>
        /// <value>Key is the phone number or email.</value>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetSubscriptionRequest {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as GetSubscriptionRequest);
        }

        /// <summary>
        /// Returns true if GetSubscriptionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSubscriptionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSubscriptionRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
