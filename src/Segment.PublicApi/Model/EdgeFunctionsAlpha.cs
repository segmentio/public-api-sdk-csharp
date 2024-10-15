/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 55.1.0
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
    /// Represents an Edge Function bundle.
    /// </summary>
    [DataContract(Name = "EdgeFunctionsAlpha")]
    public partial class EdgeFunctionsAlpha : IEquatable<EdgeFunctionsAlpha>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeFunctionsAlpha" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdgeFunctionsAlpha() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeFunctionsAlpha" /> class.
        /// </summary>
        /// <param name="id">The Edge Function id. (required).</param>
        /// <param name="sourceId">The Source id. (required).</param>
        /// <param name="createdAt">Creation date. (required).</param>
        /// <param name="createdBy">Creating user&#39;s id. (required).</param>
        /// <param name="downloadURL">The CDN URL that can be used to fetch your latest EdgeFunctions bundle. (required).</param>
        /// <param name="varVersion">Revision number associated with the latest Edge Function. (required).</param>
        public EdgeFunctionsAlpha(string id = default(string), string sourceId = default(string), string createdAt = default(string), string createdBy = default(string), string downloadURL = default(string), decimal varVersion = default(decimal))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for EdgeFunctionsAlpha and cannot be null");
            }
            this.Id = id;
            // to ensure "sourceId" is required (not null)
            if (sourceId == null)
            {
                throw new ArgumentNullException("sourceId is a required property for EdgeFunctionsAlpha and cannot be null");
            }
            this.SourceId = sourceId;
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new ArgumentNullException("createdAt is a required property for EdgeFunctionsAlpha and cannot be null");
            }
            this.CreatedAt = createdAt;
            // to ensure "createdBy" is required (not null)
            if (createdBy == null)
            {
                throw new ArgumentNullException("createdBy is a required property for EdgeFunctionsAlpha and cannot be null");
            }
            this.CreatedBy = createdBy;
            // to ensure "downloadURL" is required (not null)
            if (downloadURL == null)
            {
                throw new ArgumentNullException("downloadURL is a required property for EdgeFunctionsAlpha and cannot be null");
            }
            this.DownloadURL = downloadURL;
            this.VarVersion = varVersion;
        }

        /// <summary>
        /// The Edge Function id.
        /// </summary>
        /// <value>The Edge Function id.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The Source id.
        /// </summary>
        /// <value>The Source id.</value>
        [DataMember(Name = "sourceId", IsRequired = true, EmitDefaultValue = true)]
        public string SourceId { get; set; }

        /// <summary>
        /// Creation date.
        /// </summary>
        /// <value>Creation date.</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Creating user&#39;s id.
        /// </summary>
        /// <value>Creating user&#39;s id.</value>
        [DataMember(Name = "createdBy", IsRequired = true, EmitDefaultValue = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// The CDN URL that can be used to fetch your latest EdgeFunctions bundle.
        /// </summary>
        /// <value>The CDN URL that can be used to fetch your latest EdgeFunctions bundle.</value>
        [DataMember(Name = "downloadURL", IsRequired = true, EmitDefaultValue = true)]
        public string DownloadURL { get; set; }

        /// <summary>
        /// Revision number associated with the latest Edge Function.
        /// </summary>
        /// <value>Revision number associated with the latest Edge Function.</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public decimal VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdgeFunctionsAlpha {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  DownloadURL: ").Append(DownloadURL).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
            return this.Equals(input as EdgeFunctionsAlpha);
        }

        /// <summary>
        /// Returns true if EdgeFunctionsAlpha instances are equal
        /// </summary>
        /// <param name="input">Instance of EdgeFunctionsAlpha to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeFunctionsAlpha input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.DownloadURL == input.DownloadURL ||
                    (this.DownloadURL != null &&
                    this.DownloadURL.Equals(input.DownloadURL))
                ) && 
                (
                    this.VarVersion == input.VarVersion ||
                    this.VarVersion.Equals(input.VarVersion)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.SourceId != null)
                {
                    hashCode = (hashCode * 59) + this.SourceId.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                if (this.DownloadURL != null)
                {
                    hashCode = (hashCode * 59) + this.DownloadURL.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VarVersion.GetHashCode();
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
