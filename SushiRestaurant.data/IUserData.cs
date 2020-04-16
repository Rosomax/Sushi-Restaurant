using System.Collections.Generic;
using SushiRestaurant.core;
namespace SushiRestaurant.data
{
    public interface IUserData
    {
        IEnumerable<Users> GetUserByName(string name);
        Users GetById(int id);
        Users Update(Users updatedUser);
        Users Add(Users newUser);
        Users Delete(int id);
        Users Verify(string login, string password);
        int Commit();
    }
}
