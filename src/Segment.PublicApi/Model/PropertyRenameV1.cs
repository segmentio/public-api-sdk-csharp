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
    /// PropertyRenameV1
    /// </summary>
    [DataContract(Name = "PropertyRenameV1")]
    public partial class PropertyRenameV1 : IEquatable<PropertyRenameV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyRenameV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PropertyRenameV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyRenameV1" /> class.
        /// </summary>
        /// <param name="oldName">The old name of the property. (required).</param>
        /// <param name="newName">The new name to rename the property. (required).</param>
        public PropertyRenameV1(string oldName = default(string), string newName = default(string))
        {
            // to ensure "oldName" is required (not null)
            if (oldName == null)
            {
                throw new ArgumentNullException("oldName is a required property for PropertyRenameV1 and cannot be null");
            }
            this.OldName = oldName;
            // to ensure "newName" is required (not null)
            if (newName == null)
            {
                throw new ArgumentNullException("newName is a required property for PropertyRenameV1 and cannot be null");
            }
            this.NewName = newName;
        }

        /// <summary>
        /// The old name of the property.
        /// </summary>
        /// <value>The old name of the property.</value>
        [DataMember(Name = "oldName", IsRequired = true, EmitDefaultValue = true)]
        public string OldName { get; set; }

        /// <summary>
        /// The new name to rename the property.
        /// </summary>
        /// <value>The new name to rename the property.</value>
        [DataMember(Name = "newName", IsRequired = true, EmitDefaultValue = true)]
        public string NewName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PropertyRenameV1 {\n");
            sb.Append("  OldName: ").Append(OldName).Append("\n");
            sb.Append("  NewName: ").Append(NewName).Append("\n");
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
            return this.Equals(input as PropertyRenameV1);
        }

        /// <summary>
        /// Returns true if PropertyRenameV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertyRenameV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyRenameV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OldName == input.OldName ||
                    (this.OldName != null &&
                    this.OldName.Equals(input.OldName))
                ) && 
                (
                    this.NewName == input.NewName ||
                    (this.NewName != null &&
                    this.NewName.Equals(input.NewName))
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
                if (this.OldName != null)
                {
                    hashCode = (hashCode * 59) + this.OldName.GetHashCode();
                }
                if (this.NewName != null)
                {
                    hashCode = (hashCode * 59) + this.NewName.GetHashCode();
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
