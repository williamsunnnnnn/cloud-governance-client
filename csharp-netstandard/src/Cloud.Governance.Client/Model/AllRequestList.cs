

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
    /// AllRequestList
    /// </summary>
    [DataContract(Name = "AllRequestList")]
    public partial class AllRequestList : IEquatable<AllRequestList>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ServiceType
        /// </summary>
        [DataMember(Name = "serviceType", EmitDefaultValue = false)]
        public ServiceType? ServiceType { get; set; }
        /// <summary>
        /// Gets or Sets DetailStatus
        /// </summary>
        [DataMember(Name = "detailStatus", EmitDefaultValue = false)]
        public RequestProgressStatus? DetailStatus { get; set; }
        /// <summary>
        /// Gets or Sets ProgressStatus
        /// </summary>
        [DataMember(Name = "progressStatus", EmitDefaultValue = false)]
        public ApiRequestProgressStatus? ProgressStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AllRequestList" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="serviceId">serviceId.</param>
        /// <param name="serviceName">serviceName.</param>
        /// <param name="serviceType">serviceType.</param>
        /// <param name="serviceTypeDescription">serviceTypeDescription.</param>
        /// <param name="ticketNumber">ticketNumber.</param>
        /// <param name="summary">summary.</param>
        /// <param name="requester">requester.</param>
        /// <param name="requesterDisplayName">requesterDisplayName.</param>
        /// <param name="detailStatus">detailStatus.</param>
        /// <param name="detailStatusDescription">detailStatusDescription.</param>
        /// <param name="progressStatus">progressStatus.</param>
        /// <param name="progressStatusDescription">progressStatusDescription.</param>
        /// <param name="modified">modified.</param>
        /// <param name="assignTo">assignTo.</param>
        /// <param name="assignToDisplayName">assignToDisplayName.</param>
        /// <param name="serviceAdmin">serviceAdmin.</param>
        /// <param name="objectUrl">objectUrl.</param>
        /// <param name="createdTime">createdTime.</param>
        public AllRequestList(Guid id = default(Guid), Guid serviceId = default(Guid), string serviceName = default(string), ServiceType? serviceType = default(ServiceType?), string serviceTypeDescription = default(string), int ticketNumber = default(int), string summary = default(string), string requester = default(string), string requesterDisplayName = default(string), RequestProgressStatus? detailStatus = default(RequestProgressStatus?), string detailStatusDescription = default(string), ApiRequestProgressStatus? progressStatus = default(ApiRequestProgressStatus?), string progressStatusDescription = default(string), DateTime modified = default(DateTime), string assignTo = default(string), string assignToDisplayName = default(string), string serviceAdmin = default(string), string objectUrl = default(string), string createdTime = default(string))
        {
            this.Id = id;
            this.ServiceId = serviceId;
            this.ServiceName = serviceName;
            this.ServiceType = serviceType;
            this.ServiceTypeDescription = serviceTypeDescription;
            this.TicketNumber = ticketNumber;
            this.Summary = summary;
            this.Requester = requester;
            this.RequesterDisplayName = requesterDisplayName;
            this.DetailStatus = detailStatus;
            this.DetailStatusDescription = detailStatusDescription;
            this.ProgressStatus = progressStatus;
            this.ProgressStatusDescription = progressStatusDescription;
            this.Modified = modified;
            this.AssignTo = assignTo;
            this.AssignToDisplayName = assignToDisplayName;
            this.ServiceAdmin = serviceAdmin;
            this.ObjectUrl = objectUrl;
            this.CreatedTime = createdTime;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets ServiceId
        /// </summary>
        [DataMember(Name = "serviceId", EmitDefaultValue = false)]
        public Guid ServiceId { get; set; }

        /// <summary>
        /// Gets or Sets ServiceName
        /// </summary>
        [DataMember(Name = "serviceName", EmitDefaultValue = true)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Gets or Sets ServiceTypeDescription
        /// </summary>
        [DataMember(Name = "serviceTypeDescription", EmitDefaultValue = true)]
        public string ServiceTypeDescription { get; set; }

        /// <summary>
        /// Gets or Sets TicketNumber
        /// </summary>
        [DataMember(Name = "ticketNumber", EmitDefaultValue = false)]
        public int TicketNumber { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", EmitDefaultValue = true)]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or Sets Requester
        /// </summary>
        [DataMember(Name = "requester", EmitDefaultValue = true)]
        public string Requester { get; set; }

        /// <summary>
        /// Gets or Sets RequesterDisplayName
        /// </summary>
        [DataMember(Name = "requesterDisplayName", EmitDefaultValue = true)]
        public string RequesterDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets DetailStatusDescription
        /// </summary>
        [DataMember(Name = "detailStatusDescription", EmitDefaultValue = true)]
        public string DetailStatusDescription { get; set; }

        /// <summary>
        /// Gets or Sets ProgressStatusDescription
        /// </summary>
        [DataMember(Name = "progressStatusDescription", EmitDefaultValue = true)]
        public string ProgressStatusDescription { get; set; }

        /// <summary>
        /// Gets or Sets Modified
        /// </summary>
        [DataMember(Name = "modified", EmitDefaultValue = false)]
        public DateTime Modified { get; set; }

        /// <summary>
        /// Gets or Sets AssignTo
        /// </summary>
        [DataMember(Name = "assignTo", EmitDefaultValue = true)]
        public string AssignTo { get; set; }

        /// <summary>
        /// Gets or Sets AssignToDisplayName
        /// </summary>
        [DataMember(Name = "assignToDisplayName", EmitDefaultValue = true)]
        public string AssignToDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets ServiceAdmin
        /// </summary>
        [DataMember(Name = "serviceAdmin", EmitDefaultValue = true)]
        public string ServiceAdmin { get; set; }

        /// <summary>
        /// Gets or Sets ObjectUrl
        /// </summary>
        [DataMember(Name = "objectUrl", EmitDefaultValue = true)]
        public string ObjectUrl { get; set; }

        /// <summary>
        /// Gets or Sets CreatedTime
        /// </summary>
        [DataMember(Name = "createdTime", EmitDefaultValue = true)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllRequestList {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
            sb.Append("  ServiceTypeDescription: ").Append(ServiceTypeDescription).Append("\n");
            sb.Append("  TicketNumber: ").Append(TicketNumber).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Requester: ").Append(Requester).Append("\n");
            sb.Append("  RequesterDisplayName: ").Append(RequesterDisplayName).Append("\n");
            sb.Append("  DetailStatus: ").Append(DetailStatus).Append("\n");
            sb.Append("  DetailStatusDescription: ").Append(DetailStatusDescription).Append("\n");
            sb.Append("  ProgressStatus: ").Append(ProgressStatus).Append("\n");
            sb.Append("  ProgressStatusDescription: ").Append(ProgressStatusDescription).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  AssignTo: ").Append(AssignTo).Append("\n");
            sb.Append("  AssignToDisplayName: ").Append(AssignToDisplayName).Append("\n");
            sb.Append("  ServiceAdmin: ").Append(ServiceAdmin).Append("\n");
            sb.Append("  ObjectUrl: ").Append(ObjectUrl).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
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
            return this.Equals(input as AllRequestList);
        }

        /// <summary>
        /// Returns true if AllRequestList instances are equal
        /// </summary>
        /// <param name="input">Instance of AllRequestList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllRequestList input)
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
                    this.ServiceId == input.ServiceId ||
                    (this.ServiceId != null &&
                    this.ServiceId.Equals(input.ServiceId))
                ) && 
                (
                    this.ServiceName == input.ServiceName ||
                    (this.ServiceName != null &&
                    this.ServiceName.Equals(input.ServiceName))
                ) && 
                (
                    this.ServiceType == input.ServiceType ||
                    this.ServiceType.Equals(input.ServiceType)
                ) && 
                (
                    this.ServiceTypeDescription == input.ServiceTypeDescription ||
                    (this.ServiceTypeDescription != null &&
                    this.ServiceTypeDescription.Equals(input.ServiceTypeDescription))
                ) && 
                (
                    this.TicketNumber == input.TicketNumber ||
                    this.TicketNumber.Equals(input.TicketNumber)
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.Requester == input.Requester ||
                    (this.Requester != null &&
                    this.Requester.Equals(input.Requester))
                ) && 
                (
                    this.RequesterDisplayName == input.RequesterDisplayName ||
                    (this.RequesterDisplayName != null &&
                    this.RequesterDisplayName.Equals(input.RequesterDisplayName))
                ) && 
                (
                    this.DetailStatus == input.DetailStatus ||
                    this.DetailStatus.Equals(input.DetailStatus)
                ) && 
                (
                    this.DetailStatusDescription == input.DetailStatusDescription ||
                    (this.DetailStatusDescription != null &&
                    this.DetailStatusDescription.Equals(input.DetailStatusDescription))
                ) && 
                (
                    this.ProgressStatus == input.ProgressStatus ||
                    this.ProgressStatus.Equals(input.ProgressStatus)
                ) && 
                (
                    this.ProgressStatusDescription == input.ProgressStatusDescription ||
                    (this.ProgressStatusDescription != null &&
                    this.ProgressStatusDescription.Equals(input.ProgressStatusDescription))
                ) && 
                (
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
                ) && 
                (
                    this.AssignTo == input.AssignTo ||
                    (this.AssignTo != null &&
                    this.AssignTo.Equals(input.AssignTo))
                ) && 
                (
                    this.AssignToDisplayName == input.AssignToDisplayName ||
                    (this.AssignToDisplayName != null &&
                    this.AssignToDisplayName.Equals(input.AssignToDisplayName))
                ) && 
                (
                    this.ServiceAdmin == input.ServiceAdmin ||
                    (this.ServiceAdmin != null &&
                    this.ServiceAdmin.Equals(input.ServiceAdmin))
                ) && 
                (
                    this.ObjectUrl == input.ObjectUrl ||
                    (this.ObjectUrl != null &&
                    this.ObjectUrl.Equals(input.ObjectUrl))
                ) && 
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
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
                if (this.ServiceId != null)
                    hashCode = hashCode * 59 + this.ServiceId.GetHashCode();
                if (this.ServiceName != null)
                    hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
                hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.ServiceTypeDescription != null)
                    hashCode = hashCode * 59 + this.ServiceTypeDescription.GetHashCode();
                hashCode = hashCode * 59 + this.TicketNumber.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.Requester != null)
                    hashCode = hashCode * 59 + this.Requester.GetHashCode();
                if (this.RequesterDisplayName != null)
                    hashCode = hashCode * 59 + this.RequesterDisplayName.GetHashCode();
                hashCode = hashCode * 59 + this.DetailStatus.GetHashCode();
                if (this.DetailStatusDescription != null)
                    hashCode = hashCode * 59 + this.DetailStatusDescription.GetHashCode();
                hashCode = hashCode * 59 + this.ProgressStatus.GetHashCode();
                if (this.ProgressStatusDescription != null)
                    hashCode = hashCode * 59 + this.ProgressStatusDescription.GetHashCode();
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                if (this.AssignTo != null)
                    hashCode = hashCode * 59 + this.AssignTo.GetHashCode();
                if (this.AssignToDisplayName != null)
                    hashCode = hashCode * 59 + this.AssignToDisplayName.GetHashCode();
                if (this.ServiceAdmin != null)
                    hashCode = hashCode * 59 + this.ServiceAdmin.GetHashCode();
                if (this.ObjectUrl != null)
                    hashCode = hashCode * 59 + this.ObjectUrl.GetHashCode();
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
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
