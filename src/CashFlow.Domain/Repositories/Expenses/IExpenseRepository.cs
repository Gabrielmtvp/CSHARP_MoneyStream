using CashFlow.Domain.Entities;

namespace CashFlow.Domain.Repositories.Expenses;

public interface IExpenseRepository
{
    // Define methods for the repository
    void Add(Expense expense);
}
