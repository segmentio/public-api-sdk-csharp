/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 57.0.1
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
    /// Creates a new Destination.
    /// </summary>
    [DataContract(Name = "CreateDestinationV1Input")]
    public partial class CreateDestinationV1Input : IEquatable<CreateDestinationV1Input>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDestinationV1Input" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateDestinationV1Input() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDestinationV1Input" /> class.
        /// </summary>
        /// <param name="sourceId">The id of the Source to connect to this Destination instance.  Config API note: analogous to &#x60;parent&#x60;. (required).</param>
        /// <param name="metadataId">The id of the metadata to link to the new Destination. (required).</param>
        /// <param name="enabled">Whether this Destination should receive data..</param>
        /// <param name="name">Defines the display name of the Destination.  Config API note: equal to &#x60;displayName&#x60;..</param>
        /// <param name="settings">An object that contains settings for the Destination based on the \&quot;required\&quot; and \&quot;advanced\&quot; settings present in the Destination metadata.  Config API note: equal to &#x60;config&#x60;. (required).</param>
        public CreateDestinationV1Input(string sourceId = default(string), string metadataId = default(string), bool enabled = default(bool), string name = default(string), Dictionary<string, Object> settings = default(Dictionary<string, Object>))
        {
            // to ensure "sourceId" is required (not null)
            if (sourceId == null)
            {
                throw new ArgumentNullException("sourceId is a required property for CreateDestinationV1Input and cannot be null");
            }
            this.SourceId = sourceId;
            // to ensure "metadataId" is required (not null)
            if (metadataId == null)
            {
                throw new ArgumentNullException("metadataId is a required property for CreateDestinationV1Input and cannot be null");
            }
            this.MetadataId = metadataId;
            // to ensure "settings" is required (not null)
            if (settings == null)
            {
                throw new ArgumentNullException("settings is a required property for CreateDestinationV1Input and cannot be null");
            }
            this.Settings = settings;
            this.Enabled = enabled;
            this.Name = name;
        }

        /// <summary>
        /// The id of the Source to connect to this Destination instance.  Config API note: analogous to &#x60;parent&#x60;.
        /// </summary>
        /// <value>The id of the Source to connect to this Destination instance.  Config API note: analogous to &#x60;parent&#x60;.</value>
        [DataMember(Name = "sourceId", IsRequired = true, EmitDefaultValue = true)]
        public string SourceId { get; set; }

        /// <summary>
        /// The id of the metadata to link to the new Destination.
        /// </summary>
        /// <value>The id of the metadata to link to the new Destination.</value>
        [DataMember(Name = "metadataId", IsRequired = true, EmitDefaultValue = true)]
        public string MetadataId { get; set; }

        /// <summary>
        /// Whether this Destination should receive data.
        /// </summary>
        /// <value>Whether this Destination should receive data.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Defines the display name of the Destination.  Config API note: equal to &#x60;displayName&#x60;.
        /// </summary>
        /// <value>Defines the display name of the Destination.  Config API note: equal to &#x60;displayName&#x60;.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// An object that contains settings for the Destination based on the \&quot;required\&quot; and \&quot;advanced\&quot; settings present in the Destination metadata.  Config API note: equal to &#x60;config&#x60;.
        /// </summary>
        /// <value>An object that contains settings for the Destination based on the \&quot;required\&quot; and \&quot;advanced\&quot; settings present in the Destination metadata.  Config API note: equal to &#x60;config&#x60;.</value>
        [DataMember(Name = "settings", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> Settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateDestinationV1Input {\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  MetadataId: ").Append(MetadataId).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
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
            return this.Equals(input as CreateDestinationV1Input);
        }

        /// <summary>
        /// Returns true if CreateDestinationV1Input instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateDestinationV1Input to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDestinationV1Input input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.MetadataId == input.MetadataId ||
                    (this.MetadataId != null &&
                    this.MetadataId.Equals(input.MetadataId))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Settings == input.Settings ||
                    this.Settings != null &&
                    input.Settings != null &&
                    this.Settings.SequenceEqual(input.Settings)
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
                if (this.SourceId != null)
                {
                    hashCode = (hashCode * 59) + this.SourceId.GetHashCode();
                }
                if (this.MetadataId != null)
                {
                    hashCode = (hashCode * 59) + this.MetadataId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Settings != null)
                {
                    hashCode = (hashCode * 59) + this.Settings.GetHashCode();
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
