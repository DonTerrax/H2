using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Høj_samhørighed_og_lav_kobling
{
    class CreateUser
    {
        private string userName;
        private bool newsletter;

        public bool Newsletter
        {
            get { return newsletter; }
            set { newsletter = value; }
        }


        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public CreateUser(string userName,bool newsletter)
        {
            this.UserName = userName;
            this.Newsletter = newsletter;
        }

      
    }
}
