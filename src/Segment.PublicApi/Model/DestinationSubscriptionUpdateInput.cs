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
    /// The input parameters for updating a Destination subscription.
    /// </summary>
    [DataContract(Name = "DestinationSubscriptionUpdateInput")]
    public partial class DestinationSubscriptionUpdateInput : IEquatable<DestinationSubscriptionUpdateInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationSubscriptionUpdateInput" /> class.
        /// </summary>
        /// <param name="name">The user-defined name for the subscription..</param>
        /// <param name="trigger">The fql statement..</param>
        /// <param name="enabled">Is the subscription enabled..</param>
        /// <param name="settings">Represents settings used to configure an action subscription..</param>
        /// <param name="reverseETLModelId">(Reverse ETL only) The reverse ETL model to attach this subscription to..</param>
        /// <param name="reverseETLSchedule">reverseETLSchedule.</param>
        public DestinationSubscriptionUpdateInput(string name = default(string), string trigger = default(string), bool enabled = default(bool), Dictionary<string, Object> settings = default(Dictionary<string, Object>), string reverseETLModelId = default(string), ReverseEtlScheduleDefinition reverseETLSchedule = default(ReverseEtlScheduleDefinition))
        {
            this.Name = name;
            this.Trigger = trigger;
            this.Enabled = enabled;
            this.Settings = settings;
            this.ReverseETLModelId = reverseETLModelId;
            this.ReverseETLSchedule = reverseETLSchedule;
        }

        /// <summary>
        /// The user-defined name for the subscription.
        /// </summary>
        /// <value>The user-defined name for the subscription.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The fql statement.
        /// </summary>
        /// <value>The fql statement.</value>
        [DataMember(Name = "trigger", EmitDefaultValue = false)]
        public string Trigger { get; set; }

        /// <summary>
        /// Is the subscription enabled.
        /// </summary>
        /// <value>Is the subscription enabled.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Represents settings used to configure an action subscription.
        /// </summary>
        /// <value>Represents settings used to configure an action subscription.</value>
        [DataMember(Name = "settings", EmitDefaultValue = false)]
        public Dictionary<string, Object> Settings { get; set; }

        /// <summary>
        /// (Reverse ETL only) The reverse ETL model to attach this subscription to.
        /// </summary>
        /// <value>(Reverse ETL only) The reverse ETL model to attach this subscription to.</value>
        [DataMember(Name = "reverseETLModelId", EmitDefaultValue = false)]
        public string ReverseETLModelId { get; set; }

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
            sb.Append("class DestinationSubscriptionUpdateInput {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Trigger: ").Append(Trigger).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  ReverseETLModelId: ").Append(ReverseETLModelId).Append("\n");
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
            return this.Equals(input as DestinationSubscriptionUpdateInput);
        }

        /// <summary>
        /// Returns true if DestinationSubscriptionUpdateInput instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinationSubscriptionUpdateInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinationSubscriptionUpdateInput input)
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
                    this.ReverseETLModelId == input.ReverseETLModelId ||
                    (this.ReverseETLModelId != null &&
                    this.ReverseETLModelId.Equals(input.ReverseETLModelId))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
                if (this.ReverseETLModelId != null)
                {
                    hashCode = (hashCode * 59) + this.ReverseETLModelId.GetHashCode();
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
