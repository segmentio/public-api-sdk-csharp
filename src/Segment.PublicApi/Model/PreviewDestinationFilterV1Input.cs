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
    /// Input of the Destination filter to preview. For guidance on using FQL, see the Segment documentation site.
    /// </summary>
    [DataContract(Name = "PreviewDestinationFilterV1Input")]
    public partial class PreviewDestinationFilterV1Input : IEquatable<PreviewDestinationFilterV1Input>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewDestinationFilterV1Input" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PreviewDestinationFilterV1Input() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewDestinationFilterV1Input" /> class.
        /// </summary>
        /// <param name="filter">filter (required).</param>
        /// <param name="payload">The JSON payload to apply the filter to. (required).</param>
        public PreviewDestinationFilterV1Input(PreviewDestinationFilterV1 filter = default(PreviewDestinationFilterV1), Dictionary<string, Object> payload = default(Dictionary<string, Object>))
        {
            // to ensure "filter" is required (not null)
            if (filter == null)
            {
                throw new ArgumentNullException("filter is a required property for PreviewDestinationFilterV1Input and cannot be null");
            }
            this.Filter = filter;
            // to ensure "payload" is required (not null)
            if (payload == null)
            {
                throw new ArgumentNullException("payload is a required property for PreviewDestinationFilterV1Input and cannot be null");
            }
            this.Payload = payload;
        }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", IsRequired = true, EmitDefaultValue = true)]
        public PreviewDestinationFilterV1 Filter { get; set; }

        /// <summary>
        /// The JSON payload to apply the filter to.
        /// </summary>
        /// <value>The JSON payload to apply the filter to.</value>
        [DataMember(Name = "payload", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> Payload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PreviewDestinationFilterV1Input {\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
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
            return this.Equals(input as PreviewDestinationFilterV1Input);
        }

        /// <summary>
        /// Returns true if PreviewDestinationFilterV1Input instances are equal
        /// </summary>
        /// <param name="input">Instance of PreviewDestinationFilterV1Input to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PreviewDestinationFilterV1Input input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.Payload == input.Payload ||
                    this.Payload != null &&
                    input.Payload != null &&
                    this.Payload.SequenceEqual(input.Payload)
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
                if (this.Filter != null)
                {
                    hashCode = (hashCode * 59) + this.Filter.GetHashCode();
                }
                if (this.Payload != null)
                {
                    hashCode = (hashCode * 59) + this.Payload.GetHashCode();
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
