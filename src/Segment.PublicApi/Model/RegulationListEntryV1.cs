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
    /// RegulationListEntryV1
    /// </summary>
    [DataContract(Name = "RegulationListEntryV1")]
    public partial class RegulationListEntryV1 : IEquatable<RegulationListEntryV1>, IValidatableObject
    {
        /// <summary>
        /// The current status of the regulate request.
        /// </summary>
        /// <value>The current status of the regulate request.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED = 1,

            /// <summary>
            /// Enum FINISHED for value: FINISHED
            /// </summary>
            [EnumMember(Value = "FINISHED")]
            FINISHED = 2,

            /// <summary>
            /// Enum INITIALIZED for value: INITIALIZED
            /// </summary>
            [EnumMember(Value = "INITIALIZED")]
            INITIALIZED = 3,

            /// <summary>
            /// Enum INVALID for value: INVALID
            /// </summary>
            [EnumMember(Value = "INVALID")]
            INVALID = 4,

            /// <summary>
            /// Enum NOTSUPPORTED for value: NOT_SUPPORTED
            /// </summary>
            [EnumMember(Value = "NOT_SUPPORTED")]
            NOTSUPPORTED = 5,

            /// <summary>
            /// Enum PARTIALSUCCESS for value: PARTIAL_SUCCESS
            /// </summary>
            [EnumMember(Value = "PARTIAL_SUCCESS")]
            PARTIALSUCCESS = 6,

            /// <summary>
            /// Enum RUNNING for value: RUNNING
            /// </summary>
            [EnumMember(Value = "RUNNING")]
            RUNNING = 7
        }


        /// <summary>
        /// The current status of the regulate request.
        /// </summary>
        /// <value>The current status of the regulate request.</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// The regulation type.
        /// </summary>
        /// <value>The regulation type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RegulationTypeEnum
        {
            /// <summary>
            /// Enum DELETEINTERNAL for value: DELETE_INTERNAL
            /// </summary>
            [EnumMember(Value = "DELETE_INTERNAL")]
            DELETEINTERNAL = 1,

            /// <summary>
            /// Enum DELETEONLY for value: DELETE_ONLY
            /// </summary>
            [EnumMember(Value = "DELETE_ONLY")]
            DELETEONLY = 2,

            /// <summary>
            /// Enum SUPPRESSONLY for value: SUPPRESS_ONLY
            /// </summary>
            [EnumMember(Value = "SUPPRESS_ONLY")]
            SUPPRESSONLY = 3,

            /// <summary>
            /// Enum SUPPRESSWITHDELETE for value: SUPPRESS_WITH_DELETE
            /// </summary>
            [EnumMember(Value = "SUPPRESS_WITH_DELETE")]
            SUPPRESSWITHDELETE = 4,

            /// <summary>
            /// Enum SUPPRESSWITHDELETEINTERNAL for value: SUPPRESS_WITH_DELETE_INTERNAL
            /// </summary>
            [EnumMember(Value = "SUPPRESS_WITH_DELETE_INTERNAL")]
            SUPPRESSWITHDELETEINTERNAL = 5,

            /// <summary>
            /// Enum UNSUPPRESS for value: UNSUPPRESS
            /// </summary>
            [EnumMember(Value = "UNSUPPRESS")]
            UNSUPPRESS = 6
        }


        /// <summary>
        /// The regulation type.
        /// </summary>
        /// <value>The regulation type.</value>
        [DataMember(Name = "regulationType", IsRequired = true, EmitDefaultValue = true)]
        public RegulationTypeEnum RegulationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegulationListEntryV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RegulationListEntryV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegulationListEntryV1" /> class.
        /// </summary>
        /// <param name="id">The id of the regulate request. (required).</param>
        /// <param name="subjectType">The subject type. (required).</param>
        /// <param name="subjects">The list of &#x60;userId&#x60; or &#x60;objectId&#x60; values of the subjects to regulate. (required).</param>
        /// <param name="status">The current status of the regulate request. (required).</param>
        /// <param name="createdAt">The timestamp of the creation of the request. (required).</param>
        /// <param name="regulationType">The regulation type. (required).</param>
        /// <param name="finishedAt">The timestamp of when the request finished..</param>
        public RegulationListEntryV1(string id = default(string), string subjectType = default(string), List<string> subjects = default(List<string>), StatusEnum status = default(StatusEnum), string createdAt = default(string), RegulationTypeEnum regulationType = default(RegulationTypeEnum), string finishedAt = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for RegulationListEntryV1 and cannot be null");
            }
            this.Id = id;
            // to ensure "subjectType" is required (not null)
            if (subjectType == null)
            {
                throw new ArgumentNullException("subjectType is a required property for RegulationListEntryV1 and cannot be null");
            }
            this.SubjectType = subjectType;
            // to ensure "subjects" is required (not null)
            if (subjects == null)
            {
                throw new ArgumentNullException("subjects is a required property for RegulationListEntryV1 and cannot be null");
            }
            this.Subjects = subjects;
            this.Status = status;
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new ArgumentNullException("createdAt is a required property for RegulationListEntryV1 and cannot be null");
            }
            this.CreatedAt = createdAt;
            this.RegulationType = regulationType;
            this.FinishedAt = finishedAt;
        }

        /// <summary>
        /// The id of the regulate request.
        /// </summary>
        /// <value>The id of the regulate request.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The subject type.
        /// </summary>
        /// <value>The subject type.</value>
        [DataMember(Name = "subjectType", IsRequired = true, EmitDefaultValue = true)]
        public string SubjectType { get; set; }

        /// <summary>
        /// The list of &#x60;userId&#x60; or &#x60;objectId&#x60; values of the subjects to regulate.
        /// </summary>
        /// <value>The list of &#x60;userId&#x60; or &#x60;objectId&#x60; values of the subjects to regulate.</value>
        [DataMember(Name = "subjects", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Subjects { get; set; }

        /// <summary>
        /// The timestamp of the creation of the request.
        /// </summary>
        /// <value>The timestamp of the creation of the request.</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// The timestamp of when the request finished.
        /// </summary>
        /// <value>The timestamp of when the request finished.</value>
        [DataMember(Name = "finishedAt", EmitDefaultValue = false)]
        public string FinishedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RegulationListEntryV1 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SubjectType: ").Append(SubjectType).Append("\n");
            sb.Append("  Subjects: ").Append(Subjects).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  RegulationType: ").Append(RegulationType).Append("\n");
            sb.Append("  FinishedAt: ").Append(FinishedAt).Append("\n");
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
            return this.Equals(input as RegulationListEntryV1);
        }

        /// <summary>
        /// Returns true if RegulationListEntryV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of RegulationListEntryV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegulationListEntryV1 input)
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
                    this.SubjectType == input.SubjectType ||
                    (this.SubjectType != null &&
                    this.SubjectType.Equals(input.SubjectType))
                ) && 
                (
                    this.Subjects == input.Subjects ||
                    this.Subjects != null &&
                    input.Subjects != null &&
                    this.Subjects.SequenceEqual(input.Subjects)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.RegulationType == input.RegulationType ||
                    this.RegulationType.Equals(input.RegulationType)
                ) && 
                (
                    this.FinishedAt == input.FinishedAt ||
                    (this.FinishedAt != null &&
                    this.FinishedAt.Equals(input.FinishedAt))
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
                if (this.SubjectType != null)
                {
                    hashCode = (hashCode * 59) + this.SubjectType.GetHashCode();
                }
                if (this.Subjects != null)
                {
                    hashCode = (hashCode * 59) + this.Subjects.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RegulationType.GetHashCode();
                if (this.FinishedAt != null)
                {
                    hashCode = (hashCode * 59) + this.FinishedAt.GetHashCode();
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
