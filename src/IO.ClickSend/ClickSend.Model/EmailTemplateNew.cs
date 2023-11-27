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
    /// Model for Email Templates
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "ClassType")]
        public partial class EmailTemplateNew :  IEquatable<EmailTemplateNew>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailTemplateNew" /> class.
        /// </summary>
        /// <param name="templateName">The intended name for the new template. (required).</param>
        /// <param name="templateIdMaster">The ID of the master template you want to base on. (required).</param>
        public EmailTemplateNew(string templateName = default(string), decimal? templateIdMaster = default(decimal?))
        {
            // to ensure "templateName" is required (not null)
            if (templateName == null)
            {
                throw new InvalidDataException("templateName is a required property for EmailTemplateNew and cannot be null");
            }
            else
            {
                this.TemplateName = templateName;
            }
            // to ensure "templateIdMaster" is required (not null)
            if (templateIdMaster == null)
            {
                throw new InvalidDataException("templateIdMaster is a required property for EmailTemplateNew and cannot be null");
            }
            else
            {
                this.TemplateIdMaster = templateIdMaster;
            }
        }
        
        /// <summary>
        /// The intended name for the new template.
        /// </summary>
        /// <value>The intended name for the new template.</value>
        [DataMember(Name="template_name", EmitDefaultValue=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// The ID of the master template you want to base on.
        /// </summary>
        /// <value>The ID of the master template you want to base on.</value>
        [DataMember(Name="template_id_master", EmitDefaultValue=false)]
        public decimal? TemplateIdMaster { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailTemplateNew {\n");
            sb.Append("  TemplateName: ").Append(TemplateName).Append("\n");
            sb.Append("  TemplateIdMaster: ").Append(TemplateIdMaster).Append("\n");
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
            return this.Equals(input as EmailTemplateNew);
        }

        /// <summary>
        /// Returns true if EmailTemplateNew instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailTemplateNew to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailTemplateNew input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TemplateName == input.TemplateName ||
                    (this.TemplateName != null &&
                    this.TemplateName.Equals(input.TemplateName))
                ) && 
                (
                    this.TemplateIdMaster == input.TemplateIdMaster ||
                    (this.TemplateIdMaster != null &&
                    this.TemplateIdMaster.Equals(input.TemplateIdMaster))
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
                if (this.TemplateName != null)
                    hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                if (this.TemplateIdMaster != null)
                    hashCode = hashCode * 59 + this.TemplateIdMaster.GetHashCode();
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
