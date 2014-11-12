using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Irakli {
    static class Helpers {
        public static SqlConnection Connection {
            get { return new SqlConnection("Server=Localhost;Database=myDataBase;Trusted_Connection=True;"); }
        }

        public static StudentCityDataContext SCDC
        {
            get { return new StudentCityDataContext(); }
        }
    }
}
