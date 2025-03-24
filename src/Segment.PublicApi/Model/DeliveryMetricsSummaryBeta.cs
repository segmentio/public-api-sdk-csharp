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
    /// Defines the summary of delivery metrics for a Destination.
    /// </summary>
    [DataContract(Name = "DeliveryMetricsSummaryBeta")]
    public partial class DeliveryMetricsSummaryBeta : IEquatable<DeliveryMetricsSummaryBeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryMetricsSummaryBeta" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeliveryMetricsSummaryBeta() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryMetricsSummaryBeta" /> class.
        /// </summary>
        /// <param name="sourceId">The Source id.  Config API note: analogous to &#x60;parent&#x60;. (required).</param>
        /// <param name="destinationMetadataId">The Destination metadata id. (required).</param>
        /// <param name="metrics">The summary of event delivery metrics for the requested Destination. (required).</param>
        public DeliveryMetricsSummaryBeta(string sourceId = default(string), string destinationMetadataId = default(string), List<MetricBeta> metrics = default(List<MetricBeta>))
        {
            // to ensure "sourceId" is required (not null)
            if (sourceId == null)
            {
                throw new ArgumentNullException("sourceId is a required property for DeliveryMetricsSummaryBeta and cannot be null");
            }
            this.SourceId = sourceId;
            // to ensure "destinationMetadataId" is required (not null)
            if (destinationMetadataId == null)
            {
                throw new ArgumentNullException("destinationMetadataId is a required property for DeliveryMetricsSummaryBeta and cannot be null");
            }
            this.DestinationMetadataId = destinationMetadataId;
            // to ensure "metrics" is required (not null)
            if (metrics == null)
            {
                throw new ArgumentNullException("metrics is a required property for DeliveryMetricsSummaryBeta and cannot be null");
            }
            this.Metrics = metrics;
        }

        /// <summary>
        /// The Source id.  Config API note: analogous to &#x60;parent&#x60;.
        /// </summary>
        /// <value>The Source id.  Config API note: analogous to &#x60;parent&#x60;.</value>
        [DataMember(Name = "sourceId", IsRequired = true, EmitDefaultValue = true)]
        public string SourceId { get; set; }

        /// <summary>
        /// The Destination metadata id.
        /// </summary>
        /// <value>The Destination metadata id.</value>
        [DataMember(Name = "destinationMetadataId", IsRequired = true, EmitDefaultValue = true)]
        public string DestinationMetadataId { get; set; }

        /// <summary>
        /// The summary of event delivery metrics for the requested Destination.
        /// </summary>
        /// <value>The summary of event delivery metrics for the requested Destination.</value>
        [DataMember(Name = "metrics", IsRequired = true, EmitDefaultValue = true)]
        public List<MetricBeta> Metrics { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeliveryMetricsSummaryBeta {\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  DestinationMetadataId: ").Append(DestinationMetadataId).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
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
            return this.Equals(input as DeliveryMetricsSummaryBeta);
        }

        /// <summary>
        /// Returns true if DeliveryMetricsSummaryBeta instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryMetricsSummaryBeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryMetricsSummaryBeta input)
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
                    this.DestinationMetadataId == input.DestinationMetadataId ||
                    (this.DestinationMetadataId != null &&
                    this.DestinationMetadataId.Equals(input.DestinationMetadataId))
                ) && 
                (
                    this.Metrics == input.Metrics ||
                    this.Metrics != null &&
                    input.Metrics != null &&
                    this.Metrics.SequenceEqual(input.Metrics)
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
                if (this.DestinationMetadataId != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationMetadataId.GetHashCode();
                }
                if (this.Metrics != null)
                {
                    hashCode = (hashCode * 59) + this.Metrics.GetHashCode();
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
