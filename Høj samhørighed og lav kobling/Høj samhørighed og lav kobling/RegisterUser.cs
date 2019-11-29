using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Høj_samhørighed_og_lav_kobling
{
    class RegisterUser
    {
        public void User(string name)
        {
            bool newsletter = new Newsletter().newsletter();
            CreateUser newUser = new CreateUser(name,newsletter);
            SendToDb db = new SendToDb();
            db.SendToDatabase(newUser);
        }

    }
}
