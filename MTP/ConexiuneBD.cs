using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MTP
{
    public class ConexiuneBD
    {
        public static SqlConnection conn = new SqlConnection("Data Source= DESKTOP-01G2M05\\SQLEXPRESS;Initial Catalog = Proiect_MTP; Integrated Security = True");
    }
}