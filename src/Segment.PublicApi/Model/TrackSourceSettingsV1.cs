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
    /// TrackSourceSettingsV1
    /// </summary>
    [DataContract(Name = "TrackSourceSettingsV1")]
    public partial class TrackSourceSettingsV1 : IEquatable<TrackSourceSettingsV1>, IValidatableObject
    {
        /// <summary>
        /// The common track event on violations.  Config API note: equal to &#x60;commonTrackEventOnViolations&#x60;.
        /// </summary>
        /// <value>The common track event on violations.  Config API note: equal to &#x60;commonTrackEventOnViolations&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CommonEventOnViolationsEnum
        {
            /// <summary>
            /// Enum ALLOW for value: ALLOW
            /// </summary>
            [EnumMember(Value = "ALLOW")]
            ALLOW = 1,

            /// <summary>
            /// Enum BLOCK for value: BLOCK
            /// </summary>
            [EnumMember(Value = "BLOCK")]
            BLOCK = 2,

            /// <summary>
            /// Enum OMITPROPERTIES for value: OMIT_PROPERTIES
            /// </summary>
            [EnumMember(Value = "OMIT_PROPERTIES")]
            OMITPROPERTIES = 3
        }


        /// <summary>
        /// The common track event on violations.  Config API note: equal to &#x60;commonTrackEventOnViolations&#x60;.
        /// </summary>
        /// <value>The common track event on violations.  Config API note: equal to &#x60;commonTrackEventOnViolations&#x60;.</value>
        [DataMember(Name = "commonEventOnViolations", EmitDefaultValue = false)]
        public CommonEventOnViolationsEnum? CommonEventOnViolations { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackSourceSettingsV1" /> class.
        /// </summary>
        /// <param name="allowUnplannedEvents">Enable to allow unplanned track events.  Config API note: equal to &#x60;allowUnplannedTrackEvents&#x60;..</param>
        /// <param name="allowUnplannedEventProperties">Enable to allow unplanned track event properties.  Config API note: equal to &#x60;allowUnplannedTrackEventProperties&#x60;..</param>
        /// <param name="allowEventOnViolations">Allow track event on violations.  Config API note: equal to &#x60;allowTrackEventOnViolations&#x60;..</param>
        /// <param name="allowPropertiesOnViolations">Enable to allow track properties on violations.  Config API note: equal to &#x60;allowTrackEventPropertiesOnViolations&#x60;..</param>
        /// <param name="commonEventOnViolations">The common track event on violations.  Config API note: equal to &#x60;commonTrackEventOnViolations&#x60;..</param>
        public TrackSourceSettingsV1(bool allowUnplannedEvents = default(bool), bool allowUnplannedEventProperties = default(bool), bool allowEventOnViolations = default(bool), bool allowPropertiesOnViolations = default(bool), CommonEventOnViolationsEnum? commonEventOnViolations = default(CommonEventOnViolationsEnum?))
        {
            this.AllowUnplannedEvents = allowUnplannedEvents;
            this.AllowUnplannedEventProperties = allowUnplannedEventProperties;
            this.AllowEventOnViolations = allowEventOnViolations;
            this.AllowPropertiesOnViolations = allowPropertiesOnViolations;
            this.CommonEventOnViolations = commonEventOnViolations;
        }

        /// <summary>
        /// Enable to allow unplanned track events.  Config API note: equal to &#x60;allowUnplannedTrackEvents&#x60;.
        /// </summary>
        /// <value>Enable to allow unplanned track events.  Config API note: equal to &#x60;allowUnplannedTrackEvents&#x60;.</value>
        [DataMember(Name = "allowUnplannedEvents", EmitDefaultValue = true)]
        public bool AllowUnplannedEvents { get; set; }

        /// <summary>
        /// Enable to allow unplanned track event properties.  Config API note: equal to &#x60;allowUnplannedTrackEventProperties&#x60;.
        /// </summary>
        /// <value>Enable to allow unplanned track event properties.  Config API note: equal to &#x60;allowUnplannedTrackEventProperties&#x60;.</value>
        [DataMember(Name = "allowUnplannedEventProperties", EmitDefaultValue = true)]
        public bool AllowUnplannedEventProperties { get; set; }

        /// <summary>
        /// Allow track event on violations.  Config API note: equal to &#x60;allowTrackEventOnViolations&#x60;.
        /// </summary>
        /// <value>Allow track event on violations.  Config API note: equal to &#x60;allowTrackEventOnViolations&#x60;.</value>
        [DataMember(Name = "allowEventOnViolations", EmitDefaultValue = true)]
        public bool AllowEventOnViolations { get; set; }

        /// <summary>
        /// Enable to allow track properties on violations.  Config API note: equal to &#x60;allowTrackEventPropertiesOnViolations&#x60;.
        /// </summary>
        /// <value>Enable to allow track properties on violations.  Config API note: equal to &#x60;allowTrackEventPropertiesOnViolations&#x60;.</value>
        [DataMember(Name = "allowPropertiesOnViolations", EmitDefaultValue = true)]
        public bool AllowPropertiesOnViolations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackSourceSettingsV1 {\n");
            sb.Append("  AllowUnplannedEvents: ").Append(AllowUnplannedEvents).Append("\n");
            sb.Append("  AllowUnplannedEventProperties: ").Append(AllowUnplannedEventProperties).Append("\n");
            sb.Append("  AllowEventOnViolations: ").Append(AllowEventOnViolations).Append("\n");
            sb.Append("  AllowPropertiesOnViolations: ").Append(AllowPropertiesOnViolations).Append("\n");
            sb.Append("  CommonEventOnViolations: ").Append(CommonEventOnViolations).Append("\n");
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
            return this.Equals(input as TrackSourceSettingsV1);
        }

        /// <summary>
        /// Returns true if TrackSourceSettingsV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackSourceSettingsV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackSourceSettingsV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AllowUnplannedEvents == input.AllowUnplannedEvents ||
                    this.AllowUnplannedEvents.Equals(input.AllowUnplannedEvents)
                ) && 
                (
                    this.AllowUnplannedEventProperties == input.AllowUnplannedEventProperties ||
                    this.AllowUnplannedEventProperties.Equals(input.AllowUnplannedEventProperties)
                ) && 
                (
                    this.AllowEventOnViolations == input.AllowEventOnViolations ||
                    this.AllowEventOnViolations.Equals(input.AllowEventOnViolations)
                ) && 
                (
                    this.AllowPropertiesOnViolations == input.AllowPropertiesOnViolations ||
                    this.AllowPropertiesOnViolations.Equals(input.AllowPropertiesOnViolations)
                ) && 
                (
                    this.CommonEventOnViolations == input.CommonEventOnViolations ||
                    this.CommonEventOnViolations.Equals(input.CommonEventOnViolations)
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
                hashCode = (hashCode * 59) + this.AllowUnplannedEvents.GetHashCode();
                hashCode = (hashCode * 59) + this.AllowUnplannedEventProperties.GetHashCode();
                hashCode = (hashCode * 59) + this.AllowEventOnViolations.GetHashCode();
                hashCode = (hashCode * 59) + this.AllowPropertiesOnViolations.GetHashCode();
                hashCode = (hashCode * 59) + this.CommonEventOnViolations.GetHashCode();
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
