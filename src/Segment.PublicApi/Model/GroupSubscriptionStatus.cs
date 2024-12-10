/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 57.2.0
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
    /// GroupSubscriptionStatus
    /// </summary>
    [DataContract(Name = "GroupSubscriptionStatus")]
    public partial class GroupSubscriptionStatus : IEquatable<GroupSubscriptionStatus>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="GroupSubscriptionStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupSubscriptionStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupSubscriptionStatus" /> class.
        /// </summary>
        /// <param name="name">Name of the group. (required).</param>
        /// <param name="status">The user subscribed, unsubscribed, or on initial status. (required).</param>
        public GroupSubscriptionStatus(string name = default(string), StatusEnum status = default(StatusEnum))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for GroupSubscriptionStatus and cannot be null");
            }
            this.Name = name;
            this.Status = status;
        }

        /// <summary>
        /// Name of the group.
        /// </summary>
        /// <value>Name of the group.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupSubscriptionStatus {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as GroupSubscriptionStatus);
        }

        /// <summary>
        /// Returns true if GroupSubscriptionStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupSubscriptionStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupSubscriptionStatus input)
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
