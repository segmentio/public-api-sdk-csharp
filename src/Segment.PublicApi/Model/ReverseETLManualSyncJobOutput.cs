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
    /// StartJobOutput returns the result of triggering the specified job.
    /// </summary>
    [DataContract(Name = "ReverseETLManualSyncJobOutput")]
    public partial class ReverseETLManualSyncJobOutput : IEquatable<ReverseETLManualSyncJobOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseETLManualSyncJobOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReverseETLManualSyncJobOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseETLManualSyncJobOutput" /> class.
        /// </summary>
        /// <param name="startedAt">A datetime that indicates when the job was triggered. (required).</param>
        /// <param name="syncId">The unique id for the sync that was triggered. (required).</param>
        public ReverseETLManualSyncJobOutput(string startedAt = default(string), string syncId = default(string))
        {
            // to ensure "startedAt" is required (not null)
            if (startedAt == null)
            {
                throw new ArgumentNullException("startedAt is a required property for ReverseETLManualSyncJobOutput and cannot be null");
            }
            this.StartedAt = startedAt;
            // to ensure "syncId" is required (not null)
            if (syncId == null)
            {
                throw new ArgumentNullException("syncId is a required property for ReverseETLManualSyncJobOutput and cannot be null");
            }
            this.SyncId = syncId;
        }

        /// <summary>
        /// A datetime that indicates when the job was triggered.
        /// </summary>
        /// <value>A datetime that indicates when the job was triggered.</value>
        [DataMember(Name = "startedAt", IsRequired = true, EmitDefaultValue = true)]
        public string StartedAt { get; set; }

        /// <summary>
        /// The unique id for the sync that was triggered.
        /// </summary>
        /// <value>The unique id for the sync that was triggered.</value>
        [DataMember(Name = "syncId", IsRequired = true, EmitDefaultValue = true)]
        public string SyncId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReverseETLManualSyncJobOutput {\n");
            sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
            sb.Append("  SyncId: ").Append(SyncId).Append("\n");
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
            return this.Equals(input as ReverseETLManualSyncJobOutput);
        }

        /// <summary>
        /// Returns true if ReverseETLManualSyncJobOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of ReverseETLManualSyncJobOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReverseETLManualSyncJobOutput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StartedAt == input.StartedAt ||
                    (this.StartedAt != null &&
                    this.StartedAt.Equals(input.StartedAt))
                ) && 
                (
                    this.SyncId == input.SyncId ||
                    (this.SyncId != null &&
                    this.SyncId.Equals(input.SyncId))
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
                if (this.StartedAt != null)
                {
                    hashCode = (hashCode * 59) + this.StartedAt.GetHashCode();
                }
                if (this.SyncId != null)
                {
                    hashCode = (hashCode * 59) + this.SyncId.GetHashCode();
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
