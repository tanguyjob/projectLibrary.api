using ProjectLibraryApiInMultiTier.DAL.Entities;
using ProjectLibraryApiInMultiTier.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Connections;

namespace ProjectLibraryApiInMultiTier.DAL.Repositories
{
    public class LanguageRepository : RepositoryBase<int, LanguageEntity>, ILanguageRepositoty
    {
        public LanguageRepository(Connection connection) : base(connection, "Language", "Id")
        {
        }

        public override int Insert(LanguageEntity entity)
        {
            throw new NotImplementedException();
        }

        public override bool Update(int id, LanguageEntity entity)
        {
            throw new NotImplementedException();
        }

        protected override LanguageEntity MapRecordToEntity(IDataRecord record)
        {
            return new LanguageEntity()
            {
                Id = (int)record[TableId],
                Name = (string)record["Name"]
            };
              
        }
    }
}
