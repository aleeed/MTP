using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MTP
{
    public partial class Stergere : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-01G2M05\\SQLEXPRESS;Initial Catalog=Proiect_MTP;Integrated Security=True");
            SqlCommand cmd;
            
            try
            {
                ConexiuneBD.conn.Open();
                cmd = new SqlCommand("DELETE FROM date_studenti WHERE Nume = @Nume", ConexiuneBD.conn);
                cmd.Parameters.AddWithValue("@Nume", TextBox1.Text.Trim());

                int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        string url = "Home.aspx";
                        Response.Redirect(url);
                    }
                    else
                        LabelEroare.Text = "Eroare stergere!";
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
