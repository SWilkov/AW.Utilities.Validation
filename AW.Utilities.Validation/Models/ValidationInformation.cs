using AW.Utilities.Validation.Enums;

namespace AW.Utilities.Validation.Models
{
  internal class ValidationInformation
  {
    public string? Message { get; set; }
    public Result Result { get; set; }
    public ValidationInformation()
    {

    }
    public ValidationInformation(string message, Result result = Result.Valid)
    {
      this.Message = message;
      this.Result = result;
    }
  }
}
