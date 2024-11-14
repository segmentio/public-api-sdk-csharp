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
    /// AudienceOptions
    /// </summary>
    [DataContract(Name = "AudienceOptions")]
    public partial class AudienceOptions : IEquatable<AudienceOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AudienceOptions" /> class.
        /// </summary>
        /// <param name="includeHistoricalData">Determines whether data prior to the audience being created is included when determining audience membership. Note that including historical data may be needed in order to properly handle the definition specified. In these cases, Segment will automatically handle including historical data and the response will return the includeHistoricalData parameter as true..</param>
        /// <param name="includeAnonymousUsers">Determines whether anonymous users should be included when determining audience membership..</param>
        public AudienceOptions(bool includeHistoricalData = default(bool), bool includeAnonymousUsers = default(bool))
        {
            this.IncludeHistoricalData = includeHistoricalData;
            this.IncludeAnonymousUsers = includeAnonymousUsers;
        }

        /// <summary>
        /// Determines whether data prior to the audience being created is included when determining audience membership. Note that including historical data may be needed in order to properly handle the definition specified. In these cases, Segment will automatically handle including historical data and the response will return the includeHistoricalData parameter as true.
        /// </summary>
        /// <value>Determines whether data prior to the audience being created is included when determining audience membership. Note that including historical data may be needed in order to properly handle the definition specified. In these cases, Segment will automatically handle including historical data and the response will return the includeHistoricalData parameter as true.</value>
        [DataMember(Name = "includeHistoricalData", EmitDefaultValue = true)]
        public bool IncludeHistoricalData { get; set; }

        /// <summary>
        /// Determines whether anonymous users should be included when determining audience membership.
        /// </summary>
        /// <value>Determines whether anonymous users should be included when determining audience membership.</value>
        [DataMember(Name = "includeAnonymousUsers", EmitDefaultValue = true)]
        public bool IncludeAnonymousUsers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AudienceOptions {\n");
            sb.Append("  IncludeHistoricalData: ").Append(IncludeHistoricalData).Append("\n");
            sb.Append("  IncludeAnonymousUsers: ").Append(IncludeAnonymousUsers).Append("\n");
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
            return this.Equals(input as AudienceOptions);
        }

        /// <summary>
        /// Returns true if AudienceOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of AudienceOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AudienceOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IncludeHistoricalData == input.IncludeHistoricalData ||
                    this.IncludeHistoricalData.Equals(input.IncludeHistoricalData)
                ) && 
                (
                    this.IncludeAnonymousUsers == input.IncludeAnonymousUsers ||
                    this.IncludeAnonymousUsers.Equals(input.IncludeAnonymousUsers)
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
                hashCode = (hashCode * 59) + this.IncludeHistoricalData.GetHashCode();
                hashCode = (hashCode * 59) + this.IncludeAnonymousUsers.GetHashCode();
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
