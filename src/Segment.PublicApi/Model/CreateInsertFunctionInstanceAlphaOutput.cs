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
    /// Creates an insert Function instance.
    /// </summary>
    [DataContract(Name = "CreateInsertFunctionInstanceAlphaOutput")]
    public partial class CreateInsertFunctionInstanceAlphaOutput : IEquatable<CreateInsertFunctionInstanceAlphaOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInsertFunctionInstanceAlphaOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateInsertFunctionInstanceAlphaOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInsertFunctionInstanceAlphaOutput" /> class.
        /// </summary>
        /// <param name="insertFunctionInstance">insertFunctionInstance (required).</param>
        public CreateInsertFunctionInstanceAlphaOutput(InsertFunctionInstanceAlpha insertFunctionInstance = default(InsertFunctionInstanceAlpha))
        {
            // to ensure "insertFunctionInstance" is required (not null)
            if (insertFunctionInstance == null)
            {
                throw new ArgumentNullException("insertFunctionInstance is a required property for CreateInsertFunctionInstanceAlphaOutput and cannot be null");
            }
            this.InsertFunctionInstance = insertFunctionInstance;
        }

        /// <summary>
        /// Gets or Sets InsertFunctionInstance
        /// </summary>
        [DataMember(Name = "insertFunctionInstance", IsRequired = true, EmitDefaultValue = true)]
        public InsertFunctionInstanceAlpha InsertFunctionInstance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateInsertFunctionInstanceAlphaOutput {\n");
            sb.Append("  InsertFunctionInstance: ").Append(InsertFunctionInstance).Append("\n");
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
            return this.Equals(input as CreateInsertFunctionInstanceAlphaOutput);
        }

        /// <summary>
        /// Returns true if CreateInsertFunctionInstanceAlphaOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateInsertFunctionInstanceAlphaOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateInsertFunctionInstanceAlphaOutput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InsertFunctionInstance == input.InsertFunctionInstance ||
                    (this.InsertFunctionInstance != null &&
                    this.InsertFunctionInstance.Equals(input.InsertFunctionInstance))
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
                if (this.InsertFunctionInstance != null)
                {
                    hashCode = (hashCode * 59) + this.InsertFunctionInstance.GetHashCode();
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
