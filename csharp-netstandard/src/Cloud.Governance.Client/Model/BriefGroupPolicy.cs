

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
    /// BriefGroupPolicy
    /// </summary>
    [DataContract(Name = "BriefGroupPolicy")]
    public partial class BriefGroupPolicy : IEquatable<BriefGroupPolicy>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets LeaseExpiredIntervalType
        /// </summary>
        [DataMember(Name = "leaseExpiredIntervalType", EmitDefaultValue = false)]
        public ApiDurationType? LeaseExpiredIntervalType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BriefGroupPolicy" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="enableLeaseExpiration">enableLeaseExpiration.</param>
        /// <param name="leaseExpiredInterval">leaseExpiredInterval.</param>
        /// <param name="leaseExpiredIntervalType">leaseExpiredIntervalType.</param>
        /// <param name="enableManageGroupSharing">enableManageGroupSharing.</param>
        /// <param name="enableInviteAuthorizedGuestUser">enableInviteAuthorizedGuestUser.</param>
        /// <param name="enableInviteGuestUser">enableInviteGuestUser.</param>
        public BriefGroupPolicy(Guid id = default(Guid), string name = default(string), string description = default(string), bool enableLeaseExpiration = default(bool), int leaseExpiredInterval = default(int), ApiDurationType? leaseExpiredIntervalType = default(ApiDurationType?), bool enableManageGroupSharing = default(bool), bool enableInviteAuthorizedGuestUser = default(bool), bool enableInviteGuestUser = default(bool))
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.EnableLeaseExpiration = enableLeaseExpiration;
            this.LeaseExpiredInterval = leaseExpiredInterval;
            this.LeaseExpiredIntervalType = leaseExpiredIntervalType;
            this.EnableManageGroupSharing = enableManageGroupSharing;
            this.EnableInviteAuthorizedGuestUser = enableInviteAuthorizedGuestUser;
            this.EnableInviteGuestUser = enableInviteGuestUser;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets EnableLeaseExpiration
        /// </summary>
        [DataMember(Name = "enableLeaseExpiration", EmitDefaultValue = false)]
        public bool EnableLeaseExpiration { get; set; }

        /// <summary>
        /// Gets or Sets LeaseExpiredInterval
        /// </summary>
        [DataMember(Name = "leaseExpiredInterval", EmitDefaultValue = false)]
        public int LeaseExpiredInterval { get; set; }

        /// <summary>
        /// Gets or Sets EnableManageGroupSharing
        /// </summary>
        [DataMember(Name = "enableManageGroupSharing", EmitDefaultValue = false)]
        public bool EnableManageGroupSharing { get; set; }

        /// <summary>
        /// Gets or Sets EnableInviteAuthorizedGuestUser
        /// </summary>
        [DataMember(Name = "enableInviteAuthorizedGuestUser", EmitDefaultValue = false)]
        public bool EnableInviteAuthorizedGuestUser { get; set; }

        /// <summary>
        /// Gets or Sets EnableInviteGuestUser
        /// </summary>
        [DataMember(Name = "enableInviteGuestUser", EmitDefaultValue = false)]
        public bool EnableInviteGuestUser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BriefGroupPolicy {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EnableLeaseExpiration: ").Append(EnableLeaseExpiration).Append("\n");
            sb.Append("  LeaseExpiredInterval: ").Append(LeaseExpiredInterval).Append("\n");
            sb.Append("  LeaseExpiredIntervalType: ").Append(LeaseExpiredIntervalType).Append("\n");
            sb.Append("  EnableManageGroupSharing: ").Append(EnableManageGroupSharing).Append("\n");
            sb.Append("  EnableInviteAuthorizedGuestUser: ").Append(EnableInviteAuthorizedGuestUser).Append("\n");
            sb.Append("  EnableInviteGuestUser: ").Append(EnableInviteGuestUser).Append("\n");
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
            return this.Equals(input as BriefGroupPolicy);
        }

        /// <summary>
        /// Returns true if BriefGroupPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of BriefGroupPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BriefGroupPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EnableLeaseExpiration == input.EnableLeaseExpiration ||
                    this.EnableLeaseExpiration.Equals(input.EnableLeaseExpiration)
                ) && 
                (
                    this.LeaseExpiredInterval == input.LeaseExpiredInterval ||
                    this.LeaseExpiredInterval.Equals(input.LeaseExpiredInterval)
                ) && 
                (
                    this.LeaseExpiredIntervalType == input.LeaseExpiredIntervalType ||
                    this.LeaseExpiredIntervalType.Equals(input.LeaseExpiredIntervalType)
                ) && 
                (
                    this.EnableManageGroupSharing == input.EnableManageGroupSharing ||
                    this.EnableManageGroupSharing.Equals(input.EnableManageGroupSharing)
                ) && 
                (
                    this.EnableInviteAuthorizedGuestUser == input.EnableInviteAuthorizedGuestUser ||
                    this.EnableInviteAuthorizedGuestUser.Equals(input.EnableInviteAuthorizedGuestUser)
                ) && 
                (
                    this.EnableInviteGuestUser == input.EnableInviteGuestUser ||
                    this.EnableInviteGuestUser.Equals(input.EnableInviteGuestUser)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.EnableLeaseExpiration.GetHashCode();
                hashCode = hashCode * 59 + this.LeaseExpiredInterval.GetHashCode();
                hashCode = hashCode * 59 + this.LeaseExpiredIntervalType.GetHashCode();
                hashCode = hashCode * 59 + this.EnableManageGroupSharing.GetHashCode();
                hashCode = hashCode * 59 + this.EnableInviteAuthorizedGuestUser.GetHashCode();
                hashCode = hashCode * 59 + this.EnableInviteGuestUser.GetHashCode();
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
