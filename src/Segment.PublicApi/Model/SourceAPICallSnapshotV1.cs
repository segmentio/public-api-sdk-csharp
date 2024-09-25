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
    /// A snapshot of the number of API calls for a given Source in a Workspace.
    /// </summary>
    [DataContract(Name = "SourceAPICallSnapshotV1")]
    public partial class SourceAPICallSnapshotV1 : IEquatable<SourceAPICallSnapshotV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceAPICallSnapshotV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SourceAPICallSnapshotV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceAPICallSnapshotV1" /> class.
        /// </summary>
        /// <param name="sourceId">The Source id. (required).</param>
        /// <param name="apiCalls">A bigint of the number of API calls in this snapshot. (required).</param>
        /// <param name="timestamp">Timestamp of this snapshot within the billing cycle in the ISO-8601 format. (required).</param>
        public SourceAPICallSnapshotV1(string sourceId = default(string), string apiCalls = default(string), string timestamp = default(string))
        {
            // to ensure "sourceId" is required (not null)
            if (sourceId == null)
            {
                throw new ArgumentNullException("sourceId is a required property for SourceAPICallSnapshotV1 and cannot be null");
            }
            this.SourceId = sourceId;
            // to ensure "apiCalls" is required (not null)
            if (apiCalls == null)
            {
                throw new ArgumentNullException("apiCalls is a required property for SourceAPICallSnapshotV1 and cannot be null");
            }
            this.ApiCalls = apiCalls;
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new ArgumentNullException("timestamp is a required property for SourceAPICallSnapshotV1 and cannot be null");
            }
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// The Source id.
        /// </summary>
        /// <value>The Source id.</value>
        [DataMember(Name = "sourceId", IsRequired = true, EmitDefaultValue = true)]
        public string SourceId { get; set; }

        /// <summary>
        /// A bigint of the number of API calls in this snapshot.
        /// </summary>
        /// <value>A bigint of the number of API calls in this snapshot.</value>
        [DataMember(Name = "apiCalls", IsRequired = true, EmitDefaultValue = true)]
        public string ApiCalls { get; set; }

        /// <summary>
        /// Timestamp of this snapshot within the billing cycle in the ISO-8601 format.
        /// </summary>
        /// <value>Timestamp of this snapshot within the billing cycle in the ISO-8601 format.</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = true)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SourceAPICallSnapshotV1 {\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  ApiCalls: ").Append(ApiCalls).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as SourceAPICallSnapshotV1);
        }

        /// <summary>
        /// Returns true if SourceAPICallSnapshotV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of SourceAPICallSnapshotV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourceAPICallSnapshotV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.ApiCalls == input.ApiCalls ||
                    (this.ApiCalls != null &&
                    this.ApiCalls.Equals(input.ApiCalls))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.SourceId != null)
                {
                    hashCode = (hashCode * 59) + this.SourceId.GetHashCode();
                }
                if (this.ApiCalls != null)
                {
                    hashCode = (hashCode * 59) + this.ApiCalls.GetHashCode();
                }
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
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