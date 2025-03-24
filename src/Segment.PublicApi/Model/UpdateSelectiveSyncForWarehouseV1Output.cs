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
    /// Results from updating the schema for a Warehouse/source pair.
    /// </summary>
    [DataContract(Name = "UpdateSelectiveSyncForWarehouseV1Output")]
    public partial class UpdateSelectiveSyncForWarehouseV1Output : IEquatable<UpdateSelectiveSyncForWarehouseV1Output>, IValidatableObject
    {
        /// <summary>
        /// Status of the update operation.
        /// </summary>
        /// <value>Status of the update operation.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum UNCHANGED for value: UNCHANGED
            /// </summary>
            [EnumMember(Value = "UNCHANGED")]
            UNCHANGED = 1,

            /// <summary>
            /// Enum UPDATED for value: UPDATED
            /// </summary>
            [EnumMember(Value = "UPDATED")]
            UPDATED = 2
        }


        /// <summary>
        /// Status of the update operation.
        /// </summary>
        /// <value>Status of the update operation.</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSelectiveSyncForWarehouseV1Output" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateSelectiveSyncForWarehouseV1Output() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSelectiveSyncForWarehouseV1Output" /> class.
        /// </summary>
        /// <param name="status">Status of the update operation. (required).</param>
        /// <param name="warnings">Warnings returned by the operation. (required).</param>
        public UpdateSelectiveSyncForWarehouseV1Output(StatusEnum status = default(StatusEnum), List<string> warnings = default(List<string>))
        {
            this.Status = status;
            // to ensure "warnings" is required (not null)
            if (warnings == null)
            {
                throw new ArgumentNullException("warnings is a required property for UpdateSelectiveSyncForWarehouseV1Output and cannot be null");
            }
            this.Warnings = warnings;
        }

        /// <summary>
        /// Warnings returned by the operation.
        /// </summary>
        /// <value>Warnings returned by the operation.</value>
        [DataMember(Name = "warnings", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Warnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateSelectiveSyncForWarehouseV1Output {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
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
            return this.Equals(input as UpdateSelectiveSyncForWarehouseV1Output);
        }

        /// <summary>
        /// Returns true if UpdateSelectiveSyncForWarehouseV1Output instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateSelectiveSyncForWarehouseV1Output to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateSelectiveSyncForWarehouseV1Output input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
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
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Warnings != null)
                {
                    hashCode = (hashCode * 59) + this.Warnings.GetHashCode();
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
