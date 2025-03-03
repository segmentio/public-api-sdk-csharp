/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 57.4.0
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
    /// Returns the newly created user group.
    /// </summary>
    [DataContract(Name = "CreateUserGroupV1Output")]
    public partial class CreateUserGroupV1Output : IEquatable<CreateUserGroupV1Output>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserGroupV1Output" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateUserGroupV1Output() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserGroupV1Output" /> class.
        /// </summary>
        /// <param name="userGroup">userGroup (required).</param>
        public CreateUserGroupV1Output(UserGroupV1 userGroup = default(UserGroupV1))
        {
            // to ensure "userGroup" is required (not null)
            if (userGroup == null)
            {
                throw new ArgumentNullException("userGroup is a required property for CreateUserGroupV1Output and cannot be null");
            }
            this.UserGroup = userGroup;
        }

        /// <summary>
        /// Gets or Sets UserGroup
        /// </summary>
        [DataMember(Name = "userGroup", IsRequired = true, EmitDefaultValue = true)]
        public UserGroupV1 UserGroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateUserGroupV1Output {\n");
            sb.Append("  UserGroup: ").Append(UserGroup).Append("\n");
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
            return this.Equals(input as CreateUserGroupV1Output);
        }

        /// <summary>
        /// Returns true if CreateUserGroupV1Output instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateUserGroupV1Output to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateUserGroupV1Output input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UserGroup == input.UserGroup ||
                    (this.UserGroup != null &&
                    this.UserGroup.Equals(input.UserGroup))
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
                if (this.UserGroup != null)
                {
                    hashCode = (hashCode * 59) + this.UserGroup.GetHashCode();
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
