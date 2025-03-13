/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.0.0
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
    /// Output of the Delivery Overview public API endpoints.
    /// </summary>
    [DataContract(Name = "GetDeliveryOverviewMetricsBetaOutput")]
    public partial class GetDeliveryOverviewMetricsBetaOutput : IEquatable<GetDeliveryOverviewMetricsBetaOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeliveryOverviewMetricsBetaOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetDeliveryOverviewMetricsBetaOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeliveryOverviewMetricsBetaOutput" /> class.
        /// </summary>
        /// <param name="total">The total number of events for the returned dataset. (required).</param>
        /// <param name="dataset">Represents the list of series broken down by the dimensions and time frame requested. (required).</param>
        /// <param name="pagination">pagination (required).</param>
        public GetDeliveryOverviewMetricsBetaOutput(decimal total = default(decimal), List<DeliveryOverviewMetricsDataset> dataset = default(List<DeliveryOverviewMetricsDataset>), PaginationOutput pagination = default(PaginationOutput))
        {
            this.Total = total;
            // to ensure "dataset" is required (not null)
            if (dataset == null)
            {
                throw new ArgumentNullException("dataset is a required property for GetDeliveryOverviewMetricsBetaOutput and cannot be null");
            }
            this.Dataset = dataset;
            // to ensure "pagination" is required (not null)
            if (pagination == null)
            {
                throw new ArgumentNullException("pagination is a required property for GetDeliveryOverviewMetricsBetaOutput and cannot be null");
            }
            this.Pagination = pagination;
        }

        /// <summary>
        /// The total number of events for the returned dataset.
        /// </summary>
        /// <value>The total number of events for the returned dataset.</value>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = true)]
        public decimal Total { get; set; }

        /// <summary>
        /// Represents the list of series broken down by the dimensions and time frame requested.
        /// </summary>
        /// <value>Represents the list of series broken down by the dimensions and time frame requested.</value>
        [DataMember(Name = "dataset", IsRequired = true, EmitDefaultValue = true)]
        public List<DeliveryOverviewMetricsDataset> Dataset { get; set; }

        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name = "pagination", IsRequired = true, EmitDefaultValue = true)]
        public PaginationOutput Pagination { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetDeliveryOverviewMetricsBetaOutput {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Dataset: ").Append(Dataset).Append("\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
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
            return this.Equals(input as GetDeliveryOverviewMetricsBetaOutput);
        }

        /// <summary>
        /// Returns true if GetDeliveryOverviewMetricsBetaOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDeliveryOverviewMetricsBetaOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDeliveryOverviewMetricsBetaOutput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.Dataset == input.Dataset ||
                    this.Dataset != null &&
                    input.Dataset != null &&
                    this.Dataset.SequenceEqual(input.Dataset)
                ) && 
                (
                    this.Pagination == input.Pagination ||
                    (this.Pagination != null &&
                    this.Pagination.Equals(input.Pagination))
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
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
                if (this.Dataset != null)
                {
                    hashCode = (hashCode * 59) + this.Dataset.GetHashCode();
                }
                if (this.Pagination != null)
                {
                    hashCode = (hashCode * 59) + this.Pagination.GetHashCode();
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
