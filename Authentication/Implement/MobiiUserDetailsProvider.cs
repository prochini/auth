using Authentication.Interface;
using Authentication.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.Implement
{
    public class MobiiUserDetailsProvider: UserDetailsProvider
    {
        public override UserDetails GetUserDetails(string loginId)
        {
            return new UserDetails();
        }
    }
}
