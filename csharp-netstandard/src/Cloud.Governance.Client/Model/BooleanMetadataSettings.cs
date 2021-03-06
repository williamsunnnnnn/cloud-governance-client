

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
    /// BooleanMetadataSettings
    /// </summary>
    [DataContract(Name = "BooleanMetadataSettings")]
    public partial class BooleanMetadataSettings : IEquatable<BooleanMetadataSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanMetadataSettings" /> class.
        /// </summary>
        /// <param name="enableTerms">enableTerms.</param>
        /// <param name="value">value.</param>
        /// <param name="termsAndConditions">termsAndConditions.</param>
        public BooleanMetadataSettings(bool enableTerms = default(bool), bool value = default(bool), string termsAndConditions = default(string))
        {
            this.EnableTerms = enableTerms;
            this.Value = value;
            this.TermsAndConditions = termsAndConditions;
        }

        /// <summary>
        /// Gets or Sets EnableTerms
        /// </summary>
        [DataMember(Name = "enableTerms", EmitDefaultValue = false)]
        public bool EnableTerms { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public bool Value { get; set; }

        /// <summary>
        /// Gets or Sets TermsAndConditions
        /// </summary>
        [DataMember(Name = "termsAndConditions", EmitDefaultValue = true)]
        public string TermsAndConditions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BooleanMetadataSettings {\n");
            sb.Append("  EnableTerms: ").Append(EnableTerms).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  TermsAndConditions: ").Append(TermsAndConditions).Append("\n");
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
            return this.Equals(input as BooleanMetadataSettings);
        }

        /// <summary>
        /// Returns true if BooleanMetadataSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of BooleanMetadataSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BooleanMetadataSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableTerms == input.EnableTerms ||
                    this.EnableTerms.Equals(input.EnableTerms)
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.TermsAndConditions == input.TermsAndConditions ||
                    (this.TermsAndConditions != null &&
                    this.TermsAndConditions.Equals(input.TermsAndConditions))
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
                hashCode = hashCode * 59 + this.EnableTerms.GetHashCode();
                hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.TermsAndConditions != null)
                    hashCode = hashCode * 59 + this.TermsAndConditions.GetHashCode();
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
