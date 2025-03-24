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
    /// Input for the endpoint.
    /// </summary>
    [DataContract(Name = "ReplaceMessagingSubscriptionsInSpacesAlphaInput")]
    public partial class ReplaceMessagingSubscriptionsInSpacesAlphaInput : IEquatable<ReplaceMessagingSubscriptionsInSpacesAlphaInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceMessagingSubscriptionsInSpacesAlphaInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReplaceMessagingSubscriptionsInSpacesAlphaInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceMessagingSubscriptionsInSpacesAlphaInput" /> class.
        /// </summary>
        /// <param name="subscriptions">An array of subscriptions. (required).</param>
        public ReplaceMessagingSubscriptionsInSpacesAlphaInput(List<MessagesSubscriptionRequest> subscriptions = default(List<MessagesSubscriptionRequest>))
        {
            // to ensure "subscriptions" is required (not null)
            if (subscriptions == null)
            {
                throw new ArgumentNullException("subscriptions is a required property for ReplaceMessagingSubscriptionsInSpacesAlphaInput and cannot be null");
            }
            this.Subscriptions = subscriptions;
        }

        /// <summary>
        /// An array of subscriptions.
        /// </summary>
        /// <value>An array of subscriptions.</value>
        [DataMember(Name = "subscriptions", IsRequired = true, EmitDefaultValue = true)]
        public List<MessagesSubscriptionRequest> Subscriptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReplaceMessagingSubscriptionsInSpacesAlphaInput {\n");
            sb.Append("  Subscriptions: ").Append(Subscriptions).Append("\n");
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
            return this.Equals(input as ReplaceMessagingSubscriptionsInSpacesAlphaInput);
        }

        /// <summary>
        /// Returns true if ReplaceMessagingSubscriptionsInSpacesAlphaInput instances are equal
        /// </summary>
        /// <param name="input">Instance of ReplaceMessagingSubscriptionsInSpacesAlphaInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplaceMessagingSubscriptionsInSpacesAlphaInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Subscriptions == input.Subscriptions ||
                    this.Subscriptions != null &&
                    input.Subscriptions != null &&
                    this.Subscriptions.SequenceEqual(input.Subscriptions)
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
                if (this.Subscriptions != null)
                {
                    hashCode = (hashCode * 59) + this.Subscriptions.GetHashCode();
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
