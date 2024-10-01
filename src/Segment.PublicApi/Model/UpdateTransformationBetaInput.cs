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
    /// The input to update a Transformation.
    /// </summary>
    [DataContract(Name = "UpdateTransformationBetaInput")]
    public partial class UpdateTransformationBetaInput : IEquatable<UpdateTransformationBetaInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTransformationBetaInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateTransformationBetaInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTransformationBetaInput" /> class.
        /// </summary>
        /// <param name="transformationId">ID of the Transformation to update. (required).</param>
        /// <param name="name">The name of the Transformation..</param>
        /// <param name="sourceId">The optional Source to be associated with the Transformation..</param>
        /// <param name="destinationMetadataId">The optional Destination metadata to be associated with the Transformation..</param>
        /// <param name="enabled">If the Transformation should be enabled..</param>
        /// <param name="varIf">If statement ([FQL](https://segment.com/docs/config-api/fql/)) to match events.  For standard event matchers, use the following:  Track -\\&gt; \&quot;event&#x3D;&#39;\\&lt;eventName\\&gt;&#39;\&quot;  Identify -\\&gt; \&quot;type&#x3D;&#39;identify&#39;\&quot;  Group -\\&gt; \&quot;type&#x3D;&#39;group&#39;\&quot;.</param>
        /// <param name="newEventName">Optional new event name for renaming events. Works only for &#39;track&#39; event type..</param>
        /// <param name="propertyRenames">Optional array for renaming properties collected by your events..</param>
        /// <param name="propertyValueTransformations">Optional array for transforming properties and values collected by your events. Limited to 10 properties..</param>
        public UpdateTransformationBetaInput(string transformationId = default(string), string name = default(string), string sourceId = default(string), string destinationMetadataId = default(string), bool enabled = default(bool), string varIf = default(string), string newEventName = default(string), List<PropertyRenameBeta> propertyRenames = default(List<PropertyRenameBeta>), List<PropertyValueTransformationBeta> propertyValueTransformations = default(List<PropertyValueTransformationBeta>))
        {
            // to ensure "transformationId" is required (not null)
            if (transformationId == null)
            {
                throw new ArgumentNullException("transformationId is a required property for UpdateTransformationBetaInput and cannot be null");
            }
            this.TransformationId = transformationId;
            this.Name = name;
            this.SourceId = sourceId;
            this.DestinationMetadataId = destinationMetadataId;
            this.Enabled = enabled;
            this.VarIf = varIf;
            this.NewEventName = newEventName;
            this.PropertyRenames = propertyRenames;
            this.PropertyValueTransformations = propertyValueTransformations;
        }

        /// <summary>
        /// ID of the Transformation to update.
        /// </summary>
        /// <value>ID of the Transformation to update.</value>
        [DataMember(Name = "transformationId", IsRequired = true, EmitDefaultValue = true)]
        public string TransformationId { get; set; }

        /// <summary>
        /// The name of the Transformation.
        /// </summary>
        /// <value>The name of the Transformation.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The optional Source to be associated with the Transformation.
        /// </summary>
        /// <value>The optional Source to be associated with the Transformation.</value>
        [DataMember(Name = "sourceId", EmitDefaultValue = false)]
        public string SourceId { get; set; }

        /// <summary>
        /// The optional Destination metadata to be associated with the Transformation.
        /// </summary>
        /// <value>The optional Destination metadata to be associated with the Transformation.</value>
        [DataMember(Name = "destinationMetadataId", EmitDefaultValue = false)]
        public string DestinationMetadataId { get; set; }

        /// <summary>
        /// If the Transformation should be enabled.
        /// </summary>
        /// <value>If the Transformation should be enabled.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// If statement ([FQL](https://segment.com/docs/config-api/fql/)) to match events.  For standard event matchers, use the following:  Track -\\&gt; \&quot;event&#x3D;&#39;\\&lt;eventName\\&gt;&#39;\&quot;  Identify -\\&gt; \&quot;type&#x3D;&#39;identify&#39;\&quot;  Group -\\&gt; \&quot;type&#x3D;&#39;group&#39;\&quot;
        /// </summary>
        /// <value>If statement ([FQL](https://segment.com/docs/config-api/fql/)) to match events.  For standard event matchers, use the following:  Track -\\&gt; \&quot;event&#x3D;&#39;\\&lt;eventName\\&gt;&#39;\&quot;  Identify -\\&gt; \&quot;type&#x3D;&#39;identify&#39;\&quot;  Group -\\&gt; \&quot;type&#x3D;&#39;group&#39;\&quot;</value>
        [DataMember(Name = "if", EmitDefaultValue = false)]
        public string VarIf { get; set; }

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
        public List<PropertyRenameBeta> PropertyRenames { get; set; }

        /// <summary>
        /// Optional array for transforming properties and values collected by your events. Limited to 10 properties.
        /// </summary>
        /// <value>Optional array for transforming properties and values collected by your events. Limited to 10 properties.</value>
        [DataMember(Name = "propertyValueTransformations", EmitDefaultValue = false)]
        public List<PropertyValueTransformationBeta> PropertyValueTransformations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateTransformationBetaInput {\n");
            sb.Append("  TransformationId: ").Append(TransformationId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  DestinationMetadataId: ").Append(DestinationMetadataId).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  VarIf: ").Append(VarIf).Append("\n");
            sb.Append("  NewEventName: ").Append(NewEventName).Append("\n");
            sb.Append("  PropertyRenames: ").Append(PropertyRenames).Append("\n");
            sb.Append("  PropertyValueTransformations: ").Append(PropertyValueTransformations).Append("\n");
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
            return this.Equals(input as UpdateTransformationBetaInput);
        }

        /// <summary>
        /// Returns true if UpdateTransformationBetaInput instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateTransformationBetaInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateTransformationBetaInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TransformationId == input.TransformationId ||
                    (this.TransformationId != null &&
                    this.TransformationId.Equals(input.TransformationId))
                ) && 
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
                if (this.TransformationId != null)
                {
                    hashCode = (hashCode * 59) + this.TransformationId.GetHashCode();
                }
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
