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
    /// Returns a Source.
    /// </summary>
    [DataContract(Name = "GetSourceAlphaOutput")]
    public partial class GetSourceAlphaOutput : IEquatable<GetSourceAlphaOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSourceAlphaOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetSourceAlphaOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSourceAlphaOutput" /> class.
        /// </summary>
        /// <param name="source">source (required).</param>
        /// <param name="trackingPlanId">The id of the Tracking Plan connected to the Source. (required).</param>
        public GetSourceAlphaOutput(SourceAlpha source = default(SourceAlpha), string trackingPlanId = default(string))
        {
            // to ensure "source" is required (not null)
            if (source == null)
            {
                throw new ArgumentNullException("source is a required property for GetSourceAlphaOutput and cannot be null");
            }
            this.Source = source;
            // to ensure "trackingPlanId" is required (not null)
            if (trackingPlanId == null)
            {
                throw new ArgumentNullException("trackingPlanId is a required property for GetSourceAlphaOutput and cannot be null");
            }
            this.TrackingPlanId = trackingPlanId;
        }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", IsRequired = true, EmitDefaultValue = true)]
        public SourceAlpha Source { get; set; }

        /// <summary>
        /// The id of the Tracking Plan connected to the Source.
        /// </summary>
        /// <value>The id of the Tracking Plan connected to the Source.</value>
        [DataMember(Name = "trackingPlanId", IsRequired = true, EmitDefaultValue = true)]
        public string TrackingPlanId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetSourceAlphaOutput {\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  TrackingPlanId: ").Append(TrackingPlanId).Append("\n");
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
            return this.Equals(input as GetSourceAlphaOutput);
        }

        /// <summary>
        /// Returns true if GetSourceAlphaOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSourceAlphaOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSourceAlphaOutput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.TrackingPlanId == input.TrackingPlanId ||
                    (this.TrackingPlanId != null &&
                    this.TrackingPlanId.Equals(input.TrackingPlanId))
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
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                if (this.TrackingPlanId != null)
                {
                    hashCode = (hashCode * 59) + this.TrackingPlanId.GetHashCode();
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
