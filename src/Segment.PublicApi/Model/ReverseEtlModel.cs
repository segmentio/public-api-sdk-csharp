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
    /// Defines a Reverse ETL Model.
    /// </summary>
    [DataContract(Name = "ReverseEtlModel")]
    public partial class ReverseEtlModel : IEquatable<ReverseEtlModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseEtlModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReverseEtlModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseEtlModel" /> class.
        /// </summary>
        /// <param name="id">The id of the Model. (required).</param>
        /// <param name="sourceId">The id for the attached Source. (required).</param>
        /// <param name="name">A short, human-readable description of the Model. (required).</param>
        /// <param name="description">A longer, more descriptive explanation of the Model. (required).</param>
        /// <param name="enabled">Indicates whether the Model should have syncs enabled. When disabled, no syncs will be triggered, regardless of the enabled status of the attached destinations/subscriptions. (required).</param>
        /// <param name="query">The SQL query that will be executed to extract data from the connected Source. (required).</param>
        /// <param name="queryIdentifierColumn">Indicates the column named in &#x60;query&#x60; that should be used to uniquely identify the extracted records. (required).</param>
        public ReverseEtlModel(string id = default(string), string sourceId = default(string), string name = default(string), string description = default(string), bool enabled = default(bool), string query = default(string), string queryIdentifierColumn = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for ReverseEtlModel and cannot be null");
            }
            this.Id = id;
            // to ensure "sourceId" is required (not null)
            if (sourceId == null)
            {
                throw new ArgumentNullException("sourceId is a required property for ReverseEtlModel and cannot be null");
            }
            this.SourceId = sourceId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ReverseEtlModel and cannot be null");
            }
            this.Name = name;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for ReverseEtlModel and cannot be null");
            }
            this.Description = description;
            this.Enabled = enabled;
            // to ensure "query" is required (not null)
            if (query == null)
            {
                throw new ArgumentNullException("query is a required property for ReverseEtlModel and cannot be null");
            }
            this.Query = query;
            // to ensure "queryIdentifierColumn" is required (not null)
            if (queryIdentifierColumn == null)
            {
                throw new ArgumentNullException("queryIdentifierColumn is a required property for ReverseEtlModel and cannot be null");
            }
            this.QueryIdentifierColumn = queryIdentifierColumn;
        }

        /// <summary>
        /// The id of the Model.
        /// </summary>
        /// <value>The id of the Model.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The id for the attached Source.
        /// </summary>
        /// <value>The id for the attached Source.</value>
        [DataMember(Name = "sourceId", IsRequired = true, EmitDefaultValue = true)]
        public string SourceId { get; set; }

        /// <summary>
        /// A short, human-readable description of the Model.
        /// </summary>
        /// <value>A short, human-readable description of the Model.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// A longer, more descriptive explanation of the Model.
        /// </summary>
        /// <value>A longer, more descriptive explanation of the Model.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Indicates whether the Model should have syncs enabled. When disabled, no syncs will be triggered, regardless of the enabled status of the attached destinations/subscriptions.
        /// </summary>
        /// <value>Indicates whether the Model should have syncs enabled. When disabled, no syncs will be triggered, regardless of the enabled status of the attached destinations/subscriptions.</value>
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// The SQL query that will be executed to extract data from the connected Source.
        /// </summary>
        /// <value>The SQL query that will be executed to extract data from the connected Source.</value>
        [DataMember(Name = "query", IsRequired = true, EmitDefaultValue = true)]
        public string Query { get; set; }

        /// <summary>
        /// Indicates the column named in &#x60;query&#x60; that should be used to uniquely identify the extracted records.
        /// </summary>
        /// <value>Indicates the column named in &#x60;query&#x60; that should be used to uniquely identify the extracted records.</value>
        [DataMember(Name = "queryIdentifierColumn", IsRequired = true, EmitDefaultValue = true)]
        public string QueryIdentifierColumn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReverseEtlModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  QueryIdentifierColumn: ").Append(QueryIdentifierColumn).Append("\n");
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
            return this.Equals(input as ReverseEtlModel);
        }

        /// <summary>
        /// Returns true if ReverseEtlModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ReverseEtlModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReverseEtlModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.QueryIdentifierColumn == input.QueryIdentifierColumn ||
                    (this.QueryIdentifierColumn != null &&
                    this.QueryIdentifierColumn.Equals(input.QueryIdentifierColumn))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.SourceId != null)
                {
                    hashCode = (hashCode * 59) + this.SourceId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.Query != null)
                {
                    hashCode = (hashCode * 59) + this.Query.GetHashCode();
                }
                if (this.QueryIdentifierColumn != null)
                {
                    hashCode = (hashCode * 59) + this.QueryIdentifierColumn.GetHashCode();
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
