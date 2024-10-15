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
    /// Updates a Profiles Warehouse based on a set of parameters.
    /// </summary>
    [DataContract(Name = "UpdateProfilesWarehouseForSpaceWarehouseAlphaInput")]
    public partial class UpdateProfilesWarehouseForSpaceWarehouseAlphaInput : IEquatable<UpdateProfilesWarehouseForSpaceWarehouseAlphaInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProfilesWarehouseForSpaceWarehouseAlphaInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateProfilesWarehouseForSpaceWarehouseAlphaInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProfilesWarehouseForSpaceWarehouseAlphaInput" /> class.
        /// </summary>
        /// <param name="name">An optional human-readable name for this Warehouse..</param>
        /// <param name="enabled">Enable to allow this Warehouse to receive data. Defaults to true..</param>
        /// <param name="settings">A key-value object that contains instance-specific Warehouse settings. (required).</param>
        /// <param name="schemaName">The custom schema name that Segment uses on the Warehouse side. The space slug value is default otherwise..</param>
        public UpdateProfilesWarehouseForSpaceWarehouseAlphaInput(string name = default(string), bool enabled = default(bool), Dictionary<string, Object> settings = default(Dictionary<string, Object>), string schemaName = default(string))
        {
            // to ensure "settings" is required (not null)
            if (settings == null)
            {
                throw new ArgumentNullException("settings is a required property for UpdateProfilesWarehouseForSpaceWarehouseAlphaInput and cannot be null");
            }
            this.Settings = settings;
            this.Name = name;
            this.Enabled = enabled;
            this.SchemaName = schemaName;
        }

        /// <summary>
        /// An optional human-readable name for this Warehouse.
        /// </summary>
        /// <value>An optional human-readable name for this Warehouse.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Enable to allow this Warehouse to receive data. Defaults to true.
        /// </summary>
        /// <value>Enable to allow this Warehouse to receive data. Defaults to true.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// A key-value object that contains instance-specific Warehouse settings.
        /// </summary>
        /// <value>A key-value object that contains instance-specific Warehouse settings.</value>
        [DataMember(Name = "settings", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> Settings { get; set; }

        /// <summary>
        /// The custom schema name that Segment uses on the Warehouse side. The space slug value is default otherwise.
        /// </summary>
        /// <value>The custom schema name that Segment uses on the Warehouse side. The space slug value is default otherwise.</value>
        [DataMember(Name = "schemaName", EmitDefaultValue = false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateProfilesWarehouseForSpaceWarehouseAlphaInput {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  SchemaName: ").Append(SchemaName).Append("\n");
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
            return this.Equals(input as UpdateProfilesWarehouseForSpaceWarehouseAlphaInput);
        }

        /// <summary>
        /// Returns true if UpdateProfilesWarehouseForSpaceWarehouseAlphaInput instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateProfilesWarehouseForSpaceWarehouseAlphaInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateProfilesWarehouseForSpaceWarehouseAlphaInput input)
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
                    this.SchemaName == input.SchemaName ||
                    (this.SchemaName != null &&
                    this.SchemaName.Equals(input.SchemaName))
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
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.Settings != null)
                {
                    hashCode = (hashCode * 59) + this.Settings.GetHashCode();
                }
                if (this.SchemaName != null)
                {
                    hashCode = (hashCode * 59) + this.SchemaName.GetHashCode();
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
