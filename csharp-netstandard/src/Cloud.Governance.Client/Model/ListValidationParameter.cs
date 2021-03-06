

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
using OpenAPIDateConverter = Cloud.Governance.Client.Client.OpenAPIDateConverter;

namespace Cloud.Governance.Client.Model
{
    /// <summary>
    /// ListValidationParameter
    /// </summary>
    [DataContract(Name = "ListValidationParameter")]
    public partial class ListValidationParameter : IEquatable<ListValidationParameter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListValidationParameter" /> class.
        /// </summary>
        /// <param name="listUrl">listUrl.</param>
        /// <param name="parentUrl">parentUrl.</param>
        /// <param name="listTitle">listTitle.</param>
        /// <param name="isDocumentLibrary">isDocumentLibrary.</param>
        /// <param name="isEditTask">isEditTask.</param>
        /// <param name="isFromQuestionnaire">isFromQuestionnaire.</param>
        public ListValidationParameter(string listUrl = default(string), string parentUrl = default(string), string listTitle = default(string), bool isDocumentLibrary = default(bool), bool isEditTask = default(bool), bool isFromQuestionnaire = default(bool))
        {
            this.ListUrl = listUrl;
            this.ParentUrl = parentUrl;
            this.ListTitle = listTitle;
            this.IsDocumentLibrary = isDocumentLibrary;
            this.IsEditTask = isEditTask;
            this.IsFromQuestionnaire = isFromQuestionnaire;
        }

        /// <summary>
        /// Gets or Sets ListUrl
        /// </summary>
        [DataMember(Name = "listUrl", EmitDefaultValue = true)]
        public string ListUrl { get; set; }

        /// <summary>
        /// Gets or Sets ParentUrl
        /// </summary>
        [DataMember(Name = "parentUrl", EmitDefaultValue = true)]
        public string ParentUrl { get; set; }

        /// <summary>
        /// Gets or Sets ListTitle
        /// </summary>
        [DataMember(Name = "listTitle", EmitDefaultValue = true)]
        public string ListTitle { get; set; }

        /// <summary>
        /// Gets or Sets IsDocumentLibrary
        /// </summary>
        [DataMember(Name = "isDocumentLibrary", EmitDefaultValue = false)]
        public bool IsDocumentLibrary { get; set; }

        /// <summary>
        /// Gets or Sets IsEditTask
        /// </summary>
        [DataMember(Name = "isEditTask", EmitDefaultValue = false)]
        public bool IsEditTask { get; set; }

        /// <summary>
        /// Gets or Sets IsFromQuestionnaire
        /// </summary>
        [DataMember(Name = "isFromQuestionnaire", EmitDefaultValue = false)]
        public bool IsFromQuestionnaire { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListValidationParameter {\n");
            sb.Append("  ListUrl: ").Append(ListUrl).Append("\n");
            sb.Append("  ParentUrl: ").Append(ParentUrl).Append("\n");
            sb.Append("  ListTitle: ").Append(ListTitle).Append("\n");
            sb.Append("  IsDocumentLibrary: ").Append(IsDocumentLibrary).Append("\n");
            sb.Append("  IsEditTask: ").Append(IsEditTask).Append("\n");
            sb.Append("  IsFromQuestionnaire: ").Append(IsFromQuestionnaire).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListValidationParameter);
        }

        /// <summary>
        /// Returns true if ListValidationParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of ListValidationParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListValidationParameter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ListUrl == input.ListUrl ||
                    (this.ListUrl != null &&
                    this.ListUrl.Equals(input.ListUrl))
                ) && 
                (
                    this.ParentUrl == input.ParentUrl ||
                    (this.ParentUrl != null &&
                    this.ParentUrl.Equals(input.ParentUrl))
                ) && 
                (
                    this.ListTitle == input.ListTitle ||
                    (this.ListTitle != null &&
                    this.ListTitle.Equals(input.ListTitle))
                ) && 
                (
                    this.IsDocumentLibrary == input.IsDocumentLibrary ||
                    this.IsDocumentLibrary.Equals(input.IsDocumentLibrary)
                ) && 
                (
                    this.IsEditTask == input.IsEditTask ||
                    this.IsEditTask.Equals(input.IsEditTask)
                ) && 
                (
                    this.IsFromQuestionnaire == input.IsFromQuestionnaire ||
                    this.IsFromQuestionnaire.Equals(input.IsFromQuestionnaire)
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
                if (this.ListUrl != null)
                    hashCode = hashCode * 59 + this.ListUrl.GetHashCode();
                if (this.ParentUrl != null)
                    hashCode = hashCode * 59 + this.ParentUrl.GetHashCode();
                if (this.ListTitle != null)
                    hashCode = hashCode * 59 + this.ListTitle.GetHashCode();
                hashCode = hashCode * 59 + this.IsDocumentLibrary.GetHashCode();
                hashCode = hashCode * 59 + this.IsEditTask.GetHashCode();
                hashCode = hashCode * 59 + this.IsFromQuestionnaire.GetHashCode();
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
