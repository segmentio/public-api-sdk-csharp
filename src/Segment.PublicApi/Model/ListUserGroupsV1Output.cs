/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 54.3.0
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
    /// Returns a list of user groups with the given Workspace id.
    /// </summary>
    [DataContract(Name = "ListUserGroupsV1Output")]
    public partial class ListUserGroupsV1Output : IEquatable<ListUserGroupsV1Output>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListUserGroupsV1Output" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListUserGroupsV1Output() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListUserGroupsV1Output" /> class.
        /// </summary>
        /// <param name="userGroups">The user group returned from the query. (required).</param>
        /// <param name="pagination">pagination (required).</param>
        public ListUserGroupsV1Output(List<UserGroupV1> userGroups = default(List<UserGroupV1>), PaginationOutput pagination = default(PaginationOutput))
        {
            // to ensure "userGroups" is required (not null)
            if (userGroups == null)
            {
                throw new ArgumentNullException("userGroups is a required property for ListUserGroupsV1Output and cannot be null");
            }
            this.UserGroups = userGroups;
            // to ensure "pagination" is required (not null)
            if (pagination == null)
            {
                throw new ArgumentNullException("pagination is a required property for ListUserGroupsV1Output and cannot be null");
            }
            this.Pagination = pagination;
        }

        /// <summary>
        /// The user group returned from the query.
        /// </summary>
        /// <value>The user group returned from the query.</value>
        [DataMember(Name = "userGroups", IsRequired = true, EmitDefaultValue = true)]
        public List<UserGroupV1> UserGroups { get; set; }

        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name = "pagination", IsRequired = true, EmitDefaultValue = true)]
        public PaginationOutput Pagination { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListUserGroupsV1Output {\n");
            sb.Append("  UserGroups: ").Append(UserGroups).Append("\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
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
            return this.Equals(input as ListUserGroupsV1Output);
        }

        /// <summary>
        /// Returns true if ListUserGroupsV1Output instances are equal
        /// </summary>
        /// <param name="input">Instance of ListUserGroupsV1Output to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListUserGroupsV1Output input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UserGroups == input.UserGroups ||
                    this.UserGroups != null &&
                    input.UserGroups != null &&
                    this.UserGroups.SequenceEqual(input.UserGroups)
                ) && 
                (
                    this.Pagination == input.Pagination ||
                    (this.Pagination != null &&
                    this.Pagination.Equals(input.Pagination))
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
                if (this.UserGroups != null)
                {
                    hashCode = (hashCode * 59) + this.UserGroups.GetHashCode();
                }
                if (this.Pagination != null)
                {
                    hashCode = (hashCode * 59) + this.Pagination.GetHashCode();
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
