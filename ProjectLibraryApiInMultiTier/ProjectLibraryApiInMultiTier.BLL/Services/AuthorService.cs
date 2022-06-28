using ProjectLibraryApiInMultiTier.BLL.DTO;
using ProjectLibraryApiInMultiTier.BLL.Mappers;
using ProjectLibraryApiInMultiTier.DAL.Interfaces;
using ProjectLibraryApiInMultiTier.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryApiInMultiTier.BLL.Services
{
    public class AuthorService
    {
        private IAuthorRepository authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }


        public AuthorDTO GetById(int id)
        {
            return authorRepository.GetById(id)?.ToDTO();
        }

        public IEnumerable<AuthorDTO> GetAll()
        {
            return authorRepository.GetAll().Select(b => b.ToDTO());
        }


        public bool Insert(AuthorDTO author)
        {
            return authorRepository.Insert(author.ToEntity()) > 0;
        }

    }
}
