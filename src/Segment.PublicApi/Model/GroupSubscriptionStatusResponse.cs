/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.1.1
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
    /// GroupSubscriptionStatusResponse
    /// </summary>
    [DataContract(Name = "GroupSubscriptionStatusResponse")]
    public partial class GroupSubscriptionStatusResponse : IEquatable<GroupSubscriptionStatusResponse>, IValidatableObject
    {
        /// <summary>
        /// The user subscribed, unsubscribed, or on initial status.
        /// </summary>
        /// <value>The user subscribed, unsubscribed, or on initial status.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum DIDNOTSUBSCRIBE for value: DID_NOT_SUBSCRIBE
            /// </summary>
            [EnumMember(Value = "DID_NOT_SUBSCRIBE")]
            DIDNOTSUBSCRIBE = 1,

            /// <summary>
            /// Enum SUBSCRIBED for value: SUBSCRIBED
            /// </summary>
            [EnumMember(Value = "SUBSCRIBED")]
            SUBSCRIBED = 2,

            /// <summary>
            /// Enum UNSUBSCRIBED for value: UNSUBSCRIBED
            /// </summary>
            [EnumMember(Value = "UNSUBSCRIBED")]
            UNSUBSCRIBED = 3
        }


        /// <summary>
        /// The user subscribed, unsubscribed, or on initial status.
        /// </summary>
        /// <value>The user subscribed, unsubscribed, or on initial status.</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupSubscriptionStatusResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupSubscriptionStatusResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupSubscriptionStatusResponse" /> class.
        /// </summary>
        /// <param name="name">Name of the group. (required).</param>
        /// <param name="status">The user subscribed, unsubscribed, or on initial status. (required).</param>
        /// <param name="id">The group id. (required).</param>
        /// <param name="updatedAt">The timestamp of this subscription status&#39;s last change..</param>
        public GroupSubscriptionStatusResponse(string name = default(string), StatusEnum status = default(StatusEnum), string id = default(string), string updatedAt = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for GroupSubscriptionStatusResponse and cannot be null");
            }
            this.Name = name;
            this.Status = status;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for GroupSubscriptionStatusResponse and cannot be null");
            }
            this.Id = id;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Name of the group.
        /// </summary>
        /// <value>Name of the group.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The group id.
        /// </summary>
        /// <value>The group id.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The timestamp of this subscription status&#39;s last change.
        /// </summary>
        /// <value>The timestamp of this subscription status&#39;s last change.</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupSubscriptionStatusResponse {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as GroupSubscriptionStatusResponse);
        }

        /// <summary>
        /// Returns true if GroupSubscriptionStatusResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupSubscriptionStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupSubscriptionStatusResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
