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
    /// Represents a Function Version in a list.
    /// </summary>
    [DataContract(Name = "varVersion")]
    public partial class ModelVersion : IEquatable<ModelVersion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelVersion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModelVersion() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelVersion" /> class.
        /// </summary>
        /// <param name="id">An identifier for this version. (required).</param>
        /// <param name="author">Author of this version..</param>
        /// <param name="code">Source code of this version. (required).</param>
        /// <param name="isDeployed">The deployed status of this version..</param>
        /// <param name="createdAt">The time of this Version&#39;s creation..</param>
        /// <param name="updatedAt">The time of this Version&#39;s latest update..</param>
        /// <param name="deployedAt">The time of this Version&#39;s last deployment..</param>
        public ModelVersion(string id = default(string), string author = default(string), string code = default(string), bool isDeployed = default(bool), string createdAt = default(string), string updatedAt = default(string), string deployedAt = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for ModelVersion and cannot be null");
            }
            this.Id = id;
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for ModelVersion and cannot be null");
            }
            this.Code = code;
            this.Author = author;
            this.IsDeployed = isDeployed;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DeployedAt = deployedAt;
        }

        /// <summary>
        /// An identifier for this version.
        /// </summary>
        /// <value>An identifier for this version.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Author of this version.
        /// </summary>
        /// <value>Author of this version.</value>
        [DataMember(Name = "author", EmitDefaultValue = false)]
        public string Author { get; set; }

        /// <summary>
        /// Source code of this version.
        /// </summary>
        /// <value>Source code of this version.</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// The deployed status of this version.
        /// </summary>
        /// <value>The deployed status of this version.</value>
        [DataMember(Name = "isDeployed", EmitDefaultValue = true)]
        public bool IsDeployed { get; set; }

        /// <summary>
        /// The time of this Version&#39;s creation.
        /// </summary>
        /// <value>The time of this Version&#39;s creation.</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// The time of this Version&#39;s latest update.
        /// </summary>
        /// <value>The time of this Version&#39;s latest update.</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// The time of this Version&#39;s last deployment.
        /// </summary>
        /// <value>The time of this Version&#39;s last deployment.</value>
        [DataMember(Name = "deployedAt", EmitDefaultValue = false)]
        public string DeployedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ModelVersion {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  IsDeployed: ").Append(IsDeployed).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  DeployedAt: ").Append(DeployedAt).Append("\n");
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
            return this.Equals(input as ModelVersion);
        }

        /// <summary>
        /// Returns true if ModelVersion instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelVersion input)
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
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.IsDeployed == input.IsDeployed ||
                    this.IsDeployed.Equals(input.IsDeployed)
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
                    this.DeployedAt == input.DeployedAt ||
                    (this.DeployedAt != null &&
                    this.DeployedAt.Equals(input.DeployedAt))
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
                if (this.Author != null)
                {
                    hashCode = (hashCode * 59) + this.Author.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsDeployed.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.DeployedAt != null)
                {
                    hashCode = (hashCode * 59) + this.DeployedAt.GetHashCode();
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
