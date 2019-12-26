using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace DevExtreme.AspNet.Mvc
{
	public class DevExtremeRequiredAttribute : RequiredAttribute, IClientModelValidator
	{
		public override bool IsValid(object value)
		{
			if (value is bool)
			{
				return (bool)value;
			}
			return base.IsValid(value);
		}

		public void AddValidation(ClientModelValidationContext context)
		{
			context.Attributes.Add("data-val-devextremeRequired", FormatErrorMessage(context.ModelMetadata.GetDisplayName()));
		}
	}
}
