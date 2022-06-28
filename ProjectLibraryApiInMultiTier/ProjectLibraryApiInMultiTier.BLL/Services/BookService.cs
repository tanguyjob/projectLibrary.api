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
    public class BookService
    {
        private IBookRepository bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }


        public BookDTO GetById(int id)
        {
            return bookRepository.GetById(id)?.ToDTO();
        }

        public IEnumerable<BookDTO> GetAll()
        {
            return bookRepository.GetAll().Select(b => b.ToDTO());
        }

        public bool Insert(BookDTO H)
        {
            return bookRepository.Insert(H.ToEntity()) > 0;
        }

    }
}
