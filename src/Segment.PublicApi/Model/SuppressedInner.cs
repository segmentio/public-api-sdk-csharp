/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 54.2.0
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
    /// SuppressedInner
    /// </summary>
    [DataContract(Name = "suppressed_inner")]
    public partial class SuppressedInner : IEquatable<SuppressedInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SuppressedInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SuppressedInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SuppressedInner" /> class.
        /// </summary>
        /// <param name="subjectType">subjectType (required).</param>
        /// <param name="subjectIds">subjectIds (required).</param>
        public SuppressedInner(string subjectType = default(string), List<string> subjectIds = default(List<string>))
        {
            // to ensure "subjectType" is required (not null)
            if (subjectType == null)
            {
                throw new ArgumentNullException("subjectType is a required property for SuppressedInner and cannot be null");
            }
            this.SubjectType = subjectType;
            // to ensure "subjectIds" is required (not null)
            if (subjectIds == null)
            {
                throw new ArgumentNullException("subjectIds is a required property for SuppressedInner and cannot be null");
            }
            this.SubjectIds = subjectIds;
        }

        /// <summary>
        /// Gets or Sets SubjectType
        /// </summary>
        [DataMember(Name = "subjectType", IsRequired = true, EmitDefaultValue = true)]
        public string SubjectType { get; set; }

        /// <summary>
        /// Gets or Sets SubjectIds
        /// </summary>
        [DataMember(Name = "subjectIds", IsRequired = true, EmitDefaultValue = true)]
        public List<string> SubjectIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SuppressedInner {\n");
            sb.Append("  SubjectType: ").Append(SubjectType).Append("\n");
            sb.Append("  SubjectIds: ").Append(SubjectIds).Append("\n");
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
            return this.Equals(input as SuppressedInner);
        }

        /// <summary>
        /// Returns true if SuppressedInner instances are equal
        /// </summary>
        /// <param name="input">Instance of SuppressedInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SuppressedInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SubjectType == input.SubjectType ||
                    (this.SubjectType != null &&
                    this.SubjectType.Equals(input.SubjectType))
                ) && 
                (
                    this.SubjectIds == input.SubjectIds ||
                    this.SubjectIds != null &&
                    input.SubjectIds != null &&
                    this.SubjectIds.SequenceEqual(input.SubjectIds)
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
                if (this.SubjectType != null)
                {
                    hashCode = (hashCode * 59) + this.SubjectType.GetHashCode();
                }
                if (this.SubjectIds != null)
                {
                    hashCode = (hashCode * 59) + this.SubjectIds.GetHashCode();
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