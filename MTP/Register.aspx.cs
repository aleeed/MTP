using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MTP
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;

            try
            {

                string email = TextBox1.Text; // Get the string from the textbox
                if (email.EndsWith("@student.upt.ro") || email.EndsWith("@upt.ro"))
                {
                    ConexiuneBD.conn.Open();
                    cmd = new SqlCommand("insert into date_login (email,password) values(@nume,@pass) ", ConexiuneBD.conn);

                    cmd.Parameters.AddWithValue("@nume", TextBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", EncDec.Encrypt(TextBox2.Text.Trim()));

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        string url = "WebForm1.aspx";
                        Response.Redirect(url);
                    }
                    else
                        LabelEroare.ForeColor = Color.Red;
                        LabelEroare.Text = "Eroare inserare!";
                }
                else
                {
                    LabelEroare.ForeColor = Color.Red;
                    LabelEroare.Text = "Eroare, adresa de mail nu corespunde domaniului upt, introduceti adresa de student ";
                }
                
            }
            catch (Exception ex)
            {
                //log error 
                LabelEroare.ForeColor = Color.Red;
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