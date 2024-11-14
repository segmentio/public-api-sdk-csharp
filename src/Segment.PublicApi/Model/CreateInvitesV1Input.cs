/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 57.0.1
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
    /// Invites a user to a Workspace with specified permissions.
    /// </summary>
    [DataContract(Name = "CreateInvitesV1Input")]
    public partial class CreateInvitesV1Input : IEquatable<CreateInvitesV1Input>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInvitesV1Input" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateInvitesV1Input() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInvitesV1Input" /> class.
        /// </summary>
        /// <param name="invites">The list of invites. (required).</param>
        public CreateInvitesV1Input(List<InviteV1> invites = default(List<InviteV1>))
        {
            // to ensure "invites" is required (not null)
            if (invites == null)
            {
                throw new ArgumentNullException("invites is a required property for CreateInvitesV1Input and cannot be null");
            }
            this.Invites = invites;
        }

        /// <summary>
        /// The list of invites.
        /// </summary>
        /// <value>The list of invites.</value>
        [DataMember(Name = "invites", IsRequired = true, EmitDefaultValue = true)]
        public List<InviteV1> Invites { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateInvitesV1Input {\n");
            sb.Append("  Invites: ").Append(Invites).Append("\n");
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
            return this.Equals(input as CreateInvitesV1Input);
        }

        /// <summary>
        /// Returns true if CreateInvitesV1Input instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateInvitesV1Input to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateInvitesV1Input input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Invites == input.Invites ||
                    this.Invites != null &&
                    input.Invites != null &&
                    this.Invites.SequenceEqual(input.Invites)
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
                if (this.Invites != null)
                {
                    hashCode = (hashCode * 59) + this.Invites.GetHashCode();
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
