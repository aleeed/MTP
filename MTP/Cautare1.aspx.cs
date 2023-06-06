using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MTP
{
    public partial class Cautare1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-01G2M05\\SQLEXPRESS;Initial Catalog=Proiect_MTP;Integrated Security=True");
                SqlCommand cmd;
                SqlDataReader dr;

                try
                {
                    ConexiuneBD.conn.Open();
                    cmd = new SqlCommand("select Nume from date_studenti", ConexiuneBD.conn);

                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        DropDownList1.Items.Add(dr[0].ToString());
                    }

                }
                catch (Exception ex)
                {
                    LabelEroare.Text = "Nu se poate realiza conexiunea " + ex.Message;
                }
                finally
                {
                    ConexiuneBD.conn.Close();
                }
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-01G2M05\\SQLEXPRESS;Initial Catalog=Proiect_MTP;Integrated Security=True");
            SqlCommand cmd;

            try
            {
                ConexiuneBD.conn.Open();
                cmd = new SqlCommand("SELECT email, Nume, Prenume, Adresa, CNP, SerieCI, NrCI, NumeMama, NumeTata, Facultatea, AnStudiu, Specializarea, TeleofonParinte, TelefonStudent from date_studenti WHERE Nume='" + DropDownList1.Text + "'", ConexiuneBD.conn);
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        cmd.CommandType = CommandType.Text;
                        sda.Fill(dt);
                    }


                string htmlTable = "<table border='1' cellpadding='1' cellspacing='1' style='background-color':white align='center' ><tr>";
                foreach (DataColumn column in dt.Columns)
                {
                    htmlTable += "<th>" + column.ColumnName + "</th>";
                }
                htmlTable += "</tr>";
                foreach (DataRow dr in dt.Rows)
                {
                    string email = dr["email"].ToString();
                    string Nume = dr["Nume"].ToString();
                    string Prenume = dr["Prenume"].ToString();
                    string Adresa = dr["Adresa"].ToString();
                    string CNP = dr["CNP"].ToString();
                    string SerieCI = dr["SerieCI"].ToString();
                    string NrCI = dr["NrCI"].ToString();
                    string NumeMama = dr["NumeMama"].ToString();
                    string NumeTata = dr["NumeTata"].ToString();
                    string Facultatea = dr["Facultatea"].ToString();
                    string AnStudiu = dr["AnStudiu"].ToString();
                    string Specializarea = dr["Specializarea"].ToString();

                    string TeleofonParinte = dr["TeleofonParinte"].ToString();
                    string TelefonStudent = dr["TelefonStudent"].ToString();
                    htmlTable += "<tr><td>" + email + "</td><td>" + Nume + "</td><td>" + Prenume + "</td> <td>" + Adresa + "</td> <td>" + CNP + "</td> <td>" + SerieCI + "</td>" +
                        " <td>" + NrCI + "</td> <td>" + NumeMama + "</td> <td>" + NumeTata + "</td> <td>" + Facultatea + "</td> <td>" + AnStudiu + "</td> <td>" + Specializarea + "</td> " +
                        " <td>" + TeleofonParinte + "</td> <td>" + TelefonStudent + "</td> </tr>";
                }
                htmlTable += "</table>";
                lblTable.Text = htmlTable;


                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 1)
                {
                    string url = "Home.aspx";
                    Response.Redirect(url);
                }
                
            }


            catch (Exception ex)
            {
                //log error 
                LabelEroare.Text = "Eroare la deschidere baza date " + ex.Message;

            }
            //adaugarea datelor
            finally
            {
                ConexiuneBD.conn.Close();
            }
        }
    }
}
