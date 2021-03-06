

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
    /// PermissionSettings
    /// </summary>
    [DataContract(Name = "PermissionSettings")]
    public partial class PermissionSettings : IEquatable<PermissionSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionSettings" /> class.
        /// </summary>
        /// <param name="allowGrantUserPermission">allowGrantUserPermission.</param>
        /// <param name="preventGrantSpecificPermissionLevels">preventGrantSpecificPermissionLevels.</param>
        /// <param name="preventPermissionLevles">preventPermissionLevles.</param>
        public PermissionSettings(bool allowGrantUserPermission = default(bool), bool preventGrantSpecificPermissionLevels = default(bool), List<PermissionLevel> preventPermissionLevles = default(List<PermissionLevel>))
        {
            this.AllowGrantUserPermission = allowGrantUserPermission;
            this.PreventGrantSpecificPermissionLevels = preventGrantSpecificPermissionLevels;
            this.PreventPermissionLevles = preventPermissionLevles;
        }

        /// <summary>
        /// Gets or Sets AllowGrantUserPermission
        /// </summary>
        [DataMember(Name = "allowGrantUserPermission", EmitDefaultValue = false)]
        public bool AllowGrantUserPermission { get; set; }

        /// <summary>
        /// Gets or Sets PreventGrantSpecificPermissionLevels
        /// </summary>
        [DataMember(Name = "preventGrantSpecificPermissionLevels", EmitDefaultValue = false)]
        public bool PreventGrantSpecificPermissionLevels { get; set; }

        /// <summary>
        /// Gets or Sets PreventPermissionLevles
        /// </summary>
        [DataMember(Name = "preventPermissionLevles", EmitDefaultValue = true)]
        public List<PermissionLevel> PreventPermissionLevles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermissionSettings {\n");
            sb.Append("  AllowGrantUserPermission: ").Append(AllowGrantUserPermission).Append("\n");
            sb.Append("  PreventGrantSpecificPermissionLevels: ").Append(PreventGrantSpecificPermissionLevels).Append("\n");
            sb.Append("  PreventPermissionLevles: ").Append(PreventPermissionLevles).Append("\n");
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
            return this.Equals(input as PermissionSettings);
        }

        /// <summary>
        /// Returns true if PermissionSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of PermissionSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PermissionSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowGrantUserPermission == input.AllowGrantUserPermission ||
                    this.AllowGrantUserPermission.Equals(input.AllowGrantUserPermission)
                ) && 
                (
                    this.PreventGrantSpecificPermissionLevels == input.PreventGrantSpecificPermissionLevels ||
                    this.PreventGrantSpecificPermissionLevels.Equals(input.PreventGrantSpecificPermissionLevels)
                ) && 
                (
                    this.PreventPermissionLevles == input.PreventPermissionLevles ||
                    this.PreventPermissionLevles != null &&
                    input.PreventPermissionLevles != null &&
                    this.PreventPermissionLevles.SequenceEqual(input.PreventPermissionLevles)
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
                hashCode = hashCode * 59 + this.AllowGrantUserPermission.GetHashCode();
                hashCode = hashCode * 59 + this.PreventGrantSpecificPermissionLevels.GetHashCode();
                if (this.PreventPermissionLevles != null)
                    hashCode = hashCode * 59 + this.PreventPermissionLevles.GetHashCode();
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
