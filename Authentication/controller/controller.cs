using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Authentication.model;
using Authentication.Implement;
using Authentication.Interface;

namespace Authentication.controller
{
    public class controller
    {
        public void authenticate(string jwt)
        {
            JWTAuthentication JWTAuthentication = new JWTAuthentication(jwt);
            EyesmediaAuthenticationProvider EyesmediaAuthenticationProvider = new EyesmediaAuthenticationProvider();
            MobiiUserDetailsProvider MobiiUserDetailsProvider = new MobiiUserDetailsProvider();
            AuthenticationManager AuthenticationManager = new AuthenticationManager(EyesmediaAuthenticationProvider, MobiiUserDetailsProvider);
            
            AuthenticationManager.Authentications(new Authentications());
        }
    }
}
