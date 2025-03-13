/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.0.0
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
    /// The input for a permission, associated with a resource and/or labels.
    /// </summary>
    [DataContract(Name = "PermissionInputV1")]
    public partial class PermissionInputV1 : IEquatable<PermissionInputV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionInputV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PermissionInputV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionInputV1" /> class.
        /// </summary>
        /// <param name="roleId">The role id of this permission. (required).</param>
        /// <param name="resources">The resources to link the selected role to. (required).</param>
        public PermissionInputV1(string roleId = default(string), List<PermissionResourceV1> resources = default(List<PermissionResourceV1>))
        {
            // to ensure "roleId" is required (not null)
            if (roleId == null)
            {
                throw new ArgumentNullException("roleId is a required property for PermissionInputV1 and cannot be null");
            }
            this.RoleId = roleId;
            // to ensure "resources" is required (not null)
            if (resources == null)
            {
                throw new ArgumentNullException("resources is a required property for PermissionInputV1 and cannot be null");
            }
            this.Resources = resources;
        }

        /// <summary>
        /// The role id of this permission.
        /// </summary>
        /// <value>The role id of this permission.</value>
        [DataMember(Name = "roleId", IsRequired = true, EmitDefaultValue = true)]
        public string RoleId { get; set; }

        /// <summary>
        /// The resources to link the selected role to.
        /// </summary>
        /// <value>The resources to link the selected role to.</value>
        [DataMember(Name = "resources", IsRequired = true, EmitDefaultValue = true)]
        public List<PermissionResourceV1> Resources { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PermissionInputV1 {\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
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
            return this.Equals(input as PermissionInputV1);
        }

        /// <summary>
        /// Returns true if PermissionInputV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of PermissionInputV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PermissionInputV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RoleId == input.RoleId ||
                    (this.RoleId != null &&
                    this.RoleId.Equals(input.RoleId))
                ) && 
                (
                    this.Resources == input.Resources ||
                    this.Resources != null &&
                    input.Resources != null &&
                    this.Resources.SequenceEqual(input.Resources)
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
                if (this.RoleId != null)
                {
                    hashCode = (hashCode * 59) + this.RoleId.GetHashCode();
                }
                if (this.Resources != null)
                {
                    hashCode = (hashCode * 59) + this.Resources.GetHashCode();
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
