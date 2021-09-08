using Authentication.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.Interface
{
    public abstract class UserDetailsProvider
    {
        public abstract UserDetails GetUserDetails(string loginId);
        
    }
}
