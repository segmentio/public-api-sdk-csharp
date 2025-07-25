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
    /// Replaces the advanced sync schedule for a Warehouse.
    /// </summary>
    [DataContract(Name = "ReplaceAdvancedSyncScheduleForWarehouseV1Input")]
    public partial class ReplaceAdvancedSyncScheduleForWarehouseV1Input : IEquatable<ReplaceAdvancedSyncScheduleForWarehouseV1Input>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceAdvancedSyncScheduleForWarehouseV1Input" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReplaceAdvancedSyncScheduleForWarehouseV1Input() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceAdvancedSyncScheduleForWarehouseV1Input" /> class.
        /// </summary>
        /// <param name="enabled">Enable to turn on an advanced sync schedule for the Warehouse. (required).</param>
        /// <param name="schedule">schedule.</param>
        public ReplaceAdvancedSyncScheduleForWarehouseV1Input(bool enabled = default(bool), AdvancedWarehouseSyncScheduleV1Input schedule = default(AdvancedWarehouseSyncScheduleV1Input))
        {
            this.Enabled = enabled;
            this.Schedule = schedule;
        }

        /// <summary>
        /// Enable to turn on an advanced sync schedule for the Warehouse.
        /// </summary>
        /// <value>Enable to turn on an advanced sync schedule for the Warehouse.</value>
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name = "schedule", EmitDefaultValue = false)]
        public AdvancedWarehouseSyncScheduleV1Input Schedule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReplaceAdvancedSyncScheduleForWarehouseV1Input {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
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
            return this.Equals(input as ReplaceAdvancedSyncScheduleForWarehouseV1Input);
        }

        /// <summary>
        /// Returns true if ReplaceAdvancedSyncScheduleForWarehouseV1Input instances are equal
        /// </summary>
        /// <param name="input">Instance of ReplaceAdvancedSyncScheduleForWarehouseV1Input to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplaceAdvancedSyncScheduleForWarehouseV1Input input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
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
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.Schedule != null)
                {
                    hashCode = (hashCode * 59) + this.Schedule.GetHashCode();
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
