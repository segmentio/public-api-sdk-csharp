/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.0.0
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
    /// Updates Tracking Plan rules. Non-existent rules are added.
    /// </summary>
    [DataContract(Name = "UpdateRulesInTrackingPlanV1Input")]
    public partial class UpdateRulesInTrackingPlanV1Input : IEquatable<UpdateRulesInTrackingPlanV1Input>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRulesInTrackingPlanV1Input" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateRulesInTrackingPlanV1Input() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRulesInTrackingPlanV1Input" /> class.
        /// </summary>
        /// <param name="rules">Rules to update or insert. (required).</param>
        public UpdateRulesInTrackingPlanV1Input(List<UpsertRuleV1> rules = default(List<UpsertRuleV1>))
        {
            // to ensure "rules" is required (not null)
            if (rules == null)
            {
                throw new ArgumentNullException("rules is a required property for UpdateRulesInTrackingPlanV1Input and cannot be null");
            }
            this.Rules = rules;
        }

        /// <summary>
        /// Rules to update or insert.
        /// </summary>
        /// <value>Rules to update or insert.</value>
        [DataMember(Name = "rules", IsRequired = true, EmitDefaultValue = true)]
        public List<UpsertRuleV1> Rules { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateRulesInTrackingPlanV1Input {\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
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
            return this.Equals(input as UpdateRulesInTrackingPlanV1Input);
        }

        /// <summary>
        /// Returns true if UpdateRulesInTrackingPlanV1Input instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateRulesInTrackingPlanV1Input to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateRulesInTrackingPlanV1Input input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Rules == input.Rules ||
                    this.Rules != null &&
                    input.Rules != null &&
                    this.Rules.SequenceEqual(input.Rules)
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
                if (this.Rules != null)
                {
                    hashCode = (hashCode * 59) + this.Rules.GetHashCode();
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
