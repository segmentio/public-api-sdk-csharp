/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 57.2.0
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
    /// SourceEventVolume represents a time series of event volume for a Workspace broken down by the dimensions which the customer specifies (optional parameters).
    /// </summary>
    [DataContract(Name = "SourceEventVolumeV1")]
    public partial class SourceEventVolumeV1 : IEquatable<SourceEventVolumeV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceEventVolumeV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SourceEventVolumeV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceEventVolumeV1" /> class.
        /// </summary>
        /// <param name="source">source.</param>
        /// <param name="eventName">The name of the event, if applicable..</param>
        /// <param name="eventType">The event type, if applicable..</param>
        /// <param name="total">The total count for all events in the requested time frame. (required).</param>
        /// <param name="series">A list of the event counts broken down by the requested granularity. (required).</param>
        public SourceEventVolumeV1(EventSourceV1 source = default(EventSourceV1), string eventName = default(string), string eventType = default(string), decimal total = default(decimal), List<SourceEventVolumeDatapointV1> series = default(List<SourceEventVolumeDatapointV1>))
        {
            this.Total = total;
            // to ensure "series" is required (not null)
            if (series == null)
            {
                throw new ArgumentNullException("series is a required property for SourceEventVolumeV1 and cannot be null");
            }
            this.Series = series;
            this.Source = source;
            this.EventName = eventName;
            this.EventType = eventType;
        }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public EventSourceV1 Source { get; set; }

        /// <summary>
        /// The name of the event, if applicable.
        /// </summary>
        /// <value>The name of the event, if applicable.</value>
        [DataMember(Name = "eventName", EmitDefaultValue = false)]
        public string EventName { get; set; }

        /// <summary>
        /// The event type, if applicable.
        /// </summary>
        /// <value>The event type, if applicable.</value>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        public string EventType { get; set; }

        /// <summary>
        /// The total count for all events in the requested time frame.
        /// </summary>
        /// <value>The total count for all events in the requested time frame.</value>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = true)]
        public decimal Total { get; set; }

        /// <summary>
        /// A list of the event counts broken down by the requested granularity.
        /// </summary>
        /// <value>A list of the event counts broken down by the requested granularity.</value>
        [DataMember(Name = "series", IsRequired = true, EmitDefaultValue = true)]
        public List<SourceEventVolumeDatapointV1> Series { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SourceEventVolumeV1 {\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Series: ").Append(Series).Append("\n");
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
            return this.Equals(input as SourceEventVolumeV1);
        }

        /// <summary>
        /// Returns true if SourceEventVolumeV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of SourceEventVolumeV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourceEventVolumeV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
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
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                if (this.EventName != null)
                {
                    hashCode = (hashCode * 59) + this.EventName.GetHashCode();
                }
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
                if (this.Series != null)
                {
                    hashCode = (hashCode * 59) + this.Series.GetHashCode();
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
