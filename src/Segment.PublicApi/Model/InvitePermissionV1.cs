/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.0.1
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
    /// Defines a permission to apply to the user in an invite.
    /// </summary>
    [DataContract(Name = "InvitePermissionV1")]
    public partial class InvitePermissionV1 : IEquatable<InvitePermissionV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitePermissionV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvitePermissionV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitePermissionV1" /> class.
        /// </summary>
        /// <param name="roleId">The id of the role. (required).</param>
        /// <param name="resources">The resources to grant the invited users access to..</param>
        /// <param name="labels">The labels that determine which resources to grant users access to..</param>
        public InvitePermissionV1(string roleId = default(string), List<ResourceV1> resources = default(List<ResourceV1>), List<AllowedLabelBeta> labels = default(List<AllowedLabelBeta>))
        {
            // to ensure "roleId" is required (not null)
            if (roleId == null)
            {
                throw new ArgumentNullException("roleId is a required property for InvitePermissionV1 and cannot be null");
            }
            this.RoleId = roleId;
            this.Resources = resources;
            this.Labels = labels;
        }

        /// <summary>
        /// The id of the role.
        /// </summary>
        /// <value>The id of the role.</value>
        [DataMember(Name = "roleId", IsRequired = true, EmitDefaultValue = true)]
        public string RoleId { get; set; }

        /// <summary>
        /// The resources to grant the invited users access to.
        /// </summary>
        /// <value>The resources to grant the invited users access to.</value>
        [DataMember(Name = "resources", EmitDefaultValue = false)]
        public List<ResourceV1> Resources { get; set; }

        /// <summary>
        /// The labels that determine which resources to grant users access to.
        /// </summary>
        /// <value>The labels that determine which resources to grant users access to.</value>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public List<AllowedLabelBeta> Labels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvitePermissionV1 {\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
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
            return this.Equals(input as InvitePermissionV1);
        }

        /// <summary>
        /// Returns true if InvitePermissionV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of InvitePermissionV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvitePermissionV1 input)
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
                if (this.RoleId != null)
                {
                    hashCode = (hashCode * 59) + this.RoleId.GetHashCode();
                }
                if (this.Resources != null)
                {
                    hashCode = (hashCode * 59) + this.Resources.GetHashCode();
                }
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
