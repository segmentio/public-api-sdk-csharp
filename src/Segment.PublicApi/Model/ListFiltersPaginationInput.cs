/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.13.0
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
    /// Pagination for list filters.
    /// </summary>
    [DataContract(Name = "ListFiltersPaginationInput")]
    public partial class ListFiltersPaginationInput : IEquatable<ListFiltersPaginationInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListFiltersPaginationInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListFiltersPaginationInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListFiltersPaginationInput" /> class.
        /// </summary>
        /// <param name="cursor">The offset..</param>
        /// <param name="count">The number of items to retrieve in a page, between 1 and 10. (required).</param>
        public ListFiltersPaginationInput(decimal cursor = default(decimal), decimal count = default(decimal))
        {
            this.Count = count;
            this.Cursor = cursor;
        }

        /// <summary>
        /// The offset.
        /// </summary>
        /// <value>The offset.</value>
        [DataMember(Name = "cursor", EmitDefaultValue = false)]
        public decimal Cursor { get; set; }

        /// <summary>
        /// The number of items to retrieve in a page, between 1 and 10.
        /// </summary>
        /// <value>The number of items to retrieve in a page, between 1 and 10.</value>
        [DataMember(Name = "count", IsRequired = true, EmitDefaultValue = true)]
        public decimal Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListFiltersPaginationInput {\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
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
            return this.Equals(input as ListFiltersPaginationInput);
        }

        /// <summary>
        /// Returns true if ListFiltersPaginationInput instances are equal
        /// </summary>
        /// <param name="input">Instance of ListFiltersPaginationInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListFiltersPaginationInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Cursor == input.Cursor ||
                    this.Cursor.Equals(input.Cursor)
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
                hashCode = (hashCode * 59) + this.Cursor.GetHashCode();
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
