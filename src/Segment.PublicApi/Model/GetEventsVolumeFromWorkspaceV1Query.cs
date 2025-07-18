/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.13.0
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
    /// GetEventVolumeOutputQuery represents the input query sent to output.
    /// </summary>
    [DataContract(Name = "GetEventsVolumeFromWorkspaceV1Query")]
    public partial class GetEventsVolumeFromWorkspaceV1Query : IEquatable<GetEventsVolumeFromWorkspaceV1Query>, IValidatableObject
    {
        /// <summary>
        /// Granularity corresponds to the requested bucket granularity.
        /// </summary>
        /// <value>Granularity corresponds to the requested bucket granularity.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GranularityEnum
        {
            /// <summary>
            /// Enum DAY for value: DAY
            /// </summary>
            [EnumMember(Value = "DAY")]
            DAY = 1,

            /// <summary>
            /// Enum HOUR for value: HOUR
            /// </summary>
            [EnumMember(Value = "HOUR")]
            HOUR = 2,

            /// <summary>
            /// Enum MINUTE for value: MINUTE
            /// </summary>
            [EnumMember(Value = "MINUTE")]
            MINUTE = 3
        }


        /// <summary>
        /// Granularity corresponds to the requested bucket granularity.
        /// </summary>
        /// <value>Granularity corresponds to the requested bucket granularity.</value>
        [DataMember(Name = "granularity", IsRequired = true, EmitDefaultValue = true)]
        public GranularityEnum Granularity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEventsVolumeFromWorkspaceV1Query" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetEventsVolumeFromWorkspaceV1Query() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEventsVolumeFromWorkspaceV1Query" /> class.
        /// </summary>
        /// <param name="workspaceId">Workspace being requested. (required).</param>
        /// <param name="granularity">Granularity corresponds to the requested bucket granularity. (required).</param>
        /// <param name="startTime">StartTime is the ISO8601 formatted timestamp corresponding to the beginning of the requested time frame, inclusive. (required).</param>
        /// <param name="endTime">EndTime is the ISO8601 formatted timestamp corresponding to the end of the requested time frame, noninclusive. (required).</param>
        /// <param name="groupBy">GroupBy is a comma-delimited list of strings representing the dimensions to group the result by. The current options are: &#x60;eventName&#x60; or &#x60;eventType&#x60;..</param>
        /// <param name="sourceId">List of strings which allow you to restrict the result to just the given Sources..</param>
        /// <param name="eventName">EventName is a list of strings which allow you to restrict the result to just the given event names..</param>
        /// <param name="eventType">EventType is a list of strings which allow you to restrict the result to just the given event types..</param>
        /// <param name="appVersion">AppVersion is a list of strings which allow you to restrict the result to just the given application versions..</param>
        /// <param name="limit">Limit is the total number of items in the result..</param>
        public GetEventsVolumeFromWorkspaceV1Query(string workspaceId = default(string), GranularityEnum granularity = default(GranularityEnum), string startTime = default(string), string endTime = default(string), List<string> groupBy = default(List<string>), List<string> sourceId = default(List<string>), List<string> eventName = default(List<string>), List<string> eventType = default(List<string>), List<string> appVersion = default(List<string>), decimal limit = default(decimal))
        {
            // to ensure "workspaceId" is required (not null)
            if (workspaceId == null)
            {
                throw new ArgumentNullException("workspaceId is a required property for GetEventsVolumeFromWorkspaceV1Query and cannot be null");
            }
            this.WorkspaceId = workspaceId;
            this.Granularity = granularity;
            // to ensure "startTime" is required (not null)
            if (startTime == null)
            {
                throw new ArgumentNullException("startTime is a required property for GetEventsVolumeFromWorkspaceV1Query and cannot be null");
            }
            this.StartTime = startTime;
            // to ensure "endTime" is required (not null)
            if (endTime == null)
            {
                throw new ArgumentNullException("endTime is a required property for GetEventsVolumeFromWorkspaceV1Query and cannot be null");
            }
            this.EndTime = endTime;
            this.GroupBy = groupBy;
            this.SourceId = sourceId;
            this.EventName = eventName;
            this.EventType = eventType;
            this.AppVersion = appVersion;
            this.Limit = limit;
        }

        /// <summary>
        /// Workspace being requested.
        /// </summary>
        /// <value>Workspace being requested.</value>
        [DataMember(Name = "workspaceId", IsRequired = true, EmitDefaultValue = true)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// StartTime is the ISO8601 formatted timestamp corresponding to the beginning of the requested time frame, inclusive.
        /// </summary>
        /// <value>StartTime is the ISO8601 formatted timestamp corresponding to the beginning of the requested time frame, inclusive.</value>
        [DataMember(Name = "startTime", IsRequired = true, EmitDefaultValue = true)]
        public string StartTime { get; set; }

        /// <summary>
        /// EndTime is the ISO8601 formatted timestamp corresponding to the end of the requested time frame, noninclusive.
        /// </summary>
        /// <value>EndTime is the ISO8601 formatted timestamp corresponding to the end of the requested time frame, noninclusive.</value>
        [DataMember(Name = "endTime", IsRequired = true, EmitDefaultValue = true)]
        public string EndTime { get; set; }

        /// <summary>
        /// GroupBy is a comma-delimited list of strings representing the dimensions to group the result by. The current options are: &#x60;eventName&#x60; or &#x60;eventType&#x60;.
        /// </summary>
        /// <value>GroupBy is a comma-delimited list of strings representing the dimensions to group the result by. The current options are: &#x60;eventName&#x60; or &#x60;eventType&#x60;.</value>
        [DataMember(Name = "groupBy", EmitDefaultValue = false)]
        public List<string> GroupBy { get; set; }

        /// <summary>
        /// List of strings which allow you to restrict the result to just the given Sources.
        /// </summary>
        /// <value>List of strings which allow you to restrict the result to just the given Sources.</value>
        [DataMember(Name = "sourceId", EmitDefaultValue = false)]
        public List<string> SourceId { get; set; }

        /// <summary>
        /// EventName is a list of strings which allow you to restrict the result to just the given event names.
        /// </summary>
        /// <value>EventName is a list of strings which allow you to restrict the result to just the given event names.</value>
        [DataMember(Name = "eventName", EmitDefaultValue = false)]
        public List<string> EventName { get; set; }

        /// <summary>
        /// EventType is a list of strings which allow you to restrict the result to just the given event types.
        /// </summary>
        /// <value>EventType is a list of strings which allow you to restrict the result to just the given event types.</value>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        public List<string> EventType { get; set; }

        /// <summary>
        /// AppVersion is a list of strings which allow you to restrict the result to just the given application versions.
        /// </summary>
        /// <value>AppVersion is a list of strings which allow you to restrict the result to just the given application versions.</value>
        [DataMember(Name = "appVersion", EmitDefaultValue = false)]
        public List<string> AppVersion { get; set; }

        /// <summary>
        /// Limit is the total number of items in the result.
        /// </summary>
        /// <value>Limit is the total number of items in the result.</value>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public decimal Limit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetEventsVolumeFromWorkspaceV1Query {\n");
            sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  Granularity: ").Append(Granularity).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
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
            return this.Equals(input as GetEventsVolumeFromWorkspaceV1Query);
        }

        /// <summary>
        /// Returns true if GetEventsVolumeFromWorkspaceV1Query instances are equal
        /// </summary>
        /// <param name="input">Instance of GetEventsVolumeFromWorkspaceV1Query to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetEventsVolumeFromWorkspaceV1Query input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.WorkspaceId == input.WorkspaceId ||
                    (this.WorkspaceId != null &&
                    this.WorkspaceId.Equals(input.WorkspaceId))
                ) && 
                (
                    this.Granularity == input.Granularity ||
                    this.Granularity.Equals(input.Granularity)
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.GroupBy == input.GroupBy ||
                    this.GroupBy != null &&
                    input.GroupBy != null &&
                    this.GroupBy.SequenceEqual(input.GroupBy)
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    this.SourceId != null &&
                    input.SourceId != null &&
                    this.SourceId.SequenceEqual(input.SourceId)
                ) && 
                (
                    this.EventName == input.EventName ||
                    this.EventName != null &&
                    input.EventName != null &&
                    this.EventName.SequenceEqual(input.EventName)
                ) && 
                (
                    this.EventType == input.EventType ||
                    this.EventType != null &&
                    input.EventType != null &&
                    this.EventType.SequenceEqual(input.EventType)
                ) && 
                (
                    this.AppVersion == input.AppVersion ||
                    this.AppVersion != null &&
                    input.AppVersion != null &&
                    this.AppVersion.SequenceEqual(input.AppVersion)
                ) && 
                (
                    this.Limit == input.Limit ||
                    this.Limit.Equals(input.Limit)
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
                if (this.WorkspaceId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkspaceId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Granularity.GetHashCode();
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                if (this.GroupBy != null)
                {
                    hashCode = (hashCode * 59) + this.GroupBy.GetHashCode();
                }
                if (this.SourceId != null)
                {
                    hashCode = (hashCode * 59) + this.SourceId.GetHashCode();
                }
                if (this.EventName != null)
                {
                    hashCode = (hashCode * 59) + this.EventName.GetHashCode();
                }
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                if (this.AppVersion != null)
                {
                    hashCode = (hashCode * 59) + this.AppVersion.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Limit.GetHashCode();
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
