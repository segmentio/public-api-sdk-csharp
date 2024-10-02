/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 55.0.0
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
    [DataContract(Name = "ListFiltersPaginationOutput")]
    public partial class ListFiltersPaginationOutput : IEquatable<ListFiltersPaginationOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListFiltersPaginationOutput" /> class.
        /// </summary>
        /// <param name="current">Current..</param>
        /// <param name="next">Next..</param>
        /// <param name="totalEntries">Total entries..</param>
        public ListFiltersPaginationOutput(decimal current = default(decimal), decimal next = default(decimal), decimal totalEntries = default(decimal))
        {
            this.Current = current;
            this.Next = next;
            this.TotalEntries = totalEntries;
        }

        /// <summary>
        /// Current.
        /// </summary>
        /// <value>Current.</value>
        [DataMember(Name = "current", EmitDefaultValue = false)]
        public decimal Current { get; set; }

        /// <summary>
        /// Next.
        /// </summary>
        /// <value>Next.</value>
        [DataMember(Name = "next", EmitDefaultValue = false)]
        public decimal Next { get; set; }

        /// <summary>
        /// Total entries.
        /// </summary>
        /// <value>Total entries.</value>
        [DataMember(Name = "totalEntries", EmitDefaultValue = false)]
        public decimal TotalEntries { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListFiltersPaginationOutput {\n");
            sb.Append("  Current: ").Append(Current).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
            sb.Append("  TotalEntries: ").Append(TotalEntries).Append("\n");
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
            return this.Equals(input as ListFiltersPaginationOutput);
        }

        /// <summary>
        /// Returns true if ListFiltersPaginationOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of ListFiltersPaginationOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListFiltersPaginationOutput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Current == input.Current ||
                    this.Current.Equals(input.Current)
                ) && 
                (
                    this.Next == input.Next ||
                    this.Next.Equals(input.Next)
                ) && 
                (
                    this.TotalEntries == input.TotalEntries ||
                    this.TotalEntries.Equals(input.TotalEntries)
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
                hashCode = (hashCode * 59) + this.Current.GetHashCode();
                hashCode = (hashCode * 59) + this.Next.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalEntries.GetHashCode();
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
