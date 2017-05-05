using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace LogServer.Common.Validator
{
    public class DataAnnotationsEntityValidator : IEntityValidator
    {
        #region 

        /// <summary>
        /// Get erros if object implement IValidatableObject
        /// </summary>
        /// <typeparam name="TEntity">The typeof entity</typeparam>
        /// <param name="item">The item to validate</param>
        /// <param name="errors">A collection of current errors</param>
        private void SetValidatableObjectErrors<TEntity>(TEntity item, List<string> errors) where TEntity : class
        {
            if (typeof (IValidatableObject).IsAssignableFrom(typeof (TEntity)))
            {
                var validationContext = new ValidationContext(item, null, null);

                var validationResults = ((IValidatableObject) item).Validate(validationContext);

                errors.AddRange(validationResults.Select(vr => vr.ErrorMessage));
            }
        }

        /// <summary>
        /// Get errors on ValidationAttribute
        /// </summary>
        /// <typeparam name="TEntity">The type of entity</typeparam>
        /// <param name="item">The entity to validate</param>
        /// <param name="errors">A collection of current errors</param>
        private void SetValidationAttributeErrors<TEntity>(TEntity item, List<string> errors) where TEntity : class
        {
            var result = from property in TypeDescriptor.GetProperties(item).Cast<PropertyDescriptor>()
                from attribute in property.Attributes.OfType<ValidationAttribute>()
                where !attribute.IsValid(property.GetValue(item))
                select attribute.FormatErrorMessage(string.Empty);

            if (result != null && result.Any())
            {
                errors.AddRange(result);
            }
        }

        #endregion

        public bool IsValid<TEntity>(TEntity item) where TEntity : class
        {
            if (item == null) return false;

            var validateMessages = new List<string>();
            SetValidatableObjectErrors<TEntity>(item, validateMessages);
            SetValidationAttributeErrors<TEntity>(item, validateMessages);
            return !validateMessages.Any();
        }

        public IEnumerable<string> GetInvalidMessage<TEntity>(TEntity item) where TEntity : class
        {
            if (item == null) return null;

            var validateMessages = new List<string>();
            SetValidatableObjectErrors<TEntity>(item, validateMessages);
            SetValidationAttributeErrors<TEntity>(item, validateMessages);

            return validateMessages;
        }
    }
}
