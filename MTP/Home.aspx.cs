using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MTP
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = new DataTable();
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-01G2M05\\SQLEXPRESS;Initial Catalog=Proiect_MTP;Integrated Security=True");
                SqlCommand cmd;
               
                try
                {
                    ConexiuneBD.conn.Open();
                    cmd = new SqlCommand("SELECT email, Nume,Prenume, Adresa, CNP, SerieCI, NrCI, NumeMama, NumeTata, Facultatea, AnStudiu, Specializarea, TeleofonParinte, TelefonStudent" +
                        " FROM date_studenti", ConexiuneBD.conn);
                    
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

                        string Gen = dr["Gen"].ToString();
                        string NrMatricol = dr["NrMatricol"].ToString();
                        string Judet = dr["Judet"].ToString();


                        htmlTable += "<tr><td>" + email + "</td><td>" + Nume + "</td><td>" + Prenume + "</td> <td>" + Gen + "</td> <td>" + Adresa + "</td> <td>" + Judet + "</td> <td>" + CNP + "</td> <td>" + SerieCI + "</td>" +
                            " <td>" + NrCI + "</td> <td>" + NumeMama + "</td> <td>" + NumeTata + "</td> <td>" + Facultatea + "</td> <td>" + NrMatricol +" </td> <td>" + AnStudiu + "</td> <td>" + Specializarea + "</td> " +
                            " <td>" + TeleofonParinte + "</td> <td>" + TelefonStudent + "</td> </tr>";
                    }
                    htmlTable += "</table>";
                    lblTable.Text = htmlTable;

                }
                catch(Exception ex) {

                    LabelEroare.Text = "Eroare la deschidere baza date " + ex.Message;
                }
        
            finally
                {
                    ConexiuneBD.conn.Close();
                }
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Adauga.aspx");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Generare_contract.aspx");
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Stergere.aspx");
        }
    }
}



