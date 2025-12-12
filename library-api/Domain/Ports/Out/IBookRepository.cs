using library_api.Domain.Entities;

namespace library_api.Domain.Ports.Out
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<Book?> GetByISBNAsync(string isbn);
        Task<bool> ISBNExistsAsync(string isbn);
        Task<IEnumerable<Book>> GetBooksWithStockAsync();
        Task<IEnumerable<Book>> SearchByTitleOrAuthorAsync(string searchTerm);
    }
}