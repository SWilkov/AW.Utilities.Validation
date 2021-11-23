using AW.Utilities.Validation.Models;

namespace AW.Utilities.Validation.Interfaces
{
  internal interface IInformationValidator<T> where T : class
  {
    ValidationInformation Validate(T item);
  }
}
