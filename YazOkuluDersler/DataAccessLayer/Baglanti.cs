using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-S866UD2;Initial Catalog=DbYazOkulu ;Integrated Security=True");
    }
}
