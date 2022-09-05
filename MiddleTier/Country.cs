using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess2;

namespace MiddleTier
{
    public class Country
    {
        public DataSet getCountries()
        {
            clsSqlServer obj = new clsSqlServer();
            return obj.getCountries();
        }
    }
}
