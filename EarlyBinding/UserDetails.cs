using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarlyBinding
{
    public class UserDetails
    {
        public void GetUserDetails()
        {
            User user = new User("Ike", "Physics");

            Console.WriteLine("Name: " + user.Name);
            Console.WriteLine("My Favorite Subject is: " + user.Subject);
        }
    }
}
