using Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Implementation
{
    public interface ILogin
    {
        Roletable GetinfoByUserCredentials(string Email, string Password);
    }
}
