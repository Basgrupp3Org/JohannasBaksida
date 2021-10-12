using JohannasBaksida.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasBaksida.Areas.Identity.Data.Managers
{
    public class UserManager
    {
        private static UserManager _instance;
        public static UserManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new UserManager();
            }
            return _instance;
        }
        private UserManager()
        {

        }

      
    }
}
