/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 57.4.0
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
    /// Update journey status output.
    /// </summary>
    [DataContract(Name = "UpdateStatusForJourneyAlphaOutput")]
    public partial class UpdateStatusForJourneyAlphaOutput : IEquatable<UpdateStatusForJourneyAlphaOutput>, IValidatableObject
    {
        /// <summary>
        /// The status of the journey.
        /// </summary>
        /// <value>The status of the journey.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum ARCHIVED for value: ARCHIVED
            /// </summary>
            [EnumMember(Value = "ARCHIVED")]
            ARCHIVED = 1,

            /// <summary>
            /// Enum ENTRYPAUSED for value: ENTRY_PAUSED
            /// </summary>
            [EnumMember(Value = "ENTRY_PAUSED")]
            ENTRYPAUSED = 2,

            /// <summary>
            /// Enum PUBLISHED for value: PUBLISHED
            /// </summary>
            [EnumMember(Value = "PUBLISHED")]
            PUBLISHED = 3
        }


        /// <summary>
        /// The status of the journey.
        /// </summary>
        /// <value>The status of the journey.</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStatusForJourneyAlphaOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateStatusForJourneyAlphaOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStatusForJourneyAlphaOutput" /> class.
        /// </summary>
        /// <param name="containerId">The journey container id. (required).</param>
        /// <param name="varVersion">The journey version. (required).</param>
        /// <param name="status">The status of the journey. (required).</param>
        public UpdateStatusForJourneyAlphaOutput(string containerId = default(string), decimal varVersion = default(decimal), StatusEnum status = default(StatusEnum))
        {
            // to ensure "containerId" is required (not null)
            if (containerId == null)
            {
                throw new ArgumentNullException("containerId is a required property for UpdateStatusForJourneyAlphaOutput and cannot be null");
            }
            this.ContainerId = containerId;
            this.VarVersion = varVersion;
            this.Status = status;
        }

        /// <summary>
        /// The journey container id.
        /// </summary>
        /// <value>The journey container id.</value>
        [DataMember(Name = "containerId", IsRequired = true, EmitDefaultValue = true)]
        public string ContainerId { get; set; }

        /// <summary>
        /// The journey version.
        /// </summary>
        /// <value>The journey version.</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public decimal VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateStatusForJourneyAlphaOutput {\n");
            sb.Append("  ContainerId: ").Append(ContainerId).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as UpdateStatusForJourneyAlphaOutput);
        }

        /// <summary>
        /// Returns true if UpdateStatusForJourneyAlphaOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateStatusForJourneyAlphaOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateStatusForJourneyAlphaOutput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContainerId == input.ContainerId ||
                    (this.ContainerId != null &&
                    this.ContainerId.Equals(input.ContainerId))
                ) && 
                (
                    this.VarVersion == input.VarVersion ||
                    this.VarVersion.Equals(input.VarVersion)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                if (this.ContainerId != null)
                {
                    hashCode = (hashCode * 59) + this.ContainerId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VarVersion.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
