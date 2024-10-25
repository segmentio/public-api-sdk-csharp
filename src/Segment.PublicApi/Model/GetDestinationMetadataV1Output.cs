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
    /// Returns a Destination catalog item.
    /// </summary>
    [DataContract(Name = "GetDestinationMetadataV1Output")]
    public partial class GetDestinationMetadataV1Output : IEquatable<GetDestinationMetadataV1Output>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDestinationMetadataV1Output" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetDestinationMetadataV1Output() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDestinationMetadataV1Output" /> class.
        /// </summary>
        /// <param name="destinationMetadata">destinationMetadata (required).</param>
        public GetDestinationMetadataV1Output(DestinationMetadataV1 destinationMetadata = default(DestinationMetadataV1))
        {
            // to ensure "destinationMetadata" is required (not null)
            if (destinationMetadata == null)
            {
                throw new ArgumentNullException("destinationMetadata is a required property for GetDestinationMetadataV1Output and cannot be null");
            }
            this.DestinationMetadata = destinationMetadata;
        }

        /// <summary>
        /// Gets or Sets DestinationMetadata
        /// </summary>
        [DataMember(Name = "destinationMetadata", IsRequired = true, EmitDefaultValue = true)]
        public DestinationMetadataV1 DestinationMetadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetDestinationMetadataV1Output {\n");
            sb.Append("  DestinationMetadata: ").Append(DestinationMetadata).Append("\n");
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
            return this.Equals(input as GetDestinationMetadataV1Output);
        }

        /// <summary>
        /// Returns true if GetDestinationMetadataV1Output instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDestinationMetadataV1Output to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDestinationMetadataV1Output input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DestinationMetadata == input.DestinationMetadata ||
                    (this.DestinationMetadata != null &&
                    this.DestinationMetadata.Equals(input.DestinationMetadata))
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
                if (this.DestinationMetadata != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationMetadata.GetHashCode();
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
