using library_api.Domain.Entities;

namespace library_api.Domain.Ports.Out
{
    public interface ILoanRepository : IRepository<Loan>
    {
        Task<IEnumerable<Loan>> GetActiveLoansAsync();
        Task<IEnumerable<Loan>> GetLoansByBookIdAsync(int bookId);
        Task<IEnumerable<Loan>> GetLoansByStudentNameAsync(string studentName);
        Task<Loan?> GetLoanWithBookAsync(int id);
        Task<IEnumerable<Loan>> GetAllWithBooksAsync();
    }
}