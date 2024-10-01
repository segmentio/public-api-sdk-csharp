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
    /// DestinationSubscription
    /// </summary>
    [DataContract(Name = "DestinationSubscription")]
    public partial class DestinationSubscription : IEquatable<DestinationSubscription>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationSubscription" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DestinationSubscription() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationSubscription" /> class.
        /// </summary>
        /// <param name="id">The unique identifier for the subscription. (required).</param>
        /// <param name="name">The name of the subscription. (required).</param>
        /// <param name="actionId">The unique identifier for the Destination action to trigger. (required).</param>
        /// <param name="actionSlug">The URL-friendly key for the associated Destination action. (required).</param>
        /// <param name="destinationId">The associated Destination instance id. (required).</param>
        /// <param name="enabled">Is the subscription enabled. (required).</param>
        /// <param name="settings">Represents settings used to configure an action subscription. (required).</param>
        /// <param name="trigger">FQL string that describes what events should trigger a Destination action. (required).</param>
        /// <param name="modelId">The unique identifier for the linked ReverseETLModel, if this part of a Reverse ETL connection..</param>
        /// <param name="reverseETLSchedule">reverseETLSchedule.</param>
        public DestinationSubscription(string id = default(string), string name = default(string), string actionId = default(string), string actionSlug = default(string), string destinationId = default(string), bool enabled = default(bool), Dictionary<string, Object> settings = default(Dictionary<string, Object>), string trigger = default(string), string modelId = default(string), ReverseEtlScheduleDefinition reverseETLSchedule = default(ReverseEtlScheduleDefinition))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for DestinationSubscription and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for DestinationSubscription and cannot be null");
            }
            this.Name = name;
            // to ensure "actionId" is required (not null)
            if (actionId == null)
            {
                throw new ArgumentNullException("actionId is a required property for DestinationSubscription and cannot be null");
            }
            this.ActionId = actionId;
            // to ensure "actionSlug" is required (not null)
            if (actionSlug == null)
            {
                throw new ArgumentNullException("actionSlug is a required property for DestinationSubscription and cannot be null");
            }
            this.ActionSlug = actionSlug;
            // to ensure "destinationId" is required (not null)
            if (destinationId == null)
            {
                throw new ArgumentNullException("destinationId is a required property for DestinationSubscription and cannot be null");
            }
            this.DestinationId = destinationId;
            this.Enabled = enabled;
            // to ensure "settings" is required (not null)
            if (settings == null)
            {
                throw new ArgumentNullException("settings is a required property for DestinationSubscription and cannot be null");
            }
            this.Settings = settings;
            // to ensure "trigger" is required (not null)
            if (trigger == null)
            {
                throw new ArgumentNullException("trigger is a required property for DestinationSubscription and cannot be null");
            }
            this.Trigger = trigger;
            this.ModelId = modelId;
            this.ReverseETLSchedule = reverseETLSchedule;
        }

        /// <summary>
        /// The unique identifier for the subscription.
        /// </summary>
        /// <value>The unique identifier for the subscription.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the subscription.
        /// </summary>
        /// <value>The name of the subscription.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The unique identifier for the Destination action to trigger.
        /// </summary>
        /// <value>The unique identifier for the Destination action to trigger.</value>
        [DataMember(Name = "actionId", IsRequired = true, EmitDefaultValue = true)]
        public string ActionId { get; set; }

        /// <summary>
        /// The URL-friendly key for the associated Destination action.
        /// </summary>
        /// <value>The URL-friendly key for the associated Destination action.</value>
        [DataMember(Name = "actionSlug", IsRequired = true, EmitDefaultValue = true)]
        public string ActionSlug { get; set; }

        /// <summary>
        /// The associated Destination instance id.
        /// </summary>
        /// <value>The associated Destination instance id.</value>
        [DataMember(Name = "destinationId", IsRequired = true, EmitDefaultValue = true)]
        public string DestinationId { get; set; }

        /// <summary>
        /// Is the subscription enabled.
        /// </summary>
        /// <value>Is the subscription enabled.</value>
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Represents settings used to configure an action subscription.
        /// </summary>
        /// <value>Represents settings used to configure an action subscription.</value>
        [DataMember(Name = "settings", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> Settings { get; set; }

        /// <summary>
        /// FQL string that describes what events should trigger a Destination action.
        /// </summary>
        /// <value>FQL string that describes what events should trigger a Destination action.</value>
        [DataMember(Name = "trigger", IsRequired = true, EmitDefaultValue = true)]
        public string Trigger { get; set; }

        /// <summary>
        /// The unique identifier for the linked ReverseETLModel, if this part of a Reverse ETL connection.
        /// </summary>
        /// <value>The unique identifier for the linked ReverseETLModel, if this part of a Reverse ETL connection.</value>
        [DataMember(Name = "modelId", EmitDefaultValue = false)]
        public string ModelId { get; set; }

        /// <summary>
        /// Gets or Sets ReverseETLSchedule
        /// </summary>
        [DataMember(Name = "reverseETLSchedule", EmitDefaultValue = false)]
        public ReverseEtlScheduleDefinition ReverseETLSchedule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinationSubscription {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ActionId: ").Append(ActionId).Append("\n");
            sb.Append("  ActionSlug: ").Append(ActionSlug).Append("\n");
            sb.Append("  DestinationId: ").Append(DestinationId).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  Trigger: ").Append(Trigger).Append("\n");
            sb.Append("  ModelId: ").Append(ModelId).Append("\n");
            sb.Append("  ReverseETLSchedule: ").Append(ReverseETLSchedule).Append("\n");
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
            return this.Equals(input as DestinationSubscription);
        }

        /// <summary>
        /// Returns true if DestinationSubscription instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinationSubscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinationSubscription input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ActionId == input.ActionId ||
                    (this.ActionId != null &&
                    this.ActionId.Equals(input.ActionId))
                ) && 
                (
                    this.ActionSlug == input.ActionSlug ||
                    (this.ActionSlug != null &&
                    this.ActionSlug.Equals(input.ActionSlug))
                ) && 
                (
                    this.DestinationId == input.DestinationId ||
                    (this.DestinationId != null &&
                    this.DestinationId.Equals(input.DestinationId))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Settings == input.Settings ||
                    this.Settings != null &&
                    input.Settings != null &&
                    this.Settings.SequenceEqual(input.Settings)
                ) && 
                (
                    this.Trigger == input.Trigger ||
                    (this.Trigger != null &&
                    this.Trigger.Equals(input.Trigger))
                ) && 
                (
                    this.ModelId == input.ModelId ||
                    (this.ModelId != null &&
                    this.ModelId.Equals(input.ModelId))
                ) && 
                (
                    this.ReverseETLSchedule == input.ReverseETLSchedule ||
                    (this.ReverseETLSchedule != null &&
                    this.ReverseETLSchedule.Equals(input.ReverseETLSchedule))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.ActionId != null)
                {
                    hashCode = (hashCode * 59) + this.ActionId.GetHashCode();
                }
                if (this.ActionSlug != null)
                {
                    hashCode = (hashCode * 59) + this.ActionSlug.GetHashCode();
                }
                if (this.DestinationId != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.Settings != null)
                {
                    hashCode = (hashCode * 59) + this.Settings.GetHashCode();
                }
                if (this.Trigger != null)
                {
                    hashCode = (hashCode * 59) + this.Trigger.GetHashCode();
                }
                if (this.ModelId != null)
                {
                    hashCode = (hashCode * 59) + this.ModelId.GetHashCode();
                }
                if (this.ReverseETLSchedule != null)
                {
                    hashCode = (hashCode * 59) + this.ReverseETLSchedule.GetHashCode();
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
