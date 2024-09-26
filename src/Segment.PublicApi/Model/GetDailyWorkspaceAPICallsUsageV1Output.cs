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
    /// Returns a list of daily aggregations of Workspace MTU counts.
    /// </summary>
    [DataContract(Name = "GetDailyWorkspaceAPICallsUsageV1Output")]
    public partial class GetDailyWorkspaceAPICallsUsageV1Output : IEquatable<GetDailyWorkspaceAPICallsUsageV1Output>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDailyWorkspaceAPICallsUsageV1Output" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetDailyWorkspaceAPICallsUsageV1Output() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDailyWorkspaceAPICallsUsageV1Output" /> class.
        /// </summary>
        /// <param name="dailyWorkspaceAPICallsUsage">The list of daily Workspace API calls count aggregates. (required).</param>
        /// <param name="pagination">pagination (required).</param>
        public GetDailyWorkspaceAPICallsUsageV1Output(List<APICallSnapshotV1> dailyWorkspaceAPICallsUsage = default(List<APICallSnapshotV1>), PaginationOutput pagination = default(PaginationOutput))
        {
            // to ensure "dailyWorkspaceAPICallsUsage" is required (not null)
            if (dailyWorkspaceAPICallsUsage == null)
            {
                throw new ArgumentNullException("dailyWorkspaceAPICallsUsage is a required property for GetDailyWorkspaceAPICallsUsageV1Output and cannot be null");
            }
            this.DailyWorkspaceAPICallsUsage = dailyWorkspaceAPICallsUsage;
            // to ensure "pagination" is required (not null)
            if (pagination == null)
            {
                throw new ArgumentNullException("pagination is a required property for GetDailyWorkspaceAPICallsUsageV1Output and cannot be null");
            }
            this.Pagination = pagination;
        }

        /// <summary>
        /// The list of daily Workspace API calls count aggregates.
        /// </summary>
        /// <value>The list of daily Workspace API calls count aggregates.</value>
        [DataMember(Name = "dailyWorkspaceAPICallsUsage", IsRequired = true, EmitDefaultValue = true)]
        public List<APICallSnapshotV1> DailyWorkspaceAPICallsUsage { get; set; }

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
            sb.Append("class GetDailyWorkspaceAPICallsUsageV1Output {\n");
            sb.Append("  DailyWorkspaceAPICallsUsage: ").Append(DailyWorkspaceAPICallsUsage).Append("\n");
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
            return this.Equals(input as GetDailyWorkspaceAPICallsUsageV1Output);
        }

        /// <summary>
        /// Returns true if GetDailyWorkspaceAPICallsUsageV1Output instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDailyWorkspaceAPICallsUsageV1Output to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDailyWorkspaceAPICallsUsageV1Output input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DailyWorkspaceAPICallsUsage == input.DailyWorkspaceAPICallsUsage ||
                    this.DailyWorkspaceAPICallsUsage != null &&
                    input.DailyWorkspaceAPICallsUsage != null &&
                    this.DailyWorkspaceAPICallsUsage.SequenceEqual(input.DailyWorkspaceAPICallsUsage)
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
                if (this.DailyWorkspaceAPICallsUsage != null)
                {
                    hashCode = (hashCode * 59) + this.DailyWorkspaceAPICallsUsage.GetHashCode();
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
