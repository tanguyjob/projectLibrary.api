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
    public class AddressRepository:RepositoryBase<int, AddressEntity>, IAddessRepository
    {
        public AddressRepository(Connection connection) : base(connection, "Address", "Id")
        {
        }

        public override int Insert(AddressEntity entity)
        {
            Command cmd = new Command($"INSERT INTO {TableName} (City,PostCode,Street,Number,Box )" +
               $" OUTPUT inserted.{TableId}" +
               " VALUES (@City,@PostCode,@Street,@Number,@Box)");

            cmd.AddParameter("City", entity.City);
            cmd.AddParameter("PostCode", entity.PostCode);
            cmd.AddParameter("Street", entity.Street);
            cmd.AddParameter("Number", entity.Number);
            cmd.AddParameter("Box", entity.Box);


            int? rep = (int?)_Connection.ExecuteScalar(cmd);

            return rep ?? -1;
        }

   

        public override bool Update(int id, AddressEntity entity)
        {
            Command cmd = new Command($"UPDATE {TableName}" +
               " SET City = @City," +
               "     PostCode = @PostCode," +
               "     Street = @Street" +
               "     Number = @Number" +
               "     Box = @Box" +
               $" WHERE {TableId} = @Id");

            cmd.AddParameter("Id", entity.Id);
            return _Connection.ExecuteNonQuery(cmd) == 1;
        }

    
        protected override AddressEntity MapRecordToEntity(IDataRecord record)
        {
            return new AddressEntity()
            {
                Id = (int)record[TableId],
                City = (string)record["City"],
                PostCode = (string)record["PostCode"],
                Street = (string)record["street"],
                Number = (string)record["number"],
                Box = (string)record["box"]
            };
        }

       
    }
}
