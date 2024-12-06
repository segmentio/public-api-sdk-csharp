/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 57.1.0
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
    /// Represents a permission&#39;s resource.
    /// </summary>
    [DataContract(Name = "ResourceV1")]
    public partial class ResourceV1 : IEquatable<ResourceV1>, IValidatableObject
    {
        /// <summary>
        /// The kind of resource this permission applies to.
        /// </summary>
        /// <value>The kind of resource this permission applies to.</value>
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
        /// The kind of resource this permission applies to.
        /// </summary>
        /// <value>The kind of resource this permission applies to.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResourceV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceV1" /> class.
        /// </summary>
        /// <param name="id">The id of this resource. (required).</param>
        /// <param name="type">The kind of resource this permission applies to. (required).</param>
        public ResourceV1(string id = default(string), TypeEnum type = default(TypeEnum))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for ResourceV1 and cannot be null");
            }
            this.Id = id;
            this.Type = type;
        }

        /// <summary>
        /// The id of this resource.
        /// </summary>
        /// <value>The id of this resource.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResourceV1 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ResourceV1);
        }

        /// <summary>
        /// Returns true if ResourceV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourceV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceV1 input)
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
