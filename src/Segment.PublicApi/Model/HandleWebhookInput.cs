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
    /// Function webhook input.
    /// </summary>
    [DataContract(Name = "HandleWebhookInput")]
    public partial class HandleWebhookInput : IEquatable<HandleWebhookInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HandleWebhookInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HandleWebhookInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HandleWebhookInput" /> class.
        /// </summary>
        /// <param name="w">The Workspace id. (required).</param>
        /// <param name="n">The webhook nonce. (required).</param>
        /// <param name="t">The webhook timestamp. (required).</param>
        /// <param name="s">The webhook signature. (required).</param>
        public HandleWebhookInput(string w = default(string), string n = default(string), string t = default(string), string s = default(string))
        {
            // to ensure "w" is required (not null)
            if (w == null)
            {
                throw new ArgumentNullException("w is a required property for HandleWebhookInput and cannot be null");
            }
            this.W = w;
            // to ensure "n" is required (not null)
            if (n == null)
            {
                throw new ArgumentNullException("n is a required property for HandleWebhookInput and cannot be null");
            }
            this.N = n;
            // to ensure "t" is required (not null)
            if (t == null)
            {
                throw new ArgumentNullException("t is a required property for HandleWebhookInput and cannot be null");
            }
            this.T = t;
            // to ensure "s" is required (not null)
            if (s == null)
            {
                throw new ArgumentNullException("s is a required property for HandleWebhookInput and cannot be null");
            }
            this.S = s;
        }

        /// <summary>
        /// The Workspace id.
        /// </summary>
        /// <value>The Workspace id.</value>
        [DataMember(Name = "w", IsRequired = true, EmitDefaultValue = true)]
        public string W { get; set; }

        /// <summary>
        /// The webhook nonce.
        /// </summary>
        /// <value>The webhook nonce.</value>
        [DataMember(Name = "n", IsRequired = true, EmitDefaultValue = true)]
        public string N { get; set; }

        /// <summary>
        /// The webhook timestamp.
        /// </summary>
        /// <value>The webhook timestamp.</value>
        [DataMember(Name = "t", IsRequired = true, EmitDefaultValue = true)]
        public string T { get; set; }

        /// <summary>
        /// The webhook signature.
        /// </summary>
        /// <value>The webhook signature.</value>
        [DataMember(Name = "s", IsRequired = true, EmitDefaultValue = true)]
        public string S { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HandleWebhookInput {\n");
            sb.Append("  W: ").Append(W).Append("\n");
            sb.Append("  N: ").Append(N).Append("\n");
            sb.Append("  T: ").Append(T).Append("\n");
            sb.Append("  S: ").Append(S).Append("\n");
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
            return this.Equals(input as HandleWebhookInput);
        }

        /// <summary>
        /// Returns true if HandleWebhookInput instances are equal
        /// </summary>
        /// <param name="input">Instance of HandleWebhookInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HandleWebhookInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.W == input.W ||
                    (this.W != null &&
                    this.W.Equals(input.W))
                ) && 
                (
                    this.N == input.N ||
                    (this.N != null &&
                    this.N.Equals(input.N))
                ) && 
                (
                    this.T == input.T ||
                    (this.T != null &&
                    this.T.Equals(input.T))
                ) && 
                (
                    this.S == input.S ||
                    (this.S != null &&
                    this.S.Equals(input.S))
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
                if (this.W != null)
                {
                    hashCode = (hashCode * 59) + this.W.GetHashCode();
                }
                if (this.N != null)
                {
                    hashCode = (hashCode * 59) + this.N.GetHashCode();
                }
                if (this.T != null)
                {
                    hashCode = (hashCode * 59) + this.T.GetHashCode();
                }
                if (this.S != null)
                {
                    hashCode = (hashCode * 59) + this.S.GetHashCode();
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
