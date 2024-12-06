/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 57.1.0
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
    /// Definition for specific day and time schedule. Days is list of numbered day of the week and hours is a list of hour of the day. The corresponding Timezone is also input as string.
    /// </summary>
    [DataContract(Name = "ReverseEtlSpecificTimeScheduleConfig")]
    public partial class ReverseEtlSpecificTimeScheduleConfig : IEquatable<ReverseEtlSpecificTimeScheduleConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseEtlSpecificTimeScheduleConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReverseEtlSpecificTimeScheduleConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseEtlSpecificTimeScheduleConfig" /> class.
        /// </summary>
        /// <param name="days">Days of the week. (required).</param>
        /// <param name="hours">Hours of the day. (required).</param>
        /// <param name="timezone">Timezone for the specified times. (required).</param>
        public ReverseEtlSpecificTimeScheduleConfig(List<decimal> days = default(List<decimal>), List<decimal> hours = default(List<decimal>), string timezone = default(string))
        {
            // to ensure "days" is required (not null)
            if (days == null)
            {
                throw new ArgumentNullException("days is a required property for ReverseEtlSpecificTimeScheduleConfig and cannot be null");
            }
            this.Days = days;
            // to ensure "hours" is required (not null)
            if (hours == null)
            {
                throw new ArgumentNullException("hours is a required property for ReverseEtlSpecificTimeScheduleConfig and cannot be null");
            }
            this.Hours = hours;
            // to ensure "timezone" is required (not null)
            if (timezone == null)
            {
                throw new ArgumentNullException("timezone is a required property for ReverseEtlSpecificTimeScheduleConfig and cannot be null");
            }
            this.Timezone = timezone;
        }

        /// <summary>
        /// Days of the week.
        /// </summary>
        /// <value>Days of the week.</value>
        [DataMember(Name = "days", IsRequired = true, EmitDefaultValue = true)]
        public List<decimal> Days { get; set; }

        /// <summary>
        /// Hours of the day.
        /// </summary>
        /// <value>Hours of the day.</value>
        [DataMember(Name = "hours", IsRequired = true, EmitDefaultValue = true)]
        public List<decimal> Hours { get; set; }

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
            sb.Append("class ReverseEtlSpecificTimeScheduleConfig {\n");
            sb.Append("  Days: ").Append(Days).Append("\n");
            sb.Append("  Hours: ").Append(Hours).Append("\n");
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
            return this.Equals(input as ReverseEtlSpecificTimeScheduleConfig);
        }

        /// <summary>
        /// Returns true if ReverseEtlSpecificTimeScheduleConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ReverseEtlSpecificTimeScheduleConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReverseEtlSpecificTimeScheduleConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Days == input.Days ||
                    this.Days != null &&
                    input.Days != null &&
                    this.Days.SequenceEqual(input.Days)
                ) && 
                (
                    this.Hours == input.Hours ||
                    this.Hours != null &&
                    input.Hours != null &&
                    this.Hours.SequenceEqual(input.Hours)
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
                if (this.Days != null)
                {
                    hashCode = (hashCode * 59) + this.Days.GetHashCode();
                }
                if (this.Hours != null)
                {
                    hashCode = (hashCode * 59) + this.Hours.GetHashCode();
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
