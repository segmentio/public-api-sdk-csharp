/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 57.0.1
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
    /// Determines the time of day at which a Warehouse should sync.
    /// </summary>
    [DataContract(Name = "WarehouseAdvancedSyncV1")]
    public partial class WarehouseAdvancedSyncV1 : IEquatable<WarehouseAdvancedSyncV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseAdvancedSyncV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WarehouseAdvancedSyncV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseAdvancedSyncV1" /> class.
        /// </summary>
        /// <param name="hourOfDay">The hour of day for which to enable/disable a sync, between 0 and 23. (required).</param>
        /// <param name="enabled">Enable to the sync at the specified hour. (required).</param>
        public WarehouseAdvancedSyncV1(decimal hourOfDay = default(decimal), bool enabled = default(bool))
        {
            this.HourOfDay = hourOfDay;
            this.Enabled = enabled;
        }

        /// <summary>
        /// The hour of day for which to enable/disable a sync, between 0 and 23.
        /// </summary>
        /// <value>The hour of day for which to enable/disable a sync, between 0 and 23.</value>
        [DataMember(Name = "hourOfDay", IsRequired = true, EmitDefaultValue = true)]
        public decimal HourOfDay { get; set; }

        /// <summary>
        /// Enable to the sync at the specified hour.
        /// </summary>
        /// <value>Enable to the sync at the specified hour.</value>
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WarehouseAdvancedSyncV1 {\n");
            sb.Append("  HourOfDay: ").Append(HourOfDay).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(input as WarehouseAdvancedSyncV1);
        }

        /// <summary>
        /// Returns true if WarehouseAdvancedSyncV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of WarehouseAdvancedSyncV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WarehouseAdvancedSyncV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HourOfDay == input.HourOfDay ||
                    this.HourOfDay.Equals(input.HourOfDay)
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
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
                hashCode = (hashCode * 59) + this.HourOfDay.GetHashCode();
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
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
