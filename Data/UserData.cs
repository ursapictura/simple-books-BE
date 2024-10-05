using System.ComponentModel.DataAnnotations;
using SimplyBooks.Models;

namespace SimplyBooks.Data
{
    public class UserData
    {
        public static List<User> Users = new()
        {
            new() { 
                Id = 1, 
                UserName = "chaosGoblin",
                Email = "chaosGoblin@gmail.com"
            },

            new() {
                Id = 2,
                UserName = "billCipher",
                Email = "cipher@gfalls.com"
            }
        };
    }
}
