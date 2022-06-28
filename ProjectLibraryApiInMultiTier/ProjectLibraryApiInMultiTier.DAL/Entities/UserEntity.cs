using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryApiInMultiTier.DAL.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Firstname { get; set; }
        public DateTime Birthdate { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
        public int FK_User_Address { get; set; }
        public int FK_User_Subscription{ get; set; }
        public int FK_User_Profile { get; set; }
    }
}
