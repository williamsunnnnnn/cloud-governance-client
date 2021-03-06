

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
    /// ManagePermissionOption
    /// </summary>
    [DataContract(Name = "ManagePermissionOption")]
    public partial class ManagePermissionOption : IEquatable<ManagePermissionOption>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagePermissionOption" /> class.
        /// </summary>
        /// <param name="grantPermissionSetting">grantPermissionSetting.</param>
        /// <param name="isEnableEditPermission">isEnableEditPermission.</param>
        /// <param name="isEnableRemovePermission">isEnableRemovePermission.</param>
        /// <param name="isEnableStopInheritPermission">isEnableStopInheritPermission.</param>
        /// <param name="isEnableDeleteUniquePermission">isEnableDeleteUniquePermission.</param>
        /// <param name="isEnableExcludePermissionLevel">isEnableExcludePermissionLevel.</param>
        /// <param name="isHideExcludePermissionItem">isHideExcludePermissionItem.</param>
        /// <param name="excludedPermissionLevles">excludedPermissionLevles.</param>
        public ManagePermissionOption(ManagePermissionGrantSetting grantPermissionSetting = default(ManagePermissionGrantSetting), bool isEnableEditPermission = default(bool), bool isEnableRemovePermission = default(bool), bool isEnableStopInheritPermission = default(bool), bool isEnableDeleteUniquePermission = default(bool), bool isEnableExcludePermissionLevel = default(bool), bool isHideExcludePermissionItem = default(bool), List<PermissionLevel> excludedPermissionLevles = default(List<PermissionLevel>))
        {
            this.GrantPermissionSetting = grantPermissionSetting;
            this.IsEnableEditPermission = isEnableEditPermission;
            this.IsEnableRemovePermission = isEnableRemovePermission;
            this.IsEnableStopInheritPermission = isEnableStopInheritPermission;
            this.IsEnableDeleteUniquePermission = isEnableDeleteUniquePermission;
            this.IsEnableExcludePermissionLevel = isEnableExcludePermissionLevel;
            this.IsHideExcludePermissionItem = isHideExcludePermissionItem;
            this.ExcludedPermissionLevles = excludedPermissionLevles;
        }

        /// <summary>
        /// Gets or Sets GrantPermissionSetting
        /// </summary>
        [DataMember(Name = "grantPermissionSetting", EmitDefaultValue = true)]
        public ManagePermissionGrantSetting GrantPermissionSetting { get; set; }

        /// <summary>
        /// Gets or Sets IsEnableEditPermission
        /// </summary>
        [DataMember(Name = "isEnableEditPermission", EmitDefaultValue = false)]
        public bool IsEnableEditPermission { get; set; }

        /// <summary>
        /// Gets or Sets IsEnableRemovePermission
        /// </summary>
        [DataMember(Name = "isEnableRemovePermission", EmitDefaultValue = false)]
        public bool IsEnableRemovePermission { get; set; }

        /// <summary>
        /// Gets or Sets IsEnableStopInheritPermission
        /// </summary>
        [DataMember(Name = "isEnableStopInheritPermission", EmitDefaultValue = false)]
        public bool IsEnableStopInheritPermission { get; set; }

        /// <summary>
        /// Gets or Sets IsEnableDeleteUniquePermission
        /// </summary>
        [DataMember(Name = "isEnableDeleteUniquePermission", EmitDefaultValue = false)]
        public bool IsEnableDeleteUniquePermission { get; set; }

        /// <summary>
        /// Gets or Sets IsEnableExcludePermissionLevel
        /// </summary>
        [DataMember(Name = "isEnableExcludePermissionLevel", EmitDefaultValue = false)]
        public bool IsEnableExcludePermissionLevel { get; set; }

        /// <summary>
        /// Gets or Sets IsHideExcludePermissionItem
        /// </summary>
        [DataMember(Name = "isHideExcludePermissionItem", EmitDefaultValue = false)]
        public bool IsHideExcludePermissionItem { get; set; }

        /// <summary>
        /// Gets or Sets ExcludedPermissionLevles
        /// </summary>
        [DataMember(Name = "excludedPermissionLevles", EmitDefaultValue = true)]
        public List<PermissionLevel> ExcludedPermissionLevles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManagePermissionOption {\n");
            sb.Append("  GrantPermissionSetting: ").Append(GrantPermissionSetting).Append("\n");
            sb.Append("  IsEnableEditPermission: ").Append(IsEnableEditPermission).Append("\n");
            sb.Append("  IsEnableRemovePermission: ").Append(IsEnableRemovePermission).Append("\n");
            sb.Append("  IsEnableStopInheritPermission: ").Append(IsEnableStopInheritPermission).Append("\n");
            sb.Append("  IsEnableDeleteUniquePermission: ").Append(IsEnableDeleteUniquePermission).Append("\n");
            sb.Append("  IsEnableExcludePermissionLevel: ").Append(IsEnableExcludePermissionLevel).Append("\n");
            sb.Append("  IsHideExcludePermissionItem: ").Append(IsHideExcludePermissionItem).Append("\n");
            sb.Append("  ExcludedPermissionLevles: ").Append(ExcludedPermissionLevles).Append("\n");
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
            return this.Equals(input as ManagePermissionOption);
        }

        /// <summary>
        /// Returns true if ManagePermissionOption instances are equal
        /// </summary>
        /// <param name="input">Instance of ManagePermissionOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManagePermissionOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GrantPermissionSetting == input.GrantPermissionSetting ||
                    (this.GrantPermissionSetting != null &&
                    this.GrantPermissionSetting.Equals(input.GrantPermissionSetting))
                ) && 
                (
                    this.IsEnableEditPermission == input.IsEnableEditPermission ||
                    this.IsEnableEditPermission.Equals(input.IsEnableEditPermission)
                ) && 
                (
                    this.IsEnableRemovePermission == input.IsEnableRemovePermission ||
                    this.IsEnableRemovePermission.Equals(input.IsEnableRemovePermission)
                ) && 
                (
                    this.IsEnableStopInheritPermission == input.IsEnableStopInheritPermission ||
                    this.IsEnableStopInheritPermission.Equals(input.IsEnableStopInheritPermission)
                ) && 
                (
                    this.IsEnableDeleteUniquePermission == input.IsEnableDeleteUniquePermission ||
                    this.IsEnableDeleteUniquePermission.Equals(input.IsEnableDeleteUniquePermission)
                ) && 
                (
                    this.IsEnableExcludePermissionLevel == input.IsEnableExcludePermissionLevel ||
                    this.IsEnableExcludePermissionLevel.Equals(input.IsEnableExcludePermissionLevel)
                ) && 
                (
                    this.IsHideExcludePermissionItem == input.IsHideExcludePermissionItem ||
                    this.IsHideExcludePermissionItem.Equals(input.IsHideExcludePermissionItem)
                ) && 
                (
                    this.ExcludedPermissionLevles == input.ExcludedPermissionLevles ||
                    this.ExcludedPermissionLevles != null &&
                    input.ExcludedPermissionLevles != null &&
                    this.ExcludedPermissionLevles.SequenceEqual(input.ExcludedPermissionLevles)
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
                if (this.GrantPermissionSetting != null)
                    hashCode = hashCode * 59 + this.GrantPermissionSetting.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnableEditPermission.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnableRemovePermission.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnableStopInheritPermission.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnableDeleteUniquePermission.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnableExcludePermissionLevel.GetHashCode();
                hashCode = hashCode * 59 + this.IsHideExcludePermissionItem.GetHashCode();
                if (this.ExcludedPermissionLevles != null)
                    hashCode = hashCode * 59 + this.ExcludedPermissionLevles.GetHashCode();
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
