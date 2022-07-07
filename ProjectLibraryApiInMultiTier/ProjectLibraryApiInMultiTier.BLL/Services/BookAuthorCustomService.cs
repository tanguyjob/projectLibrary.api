using ProjectLibraryApiInMultiTier.BLL.DTO;
using ProjectLibraryApiInMultiTier.BLL.Mappers;
using ProjectLibraryApiInMultiTier.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryApiInMultiTier.BLL.Services
{
    public class BookAuthorCustomService
    {
        private IBookAuthorCustomRepository Repository;
        public BookAuthorCustomService(IBookAuthorCustomRepository Repository)
        {
            this.Repository = Repository;
        }
        public IEnumerable<BookAuthorCustomDTO> GetByBookId(int id)
        {
            return Repository.GetByBookId(id)?.Select(b => b.ToDTO());
        }
    }
}
