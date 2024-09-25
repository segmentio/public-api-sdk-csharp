/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 54.2.0
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
    /// Returns a list of daily aggregations of Source level MTU counts.
    /// </summary>
    [DataContract(Name = "GetDailyPerSourceMTUUsageV1Output")]
    public partial class GetDailyPerSourceMTUUsageV1Output : IEquatable<GetDailyPerSourceMTUUsageV1Output>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDailyPerSourceMTUUsageV1Output" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetDailyPerSourceMTUUsageV1Output() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDailyPerSourceMTUUsageV1Output" /> class.
        /// </summary>
        /// <param name="dailyPerSourceMTUUsage">The list of daily per Source MTU count aggregates. (required).</param>
        /// <param name="pagination">pagination (required).</param>
        public GetDailyPerSourceMTUUsageV1Output(List<UsersPerSourceSnapshotV1> dailyPerSourceMTUUsage = default(List<UsersPerSourceSnapshotV1>), PaginationOutput pagination = default(PaginationOutput))
        {
            // to ensure "dailyPerSourceMTUUsage" is required (not null)
            if (dailyPerSourceMTUUsage == null)
            {
                throw new ArgumentNullException("dailyPerSourceMTUUsage is a required property for GetDailyPerSourceMTUUsageV1Output and cannot be null");
            }
            this.DailyPerSourceMTUUsage = dailyPerSourceMTUUsage;
            // to ensure "pagination" is required (not null)
            if (pagination == null)
            {
                throw new ArgumentNullException("pagination is a required property for GetDailyPerSourceMTUUsageV1Output and cannot be null");
            }
            this.Pagination = pagination;
        }

        /// <summary>
        /// The list of daily per Source MTU count aggregates.
        /// </summary>
        /// <value>The list of daily per Source MTU count aggregates.</value>
        [DataMember(Name = "dailyPerSourceMTUUsage", IsRequired = true, EmitDefaultValue = true)]
        public List<UsersPerSourceSnapshotV1> DailyPerSourceMTUUsage { get; set; }

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
            sb.Append("class GetDailyPerSourceMTUUsageV1Output {\n");
            sb.Append("  DailyPerSourceMTUUsage: ").Append(DailyPerSourceMTUUsage).Append("\n");
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
            return this.Equals(input as GetDailyPerSourceMTUUsageV1Output);
        }

        /// <summary>
        /// Returns true if GetDailyPerSourceMTUUsageV1Output instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDailyPerSourceMTUUsageV1Output to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDailyPerSourceMTUUsageV1Output input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DailyPerSourceMTUUsage == input.DailyPerSourceMTUUsage ||
                    this.DailyPerSourceMTUUsage != null &&
                    input.DailyPerSourceMTUUsage != null &&
                    this.DailyPerSourceMTUUsage.SequenceEqual(input.DailyPerSourceMTUUsage)
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
                if (this.DailyPerSourceMTUUsage != null)
                {
                    hashCode = (hashCode * 59) + this.DailyPerSourceMTUUsage.GetHashCode();
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