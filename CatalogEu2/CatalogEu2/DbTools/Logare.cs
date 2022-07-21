using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace CatalogEu2.DbTools
{
    class Logare
    {
        SqlConnection con;
        string s;
        SqlDataAdapter da;
        DataTable dt, dt2;
        string CNP, parolaCont;


        public string logareCont(int tip, string email, string parola)
        {
            //tip=3 profesor, tip=1 elev, 
            //1 logare corecta, 0 logare incorecta
            string CNP = "0"; //by default

            //3=prof
            Connection c = new Connection();
            con = c.conectare();
            try { con.Close(); }
            catch (Exception e) { }
            con.Open();

            if (tip == 3)
            {
                //aflu CNP prof
                s = "select * from Profesor where email='" + email + "'";
                SqlCommand com1 = new SqlCommand(s, con);
                    SqlDataReader dr1 = com1.ExecuteReader();
                    while (dr1.Read())
                    {
                        String ceva = dr1[3].ToString();
                        Console.WriteLine(ceva);
                    }
                da = new SqlDataAdapter(s, con);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows[0][0] == "0")
                {
                    MessageBox.Show("Eroare logare (adresa de email nu exista) !");
                    return CNP;
                }
                else
                {
                    CNP = dt.Rows[0][0].ToString();
                    //aflu parola din Cont
                    s = "select * from Cont where CNP='" + CNP + "'";
                    /*SqlCommand com1 = new SqlCommand(s, con);
                    SqlDataReader dr1 = com1.ExecuteReader();
                    while (dr1.Read())
                    {
                        String ceva = dr1[3].ToString();
                        Console.WriteLine(ceva);
                    }*/

                    da = new SqlDataAdapter(s, con);
                    dt2 = new DataTable();
                    da.Fill(dt2);
                    if (dt2.Rows[0][0] == "0")
                    {
                        MessageBox.Show("Eroare logare!");
                        CNP = "0";
                        return CNP;
                    }
                    else
                    {
                        parolaCont = dt2.Rows[0][1].ToString();
                        if (String.Compare(parola, parolaCont) == 0)
                        {
                            //intra in DashBoard prof
                            return CNP;
                        }
                        else
                        {
                            MessageBox.Show("Eroare logare (parola incorecta)!");
                            return CNP;
                        }
                    }
                }
            }
            return CNP;
        }
    }
}
