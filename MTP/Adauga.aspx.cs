using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MTP
{
    public partial class Adauga : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-01G2M05\\SQLEXPRESS;Initial Catalog=Proiect_MTP;Integrated Security=True");
            SqlCommand cmd;
            if (TextBox5.Text.ToString().Length != 13)
            {
                Label1.Visible = true;
            }

            if (TextBox6.Text.ToString().Length != 2)
            {
                Label2.Visible = true;
            }
            if (TextBox7.Text.ToString().Length != 6)
            {
                Label3.Visible = true;
            }
            if (TextBox14.Text.ToString().Length != 10)
            {
                Label4.Visible = true;
            }
            if (TextBox13.Text.ToString().Length != 10)
            {
                Label5.Visible = true;
            }
            if (DropDownList1.SelectedValue == "")
            {
                Label6.Visible = true;
            }
            if (DropDownList2.SelectedValue == "")
            {
                Label7.Visible = true;
            }
            else
            {
                try
                {
                    ConexiuneBD.conn.Open();
                    cmd = new SqlCommand("insert into date_studenti (email, Nume,Prenume, Adresa, CNP, SerieCI, NrCI, NumeMama, NumeTata, Facultatea, AnStudiu, Specializarea, TeleofonParinte, TelefonStudent, Gen, NrMatricol, Judet)" +
                        " values(@email, @Nume,@Prenume, @Adresa, @CNP, @SerieCI, @NrCI, @NumeMama, @NumeTata, @Facultatea, @AnStudiu, @Specializarea, @TeleofonParinte, @TelefonStudent, @Gen, @NrMatricol, @Judet) ", ConexiuneBD.conn);
                    cmd.Parameters.AddWithValue("@email", TextBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@Nume", TextBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@Prenume", TextBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@Adresa", TextBox4.Text.Trim());

                    cmd.Parameters.AddWithValue("@CNP", TextBox5.Text.Trim());
                    cmd.Parameters.AddWithValue("@SerieCI", TextBox6.Text.Trim());
                    cmd.Parameters.AddWithValue("@NrCI", TextBox7.Text.Trim());
                    cmd.Parameters.AddWithValue("@NumeMama", TextBox8.Text.Trim());
                    cmd.Parameters.AddWithValue("@NumeTata", TextBox9.Text.Trim());
                    cmd.Parameters.AddWithValue("@Facultatea", DropDownList1.SelectedValue.Trim());
                    cmd.Parameters.AddWithValue("@AnStudiu", DropDownList2.SelectedValue.Trim());
                    cmd.Parameters.AddWithValue("@Specializarea", TextBox12.Text.Trim());
                    cmd.Parameters.AddWithValue("@TeleofonParinte", TextBox13.Text.Trim());
                    cmd.Parameters.AddWithValue("@TelefonStudent", TextBox14.Text.Trim());
                    
                    cmd.Parameters.AddWithValue("@Gen", DropDownList3.SelectedValue.Trim());
                    cmd.Parameters.AddWithValue("@NrMatricol", TextBox11.Text.Trim());
                    cmd.Parameters.AddWithValue("@Judet", TextBox10.Text.Trim());





                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        string url = "Home.aspx";
                        Response.Redirect(url);
                    }
                    else
                        LabelEroare.Text = "Eroare inserare!";
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
}