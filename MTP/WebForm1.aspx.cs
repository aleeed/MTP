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
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-01G2M05\\SQLEXPRESS;Initial Catalog=Proiect_MTP;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    ConexiuneBD.conn.Open();
                    cmd = new SqlCommand("select email from date_login", ConexiuneBD.conn);

                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        TextBox2.Text.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Label1.Text = "Nu se poate realiza conexiunea " + ex.Message;
                }
                finally
                {
                    ConexiuneBD.conn.Close();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConexiuneBD.conn.Open();
                cmd = new SqlCommand("select password from date_login where email='" + TextBox2.Text + "'", ConexiuneBD.conn);

                dr = cmd.ExecuteReader();
                if (!dr.Read())
                {
                    Label1.Text = "Datele sunt gresite!";
                }
                else
                {
                    string url;

                    if (EncDec.Decrypt(dr[0].ToString().Trim()) == TextBox1.Text.Trim())
                    {
                        Application["numeUser"] = TextBox2.Text;
                        url = "Home.aspx";
                        Response.Redirect(url);
                    }
                    else
                    {
                        Label1.Text = "Parola gresita!";
                    }
                }
            }
            catch (Exception ex)
            {
                Label1.Text = "Nu se poate realiza conexiunea " + ex.Message;
            }
            finally
            {
                ConexiuneBD.conn.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}