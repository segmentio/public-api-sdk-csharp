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
    /// The input to create a Workspace regulation.
    /// </summary>
    [DataContract(Name = "CreateWorkspaceRegulationV1Input")]
    public partial class CreateWorkspaceRegulationV1Input : IEquatable<CreateWorkspaceRegulationV1Input>, IValidatableObject
    {
        /// <summary>
        /// The regulation type to create.
        /// </summary>
        /// <value>The regulation type to create.</value>
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
        /// The regulation type to create.
        /// </summary>
        /// <value>The regulation type to create.</value>
        [DataMember(Name = "regulationType", IsRequired = true, EmitDefaultValue = true)]
        public RegulationTypeEnum RegulationType { get; set; }
        /// <summary>
        /// The subject type. Use &#x60;objectId&#x60; for Cloud Source regulations.
        /// </summary>
        /// <value>The subject type. Use &#x60;objectId&#x60; for Cloud Source regulations.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SubjectTypeEnum
        {
            /// <summary>
            /// Enum OBJECTID for value: OBJECT_ID
            /// </summary>
            [EnumMember(Value = "OBJECT_ID")]
            OBJECTID = 1,

            /// <summary>
            /// Enum USERID for value: USER_ID
            /// </summary>
            [EnumMember(Value = "USER_ID")]
            USERID = 2
        }


        /// <summary>
        /// The subject type. Use &#x60;objectId&#x60; for Cloud Source regulations.
        /// </summary>
        /// <value>The subject type. Use &#x60;objectId&#x60; for Cloud Source regulations.</value>
        [DataMember(Name = "subjectType", IsRequired = true, EmitDefaultValue = true)]
        public SubjectTypeEnum SubjectType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkspaceRegulationV1Input" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateWorkspaceRegulationV1Input() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkspaceRegulationV1Input" /> class.
        /// </summary>
        /// <param name="regulationType">The regulation type to create. (required).</param>
        /// <param name="subjectType">The subject type. Use &#x60;objectId&#x60; for Cloud Source regulations. (required).</param>
        /// <param name="subjectIds">The list of &#x60;userId&#x60; or &#x60;objectId&#x60; values of the subjects to regulate.  Config API note: equal to &#x60;parent&#x60; but allows an array. (required).</param>
        public CreateWorkspaceRegulationV1Input(RegulationTypeEnum regulationType = default(RegulationTypeEnum), SubjectTypeEnum subjectType = default(SubjectTypeEnum), List<string> subjectIds = default(List<string>))
        {
            this.RegulationType = regulationType;
            this.SubjectType = subjectType;
            // to ensure "subjectIds" is required (not null)
            if (subjectIds == null)
            {
                throw new ArgumentNullException("subjectIds is a required property for CreateWorkspaceRegulationV1Input and cannot be null");
            }
            this.SubjectIds = subjectIds;
        }

        /// <summary>
        /// The list of &#x60;userId&#x60; or &#x60;objectId&#x60; values of the subjects to regulate.  Config API note: equal to &#x60;parent&#x60; but allows an array.
        /// </summary>
        /// <value>The list of &#x60;userId&#x60; or &#x60;objectId&#x60; values of the subjects to regulate.  Config API note: equal to &#x60;parent&#x60; but allows an array.</value>
        [DataMember(Name = "subjectIds", IsRequired = true, EmitDefaultValue = true)]
        public List<string> SubjectIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateWorkspaceRegulationV1Input {\n");
            sb.Append("  RegulationType: ").Append(RegulationType).Append("\n");
            sb.Append("  SubjectType: ").Append(SubjectType).Append("\n");
            sb.Append("  SubjectIds: ").Append(SubjectIds).Append("\n");
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
            return this.Equals(input as CreateWorkspaceRegulationV1Input);
        }

        /// <summary>
        /// Returns true if CreateWorkspaceRegulationV1Input instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateWorkspaceRegulationV1Input to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateWorkspaceRegulationV1Input input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RegulationType == input.RegulationType ||
                    this.RegulationType.Equals(input.RegulationType)
                ) && 
                (
                    this.SubjectType == input.SubjectType ||
                    this.SubjectType.Equals(input.SubjectType)
                ) && 
                (
                    this.SubjectIds == input.SubjectIds ||
                    this.SubjectIds != null &&
                    input.SubjectIds != null &&
                    this.SubjectIds.SequenceEqual(input.SubjectIds)
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
                hashCode = (hashCode * 59) + this.RegulationType.GetHashCode();
                hashCode = (hashCode * 59) + this.SubjectType.GetHashCode();
                if (this.SubjectIds != null)
                {
                    hashCode = (hashCode * 59) + this.SubjectIds.GetHashCode();
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
