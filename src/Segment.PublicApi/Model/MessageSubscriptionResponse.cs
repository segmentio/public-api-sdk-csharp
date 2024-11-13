/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 57.0.0
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
    /// MessageSubscriptionResponse
    /// </summary>
    [DataContract(Name = "MessageSubscriptionResponse")]
    public partial class MessageSubscriptionResponse : IEquatable<MessageSubscriptionResponse>, IValidatableObject
    {
        /// <summary>
        /// Type is communication medium used. Either SMS, EMAIL or WHATSAPP.
        /// </summary>
        /// <value>Type is communication medium used. Either SMS, EMAIL or WHATSAPP.</value>
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
        /// Type is communication medium used. Either SMS, EMAIL or WHATSAPP.
        /// </summary>
        /// <value>Type is communication medium used. Either SMS, EMAIL or WHATSAPP.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// The user subscribed, unsubscribed, or on initial status.
        /// </summary>
        /// <value>The user subscribed, unsubscribed, or on initial status.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum DIDNOTSUBSCRIBE for value: DID_NOT_SUBSCRIBE
            /// </summary>
            [EnumMember(Value = "DID_NOT_SUBSCRIBE")]
            DIDNOTSUBSCRIBE = 1,

            /// <summary>
            /// Enum SUBSCRIBED for value: SUBSCRIBED
            /// </summary>
            [EnumMember(Value = "SUBSCRIBED")]
            SUBSCRIBED = 2,

            /// <summary>
            /// Enum UNSUBSCRIBED for value: UNSUBSCRIBED
            /// </summary>
            [EnumMember(Value = "UNSUBSCRIBED")]
            UNSUBSCRIBED = 3
        }


        /// <summary>
        /// The user subscribed, unsubscribed, or on initial status.
        /// </summary>
        /// <value>The user subscribed, unsubscribed, or on initial status.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSubscriptionResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessageSubscriptionResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSubscriptionResponse" /> class.
        /// </summary>
        /// <param name="key">Key is the phone number or email. (required).</param>
        /// <param name="type">Type is communication medium used. Either SMS, EMAIL or WHATSAPP. (required).</param>
        /// <param name="status">The user subscribed, unsubscribed, or on initial status..</param>
        /// <param name="errors">Error messages..</param>
        /// <param name="groups">Optional subscription groups..</param>
        public MessageSubscriptionResponse(string key = default(string), TypeEnum type = default(TypeEnum), StatusEnum? status = default(StatusEnum?), List<MessageSubscriptionResponseError> errors = default(List<MessageSubscriptionResponseError>), List<UpdateGroupSubscriptionStatusResponse> groups = default(List<UpdateGroupSubscriptionStatusResponse>))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for MessageSubscriptionResponse and cannot be null");
            }
            this.Key = key;
            this.Type = type;
            this.Status = status;
            this.Errors = errors;
            this.Groups = groups;
        }

        /// <summary>
        /// Key is the phone number or email.
        /// </summary>
        /// <value>Key is the phone number or email.</value>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Error messages.
        /// </summary>
        /// <value>Error messages.</value>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public List<MessageSubscriptionResponseError> Errors { get; set; }

        /// <summary>
        /// Optional subscription groups.
        /// </summary>
        /// <value>Optional subscription groups.</value>
        [DataMember(Name = "groups", EmitDefaultValue = false)]
        public List<UpdateGroupSubscriptionStatusResponse> Groups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MessageSubscriptionResponse {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
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
            return this.Equals(input as MessageSubscriptionResponse);
        }

        /// <summary>
        /// Returns true if MessageSubscriptionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageSubscriptionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageSubscriptionResponse input)
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
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
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
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Errors != null)
                {
                    hashCode = (hashCode * 59) + this.Errors.GetHashCode();
                }
                if (this.Groups != null)
                {
                    hashCode = (hashCode * 59) + this.Groups.GetHashCode();
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
