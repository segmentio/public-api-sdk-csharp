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
    /// Creates an insert Function instance.
    /// </summary>
    [DataContract(Name = "CreateInsertFunctionInstanceAlphaInput")]
    public partial class CreateInsertFunctionInstanceAlphaInput : IEquatable<CreateInsertFunctionInstanceAlphaInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInsertFunctionInstanceAlphaInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateInsertFunctionInstanceAlphaInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInsertFunctionInstanceAlphaInput" /> class.
        /// </summary>
        /// <param name="functionId">Insert Function id to which this instance is associated. (required).</param>
        /// <param name="integrationId">The Source or Destination id to be connected. (required).</param>
        /// <param name="enabled">Whether this insert Function instance should be enabled for the Destination..</param>
        /// <param name="name">Defines the display name of the insert Function instance. (required).</param>
        /// <param name="settings">An object that contains settings for this insert Function instance based on the settings present in the insert Function class. (required).</param>
        public CreateInsertFunctionInstanceAlphaInput(string functionId = default(string), string integrationId = default(string), bool enabled = default(bool), string name = default(string), Dictionary<string, Object> settings = default(Dictionary<string, Object>))
        {
            // to ensure "functionId" is required (not null)
            if (functionId == null)
            {
                throw new ArgumentNullException("functionId is a required property for CreateInsertFunctionInstanceAlphaInput and cannot be null");
            }
            this.FunctionId = functionId;
            // to ensure "integrationId" is required (not null)
            if (integrationId == null)
            {
                throw new ArgumentNullException("integrationId is a required property for CreateInsertFunctionInstanceAlphaInput and cannot be null");
            }
            this.IntegrationId = integrationId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateInsertFunctionInstanceAlphaInput and cannot be null");
            }
            this.Name = name;
            // to ensure "settings" is required (not null)
            if (settings == null)
            {
                throw new ArgumentNullException("settings is a required property for CreateInsertFunctionInstanceAlphaInput and cannot be null");
            }
            this.Settings = settings;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Insert Function id to which this instance is associated.
        /// </summary>
        /// <value>Insert Function id to which this instance is associated.</value>
        [DataMember(Name = "functionId", IsRequired = true, EmitDefaultValue = true)]
        public string FunctionId { get; set; }

        /// <summary>
        /// The Source or Destination id to be connected.
        /// </summary>
        /// <value>The Source or Destination id to be connected.</value>
        [DataMember(Name = "integrationId", IsRequired = true, EmitDefaultValue = true)]
        public string IntegrationId { get; set; }

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
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
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
            sb.Append("class CreateInsertFunctionInstanceAlphaInput {\n");
            sb.Append("  FunctionId: ").Append(FunctionId).Append("\n");
            sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
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
            return this.Equals(input as CreateInsertFunctionInstanceAlphaInput);
        }

        /// <summary>
        /// Returns true if CreateInsertFunctionInstanceAlphaInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateInsertFunctionInstanceAlphaInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateInsertFunctionInstanceAlphaInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FunctionId == input.FunctionId ||
                    (this.FunctionId != null &&
                    this.FunctionId.Equals(input.FunctionId))
                ) && 
                (
                    this.IntegrationId == input.IntegrationId ||
                    (this.IntegrationId != null &&
                    this.IntegrationId.Equals(input.IntegrationId))
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
                if (this.FunctionId != null)
                {
                    hashCode = (hashCode * 59) + this.FunctionId.GetHashCode();
                }
                if (this.IntegrationId != null)
                {
                    hashCode = (hashCode * 59) + this.IntegrationId.GetHashCode();
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
