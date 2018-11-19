/* 
 * ClickSend v3 REST API
 *
 *  This is the official [ClickSend](https://clicksend.com) SDK.  *You'll need to create a free account to use the API. You can register [here](https://www.clicksend.com/signup).*  You can use our API documentation along with the SDK. Our API docs can be found [here](https://developers.clicksend.com). 
 *
 * OpenAPI spec version: 3.1.0
 * Contact: support@clicksend.com
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using ClickSendDateConverter = IO.ClickSend.Client.ClickSendDateConverter;

namespace IO.ClickSend.ClickSend.Model
{
    /// <summary>
    /// Email-to-SMS Allowed Address
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "classType")]
    public partial class EmailSMSAddress :  IEquatable<EmailSMSAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailSMSAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailSMSAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailSMSAddress" /> class.
        /// </summary>
        /// <param name="emailAddress">Your email address (required).</param>
        /// <param name="from">Your sender id (required).</param>
        /// <param name="subaccountId">Your subaccount id.</param>
        public EmailSMSAddress(string emailAddress = default(string), string from = default(string), string subaccountId = default(string))
        {
            // to ensure "emailAddress" is required (not null)
            if (emailAddress == null)
            {
                throw new InvalidDataException("emailAddress is a required property for EmailSMSAddress and cannot be null");
            }
            else
            {
                this.EmailAddress = emailAddress;
            }
            // to ensure "from" is required (not null)
            if (from == null)
            {
                throw new InvalidDataException("from is a required property for EmailSMSAddress and cannot be null");
            }
            else
            {
                this.From = from;
            }
            this.SubaccountId = subaccountId;
        }
        
        /// <summary>
        /// Your email address
        /// </summary>
        /// <value>Your email address</value>
        [DataMember(Name="email_address", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Your sender id
        /// </summary>
        /// <value>Your sender id</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }

        /// <summary>
        /// Your subaccount id
        /// </summary>
        /// <value>Your subaccount id</value>
        [DataMember(Name="subaccount_id", EmitDefaultValue=false)]
        public string SubaccountId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailSMSAddress {\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  SubaccountId: ").Append(SubaccountId).Append("\n");
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
            return this.Equals(input as EmailSMSAddress);
        }

        /// <summary>
        /// Returns true if EmailSMSAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailSMSAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailSMSAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.SubaccountId == input.SubaccountId ||
                    (this.SubaccountId != null &&
                    this.SubaccountId.Equals(input.SubaccountId))
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
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.SubaccountId != null)
                    hashCode = hashCode * 59 + this.SubaccountId.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
