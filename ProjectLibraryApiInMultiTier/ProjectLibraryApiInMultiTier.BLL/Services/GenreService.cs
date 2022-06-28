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
    public class GenreService
    {
        private IGenreRepository genreRepository;

        public GenreService(IGenreRepository genreRepository)
        {
            this.genreRepository = genreRepository;
        }


        public GenreDTO GetById(int id)
        {
            return genreRepository.GetById(id)?.ToDTO();     
        }

        public IEnumerable<GenreDTO> GetAll()
        {
            return genreRepository.GetAll().Select(b => b.ToDTO());
        }


        public bool Insert(GenreDTO H)
        {
            return genreRepository.Insert(H.ToEntity()) > 0;
        }



        //public GenreDTO Insert(GenreDTO genre)
        //{
        //    int id = genreRepository.Insert(genre.ToEntity());

        //    genre.Id = id;
        //    return genre;
        //}

    }
}
