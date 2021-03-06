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
    /// Request object for a manual webhook request.
    /// </summary>
    [DataContract]
    public partial class ManualWebhookRequest :  IEquatable<ManualWebhookRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManualWebhookRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ManualWebhookRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ManualWebhookRequest" /> class.
        /// </summary>
        /// <param name="hash">SHA-256 Hash in Hex representation. (required).</param>
        /// <param name="webhookUrl">The target URL to which we send the timestamp information of the requested hash via a post request. (required).</param>
        public ManualWebhookRequest(string hash = default(string), string webhookUrl = default(string))
        {
            // to ensure "hash" is required (not null)
            if (hash == null)
            {
                throw new InvalidDataException("hash is a required property for ManualWebhookRequest and cannot be null");
            }
            else
            {
                this.Hash = hash;
            }
            // to ensure "webhookUrl" is required (not null)
            if (webhookUrl == null)
            {
                throw new InvalidDataException("webhookUrl is a required property for ManualWebhookRequest and cannot be null");
            }
            else
            {
                this.WebhookUrl = webhookUrl;
            }
        }
        
        /// <summary>
        /// SHA-256 Hash in Hex representation.
        /// </summary>
        /// <value>SHA-256 Hash in Hex representation.</value>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public string Hash { get; set; }

        /// <summary>
        /// The target URL to which we send the timestamp information of the requested hash via a post request.
        /// </summary>
        /// <value>The target URL to which we send the timestamp information of the requested hash via a post request.</value>
        [DataMember(Name="webhook_url", EmitDefaultValue=false)]
        public string WebhookUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManualWebhookRequest {\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  WebhookUrl: ").Append(WebhookUrl).Append("\n");
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
            return this.Equals(input as ManualWebhookRequest);
        }

        /// <summary>
        /// Returns true if ManualWebhookRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ManualWebhookRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManualWebhookRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.WebhookUrl == input.WebhookUrl ||
                    (this.WebhookUrl != null &&
                    this.WebhookUrl.Equals(input.WebhookUrl))
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
                if (this.Hash != null)
                    hashCode = hashCode * 59 + this.Hash.GetHashCode();
                if (this.WebhookUrl != null)
                    hashCode = hashCode * 59 + this.WebhookUrl.GetHashCode();
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
