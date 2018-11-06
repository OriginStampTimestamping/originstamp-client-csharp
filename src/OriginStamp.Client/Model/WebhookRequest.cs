/* 
 * OriginStamp Client
 * 
 * OpenAPI spec version: 3.0
 * OriginStamp Documentation: https://doc.originstamp.org
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
    public partial class WebhookRequest :  IEquatable<WebhookRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRequest" /> class.
        /// </summary>
        /// <param name="Hash">SHA-256 Hash in Hex representation (required).</param>
        /// <param name="WebhookUrl">target url that should receive the webhook (required).</param>
        public WebhookRequest(string Hash = default(string), string WebhookUrl = default(string))
        {
            // to ensure "Hash" is required (not null)
            if (Hash == null)
            {
                throw new InvalidDataException("Hash is a required property for WebhookRequest and cannot be null");
            }
            else
            {
                this.Hash = Hash;
            }
            // to ensure "WebhookUrl" is required (not null)
            if (WebhookUrl == null)
            {
                throw new InvalidDataException("WebhookUrl is a required property for WebhookRequest and cannot be null");
            }
            else
            {
                this.WebhookUrl = WebhookUrl;
            }
        }
        
        /// <summary>
        /// SHA-256 Hash in Hex representation
        /// </summary>
        /// <value>SHA-256 Hash in Hex representation</value>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public string Hash { get; set; }

        /// <summary>
        /// target url that should receive the webhook
        /// </summary>
        /// <value>target url that should receive the webhook</value>
        [DataMember(Name="webhook_url", EmitDefaultValue=false)]
        public string WebhookUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookRequest {\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  WebhookUrl: ").Append(WebhookUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as WebhookRequest);
        }

        /// <summary>
        /// Returns true if WebhookRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookRequest input)
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
