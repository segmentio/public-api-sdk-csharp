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
    /// Defines the parameters needed to trigger a manual sync for a RETL connection.
    /// </summary>
    [DataContract(Name = "CreateReverseETLManualSyncInput")]
    public partial class CreateReverseETLManualSyncInput : IEquatable<CreateReverseETLManualSyncInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReverseETLManualSyncInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateReverseETLManualSyncInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReverseETLManualSyncInput" /> class.
        /// </summary>
        /// <param name="sourceId">The id of the Source. (required).</param>
        /// <param name="modelId">The id of the Model. (required).</param>
        /// <param name="subscriptionId">The id of the Subscription. (required).</param>
        public CreateReverseETLManualSyncInput(string sourceId = default(string), string modelId = default(string), string subscriptionId = default(string))
        {
            // to ensure "sourceId" is required (not null)
            if (sourceId == null)
            {
                throw new ArgumentNullException("sourceId is a required property for CreateReverseETLManualSyncInput and cannot be null");
            }
            this.SourceId = sourceId;
            // to ensure "modelId" is required (not null)
            if (modelId == null)
            {
                throw new ArgumentNullException("modelId is a required property for CreateReverseETLManualSyncInput and cannot be null");
            }
            this.ModelId = modelId;
            // to ensure "subscriptionId" is required (not null)
            if (subscriptionId == null)
            {
                throw new ArgumentNullException("subscriptionId is a required property for CreateReverseETLManualSyncInput and cannot be null");
            }
            this.SubscriptionId = subscriptionId;
        }

        /// <summary>
        /// The id of the Source.
        /// </summary>
        /// <value>The id of the Source.</value>
        [DataMember(Name = "sourceId", IsRequired = true, EmitDefaultValue = true)]
        public string SourceId { get; set; }

        /// <summary>
        /// The id of the Model.
        /// </summary>
        /// <value>The id of the Model.</value>
        [DataMember(Name = "modelId", IsRequired = true, EmitDefaultValue = true)]
        public string ModelId { get; set; }

        /// <summary>
        /// The id of the Subscription.
        /// </summary>
        /// <value>The id of the Subscription.</value>
        [DataMember(Name = "subscriptionId", IsRequired = true, EmitDefaultValue = true)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateReverseETLManualSyncInput {\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  ModelId: ").Append(ModelId).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
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
            return this.Equals(input as CreateReverseETLManualSyncInput);
        }

        /// <summary>
        /// Returns true if CreateReverseETLManualSyncInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateReverseETLManualSyncInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateReverseETLManualSyncInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.ModelId == input.ModelId ||
                    (this.ModelId != null &&
                    this.ModelId.Equals(input.ModelId))
                ) && 
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))
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
                if (this.SourceId != null)
                {
                    hashCode = (hashCode * 59) + this.SourceId.GetHashCode();
                }
                if (this.ModelId != null)
                {
                    hashCode = (hashCode * 59) + this.ModelId.GetHashCode();
                }
                if (this.SubscriptionId != null)
                {
                    hashCode = (hashCode * 59) + this.SubscriptionId.GetHashCode();
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
