

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
    /// LifecycleRenewalSetting
    /// </summary>
    [DataContract(Name = "LifecycleRenewalSetting")]
    public partial class LifecycleRenewalSetting : IEquatable<LifecycleRenewalSetting>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets LeaseDateType
        /// </summary>
        [DataMember(Name = "leaseDateType", EmitDefaultValue = false)]
        public LeaseDateType? LeaseDateType { get; set; }
        /// <summary>
        /// Gets or Sets StartDateType
        /// </summary>
        [DataMember(Name = "startDateType", EmitDefaultValue = false)]
        public LeaseStartDateType? StartDateType { get; set; }
        /// <summary>
        /// Gets or Sets HandleOngoingType
        /// </summary>
        [DataMember(Name = "handleOngoingType", EmitDefaultValue = false)]
        public HandleOngoingType? HandleOngoingType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LifecycleRenewalSetting" /> class.
        /// </summary>
        /// <param name="leaseDateType">leaseDateType.</param>
        /// <param name="startDateType">startDateType.</param>
        /// <param name="specifyStartDate">specifyStartDate.</param>
        /// <param name="handleOngoingType">handleOngoingType.</param>
        public LifecycleRenewalSetting(LeaseDateType? leaseDateType = default(LeaseDateType?), LeaseStartDateType? startDateType = default(LeaseStartDateType?), DateTime? specifyStartDate = default(DateTime?), HandleOngoingType? handleOngoingType = default(HandleOngoingType?))
        {
            this.LeaseDateType = leaseDateType;
            this.StartDateType = startDateType;
            this.SpecifyStartDate = specifyStartDate;
            this.HandleOngoingType = handleOngoingType;
        }

        /// <summary>
        /// Gets or Sets SpecifyStartDate
        /// </summary>
        [DataMember(Name = "specifyStartDate", EmitDefaultValue = true)]
        public DateTime? SpecifyStartDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LifecycleRenewalSetting {\n");
            sb.Append("  LeaseDateType: ").Append(LeaseDateType).Append("\n");
            sb.Append("  StartDateType: ").Append(StartDateType).Append("\n");
            sb.Append("  SpecifyStartDate: ").Append(SpecifyStartDate).Append("\n");
            sb.Append("  HandleOngoingType: ").Append(HandleOngoingType).Append("\n");
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
            return this.Equals(input as LifecycleRenewalSetting);
        }

        /// <summary>
        /// Returns true if LifecycleRenewalSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of LifecycleRenewalSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LifecycleRenewalSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LeaseDateType == input.LeaseDateType ||
                    this.LeaseDateType.Equals(input.LeaseDateType)
                ) && 
                (
                    this.StartDateType == input.StartDateType ||
                    this.StartDateType.Equals(input.StartDateType)
                ) && 
                (
                    this.SpecifyStartDate == input.SpecifyStartDate ||
                    (this.SpecifyStartDate != null &&
                    this.SpecifyStartDate.Equals(input.SpecifyStartDate))
                ) && 
                (
                    this.HandleOngoingType == input.HandleOngoingType ||
                    this.HandleOngoingType.Equals(input.HandleOngoingType)
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
                hashCode = hashCode * 59 + this.LeaseDateType.GetHashCode();
                hashCode = hashCode * 59 + this.StartDateType.GetHashCode();
                if (this.SpecifyStartDate != null)
                    hashCode = hashCode * 59 + this.SpecifyStartDate.GetHashCode();
                hashCode = hashCode * 59 + this.HandleOngoingType.GetHashCode();
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
