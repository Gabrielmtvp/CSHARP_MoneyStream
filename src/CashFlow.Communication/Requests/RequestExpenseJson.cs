namespace CashFlow.Communication.Requests;

using CashFlow.Communication.Enums;

public class RequestExpenseJson
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public PaymentType PaymentType { get; set; }

}