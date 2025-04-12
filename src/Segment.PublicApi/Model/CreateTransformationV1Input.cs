/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.2.0
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
    /// The input to create a Transformation.
    /// </summary>
    [DataContract(Name = "CreateTransformationV1Input")]
    public partial class CreateTransformationV1Input : IEquatable<CreateTransformationV1Input>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTransformationV1Input" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTransformationV1Input() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTransformationV1Input" /> class.
        /// </summary>
        /// <param name="name">The name of the Transformation. (required).</param>
        /// <param name="sourceId">The Source to be associated with the Transformation. (required).</param>
        /// <param name="destinationMetadataId">The optional Destination metadata id to be associated with the Transformation..</param>
        /// <param name="enabled">If the Transformation should be enabled. (required).</param>
        /// <param name="varIf">If statement ([FQL](https://segment.com/docs/config-api/fql/)) to match events.  For standard event matchers, use the following:  Track -\\&gt; \&quot;event&#x3D;&#39;\\&lt;eventName\\&gt;&#39;\&quot;  Identify -\\&gt; \&quot;type&#x3D;&#39;identify&#39;\&quot;  Group -\\&gt; \&quot;type&#x3D;&#39;group&#39;\&quot; (required).</param>
        /// <param name="drop">Optional boolean value if the Transformation should drop the event entirely when the if statement matches, ignores all other transforms..</param>
        /// <param name="newEventName">Optional new event name for renaming events. Works only for &#39;track&#39; event type..</param>
        /// <param name="propertyRenames">Optional array for renaming properties collected by your events..</param>
        /// <param name="propertyValueTransformations">Optional array for transforming properties and values collected by your events. Limited to 10 properties..</param>
        /// <param name="fqlDefinedProperties">Optional array for defining new properties in [FQL](https://segment.com/docs/config-api/fql/). Currently limited to 1 property..</param>
        /// <param name="allowProperties">Optional array for allowing properties from your events..</param>
        /// <param name="hashPropertiesConfiguration">hashPropertiesConfiguration.</param>
        public CreateTransformationV1Input(string name = default(string), string sourceId = default(string), string destinationMetadataId = default(string), bool enabled = default(bool), string varIf = default(string), bool drop = default(bool), string newEventName = default(string), List<PropertyRenameV1> propertyRenames = default(List<PropertyRenameV1>), List<PropertyValueTransformationV1> propertyValueTransformations = default(List<PropertyValueTransformationV1>), List<FQLDefinedPropertyV1> fqlDefinedProperties = default(List<FQLDefinedPropertyV1>), List<string> allowProperties = default(List<string>), HashPropertiesConfiguration hashPropertiesConfiguration = default(HashPropertiesConfiguration))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateTransformationV1Input and cannot be null");
            }
            this.Name = name;
            // to ensure "sourceId" is required (not null)
            if (sourceId == null)
            {
                throw new ArgumentNullException("sourceId is a required property for CreateTransformationV1Input and cannot be null");
            }
            this.SourceId = sourceId;
            this.Enabled = enabled;
            // to ensure "varIf" is required (not null)
            if (varIf == null)
            {
                throw new ArgumentNullException("varIf is a required property for CreateTransformationV1Input and cannot be null");
            }
            this.VarIf = varIf;
            this.DestinationMetadataId = destinationMetadataId;
            this.Drop = drop;
            this.NewEventName = newEventName;
            this.PropertyRenames = propertyRenames;
            this.PropertyValueTransformations = propertyValueTransformations;
            this.FqlDefinedProperties = fqlDefinedProperties;
            this.AllowProperties = allowProperties;
            this.HashPropertiesConfiguration = hashPropertiesConfiguration;
        }

        /// <summary>
        /// The name of the Transformation.
        /// </summary>
        /// <value>The name of the Transformation.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The Source to be associated with the Transformation.
        /// </summary>
        /// <value>The Source to be associated with the Transformation.</value>
        [DataMember(Name = "sourceId", IsRequired = true, EmitDefaultValue = true)]
        public string SourceId { get; set; }

        /// <summary>
        /// The optional Destination metadata id to be associated with the Transformation.
        /// </summary>
        /// <value>The optional Destination metadata id to be associated with the Transformation.</value>
        [DataMember(Name = "destinationMetadataId", EmitDefaultValue = false)]
        public string DestinationMetadataId { get; set; }

        /// <summary>
        /// If the Transformation should be enabled.
        /// </summary>
        /// <value>If the Transformation should be enabled.</value>
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// If statement ([FQL](https://segment.com/docs/config-api/fql/)) to match events.  For standard event matchers, use the following:  Track -\\&gt; \&quot;event&#x3D;&#39;\\&lt;eventName\\&gt;&#39;\&quot;  Identify -\\&gt; \&quot;type&#x3D;&#39;identify&#39;\&quot;  Group -\\&gt; \&quot;type&#x3D;&#39;group&#39;\&quot;
        /// </summary>
        /// <value>If statement ([FQL](https://segment.com/docs/config-api/fql/)) to match events.  For standard event matchers, use the following:  Track -\\&gt; \&quot;event&#x3D;&#39;\\&lt;eventName\\&gt;&#39;\&quot;  Identify -\\&gt; \&quot;type&#x3D;&#39;identify&#39;\&quot;  Group -\\&gt; \&quot;type&#x3D;&#39;group&#39;\&quot;</value>
        [DataMember(Name = "if", IsRequired = true, EmitDefaultValue = true)]
        public string VarIf { get; set; }

        /// <summary>
        /// Optional boolean value if the Transformation should drop the event entirely when the if statement matches, ignores all other transforms.
        /// </summary>
        /// <value>Optional boolean value if the Transformation should drop the event entirely when the if statement matches, ignores all other transforms.</value>
        [DataMember(Name = "drop", EmitDefaultValue = true)]
        public bool Drop { get; set; }

        /// <summary>
        /// Optional new event name for renaming events. Works only for &#39;track&#39; event type.
        /// </summary>
        /// <value>Optional new event name for renaming events. Works only for &#39;track&#39; event type.</value>
        [DataMember(Name = "newEventName", EmitDefaultValue = false)]
        public string NewEventName { get; set; }

        /// <summary>
        /// Optional array for renaming properties collected by your events.
        /// </summary>
        /// <value>Optional array for renaming properties collected by your events.</value>
        [DataMember(Name = "propertyRenames", EmitDefaultValue = false)]
        public List<PropertyRenameV1> PropertyRenames { get; set; }

        /// <summary>
        /// Optional array for transforming properties and values collected by your events. Limited to 10 properties.
        /// </summary>
        /// <value>Optional array for transforming properties and values collected by your events. Limited to 10 properties.</value>
        [DataMember(Name = "propertyValueTransformations", EmitDefaultValue = false)]
        public List<PropertyValueTransformationV1> PropertyValueTransformations { get; set; }

        /// <summary>
        /// Optional array for defining new properties in [FQL](https://segment.com/docs/config-api/fql/). Currently limited to 1 property.
        /// </summary>
        /// <value>Optional array for defining new properties in [FQL](https://segment.com/docs/config-api/fql/). Currently limited to 1 property.</value>
        [DataMember(Name = "fqlDefinedProperties", EmitDefaultValue = false)]
        public List<FQLDefinedPropertyV1> FqlDefinedProperties { get; set; }

        /// <summary>
        /// Optional array for allowing properties from your events.
        /// </summary>
        /// <value>Optional array for allowing properties from your events.</value>
        [DataMember(Name = "allowProperties", EmitDefaultValue = false)]
        public List<string> AllowProperties { get; set; }

        /// <summary>
        /// Gets or Sets HashPropertiesConfiguration
        /// </summary>
        [DataMember(Name = "hashPropertiesConfiguration", EmitDefaultValue = false)]
        public HashPropertiesConfiguration HashPropertiesConfiguration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateTransformationV1Input {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  DestinationMetadataId: ").Append(DestinationMetadataId).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  VarIf: ").Append(VarIf).Append("\n");
            sb.Append("  Drop: ").Append(Drop).Append("\n");
            sb.Append("  NewEventName: ").Append(NewEventName).Append("\n");
            sb.Append("  PropertyRenames: ").Append(PropertyRenames).Append("\n");
            sb.Append("  PropertyValueTransformations: ").Append(PropertyValueTransformations).Append("\n");
            sb.Append("  FqlDefinedProperties: ").Append(FqlDefinedProperties).Append("\n");
            sb.Append("  AllowProperties: ").Append(AllowProperties).Append("\n");
            sb.Append("  HashPropertiesConfiguration: ").Append(HashPropertiesConfiguration).Append("\n");
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
            return this.Equals(input as CreateTransformationV1Input);
        }

        /// <summary>
        /// Returns true if CreateTransformationV1Input instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTransformationV1Input to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTransformationV1Input input)
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
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.DestinationMetadataId == input.DestinationMetadataId ||
                    (this.DestinationMetadataId != null &&
                    this.DestinationMetadataId.Equals(input.DestinationMetadataId))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.VarIf == input.VarIf ||
                    (this.VarIf != null &&
                    this.VarIf.Equals(input.VarIf))
                ) && 
                (
                    this.Drop == input.Drop ||
                    this.Drop.Equals(input.Drop)
                ) && 
                (
                    this.NewEventName == input.NewEventName ||
                    (this.NewEventName != null &&
                    this.NewEventName.Equals(input.NewEventName))
                ) && 
                (
                    this.PropertyRenames == input.PropertyRenames ||
                    this.PropertyRenames != null &&
                    input.PropertyRenames != null &&
                    this.PropertyRenames.SequenceEqual(input.PropertyRenames)
                ) && 
                (
                    this.PropertyValueTransformations == input.PropertyValueTransformations ||
                    this.PropertyValueTransformations != null &&
                    input.PropertyValueTransformations != null &&
                    this.PropertyValueTransformations.SequenceEqual(input.PropertyValueTransformations)
                ) && 
                (
                    this.FqlDefinedProperties == input.FqlDefinedProperties ||
                    this.FqlDefinedProperties != null &&
                    input.FqlDefinedProperties != null &&
                    this.FqlDefinedProperties.SequenceEqual(input.FqlDefinedProperties)
                ) && 
                (
                    this.AllowProperties == input.AllowProperties ||
                    this.AllowProperties != null &&
                    input.AllowProperties != null &&
                    this.AllowProperties.SequenceEqual(input.AllowProperties)
                ) && 
                (
                    this.HashPropertiesConfiguration == input.HashPropertiesConfiguration ||
                    (this.HashPropertiesConfiguration != null &&
                    this.HashPropertiesConfiguration.Equals(input.HashPropertiesConfiguration))
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
                if (this.SourceId != null)
                {
                    hashCode = (hashCode * 59) + this.SourceId.GetHashCode();
                }
                if (this.DestinationMetadataId != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationMetadataId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.VarIf != null)
                {
                    hashCode = (hashCode * 59) + this.VarIf.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Drop.GetHashCode();
                if (this.NewEventName != null)
                {
                    hashCode = (hashCode * 59) + this.NewEventName.GetHashCode();
                }
                if (this.PropertyRenames != null)
                {
                    hashCode = (hashCode * 59) + this.PropertyRenames.GetHashCode();
                }
                if (this.PropertyValueTransformations != null)
                {
                    hashCode = (hashCode * 59) + this.PropertyValueTransformations.GetHashCode();
                }
                if (this.FqlDefinedProperties != null)
                {
                    hashCode = (hashCode * 59) + this.FqlDefinedProperties.GetHashCode();
                }
                if (this.AllowProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AllowProperties.GetHashCode();
                }
                if (this.HashPropertiesConfiguration != null)
                {
                    hashCode = (hashCode * 59) + this.HashPropertiesConfiguration.GetHashCode();
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
