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
    /// The regulate request.
    /// </summary>
    [DataContract(Name = "regulation")]
    public partial class Regulation : IEquatable<Regulation>, IValidatableObject
    {
        /// <summary>
        /// The current status of the regulate request.
        /// </summary>
        /// <value>The current status of the regulate request.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OverallStatusEnum
        {
            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED = 1,

            /// <summary>
            /// Enum FINISHED for value: FINISHED
            /// </summary>
            [EnumMember(Value = "FINISHED")]
            FINISHED = 2,

            /// <summary>
            /// Enum INITIALIZED for value: INITIALIZED
            /// </summary>
            [EnumMember(Value = "INITIALIZED")]
            INITIALIZED = 3,

            /// <summary>
            /// Enum INVALID for value: INVALID
            /// </summary>
            [EnumMember(Value = "INVALID")]
            INVALID = 4,

            /// <summary>
            /// Enum NOTSUPPORTED for value: NOT_SUPPORTED
            /// </summary>
            [EnumMember(Value = "NOT_SUPPORTED")]
            NOTSUPPORTED = 5,

            /// <summary>
            /// Enum PARTIALSUCCESS for value: PARTIAL_SUCCESS
            /// </summary>
            [EnumMember(Value = "PARTIAL_SUCCESS")]
            PARTIALSUCCESS = 6,

            /// <summary>
            /// Enum RUNNING for value: RUNNING
            /// </summary>
            [EnumMember(Value = "RUNNING")]
            RUNNING = 7
        }


        /// <summary>
        /// The current status of the regulate request.
        /// </summary>
        /// <value>The current status of the regulate request.</value>
        [DataMember(Name = "overallStatus", IsRequired = true, EmitDefaultValue = true)]
        public OverallStatusEnum OverallStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Regulation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Regulation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Regulation" /> class.
        /// </summary>
        /// <param name="id">The id of the regulate request. (required).</param>
        /// <param name="workspaceId">The id of the Workspace that the regulate request belongs to. (required).</param>
        /// <param name="overallStatus">The current status of the regulate request. (required).</param>
        /// <param name="finishedAt">The timestamp of when the request finished..</param>
        /// <param name="createdAt">The timestamp of the creation of the request. (required).</param>
        /// <param name="streamStatus">The status of each stream including all the Destinations that correspond to the stream. (required).</param>
        public Regulation(string id = default(string), string workspaceId = default(string), OverallStatusEnum overallStatus = default(OverallStatusEnum), string finishedAt = default(string), string createdAt = default(string), List<StreamStatusV1> streamStatus = default(List<StreamStatusV1>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Regulation and cannot be null");
            }
            this.Id = id;
            // to ensure "workspaceId" is required (not null)
            if (workspaceId == null)
            {
                throw new ArgumentNullException("workspaceId is a required property for Regulation and cannot be null");
            }
            this.WorkspaceId = workspaceId;
            this.OverallStatus = overallStatus;
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new ArgumentNullException("createdAt is a required property for Regulation and cannot be null");
            }
            this.CreatedAt = createdAt;
            // to ensure "streamStatus" is required (not null)
            if (streamStatus == null)
            {
                throw new ArgumentNullException("streamStatus is a required property for Regulation and cannot be null");
            }
            this.StreamStatus = streamStatus;
            this.FinishedAt = finishedAt;
        }

        /// <summary>
        /// The id of the regulate request.
        /// </summary>
        /// <value>The id of the regulate request.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The id of the Workspace that the regulate request belongs to.
        /// </summary>
        /// <value>The id of the Workspace that the regulate request belongs to.</value>
        [DataMember(Name = "workspaceId", IsRequired = true, EmitDefaultValue = true)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// The timestamp of when the request finished.
        /// </summary>
        /// <value>The timestamp of when the request finished.</value>
        [DataMember(Name = "finishedAt", EmitDefaultValue = false)]
        public string FinishedAt { get; set; }

        /// <summary>
        /// The timestamp of the creation of the request.
        /// </summary>
        /// <value>The timestamp of the creation of the request.</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// The status of each stream including all the Destinations that correspond to the stream.
        /// </summary>
        /// <value>The status of each stream including all the Destinations that correspond to the stream.</value>
        [DataMember(Name = "streamStatus", IsRequired = true, EmitDefaultValue = true)]
        public List<StreamStatusV1> StreamStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Regulation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  OverallStatus: ").Append(OverallStatus).Append("\n");
            sb.Append("  FinishedAt: ").Append(FinishedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  StreamStatus: ").Append(StreamStatus).Append("\n");
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
            return this.Equals(input as Regulation);
        }

        /// <summary>
        /// Returns true if Regulation instances are equal
        /// </summary>
        /// <param name="input">Instance of Regulation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Regulation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.WorkspaceId == input.WorkspaceId ||
                    (this.WorkspaceId != null &&
                    this.WorkspaceId.Equals(input.WorkspaceId))
                ) && 
                (
                    this.OverallStatus == input.OverallStatus ||
                    this.OverallStatus.Equals(input.OverallStatus)
                ) && 
                (
                    this.FinishedAt == input.FinishedAt ||
                    (this.FinishedAt != null &&
                    this.FinishedAt.Equals(input.FinishedAt))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.StreamStatus == input.StreamStatus ||
                    this.StreamStatus != null &&
                    input.StreamStatus != null &&
                    this.StreamStatus.SequenceEqual(input.StreamStatus)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.WorkspaceId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkspaceId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OverallStatus.GetHashCode();
                if (this.FinishedAt != null)
                {
                    hashCode = (hashCode * 59) + this.FinishedAt.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.StreamStatus != null)
                {
                    hashCode = (hashCode * 59) + this.StreamStatus.GetHashCode();
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
