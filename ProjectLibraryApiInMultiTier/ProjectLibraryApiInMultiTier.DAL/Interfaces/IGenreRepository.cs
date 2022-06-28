using ProjectLibraryApiInMultiTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryApiInMultiTier.DAL.Interfaces
{
    public interface IGenreRepository: IRepository<int, GenreEntity>
    {

    }
}
