/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.13.0
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
    /// Input to update a Source&#39;s settings.
    /// </summary>
    [DataContract(Name = "UpdateSchemaSettingsInSourceV1Input")]
    public partial class UpdateSchemaSettingsInSourceV1Input : IEquatable<UpdateSchemaSettingsInSourceV1Input>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSchemaSettingsInSourceV1Input" /> class.
        /// </summary>
        /// <param name="track">track.</param>
        /// <param name="identify">identify.</param>
        /// <param name="group">group.</param>
        /// <param name="forwardingViolationsTo">Source id to forward violations to..</param>
        /// <param name="forwardingBlockedEventsTo">Source id to forward blocked events to..</param>
        public UpdateSchemaSettingsInSourceV1Input(TrackSourceSettingsV1 track = default(TrackSourceSettingsV1), IdentifySourceSettingsV1 identify = default(IdentifySourceSettingsV1), GroupSourceSettingsV1 group = default(GroupSourceSettingsV1), string forwardingViolationsTo = default(string), string forwardingBlockedEventsTo = default(string))
        {
            this.Track = track;
            this.Identify = identify;
            this.Group = group;
            this.ForwardingViolationsTo = forwardingViolationsTo;
            this.ForwardingBlockedEventsTo = forwardingBlockedEventsTo;
        }

        /// <summary>
        /// Gets or Sets Track
        /// </summary>
        [DataMember(Name = "track", EmitDefaultValue = false)]
        public TrackSourceSettingsV1 Track { get; set; }

        /// <summary>
        /// Gets or Sets Identify
        /// </summary>
        [DataMember(Name = "identify", EmitDefaultValue = false)]
        public IdentifySourceSettingsV1 Identify { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name = "group", EmitDefaultValue = false)]
        public GroupSourceSettingsV1 Group { get; set; }

        /// <summary>
        /// Source id to forward violations to.
        /// </summary>
        /// <value>Source id to forward violations to.</value>
        [DataMember(Name = "forwardingViolationsTo", EmitDefaultValue = false)]
        public string ForwardingViolationsTo { get; set; }

        /// <summary>
        /// Source id to forward blocked events to.
        /// </summary>
        /// <value>Source id to forward blocked events to.</value>
        [DataMember(Name = "forwardingBlockedEventsTo", EmitDefaultValue = false)]
        public string ForwardingBlockedEventsTo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateSchemaSettingsInSourceV1Input {\n");
            sb.Append("  Track: ").Append(Track).Append("\n");
            sb.Append("  Identify: ").Append(Identify).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  ForwardingViolationsTo: ").Append(ForwardingViolationsTo).Append("\n");
            sb.Append("  ForwardingBlockedEventsTo: ").Append(ForwardingBlockedEventsTo).Append("\n");
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
            return this.Equals(input as UpdateSchemaSettingsInSourceV1Input);
        }

        /// <summary>
        /// Returns true if UpdateSchemaSettingsInSourceV1Input instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateSchemaSettingsInSourceV1Input to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateSchemaSettingsInSourceV1Input input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Track == input.Track ||
                    (this.Track != null &&
                    this.Track.Equals(input.Track))
                ) && 
                (
                    this.Identify == input.Identify ||
                    (this.Identify != null &&
                    this.Identify.Equals(input.Identify))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.ForwardingViolationsTo == input.ForwardingViolationsTo ||
                    (this.ForwardingViolationsTo != null &&
                    this.ForwardingViolationsTo.Equals(input.ForwardingViolationsTo))
                ) && 
                (
                    this.ForwardingBlockedEventsTo == input.ForwardingBlockedEventsTo ||
                    (this.ForwardingBlockedEventsTo != null &&
                    this.ForwardingBlockedEventsTo.Equals(input.ForwardingBlockedEventsTo))
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
                if (this.Track != null)
                {
                    hashCode = (hashCode * 59) + this.Track.GetHashCode();
                }
                if (this.Identify != null)
                {
                    hashCode = (hashCode * 59) + this.Identify.GetHashCode();
                }
                if (this.Group != null)
                {
                    hashCode = (hashCode * 59) + this.Group.GetHashCode();
                }
                if (this.ForwardingViolationsTo != null)
                {
                    hashCode = (hashCode * 59) + this.ForwardingViolationsTo.GetHashCode();
                }
                if (this.ForwardingBlockedEventsTo != null)
                {
                    hashCode = (hashCode * 59) + this.ForwardingBlockedEventsTo.GetHashCode();
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
