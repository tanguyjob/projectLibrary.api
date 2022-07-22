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
    public class LanguageService
    {
        private ILanguageRepositoty languageRepository; 

        public LanguageService(ILanguageRepositoty languageRepository)
        {
            this.languageRepository = languageRepository;
        }

        public IEnumerable<LanguageDTO> GetAll()
        {
            return languageRepository.GetAll().Select(b => b.ToDTO());
        }
    }
}
