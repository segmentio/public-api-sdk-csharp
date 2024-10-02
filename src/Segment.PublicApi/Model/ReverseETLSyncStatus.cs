/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 55.0.0
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
    /// Defines the result of getting the sync status of a RETL connection.
    /// </summary>
    [DataContract(Name = "ReverseETLSyncStatus")]
    public partial class ReverseETLSyncStatus : IEquatable<ReverseETLSyncStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseETLSyncStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReverseETLSyncStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseETLSyncStatus" /> class.
        /// </summary>
        /// <param name="syncId">The id of the sync. (required).</param>
        /// <param name="modelId">The Model id of the sync. (required).</param>
        /// <param name="sourceId">The Source id of the sync. (required).</param>
        /// <param name="syncStatus">The status of the sync. It currently can be IN_PROGRESS, FAIL, SUCCESS, PARTIAL_SUCCESS. (required).</param>
        /// <param name="duration">The duration of the sync. (required).</param>
        /// <param name="startedAt">When the sync started. (required).</param>
        /// <param name="finishedAt">When the sync started..</param>
        /// <param name="extractPhase">extractPhase.</param>
        /// <param name="loadPhase">loadPhase.</param>
        /// <param name="error">Error message if applicable..</param>
        /// <param name="errorCode">Error code indicates a fatal sync error code, if applicable..</param>
        public ReverseETLSyncStatus(string syncId = default(string), string modelId = default(string), string sourceId = default(string), string syncStatus = default(string), string duration = default(string), string startedAt = default(string), string finishedAt = default(string), SyncExtractPhase extractPhase = default(SyncExtractPhase), SyncLoadPhase loadPhase = default(SyncLoadPhase), string error = default(string), string errorCode = default(string))
        {
            // to ensure "syncId" is required (not null)
            if (syncId == null)
            {
                throw new ArgumentNullException("syncId is a required property for ReverseETLSyncStatus and cannot be null");
            }
            this.SyncId = syncId;
            // to ensure "modelId" is required (not null)
            if (modelId == null)
            {
                throw new ArgumentNullException("modelId is a required property for ReverseETLSyncStatus and cannot be null");
            }
            this.ModelId = modelId;
            // to ensure "sourceId" is required (not null)
            if (sourceId == null)
            {
                throw new ArgumentNullException("sourceId is a required property for ReverseETLSyncStatus and cannot be null");
            }
            this.SourceId = sourceId;
            // to ensure "syncStatus" is required (not null)
            if (syncStatus == null)
            {
                throw new ArgumentNullException("syncStatus is a required property for ReverseETLSyncStatus and cannot be null");
            }
            this.SyncStatus = syncStatus;
            // to ensure "duration" is required (not null)
            if (duration == null)
            {
                throw new ArgumentNullException("duration is a required property for ReverseETLSyncStatus and cannot be null");
            }
            this.Duration = duration;
            // to ensure "startedAt" is required (not null)
            if (startedAt == null)
            {
                throw new ArgumentNullException("startedAt is a required property for ReverseETLSyncStatus and cannot be null");
            }
            this.StartedAt = startedAt;
            this.FinishedAt = finishedAt;
            this.ExtractPhase = extractPhase;
            this.LoadPhase = loadPhase;
            this.Error = error;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// The id of the sync.
        /// </summary>
        /// <value>The id of the sync.</value>
        [DataMember(Name = "syncId", IsRequired = true, EmitDefaultValue = true)]
        public string SyncId { get; set; }

        /// <summary>
        /// The Model id of the sync.
        /// </summary>
        /// <value>The Model id of the sync.</value>
        [DataMember(Name = "modelId", IsRequired = true, EmitDefaultValue = true)]
        public string ModelId { get; set; }

        /// <summary>
        /// The Source id of the sync.
        /// </summary>
        /// <value>The Source id of the sync.</value>
        [DataMember(Name = "sourceId", IsRequired = true, EmitDefaultValue = true)]
        public string SourceId { get; set; }

        /// <summary>
        /// The status of the sync. It currently can be IN_PROGRESS, FAIL, SUCCESS, PARTIAL_SUCCESS.
        /// </summary>
        /// <value>The status of the sync. It currently can be IN_PROGRESS, FAIL, SUCCESS, PARTIAL_SUCCESS.</value>
        [DataMember(Name = "syncStatus", IsRequired = true, EmitDefaultValue = true)]
        public string SyncStatus { get; set; }

        /// <summary>
        /// The duration of the sync.
        /// </summary>
        /// <value>The duration of the sync.</value>
        [DataMember(Name = "duration", IsRequired = true, EmitDefaultValue = true)]
        public string Duration { get; set; }

        /// <summary>
        /// When the sync started.
        /// </summary>
        /// <value>When the sync started.</value>
        [DataMember(Name = "startedAt", IsRequired = true, EmitDefaultValue = true)]
        public string StartedAt { get; set; }

        /// <summary>
        /// When the sync started.
        /// </summary>
        /// <value>When the sync started.</value>
        [DataMember(Name = "finishedAt", EmitDefaultValue = false)]
        public string FinishedAt { get; set; }

        /// <summary>
        /// Gets or Sets ExtractPhase
        /// </summary>
        [DataMember(Name = "extractPhase", EmitDefaultValue = false)]
        public SyncExtractPhase ExtractPhase { get; set; }

        /// <summary>
        /// Gets or Sets LoadPhase
        /// </summary>
        [DataMember(Name = "loadPhase", EmitDefaultValue = false)]
        public SyncLoadPhase LoadPhase { get; set; }

        /// <summary>
        /// Error message if applicable.
        /// </summary>
        /// <value>Error message if applicable.</value>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public string Error { get; set; }

        /// <summary>
        /// Error code indicates a fatal sync error code, if applicable.
        /// </summary>
        /// <value>Error code indicates a fatal sync error code, if applicable.</value>
        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReverseETLSyncStatus {\n");
            sb.Append("  SyncId: ").Append(SyncId).Append("\n");
            sb.Append("  ModelId: ").Append(ModelId).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  SyncStatus: ").Append(SyncStatus).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
            sb.Append("  FinishedAt: ").Append(FinishedAt).Append("\n");
            sb.Append("  ExtractPhase: ").Append(ExtractPhase).Append("\n");
            sb.Append("  LoadPhase: ").Append(LoadPhase).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
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
            return this.Equals(input as ReverseETLSyncStatus);
        }

        /// <summary>
        /// Returns true if ReverseETLSyncStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of ReverseETLSyncStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReverseETLSyncStatus input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SyncId == input.SyncId ||
                    (this.SyncId != null &&
                    this.SyncId.Equals(input.SyncId))
                ) && 
                (
                    this.ModelId == input.ModelId ||
                    (this.ModelId != null &&
                    this.ModelId.Equals(input.ModelId))
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.SyncStatus == input.SyncStatus ||
                    (this.SyncStatus != null &&
                    this.SyncStatus.Equals(input.SyncStatus))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
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
                ) && 
                (
                    this.ExtractPhase == input.ExtractPhase ||
                    (this.ExtractPhase != null &&
                    this.ExtractPhase.Equals(input.ExtractPhase))
                ) && 
                (
                    this.LoadPhase == input.LoadPhase ||
                    (this.LoadPhase != null &&
                    this.LoadPhase.Equals(input.LoadPhase))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
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
                if (this.SyncId != null)
                {
                    hashCode = (hashCode * 59) + this.SyncId.GetHashCode();
                }
                if (this.ModelId != null)
                {
                    hashCode = (hashCode * 59) + this.ModelId.GetHashCode();
                }
                if (this.SourceId != null)
                {
                    hashCode = (hashCode * 59) + this.SourceId.GetHashCode();
                }
                if (this.SyncStatus != null)
                {
                    hashCode = (hashCode * 59) + this.SyncStatus.GetHashCode();
                }
                if (this.Duration != null)
                {
                    hashCode = (hashCode * 59) + this.Duration.GetHashCode();
                }
                if (this.StartedAt != null)
                {
                    hashCode = (hashCode * 59) + this.StartedAt.GetHashCode();
                }
                if (this.FinishedAt != null)
                {
                    hashCode = (hashCode * 59) + this.FinishedAt.GetHashCode();
                }
                if (this.ExtractPhase != null)
                {
                    hashCode = (hashCode * 59) + this.ExtractPhase.GetHashCode();
                }
                if (this.LoadPhase != null)
                {
                    hashCode = (hashCode * 59) + this.LoadPhase.GetHashCode();
                }
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
                }
                if (this.ErrorCode != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorCode.GetHashCode();
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
