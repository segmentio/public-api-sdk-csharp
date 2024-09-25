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
    /// The reverse ETL sync statuses that were looked up.
    /// </summary>
    [DataContract(Name = "ListReverseETLSyncStatusesFromModelAndSubscriptionIdOutput")]
    public partial class ListReverseETLSyncStatusesFromModelAndSubscriptionIdOutput : IEquatable<ListReverseETLSyncStatusesFromModelAndSubscriptionIdOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListReverseETLSyncStatusesFromModelAndSubscriptionIdOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListReverseETLSyncStatusesFromModelAndSubscriptionIdOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListReverseETLSyncStatusesFromModelAndSubscriptionIdOutput" /> class.
        /// </summary>
        /// <param name="syncStatuses">The reverse ETL sync statuses that were looked up of the subscription id. (required).</param>
        /// <param name="pagination">pagination.</param>
        public ListReverseETLSyncStatusesFromModelAndSubscriptionIdOutput(List<ReverseETLSyncStatus> syncStatuses = default(List<ReverseETLSyncStatus>), PaginationOutput pagination = default(PaginationOutput))
        {
            // to ensure "syncStatuses" is required (not null)
            if (syncStatuses == null)
            {
                throw new ArgumentNullException("syncStatuses is a required property for ListReverseETLSyncStatusesFromModelAndSubscriptionIdOutput and cannot be null");
            }
            this.SyncStatuses = syncStatuses;
            this.Pagination = pagination;
        }

        /// <summary>
        /// The reverse ETL sync statuses that were looked up of the subscription id.
        /// </summary>
        /// <value>The reverse ETL sync statuses that were looked up of the subscription id.</value>
        [DataMember(Name = "syncStatuses", IsRequired = true, EmitDefaultValue = true)]
        public List<ReverseETLSyncStatus> SyncStatuses { get; set; }

        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name = "pagination", EmitDefaultValue = false)]
        public PaginationOutput Pagination { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListReverseETLSyncStatusesFromModelAndSubscriptionIdOutput {\n");
            sb.Append("  SyncStatuses: ").Append(SyncStatuses).Append("\n");
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
            return this.Equals(input as ListReverseETLSyncStatusesFromModelAndSubscriptionIdOutput);
        }

        /// <summary>
        /// Returns true if ListReverseETLSyncStatusesFromModelAndSubscriptionIdOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of ListReverseETLSyncStatusesFromModelAndSubscriptionIdOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListReverseETLSyncStatusesFromModelAndSubscriptionIdOutput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SyncStatuses == input.SyncStatuses ||
                    this.SyncStatuses != null &&
                    input.SyncStatuses != null &&
                    this.SyncStatuses.SequenceEqual(input.SyncStatuses)
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
                if (this.SyncStatuses != null)
                {
                    hashCode = (hashCode * 59) + this.SyncStatuses.GetHashCode();
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