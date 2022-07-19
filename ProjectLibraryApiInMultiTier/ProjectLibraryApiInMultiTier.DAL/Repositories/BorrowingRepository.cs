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
    public class BorrowingRepository : RepositoryBase<int, BorrowingEntity>, IBorrowingRepository
    {
        public BorrowingRepository(Connection connection) : base(connection, "Borrowing", "Id")
        {
        }
        public IEnumerable<BorrowingEntity> GetBorrowingByUserId(int id)
        {
            Command cmd = new Command($"Select b.Id,b.Title, b.[Resume],b.PublicationDate, b.LanguageId from Book b join BookAuthor ba on b.Id = ba.Id join Author a on a.Id= ba.AuthorId where ba.AuthorId=@id");

            cmd.AddParameter("id", id);

            return _Connection.ExecuteReader(cmd, MapRecordToEntity);

        }
        public override int Insert(BorrowingEntity entity)
        {
            Command cmd = new Command($"INSERT INTO {TableName} (DateBegin,DateBack,Additional,FK_Borrowing_Copy,FK_Borrowing_User)" +
              $" OUTPUT inserted.{TableId}" +
              " VALUES (@DateBegin,@DateBack,@Additional,@FK_Borrowing_Copy,@FK_Borrowing_User)");

            cmd.AddParameter("DateBegin", entity.DateBegin);
            cmd.AddParameter("DateBack", entity.DateBack);
            cmd.AddParameter("Additional", entity.Additional);
            cmd.AddParameter("FK_Borrowing_User", entity.FK_Borrowing_Copy);
            cmd.AddParameter("FK_Borrowing_User", entity.FK_Borrowing_User);


            int? rep = (int?)_Connection.ExecuteScalar(cmd);

            return rep ?? -1;
        }

        public override bool Update(int id, BorrowingEntity entity)
        {
            Command cmd = new Command($"UPDATE {TableName}" +
              " SET DateBegin = @DateBegin," +
              "     DateBack = @DateBack," +
              "     Additional = @Additional" +
              "     FK_Borrowing_Copy = @FK_Borrowing_Copy" +
              "     FK_Borrowing_User = @FK_Borrowing_User" +
              $" WHERE {TableId} = @Id");

            cmd.AddParameter("Id", entity.Id);
            return _Connection.ExecuteNonQuery(cmd) == 1;
        }

        protected override BorrowingEntity MapRecordToEntity(IDataRecord record)
        {
            return new BorrowingEntity()
            {
                Id = (int)record[TableId],
                DateBegin = (DateTime)record["DateBegin"],
                DateBack = (DateTime)record["DateBack"],
                Additional = (bool)record["Additional"],
                FK_Borrowing_Copy = (int)record["FK_Borrowing_Copy"],
                FK_Borrowing_User = (int)record["FK_Borrowing_User"]
            };
        }
    }
}
