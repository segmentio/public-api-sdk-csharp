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
    /// Represents the output of loading the Workspace.
    /// </summary>
    [DataContract(Name = "GetWorkspaceV1Output")]
    public partial class GetWorkspaceV1Output : IEquatable<GetWorkspaceV1Output>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkspaceV1Output" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetWorkspaceV1Output() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkspaceV1Output" /> class.
        /// </summary>
        /// <param name="workspace">workspace (required).</param>
        public GetWorkspaceV1Output(WorkspaceV1 workspace = default(WorkspaceV1))
        {
            // to ensure "workspace" is required (not null)
            if (workspace == null)
            {
                throw new ArgumentNullException("workspace is a required property for GetWorkspaceV1Output and cannot be null");
            }
            this.Workspace = workspace;
        }

        /// <summary>
        /// Gets or Sets Workspace
        /// </summary>
        [DataMember(Name = "workspace", IsRequired = true, EmitDefaultValue = true)]
        public WorkspaceV1 Workspace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetWorkspaceV1Output {\n");
            sb.Append("  Workspace: ").Append(Workspace).Append("\n");
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
            return this.Equals(input as GetWorkspaceV1Output);
        }

        /// <summary>
        /// Returns true if GetWorkspaceV1Output instances are equal
        /// </summary>
        /// <param name="input">Instance of GetWorkspaceV1Output to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetWorkspaceV1Output input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Workspace == input.Workspace ||
                    (this.Workspace != null &&
                    this.Workspace.Equals(input.Workspace))
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
                if (this.Workspace != null)
                {
                    hashCode = (hashCode * 59) + this.Workspace.GetHashCode();
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
