using Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_layer.Class
{
    public class Login
    {

        ApidataEntities db1 = new ApidataEntities();
        public Roletable GetinfoByUserCredentials(string email, string password)
        {


            Roletable roledata = new Roletable();
             roledata =  db1.Roletable.Where(m => m.Email == email && m.Password == password).FirstOrDefault();


            //roletable credentials = roledata.where(Roletable=>)
            return roledata;
        } 

    }
}
