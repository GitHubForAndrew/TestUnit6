using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestUnit6.Infrastructure.Abstract;
using System.Web.Security;

namespace TestUnit6.Infrastructure.Concrete
{
    public class FormsAuthProvider : IAuhtProvider
    {
        public bool Auhtenticate(string username, string password)
        {
            bool result = FormsAuthentication.Authenticate(username, password);
            if(result)
            {
                FormsAuthentication.SetAuthCookie(username, false);
            }
            return result;
        }
    }
}
