

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
    /// UnlockSiteSetting
    /// </summary>
    [DataContract(Name = "UnlockSiteSetting")]
    public partial class UnlockSiteSetting : IEquatable<UnlockSiteSetting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnlockSiteSetting" /> class.
        /// </summary>
        /// <param name="isExpired">isExpired.</param>
        /// <param name="isExtendEnabled">isExtendEnabled.</param>
        public UnlockSiteSetting(bool isExpired = default(bool), bool isExtendEnabled = default(bool))
        {
            this.IsExpired = isExpired;
            this.IsExtendEnabled = isExtendEnabled;
        }

        /// <summary>
        /// Gets or Sets IsExpired
        /// </summary>
        [DataMember(Name = "isExpired", EmitDefaultValue = false)]
        public bool IsExpired { get; set; }

        /// <summary>
        /// Gets or Sets IsExtendEnabled
        /// </summary>
        [DataMember(Name = "isExtendEnabled", EmitDefaultValue = false)]
        public bool IsExtendEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnlockSiteSetting {\n");
            sb.Append("  IsExpired: ").Append(IsExpired).Append("\n");
            sb.Append("  IsExtendEnabled: ").Append(IsExtendEnabled).Append("\n");
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
            return this.Equals(input as UnlockSiteSetting);
        }

        /// <summary>
        /// Returns true if UnlockSiteSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of UnlockSiteSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnlockSiteSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsExpired == input.IsExpired ||
                    this.IsExpired.Equals(input.IsExpired)
                ) && 
                (
                    this.IsExtendEnabled == input.IsExtendEnabled ||
                    this.IsExtendEnabled.Equals(input.IsExtendEnabled)
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
                hashCode = hashCode * 59 + this.IsExpired.GetHashCode();
                hashCode = hashCode * 59 + this.IsExtendEnabled.GetHashCode();
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
