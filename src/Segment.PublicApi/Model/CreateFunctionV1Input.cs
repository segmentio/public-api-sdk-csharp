/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 54.2.0
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
    /// Creates a Function.
    /// </summary>
    [DataContract(Name = "CreateFunctionV1Input")]
    public partial class CreateFunctionV1Input : IEquatable<CreateFunctionV1Input>, IValidatableObject
    {
        /// <summary>
        /// The Function type.  Config API note: equal to &#x60;type&#x60;.
        /// </summary>
        /// <value>The Function type.  Config API note: equal to &#x60;type&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResourceTypeEnum
        {
            /// <summary>
            /// Enum DESTINATION for value: DESTINATION
            /// </summary>
            [EnumMember(Value = "DESTINATION")]
            DESTINATION = 1,

            /// <summary>
            /// Enum INSERTDESTINATION for value: INSERT_DESTINATION
            /// </summary>
            [EnumMember(Value = "INSERT_DESTINATION")]
            INSERTDESTINATION = 2,

            /// <summary>
            /// Enum SOURCE for value: SOURCE
            /// </summary>
            [EnumMember(Value = "SOURCE")]
            SOURCE = 3
        }


        /// <summary>
        /// The Function type.  Config API note: equal to &#x60;type&#x60;.
        /// </summary>
        /// <value>The Function type.  Config API note: equal to &#x60;type&#x60;.</value>
        [DataMember(Name = "resourceType", IsRequired = true, EmitDefaultValue = true)]
        public ResourceTypeEnum ResourceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFunctionV1Input" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateFunctionV1Input() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFunctionV1Input" /> class.
        /// </summary>
        /// <param name="code">The Function code. (required).</param>
        /// <param name="settings">The list of settings for this Function..</param>
        /// <param name="displayName">A display name for this Function.  Note that Destination Functions append the Workspace to the display name. (required).</param>
        /// <param name="logoUrl">The URL of the logo for this Function..</param>
        /// <param name="resourceType">The Function type.  Config API note: equal to &#x60;type&#x60;. (required).</param>
        /// <param name="description">A description for this Function..</param>
        public CreateFunctionV1Input(string code = default(string), List<FunctionSettingV1> settings = default(List<FunctionSettingV1>), string displayName = default(string), string logoUrl = default(string), ResourceTypeEnum resourceType = default(ResourceTypeEnum), string description = default(string))
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for CreateFunctionV1Input and cannot be null");
            }
            this.Code = code;
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new ArgumentNullException("displayName is a required property for CreateFunctionV1Input and cannot be null");
            }
            this.DisplayName = displayName;
            this.ResourceType = resourceType;
            this.Settings = settings;
            this.LogoUrl = logoUrl;
            this.Description = description;
        }

        /// <summary>
        /// The Function code.
        /// </summary>
        /// <value>The Function code.</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// The list of settings for this Function.
        /// </summary>
        /// <value>The list of settings for this Function.</value>
        [DataMember(Name = "settings", EmitDefaultValue = false)]
        public List<FunctionSettingV1> Settings { get; set; }

        /// <summary>
        /// A display name for this Function.  Note that Destination Functions append the Workspace to the display name.
        /// </summary>
        /// <value>A display name for this Function.  Note that Destination Functions append the Workspace to the display name.</value>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The URL of the logo for this Function.
        /// </summary>
        /// <value>The URL of the logo for this Function.</value>
        [DataMember(Name = "logoUrl", EmitDefaultValue = false)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// A description for this Function.
        /// </summary>
        /// <value>A description for this Function.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateFunctionV1Input {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as CreateFunctionV1Input);
        }

        /// <summary>
        /// Returns true if CreateFunctionV1Input instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateFunctionV1Input to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateFunctionV1Input input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Settings == input.Settings ||
                    this.Settings != null &&
                    input.Settings != null &&
                    this.Settings.SequenceEqual(input.Settings)
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.LogoUrl == input.LogoUrl ||
                    (this.LogoUrl != null &&
                    this.LogoUrl.Equals(input.LogoUrl))
                ) && 
                (
                    this.ResourceType == input.ResourceType ||
                    this.ResourceType.Equals(input.ResourceType)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Settings != null)
                {
                    hashCode = (hashCode * 59) + this.Settings.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.LogoUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LogoUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ResourceType.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
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
