/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.0.1
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
    /// Represents methods that a given Destination supports.
    /// </summary>
    [DataContract(Name = "DestinationMetadataMethodsV1")]
    public partial class DestinationMetadataMethodsV1 : IEquatable<DestinationMetadataMethodsV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationMetadataMethodsV1" /> class.
        /// </summary>
        /// <param name="pageview">Identifies if the Destination supports the &#x60;pageview&#x60; method..</param>
        /// <param name="identify">Identifies if the Destination supports the &#x60;identify&#x60; method..</param>
        /// <param name="alias">Identifies if the Destination supports the &#x60;alias&#x60; method..</param>
        /// <param name="track">Identifies if the Destination supports the &#x60;track&#x60; method..</param>
        /// <param name="group">Identifies if the Destination supports the &#x60;group&#x60; method..</param>
        public DestinationMetadataMethodsV1(bool pageview = default(bool), bool identify = default(bool), bool alias = default(bool), bool track = default(bool), bool group = default(bool))
        {
            this.Pageview = pageview;
            this.Identify = identify;
            this.Alias = alias;
            this.Track = track;
            this.Group = group;
        }

        /// <summary>
        /// Identifies if the Destination supports the &#x60;pageview&#x60; method.
        /// </summary>
        /// <value>Identifies if the Destination supports the &#x60;pageview&#x60; method.</value>
        [DataMember(Name = "pageview", EmitDefaultValue = true)]
        public bool Pageview { get; set; }

        /// <summary>
        /// Identifies if the Destination supports the &#x60;identify&#x60; method.
        /// </summary>
        /// <value>Identifies if the Destination supports the &#x60;identify&#x60; method.</value>
        [DataMember(Name = "identify", EmitDefaultValue = true)]
        public bool Identify { get; set; }

        /// <summary>
        /// Identifies if the Destination supports the &#x60;alias&#x60; method.
        /// </summary>
        /// <value>Identifies if the Destination supports the &#x60;alias&#x60; method.</value>
        [DataMember(Name = "alias", EmitDefaultValue = true)]
        public bool Alias { get; set; }

        /// <summary>
        /// Identifies if the Destination supports the &#x60;track&#x60; method.
        /// </summary>
        /// <value>Identifies if the Destination supports the &#x60;track&#x60; method.</value>
        [DataMember(Name = "track", EmitDefaultValue = true)]
        public bool Track { get; set; }

        /// <summary>
        /// Identifies if the Destination supports the &#x60;group&#x60; method.
        /// </summary>
        /// <value>Identifies if the Destination supports the &#x60;group&#x60; method.</value>
        [DataMember(Name = "group", EmitDefaultValue = true)]
        public bool Group { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinationMetadataMethodsV1 {\n");
            sb.Append("  Pageview: ").Append(Pageview).Append("\n");
            sb.Append("  Identify: ").Append(Identify).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Track: ").Append(Track).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
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
            return this.Equals(input as DestinationMetadataMethodsV1);
        }

        /// <summary>
        /// Returns true if DestinationMetadataMethodsV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinationMetadataMethodsV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinationMetadataMethodsV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Pageview == input.Pageview ||
                    this.Pageview.Equals(input.Pageview)
                ) && 
                (
                    this.Identify == input.Identify ||
                    this.Identify.Equals(input.Identify)
                ) && 
                (
                    this.Alias == input.Alias ||
                    this.Alias.Equals(input.Alias)
                ) && 
                (
                    this.Track == input.Track ||
                    this.Track.Equals(input.Track)
                ) && 
                (
                    this.Group == input.Group ||
                    this.Group.Equals(input.Group)
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
                hashCode = (hashCode * 59) + this.Pageview.GetHashCode();
                hashCode = (hashCode * 59) + this.Identify.GetHashCode();
                hashCode = (hashCode * 59) + this.Alias.GetHashCode();
                hashCode = (hashCode * 59) + this.Track.GetHashCode();
                hashCode = (hashCode * 59) + this.Group.GetHashCode();
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
