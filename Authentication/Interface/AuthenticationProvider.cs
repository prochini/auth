using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.Interface
{
    public abstract class AuthenticationProvider
    {
        public abstract void authenticate(Authentications Authentications);
    }
}
