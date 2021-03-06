

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
    /// TemporaryPermissionRequestSetting
    /// </summary>
    [DataContract(Name = "TemporaryPermissionRequestSetting")]
    public partial class TemporaryPermissionRequestSetting : IEquatable<TemporaryPermissionRequestSetting>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ExpirationType
        /// </summary>
        [DataMember(Name = "expirationType", EmitDefaultValue = false)]
        public ExpirationType? ExpirationType { get; set; }
        /// <summary>
        /// Gets or Sets DurationDateType
        /// </summary>
        [DataMember(Name = "durationDateType", EmitDefaultValue = true)]
        public ApiDurationType? DurationDateType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemporaryPermissionRequestSetting" /> class.
        /// </summary>
        /// <param name="isGrantTemporaryPermission">isGrantTemporaryPermission.</param>
        /// <param name="isGrantAdminGroup">isGrantAdminGroup.</param>
        /// <param name="expirationType">expirationType.</param>
        /// <param name="durationInterval">durationInterval.</param>
        /// <param name="durationDateType">durationDateType.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="endTime">endTime.</param>
        public TemporaryPermissionRequestSetting(bool isGrantTemporaryPermission = default(bool), bool isGrantAdminGroup = default(bool), ExpirationType? expirationType = default(ExpirationType?), int? durationInterval = default(int?), ApiDurationType? durationDateType = default(ApiDurationType?), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?))
        {
            this.IsGrantTemporaryPermission = isGrantTemporaryPermission;
            this.IsGrantAdminGroup = isGrantAdminGroup;
            this.ExpirationType = expirationType;
            this.DurationInterval = durationInterval;
            this.DurationDateType = durationDateType;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Gets or Sets IsGrantTemporaryPermission
        /// </summary>
        [DataMember(Name = "isGrantTemporaryPermission", EmitDefaultValue = false)]
        public bool IsGrantTemporaryPermission { get; set; }

        /// <summary>
        /// Gets or Sets IsGrantAdminGroup
        /// </summary>
        [DataMember(Name = "isGrantAdminGroup", EmitDefaultValue = false)]
        public bool IsGrantAdminGroup { get; set; }

        /// <summary>
        /// Gets or Sets DurationInterval
        /// </summary>
        [DataMember(Name = "durationInterval", EmitDefaultValue = true)]
        public int? DurationInterval { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name = "startTime", EmitDefaultValue = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name = "endTime", EmitDefaultValue = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemporaryPermissionRequestSetting {\n");
            sb.Append("  IsGrantTemporaryPermission: ").Append(IsGrantTemporaryPermission).Append("\n");
            sb.Append("  IsGrantAdminGroup: ").Append(IsGrantAdminGroup).Append("\n");
            sb.Append("  ExpirationType: ").Append(ExpirationType).Append("\n");
            sb.Append("  DurationInterval: ").Append(DurationInterval).Append("\n");
            sb.Append("  DurationDateType: ").Append(DurationDateType).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
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
            return this.Equals(input as TemporaryPermissionRequestSetting);
        }

        /// <summary>
        /// Returns true if TemporaryPermissionRequestSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of TemporaryPermissionRequestSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemporaryPermissionRequestSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsGrantTemporaryPermission == input.IsGrantTemporaryPermission ||
                    this.IsGrantTemporaryPermission.Equals(input.IsGrantTemporaryPermission)
                ) && 
                (
                    this.IsGrantAdminGroup == input.IsGrantAdminGroup ||
                    this.IsGrantAdminGroup.Equals(input.IsGrantAdminGroup)
                ) && 
                (
                    this.ExpirationType == input.ExpirationType ||
                    this.ExpirationType.Equals(input.ExpirationType)
                ) && 
                (
                    this.DurationInterval == input.DurationInterval ||
                    (this.DurationInterval != null &&
                    this.DurationInterval.Equals(input.DurationInterval))
                ) && 
                (
                    this.DurationDateType == input.DurationDateType ||
                    this.DurationDateType.Equals(input.DurationDateType)
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
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
                hashCode = hashCode * 59 + this.IsGrantTemporaryPermission.GetHashCode();
                hashCode = hashCode * 59 + this.IsGrantAdminGroup.GetHashCode();
                hashCode = hashCode * 59 + this.ExpirationType.GetHashCode();
                if (this.DurationInterval != null)
                    hashCode = hashCode * 59 + this.DurationInterval.GetHashCode();
                hashCode = hashCode * 59 + this.DurationDateType.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
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
