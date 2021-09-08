using Authentication.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Authentication.Implement
{
    public class AuthenticationManager
    {
        AuthenticationProvider AuthenticationProvider;
        UserDetailsProvider UserDetailsProvider;

        public AuthenticationManager(AuthenticationProvider authenticationProvider, UserDetailsProvider userDetailsProvider)
        {
            AuthenticationProvider = authenticationProvider;
            UserDetailsProvider = userDetailsProvider;
        }

        public Authentications Authentications(Authentications Authentications)
        {
            return Authentications(Authentications);
        }

    }
}
