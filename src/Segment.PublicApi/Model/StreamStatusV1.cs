/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 57.0.0
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
    /// StreamStatus represents status of each stream including all the Destinations corresponding to the stream.
    /// </summary>
    [DataContract(Name = "StreamStatusV1")]
    public partial class StreamStatusV1 : IEquatable<StreamStatusV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamStatusV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StreamStatusV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamStatusV1" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="destinationStatus">destinationStatus (required).</param>
        public StreamStatusV1(string id = default(string), List<DestinationStatusV1> destinationStatus = default(List<DestinationStatusV1>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for StreamStatusV1 and cannot be null");
            }
            this.Id = id;
            // to ensure "destinationStatus" is required (not null)
            if (destinationStatus == null)
            {
                throw new ArgumentNullException("destinationStatus is a required property for StreamStatusV1 and cannot be null");
            }
            this.DestinationStatus = destinationStatus;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets DestinationStatus
        /// </summary>
        [DataMember(Name = "destinationStatus", IsRequired = true, EmitDefaultValue = true)]
        public List<DestinationStatusV1> DestinationStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StreamStatusV1 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DestinationStatus: ").Append(DestinationStatus).Append("\n");
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
            return this.Equals(input as StreamStatusV1);
        }

        /// <summary>
        /// Returns true if StreamStatusV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of StreamStatusV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StreamStatusV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DestinationStatus == input.DestinationStatus ||
                    this.DestinationStatus != null &&
                    input.DestinationStatus != null &&
                    this.DestinationStatus.SequenceEqual(input.DestinationStatus)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.DestinationStatus != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationStatus.GetHashCode();
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
