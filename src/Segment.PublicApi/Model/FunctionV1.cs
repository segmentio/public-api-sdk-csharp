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
    /// Represents a Function.
    /// </summary>
    [DataContract(Name = "FunctionV1")]
    public partial class FunctionV1 : IEquatable<FunctionV1>, IValidatableObject
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
            /// Enum INSERTSOURCE for value: INSERT_SOURCE
            /// </summary>
            [EnumMember(Value = "INSERT_SOURCE")]
            INSERTSOURCE = 3,

            /// <summary>
            /// Enum SOURCE for value: SOURCE
            /// </summary>
            [EnumMember(Value = "SOURCE")]
            SOURCE = 4
        }


        /// <summary>
        /// The Function type.  Config API note: equal to &#x60;type&#x60;.
        /// </summary>
        /// <value>The Function type.  Config API note: equal to &#x60;type&#x60;.</value>
        [DataMember(Name = "resourceType", EmitDefaultValue = false)]
        public ResourceTypeEnum? ResourceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionV1" /> class.
        /// </summary>
        /// <param name="id">An identifier for this Function..</param>
        /// <param name="resourceType">The Function type.  Config API note: equal to &#x60;type&#x60;..</param>
        /// <param name="createdAt">The time this Function was created..</param>
        /// <param name="createdBy">The id of the user who created this Function..</param>
        /// <param name="code">The Function code..</param>
        /// <param name="deployedAt">The time of this Function&#39;s last deployment..</param>
        /// <param name="settings">The list of settings for this Function..</param>
        /// <param name="displayName">A display name for this Function..</param>
        /// <param name="description">A description for this Function..</param>
        /// <param name="logoUrl">The URL of the logo for this Function..</param>
        /// <param name="previewWebhookUrl">The preview webhook URL for this Function..</param>
        /// <param name="batchMaxCount">The max count of the batch for this Function..</param>
        /// <param name="catalogId">The catalog id of this Function..</param>
        /// <param name="isLatestVersion">Whether the deployment of this Function is the latest version..</param>
        public FunctionV1(string id = default(string), ResourceTypeEnum? resourceType = default(ResourceTypeEnum?), string createdAt = default(string), string createdBy = default(string), string code = default(string), string deployedAt = default(string), List<FunctionSettingV1> settings = default(List<FunctionSettingV1>), string displayName = default(string), string description = default(string), string logoUrl = default(string), string previewWebhookUrl = default(string), decimal batchMaxCount = default(decimal), string catalogId = default(string), bool isLatestVersion = default(bool))
        {
            this.Id = id;
            this.ResourceType = resourceType;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Code = code;
            this.DeployedAt = deployedAt;
            this.Settings = settings;
            this.DisplayName = displayName;
            this.Description = description;
            this.LogoUrl = logoUrl;
            this.PreviewWebhookUrl = previewWebhookUrl;
            this.BatchMaxCount = batchMaxCount;
            this.CatalogId = catalogId;
            this.IsLatestVersion = isLatestVersion;
        }

        /// <summary>
        /// An identifier for this Function.
        /// </summary>
        /// <value>An identifier for this Function.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The time this Function was created.
        /// </summary>
        /// <value>The time this Function was created.</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// The id of the user who created this Function.
        /// </summary>
        /// <value>The id of the user who created this Function.</value>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// The Function code.
        /// </summary>
        /// <value>The Function code.</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// The time of this Function&#39;s last deployment.
        /// </summary>
        /// <value>The time of this Function&#39;s last deployment.</value>
        [DataMember(Name = "deployedAt", EmitDefaultValue = true)]
        public string DeployedAt { get; set; }

        /// <summary>
        /// The list of settings for this Function.
        /// </summary>
        /// <value>The list of settings for this Function.</value>
        [DataMember(Name = "settings", EmitDefaultValue = false)]
        public List<FunctionSettingV1> Settings { get; set; }

        /// <summary>
        /// A display name for this Function.
        /// </summary>
        /// <value>A display name for this Function.</value>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// A description for this Function.
        /// </summary>
        /// <value>A description for this Function.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The URL of the logo for this Function.
        /// </summary>
        /// <value>The URL of the logo for this Function.</value>
        [DataMember(Name = "logoUrl", EmitDefaultValue = false)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// The preview webhook URL for this Function.
        /// </summary>
        /// <value>The preview webhook URL for this Function.</value>
        [DataMember(Name = "previewWebhookUrl", EmitDefaultValue = false)]
        public string PreviewWebhookUrl { get; set; }

        /// <summary>
        /// The max count of the batch for this Function.
        /// </summary>
        /// <value>The max count of the batch for this Function.</value>
        [DataMember(Name = "batchMaxCount", EmitDefaultValue = false)]
        public decimal BatchMaxCount { get; set; }

        /// <summary>
        /// The catalog id of this Function.
        /// </summary>
        /// <value>The catalog id of this Function.</value>
        [DataMember(Name = "catalogId", EmitDefaultValue = false)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Whether the deployment of this Function is the latest version.
        /// </summary>
        /// <value>Whether the deployment of this Function is the latest version.</value>
        [DataMember(Name = "isLatestVersion", EmitDefaultValue = true)]
        public bool IsLatestVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FunctionV1 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  DeployedAt: ").Append(DeployedAt).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
            sb.Append("  PreviewWebhookUrl: ").Append(PreviewWebhookUrl).Append("\n");
            sb.Append("  BatchMaxCount: ").Append(BatchMaxCount).Append("\n");
            sb.Append("  CatalogId: ").Append(CatalogId).Append("\n");
            sb.Append("  IsLatestVersion: ").Append(IsLatestVersion).Append("\n");
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
            return this.Equals(input as FunctionV1);
        }

        /// <summary>
        /// Returns true if FunctionV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of FunctionV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FunctionV1 input)
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
                    this.ResourceType == input.ResourceType ||
                    this.ResourceType.Equals(input.ResourceType)
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
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.DeployedAt == input.DeployedAt ||
                    (this.DeployedAt != null &&
                    this.DeployedAt.Equals(input.DeployedAt))
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.LogoUrl == input.LogoUrl ||
                    (this.LogoUrl != null &&
                    this.LogoUrl.Equals(input.LogoUrl))
                ) && 
                (
                    this.PreviewWebhookUrl == input.PreviewWebhookUrl ||
                    (this.PreviewWebhookUrl != null &&
                    this.PreviewWebhookUrl.Equals(input.PreviewWebhookUrl))
                ) && 
                (
                    this.BatchMaxCount == input.BatchMaxCount ||
                    this.BatchMaxCount.Equals(input.BatchMaxCount)
                ) && 
                (
                    this.CatalogId == input.CatalogId ||
                    (this.CatalogId != null &&
                    this.CatalogId.Equals(input.CatalogId))
                ) && 
                (
                    this.IsLatestVersion == input.IsLatestVersion ||
                    this.IsLatestVersion.Equals(input.IsLatestVersion)
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
                hashCode = (hashCode * 59) + this.ResourceType.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.DeployedAt != null)
                {
                    hashCode = (hashCode * 59) + this.DeployedAt.GetHashCode();
                }
                if (this.Settings != null)
                {
                    hashCode = (hashCode * 59) + this.Settings.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.LogoUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LogoUrl.GetHashCode();
                }
                if (this.PreviewWebhookUrl != null)
                {
                    hashCode = (hashCode * 59) + this.PreviewWebhookUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BatchMaxCount.GetHashCode();
                if (this.CatalogId != null)
                {
                    hashCode = (hashCode * 59) + this.CatalogId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsLatestVersion.GetHashCode();
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
