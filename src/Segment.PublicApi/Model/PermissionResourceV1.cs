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
    /// The most basic representation of a resource belonging to a set of permissions.
    /// </summary>
    [DataContract(Name = "PermissionResourceV1")]
    public partial class PermissionResourceV1 : IEquatable<PermissionResourceV1>, IValidatableObject
    {
        /// <summary>
        /// The type for this resource.
        /// </summary>
        /// <value>The type for this resource.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum FUNCTION for value: FUNCTION
            /// </summary>
            [EnumMember(Value = "FUNCTION")]
            FUNCTION = 1,

            /// <summary>
            /// Enum SOURCE for value: SOURCE
            /// </summary>
            [EnumMember(Value = "SOURCE")]
            SOURCE = 2,

            /// <summary>
            /// Enum SPACE for value: SPACE
            /// </summary>
            [EnumMember(Value = "SPACE")]
            SPACE = 3,

            /// <summary>
            /// Enum WAREHOUSE for value: WAREHOUSE
            /// </summary>
            [EnumMember(Value = "WAREHOUSE")]
            WAREHOUSE = 4,

            /// <summary>
            /// Enum WORKSPACE for value: WORKSPACE
            /// </summary>
            [EnumMember(Value = "WORKSPACE")]
            WORKSPACE = 5
        }


        /// <summary>
        /// The type for this resource.
        /// </summary>
        /// <value>The type for this resource.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionResourceV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PermissionResourceV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionResourceV1" /> class.
        /// </summary>
        /// <param name="id">The id of this resource. (required).</param>
        /// <param name="type">The type for this resource. (required).</param>
        /// <param name="labels">The labels that further refine access to this resource. Labels are exclusive to Workspace-level permissions..</param>
        public PermissionResourceV1(string id = default(string), TypeEnum type = default(TypeEnum), List<AllowedLabelBeta> labels = default(List<AllowedLabelBeta>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for PermissionResourceV1 and cannot be null");
            }
            this.Id = id;
            this.Type = type;
            this.Labels = labels;
        }

        /// <summary>
        /// The id of this resource.
        /// </summary>
        /// <value>The id of this resource.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The labels that further refine access to this resource. Labels are exclusive to Workspace-level permissions.
        /// </summary>
        /// <value>The labels that further refine access to this resource. Labels are exclusive to Workspace-level permissions.</value>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public List<AllowedLabelBeta> Labels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PermissionResourceV1 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
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
            return this.Equals(input as PermissionResourceV1);
        }

        /// <summary>
        /// Returns true if PermissionResourceV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of PermissionResourceV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PermissionResourceV1 input)
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
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    input.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Labels != null)
                {
                    hashCode = (hashCode * 59) + this.Labels.GetHashCode();
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
