/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 57.0.1
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
    /// GroupSourceSettingsV1
    /// </summary>
    [DataContract(Name = "GroupSourceSettingsV1")]
    public partial class GroupSourceSettingsV1 : IEquatable<GroupSourceSettingsV1>, IValidatableObject
    {
        /// <summary>
        /// The common group event on violations.  Config API note: equal to &#x60;commonGroupEventOnViolations&#x60;.
        /// </summary>
        /// <value>The common group event on violations.  Config API note: equal to &#x60;commonGroupEventOnViolations&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CommonEventOnViolationsEnum
        {
            /// <summary>
            /// Enum ALLOW for value: ALLOW
            /// </summary>
            [EnumMember(Value = "ALLOW")]
            ALLOW = 1,

            /// <summary>
            /// Enum BLOCK for value: BLOCK
            /// </summary>
            [EnumMember(Value = "BLOCK")]
            BLOCK = 2,

            /// <summary>
            /// Enum OMITTRAITS for value: OMIT_TRAITS
            /// </summary>
            [EnumMember(Value = "OMIT_TRAITS")]
            OMITTRAITS = 3
        }


        /// <summary>
        /// The common group event on violations.  Config API note: equal to &#x60;commonGroupEventOnViolations&#x60;.
        /// </summary>
        /// <value>The common group event on violations.  Config API note: equal to &#x60;commonGroupEventOnViolations&#x60;.</value>
        [DataMember(Name = "commonEventOnViolations", EmitDefaultValue = false)]
        public CommonEventOnViolationsEnum? CommonEventOnViolations { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupSourceSettingsV1" /> class.
        /// </summary>
        /// <param name="allowUnplannedTraits">Enable to allow unplanned group traits.  Config API note: equal to &#x60;allowUnplannedGroupTraits&#x60;..</param>
        /// <param name="allowTraitsOnViolations">Enable to allow group traits on violations.  Config API note: equal to &#x60;allowGroupTraitsOnViolations&#x60;..</param>
        /// <param name="commonEventOnViolations">The common group event on violations.  Config API note: equal to &#x60;commonGroupEventOnViolations&#x60;..</param>
        public GroupSourceSettingsV1(bool allowUnplannedTraits = default(bool), bool allowTraitsOnViolations = default(bool), CommonEventOnViolationsEnum? commonEventOnViolations = default(CommonEventOnViolationsEnum?))
        {
            this.AllowUnplannedTraits = allowUnplannedTraits;
            this.AllowTraitsOnViolations = allowTraitsOnViolations;
            this.CommonEventOnViolations = commonEventOnViolations;
        }

        /// <summary>
        /// Enable to allow unplanned group traits.  Config API note: equal to &#x60;allowUnplannedGroupTraits&#x60;.
        /// </summary>
        /// <value>Enable to allow unplanned group traits.  Config API note: equal to &#x60;allowUnplannedGroupTraits&#x60;.</value>
        [DataMember(Name = "allowUnplannedTraits", EmitDefaultValue = true)]
        public bool AllowUnplannedTraits { get; set; }

        /// <summary>
        /// Enable to allow group traits on violations.  Config API note: equal to &#x60;allowGroupTraitsOnViolations&#x60;.
        /// </summary>
        /// <value>Enable to allow group traits on violations.  Config API note: equal to &#x60;allowGroupTraitsOnViolations&#x60;.</value>
        [DataMember(Name = "allowTraitsOnViolations", EmitDefaultValue = true)]
        public bool AllowTraitsOnViolations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupSourceSettingsV1 {\n");
            sb.Append("  AllowUnplannedTraits: ").Append(AllowUnplannedTraits).Append("\n");
            sb.Append("  AllowTraitsOnViolations: ").Append(AllowTraitsOnViolations).Append("\n");
            sb.Append("  CommonEventOnViolations: ").Append(CommonEventOnViolations).Append("\n");
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
            return this.Equals(input as GroupSourceSettingsV1);
        }

        /// <summary>
        /// Returns true if GroupSourceSettingsV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupSourceSettingsV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupSourceSettingsV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AllowUnplannedTraits == input.AllowUnplannedTraits ||
                    this.AllowUnplannedTraits.Equals(input.AllowUnplannedTraits)
                ) && 
                (
                    this.AllowTraitsOnViolations == input.AllowTraitsOnViolations ||
                    this.AllowTraitsOnViolations.Equals(input.AllowTraitsOnViolations)
                ) && 
                (
                    this.CommonEventOnViolations == input.CommonEventOnViolations ||
                    this.CommonEventOnViolations.Equals(input.CommonEventOnViolations)
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
                hashCode = (hashCode * 59) + this.AllowUnplannedTraits.GetHashCode();
                hashCode = (hashCode * 59) + this.AllowTraitsOnViolations.GetHashCode();
                hashCode = (hashCode * 59) + this.CommonEventOnViolations.GetHashCode();
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
