/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 56.0.0
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
    /// The event delivery metric.
    /// </summary>
    [DataContract(Name = "MetricBeta")]
    public partial class MetricBeta : IEquatable<MetricBeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricBeta" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MetricBeta() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricBeta" /> class.
        /// </summary>
        /// <param name="metricName">The name of the metric. (required).</param>
        /// <param name="total">Number of occurrences of the metric. (required).</param>
        /// <param name="breakdown">Breakdown of metrics within a metric..</param>
        public MetricBeta(string metricName = default(string), decimal total = default(decimal), List<BreakdownBeta> breakdown = default(List<BreakdownBeta>))
        {
            // to ensure "metricName" is required (not null)
            if (metricName == null)
            {
                throw new ArgumentNullException("metricName is a required property for MetricBeta and cannot be null");
            }
            this.MetricName = metricName;
            this.Total = total;
            this.Breakdown = breakdown;
        }

        /// <summary>
        /// The name of the metric.
        /// </summary>
        /// <value>The name of the metric.</value>
        [DataMember(Name = "metricName", IsRequired = true, EmitDefaultValue = true)]
        public string MetricName { get; set; }

        /// <summary>
        /// Number of occurrences of the metric.
        /// </summary>
        /// <value>Number of occurrences of the metric.</value>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = true)]
        public decimal Total { get; set; }

        /// <summary>
        /// Breakdown of metrics within a metric.
        /// </summary>
        /// <value>Breakdown of metrics within a metric.</value>
        [DataMember(Name = "breakdown", EmitDefaultValue = false)]
        public List<BreakdownBeta> Breakdown { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MetricBeta {\n");
            sb.Append("  MetricName: ").Append(MetricName).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Breakdown: ").Append(Breakdown).Append("\n");
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
            return this.Equals(input as MetricBeta);
        }

        /// <summary>
        /// Returns true if MetricBeta instances are equal
        /// </summary>
        /// <param name="input">Instance of MetricBeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetricBeta input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MetricName == input.MetricName ||
                    (this.MetricName != null &&
                    this.MetricName.Equals(input.MetricName))
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.Breakdown == input.Breakdown ||
                    this.Breakdown != null &&
                    input.Breakdown != null &&
                    this.Breakdown.SequenceEqual(input.Breakdown)
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
                if (this.MetricName != null)
                {
                    hashCode = (hashCode * 59) + this.MetricName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
                if (this.Breakdown != null)
                {
                    hashCode = (hashCode * 59) + this.Breakdown.GetHashCode();
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
