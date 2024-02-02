using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HospitalOtomation
{
    class SqlConnectionshortcut
    {

        public SqlConnection connect()
        {
            SqlConnection connet = new SqlConnection("Data Source=DESKTOP-HP2NA5H\\SQLEXPRESS;Initial Catalog=HospitalOtomation;Integrated Security=True");
            connet.Open();
            return connet;
        }
    }
}
