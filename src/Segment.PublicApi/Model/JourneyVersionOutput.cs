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
    /// JourneyVersionOutput
    /// </summary>
    [DataContract(Name = "JourneyVersionOutput")]
    public partial class JourneyVersionOutput : IEquatable<JourneyVersionOutput>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum ARCHIVED for value: ARCHIVED
            /// </summary>
            [EnumMember(Value = "ARCHIVED")]
            ARCHIVED = 1,

            /// <summary>
            /// Enum DRAFT for value: DRAFT
            /// </summary>
            [EnumMember(Value = "DRAFT")]
            DRAFT = 2,

            /// <summary>
            /// Enum ENTRYPAUSED for value: ENTRY_PAUSED
            /// </summary>
            [EnumMember(Value = "ENTRY_PAUSED")]
            ENTRYPAUSED = 3,

            /// <summary>
            /// Enum PUBLISHED for value: PUBLISHED
            /// </summary>
            [EnumMember(Value = "PUBLISHED")]
            PUBLISHED = 4
        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyVersionOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JourneyVersionOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyVersionOutput" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="varVersion">varVersion (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="definition">definition (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="createdBy">createdBy (required).</param>
        /// <param name="updatedBy">updatedBy.</param>
        public JourneyVersionOutput(string id = default(string), decimal varVersion = default(decimal), StatusEnum status = default(StatusEnum), JourneyDefinition definition = default(JourneyDefinition), string createdAt = default(string), string updatedAt = default(string), string createdBy = default(string), string updatedBy = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for JourneyVersionOutput and cannot be null");
            }
            this.Id = id;
            this.VarVersion = varVersion;
            this.Status = status;
            // to ensure "definition" is required (not null)
            if (definition == null)
            {
                throw new ArgumentNullException("definition is a required property for JourneyVersionOutput and cannot be null");
            }
            this.Definition = definition;
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new ArgumentNullException("createdAt is a required property for JourneyVersionOutput and cannot be null");
            }
            this.CreatedAt = createdAt;
            // to ensure "createdBy" is required (not null)
            if (createdBy == null)
            {
                throw new ArgumentNullException("createdBy is a required property for JourneyVersionOutput and cannot be null");
            }
            this.CreatedBy = createdBy;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public decimal VarVersion { get; set; }

        /// <summary>
        /// Gets or Sets Definition
        /// </summary>
        [DataMember(Name = "definition", IsRequired = true, EmitDefaultValue = true)]
        public JourneyDefinition Definition { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "createdBy", IsRequired = true, EmitDefaultValue = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedBy
        /// </summary>
        [DataMember(Name = "updatedBy", EmitDefaultValue = false)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JourneyVersionOutput {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Definition: ").Append(Definition).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
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
            return this.Equals(input as JourneyVersionOutput);
        }

        /// <summary>
        /// Returns true if JourneyVersionOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of JourneyVersionOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyVersionOutput input)
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
                    this.VarVersion == input.VarVersion ||
                    this.VarVersion.Equals(input.VarVersion)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Definition == input.Definition ||
                    (this.Definition != null &&
                    this.Definition.Equals(input.Definition))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    (this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(input.UpdatedBy))
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
                hashCode = (hashCode * 59) + this.VarVersion.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Definition != null)
                {
                    hashCode = (hashCode * 59) + this.Definition.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                if (this.UpdatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedBy.GetHashCode();
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
