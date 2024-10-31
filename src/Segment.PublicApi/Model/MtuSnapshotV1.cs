/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 56.0.0
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
    /// A snapshot of MTU metrics within the given usage period.
    /// </summary>
    [DataContract(Name = "MtuSnapshotV1")]
    public partial class MtuSnapshotV1 : IEquatable<MtuSnapshotV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MtuSnapshotV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MtuSnapshotV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MtuSnapshotV1" /> class.
        /// </summary>
        /// <param name="periodStart">The start of the usage period, in unix time (seconds since epoch). (required).</param>
        /// <param name="periodEnd">The end of the usage period, in unix time (seconds since epoch). (required).</param>
        /// <param name="anonymous">A bigint of the number of anonymous users in this snapshot. (required).</param>
        /// <param name="anonymousIdentified">A bigint of the number of anonymous identified users in this snapshot. (required).</param>
        /// <param name="identified">A bigint of the number of identified users in this snapshot. (required).</param>
        /// <param name="neverIdentified">A bigint of the number of never identified users in this snapshot. (required).</param>
        /// <param name="timestamp">The timestamp of this snapshot within the billing cycle, in the ISO-8601 format. (required).</param>
        public MtuSnapshotV1(decimal periodStart = default(decimal), decimal periodEnd = default(decimal), string anonymous = default(string), string anonymousIdentified = default(string), string identified = default(string), string neverIdentified = default(string), string timestamp = default(string))
        {
            this.PeriodStart = periodStart;
            this.PeriodEnd = periodEnd;
            // to ensure "anonymous" is required (not null)
            if (anonymous == null)
            {
                throw new ArgumentNullException("anonymous is a required property for MtuSnapshotV1 and cannot be null");
            }
            this.Anonymous = anonymous;
            // to ensure "anonymousIdentified" is required (not null)
            if (anonymousIdentified == null)
            {
                throw new ArgumentNullException("anonymousIdentified is a required property for MtuSnapshotV1 and cannot be null");
            }
            this.AnonymousIdentified = anonymousIdentified;
            // to ensure "identified" is required (not null)
            if (identified == null)
            {
                throw new ArgumentNullException("identified is a required property for MtuSnapshotV1 and cannot be null");
            }
            this.Identified = identified;
            // to ensure "neverIdentified" is required (not null)
            if (neverIdentified == null)
            {
                throw new ArgumentNullException("neverIdentified is a required property for MtuSnapshotV1 and cannot be null");
            }
            this.NeverIdentified = neverIdentified;
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new ArgumentNullException("timestamp is a required property for MtuSnapshotV1 and cannot be null");
            }
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// The start of the usage period, in unix time (seconds since epoch).
        /// </summary>
        /// <value>The start of the usage period, in unix time (seconds since epoch).</value>
        [DataMember(Name = "periodStart", IsRequired = true, EmitDefaultValue = true)]
        public decimal PeriodStart { get; set; }

        /// <summary>
        /// The end of the usage period, in unix time (seconds since epoch).
        /// </summary>
        /// <value>The end of the usage period, in unix time (seconds since epoch).</value>
        [DataMember(Name = "periodEnd", IsRequired = true, EmitDefaultValue = true)]
        public decimal PeriodEnd { get; set; }

        /// <summary>
        /// A bigint of the number of anonymous users in this snapshot.
        /// </summary>
        /// <value>A bigint of the number of anonymous users in this snapshot.</value>
        [DataMember(Name = "anonymous", IsRequired = true, EmitDefaultValue = true)]
        public string Anonymous { get; set; }

        /// <summary>
        /// A bigint of the number of anonymous identified users in this snapshot.
        /// </summary>
        /// <value>A bigint of the number of anonymous identified users in this snapshot.</value>
        [DataMember(Name = "anonymousIdentified", IsRequired = true, EmitDefaultValue = true)]
        public string AnonymousIdentified { get; set; }

        /// <summary>
        /// A bigint of the number of identified users in this snapshot.
        /// </summary>
        /// <value>A bigint of the number of identified users in this snapshot.</value>
        [DataMember(Name = "identified", IsRequired = true, EmitDefaultValue = true)]
        public string Identified { get; set; }

        /// <summary>
        /// A bigint of the number of never identified users in this snapshot.
        /// </summary>
        /// <value>A bigint of the number of never identified users in this snapshot.</value>
        [DataMember(Name = "neverIdentified", IsRequired = true, EmitDefaultValue = true)]
        public string NeverIdentified { get; set; }

        /// <summary>
        /// The timestamp of this snapshot within the billing cycle, in the ISO-8601 format.
        /// </summary>
        /// <value>The timestamp of this snapshot within the billing cycle, in the ISO-8601 format.</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = true)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MtuSnapshotV1 {\n");
            sb.Append("  PeriodStart: ").Append(PeriodStart).Append("\n");
            sb.Append("  PeriodEnd: ").Append(PeriodEnd).Append("\n");
            sb.Append("  Anonymous: ").Append(Anonymous).Append("\n");
            sb.Append("  AnonymousIdentified: ").Append(AnonymousIdentified).Append("\n");
            sb.Append("  Identified: ").Append(Identified).Append("\n");
            sb.Append("  NeverIdentified: ").Append(NeverIdentified).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as MtuSnapshotV1);
        }

        /// <summary>
        /// Returns true if MtuSnapshotV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of MtuSnapshotV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MtuSnapshotV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PeriodStart == input.PeriodStart ||
                    this.PeriodStart.Equals(input.PeriodStart)
                ) && 
                (
                    this.PeriodEnd == input.PeriodEnd ||
                    this.PeriodEnd.Equals(input.PeriodEnd)
                ) && 
                (
                    this.Anonymous == input.Anonymous ||
                    (this.Anonymous != null &&
                    this.Anonymous.Equals(input.Anonymous))
                ) && 
                (
                    this.AnonymousIdentified == input.AnonymousIdentified ||
                    (this.AnonymousIdentified != null &&
                    this.AnonymousIdentified.Equals(input.AnonymousIdentified))
                ) && 
                (
                    this.Identified == input.Identified ||
                    (this.Identified != null &&
                    this.Identified.Equals(input.Identified))
                ) && 
                (
                    this.NeverIdentified == input.NeverIdentified ||
                    (this.NeverIdentified != null &&
                    this.NeverIdentified.Equals(input.NeverIdentified))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                hashCode = (hashCode * 59) + this.PeriodStart.GetHashCode();
                hashCode = (hashCode * 59) + this.PeriodEnd.GetHashCode();
                if (this.Anonymous != null)
                {
                    hashCode = (hashCode * 59) + this.Anonymous.GetHashCode();
                }
                if (this.AnonymousIdentified != null)
                {
                    hashCode = (hashCode * 59) + this.AnonymousIdentified.GetHashCode();
                }
                if (this.Identified != null)
                {
                    hashCode = (hashCode * 59) + this.Identified.GetHashCode();
                }
                if (this.NeverIdentified != null)
                {
                    hashCode = (hashCode * 59) + this.NeverIdentified.GetHashCode();
                }
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
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
