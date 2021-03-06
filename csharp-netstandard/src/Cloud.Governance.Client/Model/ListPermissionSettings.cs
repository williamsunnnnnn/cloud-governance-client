

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
    /// ListPermissionSettings
    /// </summary>
    [DataContract(Name = "ListPermissionSettings")]
    public partial class ListPermissionSettings : IEquatable<ListPermissionSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListPermissionSettings" /> class.
        /// </summary>
        /// <param name="stopInheritingPermissions">stopInheritingPermissions.</param>
        /// <param name="userPermissions">userPermissions.</param>
        /// <param name="groupPermissions">groupPermissions.</param>
        public ListPermissionSettings(bool stopInheritingPermissions = default(bool), List<RequestUserWithPermissions> userPermissions = default(List<RequestUserWithPermissions>), List<RequestGroupWithPermissions> groupPermissions = default(List<RequestGroupWithPermissions>))
        {
            this.StopInheritingPermissions = stopInheritingPermissions;
            this.UserPermissions = userPermissions;
            this.GroupPermissions = groupPermissions;
        }

        /// <summary>
        /// Gets or Sets StopInheritingPermissions
        /// </summary>
        [DataMember(Name = "stopInheritingPermissions", EmitDefaultValue = false)]
        public bool StopInheritingPermissions { get; set; }

        /// <summary>
        /// Gets or Sets UserPermissions
        /// </summary>
        [DataMember(Name = "userPermissions", EmitDefaultValue = true)]
        public List<RequestUserWithPermissions> UserPermissions { get; set; }

        /// <summary>
        /// Gets or Sets GroupPermissions
        /// </summary>
        [DataMember(Name = "groupPermissions", EmitDefaultValue = true)]
        public List<RequestGroupWithPermissions> GroupPermissions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPermissionSettings {\n");
            sb.Append("  StopInheritingPermissions: ").Append(StopInheritingPermissions).Append("\n");
            sb.Append("  UserPermissions: ").Append(UserPermissions).Append("\n");
            sb.Append("  GroupPermissions: ").Append(GroupPermissions).Append("\n");
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
            return this.Equals(input as ListPermissionSettings);
        }

        /// <summary>
        /// Returns true if ListPermissionSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of ListPermissionSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListPermissionSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StopInheritingPermissions == input.StopInheritingPermissions ||
                    this.StopInheritingPermissions.Equals(input.StopInheritingPermissions)
                ) && 
                (
                    this.UserPermissions == input.UserPermissions ||
                    this.UserPermissions != null &&
                    input.UserPermissions != null &&
                    this.UserPermissions.SequenceEqual(input.UserPermissions)
                ) && 
                (
                    this.GroupPermissions == input.GroupPermissions ||
                    this.GroupPermissions != null &&
                    input.GroupPermissions != null &&
                    this.GroupPermissions.SequenceEqual(input.GroupPermissions)
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
                hashCode = hashCode * 59 + this.StopInheritingPermissions.GetHashCode();
                if (this.UserPermissions != null)
                    hashCode = hashCode * 59 + this.UserPermissions.GetHashCode();
                if (this.GroupPermissions != null)
                    hashCode = hashCode * 59 + this.GroupPermissions.GetHashCode();
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
