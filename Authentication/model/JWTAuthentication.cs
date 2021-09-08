using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.model
{
    public class JWTAuthentication
    {
        private string jwt;

        public JWTAuthentication(string jwt)
        {
            this.jwt = jwt;
        }
    }
}
