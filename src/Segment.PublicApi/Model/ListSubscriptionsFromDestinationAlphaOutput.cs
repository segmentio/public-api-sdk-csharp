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
    /// Output for ListDestinationSubscriptionsAlpha.
    /// </summary>
    [DataContract(Name = "ListSubscriptionsFromDestinationAlphaOutput")]
    public partial class ListSubscriptionsFromDestinationAlphaOutput : IEquatable<ListSubscriptionsFromDestinationAlphaOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionsFromDestinationAlphaOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListSubscriptionsFromDestinationAlphaOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionsFromDestinationAlphaOutput" /> class.
        /// </summary>
        /// <param name="subscriptions">A list of Destination subscriptions. (required).</param>
        /// <param name="pagination">pagination.</param>
        public ListSubscriptionsFromDestinationAlphaOutput(List<DestinationSubscription> subscriptions = default(List<DestinationSubscription>), PaginationOutput pagination = default(PaginationOutput))
        {
            // to ensure "subscriptions" is required (not null)
            if (subscriptions == null)
            {
                throw new ArgumentNullException("subscriptions is a required property for ListSubscriptionsFromDestinationAlphaOutput and cannot be null");
            }
            this.Subscriptions = subscriptions;
            this.Pagination = pagination;
        }

        /// <summary>
        /// A list of Destination subscriptions.
        /// </summary>
        /// <value>A list of Destination subscriptions.</value>
        [DataMember(Name = "subscriptions", IsRequired = true, EmitDefaultValue = true)]
        public List<DestinationSubscription> Subscriptions { get; set; }

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
            sb.Append("class ListSubscriptionsFromDestinationAlphaOutput {\n");
            sb.Append("  Subscriptions: ").Append(Subscriptions).Append("\n");
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
            return this.Equals(input as ListSubscriptionsFromDestinationAlphaOutput);
        }

        /// <summary>
        /// Returns true if ListSubscriptionsFromDestinationAlphaOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of ListSubscriptionsFromDestinationAlphaOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListSubscriptionsFromDestinationAlphaOutput input)
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
                if (this.Subscriptions != null)
                {
                    hashCode = (hashCode * 59) + this.Subscriptions.GetHashCode();
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
