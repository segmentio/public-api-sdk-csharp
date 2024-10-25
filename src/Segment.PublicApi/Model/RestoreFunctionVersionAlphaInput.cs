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
    /// Restore a given Function version.
    /// </summary>
    [DataContract(Name = "RestoreFunctionVersionAlphaInput")]
    public partial class RestoreFunctionVersionAlphaInput : IEquatable<RestoreFunctionVersionAlphaInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreFunctionVersionAlphaInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RestoreFunctionVersionAlphaInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreFunctionVersionAlphaInput" /> class.
        /// </summary>
        /// <param name="versionId">An identifier for this version. (required).</param>
        public RestoreFunctionVersionAlphaInput(string versionId = default(string))
        {
            // to ensure "versionId" is required (not null)
            if (versionId == null)
            {
                throw new ArgumentNullException("versionId is a required property for RestoreFunctionVersionAlphaInput and cannot be null");
            }
            this.VersionId = versionId;
        }

        /// <summary>
        /// An identifier for this version.
        /// </summary>
        /// <value>An identifier for this version.</value>
        [DataMember(Name = "versionId", IsRequired = true, EmitDefaultValue = true)]
        public string VersionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RestoreFunctionVersionAlphaInput {\n");
            sb.Append("  VersionId: ").Append(VersionId).Append("\n");
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
            return this.Equals(input as RestoreFunctionVersionAlphaInput);
        }

        /// <summary>
        /// Returns true if RestoreFunctionVersionAlphaInput instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreFunctionVersionAlphaInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreFunctionVersionAlphaInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VersionId == input.VersionId ||
                    (this.VersionId != null &&
                    this.VersionId.Equals(input.VersionId))
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
                if (this.VersionId != null)
                {
                    hashCode = (hashCode * 59) + this.VersionId.GetHashCode();
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
