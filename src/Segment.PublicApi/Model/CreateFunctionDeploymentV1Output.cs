/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 55.2.0
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
    /// Updates the deployment for a Source Function instance.
    /// </summary>
    [DataContract(Name = "CreateFunctionDeploymentV1Output")]
    public partial class CreateFunctionDeploymentV1Output : IEquatable<CreateFunctionDeploymentV1Output>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFunctionDeploymentV1Output" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateFunctionDeploymentV1Output() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFunctionDeploymentV1Output" /> class.
        /// </summary>
        /// <param name="functionDeployment">functionDeployment (required).</param>
        public CreateFunctionDeploymentV1Output(FunctionDeployment functionDeployment = default(FunctionDeployment))
        {
            // to ensure "functionDeployment" is required (not null)
            if (functionDeployment == null)
            {
                throw new ArgumentNullException("functionDeployment is a required property for CreateFunctionDeploymentV1Output and cannot be null");
            }
            this.FunctionDeployment = functionDeployment;
        }

        /// <summary>
        /// Gets or Sets FunctionDeployment
        /// </summary>
        [DataMember(Name = "functionDeployment", IsRequired = true, EmitDefaultValue = true)]
        public FunctionDeployment FunctionDeployment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateFunctionDeploymentV1Output {\n");
            sb.Append("  FunctionDeployment: ").Append(FunctionDeployment).Append("\n");
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
            return this.Equals(input as CreateFunctionDeploymentV1Output);
        }

        /// <summary>
        /// Returns true if CreateFunctionDeploymentV1Output instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateFunctionDeploymentV1Output to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateFunctionDeploymentV1Output input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FunctionDeployment == input.FunctionDeployment ||
                    (this.FunctionDeployment != null &&
                    this.FunctionDeployment.Equals(input.FunctionDeployment))
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
                if (this.FunctionDeployment != null)
                {
                    hashCode = (hashCode * 59) + this.FunctionDeployment.GetHashCode();
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
