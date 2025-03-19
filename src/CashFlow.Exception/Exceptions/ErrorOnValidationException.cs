using System.Collections.Generic;
using CashFlow.Exception.Exceptions;

namespace CashFlow.Exception.Exceptions;

public class ErrorOnValidationException : CashFlowException
{
    public List<string> Errors { get; set; }
    public ErrorOnValidationException(List<string> errorMessages)
    {
        Errors = errorMessages;
    }
}