/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.2.0
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
    /// Returns the status of a Warehouse connection settings after an attempt to connect to it.
    /// </summary>
    [DataContract(Name = "GetConnectionStateFromWarehouseV1Output")]
    public partial class GetConnectionStateFromWarehouseV1Output : IEquatable<GetConnectionStateFromWarehouseV1Output>, IValidatableObject
    {
        /// <summary>
        /// Represents the status for the current connection settings.
        /// </summary>
        /// <value>Represents the status for the current connection settings.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConnectionStateEnum
        {
            /// <summary>
            /// Enum CONNECTED for value: CONNECTED
            /// </summary>
            [EnumMember(Value = "CONNECTED")]
            CONNECTED = 1,

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED = 2
        }


        /// <summary>
        /// Represents the status for the current connection settings.
        /// </summary>
        /// <value>Represents the status for the current connection settings.</value>
        [DataMember(Name = "connectionState", IsRequired = true, EmitDefaultValue = true)]
        public ConnectionStateEnum ConnectionState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectionStateFromWarehouseV1Output" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetConnectionStateFromWarehouseV1Output() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectionStateFromWarehouseV1Output" /> class.
        /// </summary>
        /// <param name="connectionState">Represents the status for the current connection settings. (required).</param>
        public GetConnectionStateFromWarehouseV1Output(ConnectionStateEnum connectionState = default(ConnectionStateEnum))
        {
            this.ConnectionState = connectionState;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetConnectionStateFromWarehouseV1Output {\n");
            sb.Append("  ConnectionState: ").Append(ConnectionState).Append("\n");
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
            return this.Equals(input as GetConnectionStateFromWarehouseV1Output);
        }

        /// <summary>
        /// Returns true if GetConnectionStateFromWarehouseV1Output instances are equal
        /// </summary>
        /// <param name="input">Instance of GetConnectionStateFromWarehouseV1Output to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetConnectionStateFromWarehouseV1Output input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConnectionState == input.ConnectionState ||
                    this.ConnectionState.Equals(input.ConnectionState)
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
                hashCode = (hashCode * 59) + this.ConnectionState.GetHashCode();
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
