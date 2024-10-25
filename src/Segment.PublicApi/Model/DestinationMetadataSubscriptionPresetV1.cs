/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 55.1.0
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
    /// Represents a set of defaults for a Destination subscription.
    /// </summary>
    [DataContract(Name = "DestinationMetadataSubscriptionPresetV1")]
    public partial class DestinationMetadataSubscriptionPresetV1 : IEquatable<DestinationMetadataSubscriptionPresetV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationMetadataSubscriptionPresetV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DestinationMetadataSubscriptionPresetV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationMetadataSubscriptionPresetV1" /> class.
        /// </summary>
        /// <param name="actionId">The unique identifier for the Destination Action to trigger. (required).</param>
        /// <param name="name">The name of the subscription. (required).</param>
        /// <param name="fields">The default settings for action fields. (required).</param>
        /// <param name="trigger">FQL string that describes what events should trigger an action. See https://segment.com/docs/config-api/fql/ for more information regarding Segment&#39;s Filter Query Language (FQL). (required).</param>
        public DestinationMetadataSubscriptionPresetV1(string actionId = default(string), string name = default(string), Dictionary<string, Object> fields = default(Dictionary<string, Object>), string trigger = default(string))
        {
            // to ensure "actionId" is required (not null)
            if (actionId == null)
            {
                throw new ArgumentNullException("actionId is a required property for DestinationMetadataSubscriptionPresetV1 and cannot be null");
            }
            this.ActionId = actionId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for DestinationMetadataSubscriptionPresetV1 and cannot be null");
            }
            this.Name = name;
            // to ensure "fields" is required (not null)
            if (fields == null)
            {
                throw new ArgumentNullException("fields is a required property for DestinationMetadataSubscriptionPresetV1 and cannot be null");
            }
            this.Fields = fields;
            // to ensure "trigger" is required (not null)
            if (trigger == null)
            {
                throw new ArgumentNullException("trigger is a required property for DestinationMetadataSubscriptionPresetV1 and cannot be null");
            }
            this.Trigger = trigger;
        }

        /// <summary>
        /// The unique identifier for the Destination Action to trigger.
        /// </summary>
        /// <value>The unique identifier for the Destination Action to trigger.</value>
        [DataMember(Name = "actionId", IsRequired = true, EmitDefaultValue = true)]
        public string ActionId { get; set; }

        /// <summary>
        /// The name of the subscription.
        /// </summary>
        /// <value>The name of the subscription.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The default settings for action fields.
        /// </summary>
        /// <value>The default settings for action fields.</value>
        [DataMember(Name = "fields", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> Fields { get; set; }

        /// <summary>
        /// FQL string that describes what events should trigger an action. See https://segment.com/docs/config-api/fql/ for more information regarding Segment&#39;s Filter Query Language (FQL).
        /// </summary>
        /// <value>FQL string that describes what events should trigger an action. See https://segment.com/docs/config-api/fql/ for more information regarding Segment&#39;s Filter Query Language (FQL).</value>
        [DataMember(Name = "trigger", IsRequired = true, EmitDefaultValue = true)]
        public string Trigger { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinationMetadataSubscriptionPresetV1 {\n");
            sb.Append("  ActionId: ").Append(ActionId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Trigger: ").Append(Trigger).Append("\n");
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
            return this.Equals(input as DestinationMetadataSubscriptionPresetV1);
        }

        /// <summary>
        /// Returns true if DestinationMetadataSubscriptionPresetV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinationMetadataSubscriptionPresetV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinationMetadataSubscriptionPresetV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActionId == input.ActionId ||
                    (this.ActionId != null &&
                    this.ActionId.Equals(input.ActionId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.Trigger == input.Trigger ||
                    (this.Trigger != null &&
                    this.Trigger.Equals(input.Trigger))
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
                if (this.ActionId != null)
                {
                    hashCode = (hashCode * 59) + this.ActionId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Fields != null)
                {
                    hashCode = (hashCode * 59) + this.Fields.GetHashCode();
                }
                if (this.Trigger != null)
                {
                    hashCode = (hashCode * 59) + this.Trigger.GetHashCode();
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
