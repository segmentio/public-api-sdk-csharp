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
    /// Returns the emails of invitees to a user group with the given group id.
    /// </summary>
    [DataContract(Name = "ListInvitesFromUserGroupV1Output")]
    public partial class ListInvitesFromUserGroupV1Output : IEquatable<ListInvitesFromUserGroupV1Output>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListInvitesFromUserGroupV1Output" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListInvitesFromUserGroupV1Output() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListInvitesFromUserGroupV1Output" /> class.
        /// </summary>
        /// <param name="emails">The emails of the invitees to the user group. (required).</param>
        /// <param name="pagination">pagination (required).</param>
        public ListInvitesFromUserGroupV1Output(List<string> emails = default(List<string>), PaginationOutput pagination = default(PaginationOutput))
        {
            // to ensure "emails" is required (not null)
            if (emails == null)
            {
                throw new ArgumentNullException("emails is a required property for ListInvitesFromUserGroupV1Output and cannot be null");
            }
            this.Emails = emails;
            // to ensure "pagination" is required (not null)
            if (pagination == null)
            {
                throw new ArgumentNullException("pagination is a required property for ListInvitesFromUserGroupV1Output and cannot be null");
            }
            this.Pagination = pagination;
        }

        /// <summary>
        /// The emails of the invitees to the user group.
        /// </summary>
        /// <value>The emails of the invitees to the user group.</value>
        [DataMember(Name = "emails", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Emails { get; set; }

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
            sb.Append("class ListInvitesFromUserGroupV1Output {\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
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
            return this.Equals(input as ListInvitesFromUserGroupV1Output);
        }

        /// <summary>
        /// Returns true if ListInvitesFromUserGroupV1Output instances are equal
        /// </summary>
        /// <param name="input">Instance of ListInvitesFromUserGroupV1Output to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListInvitesFromUserGroupV1Output input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Emails == input.Emails ||
                    this.Emails != null &&
                    input.Emails != null &&
                    this.Emails.SequenceEqual(input.Emails)
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
                if (this.Emails != null)
                {
                    hashCode = (hashCode * 59) + this.Emails.GetHashCode();
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
