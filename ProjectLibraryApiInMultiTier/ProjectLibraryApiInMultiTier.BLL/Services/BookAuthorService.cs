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
    public class BookAuthorService
    {
        private IBookAuthorRepository bookauthorRepository;

        public BookAuthorService(IBookAuthorRepository baRepository)
        {
            this.bookauthorRepository = baRepository;
        }
        public IEnumerable<BookAuthorDTO> GetAll()
        {
            return bookauthorRepository.GetAll().Select(b => b.ToDTO());
        }
      
        public bool Insert(BookAuthorDTO ba)
        {
            return bookauthorRepository.Insert(ba.ToEntity()) > 0;
        }
    }
}
