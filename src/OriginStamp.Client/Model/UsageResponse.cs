/*
 * OriginStamp Client
 *
 * OpenAPI spec version: 3.0
 * OriginStamp Documentation: https://docs.originstamp.com
 * Contact: mail@originstamp.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = OriginStamp.Client.Client.SwaggerDateConverter;

namespace OriginStamp.Client.Model
{
    /// <summary>
    /// Usage metric for this month.
    /// </summary>
    [DataContract]
    public partial class UsageResponse :  IEquatable<UsageResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsageResponse" /> class.
        /// </summary>
        /// <param name="certificatePerMonth">Total number of certificates available per month..</param>
        /// <param name="consumedCertificates">Number of certificates requested for the current month..</param>
        /// <param name="consumedCredits">Number of used credits for the current month..</param>
        /// <param name="consumedTimestamps">Number of timestamps created for the current month..</param>
        /// <param name="creditsPerMonth">Represents the total number of credits per month..</param>
        /// <param name="limitationType">Determines which usage metric is applied (0 &#x3D; credits, 1 &#x3D; timestamps)..</param>
        /// <param name="remainingCredits">Remaining number of credits for the current month..</param>
        /// <param name="timestampsPerMonth">Total number of timestamps available per month..</param>
        public UsageResponse(long? certificatePerMonth = default(long?), long? consumedCertificates = default(long?), decimal? consumedCredits = default(decimal?), long? consumedTimestamps = default(long?), decimal? creditsPerMonth = default(decimal?), int? limitationType = default(int?), decimal? remainingCredits = default(decimal?), long? timestampsPerMonth = default(long?))
        {
            this.CertificatePerMonth = certificatePerMonth;
            this.ConsumedCertificates = consumedCertificates;
            this.ConsumedCredits = consumedCredits;
            this.ConsumedTimestamps = consumedTimestamps;
            this.CreditsPerMonth = creditsPerMonth;
            this.LimitationType = limitationType;
            this.RemainingCredits = remainingCredits;
            this.TimestampsPerMonth = timestampsPerMonth;
        }
        
        /// <summary>
        /// Total number of certificates available per month.
        /// </summary>
        /// <value>Total number of certificates available per month.</value>
        [DataMember(Name="certificate_per_month", EmitDefaultValue=false)]
        public long? CertificatePerMonth { get; set; }

        /// <summary>
        /// Number of certificates requested for the current month.
        /// </summary>
        /// <value>Number of certificates requested for the current month.</value>
        [DataMember(Name="consumed_certificates", EmitDefaultValue=false)]
        public long? ConsumedCertificates { get; set; }

        /// <summary>
        /// Number of used credits for the current month.
        /// </summary>
        /// <value>Number of used credits for the current month.</value>
        [DataMember(Name="consumed_credits", EmitDefaultValue=false)]
        public decimal? ConsumedCredits { get; set; }

        /// <summary>
        /// Number of timestamps created for the current month.
        /// </summary>
        /// <value>Number of timestamps created for the current month.</value>
        [DataMember(Name="consumed_timestamps", EmitDefaultValue=false)]
        public long? ConsumedTimestamps { get; set; }

        /// <summary>
        /// Represents the total number of credits per month.
        /// </summary>
        /// <value>Represents the total number of credits per month.</value>
        [DataMember(Name="credits_per_month", EmitDefaultValue=false)]
        public decimal? CreditsPerMonth { get; set; }

        /// <summary>
        /// Determines which usage metric is applied (0 &#x3D; credits, 1 &#x3D; timestamps).
        /// </summary>
        /// <value>Determines which usage metric is applied (0 &#x3D; credits, 1 &#x3D; timestamps).</value>
        [DataMember(Name="limitation_type", EmitDefaultValue=false)]
        public int? LimitationType { get; set; }

        /// <summary>
        /// Remaining number of credits for the current month.
        /// </summary>
        /// <value>Remaining number of credits for the current month.</value>
        [DataMember(Name="remaining_credits", EmitDefaultValue=false)]
        public decimal? RemainingCredits { get; set; }

        /// <summary>
        /// Total number of timestamps available per month.
        /// </summary>
        /// <value>Total number of timestamps available per month.</value>
        [DataMember(Name="timestamps_per_month", EmitDefaultValue=false)]
        public long? TimestampsPerMonth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsageResponse {\n");
            sb.Append("  CertificatePerMonth: ").Append(CertificatePerMonth).Append("\n");
            sb.Append("  ConsumedCertificates: ").Append(ConsumedCertificates).Append("\n");
            sb.Append("  ConsumedCredits: ").Append(ConsumedCredits).Append("\n");
            sb.Append("  ConsumedTimestamps: ").Append(ConsumedTimestamps).Append("\n");
            sb.Append("  CreditsPerMonth: ").Append(CreditsPerMonth).Append("\n");
            sb.Append("  LimitationType: ").Append(LimitationType).Append("\n");
            sb.Append("  RemainingCredits: ").Append(RemainingCredits).Append("\n");
            sb.Append("  TimestampsPerMonth: ").Append(TimestampsPerMonth).Append("\n");
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
            return this.Equals(input as UsageResponse);
        }

        /// <summary>
        /// Returns true if UsageResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UsageResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsageResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CertificatePerMonth == input.CertificatePerMonth ||
                    (this.CertificatePerMonth != null &&
                    this.CertificatePerMonth.Equals(input.CertificatePerMonth))
                ) && 
                (
                    this.ConsumedCertificates == input.ConsumedCertificates ||
                    (this.ConsumedCertificates != null &&
                    this.ConsumedCertificates.Equals(input.ConsumedCertificates))
                ) && 
                (
                    this.ConsumedCredits == input.ConsumedCredits ||
                    (this.ConsumedCredits != null &&
                    this.ConsumedCredits.Equals(input.ConsumedCredits))
                ) && 
                (
                    this.ConsumedTimestamps == input.ConsumedTimestamps ||
                    (this.ConsumedTimestamps != null &&
                    this.ConsumedTimestamps.Equals(input.ConsumedTimestamps))
                ) && 
                (
                    this.CreditsPerMonth == input.CreditsPerMonth ||
                    (this.CreditsPerMonth != null &&
                    this.CreditsPerMonth.Equals(input.CreditsPerMonth))
                ) && 
                (
                    this.LimitationType == input.LimitationType ||
                    (this.LimitationType != null &&
                    this.LimitationType.Equals(input.LimitationType))
                ) && 
                (
                    this.RemainingCredits == input.RemainingCredits ||
                    (this.RemainingCredits != null &&
                    this.RemainingCredits.Equals(input.RemainingCredits))
                ) && 
                (
                    this.TimestampsPerMonth == input.TimestampsPerMonth ||
                    (this.TimestampsPerMonth != null &&
                    this.TimestampsPerMonth.Equals(input.TimestampsPerMonth))
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
                if (this.CertificatePerMonth != null)
                    hashCode = hashCode * 59 + this.CertificatePerMonth.GetHashCode();
                if (this.ConsumedCertificates != null)
                    hashCode = hashCode * 59 + this.ConsumedCertificates.GetHashCode();
                if (this.ConsumedCredits != null)
                    hashCode = hashCode * 59 + this.ConsumedCredits.GetHashCode();
                if (this.ConsumedTimestamps != null)
                    hashCode = hashCode * 59 + this.ConsumedTimestamps.GetHashCode();
                if (this.CreditsPerMonth != null)
                    hashCode = hashCode * 59 + this.CreditsPerMonth.GetHashCode();
                if (this.LimitationType != null)
                    hashCode = hashCode * 59 + this.LimitationType.GetHashCode();
                if (this.RemainingCredits != null)
                    hashCode = hashCode * 59 + this.RemainingCredits.GetHashCode();
                if (this.TimestampsPerMonth != null)
                    hashCode = hashCode * 59 + this.TimestampsPerMonth.GetHashCode();
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
