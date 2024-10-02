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
    /// DestinationStatus represents status of each Destination in a stream.
    /// </summary>
    [DataContract(Name = "DestinationStatusV1")]
    public partial class DestinationStatusV1 : IEquatable<DestinationStatusV1>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
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
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationStatusV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DestinationStatusV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationStatusV1" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="errString">errString (required).</param>
        /// <param name="finishedAt">finishedAt (required).</param>
        public DestinationStatusV1(string name = default(string), string id = default(string), StatusEnum status = default(StatusEnum), string errString = default(string), string finishedAt = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for DestinationStatusV1 and cannot be null");
            }
            this.Name = name;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for DestinationStatusV1 and cannot be null");
            }
            this.Id = id;
            this.Status = status;
            // to ensure "errString" is required (not null)
            if (errString == null)
            {
                throw new ArgumentNullException("errString is a required property for DestinationStatusV1 and cannot be null");
            }
            this.ErrString = errString;
            // to ensure "finishedAt" is required (not null)
            if (finishedAt == null)
            {
                throw new ArgumentNullException("finishedAt is a required property for DestinationStatusV1 and cannot be null");
            }
            this.FinishedAt = finishedAt;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ErrString
        /// </summary>
        [DataMember(Name = "errString", IsRequired = true, EmitDefaultValue = true)]
        public string ErrString { get; set; }

        /// <summary>
        /// Gets or Sets FinishedAt
        /// </summary>
        [DataMember(Name = "finishedAt", IsRequired = true, EmitDefaultValue = true)]
        public string FinishedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinationStatusV1 {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ErrString: ").Append(ErrString).Append("\n");
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
            return this.Equals(input as DestinationStatusV1);
        }

        /// <summary>
        /// Returns true if DestinationStatusV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinationStatusV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinationStatusV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.ErrString == input.ErrString ||
                    (this.ErrString != null &&
                    this.ErrString.Equals(input.ErrString))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.ErrString != null)
                {
                    hashCode = (hashCode * 59) + this.ErrString.GetHashCode();
                }
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
