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
    /// Represents a Tracking Plan.
    /// </summary>
    [DataContract(Name = "TrackingPlanV1")]
    public partial class TrackingPlanV1 : IEquatable<TrackingPlanV1>, IValidatableObject
    {
        /// <summary>
        /// The Tracking Plan&#39;s type.
        /// </summary>
        /// <value>The Tracking Plan&#39;s type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum ENGAGE for value: ENGAGE
            /// </summary>
            [EnumMember(Value = "ENGAGE")]
            ENGAGE = 1,

            /// <summary>
            /// Enum LIVE for value: LIVE
            /// </summary>
            [EnumMember(Value = "LIVE")]
            LIVE = 2,

            /// <summary>
            /// Enum PROPERTYLIBRARY for value: PROPERTY_LIBRARY
            /// </summary>
            [EnumMember(Value = "PROPERTY_LIBRARY")]
            PROPERTYLIBRARY = 3,

            /// <summary>
            /// Enum RULELIBRARY for value: RULE_LIBRARY
            /// </summary>
            [EnumMember(Value = "RULE_LIBRARY")]
            RULELIBRARY = 4,

            /// <summary>
            /// Enum TEMPLATE for value: TEMPLATE
            /// </summary>
            [EnumMember(Value = "TEMPLATE")]
            TEMPLATE = 5
        }


        /// <summary>
        /// The Tracking Plan&#39;s type.
        /// </summary>
        /// <value>The Tracking Plan&#39;s type.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingPlanV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrackingPlanV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingPlanV1" /> class.
        /// </summary>
        /// <param name="id">The Tracking Plan&#39;s identifier.  Config API note: analogous to &#x60;name&#x60;. (required).</param>
        /// <param name="name">The Tracking Plan&#39;s name.  Config API note: equal to &#x60;displayName&#x60;..</param>
        /// <param name="slug">URL-friendly slug of this Tracking Plan.  Config API note: equal to &#x60;name&#x60;..</param>
        /// <param name="description">The Tracking Plan&#39;s description..</param>
        /// <param name="type">The Tracking Plan&#39;s type. (required).</param>
        /// <param name="updatedAt">The timestamp of the last change to the Tracking Plan.  Config API note: equal to &#x60;updateTime&#x60;..</param>
        /// <param name="createdAt">The timestamp of this Tracking Plan&#39;s creation.  Config API note: equal to &#x60;createTime&#x60;..</param>
        public TrackingPlanV1(string id = default(string), string name = default(string), string slug = default(string), string description = default(string), TypeEnum type = default(TypeEnum), string updatedAt = default(string), string createdAt = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for TrackingPlanV1 and cannot be null");
            }
            this.Id = id;
            this.Type = type;
            this.Name = name;
            this.Slug = slug;
            this.Description = description;
            this.UpdatedAt = updatedAt;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// The Tracking Plan&#39;s identifier.  Config API note: analogous to &#x60;name&#x60;.
        /// </summary>
        /// <value>The Tracking Plan&#39;s identifier.  Config API note: analogous to &#x60;name&#x60;.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The Tracking Plan&#39;s name.  Config API note: equal to &#x60;displayName&#x60;.
        /// </summary>
        /// <value>The Tracking Plan&#39;s name.  Config API note: equal to &#x60;displayName&#x60;.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// URL-friendly slug of this Tracking Plan.  Config API note: equal to &#x60;name&#x60;.
        /// </summary>
        /// <value>URL-friendly slug of this Tracking Plan.  Config API note: equal to &#x60;name&#x60;.</value>
        [DataMember(Name = "slug", EmitDefaultValue = false)]
        public string Slug { get; set; }

        /// <summary>
        /// The Tracking Plan&#39;s description.
        /// </summary>
        /// <value>The Tracking Plan&#39;s description.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The timestamp of the last change to the Tracking Plan.  Config API note: equal to &#x60;updateTime&#x60;.
        /// </summary>
        /// <value>The timestamp of the last change to the Tracking Plan.  Config API note: equal to &#x60;updateTime&#x60;.</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// The timestamp of this Tracking Plan&#39;s creation.  Config API note: equal to &#x60;createTime&#x60;.
        /// </summary>
        /// <value>The timestamp of this Tracking Plan&#39;s creation.  Config API note: equal to &#x60;createTime&#x60;.</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackingPlanV1 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as TrackingPlanV1);
        }

        /// <summary>
        /// Returns true if TrackingPlanV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackingPlanV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackingPlanV1 input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Slug != null)
                {
                    hashCode = (hashCode * 59) + this.Slug.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
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
