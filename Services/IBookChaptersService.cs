using BooksService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksService.Services
{
	public interface IBookChaptersService
	{
		Task AddAsync(BookChapter bookChapter);
		Task AddRangeAsync(IEnumerable<BookChapter> chapters);
		Task<IEnumerable<BookChapter>> GetAllAsync();
		Task<BookChapter> FindAsync(Guid id);
		Task<BookChapter> RemoveAsync(Guid id);
		Task UpdateAsync(BookChapter bookChapter);
	}
}
