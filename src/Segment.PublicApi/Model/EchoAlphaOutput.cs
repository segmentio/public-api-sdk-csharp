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
    /// Echo response.
    /// </summary>
    [DataContract(Name = "EchoAlphaOutput")]
    public partial class EchoAlphaOutput : IEquatable<EchoAlphaOutput>, IValidatableObject
    {
        /// <summary>
        /// The HTTP method used for this round-trip.  Currently, this endpoint supports only &#x60;get&#x60; and &#x60;post&#x60; methods.
        /// </summary>
        /// <value>The HTTP method used for this round-trip.  Currently, this endpoint supports only &#x60;get&#x60; and &#x60;post&#x60; methods.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MethodEnum
        {
            /// <summary>
            /// Enum Get for value: get
            /// </summary>
            [EnumMember(Value = "get")]
            Get = 1,

            /// <summary>
            /// Enum Post for value: post
            /// </summary>
            [EnumMember(Value = "post")]
            Post = 2
        }


        /// <summary>
        /// The HTTP method used for this round-trip.  Currently, this endpoint supports only &#x60;get&#x60; and &#x60;post&#x60; methods.
        /// </summary>
        /// <value>The HTTP method used for this round-trip.  Currently, this endpoint supports only &#x60;get&#x60; and &#x60;post&#x60; methods.</value>
        [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = true)]
        public MethodEnum Method { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EchoAlphaOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EchoAlphaOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EchoAlphaOutput" /> class.
        /// </summary>
        /// <param name="method">The HTTP method used for this round-trip.  Currently, this endpoint supports only &#x60;get&#x60; and &#x60;post&#x60; methods. (required).</param>
        /// <param name="message">The string passed in the &#x60;message&#x60; input field. (required).</param>
        /// <param name="headers">The request&#39;s HTTP headers. (required).</param>
        public EchoAlphaOutput(MethodEnum method = default(MethodEnum), string message = default(string), Dictionary<string, Object> headers = default(Dictionary<string, Object>))
        {
            this.Method = method;
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for EchoAlphaOutput and cannot be null");
            }
            this.Message = message;
            // to ensure "headers" is required (not null)
            if (headers == null)
            {
                throw new ArgumentNullException("headers is a required property for EchoAlphaOutput and cannot be null");
            }
            this.Headers = headers;
        }

        /// <summary>
        /// The string passed in the &#x60;message&#x60; input field.
        /// </summary>
        /// <value>The string passed in the &#x60;message&#x60; input field.</value>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// The request&#39;s HTTP headers.
        /// </summary>
        /// <value>The request&#39;s HTTP headers.</value>
        [DataMember(Name = "headers", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> Headers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EchoAlphaOutput {\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
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
            return this.Equals(input as EchoAlphaOutput);
        }

        /// <summary>
        /// Returns true if EchoAlphaOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of EchoAlphaOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EchoAlphaOutput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Method == input.Method ||
                    this.Method.Equals(input.Method)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Headers == input.Headers ||
                    this.Headers != null &&
                    input.Headers != null &&
                    this.Headers.SequenceEqual(input.Headers)
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
                hashCode = (hashCode * 59) + this.Method.GetHashCode();
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.Headers != null)
                {
                    hashCode = (hashCode * 59) + this.Headers.GetHashCode();
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
