using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpDeskSyste.Models.Database;

namespace ServiceLayer.Class
{
    public class Login
    {
        public Roletable GetinfoByUserCredentials(string Email, string Password)
        {
            Roletable roledata =  new Roletable();
            return roledata;
        }

    }
}
