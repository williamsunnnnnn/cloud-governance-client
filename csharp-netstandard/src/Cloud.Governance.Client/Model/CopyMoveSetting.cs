

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
    /// CopyMoveSetting
    /// </summary>
    [DataContract(Name = "CopyMoveSetting")]
    public partial class CopyMoveSetting : IEquatable<CopyMoveSetting>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ColumnsAndContentConflictResolution
        /// </summary>
        [DataMember(Name = "columnsAndContentConflictResolution", EmitDefaultValue = false)]
        public ItemConflictResolutionType? ColumnsAndContentConflictResolution { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CopyMoveSetting" /> class.
        /// </summary>
        /// <param name="isMigrateConfiguration">isMigrateConfiguration.</param>
        /// <param name="isKeepLookAndFeel">isKeepLookAndFeel.</param>
        /// <param name="columnsAndContentConflictResolution">columnsAndContentConflictResolution.</param>
        /// <param name="isMigrateSecurity">isMigrateSecurity.</param>
        /// <param name="isMigrateColumnsAndContentTypes">isMigrateColumnsAndContentTypes.</param>
        /// <param name="isMigrateContent">isMigrateContent.</param>
        /// <param name="isMigrateContentIncludeListAttachment">isMigrateContentIncludeListAttachment.</param>
        public CopyMoveSetting(bool isMigrateConfiguration = default(bool), bool isKeepLookAndFeel = default(bool), ItemConflictResolutionType? columnsAndContentConflictResolution = default(ItemConflictResolutionType?), bool isMigrateSecurity = default(bool), bool isMigrateColumnsAndContentTypes = default(bool), bool isMigrateContent = default(bool), bool isMigrateContentIncludeListAttachment = default(bool))
        {
            this.IsMigrateConfiguration = isMigrateConfiguration;
            this.IsKeepLookAndFeel = isKeepLookAndFeel;
            this.ColumnsAndContentConflictResolution = columnsAndContentConflictResolution;
            this.IsMigrateSecurity = isMigrateSecurity;
            this.IsMigrateColumnsAndContentTypes = isMigrateColumnsAndContentTypes;
            this.IsMigrateContent = isMigrateContent;
            this.IsMigrateContentIncludeListAttachment = isMigrateContentIncludeListAttachment;
        }

        /// <summary>
        /// Gets or Sets IsMigrateConfiguration
        /// </summary>
        [DataMember(Name = "isMigrateConfiguration", EmitDefaultValue = false)]
        public bool IsMigrateConfiguration { get; set; }

        /// <summary>
        /// Gets or Sets IsKeepLookAndFeel
        /// </summary>
        [DataMember(Name = "isKeepLookAndFeel", EmitDefaultValue = false)]
        public bool IsKeepLookAndFeel { get; set; }

        /// <summary>
        /// Gets or Sets IsMigrateSecurity
        /// </summary>
        [DataMember(Name = "isMigrateSecurity", EmitDefaultValue = false)]
        public bool IsMigrateSecurity { get; set; }

        /// <summary>
        /// Gets or Sets IsMigrateColumnsAndContentTypes
        /// </summary>
        [DataMember(Name = "isMigrateColumnsAndContentTypes", EmitDefaultValue = false)]
        public bool IsMigrateColumnsAndContentTypes { get; set; }

        /// <summary>
        /// Gets or Sets IsMigrateContent
        /// </summary>
        [DataMember(Name = "isMigrateContent", EmitDefaultValue = false)]
        public bool IsMigrateContent { get; set; }

        /// <summary>
        /// Gets or Sets IsMigrateContentIncludeListAttachment
        /// </summary>
        [DataMember(Name = "isMigrateContentIncludeListAttachment", EmitDefaultValue = false)]
        public bool IsMigrateContentIncludeListAttachment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CopyMoveSetting {\n");
            sb.Append("  IsMigrateConfiguration: ").Append(IsMigrateConfiguration).Append("\n");
            sb.Append("  IsKeepLookAndFeel: ").Append(IsKeepLookAndFeel).Append("\n");
            sb.Append("  ColumnsAndContentConflictResolution: ").Append(ColumnsAndContentConflictResolution).Append("\n");
            sb.Append("  IsMigrateSecurity: ").Append(IsMigrateSecurity).Append("\n");
            sb.Append("  IsMigrateColumnsAndContentTypes: ").Append(IsMigrateColumnsAndContentTypes).Append("\n");
            sb.Append("  IsMigrateContent: ").Append(IsMigrateContent).Append("\n");
            sb.Append("  IsMigrateContentIncludeListAttachment: ").Append(IsMigrateContentIncludeListAttachment).Append("\n");
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
            return this.Equals(input as CopyMoveSetting);
        }

        /// <summary>
        /// Returns true if CopyMoveSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of CopyMoveSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CopyMoveSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsMigrateConfiguration == input.IsMigrateConfiguration ||
                    this.IsMigrateConfiguration.Equals(input.IsMigrateConfiguration)
                ) && 
                (
                    this.IsKeepLookAndFeel == input.IsKeepLookAndFeel ||
                    this.IsKeepLookAndFeel.Equals(input.IsKeepLookAndFeel)
                ) && 
                (
                    this.ColumnsAndContentConflictResolution == input.ColumnsAndContentConflictResolution ||
                    this.ColumnsAndContentConflictResolution.Equals(input.ColumnsAndContentConflictResolution)
                ) && 
                (
                    this.IsMigrateSecurity == input.IsMigrateSecurity ||
                    this.IsMigrateSecurity.Equals(input.IsMigrateSecurity)
                ) && 
                (
                    this.IsMigrateColumnsAndContentTypes == input.IsMigrateColumnsAndContentTypes ||
                    this.IsMigrateColumnsAndContentTypes.Equals(input.IsMigrateColumnsAndContentTypes)
                ) && 
                (
                    this.IsMigrateContent == input.IsMigrateContent ||
                    this.IsMigrateContent.Equals(input.IsMigrateContent)
                ) && 
                (
                    this.IsMigrateContentIncludeListAttachment == input.IsMigrateContentIncludeListAttachment ||
                    this.IsMigrateContentIncludeListAttachment.Equals(input.IsMigrateContentIncludeListAttachment)
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
                hashCode = hashCode * 59 + this.IsMigrateConfiguration.GetHashCode();
                hashCode = hashCode * 59 + this.IsKeepLookAndFeel.GetHashCode();
                hashCode = hashCode * 59 + this.ColumnsAndContentConflictResolution.GetHashCode();
                hashCode = hashCode * 59 + this.IsMigrateSecurity.GetHashCode();
                hashCode = hashCode * 59 + this.IsMigrateColumnsAndContentTypes.GetHashCode();
                hashCode = hashCode * 59 + this.IsMigrateContent.GetHashCode();
                hashCode = hashCode * 59 + this.IsMigrateContentIncludeListAttachment.GetHashCode();
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
