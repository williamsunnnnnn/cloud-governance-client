

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
    /// AppSettings
    /// </summary>
    [DataContract(Name = "AppSettings")]
    public partial class AppSettings : IEquatable<AppSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppSettings" /> class.
        /// </summary>
        /// <param name="enableInstallApp">enableInstallApp.</param>
        /// <param name="enableAddSiteInfoCard">enableAddSiteInfoCard.</param>
        /// <param name="enableAddTimeLine">enableAddTimeLine.</param>
        /// <param name="enableAddPanel">enableAddPanel.</param>
        public AppSettings(bool enableInstallApp = default(bool), bool enableAddSiteInfoCard = default(bool), bool enableAddTimeLine = default(bool), bool enableAddPanel = default(bool))
        {
            this.EnableInstallApp = enableInstallApp;
            this.EnableAddSiteInfoCard = enableAddSiteInfoCard;
            this.EnableAddTimeLine = enableAddTimeLine;
            this.EnableAddPanel = enableAddPanel;
        }

        /// <summary>
        /// Gets or Sets EnableInstallApp
        /// </summary>
        [DataMember(Name = "enableInstallApp", EmitDefaultValue = false)]
        public bool EnableInstallApp { get; set; }

        /// <summary>
        /// Gets or Sets EnableAddSiteInfoCard
        /// </summary>
        [DataMember(Name = "enableAddSiteInfoCard", EmitDefaultValue = false)]
        public bool EnableAddSiteInfoCard { get; set; }

        /// <summary>
        /// Gets or Sets EnableAddTimeLine
        /// </summary>
        [DataMember(Name = "enableAddTimeLine", EmitDefaultValue = false)]
        public bool EnableAddTimeLine { get; set; }

        /// <summary>
        /// Gets or Sets EnableAddPanel
        /// </summary>
        [DataMember(Name = "enableAddPanel", EmitDefaultValue = false)]
        public bool EnableAddPanel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppSettings {\n");
            sb.Append("  EnableInstallApp: ").Append(EnableInstallApp).Append("\n");
            sb.Append("  EnableAddSiteInfoCard: ").Append(EnableAddSiteInfoCard).Append("\n");
            sb.Append("  EnableAddTimeLine: ").Append(EnableAddTimeLine).Append("\n");
            sb.Append("  EnableAddPanel: ").Append(EnableAddPanel).Append("\n");
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
            return this.Equals(input as AppSettings);
        }

        /// <summary>
        /// Returns true if AppSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of AppSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableInstallApp == input.EnableInstallApp ||
                    this.EnableInstallApp.Equals(input.EnableInstallApp)
                ) && 
                (
                    this.EnableAddSiteInfoCard == input.EnableAddSiteInfoCard ||
                    this.EnableAddSiteInfoCard.Equals(input.EnableAddSiteInfoCard)
                ) && 
                (
                    this.EnableAddTimeLine == input.EnableAddTimeLine ||
                    this.EnableAddTimeLine.Equals(input.EnableAddTimeLine)
                ) && 
                (
                    this.EnableAddPanel == input.EnableAddPanel ||
                    this.EnableAddPanel.Equals(input.EnableAddPanel)
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
                hashCode = hashCode * 59 + this.EnableInstallApp.GetHashCode();
                hashCode = hashCode * 59 + this.EnableAddSiteInfoCard.GetHashCode();
                hashCode = hashCode * 59 + this.EnableAddTimeLine.GetHashCode();
                hashCode = hashCode * 59 + this.EnableAddPanel.GetHashCode();
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
