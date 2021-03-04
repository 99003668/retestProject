using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBooking
{
    public class User
    {

        string UName ;
        string Pswd;
        public int Login(String name, string password)
        {
            if (name == UName && password == Pswd)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }


}
