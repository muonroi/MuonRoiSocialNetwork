using BaseConfig.EntityObject.EntityObject;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text.Json.Serialization;

namespace BaseConfig.EntityObject.Entity
{
    public class ValidationObject
    {
        protected List<ErrorResult> _errorMessages = new();

        [JsonIgnore]
        public IReadOnlyCollection<ErrorResult> ErrorMessages => _errorMessages;

        protected Assembly GetAssembly()
        {
            return GetType().Assembly;
        }

        protected void AddValidationError(string errorCode, string propertyName, object propertyValue)
        {
            AddValidationError(errorCode, new List<string> { Helpers.GenerateErrorResult(propertyName, propertyValue) });
        }

        protected void AddValidationError(string errorCode, List<string> errorValues)
        {
            _errorMessages.Add(new ErrorResult
            {
                ErrorCode = errorCode,
                ErrorMessage = Helpers.GetErrorMessage(errorCode, GetAssembly()),
                ErrorValues = errorValues
            });
        }

        protected void AddValidationErrors(IEnumerable<ErrorResult> errorMessages)
        {
            _errorMessages.AddRange(errorMessages);
        }

        public virtual bool IsValid()
        {
            ValidationContext validationContext = new(this, null, null);
            List<ValidationResult> list = new();
            if (!Validator.TryValidateObject(this, validationContext, list, validateAllProperties: true))
            {
                foreach (ValidationResult item in list)
                {
#pragma warning disable CS8601 // Possible null reference assignment.
                    ErrorResult errorResult = new()
                    {
                        ErrorCode = item.ErrorMessage
                    };
#pragma warning restore CS8601 // Possible null reference assignment.
                    errorResult.ErrorMessage = Helpers.GetErrorMessage(item.ErrorMessage, GetAssembly());
                    foreach (string memberName in item.MemberNames)
                    {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                        PropertyInfo property = validationContext.ObjectType.GetProperty(memberName);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                        object value = property.GetValue(validationContext.ObjectInstance, null);
                        errorResult.ErrorValues.Add(Helpers.GenerateErrorResult(memberName, value));
                    }

                    _errorMessages.Add(errorResult);
                }
            }

            return _errorMessages.Count == 0;
        }
    }
}