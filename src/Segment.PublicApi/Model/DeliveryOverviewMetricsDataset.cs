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
    /// Dataset within GetDeliveryOverviewMetricsBetaOutput.
    /// </summary>
    [DataContract(Name = "DeliveryOverviewMetricsDataset")]
    public partial class DeliveryOverviewMetricsDataset : IEquatable<DeliveryOverviewMetricsDataset>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryOverviewMetricsDataset" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeliveryOverviewMetricsDataset() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryOverviewMetricsDataset" /> class.
        /// </summary>
        /// <param name="eventName">The name of the event if group By[] included &#39;event Name&#39; in the request..</param>
        /// <param name="appVersion">The version of the app if group By[] included &#39;app Version&#39; in the request..</param>
        /// <param name="eventType">The event type if group By[] included &#39;event Type&#39; in the request..</param>
        /// <param name="discardReason">The discard reason for dropped events if group By[] included &#39;discard Reason&#39; in the request..</param>
        /// <param name="total">Holds the count of all event counts over the time frame of the series. (required).</param>
        /// <param name="series">A list of the event counts broken down by the requested granularity, time frame, and group By options. (required).</param>
        /// <param name="totalRetryCount">The number of events successfully delivered upon retry..</param>
        public DeliveryOverviewMetricsDataset(string eventName = default(string), string appVersion = default(string), string eventType = default(string), string discardReason = default(string), decimal total = default(decimal), List<DeliveryOverviewMetricsDatapoint> series = default(List<DeliveryOverviewMetricsDatapoint>), decimal totalRetryCount = default(decimal))
        {
            this.Total = total;
            // to ensure "series" is required (not null)
            if (series == null)
            {
                throw new ArgumentNullException("series is a required property for DeliveryOverviewMetricsDataset and cannot be null");
            }
            this.Series = series;
            this.EventName = eventName;
            this.AppVersion = appVersion;
            this.EventType = eventType;
            this.DiscardReason = discardReason;
            this.TotalRetryCount = totalRetryCount;
        }

        /// <summary>
        /// The name of the event if group By[] included &#39;event Name&#39; in the request.
        /// </summary>
        /// <value>The name of the event if group By[] included &#39;event Name&#39; in the request.</value>
        [DataMember(Name = "eventName", EmitDefaultValue = false)]
        public string EventName { get; set; }

        /// <summary>
        /// The version of the app if group By[] included &#39;app Version&#39; in the request.
        /// </summary>
        /// <value>The version of the app if group By[] included &#39;app Version&#39; in the request.</value>
        [DataMember(Name = "appVersion", EmitDefaultValue = false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// The event type if group By[] included &#39;event Type&#39; in the request.
        /// </summary>
        /// <value>The event type if group By[] included &#39;event Type&#39; in the request.</value>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        public string EventType { get; set; }

        /// <summary>
        /// The discard reason for dropped events if group By[] included &#39;discard Reason&#39; in the request.
        /// </summary>
        /// <value>The discard reason for dropped events if group By[] included &#39;discard Reason&#39; in the request.</value>
        [DataMember(Name = "discardReason", EmitDefaultValue = false)]
        public string DiscardReason { get; set; }

        /// <summary>
        /// Holds the count of all event counts over the time frame of the series.
        /// </summary>
        /// <value>Holds the count of all event counts over the time frame of the series.</value>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = true)]
        public decimal Total { get; set; }

        /// <summary>
        /// A list of the event counts broken down by the requested granularity, time frame, and group By options.
        /// </summary>
        /// <value>A list of the event counts broken down by the requested granularity, time frame, and group By options.</value>
        [DataMember(Name = "series", IsRequired = true, EmitDefaultValue = true)]
        public List<DeliveryOverviewMetricsDatapoint> Series { get; set; }

        /// <summary>
        /// The number of events successfully delivered upon retry.
        /// </summary>
        /// <value>The number of events successfully delivered upon retry.</value>
        [DataMember(Name = "totalRetryCount", EmitDefaultValue = false)]
        public decimal TotalRetryCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeliveryOverviewMetricsDataset {\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  DiscardReason: ").Append(DiscardReason).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Series: ").Append(Series).Append("\n");
            sb.Append("  TotalRetryCount: ").Append(TotalRetryCount).Append("\n");
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
            return this.Equals(input as DeliveryOverviewMetricsDataset);
        }

        /// <summary>
        /// Returns true if DeliveryOverviewMetricsDataset instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryOverviewMetricsDataset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryOverviewMetricsDataset input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.AppVersion == input.AppVersion ||
                    (this.AppVersion != null &&
                    this.AppVersion.Equals(input.AppVersion))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.DiscardReason == input.DiscardReason ||
                    (this.DiscardReason != null &&
                    this.DiscardReason.Equals(input.DiscardReason))
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.Series == input.Series ||
                    this.Series != null &&
                    input.Series != null &&
                    this.Series.SequenceEqual(input.Series)
                ) && 
                (
                    this.TotalRetryCount == input.TotalRetryCount ||
                    this.TotalRetryCount.Equals(input.TotalRetryCount)
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
                if (this.EventName != null)
                {
                    hashCode = (hashCode * 59) + this.EventName.GetHashCode();
                }
                if (this.AppVersion != null)
                {
                    hashCode = (hashCode * 59) + this.AppVersion.GetHashCode();
                }
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                if (this.DiscardReason != null)
                {
                    hashCode = (hashCode * 59) + this.DiscardReason.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
                if (this.Series != null)
                {
                    hashCode = (hashCode * 59) + this.Series.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalRetryCount.GetHashCode();
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
