using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DevExtreme.NETCore.Demos.ViewModels {
    public sealed class AgeVerificationAttribute : ValidationAttribute, IClientModelValidator {

        public void AddValidation(ClientModelValidationContext context) {
            MergeAttribute(context.Attributes, "data-val-custom-verifyage", FormatErrorMessage(context.ModelMetadata.GetDisplayName()));
            MergeAttribute(context.Attributes, "data-val-custom-verifyage-validationcallback", "verifyAge");
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
            var date = (DateTime?)value;
            if(date <= DateTime.Now.AddYears(-21)) {
                return ValidationResult.Success;
            }
            return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
        }

        bool MergeAttribute(IDictionary<string, string> attributes, string key, string value) {
            if(attributes.ContainsKey(key)) {
                return false;
            }
            attributes.Add(key, value);
            return true;
        }
    }
}
