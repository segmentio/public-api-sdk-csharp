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
    /// Connects a Source to a Tracking Plan.
    /// </summary>
    [DataContract(Name = "AddSourceToTrackingPlanV1Input")]
    public partial class AddSourceToTrackingPlanV1Input : IEquatable<AddSourceToTrackingPlanV1Input>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddSourceToTrackingPlanV1Input" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddSourceToTrackingPlanV1Input() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddSourceToTrackingPlanV1Input" /> class.
        /// </summary>
        /// <param name="sourceId">The id of the Source associated with the Tracking Plan.  Config API note: analogous to &#x60;sourceName&#x60;. (required).</param>
        public AddSourceToTrackingPlanV1Input(string sourceId = default(string))
        {
            // to ensure "sourceId" is required (not null)
            if (sourceId == null)
            {
                throw new ArgumentNullException("sourceId is a required property for AddSourceToTrackingPlanV1Input and cannot be null");
            }
            this.SourceId = sourceId;
        }

        /// <summary>
        /// The id of the Source associated with the Tracking Plan.  Config API note: analogous to &#x60;sourceName&#x60;.
        /// </summary>
        /// <value>The id of the Source associated with the Tracking Plan.  Config API note: analogous to &#x60;sourceName&#x60;.</value>
        [DataMember(Name = "sourceId", IsRequired = true, EmitDefaultValue = true)]
        public string SourceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddSourceToTrackingPlanV1Input {\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
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
            return this.Equals(input as AddSourceToTrackingPlanV1Input);
        }

        /// <summary>
        /// Returns true if AddSourceToTrackingPlanV1Input instances are equal
        /// </summary>
        /// <param name="input">Instance of AddSourceToTrackingPlanV1Input to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddSourceToTrackingPlanV1Input input)
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
