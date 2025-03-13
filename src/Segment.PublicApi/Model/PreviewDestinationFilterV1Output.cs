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
    /// Preview output from applying the Destination filter. Segment modifies or nullifies payloads depending on the provided filter actions.
    /// </summary>
    [DataContract(Name = "PreviewDestinationFilterV1Output")]
    public partial class PreviewDestinationFilterV1Output : IEquatable<PreviewDestinationFilterV1Output>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewDestinationFilterV1Output" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PreviewDestinationFilterV1Output() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewDestinationFilterV1Output" /> class.
        /// </summary>
        /// <param name="inputPayload">The pre-filter JSON input. (required).</param>
        /// <param name="result">The filtered JSON output. (required).</param>
        public PreviewDestinationFilterV1Output(Dictionary<string, Object> inputPayload = default(Dictionary<string, Object>), Object result = default(Object))
        {
            // to ensure "inputPayload" is required (not null)
            if (inputPayload == null)
            {
                throw new ArgumentNullException("inputPayload is a required property for PreviewDestinationFilterV1Output and cannot be null");
            }
            this.InputPayload = inputPayload;
            // to ensure "result" is required (not null)
            if (result == null)
            {
                throw new ArgumentNullException("result is a required property for PreviewDestinationFilterV1Output and cannot be null");
            }
            this.Result = result;
        }

        /// <summary>
        /// The pre-filter JSON input.
        /// </summary>
        /// <value>The pre-filter JSON input.</value>
        [DataMember(Name = "inputPayload", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> InputPayload { get; set; }

        /// <summary>
        /// The filtered JSON output.
        /// </summary>
        /// <value>The filtered JSON output.</value>
        [DataMember(Name = "result", IsRequired = true, EmitDefaultValue = true)]
        public Object Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PreviewDestinationFilterV1Output {\n");
            sb.Append("  InputPayload: ").Append(InputPayload).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return this.Equals(input as PreviewDestinationFilterV1Output);
        }

        /// <summary>
        /// Returns true if PreviewDestinationFilterV1Output instances are equal
        /// </summary>
        /// <param name="input">Instance of PreviewDestinationFilterV1Output to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PreviewDestinationFilterV1Output input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InputPayload == input.InputPayload ||
                    this.InputPayload != null &&
                    input.InputPayload != null &&
                    this.InputPayload.SequenceEqual(input.InputPayload)
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
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
                if (this.InputPayload != null)
                {
                    hashCode = (hashCode * 59) + this.InputPayload.GetHashCode();
                }
                if (this.Result != null)
                {
                    hashCode = (hashCode * 59) + this.Result.GetHashCode();
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
