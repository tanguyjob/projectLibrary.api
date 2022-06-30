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
    public class BorrowingBookCustomRepository : IBorrowingBookCustom
    {
        protected Connection _Connection { get; set; }

        public BorrowingBookCustomRepository(Connection connection)
        {
            _Connection = connection;
         
        }

        public override IEnumerable<BorrowingBookCustomEntity> GetById(int id)
        {
            Command cmd = new Command($"SelectAllInfoBorrowingByUserId", true);
            cmd.AddParameter("Id", id);

            return _Connection.ExecuteReader(cmd, MapRecordToEntity);
        }

        private BorrowingBookCustomEntity MapRecordToEntity(IDataRecord arg)
        {
            // A compléter
            return new AuthorEntity()
            {
                Id = (int)record[TableId],
                Name = (string)record["Name"],
                Firstname = (string)record["Firstname"],
                Birthdate = (DateTime)record["Birthdate"],

            };
        }

        public int Insert(BorrowingBookCustomEntity entity)
        {
            throw new NotImplementedException();
        }

        BorrowingBookCustomEntity IRepository<int, BorrowingBookCustomEntity>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BorrowingBookCustomEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, BorrowingBookCustomEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
