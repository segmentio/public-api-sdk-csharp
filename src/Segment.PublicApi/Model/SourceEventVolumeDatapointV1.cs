/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 57.2.0
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
    /// SourceEventVolumeDatapoint represents an individual timestamp/event count pair corresponding to a window of time designated by the granularity.
    /// </summary>
    [DataContract(Name = "SourceEventVolumeDatapointV1")]
    public partial class SourceEventVolumeDatapointV1 : IEquatable<SourceEventVolumeDatapointV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceEventVolumeDatapointV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SourceEventVolumeDatapointV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceEventVolumeDatapointV1" /> class.
        /// </summary>
        /// <param name="time">The timestamp that corresponds to the beginning of the window given by the requested granularity. (required).</param>
        /// <param name="count">The number of valid events Segment received in the given window, after the events completed the validation process. (required).</param>
        public SourceEventVolumeDatapointV1(string time = default(string), decimal count = default(decimal))
        {
            // to ensure "time" is required (not null)
            if (time == null)
            {
                throw new ArgumentNullException("time is a required property for SourceEventVolumeDatapointV1 and cannot be null");
            }
            this.Time = time;
            this.Count = count;
        }

        /// <summary>
        /// The timestamp that corresponds to the beginning of the window given by the requested granularity.
        /// </summary>
        /// <value>The timestamp that corresponds to the beginning of the window given by the requested granularity.</value>
        [DataMember(Name = "time", IsRequired = true, EmitDefaultValue = true)]
        public string Time { get; set; }

        /// <summary>
        /// The number of valid events Segment received in the given window, after the events completed the validation process.
        /// </summary>
        /// <value>The number of valid events Segment received in the given window, after the events completed the validation process.</value>
        [DataMember(Name = "count", IsRequired = true, EmitDefaultValue = true)]
        public decimal Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SourceEventVolumeDatapointV1 {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(input as SourceEventVolumeDatapointV1);
        }

        /// <summary>
        /// Returns true if SourceEventVolumeDatapointV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of SourceEventVolumeDatapointV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourceEventVolumeDatapointV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
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
                if (this.Time != null)
                {
                    hashCode = (hashCode * 59) + this.Time.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Count.GetHashCode();
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
