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
    /// Represents a logo.
    /// </summary>
    [DataContract(Name = "LogosBeta")]
    public partial class LogosBeta : IEquatable<LogosBeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogosBeta" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LogosBeta() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LogosBeta" /> class.
        /// </summary>
        /// <param name="varDefault">The default URL for this logo. (required).</param>
        /// <param name="mark">The logo mark..</param>
        /// <param name="alt">The alternative text for this logo..</param>
        public LogosBeta(string varDefault = default(string), string mark = default(string), string alt = default(string))
        {
            // to ensure "varDefault" is required (not null)
            if (varDefault == null)
            {
                throw new ArgumentNullException("varDefault is a required property for LogosBeta and cannot be null");
            }
            this.VarDefault = varDefault;
            this.Mark = mark;
            this.Alt = alt;
        }

        /// <summary>
        /// The default URL for this logo.
        /// </summary>
        /// <value>The default URL for this logo.</value>
        [DataMember(Name = "default", IsRequired = true, EmitDefaultValue = true)]
        public string VarDefault { get; set; }

        /// <summary>
        /// The logo mark.
        /// </summary>
        /// <value>The logo mark.</value>
        [DataMember(Name = "mark", EmitDefaultValue = true)]
        public string Mark { get; set; }

        /// <summary>
        /// The alternative text for this logo.
        /// </summary>
        /// <value>The alternative text for this logo.</value>
        [DataMember(Name = "alt", EmitDefaultValue = true)]
        public string Alt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogosBeta {\n");
            sb.Append("  VarDefault: ").Append(VarDefault).Append("\n");
            sb.Append("  Mark: ").Append(Mark).Append("\n");
            sb.Append("  Alt: ").Append(Alt).Append("\n");
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
            return this.Equals(input as LogosBeta);
        }

        /// <summary>
        /// Returns true if LogosBeta instances are equal
        /// </summary>
        /// <param name="input">Instance of LogosBeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogosBeta input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VarDefault == input.VarDefault ||
                    (this.VarDefault != null &&
                    this.VarDefault.Equals(input.VarDefault))
                ) && 
                (
                    this.Mark == input.Mark ||
                    (this.Mark != null &&
                    this.Mark.Equals(input.Mark))
                ) && 
                (
                    this.Alt == input.Alt ||
                    (this.Alt != null &&
                    this.Alt.Equals(input.Alt))
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
                if (this.VarDefault != null)
                {
                    hashCode = (hashCode * 59) + this.VarDefault.GetHashCode();
                }
                if (this.Mark != null)
                {
                    hashCode = (hashCode * 59) + this.Mark.GetHashCode();
                }
                if (this.Alt != null)
                {
                    hashCode = (hashCode * 59) + this.Alt.GetHashCode();
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
