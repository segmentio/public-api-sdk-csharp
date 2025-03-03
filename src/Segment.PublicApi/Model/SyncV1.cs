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
    /// Represents a sync between a Source and Warehouse.  A sync occurs when data from a Source is loaded into a Warehouse.
    /// </summary>
    [DataContract(Name = "SyncV1")]
    public partial class SyncV1 : IEquatable<SyncV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SyncV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncV1" /> class.
        /// </summary>
        /// <param name="sourceId">The id of the Source loaded in the sync. (required).</param>
        /// <param name="start">The start time of the sync. (required).</param>
        /// <param name="end">The time the sync completed. Returns null if unfinished. (required).</param>
        /// <param name="status">The status of the sync. (required).</param>
        /// <param name="duration">The duration of the sync in seconds. Returns the partial duration if the sync has not finished yet. (required).</param>
        /// <param name="humanDuration">The human-readable counterpart of &#x60;duration&#x60;. (required).</param>
        /// <param name="count">The number of rows synced into the Warehouse. (required).</param>
        /// <param name="notices">Notices that contain the events that occurred during the sync. (required).</param>
        public SyncV1(string sourceId = default(string), string start = default(string), string end = default(string), string status = default(string), decimal duration = default(decimal), string humanDuration = default(string), decimal count = default(decimal), List<SyncNoticeV1> notices = default(List<SyncNoticeV1>))
        {
            // to ensure "sourceId" is required (not null)
            if (sourceId == null)
            {
                throw new ArgumentNullException("sourceId is a required property for SyncV1 and cannot be null");
            }
            this.SourceId = sourceId;
            // to ensure "start" is required (not null)
            if (start == null)
            {
                throw new ArgumentNullException("start is a required property for SyncV1 and cannot be null");
            }
            this.Start = start;
            // to ensure "end" is required (not null)
            if (end == null)
            {
                throw new ArgumentNullException("end is a required property for SyncV1 and cannot be null");
            }
            this.End = end;
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for SyncV1 and cannot be null");
            }
            this.Status = status;
            this.Duration = duration;
            // to ensure "humanDuration" is required (not null)
            if (humanDuration == null)
            {
                throw new ArgumentNullException("humanDuration is a required property for SyncV1 and cannot be null");
            }
            this.HumanDuration = humanDuration;
            this.Count = count;
            // to ensure "notices" is required (not null)
            if (notices == null)
            {
                throw new ArgumentNullException("notices is a required property for SyncV1 and cannot be null");
            }
            this.Notices = notices;
        }

        /// <summary>
        /// The id of the Source loaded in the sync.
        /// </summary>
        /// <value>The id of the Source loaded in the sync.</value>
        [DataMember(Name = "sourceId", IsRequired = true, EmitDefaultValue = true)]
        public string SourceId { get; set; }

        /// <summary>
        /// The start time of the sync.
        /// </summary>
        /// <value>The start time of the sync.</value>
        [DataMember(Name = "start", IsRequired = true, EmitDefaultValue = true)]
        public string Start { get; set; }

        /// <summary>
        /// The time the sync completed. Returns null if unfinished.
        /// </summary>
        /// <value>The time the sync completed. Returns null if unfinished.</value>
        [DataMember(Name = "end", IsRequired = true, EmitDefaultValue = true)]
        public string End { get; set; }

        /// <summary>
        /// The status of the sync.
        /// </summary>
        /// <value>The status of the sync.</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// The duration of the sync in seconds. Returns the partial duration if the sync has not finished yet.
        /// </summary>
        /// <value>The duration of the sync in seconds. Returns the partial duration if the sync has not finished yet.</value>
        [DataMember(Name = "duration", IsRequired = true, EmitDefaultValue = true)]
        public decimal Duration { get; set; }

        /// <summary>
        /// The human-readable counterpart of &#x60;duration&#x60;.
        /// </summary>
        /// <value>The human-readable counterpart of &#x60;duration&#x60;.</value>
        [DataMember(Name = "humanDuration", IsRequired = true, EmitDefaultValue = true)]
        public string HumanDuration { get; set; }

        /// <summary>
        /// The number of rows synced into the Warehouse.
        /// </summary>
        /// <value>The number of rows synced into the Warehouse.</value>
        [DataMember(Name = "count", IsRequired = true, EmitDefaultValue = true)]
        public decimal Count { get; set; }

        /// <summary>
        /// Notices that contain the events that occurred during the sync.
        /// </summary>
        /// <value>Notices that contain the events that occurred during the sync.</value>
        [DataMember(Name = "notices", IsRequired = true, EmitDefaultValue = true)]
        public List<SyncNoticeV1> Notices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SyncV1 {\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  HumanDuration: ").Append(HumanDuration).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Notices: ").Append(Notices).Append("\n");
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
            return this.Equals(input as SyncV1);
        }

        /// <summary>
        /// Returns true if SyncV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of SyncV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SyncV1 input)
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
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.End == input.End ||
                    (this.End != null &&
                    this.End.Equals(input.End))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Duration == input.Duration ||
                    this.Duration.Equals(input.Duration)
                ) && 
                (
                    this.HumanDuration == input.HumanDuration ||
                    (this.HumanDuration != null &&
                    this.HumanDuration.Equals(input.HumanDuration))
                ) && 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
                ) && 
                (
                    this.Notices == input.Notices ||
                    this.Notices != null &&
                    input.Notices != null &&
                    this.Notices.SequenceEqual(input.Notices)
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
                if (this.Start != null)
                {
                    hashCode = (hashCode * 59) + this.Start.GetHashCode();
                }
                if (this.End != null)
                {
                    hashCode = (hashCode * 59) + this.End.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Duration.GetHashCode();
                if (this.HumanDuration != null)
                {
                    hashCode = (hashCode * 59) + this.HumanDuration.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Count.GetHashCode();
                if (this.Notices != null)
                {
                    hashCode = (hashCode * 59) + this.Notices.GetHashCode();
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
