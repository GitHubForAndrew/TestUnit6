using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnit6.Infrastructure.Abstract
{
    public interface IAuhtProvider
    {
        bool Auhtenticate(string username, string password);
    }
}
