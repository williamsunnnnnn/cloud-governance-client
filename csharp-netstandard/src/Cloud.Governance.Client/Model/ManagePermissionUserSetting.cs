

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
    /// ManagePermissionUserSetting
    /// </summary>
    [DataContract(Name = "ManagePermissionUserSetting")]
    public partial class ManagePermissionUserSetting : IEquatable<ManagePermissionUserSetting>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets UserLevelRestrictionType
        /// </summary>
        [DataMember(Name = "userLevelRestrictionType", EmitDefaultValue = false)]
        public UserLevelRestrictionType? UserLevelRestrictionType { get; set; }
        /// <summary>
        /// Gets or Sets UserManagementSourceType
        /// </summary>
        [DataMember(Name = "userManagementSourceType", EmitDefaultValue = false)]
        public UserManagementSourceType? UserManagementSourceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagePermissionUserSetting" /> class.
        /// </summary>
        /// <param name="userLevelRestrictionType">userLevelRestrictionType.</param>
        /// <param name="userManagementSourceType">userManagementSourceType.</param>
        /// <param name="isEnableShowAADGroupMembers">isEnableShowAADGroupMembers.</param>
        public ManagePermissionUserSetting(UserLevelRestrictionType? userLevelRestrictionType = default(UserLevelRestrictionType?), UserManagementSourceType? userManagementSourceType = default(UserManagementSourceType?), bool isEnableShowAADGroupMembers = default(bool))
        {
            this.UserLevelRestrictionType = userLevelRestrictionType;
            this.UserManagementSourceType = userManagementSourceType;
            this.IsEnableShowAADGroupMembers = isEnableShowAADGroupMembers;
        }

        /// <summary>
        /// Gets or Sets IsEnableShowAADGroupMembers
        /// </summary>
        [DataMember(Name = "isEnableShowAADGroupMembers", EmitDefaultValue = false)]
        public bool IsEnableShowAADGroupMembers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManagePermissionUserSetting {\n");
            sb.Append("  UserLevelRestrictionType: ").Append(UserLevelRestrictionType).Append("\n");
            sb.Append("  UserManagementSourceType: ").Append(UserManagementSourceType).Append("\n");
            sb.Append("  IsEnableShowAADGroupMembers: ").Append(IsEnableShowAADGroupMembers).Append("\n");
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
            return this.Equals(input as ManagePermissionUserSetting);
        }

        /// <summary>
        /// Returns true if ManagePermissionUserSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of ManagePermissionUserSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManagePermissionUserSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserLevelRestrictionType == input.UserLevelRestrictionType ||
                    this.UserLevelRestrictionType.Equals(input.UserLevelRestrictionType)
                ) && 
                (
                    this.UserManagementSourceType == input.UserManagementSourceType ||
                    this.UserManagementSourceType.Equals(input.UserManagementSourceType)
                ) && 
                (
                    this.IsEnableShowAADGroupMembers == input.IsEnableShowAADGroupMembers ||
                    this.IsEnableShowAADGroupMembers.Equals(input.IsEnableShowAADGroupMembers)
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
                hashCode = hashCode * 59 + this.UserLevelRestrictionType.GetHashCode();
                hashCode = hashCode * 59 + this.UserManagementSourceType.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnableShowAADGroupMembers.GetHashCode();
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
