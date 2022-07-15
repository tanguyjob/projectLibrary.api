using ProjectLibraryApiInMultiTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryApiInMultiTier.DAL.Interfaces
{
    public interface IBookRepository : IRepository<int, BookEntity>
    {
        public IEnumerable<BookEntity> GetBookByAuthorId(int id);
    }
}
