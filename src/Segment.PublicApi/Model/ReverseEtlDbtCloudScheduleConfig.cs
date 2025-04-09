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
    /// Definition for a schedule triggered by dbt Cloud job events.
    /// </summary>
    [DataContract(Name = "ReverseEtlDbtCloudScheduleConfig")]
    public partial class ReverseEtlDbtCloudScheduleConfig : IEquatable<ReverseEtlDbtCloudScheduleConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseEtlDbtCloudScheduleConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReverseEtlDbtCloudScheduleConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseEtlDbtCloudScheduleConfig" /> class.
        /// </summary>
        /// <param name="jobId">The dbt Cloud job used to trigger a sync for a Reverse ETL Connection. (required).</param>
        /// <param name="accountId">The dbt Cloud account where the job belongs to. (required).</param>
        public ReverseEtlDbtCloudScheduleConfig(string jobId = default(string), string accountId = default(string))
        {
            // to ensure "jobId" is required (not null)
            if (jobId == null)
            {
                throw new ArgumentNullException("jobId is a required property for ReverseEtlDbtCloudScheduleConfig and cannot be null");
            }
            this.JobId = jobId;
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new ArgumentNullException("accountId is a required property for ReverseEtlDbtCloudScheduleConfig and cannot be null");
            }
            this.AccountId = accountId;
        }

        /// <summary>
        /// The dbt Cloud job used to trigger a sync for a Reverse ETL Connection.
        /// </summary>
        /// <value>The dbt Cloud job used to trigger a sync for a Reverse ETL Connection.</value>
        [DataMember(Name = "jobId", IsRequired = true, EmitDefaultValue = true)]
        public string JobId { get; set; }

        /// <summary>
        /// The dbt Cloud account where the job belongs to.
        /// </summary>
        /// <value>The dbt Cloud account where the job belongs to.</value>
        [DataMember(Name = "accountId", IsRequired = true, EmitDefaultValue = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReverseEtlDbtCloudScheduleConfig {\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
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
            return this.Equals(input as ReverseEtlDbtCloudScheduleConfig);
        }

        /// <summary>
        /// Returns true if ReverseEtlDbtCloudScheduleConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ReverseEtlDbtCloudScheduleConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReverseEtlDbtCloudScheduleConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
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
                if (this.JobId != null)
                {
                    hashCode = (hashCode * 59) + this.JobId.GetHashCode();
                }
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
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
