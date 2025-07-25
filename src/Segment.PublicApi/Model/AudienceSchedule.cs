/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.13.0
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
    /// Defines an Audience Schedule.
    /// </summary>
    [DataContract(Name = "AudienceSchedule")]
    public partial class AudienceSchedule : IEquatable<AudienceSchedule>, IValidatableObject
    {
        /// <summary>
        /// Strategy of the audience schedule (manual, periodic, or specific days).
        /// </summary>
        /// <value>Strategy of the audience schedule (manual, periodic, or specific days).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StrategyEnum
        {
            /// <summary>
            /// Enum MANUAL for value: MANUAL
            /// </summary>
            [EnumMember(Value = "MANUAL")]
            MANUAL = 1,

            /// <summary>
            /// Enum PERIODIC for value: PERIODIC
            /// </summary>
            [EnumMember(Value = "PERIODIC")]
            PERIODIC = 2,

            /// <summary>
            /// Enum SPECIFICDAYS for value: SPECIFIC_DAYS
            /// </summary>
            [EnumMember(Value = "SPECIFIC_DAYS")]
            SPECIFICDAYS = 3
        }


        /// <summary>
        /// Strategy of the audience schedule (manual, periodic, or specific days).
        /// </summary>
        /// <value>Strategy of the audience schedule (manual, periodic, or specific days).</value>
        [DataMember(Name = "strategy", IsRequired = true, EmitDefaultValue = true)]
        public StrategyEnum Strategy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AudienceSchedule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AudienceSchedule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AudienceSchedule" /> class.
        /// </summary>
        /// <param name="id">Distinct identifier for the schedule. (required).</param>
        /// <param name="strategy">Strategy of the audience schedule (manual, periodic, or specific days). (required).</param>
        /// <param name="config">config.</param>
        /// <param name="nextExecution">The next scheduled execution time (RFC3339)..</param>
        public AudienceSchedule(string id = default(string), StrategyEnum strategy = default(StrategyEnum), Config config = default(Config), string nextExecution = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for AudienceSchedule and cannot be null");
            }
            this.Id = id;
            this.Strategy = strategy;
            this.Config = config;
            this.NextExecution = nextExecution;
        }

        /// <summary>
        /// Distinct identifier for the schedule.
        /// </summary>
        /// <value>Distinct identifier for the schedule.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name = "config", EmitDefaultValue = true)]
        public Config Config { get; set; }

        /// <summary>
        /// The next scheduled execution time (RFC3339).
        /// </summary>
        /// <value>The next scheduled execution time (RFC3339).</value>
        [DataMember(Name = "nextExecution", EmitDefaultValue = false)]
        public string NextExecution { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AudienceSchedule {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Strategy: ").Append(Strategy).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  NextExecution: ").Append(NextExecution).Append("\n");
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
            return this.Equals(input as AudienceSchedule);
        }

        /// <summary>
        /// Returns true if AudienceSchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of AudienceSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AudienceSchedule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Strategy == input.Strategy ||
                    this.Strategy.Equals(input.Strategy)
                ) && 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
                ) && 
                (
                    this.NextExecution == input.NextExecution ||
                    (this.NextExecution != null &&
                    this.NextExecution.Equals(input.NextExecution))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Strategy.GetHashCode();
                if (this.Config != null)
                {
                    hashCode = (hashCode * 59) + this.Config.GetHashCode();
                }
                if (this.NextExecution != null)
                {
                    hashCode = (hashCode * 59) + this.NextExecution.GetHashCode();
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
