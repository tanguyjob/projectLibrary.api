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
    public class BorrowingBookCustomRepository:RepositoryBase<int, BorrowingBookCustomEntity>, IBorrowingBookCustom
    {
        protected Connection _Connection { get; set; }

        public BorrowingBookCustomRepository(Connection connection)
       : base(connection, "Book", "Id")
        {
            _Connection = connection;
         
        }

        public IEnumerable<BorrowingBookCustomEntity> GetByCustumerId(int id)
        {
            Command cmd = new Command($"SelectAllInfoBorrowingByUserId", true);
            cmd.AddParameter("Id", id);

            return _Connection.ExecuteReader(cmd, MapRecordToEntity);
        }

        protected override BorrowingBookCustomEntity MapRecordToEntity(IDataRecord record)
        {
            // A compléter
            return new BorrowingBookCustomEntity()
            {
                BorrowingId = (int)record["BorrowingId"],
                DateBack = (DateTime)record["DateBack"],
                DateBegin = (DateTime)record["DateBegin"],
                Additional = (bool)record["Additional"],
                CopyId = (int)record["CopyId"],
                Title = (string)record["Title"],
                Resume= (string)record["Resume"],
                PublicationDate = (DateTime)record["PublicationDate"]

            };
        }

        public override int Insert(BorrowingBookCustomEntity entity)
        {
            throw new NotImplementedException();
        }

        public override bool Update(int id, BorrowingBookCustomEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
