

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
    /// GroupLeasePeriodSettings
    /// </summary>
    [DataContract(Name = "GroupLeasePeriodSettings")]
    public partial class GroupLeasePeriodSettings : IEquatable<GroupLeasePeriodSettings>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets LeaseType
        /// </summary>
        [DataMember(Name = "leaseType", EmitDefaultValue = false)]
        public GroupLeasePeriodType? LeaseType { get; set; }
        /// <summary>
        /// Gets or Sets DurationType
        /// </summary>
        [DataMember(Name = "durationType", EmitDefaultValue = false)]
        public ApiDurationType? DurationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupLeasePeriodSettings" /> class.
        /// </summary>
        /// <param name="isEnabled">isEnabled.</param>
        /// <param name="leaseType">leaseType.</param>
        /// <param name="durationType">durationType.</param>
        /// <param name="durationInterval">durationInterval.</param>
        /// <param name="leaseExpirationDate">leaseExpirationDate.</param>
        public GroupLeasePeriodSettings(bool isEnabled = default(bool), GroupLeasePeriodType? leaseType = default(GroupLeasePeriodType?), ApiDurationType? durationType = default(ApiDurationType?), int durationInterval = default(int), DateTime? leaseExpirationDate = default(DateTime?))
        {
            this.IsEnabled = isEnabled;
            this.LeaseType = leaseType;
            this.DurationType = durationType;
            this.DurationInterval = durationInterval;
            this.LeaseExpirationDate = leaseExpirationDate;
        }

        /// <summary>
        /// Gets or Sets IsEnabled
        /// </summary>
        [DataMember(Name = "isEnabled", EmitDefaultValue = false)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets DurationInterval
        /// </summary>
        [DataMember(Name = "durationInterval", EmitDefaultValue = false)]
        public int DurationInterval { get; set; }

        /// <summary>
        /// Gets or Sets LeaseExpirationDate
        /// </summary>
        [DataMember(Name = "leaseExpirationDate", EmitDefaultValue = true)]
        public DateTime? LeaseExpirationDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupLeasePeriodSettings {\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  LeaseType: ").Append(LeaseType).Append("\n");
            sb.Append("  DurationType: ").Append(DurationType).Append("\n");
            sb.Append("  DurationInterval: ").Append(DurationInterval).Append("\n");
            sb.Append("  LeaseExpirationDate: ").Append(LeaseExpirationDate).Append("\n");
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
            return this.Equals(input as GroupLeasePeriodSettings);
        }

        /// <summary>
        /// Returns true if GroupLeasePeriodSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupLeasePeriodSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupLeasePeriodSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsEnabled == input.IsEnabled ||
                    this.IsEnabled.Equals(input.IsEnabled)
                ) && 
                (
                    this.LeaseType == input.LeaseType ||
                    this.LeaseType.Equals(input.LeaseType)
                ) && 
                (
                    this.DurationType == input.DurationType ||
                    this.DurationType.Equals(input.DurationType)
                ) && 
                (
                    this.DurationInterval == input.DurationInterval ||
                    this.DurationInterval.Equals(input.DurationInterval)
                ) && 
                (
                    this.LeaseExpirationDate == input.LeaseExpirationDate ||
                    (this.LeaseExpirationDate != null &&
                    this.LeaseExpirationDate.Equals(input.LeaseExpirationDate))
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
                hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.LeaseType.GetHashCode();
                hashCode = hashCode * 59 + this.DurationType.GetHashCode();
                hashCode = hashCode * 59 + this.DurationInterval.GetHashCode();
                if (this.LeaseExpirationDate != null)
                    hashCode = hashCode * 59 + this.LeaseExpirationDate.GetHashCode();
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
