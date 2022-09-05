using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess2;

namespace MiddleTier
{
    public class User
    {
        private string userName = "";
        private string passWord = "";
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }       

        public string PassWord 
        {
            get { return passWord; }
            set { passWord = value; } 
        }
       public bool IsValid()
        {
            clsSqlServer obj = new clsSqlServer();
            if (obj.getUser(userName, passWord).Tables[0].Rows.Count==0)
            {
                return false;
            }
            else 
            {
                return true;
            }

        }
    }
}
