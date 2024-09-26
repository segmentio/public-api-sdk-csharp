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
    /// A permission governing access to a resource.
    /// </summary>
    [DataContract(Name = "AccessPermissionV1")]
    public partial class AccessPermissionV1 : IEquatable<AccessPermissionV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPermissionV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccessPermissionV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPermissionV1" /> class.
        /// </summary>
        /// <param name="roleId">The id of the role that applies to this permission. (required).</param>
        /// <param name="roleName">The name of the role that applies to this permission. (required).</param>
        /// <param name="resources">The resources included with this permission. (required).</param>
        public AccessPermissionV1(string roleId = default(string), string roleName = default(string), List<PermissionResourceV1> resources = default(List<PermissionResourceV1>))
        {
            // to ensure "roleId" is required (not null)
            if (roleId == null)
            {
                throw new ArgumentNullException("roleId is a required property for AccessPermissionV1 and cannot be null");
            }
            this.RoleId = roleId;
            // to ensure "roleName" is required (not null)
            if (roleName == null)
            {
                throw new ArgumentNullException("roleName is a required property for AccessPermissionV1 and cannot be null");
            }
            this.RoleName = roleName;
            // to ensure "resources" is required (not null)
            if (resources == null)
            {
                throw new ArgumentNullException("resources is a required property for AccessPermissionV1 and cannot be null");
            }
            this.Resources = resources;
        }

        /// <summary>
        /// The id of the role that applies to this permission.
        /// </summary>
        /// <value>The id of the role that applies to this permission.</value>
        [DataMember(Name = "roleId", IsRequired = true, EmitDefaultValue = true)]
        public string RoleId { get; set; }

        /// <summary>
        /// The name of the role that applies to this permission.
        /// </summary>
        /// <value>The name of the role that applies to this permission.</value>
        [DataMember(Name = "roleName", IsRequired = true, EmitDefaultValue = true)]
        public string RoleName { get; set; }

        /// <summary>
        /// The resources included with this permission.
        /// </summary>
        /// <value>The resources included with this permission.</value>
        [DataMember(Name = "resources", IsRequired = true, EmitDefaultValue = true)]
        public List<PermissionResourceV1> Resources { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccessPermissionV1 {\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
            sb.Append("  RoleName: ").Append(RoleName).Append("\n");
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
            return this.Equals(input as AccessPermissionV1);
        }

        /// <summary>
        /// Returns true if AccessPermissionV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessPermissionV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessPermissionV1 input)
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
                    this.RoleName == input.RoleName ||
                    (this.RoleName != null &&
                    this.RoleName.Equals(input.RoleName))
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
                if (this.RoleName != null)
                {
                    hashCode = (hashCode * 59) + this.RoleName.GetHashCode();
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
