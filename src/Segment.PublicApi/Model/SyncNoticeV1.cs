/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 55.0.0
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
    /// Represents a notice within a sync for a Source and Warehouse pair.
    /// </summary>
    [DataContract(Name = "SyncNoticeV1")]
    public partial class SyncNoticeV1 : IEquatable<SyncNoticeV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncNoticeV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SyncNoticeV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncNoticeV1" /> class.
        /// </summary>
        /// <param name="level">The severity of the notice. (required).</param>
        /// <param name="message">The human-readable message that describes the notice. (required).</param>
        /// <param name="createdAt">The timestamp of this sync notice&#39;s creation. (required).</param>
        public SyncNoticeV1(string level = default(string), string message = default(string), string createdAt = default(string))
        {
            // to ensure "level" is required (not null)
            if (level == null)
            {
                throw new ArgumentNullException("level is a required property for SyncNoticeV1 and cannot be null");
            }
            this.Level = level;
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for SyncNoticeV1 and cannot be null");
            }
            this.Message = message;
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new ArgumentNullException("createdAt is a required property for SyncNoticeV1 and cannot be null");
            }
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// The severity of the notice.
        /// </summary>
        /// <value>The severity of the notice.</value>
        [DataMember(Name = "level", IsRequired = true, EmitDefaultValue = true)]
        public string Level { get; set; }

        /// <summary>
        /// The human-readable message that describes the notice.
        /// </summary>
        /// <value>The human-readable message that describes the notice.</value>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// The timestamp of this sync notice&#39;s creation.
        /// </summary>
        /// <value>The timestamp of this sync notice&#39;s creation.</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SyncNoticeV1 {\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as SyncNoticeV1);
        }

        /// <summary>
        /// Returns true if SyncNoticeV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of SyncNoticeV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SyncNoticeV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.Level != null)
                {
                    hashCode = (hashCode * 59) + this.Level.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
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
