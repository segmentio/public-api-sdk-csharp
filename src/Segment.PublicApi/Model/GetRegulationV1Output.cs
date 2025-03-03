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
    /// The regulate request returned.
    /// </summary>
    [DataContract(Name = "GetRegulationV1Output")]
    public partial class GetRegulationV1Output : IEquatable<GetRegulationV1Output>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetRegulationV1Output" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetRegulationV1Output() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetRegulationV1Output" /> class.
        /// </summary>
        /// <param name="regulation">regulation (required).</param>
        public GetRegulationV1Output(Regulation regulation = default(Regulation))
        {
            // to ensure "regulation" is required (not null)
            if (regulation == null)
            {
                throw new ArgumentNullException("regulation is a required property for GetRegulationV1Output and cannot be null");
            }
            this.Regulation = regulation;
        }

        /// <summary>
        /// Gets or Sets Regulation
        /// </summary>
        [DataMember(Name = "regulation", IsRequired = true, EmitDefaultValue = true)]
        public Regulation Regulation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetRegulationV1Output {\n");
            sb.Append("  Regulation: ").Append(Regulation).Append("\n");
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
            return this.Equals(input as GetRegulationV1Output);
        }

        /// <summary>
        /// Returns true if GetRegulationV1Output instances are equal
        /// </summary>
        /// <param name="input">Instance of GetRegulationV1Output to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetRegulationV1Output input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Regulation == input.Regulation ||
                    (this.Regulation != null &&
                    this.Regulation.Equals(input.Regulation))
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
                if (this.Regulation != null)
                {
                    hashCode = (hashCode * 59) + this.Regulation.GetHashCode();
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
