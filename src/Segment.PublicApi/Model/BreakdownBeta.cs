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
    /// The breakdown of a metric.
    /// </summary>
    [DataContract(Name = "BreakdownBeta")]
    public partial class BreakdownBeta : IEquatable<BreakdownBeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BreakdownBeta" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BreakdownBeta() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BreakdownBeta" /> class.
        /// </summary>
        /// <param name="metricName">The name of the metric. (required).</param>
        /// <param name="value">Number of occurrences of the metric. (required).</param>
        public BreakdownBeta(string metricName = default(string), decimal value = default(decimal))
        {
            // to ensure "metricName" is required (not null)
            if (metricName == null)
            {
                throw new ArgumentNullException("metricName is a required property for BreakdownBeta and cannot be null");
            }
            this.MetricName = metricName;
            this.Value = value;
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
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public decimal Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BreakdownBeta {\n");
            sb.Append("  MetricName: ").Append(MetricName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as BreakdownBeta);
        }

        /// <summary>
        /// Returns true if BreakdownBeta instances are equal
        /// </summary>
        /// <param name="input">Instance of BreakdownBeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BreakdownBeta input)
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
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
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
                hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
