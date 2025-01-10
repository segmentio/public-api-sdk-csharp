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
    /// Defines a configuration object used for scheduling, which can vary depending on the configured strategy.
    /// </summary>
    [DataContract(Name = "ReverseEtlScheduleDefinition")]
    public partial class ReverseEtlScheduleDefinition : IEquatable<ReverseEtlScheduleDefinition>, IValidatableObject
    {
        /// <summary>
        /// Strategy supports: Periodic, Specific Days, Manual, CRON and DBT_CLOUD.
        /// </summary>
        /// <value>Strategy supports: Periodic, Specific Days, Manual, CRON and DBT_CLOUD.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StrategyEnum
        {
            /// <summary>
            /// Enum CRON for value: CRON
            /// </summary>
            [EnumMember(Value = "CRON")]
            CRON = 1,

            /// <summary>
            /// Enum DBTCLOUD for value: DBT_CLOUD
            /// </summary>
            [EnumMember(Value = "DBT_CLOUD")]
            DBTCLOUD = 2,

            /// <summary>
            /// Enum MANUAL for value: MANUAL
            /// </summary>
            [EnumMember(Value = "MANUAL")]
            MANUAL = 3,

            /// <summary>
            /// Enum PERIODIC for value: PERIODIC
            /// </summary>
            [EnumMember(Value = "PERIODIC")]
            PERIODIC = 4,

            /// <summary>
            /// Enum SPECIFICDAYS for value: SPECIFIC_DAYS
            /// </summary>
            [EnumMember(Value = "SPECIFIC_DAYS")]
            SPECIFICDAYS = 5
        }


        /// <summary>
        /// Strategy supports: Periodic, Specific Days, Manual, CRON and DBT_CLOUD.
        /// </summary>
        /// <value>Strategy supports: Periodic, Specific Days, Manual, CRON and DBT_CLOUD.</value>
        [DataMember(Name = "strategy", IsRequired = true, EmitDefaultValue = true)]
        public StrategyEnum Strategy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseEtlScheduleDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReverseEtlScheduleDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseEtlScheduleDefinition" /> class.
        /// </summary>
        /// <param name="strategy">Strategy supports: Periodic, Specific Days, Manual, CRON and DBT_CLOUD. (required).</param>
        /// <param name="config">config.</param>
        public ReverseEtlScheduleDefinition(StrategyEnum strategy = default(StrategyEnum), Config config = default(Config))
        {
            this.Strategy = strategy;
            this.Config = config;
        }

        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name = "config", EmitDefaultValue = true)]
        public Config Config { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReverseEtlScheduleDefinition {\n");
            sb.Append("  Strategy: ").Append(Strategy).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
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
            return this.Equals(input as ReverseEtlScheduleDefinition);
        }

        /// <summary>
        /// Returns true if ReverseEtlScheduleDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of ReverseEtlScheduleDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReverseEtlScheduleDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Strategy == input.Strategy ||
                    this.Strategy.Equals(input.Strategy)
                ) && 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
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
                hashCode = (hashCode * 59) + this.Strategy.GetHashCode();
                if (this.Config != null)
                {
                    hashCode = (hashCode * 59) + this.Config.GetHashCode();
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
