/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.1.1
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
    /// Represents platforms that a given Destination supports.
    /// </summary>
    [DataContract(Name = "DestinationMetadataPlatformsV1")]
    public partial class DestinationMetadataPlatformsV1 : IEquatable<DestinationMetadataPlatformsV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationMetadataPlatformsV1" /> class.
        /// </summary>
        /// <param name="browser">Whether this Destination supports browser events..</param>
        /// <param name="server">Whether this Destination supports server events..</param>
        /// <param name="mobile">Whether this Destination supports mobile events..</param>
        /// <param name="warehouse">Whether this Destination supports Warehouse events..</param>
        /// <param name="cloudAppObject">Whether this Destination supports cloud app object events..</param>
        /// <param name="linkedAudiences">Whether this Destination supports linked audiences..</param>
        public DestinationMetadataPlatformsV1(bool browser = default(bool), bool server = default(bool), bool mobile = default(bool), bool warehouse = default(bool), bool cloudAppObject = default(bool), bool linkedAudiences = default(bool))
        {
            this.Browser = browser;
            this.Server = server;
            this.Mobile = mobile;
            this.Warehouse = warehouse;
            this.CloudAppObject = cloudAppObject;
            this.LinkedAudiences = linkedAudiences;
        }

        /// <summary>
        /// Whether this Destination supports browser events.
        /// </summary>
        /// <value>Whether this Destination supports browser events.</value>
        [DataMember(Name = "browser", EmitDefaultValue = true)]
        public bool Browser { get; set; }

        /// <summary>
        /// Whether this Destination supports server events.
        /// </summary>
        /// <value>Whether this Destination supports server events.</value>
        [DataMember(Name = "server", EmitDefaultValue = true)]
        public bool Server { get; set; }

        /// <summary>
        /// Whether this Destination supports mobile events.
        /// </summary>
        /// <value>Whether this Destination supports mobile events.</value>
        [DataMember(Name = "mobile", EmitDefaultValue = true)]
        public bool Mobile { get; set; }

        /// <summary>
        /// Whether this Destination supports Warehouse events.
        /// </summary>
        /// <value>Whether this Destination supports Warehouse events.</value>
        [DataMember(Name = "warehouse", EmitDefaultValue = true)]
        public bool Warehouse { get; set; }

        /// <summary>
        /// Whether this Destination supports cloud app object events.
        /// </summary>
        /// <value>Whether this Destination supports cloud app object events.</value>
        [DataMember(Name = "cloudAppObject", EmitDefaultValue = true)]
        public bool CloudAppObject { get; set; }

        /// <summary>
        /// Whether this Destination supports linked audiences.
        /// </summary>
        /// <value>Whether this Destination supports linked audiences.</value>
        [DataMember(Name = "linkedAudiences", EmitDefaultValue = true)]
        public bool LinkedAudiences { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinationMetadataPlatformsV1 {\n");
            sb.Append("  Browser: ").Append(Browser).Append("\n");
            sb.Append("  Server: ").Append(Server).Append("\n");
            sb.Append("  Mobile: ").Append(Mobile).Append("\n");
            sb.Append("  Warehouse: ").Append(Warehouse).Append("\n");
            sb.Append("  CloudAppObject: ").Append(CloudAppObject).Append("\n");
            sb.Append("  LinkedAudiences: ").Append(LinkedAudiences).Append("\n");
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
            return this.Equals(input as DestinationMetadataPlatformsV1);
        }

        /// <summary>
        /// Returns true if DestinationMetadataPlatformsV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinationMetadataPlatformsV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinationMetadataPlatformsV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Browser == input.Browser ||
                    this.Browser.Equals(input.Browser)
                ) && 
                (
                    this.Server == input.Server ||
                    this.Server.Equals(input.Server)
                ) && 
                (
                    this.Mobile == input.Mobile ||
                    this.Mobile.Equals(input.Mobile)
                ) && 
                (
                    this.Warehouse == input.Warehouse ||
                    this.Warehouse.Equals(input.Warehouse)
                ) && 
                (
                    this.CloudAppObject == input.CloudAppObject ||
                    this.CloudAppObject.Equals(input.CloudAppObject)
                ) && 
                (
                    this.LinkedAudiences == input.LinkedAudiences ||
                    this.LinkedAudiences.Equals(input.LinkedAudiences)
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
                hashCode = (hashCode * 59) + this.Browser.GetHashCode();
                hashCode = (hashCode * 59) + this.Server.GetHashCode();
                hashCode = (hashCode * 59) + this.Mobile.GetHashCode();
                hashCode = (hashCode * 59) + this.Warehouse.GetHashCode();
                hashCode = (hashCode * 59) + this.CloudAppObject.GetHashCode();
                hashCode = (hashCode * 59) + this.LinkedAudiences.GetHashCode();
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
