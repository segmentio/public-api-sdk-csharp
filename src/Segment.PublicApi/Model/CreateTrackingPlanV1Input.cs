/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.2.0
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
    /// Creates a Tracking Plan in the Workspace.
    /// </summary>
    [DataContract(Name = "CreateTrackingPlanV1Input")]
    public partial class CreateTrackingPlanV1Input : IEquatable<CreateTrackingPlanV1Input>, IValidatableObject
    {
        /// <summary>
        /// The Tracking Plan&#39;s type.
        /// </summary>
        /// <value>The Tracking Plan&#39;s type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum ENGAGE for value: ENGAGE
            /// </summary>
            [EnumMember(Value = "ENGAGE")]
            ENGAGE = 1,

            /// <summary>
            /// Enum LIVE for value: LIVE
            /// </summary>
            [EnumMember(Value = "LIVE")]
            LIVE = 2,

            /// <summary>
            /// Enum PROPERTYLIBRARY for value: PROPERTY_LIBRARY
            /// </summary>
            [EnumMember(Value = "PROPERTY_LIBRARY")]
            PROPERTYLIBRARY = 3,

            /// <summary>
            /// Enum RULELIBRARY for value: RULE_LIBRARY
            /// </summary>
            [EnumMember(Value = "RULE_LIBRARY")]
            RULELIBRARY = 4,

            /// <summary>
            /// Enum TEMPLATE for value: TEMPLATE
            /// </summary>
            [EnumMember(Value = "TEMPLATE")]
            TEMPLATE = 5
        }


        /// <summary>
        /// The Tracking Plan&#39;s type.
        /// </summary>
        /// <value>The Tracking Plan&#39;s type.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrackingPlanV1Input" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTrackingPlanV1Input() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrackingPlanV1Input" /> class.
        /// </summary>
        /// <param name="name">The Tracking Plan&#39;s name.  Config API note: equal to &#x60;displayName&#x60;. (required).</param>
        /// <param name="description">The Tracking Plan&#39;s description..</param>
        /// <param name="type">The Tracking Plan&#39;s type. (required).</param>
        public CreateTrackingPlanV1Input(string name = default(string), string description = default(string), TypeEnum type = default(TypeEnum))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateTrackingPlanV1Input and cannot be null");
            }
            this.Name = name;
            this.Type = type;
            this.Description = description;
        }

        /// <summary>
        /// The Tracking Plan&#39;s name.  Config API note: equal to &#x60;displayName&#x60;.
        /// </summary>
        /// <value>The Tracking Plan&#39;s name.  Config API note: equal to &#x60;displayName&#x60;.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The Tracking Plan&#39;s description.
        /// </summary>
        /// <value>The Tracking Plan&#39;s description.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateTrackingPlanV1Input {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as CreateTrackingPlanV1Input);
        }

        /// <summary>
        /// Returns true if CreateTrackingPlanV1Input instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTrackingPlanV1Input to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTrackingPlanV1Input input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
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
