using Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_layer.Implementation
{
    public interface ILogin
    {
        Roletable GetinfoByUserCredentials(string email, string password);

    }
}
