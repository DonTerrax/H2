using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Høj_samhørighed_og_lav_kobling
{
    class SendToDb
    {
        public void SendToDatabase(CreateUser create)
        {
            String queru = "INSERT INTO User(Name,Newsletter)" +
                           "VALUES("+ create.UserName +","+ create.Newsletter +")";
        }
    }
}
