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
    /// Returns the user group&#39;s permissions, including the updated permissions.
    /// </summary>
    [DataContract(Name = "ReplacePermissionsForUserGroupV1Output")]
    public partial class ReplacePermissionsForUserGroupV1Output : IEquatable<ReplacePermissionsForUserGroupV1Output>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplacePermissionsForUserGroupV1Output" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReplacePermissionsForUserGroupV1Output() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplacePermissionsForUserGroupV1Output" /> class.
        /// </summary>
        /// <param name="permissions">The updated permissions. (required).</param>
        public ReplacePermissionsForUserGroupV1Output(List<AccessPermissionV1> permissions = default(List<AccessPermissionV1>))
        {
            // to ensure "permissions" is required (not null)
            if (permissions == null)
            {
                throw new ArgumentNullException("permissions is a required property for ReplacePermissionsForUserGroupV1Output and cannot be null");
            }
            this.Permissions = permissions;
        }

        /// <summary>
        /// The updated permissions.
        /// </summary>
        /// <value>The updated permissions.</value>
        [DataMember(Name = "permissions", IsRequired = true, EmitDefaultValue = true)]
        public List<AccessPermissionV1> Permissions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReplacePermissionsForUserGroupV1Output {\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
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
            return this.Equals(input as ReplacePermissionsForUserGroupV1Output);
        }

        /// <summary>
        /// Returns true if ReplacePermissionsForUserGroupV1Output instances are equal
        /// </summary>
        /// <param name="input">Instance of ReplacePermissionsForUserGroupV1Output to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplacePermissionsForUserGroupV1Output input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Permissions == input.Permissions ||
                    this.Permissions != null &&
                    input.Permissions != null &&
                    this.Permissions.SequenceEqual(input.Permissions)
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
                if (this.Permissions != null)
                {
                    hashCode = (hashCode * 59) + this.Permissions.GetHashCode();
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
