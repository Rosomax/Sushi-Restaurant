using SushiRestaurant.core;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SushiRestaurant.data
{
    public class SQLUserData : IUserData
    {
        private readonly SushiRestaurantDbContext dbU;

        public SQLUserData(SushiRestaurantDbContext dbU)
        {
            this.dbU = dbU;
        }

        public Users Add(Users newUser)
        {
            dbU.Add(newUser);
            return newUser;
        }

        public Users Delete(int id)
        {
            var userToDelete = GetById(id);
            if( userToDelete!=null)
            {
                dbU.Remove(userToDelete);
            }
            return userToDelete;
        }

        public Users GetById(int id)
        {
            return dbU.Users.Find(id);
        }

        public IEnumerable<Users> GetUserByName(string name)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            return dbU.SaveChanges();
        }

        public Users Update(Users updatedUser)
        {
            throw new NotImplementedException();
        }

        public bool Verify(Users logingUser)
        {
            Users searchedUser = new Users();
            searchedUser = dbU.Users.Where(s => s.Login == logingUser.Login).FirstOrDefault();
            if (searchedUser == null) return false;
            if (logingUser.Login == searchedUser.Login && logingUser.Password == searchedUser.Password) 
                return true;
                return false;
        }
    }
}
