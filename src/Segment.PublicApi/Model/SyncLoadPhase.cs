/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.1.1
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
    /// Object representing the load phase + details.
    /// </summary>
    [DataContract(Name = "SyncLoadPhase")]
    public partial class SyncLoadPhase : IEquatable<SyncLoadPhase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncLoadPhase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SyncLoadPhase() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncLoadPhase" /> class.
        /// </summary>
        /// <param name="deliverSuccessCount">Counts the subset of records successfully delivered to the downstream Destination. (required).</param>
        /// <param name="deliverFailureCount">Counts the subset of records status that failed to be delivered by either receiving a permanent error (for example, 400 Bad Request) or by exhausting all retries for temporary errors (for example, 429 Too Many Requests). (required).</param>
        /// <param name="errorCode">Error code indicates a fatal sync error code, if applicable. (required).</param>
        /// <param name="startedAt">Time that the load phase started. (required).</param>
        /// <param name="finishedAt">Time that the load phase finished. (required).</param>
        public SyncLoadPhase(string deliverSuccessCount = default(string), string deliverFailureCount = default(string), string errorCode = default(string), string startedAt = default(string), string finishedAt = default(string))
        {
            // to ensure "deliverSuccessCount" is required (not null)
            if (deliverSuccessCount == null)
            {
                throw new ArgumentNullException("deliverSuccessCount is a required property for SyncLoadPhase and cannot be null");
            }
            this.DeliverSuccessCount = deliverSuccessCount;
            // to ensure "deliverFailureCount" is required (not null)
            if (deliverFailureCount == null)
            {
                throw new ArgumentNullException("deliverFailureCount is a required property for SyncLoadPhase and cannot be null");
            }
            this.DeliverFailureCount = deliverFailureCount;
            // to ensure "errorCode" is required (not null)
            if (errorCode == null)
            {
                throw new ArgumentNullException("errorCode is a required property for SyncLoadPhase and cannot be null");
            }
            this.ErrorCode = errorCode;
            // to ensure "startedAt" is required (not null)
            if (startedAt == null)
            {
                throw new ArgumentNullException("startedAt is a required property for SyncLoadPhase and cannot be null");
            }
            this.StartedAt = startedAt;
            // to ensure "finishedAt" is required (not null)
            if (finishedAt == null)
            {
                throw new ArgumentNullException("finishedAt is a required property for SyncLoadPhase and cannot be null");
            }
            this.FinishedAt = finishedAt;
        }

        /// <summary>
        /// Counts the subset of records successfully delivered to the downstream Destination.
        /// </summary>
        /// <value>Counts the subset of records successfully delivered to the downstream Destination.</value>
        [DataMember(Name = "deliverSuccessCount", IsRequired = true, EmitDefaultValue = true)]
        public string DeliverSuccessCount { get; set; }

        /// <summary>
        /// Counts the subset of records status that failed to be delivered by either receiving a permanent error (for example, 400 Bad Request) or by exhausting all retries for temporary errors (for example, 429 Too Many Requests).
        /// </summary>
        /// <value>Counts the subset of records status that failed to be delivered by either receiving a permanent error (for example, 400 Bad Request) or by exhausting all retries for temporary errors (for example, 429 Too Many Requests).</value>
        [DataMember(Name = "deliverFailureCount", IsRequired = true, EmitDefaultValue = true)]
        public string DeliverFailureCount { get; set; }

        /// <summary>
        /// Error code indicates a fatal sync error code, if applicable.
        /// </summary>
        /// <value>Error code indicates a fatal sync error code, if applicable.</value>
        [DataMember(Name = "errorCode", IsRequired = true, EmitDefaultValue = true)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Time that the load phase started.
        /// </summary>
        /// <value>Time that the load phase started.</value>
        [DataMember(Name = "startedAt", IsRequired = true, EmitDefaultValue = true)]
        public string StartedAt { get; set; }

        /// <summary>
        /// Time that the load phase finished.
        /// </summary>
        /// <value>Time that the load phase finished.</value>
        [DataMember(Name = "finishedAt", IsRequired = true, EmitDefaultValue = true)]
        public string FinishedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SyncLoadPhase {\n");
            sb.Append("  DeliverSuccessCount: ").Append(DeliverSuccessCount).Append("\n");
            sb.Append("  DeliverFailureCount: ").Append(DeliverFailureCount).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
            sb.Append("  FinishedAt: ").Append(FinishedAt).Append("\n");
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
            return this.Equals(input as SyncLoadPhase);
        }

        /// <summary>
        /// Returns true if SyncLoadPhase instances are equal
        /// </summary>
        /// <param name="input">Instance of SyncLoadPhase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SyncLoadPhase input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeliverSuccessCount == input.DeliverSuccessCount ||
                    (this.DeliverSuccessCount != null &&
                    this.DeliverSuccessCount.Equals(input.DeliverSuccessCount))
                ) && 
                (
                    this.DeliverFailureCount == input.DeliverFailureCount ||
                    (this.DeliverFailureCount != null &&
                    this.DeliverFailureCount.Equals(input.DeliverFailureCount))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.StartedAt == input.StartedAt ||
                    (this.StartedAt != null &&
                    this.StartedAt.Equals(input.StartedAt))
                ) && 
                (
                    this.FinishedAt == input.FinishedAt ||
                    (this.FinishedAt != null &&
                    this.FinishedAt.Equals(input.FinishedAt))
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
                if (this.DeliverSuccessCount != null)
                {
                    hashCode = (hashCode * 59) + this.DeliverSuccessCount.GetHashCode();
                }
                if (this.DeliverFailureCount != null)
                {
                    hashCode = (hashCode * 59) + this.DeliverFailureCount.GetHashCode();
                }
                if (this.ErrorCode != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorCode.GetHashCode();
                }
                if (this.StartedAt != null)
                {
                    hashCode = (hashCode * 59) + this.StartedAt.GetHashCode();
                }
                if (this.FinishedAt != null)
                {
                    hashCode = (hashCode * 59) + this.FinishedAt.GetHashCode();
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
