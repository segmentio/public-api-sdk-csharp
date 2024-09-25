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
    /// Function webhook output status.
    /// </summary>
    [DataContract(Name = "HandleWebhookOutput")]
    public partial class HandleWebhookOutput : IEquatable<HandleWebhookOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HandleWebhookOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HandleWebhookOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HandleWebhookOutput" /> class.
        /// </summary>
        /// <param name="statusCode">The http status code. (required).</param>
        /// <param name="success">The status of the operation. (required).</param>
        public HandleWebhookOutput(decimal statusCode = default(decimal), bool success = default(bool))
        {
            this.StatusCode = statusCode;
            this.Success = success;
        }

        /// <summary>
        /// The http status code.
        /// </summary>
        /// <value>The http status code.</value>
        [DataMember(Name = "statusCode", IsRequired = true, EmitDefaultValue = true)]
        public decimal StatusCode { get; set; }

        /// <summary>
        /// The status of the operation.
        /// </summary>
        /// <value>The status of the operation.</value>
        [DataMember(Name = "success", IsRequired = true, EmitDefaultValue = true)]
        public bool Success { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HandleWebhookOutput {\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
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
            return this.Equals(input as HandleWebhookOutput);
        }

        /// <summary>
        /// Returns true if HandleWebhookOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of HandleWebhookOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HandleWebhookOutput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StatusCode == input.StatusCode ||
                    this.StatusCode.Equals(input.StatusCode)
                ) && 
                (
                    this.Success == input.Success ||
                    this.Success.Equals(input.Success)
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
                hashCode = (hashCode * 59) + this.StatusCode.GetHashCode();
                hashCode = (hashCode * 59) + this.Success.GetHashCode();
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