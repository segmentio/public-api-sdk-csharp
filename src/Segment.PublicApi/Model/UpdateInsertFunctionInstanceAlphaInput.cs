/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.0.0
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
    /// Updates an insert Function instance.
    /// </summary>
    [DataContract(Name = "UpdateInsertFunctionInstanceAlphaInput")]
    public partial class UpdateInsertFunctionInstanceAlphaInput : IEquatable<UpdateInsertFunctionInstanceAlphaInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInsertFunctionInstanceAlphaInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateInsertFunctionInstanceAlphaInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInsertFunctionInstanceAlphaInput" /> class.
        /// </summary>
        /// <param name="enabled">Whether this insert Function instance should be enabled for the Destination..</param>
        /// <param name="name">Defines the display name of the insert Function instance..</param>
        /// <param name="settings">An object that contains settings for this insert Function instance based on the settings present in the insert Function class. (required).</param>
        public UpdateInsertFunctionInstanceAlphaInput(bool enabled = default(bool), string name = default(string), Dictionary<string, Object> settings = default(Dictionary<string, Object>))
        {
            // to ensure "settings" is required (not null)
            if (settings == null)
            {
                throw new ArgumentNullException("settings is a required property for UpdateInsertFunctionInstanceAlphaInput and cannot be null");
            }
            this.Settings = settings;
            this.Enabled = enabled;
            this.Name = name;
        }

        /// <summary>
        /// Whether this insert Function instance should be enabled for the Destination.
        /// </summary>
        /// <value>Whether this insert Function instance should be enabled for the Destination.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Defines the display name of the insert Function instance.
        /// </summary>
        /// <value>Defines the display name of the insert Function instance.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// An object that contains settings for this insert Function instance based on the settings present in the insert Function class.
        /// </summary>
        /// <value>An object that contains settings for this insert Function instance based on the settings present in the insert Function class.</value>
        [DataMember(Name = "settings", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> Settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateInsertFunctionInstanceAlphaInput {\n");
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
            return this.Equals(input as UpdateInsertFunctionInstanceAlphaInput);
        }

        /// <summary>
        /// Returns true if UpdateInsertFunctionInstanceAlphaInput instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateInsertFunctionInstanceAlphaInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateInsertFunctionInstanceAlphaInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
