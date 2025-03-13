/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.0.0
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
    /// The &#x60;DeliveryOverviewDestinationFilterBy&#x60; object is a map of the filterable fields and their values.
    /// </summary>
    [DataContract(Name = "DeliveryOverviewDestinationFilterBy")]
    public partial class DeliveryOverviewDestinationFilterBy : IEquatable<DeliveryOverviewDestinationFilterBy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryOverviewDestinationFilterBy" /> class.
        /// </summary>
        /// <param name="discardReason">A list of strings of discard reasons.  See [Discard Record Documentation](https://segment.com/docs/connections/delivery-overview/#troubleshooting) for valid error codes..</param>
        /// <param name="eventName">A list of strings of event names..</param>
        /// <param name="eventType">A list of strings of event types. Valid options are: &#x60;alias&#x60;, &#x60;group&#x60;, &#x60;identify&#x60;, &#x60;page&#x60;, &#x60;screen&#x60;, and &#x60;track&#x60;..</param>
        /// <param name="appVersion">A list of strings of app versions..</param>
        /// <param name="subscriptionId">A list of strings of subscription IDs for Actions Destinations..</param>
        /// <param name="activationId">A list of strings of event context IDs from a Linked Audience mapping/activation..</param>
        /// <param name="audienceId">A list of strings of audience IDs for a Linked Audience..</param>
        /// <param name="spaceId">A list of strings of space IDs for a Linked Audience..</param>
        public DeliveryOverviewDestinationFilterBy(List<string> discardReason = default(List<string>), List<string> eventName = default(List<string>), List<string> eventType = default(List<string>), List<string> appVersion = default(List<string>), List<string> subscriptionId = default(List<string>), List<string> activationId = default(List<string>), List<string> audienceId = default(List<string>), List<string> spaceId = default(List<string>))
        {
            this.DiscardReason = discardReason;
            this.EventName = eventName;
            this.EventType = eventType;
            this.AppVersion = appVersion;
            this.SubscriptionId = subscriptionId;
            this.ActivationId = activationId;
            this.AudienceId = audienceId;
            this.SpaceId = spaceId;
        }

        /// <summary>
        /// A list of strings of discard reasons.  See [Discard Record Documentation](https://segment.com/docs/connections/delivery-overview/#troubleshooting) for valid error codes.
        /// </summary>
        /// <value>A list of strings of discard reasons.  See [Discard Record Documentation](https://segment.com/docs/connections/delivery-overview/#troubleshooting) for valid error codes.</value>
        [DataMember(Name = "discardReason", EmitDefaultValue = false)]
        public List<string> DiscardReason { get; set; }

        /// <summary>
        /// A list of strings of event names.
        /// </summary>
        /// <value>A list of strings of event names.</value>
        [DataMember(Name = "eventName", EmitDefaultValue = false)]
        public List<string> EventName { get; set; }

        /// <summary>
        /// A list of strings of event types. Valid options are: &#x60;alias&#x60;, &#x60;group&#x60;, &#x60;identify&#x60;, &#x60;page&#x60;, &#x60;screen&#x60;, and &#x60;track&#x60;.
        /// </summary>
        /// <value>A list of strings of event types. Valid options are: &#x60;alias&#x60;, &#x60;group&#x60;, &#x60;identify&#x60;, &#x60;page&#x60;, &#x60;screen&#x60;, and &#x60;track&#x60;.</value>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        public List<string> EventType { get; set; }

        /// <summary>
        /// A list of strings of app versions.
        /// </summary>
        /// <value>A list of strings of app versions.</value>
        [DataMember(Name = "appVersion", EmitDefaultValue = false)]
        public List<string> AppVersion { get; set; }

        /// <summary>
        /// A list of strings of subscription IDs for Actions Destinations.
        /// </summary>
        /// <value>A list of strings of subscription IDs for Actions Destinations.</value>
        [DataMember(Name = "subscriptionId", EmitDefaultValue = false)]
        public List<string> SubscriptionId { get; set; }

        /// <summary>
        /// A list of strings of event context IDs from a Linked Audience mapping/activation.
        /// </summary>
        /// <value>A list of strings of event context IDs from a Linked Audience mapping/activation.</value>
        [DataMember(Name = "activationId", EmitDefaultValue = false)]
        public List<string> ActivationId { get; set; }

        /// <summary>
        /// A list of strings of audience IDs for a Linked Audience.
        /// </summary>
        /// <value>A list of strings of audience IDs for a Linked Audience.</value>
        [DataMember(Name = "audienceId", EmitDefaultValue = false)]
        public List<string> AudienceId { get; set; }

        /// <summary>
        /// A list of strings of space IDs for a Linked Audience.
        /// </summary>
        /// <value>A list of strings of space IDs for a Linked Audience.</value>
        [DataMember(Name = "spaceId", EmitDefaultValue = false)]
        public List<string> SpaceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeliveryOverviewDestinationFilterBy {\n");
            sb.Append("  DiscardReason: ").Append(DiscardReason).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  ActivationId: ").Append(ActivationId).Append("\n");
            sb.Append("  AudienceId: ").Append(AudienceId).Append("\n");
            sb.Append("  SpaceId: ").Append(SpaceId).Append("\n");
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
            return this.Equals(input as DeliveryOverviewDestinationFilterBy);
        }

        /// <summary>
        /// Returns true if DeliveryOverviewDestinationFilterBy instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryOverviewDestinationFilterBy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryOverviewDestinationFilterBy input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DiscardReason == input.DiscardReason ||
                    this.DiscardReason != null &&
                    input.DiscardReason != null &&
                    this.DiscardReason.SequenceEqual(input.DiscardReason)
                ) && 
                (
                    this.EventName == input.EventName ||
                    this.EventName != null &&
                    input.EventName != null &&
                    this.EventName.SequenceEqual(input.EventName)
                ) && 
                (
                    this.EventType == input.EventType ||
                    this.EventType != null &&
                    input.EventType != null &&
                    this.EventType.SequenceEqual(input.EventType)
                ) && 
                (
                    this.AppVersion == input.AppVersion ||
                    this.AppVersion != null &&
                    input.AppVersion != null &&
                    this.AppVersion.SequenceEqual(input.AppVersion)
                ) && 
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    this.SubscriptionId != null &&
                    input.SubscriptionId != null &&
                    this.SubscriptionId.SequenceEqual(input.SubscriptionId)
                ) && 
                (
                    this.ActivationId == input.ActivationId ||
                    this.ActivationId != null &&
                    input.ActivationId != null &&
                    this.ActivationId.SequenceEqual(input.ActivationId)
                ) && 
                (
                    this.AudienceId == input.AudienceId ||
                    this.AudienceId != null &&
                    input.AudienceId != null &&
                    this.AudienceId.SequenceEqual(input.AudienceId)
                ) && 
                (
                    this.SpaceId == input.SpaceId ||
                    this.SpaceId != null &&
                    input.SpaceId != null &&
                    this.SpaceId.SequenceEqual(input.SpaceId)
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
                if (this.DiscardReason != null)
                {
                    hashCode = (hashCode * 59) + this.DiscardReason.GetHashCode();
                }
                if (this.EventName != null)
                {
                    hashCode = (hashCode * 59) + this.EventName.GetHashCode();
                }
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                if (this.AppVersion != null)
                {
                    hashCode = (hashCode * 59) + this.AppVersion.GetHashCode();
                }
                if (this.SubscriptionId != null)
                {
                    hashCode = (hashCode * 59) + this.SubscriptionId.GetHashCode();
                }
                if (this.ActivationId != null)
                {
                    hashCode = (hashCode * 59) + this.ActivationId.GetHashCode();
                }
                if (this.AudienceId != null)
                {
                    hashCode = (hashCode * 59) + this.AudienceId.GetHashCode();
                }
                if (this.SpaceId != null)
                {
                    hashCode = (hashCode * 59) + this.SpaceId.GetHashCode();
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
