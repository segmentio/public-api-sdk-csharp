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
    /// Output of the Source with updated settings.
    /// </summary>
    [DataContract(Name = "UpdateSchemaSettingsInSourceV1Output")]
    public partial class UpdateSchemaSettingsInSourceV1Output : IEquatable<UpdateSchemaSettingsInSourceV1Output>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSchemaSettingsInSourceV1Output" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateSchemaSettingsInSourceV1Output() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSchemaSettingsInSourceV1Output" /> class.
        /// </summary>
        /// <param name="sourceId">The id of the updated Source.  Config API note: analogous to &#x60;parent&#x60; and &#x60;name&#x60;. (required).</param>
        /// <param name="settings">settings (required).</param>
        public UpdateSchemaSettingsInSourceV1Output(string sourceId = default(string), SourceSettingsOutputV1 settings = default(SourceSettingsOutputV1))
        {
            // to ensure "sourceId" is required (not null)
            if (sourceId == null)
            {
                throw new ArgumentNullException("sourceId is a required property for UpdateSchemaSettingsInSourceV1Output and cannot be null");
            }
            this.SourceId = sourceId;
            // to ensure "settings" is required (not null)
            if (settings == null)
            {
                throw new ArgumentNullException("settings is a required property for UpdateSchemaSettingsInSourceV1Output and cannot be null");
            }
            this.Settings = settings;
        }

        /// <summary>
        /// The id of the updated Source.  Config API note: analogous to &#x60;parent&#x60; and &#x60;name&#x60;.
        /// </summary>
        /// <value>The id of the updated Source.  Config API note: analogous to &#x60;parent&#x60; and &#x60;name&#x60;.</value>
        [DataMember(Name = "sourceId", IsRequired = true, EmitDefaultValue = true)]
        public string SourceId { get; set; }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name = "settings", IsRequired = true, EmitDefaultValue = true)]
        public SourceSettingsOutputV1 Settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateSchemaSettingsInSourceV1Output {\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
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
            return this.Equals(input as UpdateSchemaSettingsInSourceV1Output);
        }

        /// <summary>
        /// Returns true if UpdateSchemaSettingsInSourceV1Output instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateSchemaSettingsInSourceV1Output to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateSchemaSettingsInSourceV1Output input)
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
                    this.Settings == input.Settings ||
                    (this.Settings != null &&
                    this.Settings.Equals(input.Settings))
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
