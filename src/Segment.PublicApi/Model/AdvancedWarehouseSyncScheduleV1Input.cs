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
    /// Defines the advanced sync schedule for a Warehouse.
    /// </summary>
    [DataContract(Name = "AdvancedWarehouseSyncScheduleV1Input")]
    public partial class AdvancedWarehouseSyncScheduleV1Input : IEquatable<AdvancedWarehouseSyncScheduleV1Input>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedWarehouseSyncScheduleV1Input" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdvancedWarehouseSyncScheduleV1Input() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedWarehouseSyncScheduleV1Input" /> class.
        /// </summary>
        /// <param name="times">A list that contains the times when syncs should occur. (required).</param>
        /// <param name="timezone">A TZ-database timezone for this sync schedule. (required).</param>
        public AdvancedWarehouseSyncScheduleV1Input(List<WarehouseAdvancedSyncV1> times = default(List<WarehouseAdvancedSyncV1>), string timezone = default(string))
        {
            // to ensure "times" is required (not null)
            if (times == null)
            {
                throw new ArgumentNullException("times is a required property for AdvancedWarehouseSyncScheduleV1Input and cannot be null");
            }
            this.Times = times;
            // to ensure "timezone" is required (not null)
            if (timezone == null)
            {
                throw new ArgumentNullException("timezone is a required property for AdvancedWarehouseSyncScheduleV1Input and cannot be null");
            }
            this.Timezone = timezone;
        }

        /// <summary>
        /// A list that contains the times when syncs should occur.
        /// </summary>
        /// <value>A list that contains the times when syncs should occur.</value>
        [DataMember(Name = "times", IsRequired = true, EmitDefaultValue = true)]
        public List<WarehouseAdvancedSyncV1> Times { get; set; }

        /// <summary>
        /// A TZ-database timezone for this sync schedule.
        /// </summary>
        /// <value>A TZ-database timezone for this sync schedule.</value>
        [DataMember(Name = "timezone", IsRequired = true, EmitDefaultValue = true)]
        public string Timezone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdvancedWarehouseSyncScheduleV1Input {\n");
            sb.Append("  Times: ").Append(Times).Append("\n");
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
            return this.Equals(input as AdvancedWarehouseSyncScheduleV1Input);
        }

        /// <summary>
        /// Returns true if AdvancedWarehouseSyncScheduleV1Input instances are equal
        /// </summary>
        /// <param name="input">Instance of AdvancedWarehouseSyncScheduleV1Input to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdvancedWarehouseSyncScheduleV1Input input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Times == input.Times ||
                    this.Times != null &&
                    input.Times != null &&
                    this.Times.SequenceEqual(input.Times)
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
                if (this.Times != null)
                {
                    hashCode = (hashCode * 59) + this.Times.GetHashCode();
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
