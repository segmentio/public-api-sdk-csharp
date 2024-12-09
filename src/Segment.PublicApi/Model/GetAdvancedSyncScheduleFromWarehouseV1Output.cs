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
    /// Returns the advanced sync schedule for a Warehouse.
    /// </summary>
    [DataContract(Name = "GetAdvancedSyncScheduleFromWarehouseV1Output")]
    public partial class GetAdvancedSyncScheduleFromWarehouseV1Output : IEquatable<GetAdvancedSyncScheduleFromWarehouseV1Output>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAdvancedSyncScheduleFromWarehouseV1Output" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAdvancedSyncScheduleFromWarehouseV1Output() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAdvancedSyncScheduleFromWarehouseV1Output" /> class.
        /// </summary>
        /// <param name="enabled">Indicates if an advanced sync schedule is enabled for this Warehouse. (required).</param>
        /// <param name="schedule">schedule.</param>
        public GetAdvancedSyncScheduleFromWarehouseV1Output(bool enabled = default(bool), AdvancedWarehouseSyncScheduleV1Output schedule = default(AdvancedWarehouseSyncScheduleV1Output))
        {
            this.Enabled = enabled;
            this.Schedule = schedule;
        }

        /// <summary>
        /// Indicates if an advanced sync schedule is enabled for this Warehouse.
        /// </summary>
        /// <value>Indicates if an advanced sync schedule is enabled for this Warehouse.</value>
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name = "schedule", EmitDefaultValue = false)]
        public AdvancedWarehouseSyncScheduleV1Output Schedule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAdvancedSyncScheduleFromWarehouseV1Output {\n");
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
            return this.Equals(input as GetAdvancedSyncScheduleFromWarehouseV1Output);
        }

        /// <summary>
        /// Returns true if GetAdvancedSyncScheduleFromWarehouseV1Output instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAdvancedSyncScheduleFromWarehouseV1Output to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAdvancedSyncScheduleFromWarehouseV1Output input)
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
