/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.0.1
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
    /// GetMessagingSubscriptionFailureResponse
    /// </summary>
    [DataContract(Name = "GetMessagingSubscriptionFailureResponse")]
    public partial class GetMessagingSubscriptionFailureResponse : IEquatable<GetMessagingSubscriptionFailureResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMessagingSubscriptionFailureResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetMessagingSubscriptionFailureResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMessagingSubscriptionFailureResponse" /> class.
        /// </summary>
        /// <param name="key">Key is the phone number or email. (required).</param>
        /// <param name="type">This will be the exact type as given in the request. (required).</param>
        /// <param name="errors">Per key errors, such as validation errors. (required).</param>
        public GetMessagingSubscriptionFailureResponse(string key = default(string), string type = default(string), List<MessageSubscriptionResponseError> errors = default(List<MessageSubscriptionResponseError>))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for GetMessagingSubscriptionFailureResponse and cannot be null");
            }
            this.Key = key;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for GetMessagingSubscriptionFailureResponse and cannot be null");
            }
            this.Type = type;
            // to ensure "errors" is required (not null)
            if (errors == null)
            {
                throw new ArgumentNullException("errors is a required property for GetMessagingSubscriptionFailureResponse and cannot be null");
            }
            this.Errors = errors;
        }

        /// <summary>
        /// Key is the phone number or email.
        /// </summary>
        /// <value>Key is the phone number or email.</value>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// This will be the exact type as given in the request.
        /// </summary>
        /// <value>This will be the exact type as given in the request.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Per key errors, such as validation errors.
        /// </summary>
        /// <value>Per key errors, such as validation errors.</value>
        [DataMember(Name = "errors", IsRequired = true, EmitDefaultValue = true)]
        public List<MessageSubscriptionResponseError> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetMessagingSubscriptionFailureResponse {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(input as GetMessagingSubscriptionFailureResponse);
        }

        /// <summary>
        /// Returns true if GetMessagingSubscriptionFailureResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetMessagingSubscriptionFailureResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetMessagingSubscriptionFailureResponse input)
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
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
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
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Errors != null)
                {
                    hashCode = (hashCode * 59) + this.Errors.GetHashCode();
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
