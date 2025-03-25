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
using System.Reflection;

namespace Segment.PublicApi.Model
{
    /// <summary>
    /// TransitionsInner
    /// </summary>
    [JsonConverter(typeof(TransitionsInnerJsonConverter))]
    [DataContract(Name = "transitions_inner")]
    public partial class TransitionsInner : AbstractOpenAPISchema, IEquatable<TransitionsInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransitionsInner" /> class
        /// with the <see cref="ConditionBranch" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ConditionBranch.</param>
        public TransitionsInner(ConditionBranch actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransitionsInner" /> class
        /// with the <see cref="TimeOutBranch" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of TimeOutBranch.</param>
        public TransitionsInner(TimeOutBranch actualInstance)
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
                if (value.GetType() == typeof(ConditionBranch))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(TimeOutBranch))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: ConditionBranch, TimeOutBranch");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `ConditionBranch`. If the actual instance is not `ConditionBranch`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ConditionBranch</returns>
        public ConditionBranch GetConditionBranch()
        {
            return (ConditionBranch)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `TimeOutBranch`. If the actual instance is not `TimeOutBranch`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of TimeOutBranch</returns>
        public TimeOutBranch GetTimeOutBranch()
        {
            return (TimeOutBranch)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransitionsInner {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, TransitionsInner.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of TransitionsInner
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of TransitionsInner</returns>
        public static TransitionsInner FromJson(string jsonString)
        {
            TransitionsInner newTransitionsInner = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newTransitionsInner;
            }

            try
            {
                newTransitionsInner = new TransitionsInner(JsonConvert.DeserializeObject<ConditionBranch>(jsonString, TransitionsInner.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newTransitionsInner;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ConditionBranch: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newTransitionsInner = new TransitionsInner(JsonConvert.DeserializeObject<TimeOutBranch>(jsonString, TransitionsInner.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newTransitionsInner;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into TimeOutBranch: {1}", jsonString, exception.ToString()));
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
            return this.Equals(input as TransitionsInner);
        }

        /// <summary>
        /// Returns true if TransitionsInner instances are equal
        /// </summary>
        /// <param name="input">Instance of TransitionsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransitionsInner input)
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
    /// Custom JSON converter for TransitionsInner
    /// </summary>
    public class TransitionsInnerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(TransitionsInner).GetMethod("ToJson").Invoke(value, null)));
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
                return TransitionsInner.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
