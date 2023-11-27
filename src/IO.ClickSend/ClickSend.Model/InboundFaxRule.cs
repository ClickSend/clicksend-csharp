/* 
 * ClickSend v3 API
 *
 *  This is an official SDK for [ClickSend](https://clicksend.com)  Below you will find a current list of the available methods for clicksend.  *NOTE: You will need to create a free account to use the API. You can register [here](https://dashboard.clicksend.com/#/signup/step1/)..* 
 *
 * OpenAPI spec version: 3.1
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
    /// Model for Inbound FAX Rules
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "ClassType")]
        public partial class InboundFaxRule :  IEquatable<InboundFaxRule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundFaxRule" /> class.
        /// </summary>
        /// <param name="dedicatedNumber">Dedicated Number. Can be &#x27;*&#x27; to apply to all numbers. (required).</param>
        /// <param name="ruleName">Rule Name. (required).</param>
        /// <param name="action">Action to be taken (AUTO_REPLY, EMAIL_USER, EMAIL_FIXED, URL, SMS, POLL, GROUP_SMS, MOVE_CONTACT, CREATE_CONTACT, CREATE_CONTACT_PLUS_EMAIL, CREATE_CONTACT_PLUS_NAME_EMAIL CREATE_CONTACT_PLUS_NAME, SMPP, NONE). (required).</param>
        /// <param name="actionAddress">Action address. (required).</param>
        /// <param name="enabled">Enabled: Disabled&#x3D;0 or Enabled&#x3D;1. (required).</param>
        public InboundFaxRule(string dedicatedNumber = default(string), string ruleName = default(string), string action = default(string), string actionAddress = default(string), decimal? enabled = default(decimal?))
        {
            // to ensure "dedicatedNumber" is required (not null)
            if (dedicatedNumber == null)
            {
                throw new InvalidDataException("dedicatedNumber is a required property for InboundFaxRule and cannot be null");
            }
            else
            {
                this.DedicatedNumber = dedicatedNumber;
            }
            // to ensure "ruleName" is required (not null)
            if (ruleName == null)
            {
                throw new InvalidDataException("ruleName is a required property for InboundFaxRule and cannot be null");
            }
            else
            {
                this.RuleName = ruleName;
            }
            // to ensure "action" is required (not null)
            if (action == null)
            {
                throw new InvalidDataException("action is a required property for InboundFaxRule and cannot be null");
            }
            else
            {
                this.Action = action;
            }
            // to ensure "actionAddress" is required (not null)
            if (actionAddress == null)
            {
                throw new InvalidDataException("actionAddress is a required property for InboundFaxRule and cannot be null");
            }
            else
            {
                this.ActionAddress = actionAddress;
            }
            // to ensure "enabled" is required (not null)
            if (enabled == null)
            {
                throw new InvalidDataException("enabled is a required property for InboundFaxRule and cannot be null");
            }
            else
            {
                this.Enabled = enabled;
            }
        }
        
        /// <summary>
        /// Dedicated Number. Can be &#x27;*&#x27; to apply to all numbers.
        /// </summary>
        /// <value>Dedicated Number. Can be &#x27;*&#x27; to apply to all numbers.</value>
        [DataMember(Name="dedicated_number", EmitDefaultValue=false)]
        public string DedicatedNumber { get; set; }

        /// <summary>
        /// Rule Name.
        /// </summary>
        /// <value>Rule Name.</value>
        [DataMember(Name="rule_name", EmitDefaultValue=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// Action to be taken (AUTO_REPLY, EMAIL_USER, EMAIL_FIXED, URL, SMS, POLL, GROUP_SMS, MOVE_CONTACT, CREATE_CONTACT, CREATE_CONTACT_PLUS_EMAIL, CREATE_CONTACT_PLUS_NAME_EMAIL CREATE_CONTACT_PLUS_NAME, SMPP, NONE).
        /// </summary>
        /// <value>Action to be taken (AUTO_REPLY, EMAIL_USER, EMAIL_FIXED, URL, SMS, POLL, GROUP_SMS, MOVE_CONTACT, CREATE_CONTACT, CREATE_CONTACT_PLUS_EMAIL, CREATE_CONTACT_PLUS_NAME_EMAIL CREATE_CONTACT_PLUS_NAME, SMPP, NONE).</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// Action address.
        /// </summary>
        /// <value>Action address.</value>
        [DataMember(Name="action_address", EmitDefaultValue=false)]
        public string ActionAddress { get; set; }

        /// <summary>
        /// Enabled: Disabled&#x3D;0 or Enabled&#x3D;1.
        /// </summary>
        /// <value>Enabled: Disabled&#x3D;0 or Enabled&#x3D;1.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public decimal? Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InboundFaxRule {\n");
            sb.Append("  DedicatedNumber: ").Append(DedicatedNumber).Append("\n");
            sb.Append("  RuleName: ").Append(RuleName).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ActionAddress: ").Append(ActionAddress).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(input as InboundFaxRule);
        }

        /// <summary>
        /// Returns true if InboundFaxRule instances are equal
        /// </summary>
        /// <param name="input">Instance of InboundFaxRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InboundFaxRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DedicatedNumber == input.DedicatedNumber ||
                    (this.DedicatedNumber != null &&
                    this.DedicatedNumber.Equals(input.DedicatedNumber))
                ) && 
                (
                    this.RuleName == input.RuleName ||
                    (this.RuleName != null &&
                    this.RuleName.Equals(input.RuleName))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.ActionAddress == input.ActionAddress ||
                    (this.ActionAddress != null &&
                    this.ActionAddress.Equals(input.ActionAddress))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
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
                if (this.DedicatedNumber != null)
                    hashCode = hashCode * 59 + this.DedicatedNumber.GetHashCode();
                if (this.RuleName != null)
                    hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.ActionAddress != null)
                    hashCode = hashCode * 59 + this.ActionAddress.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
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
