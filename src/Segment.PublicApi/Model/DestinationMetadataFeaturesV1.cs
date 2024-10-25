/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 55.1.0
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
    /// Represents features that a given Destination supports.
    /// </summary>
    [DataContract(Name = "DestinationMetadataFeaturesV1")]
    public partial class DestinationMetadataFeaturesV1 : IEquatable<DestinationMetadataFeaturesV1>, IValidatableObject
    {
        /// <summary>
        /// This Destination&#39;s support level for cloud mode instances. The values &#39;0&#39; and &#39;NONE&#39;, and &#39;1&#39; and &#39;SINGLE&#39; are equivalent.
        /// </summary>
        /// <value>This Destination&#39;s support level for cloud mode instances. The values &#39;0&#39; and &#39;NONE&#39;, and &#39;1&#39; and &#39;SINGLE&#39; are equivalent.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CloudModeInstancesEnum
        {
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            [EnumMember(Value = "0")]
            _0 = 1,

            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            [EnumMember(Value = "1")]
            _1 = 2,

            /// <summary>
            /// Enum MULTIPLE for value: MULTIPLE
            /// </summary>
            [EnumMember(Value = "MULTIPLE")]
            MULTIPLE = 3,

            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE = 4,

            /// <summary>
            /// Enum SINGLE for value: SINGLE
            /// </summary>
            [EnumMember(Value = "SINGLE")]
            SINGLE = 5
        }


        /// <summary>
        /// This Destination&#39;s support level for cloud mode instances. The values &#39;0&#39; and &#39;NONE&#39;, and &#39;1&#39; and &#39;SINGLE&#39; are equivalent.
        /// </summary>
        /// <value>This Destination&#39;s support level for cloud mode instances. The values &#39;0&#39; and &#39;NONE&#39;, and &#39;1&#39; and &#39;SINGLE&#39; are equivalent.</value>
        [DataMember(Name = "cloudModeInstances", EmitDefaultValue = false)]
        public CloudModeInstancesEnum? CloudModeInstances { get; set; }
        /// <summary>
        /// This Destination&#39;s support level for device mode instances. Support for multiple device mode instances is currently not planned. The values &#39;0&#39; and &#39;NONE&#39;, and &#39;1&#39; and &#39;SINGLE&#39; are equivalent.
        /// </summary>
        /// <value>This Destination&#39;s support level for device mode instances. Support for multiple device mode instances is currently not planned. The values &#39;0&#39; and &#39;NONE&#39;, and &#39;1&#39; and &#39;SINGLE&#39; are equivalent.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeviceModeInstancesEnum
        {
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            [EnumMember(Value = "0")]
            _0 = 1,

            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            [EnumMember(Value = "1")]
            _1 = 2,

            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE = 3,

            /// <summary>
            /// Enum SINGLE for value: SINGLE
            /// </summary>
            [EnumMember(Value = "SINGLE")]
            SINGLE = 4
        }


        /// <summary>
        /// This Destination&#39;s support level for device mode instances. Support for multiple device mode instances is currently not planned. The values &#39;0&#39; and &#39;NONE&#39;, and &#39;1&#39; and &#39;SINGLE&#39; are equivalent.
        /// </summary>
        /// <value>This Destination&#39;s support level for device mode instances. Support for multiple device mode instances is currently not planned. The values &#39;0&#39; and &#39;NONE&#39;, and &#39;1&#39; and &#39;SINGLE&#39; are equivalent.</value>
        [DataMember(Name = "deviceModeInstances", EmitDefaultValue = false)]
        public DeviceModeInstancesEnum? DeviceModeInstances { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationMetadataFeaturesV1" /> class.
        /// </summary>
        /// <param name="cloudModeInstances">This Destination&#39;s support level for cloud mode instances. The values &#39;0&#39; and &#39;NONE&#39;, and &#39;1&#39; and &#39;SINGLE&#39; are equivalent..</param>
        /// <param name="deviceModeInstances">This Destination&#39;s support level for device mode instances. Support for multiple device mode instances is currently not planned. The values &#39;0&#39; and &#39;NONE&#39;, and &#39;1&#39; and &#39;SINGLE&#39; are equivalent..</param>
        /// <param name="replay">Whether this Destination supports replays..</param>
        /// <param name="browserUnbundling">Whether this Destination supports browser unbundling..</param>
        /// <param name="browserUnbundlingPublic">Whether this Destination supports public browser unbundling..</param>
        public DestinationMetadataFeaturesV1(CloudModeInstancesEnum? cloudModeInstances = default(CloudModeInstancesEnum?), DeviceModeInstancesEnum? deviceModeInstances = default(DeviceModeInstancesEnum?), bool replay = default(bool), bool browserUnbundling = default(bool), bool browserUnbundlingPublic = default(bool))
        {
            this.CloudModeInstances = cloudModeInstances;
            this.DeviceModeInstances = deviceModeInstances;
            this.Replay = replay;
            this.BrowserUnbundling = browserUnbundling;
            this.BrowserUnbundlingPublic = browserUnbundlingPublic;
        }

        /// <summary>
        /// Whether this Destination supports replays.
        /// </summary>
        /// <value>Whether this Destination supports replays.</value>
        [DataMember(Name = "replay", EmitDefaultValue = true)]
        public bool Replay { get; set; }

        /// <summary>
        /// Whether this Destination supports browser unbundling.
        /// </summary>
        /// <value>Whether this Destination supports browser unbundling.</value>
        [DataMember(Name = "browserUnbundling", EmitDefaultValue = true)]
        public bool BrowserUnbundling { get; set; }

        /// <summary>
        /// Whether this Destination supports public browser unbundling.
        /// </summary>
        /// <value>Whether this Destination supports public browser unbundling.</value>
        [DataMember(Name = "browserUnbundlingPublic", EmitDefaultValue = true)]
        public bool BrowserUnbundlingPublic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinationMetadataFeaturesV1 {\n");
            sb.Append("  CloudModeInstances: ").Append(CloudModeInstances).Append("\n");
            sb.Append("  DeviceModeInstances: ").Append(DeviceModeInstances).Append("\n");
            sb.Append("  Replay: ").Append(Replay).Append("\n");
            sb.Append("  BrowserUnbundling: ").Append(BrowserUnbundling).Append("\n");
            sb.Append("  BrowserUnbundlingPublic: ").Append(BrowserUnbundlingPublic).Append("\n");
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
            return this.Equals(input as DestinationMetadataFeaturesV1);
        }

        /// <summary>
        /// Returns true if DestinationMetadataFeaturesV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinationMetadataFeaturesV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinationMetadataFeaturesV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CloudModeInstances == input.CloudModeInstances ||
                    this.CloudModeInstances.Equals(input.CloudModeInstances)
                ) && 
                (
                    this.DeviceModeInstances == input.DeviceModeInstances ||
                    this.DeviceModeInstances.Equals(input.DeviceModeInstances)
                ) && 
                (
                    this.Replay == input.Replay ||
                    this.Replay.Equals(input.Replay)
                ) && 
                (
                    this.BrowserUnbundling == input.BrowserUnbundling ||
                    this.BrowserUnbundling.Equals(input.BrowserUnbundling)
                ) && 
                (
                    this.BrowserUnbundlingPublic == input.BrowserUnbundlingPublic ||
                    this.BrowserUnbundlingPublic.Equals(input.BrowserUnbundlingPublic)
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
                hashCode = (hashCode * 59) + this.CloudModeInstances.GetHashCode();
                hashCode = (hashCode * 59) + this.DeviceModeInstances.GetHashCode();
                hashCode = (hashCode * 59) + this.Replay.GetHashCode();
                hashCode = (hashCode * 59) + this.BrowserUnbundling.GetHashCode();
                hashCode = (hashCode * 59) + this.BrowserUnbundlingPublic.GetHashCode();
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
