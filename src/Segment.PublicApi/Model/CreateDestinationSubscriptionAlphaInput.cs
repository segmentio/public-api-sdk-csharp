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
    /// The basic input parameters for creating a Destination subscription.
    /// </summary>
    [DataContract(Name = "CreateDestinationSubscriptionAlphaInput")]
    public partial class CreateDestinationSubscriptionAlphaInput : IEquatable<CreateDestinationSubscriptionAlphaInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDestinationSubscriptionAlphaInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateDestinationSubscriptionAlphaInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDestinationSubscriptionAlphaInput" /> class.
        /// </summary>
        /// <param name="name">A user-defined name for the subscription. (required).</param>
        /// <param name="actionId">The associated action id the subscription should trigger. (required).</param>
        /// <param name="trigger">The FQL statement. (required).</param>
        /// <param name="enabled">Is the subscription enabled. (required).</param>
        /// <param name="settings">Represents settings used to configure an action subscription..</param>
        /// <param name="modelId">When creating a Reverse ETL connection, indicates the Model being used to extract data..</param>
        public CreateDestinationSubscriptionAlphaInput(string name = default(string), string actionId = default(string), string trigger = default(string), bool enabled = default(bool), Dictionary<string, Object> settings = default(Dictionary<string, Object>), string modelId = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateDestinationSubscriptionAlphaInput and cannot be null");
            }
            this.Name = name;
            // to ensure "actionId" is required (not null)
            if (actionId == null)
            {
                throw new ArgumentNullException("actionId is a required property for CreateDestinationSubscriptionAlphaInput and cannot be null");
            }
            this.ActionId = actionId;
            // to ensure "trigger" is required (not null)
            if (trigger == null)
            {
                throw new ArgumentNullException("trigger is a required property for CreateDestinationSubscriptionAlphaInput and cannot be null");
            }
            this.Trigger = trigger;
            this.Enabled = enabled;
            this.Settings = settings;
            this.ModelId = modelId;
        }

        /// <summary>
        /// A user-defined name for the subscription.
        /// </summary>
        /// <value>A user-defined name for the subscription.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The associated action id the subscription should trigger.
        /// </summary>
        /// <value>The associated action id the subscription should trigger.</value>
        [DataMember(Name = "actionId", IsRequired = true, EmitDefaultValue = true)]
        public string ActionId { get; set; }

        /// <summary>
        /// The FQL statement.
        /// </summary>
        /// <value>The FQL statement.</value>
        [DataMember(Name = "trigger", IsRequired = true, EmitDefaultValue = true)]
        public string Trigger { get; set; }

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
        [DataMember(Name = "settings", EmitDefaultValue = false)]
        public Dictionary<string, Object> Settings { get; set; }

        /// <summary>
        /// When creating a Reverse ETL connection, indicates the Model being used to extract data.
        /// </summary>
        /// <value>When creating a Reverse ETL connection, indicates the Model being used to extract data.</value>
        [DataMember(Name = "modelId", EmitDefaultValue = false)]
        public string ModelId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateDestinationSubscriptionAlphaInput {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ActionId: ").Append(ActionId).Append("\n");
            sb.Append("  Trigger: ").Append(Trigger).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  ModelId: ").Append(ModelId).Append("\n");
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
            return this.Equals(input as CreateDestinationSubscriptionAlphaInput);
        }

        /// <summary>
        /// Returns true if CreateDestinationSubscriptionAlphaInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateDestinationSubscriptionAlphaInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDestinationSubscriptionAlphaInput input)
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
                    this.ActionId == input.ActionId ||
                    (this.ActionId != null &&
                    this.ActionId.Equals(input.ActionId))
                ) && 
                (
                    this.Trigger == input.Trigger ||
                    (this.Trigger != null &&
                    this.Trigger.Equals(input.Trigger))
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
                    this.ModelId == input.ModelId ||
                    (this.ModelId != null &&
                    this.ModelId.Equals(input.ModelId))
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
                if (this.ActionId != null)
                {
                    hashCode = (hashCode * 59) + this.ActionId.GetHashCode();
                }
                if (this.Trigger != null)
                {
                    hashCode = (hashCode * 59) + this.Trigger.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.Settings != null)
                {
                    hashCode = (hashCode * 59) + this.Settings.GetHashCode();
                }
                if (this.ModelId != null)
                {
                    hashCode = (hashCode * 59) + this.ModelId.GetHashCode();
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
