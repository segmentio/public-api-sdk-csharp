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
    /// Represents an Action, a building block of behavior that can be performed by the Destination.
    /// </summary>
    [DataContract(Name = "DestinationMetadataActionV1")]
    public partial class DestinationMetadataActionV1 : IEquatable<DestinationMetadataActionV1>, IValidatableObject
    {
        /// <summary>
        /// The platform on which this action runs.
        /// </summary>
        /// <value>The platform on which this action runs.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PlatformEnum
        {
            /// <summary>
            /// Enum CLOUD for value: CLOUD
            /// </summary>
            [EnumMember(Value = "CLOUD")]
            CLOUD = 1,

            /// <summary>
            /// Enum MOBILE for value: MOBILE
            /// </summary>
            [EnumMember(Value = "MOBILE")]
            MOBILE = 2,

            /// <summary>
            /// Enum WEB for value: WEB
            /// </summary>
            [EnumMember(Value = "WEB")]
            WEB = 3
        }


        /// <summary>
        /// The platform on which this action runs.
        /// </summary>
        /// <value>The platform on which this action runs.</value>
        [DataMember(Name = "platform", IsRequired = true, EmitDefaultValue = true)]
        public PlatformEnum Platform { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationMetadataActionV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DestinationMetadataActionV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationMetadataActionV1" /> class.
        /// </summary>
        /// <param name="id">The primary key of the action. (required).</param>
        /// <param name="slug">A machine-readable key unique to the action definition. (required).</param>
        /// <param name="name">A human-readable name for the action. (required).</param>
        /// <param name="description">A human-readable description of the action. May include Markdown. (required).</param>
        /// <param name="platform">The platform on which this action runs. (required).</param>
        /// <param name="hidden">Whether the action should be hidden. (required).</param>
        /// <param name="defaultTrigger">The default value used as the trigger when connecting this action. (required).</param>
        /// <param name="fields">The fields expected in order to perform the action. (required).</param>
        public DestinationMetadataActionV1(string id = default(string), string slug = default(string), string name = default(string), string description = default(string), PlatformEnum platform = default(PlatformEnum), bool hidden = default(bool), string defaultTrigger = default(string), List<DestinationMetadataActionFieldV1> fields = default(List<DestinationMetadataActionFieldV1>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for DestinationMetadataActionV1 and cannot be null");
            }
            this.Id = id;
            // to ensure "slug" is required (not null)
            if (slug == null)
            {
                throw new ArgumentNullException("slug is a required property for DestinationMetadataActionV1 and cannot be null");
            }
            this.Slug = slug;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for DestinationMetadataActionV1 and cannot be null");
            }
            this.Name = name;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for DestinationMetadataActionV1 and cannot be null");
            }
            this.Description = description;
            this.Platform = platform;
            this.Hidden = hidden;
            // to ensure "defaultTrigger" is required (not null)
            if (defaultTrigger == null)
            {
                throw new ArgumentNullException("defaultTrigger is a required property for DestinationMetadataActionV1 and cannot be null");
            }
            this.DefaultTrigger = defaultTrigger;
            // to ensure "fields" is required (not null)
            if (fields == null)
            {
                throw new ArgumentNullException("fields is a required property for DestinationMetadataActionV1 and cannot be null");
            }
            this.Fields = fields;
        }

        /// <summary>
        /// The primary key of the action.
        /// </summary>
        /// <value>The primary key of the action.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// A machine-readable key unique to the action definition.
        /// </summary>
        /// <value>A machine-readable key unique to the action definition.</value>
        [DataMember(Name = "slug", IsRequired = true, EmitDefaultValue = true)]
        public string Slug { get; set; }

        /// <summary>
        /// A human-readable name for the action.
        /// </summary>
        /// <value>A human-readable name for the action.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// A human-readable description of the action. May include Markdown.
        /// </summary>
        /// <value>A human-readable description of the action. May include Markdown.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Whether the action should be hidden.
        /// </summary>
        /// <value>Whether the action should be hidden.</value>
        [DataMember(Name = "hidden", IsRequired = true, EmitDefaultValue = true)]
        public bool Hidden { get; set; }

        /// <summary>
        /// The default value used as the trigger when connecting this action.
        /// </summary>
        /// <value>The default value used as the trigger when connecting this action.</value>
        [DataMember(Name = "defaultTrigger", IsRequired = true, EmitDefaultValue = true)]
        public string DefaultTrigger { get; set; }

        /// <summary>
        /// The fields expected in order to perform the action.
        /// </summary>
        /// <value>The fields expected in order to perform the action.</value>
        [DataMember(Name = "fields", IsRequired = true, EmitDefaultValue = true)]
        public List<DestinationMetadataActionFieldV1> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinationMetadataActionV1 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
            sb.Append("  DefaultTrigger: ").Append(DefaultTrigger).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
            return this.Equals(input as DestinationMetadataActionV1);
        }

        /// <summary>
        /// Returns true if DestinationMetadataActionV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinationMetadataActionV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinationMetadataActionV1 input)
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
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Platform == input.Platform ||
                    this.Platform.Equals(input.Platform)
                ) && 
                (
                    this.Hidden == input.Hidden ||
                    this.Hidden.Equals(input.Hidden)
                ) && 
                (
                    this.DefaultTrigger == input.DefaultTrigger ||
                    (this.DefaultTrigger != null &&
                    this.DefaultTrigger.Equals(input.DefaultTrigger))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
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
                if (this.Slug != null)
                {
                    hashCode = (hashCode * 59) + this.Slug.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Platform.GetHashCode();
                hashCode = (hashCode * 59) + this.Hidden.GetHashCode();
                if (this.DefaultTrigger != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultTrigger.GetHashCode();
                }
                if (this.Fields != null)
                {
                    hashCode = (hashCode * 59) + this.Fields.GetHashCode();
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
