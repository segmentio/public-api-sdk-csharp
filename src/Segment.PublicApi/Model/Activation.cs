/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 57.4.0
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
    /// Activation
    /// </summary>
    [DataContract(Name = "Activation")]
    public partial class Activation : IEquatable<Activation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Activation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Activation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Activation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="eventName">eventName (required).</param>
        /// <param name="actionDefinition">actionDefinition (required).</param>
        /// <param name="propertySelections">propertySelections.</param>
        public Activation(string id = default(string), string eventName = default(string), ActionDefinition actionDefinition = default(ActionDefinition), PropertySelectionsConfig propertySelections = default(PropertySelectionsConfig))
        {
            // to ensure "eventName" is required (not null)
            if (eventName == null)
            {
                throw new ArgumentNullException("eventName is a required property for Activation and cannot be null");
            }
            this.EventName = eventName;
            // to ensure "actionDefinition" is required (not null)
            if (actionDefinition == null)
            {
                throw new ArgumentNullException("actionDefinition is a required property for Activation and cannot be null");
            }
            this.ActionDefinition = actionDefinition;
            this.Id = id;
            this.PropertySelections = propertySelections;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name = "eventName", IsRequired = true, EmitDefaultValue = true)]
        public string EventName { get; set; }

        /// <summary>
        /// Gets or Sets ActionDefinition
        /// </summary>
        [DataMember(Name = "actionDefinition", IsRequired = true, EmitDefaultValue = true)]
        public ActionDefinition ActionDefinition { get; set; }

        /// <summary>
        /// Gets or Sets PropertySelections
        /// </summary>
        [DataMember(Name = "propertySelections", EmitDefaultValue = false)]
        public PropertySelectionsConfig PropertySelections { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Activation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  ActionDefinition: ").Append(ActionDefinition).Append("\n");
            sb.Append("  PropertySelections: ").Append(PropertySelections).Append("\n");
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
            return this.Equals(input as Activation);
        }

        /// <summary>
        /// Returns true if Activation instances are equal
        /// </summary>
        /// <param name="input">Instance of Activation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Activation input)
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
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.ActionDefinition == input.ActionDefinition ||
                    (this.ActionDefinition != null &&
                    this.ActionDefinition.Equals(input.ActionDefinition))
                ) && 
                (
                    this.PropertySelections == input.PropertySelections ||
                    (this.PropertySelections != null &&
                    this.PropertySelections.Equals(input.PropertySelections))
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
                if (this.EventName != null)
                {
                    hashCode = (hashCode * 59) + this.EventName.GetHashCode();
                }
                if (this.ActionDefinition != null)
                {
                    hashCode = (hashCode * 59) + this.ActionDefinition.GetHashCode();
                }
                if (this.PropertySelections != null)
                {
                    hashCode = (hashCode * 59) + this.PropertySelections.GetHashCode();
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
