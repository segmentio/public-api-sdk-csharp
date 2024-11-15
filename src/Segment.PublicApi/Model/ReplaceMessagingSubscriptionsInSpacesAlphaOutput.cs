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
    /// Output for the endpoint.
    /// </summary>
    [DataContract(Name = "ReplaceMessagingSubscriptionsInSpacesAlphaOutput")]
    public partial class ReplaceMessagingSubscriptionsInSpacesAlphaOutput : IEquatable<ReplaceMessagingSubscriptionsInSpacesAlphaOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceMessagingSubscriptionsInSpacesAlphaOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReplaceMessagingSubscriptionsInSpacesAlphaOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceMessagingSubscriptionsInSpacesAlphaOutput" /> class.
        /// </summary>
        /// <param name="successes">Array of successful subscription status. (required).</param>
        /// <param name="failures">Array of failure subscription status. (required).</param>
        /// <param name="pagination">pagination.</param>
        public ReplaceMessagingSubscriptionsInSpacesAlphaOutput(List<MessageSubscriptionResponse> successes = default(List<MessageSubscriptionResponse>), List<MessageSubscriptionResponse> failures = default(List<MessageSubscriptionResponse>), PaginationOutput pagination = default(PaginationOutput))
        {
            // to ensure "successes" is required (not null)
            if (successes == null)
            {
                throw new ArgumentNullException("successes is a required property for ReplaceMessagingSubscriptionsInSpacesAlphaOutput and cannot be null");
            }
            this.Successes = successes;
            // to ensure "failures" is required (not null)
            if (failures == null)
            {
                throw new ArgumentNullException("failures is a required property for ReplaceMessagingSubscriptionsInSpacesAlphaOutput and cannot be null");
            }
            this.Failures = failures;
            this.Pagination = pagination;
        }

        /// <summary>
        /// Array of successful subscription status.
        /// </summary>
        /// <value>Array of successful subscription status.</value>
        [DataMember(Name = "successes", IsRequired = true, EmitDefaultValue = true)]
        public List<MessageSubscriptionResponse> Successes { get; set; }

        /// <summary>
        /// Array of failure subscription status.
        /// </summary>
        /// <value>Array of failure subscription status.</value>
        [DataMember(Name = "failures", IsRequired = true, EmitDefaultValue = true)]
        public List<MessageSubscriptionResponse> Failures { get; set; }

        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name = "pagination", EmitDefaultValue = false)]
        public PaginationOutput Pagination { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReplaceMessagingSubscriptionsInSpacesAlphaOutput {\n");
            sb.Append("  Successes: ").Append(Successes).Append("\n");
            sb.Append("  Failures: ").Append(Failures).Append("\n");
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
            return this.Equals(input as ReplaceMessagingSubscriptionsInSpacesAlphaOutput);
        }

        /// <summary>
        /// Returns true if ReplaceMessagingSubscriptionsInSpacesAlphaOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of ReplaceMessagingSubscriptionsInSpacesAlphaOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplaceMessagingSubscriptionsInSpacesAlphaOutput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Successes == input.Successes ||
                    this.Successes != null &&
                    input.Successes != null &&
                    this.Successes.SequenceEqual(input.Successes)
                ) && 
                (
                    this.Failures == input.Failures ||
                    this.Failures != null &&
                    input.Failures != null &&
                    this.Failures.SequenceEqual(input.Failures)
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
                if (this.Successes != null)
                {
                    hashCode = (hashCode * 59) + this.Successes.GetHashCode();
                }
                if (this.Failures != null)
                {
                    hashCode = (hashCode * 59) + this.Failures.GetHashCode();
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
