using AW.Utilities.Validation.Enums;

namespace AW.Utilities.Validation.Interfaces
{
  internal interface IValidator<T> where T : class
  {
    Result Validate(T item);
  }
}
