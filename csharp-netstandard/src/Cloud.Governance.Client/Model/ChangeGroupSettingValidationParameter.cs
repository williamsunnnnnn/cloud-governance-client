

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
    /// ChangeGroupSettingValidationParameter
    /// </summary>
    [DataContract(Name = "ChangeGroupSettingValidationParameter")]
    public partial class ChangeGroupSettingValidationParameter : IEquatable<ChangeGroupSettingValidationParameter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeGroupSettingValidationParameter" /> class.
        /// </summary>
        /// <param name="groupEmail">groupEmail.</param>
        /// <param name="groupId">groupId.</param>
        /// <param name="isEditTask">isEditTask.</param>
        /// <param name="isFromQuestionnaire">isFromQuestionnaire.</param>
        public ChangeGroupSettingValidationParameter(string groupEmail = default(string), Guid groupId = default(Guid), bool isEditTask = default(bool), bool isFromQuestionnaire = default(bool))
        {
            this.GroupEmail = groupEmail;
            this.GroupId = groupId;
            this.IsEditTask = isEditTask;
            this.IsFromQuestionnaire = isFromQuestionnaire;
        }

        /// <summary>
        /// Gets or Sets GroupEmail
        /// </summary>
        [DataMember(Name = "groupEmail", EmitDefaultValue = true)]
        public string GroupEmail { get; set; }

        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name = "groupId", EmitDefaultValue = false)]
        public Guid GroupId { get; set; }

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
            sb.Append("class ChangeGroupSettingValidationParameter {\n");
            sb.Append("  GroupEmail: ").Append(GroupEmail).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
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
            return this.Equals(input as ChangeGroupSettingValidationParameter);
        }

        /// <summary>
        /// Returns true if ChangeGroupSettingValidationParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeGroupSettingValidationParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeGroupSettingValidationParameter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupEmail == input.GroupEmail ||
                    (this.GroupEmail != null &&
                    this.GroupEmail.Equals(input.GroupEmail))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
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
                if (this.GroupEmail != null)
                    hashCode = hashCode * 59 + this.GroupEmail.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
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
