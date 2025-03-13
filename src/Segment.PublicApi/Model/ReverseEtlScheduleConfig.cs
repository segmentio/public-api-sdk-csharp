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
using System.Reflection;

namespace Segment.PublicApi.Model
{
    /// <summary>
    /// ReverseEtlScheduleConfig
    /// </summary>
    [JsonConverter(typeof(ReverseEtlScheduleConfigJsonConverter))]
    [DataContract(Name = "ReverseEtlScheduleConfig")]
    public partial class ReverseEtlScheduleConfig : AbstractOpenAPISchema, IEquatable<ReverseEtlScheduleConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseEtlScheduleConfig" /> class
        /// with the <see cref="ReverseEtlPeriodicScheduleConfig" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ReverseEtlPeriodicScheduleConfig.</param>
        public ReverseEtlScheduleConfig(ReverseEtlPeriodicScheduleConfig actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseEtlScheduleConfig" /> class
        /// with the <see cref="ReverseEtlSpecificTimeScheduleConfig" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ReverseEtlSpecificTimeScheduleConfig.</param>
        public ReverseEtlScheduleConfig(ReverseEtlSpecificTimeScheduleConfig actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseEtlScheduleConfig" /> class
        /// with the <see cref="ReverseEtlCronScheduleConfig" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ReverseEtlCronScheduleConfig.</param>
        public ReverseEtlScheduleConfig(ReverseEtlCronScheduleConfig actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseEtlScheduleConfig" /> class
        /// with the <see cref="ReverseEtlDbtCloudScheduleConfig" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ReverseEtlDbtCloudScheduleConfig.</param>
        public ReverseEtlScheduleConfig(ReverseEtlDbtCloudScheduleConfig actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(ReverseEtlCronScheduleConfig))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ReverseEtlDbtCloudScheduleConfig))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ReverseEtlPeriodicScheduleConfig))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ReverseEtlSpecificTimeScheduleConfig))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: ReverseEtlCronScheduleConfig, ReverseEtlDbtCloudScheduleConfig, ReverseEtlPeriodicScheduleConfig, ReverseEtlSpecificTimeScheduleConfig");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `ReverseEtlPeriodicScheduleConfig`. If the actual instance is not `ReverseEtlPeriodicScheduleConfig`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ReverseEtlPeriodicScheduleConfig</returns>
        public ReverseEtlPeriodicScheduleConfig GetReverseEtlPeriodicScheduleConfig()
        {
            return (ReverseEtlPeriodicScheduleConfig)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ReverseEtlSpecificTimeScheduleConfig`. If the actual instance is not `ReverseEtlSpecificTimeScheduleConfig`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ReverseEtlSpecificTimeScheduleConfig</returns>
        public ReverseEtlSpecificTimeScheduleConfig GetReverseEtlSpecificTimeScheduleConfig()
        {
            return (ReverseEtlSpecificTimeScheduleConfig)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ReverseEtlCronScheduleConfig`. If the actual instance is not `ReverseEtlCronScheduleConfig`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ReverseEtlCronScheduleConfig</returns>
        public ReverseEtlCronScheduleConfig GetReverseEtlCronScheduleConfig()
        {
            return (ReverseEtlCronScheduleConfig)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ReverseEtlDbtCloudScheduleConfig`. If the actual instance is not `ReverseEtlDbtCloudScheduleConfig`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ReverseEtlDbtCloudScheduleConfig</returns>
        public ReverseEtlDbtCloudScheduleConfig GetReverseEtlDbtCloudScheduleConfig()
        {
            return (ReverseEtlDbtCloudScheduleConfig)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReverseEtlScheduleConfig {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, ReverseEtlScheduleConfig.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of ReverseEtlScheduleConfig
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of ReverseEtlScheduleConfig</returns>
        public static ReverseEtlScheduleConfig FromJson(string jsonString)
        {
            ReverseEtlScheduleConfig newReverseEtlScheduleConfig = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newReverseEtlScheduleConfig;
            }

            try
            {
                newReverseEtlScheduleConfig = new ReverseEtlScheduleConfig(JsonConvert.DeserializeObject<ReverseEtlCronScheduleConfig>(jsonString, ReverseEtlScheduleConfig.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newReverseEtlScheduleConfig;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ReverseEtlCronScheduleConfig: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newReverseEtlScheduleConfig = new ReverseEtlScheduleConfig(JsonConvert.DeserializeObject<ReverseEtlDbtCloudScheduleConfig>(jsonString, ReverseEtlScheduleConfig.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newReverseEtlScheduleConfig;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ReverseEtlDbtCloudScheduleConfig: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newReverseEtlScheduleConfig = new ReverseEtlScheduleConfig(JsonConvert.DeserializeObject<ReverseEtlPeriodicScheduleConfig>(jsonString, ReverseEtlScheduleConfig.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newReverseEtlScheduleConfig;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ReverseEtlPeriodicScheduleConfig: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newReverseEtlScheduleConfig = new ReverseEtlScheduleConfig(JsonConvert.DeserializeObject<ReverseEtlSpecificTimeScheduleConfig>(jsonString, ReverseEtlScheduleConfig.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newReverseEtlScheduleConfig;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ReverseEtlSpecificTimeScheduleConfig: {1}", jsonString, exception.ToString()));
            }

            // no match found, throw an exception
            throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReverseEtlScheduleConfig);
        }

        /// <summary>
        /// Returns true if ReverseEtlScheduleConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ReverseEtlScheduleConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReverseEtlScheduleConfig input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
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

    /// <summary>
    /// Custom JSON converter for ReverseEtlScheduleConfig
    /// </summary>
    public class ReverseEtlScheduleConfigJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(ReverseEtlScheduleConfig).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return ReverseEtlScheduleConfig.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
