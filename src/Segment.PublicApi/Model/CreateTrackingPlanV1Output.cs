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
    /// Result of a CreateTrackingPlan call.
    /// </summary>
    [DataContract(Name = "CreateTrackingPlanV1Output")]
    public partial class CreateTrackingPlanV1Output : IEquatable<CreateTrackingPlanV1Output>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrackingPlanV1Output" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTrackingPlanV1Output() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrackingPlanV1Output" /> class.
        /// </summary>
        /// <param name="trackingPlan">trackingPlan (required).</param>
        public CreateTrackingPlanV1Output(TrackingPlanV1 trackingPlan = default(TrackingPlanV1))
        {
            // to ensure "trackingPlan" is required (not null)
            if (trackingPlan == null)
            {
                throw new ArgumentNullException("trackingPlan is a required property for CreateTrackingPlanV1Output and cannot be null");
            }
            this.TrackingPlan = trackingPlan;
        }

        /// <summary>
        /// Gets or Sets TrackingPlan
        /// </summary>
        [DataMember(Name = "trackingPlan", IsRequired = true, EmitDefaultValue = true)]
        public TrackingPlanV1 TrackingPlan { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateTrackingPlanV1Output {\n");
            sb.Append("  TrackingPlan: ").Append(TrackingPlan).Append("\n");
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
            return this.Equals(input as CreateTrackingPlanV1Output);
        }

        /// <summary>
        /// Returns true if CreateTrackingPlanV1Output instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTrackingPlanV1Output to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTrackingPlanV1Output input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TrackingPlan == input.TrackingPlan ||
                    (this.TrackingPlan != null &&
                    this.TrackingPlan.Equals(input.TrackingPlan))
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
                if (this.TrackingPlan != null)
                {
                    hashCode = (hashCode * 59) + this.TrackingPlan.GetHashCode();
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
