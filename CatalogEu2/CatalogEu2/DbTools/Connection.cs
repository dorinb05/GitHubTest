using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace CatalogEu2.DbTools
{
    class Connection
    {
        public SqlConnection con;


        public SqlConnection conectare()
        {
            con = new SqlConnection();
            //Bogdan
            //con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\Asus\Downloads\Licenta catalog 16 ianuarie\Licenta catalog 14 ianuarie\Licenta catalog 22 decembrie\Licenta\Database1.mdf';Integrated Security=True";
            //con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\Asus\Downloads\Licenta catalog 22 decembrie\Licenta catalog 22 decembrie\Licenta\Database1.mdf';Integrated Security=True";
            //Dorin
            con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\users\dorin\documents\visual studio 2013\Projects\CatalogEu2\CatalogEu2\Database1.mdf';Integrated Security=True";
            return con;
        }     
    }
}
