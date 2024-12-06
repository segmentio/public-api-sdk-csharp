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
    /// Defines an invitation to join a Workspace.
    /// </summary>
    [DataContract(Name = "InviteV1")]
    public partial class InviteV1 : IEquatable<InviteV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InviteV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InviteV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InviteV1" /> class.
        /// </summary>
        /// <param name="email">The invited user&#39;s email to attach the permissions to. (required).</param>
        /// <param name="permissions">The permissions to attach to the invited user..</param>
        public InviteV1(string email = default(string), List<InvitePermissionV1> permissions = default(List<InvitePermissionV1>))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for InviteV1 and cannot be null");
            }
            this.Email = email;
            this.Permissions = permissions;
        }

        /// <summary>
        /// The invited user&#39;s email to attach the permissions to.
        /// </summary>
        /// <value>The invited user&#39;s email to attach the permissions to.</value>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// The permissions to attach to the invited user.
        /// </summary>
        /// <value>The permissions to attach to the invited user.</value>
        [DataMember(Name = "permissions", EmitDefaultValue = false)]
        public List<InvitePermissionV1> Permissions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InviteV1 {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(input as InviteV1);
        }

        /// <summary>
        /// Returns true if InviteV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of InviteV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InviteV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
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
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
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
