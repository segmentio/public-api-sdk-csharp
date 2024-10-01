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
    /// Verifies a set of Warehouse credentials by attempting to connect to it.
    /// </summary>
    [DataContract(Name = "CreateValidationInWarehouseV1Input")]
    public partial class CreateValidationInWarehouseV1Input : IEquatable<CreateValidationInWarehouseV1Input>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateValidationInWarehouseV1Input" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateValidationInWarehouseV1Input() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateValidationInWarehouseV1Input" /> class.
        /// </summary>
        /// <param name="metadataId">The id of the Warehouse metadata type. (required).</param>
        /// <param name="settings">A key-value object that contains instance-specific Warehouse settings. (required).</param>
        public CreateValidationInWarehouseV1Input(string metadataId = default(string), Dictionary<string, Object> settings = default(Dictionary<string, Object>))
        {
            // to ensure "metadataId" is required (not null)
            if (metadataId == null)
            {
                throw new ArgumentNullException("metadataId is a required property for CreateValidationInWarehouseV1Input and cannot be null");
            }
            this.MetadataId = metadataId;
            // to ensure "settings" is required (not null)
            if (settings == null)
            {
                throw new ArgumentNullException("settings is a required property for CreateValidationInWarehouseV1Input and cannot be null");
            }
            this.Settings = settings;
        }

        /// <summary>
        /// The id of the Warehouse metadata type.
        /// </summary>
        /// <value>The id of the Warehouse metadata type.</value>
        [DataMember(Name = "metadataId", IsRequired = true, EmitDefaultValue = true)]
        public string MetadataId { get; set; }

        /// <summary>
        /// A key-value object that contains instance-specific Warehouse settings.
        /// </summary>
        /// <value>A key-value object that contains instance-specific Warehouse settings.</value>
        [DataMember(Name = "settings", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> Settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateValidationInWarehouseV1Input {\n");
            sb.Append("  MetadataId: ").Append(MetadataId).Append("\n");
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
            return this.Equals(input as CreateValidationInWarehouseV1Input);
        }

        /// <summary>
        /// Returns true if CreateValidationInWarehouseV1Input instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateValidationInWarehouseV1Input to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateValidationInWarehouseV1Input input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MetadataId == input.MetadataId ||
                    (this.MetadataId != null &&
                    this.MetadataId.Equals(input.MetadataId))
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
                if (this.MetadataId != null)
                {
                    hashCode = (hashCode * 59) + this.MetadataId.GetHashCode();
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
