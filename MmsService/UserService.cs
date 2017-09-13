using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmsData;
using MmsEntity;

namespace MmsService
{
    class UserService : IUserService
    {
        private IUserDataAccess data;
        public UserService(IUserDataAccess data)
        {
            this.data = data;
        }
        public IEnumerable<User> GetAll()
        {
            return this.data.GetAll();
        }

        public User GetByContact(string contact)
        {
            return this.data.GetByContact(contact);
        }

        public int Insert(User user)
        {
            return this.data.Insert(user);
        }

        public int UpdatePassword(User user)
        {
            return this.data.UpdatePassword(user);
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }

    }
}
