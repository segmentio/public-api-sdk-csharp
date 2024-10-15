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
    /// GetEventsVolumeFromWorkspaceV1Output represents the results given the input query.
    /// </summary>
    [DataContract(Name = "GetEventsVolumeFromWorkspaceV1Output")]
    public partial class GetEventsVolumeFromWorkspaceV1Output : IEquatable<GetEventsVolumeFromWorkspaceV1Output>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEventsVolumeFromWorkspaceV1Output" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetEventsVolumeFromWorkspaceV1Output() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEventsVolumeFromWorkspaceV1Output" /> class.
        /// </summary>
        /// <param name="path">Observability event volume path. (required).</param>
        /// <param name="query">query (required).</param>
        /// <param name="result">The resultant list of series broken down by the dimensions requested over the time frame requested and ordered by the total count of events in all series. Note: The limit of entries returned is 5000. (required).</param>
        /// <param name="pagination">pagination.</param>
        public GetEventsVolumeFromWorkspaceV1Output(string path = default(string), GetEventsVolumeFromWorkspaceV1Query query = default(GetEventsVolumeFromWorkspaceV1Query), List<SourceEventVolumeV1> result = default(List<SourceEventVolumeV1>), PaginationOutput pagination = default(PaginationOutput))
        {
            // to ensure "path" is required (not null)
            if (path == null)
            {
                throw new ArgumentNullException("path is a required property for GetEventsVolumeFromWorkspaceV1Output and cannot be null");
            }
            this.Path = path;
            // to ensure "query" is required (not null)
            if (query == null)
            {
                throw new ArgumentNullException("query is a required property for GetEventsVolumeFromWorkspaceV1Output and cannot be null");
            }
            this.Query = query;
            // to ensure "result" is required (not null)
            if (result == null)
            {
                throw new ArgumentNullException("result is a required property for GetEventsVolumeFromWorkspaceV1Output and cannot be null");
            }
            this.Result = result;
            this.Pagination = pagination;
        }

        /// <summary>
        /// Observability event volume path.
        /// </summary>
        /// <value>Observability event volume path.</value>
        [DataMember(Name = "path", IsRequired = true, EmitDefaultValue = true)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name = "query", IsRequired = true, EmitDefaultValue = true)]
        public GetEventsVolumeFromWorkspaceV1Query Query { get; set; }

        /// <summary>
        /// The resultant list of series broken down by the dimensions requested over the time frame requested and ordered by the total count of events in all series. Note: The limit of entries returned is 5000.
        /// </summary>
        /// <value>The resultant list of series broken down by the dimensions requested over the time frame requested and ordered by the total count of events in all series. Note: The limit of entries returned is 5000.</value>
        [DataMember(Name = "result", IsRequired = true, EmitDefaultValue = true)]
        public List<SourceEventVolumeV1> Result { get; set; }

        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name = "pagination", EmitDefaultValue = false)]
        public PaginationOutput Pagination { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetEventsVolumeFromWorkspaceV1Output {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
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
            return this.Equals(input as GetEventsVolumeFromWorkspaceV1Output);
        }

        /// <summary>
        /// Returns true if GetEventsVolumeFromWorkspaceV1Output instances are equal
        /// </summary>
        /// <param name="input">Instance of GetEventsVolumeFromWorkspaceV1Output to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetEventsVolumeFromWorkspaceV1Output input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.Result == input.Result ||
                    this.Result != null &&
                    input.Result != null &&
                    this.Result.SequenceEqual(input.Result)
                ) && 
                (
                    this.Pagination == input.Pagination ||
                    (this.Pagination != null &&
                    this.Pagination.Equals(input.Pagination))
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
                if (this.Path != null)
                {
                    hashCode = (hashCode * 59) + this.Path.GetHashCode();
                }
                if (this.Query != null)
                {
                    hashCode = (hashCode * 59) + this.Query.GetHashCode();
                }
                if (this.Result != null)
                {
                    hashCode = (hashCode * 59) + this.Result.GetHashCode();
                }
                if (this.Pagination != null)
                {
                    hashCode = (hashCode * 59) + this.Pagination.GetHashCode();
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
