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
    /// ReverseEtlCronScheduleConfig
    /// </summary>
    [DataContract(Name = "ReverseEtlCronScheduleConfig")]
    public partial class ReverseEtlCronScheduleConfig : IEquatable<ReverseEtlCronScheduleConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseEtlCronScheduleConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReverseEtlCronScheduleConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseEtlCronScheduleConfig" /> class.
        /// </summary>
        /// <param name="spec">5 field cron string expression. The cron expression must be larger than 15 minutes. (required).</param>
        /// <param name="timezone">Timezone for the specified times. (required).</param>
        public ReverseEtlCronScheduleConfig(string spec = default(string), string timezone = default(string))
        {
            // to ensure "spec" is required (not null)
            if (spec == null)
            {
                throw new ArgumentNullException("spec is a required property for ReverseEtlCronScheduleConfig and cannot be null");
            }
            this.Spec = spec;
            // to ensure "timezone" is required (not null)
            if (timezone == null)
            {
                throw new ArgumentNullException("timezone is a required property for ReverseEtlCronScheduleConfig and cannot be null");
            }
            this.Timezone = timezone;
        }

        /// <summary>
        /// 5 field cron string expression. The cron expression must be larger than 15 minutes.
        /// </summary>
        /// <value>5 field cron string expression. The cron expression must be larger than 15 minutes.</value>
        [DataMember(Name = "spec", IsRequired = true, EmitDefaultValue = true)]
        public string Spec { get; set; }

        /// <summary>
        /// Timezone for the specified times.
        /// </summary>
        /// <value>Timezone for the specified times.</value>
        [DataMember(Name = "timezone", IsRequired = true, EmitDefaultValue = true)]
        public string Timezone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReverseEtlCronScheduleConfig {\n");
            sb.Append("  Spec: ").Append(Spec).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
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
            return this.Equals(input as ReverseEtlCronScheduleConfig);
        }

        /// <summary>
        /// Returns true if ReverseEtlCronScheduleConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ReverseEtlCronScheduleConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReverseEtlCronScheduleConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Spec == input.Spec ||
                    (this.Spec != null &&
                    this.Spec.Equals(input.Spec))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
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
                if (this.Spec != null)
                {
                    hashCode = (hashCode * 59) + this.Spec.GetHashCode();
                }
                if (this.Timezone != null)
                {
                    hashCode = (hashCode * 59) + this.Timezone.GetHashCode();
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
