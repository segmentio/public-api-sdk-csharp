/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.1.1
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
    /// AudienceComputationDefinition
    /// </summary>
    [DataContract(Name = "AudienceComputationDefinition")]
    public partial class AudienceComputationDefinition : IEquatable<AudienceComputationDefinition>, IValidatableObject
    {
        /// <summary>
        /// The underlying data type being segmented for this audience.  Possible values: users, accounts.
        /// </summary>
        /// <value>The underlying data type being segmented for this audience.  Possible values: users, accounts.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum ACCOUNTS for value: ACCOUNTS
            /// </summary>
            [EnumMember(Value = "ACCOUNTS")]
            ACCOUNTS = 1,

            /// <summary>
            /// Enum USERS for value: USERS
            /// </summary>
            [EnumMember(Value = "USERS")]
            USERS = 2
        }


        /// <summary>
        /// The underlying data type being segmented for this audience.  Possible values: users, accounts.
        /// </summary>
        /// <value>The underlying data type being segmented for this audience.  Possible values: users, accounts.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AudienceComputationDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AudienceComputationDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AudienceComputationDefinition" /> class.
        /// </summary>
        /// <param name="type">The underlying data type being segmented for this audience.  Possible values: users, accounts. (required).</param>
        /// <param name="query">The query language string defining the audience segmentation criteria.  For guidance on using the query language, see the [Segment documentation site](https://segment.com/docs/api/public-api/query-language). (required).</param>
        public AudienceComputationDefinition(TypeEnum type = default(TypeEnum), string query = default(string))
        {
            this.Type = type;
            // to ensure "query" is required (not null)
            if (query == null)
            {
                throw new ArgumentNullException("query is a required property for AudienceComputationDefinition and cannot be null");
            }
            this.Query = query;
        }

        /// <summary>
        /// The query language string defining the audience segmentation criteria.  For guidance on using the query language, see the [Segment documentation site](https://segment.com/docs/api/public-api/query-language).
        /// </summary>
        /// <value>The query language string defining the audience segmentation criteria.  For guidance on using the query language, see the [Segment documentation site](https://segment.com/docs/api/public-api/query-language).</value>
        [DataMember(Name = "query", IsRequired = true, EmitDefaultValue = true)]
        public string Query { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AudienceComputationDefinition {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
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
            return this.Equals(input as AudienceComputationDefinition);
        }

        /// <summary>
        /// Returns true if AudienceComputationDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of AudienceComputationDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AudienceComputationDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Query != null)
                {
                    hashCode = (hashCode * 59) + this.Query.GetHashCode();
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
