/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.1.1
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
    /// AudienceEntryState
    /// </summary>
    [DataContract(Name = "AudienceEntryState")]
    public partial class AudienceEntryState : IEquatable<AudienceEntryState>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum AUDIENCEENTRY for value: AUDIENCE_ENTRY
            /// </summary>
            [EnumMember(Value = "AUDIENCE_ENTRY")]
            AUDIENCEENTRY = 1
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AudienceEntryState" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AudienceEntryState() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AudienceEntryState" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="audienceId">audienceId (required).</param>
        /// <param name="transitions">transitions (required).</param>
        /// <param name="key">key (required).</param>
        public AudienceEntryState(TypeEnum type = default(TypeEnum), string audienceId = default(string), List<Transitions> transitions = default(List<Transitions>), Key key = default(Key))
        {
            this.Type = type;
            // to ensure "audienceId" is required (not null)
            if (audienceId == null)
            {
                throw new ArgumentNullException("audienceId is a required property for AudienceEntryState and cannot be null");
            }
            this.AudienceId = audienceId;
            // to ensure "transitions" is required (not null)
            if (transitions == null)
            {
                throw new ArgumentNullException("transitions is a required property for AudienceEntryState and cannot be null");
            }
            this.Transitions = transitions;
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for AudienceEntryState and cannot be null");
            }
            this.Key = key;
        }

        /// <summary>
        /// Gets or Sets AudienceId
        /// </summary>
        [DataMember(Name = "audienceId", IsRequired = true, EmitDefaultValue = true)]
        public string AudienceId { get; set; }

        /// <summary>
        /// Gets or Sets Transitions
        /// </summary>
        [DataMember(Name = "transitions", IsRequired = true, EmitDefaultValue = true)]
        public List<Transitions> Transitions { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public Key Key { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AudienceEntryState {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AudienceId: ").Append(AudienceId).Append("\n");
            sb.Append("  Transitions: ").Append(Transitions).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
            return this.Equals(input as AudienceEntryState);
        }

        /// <summary>
        /// Returns true if AudienceEntryState instances are equal
        /// </summary>
        /// <param name="input">Instance of AudienceEntryState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AudienceEntryState input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.AudienceId == input.AudienceId ||
                    (this.AudienceId != null &&
                    this.AudienceId.Equals(input.AudienceId))
                ) && 
                (
                    this.Transitions == input.Transitions ||
                    this.Transitions != null &&
                    input.Transitions != null &&
                    this.Transitions.SequenceEqual(input.Transitions)
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.AudienceId != null)
                {
                    hashCode = (hashCode * 59) + this.AudienceId.GetHashCode();
                }
                if (this.Transitions != null)
                {
                    hashCode = (hashCode * 59) + this.Transitions.GetHashCode();
                }
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
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
