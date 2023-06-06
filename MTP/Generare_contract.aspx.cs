using System;
using System.Text;
using System.Linq;
using Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using DataTable = System.Data.DataTable;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Security.Policy;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using System.Drawing;

namespace MTP
{

    public class SqlDataRetriever
    {
        private const string ConnectionString = "Data Source=DESKTOP-01G2M05\\SQLEXPRESS;Initial Catalog=Proiect_MTP;Integrated Security=True";

        public SqlDataReader RetrieveStudentData(string inputNume)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand("SELECT Nume, Prenume, Adresa, CNP, SerieCI, NrCI, NumeMama, NumeTata, Facultatea, AnStudiu, Specializarea, TeleofonParinte, TelefonStudent, Gen, NrMatricol, Judet FROM date_studenti WHERE Nume = @Nume", connection);
            command.Parameters.AddWithValue("@Nume", inputNume);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            return reader;
        }

    }


    public class FileRenamer
    {
        public void RenameFile(string currentFilePath, string newFileName)
        {
            // Get the directory path of the current file
            string directoryPath = Path.GetDirectoryName(currentFilePath);

            // Get the new file path by combining the directory path and new file name
            string newFilePath = Path.Combine(directoryPath, newFileName);

            // Rename the file
            File.Move(currentFilePath, newFilePath);
        }
    }


    public partial class Generare_contract : System.Web.UI.Page
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

                    dr.Close();

                    string selectedNume = DropDownList1.SelectedValue;
                    cmd = new SqlCommand("select Prenume from date_studenti WHERE Nume =@Nume", ConexiuneBD.conn);
                    cmd.Parameters.AddWithValue("@Nume", selectedNume);

                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        DropDownList2.Items.Add(dr[0].ToString());

                    }
                    dr.Close();

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

            try
            {
                string inputNume = DropDownList1.SelectedValue;
                string inputPrenume = DropDownList2.SelectedValue;




                SqlDataRetriever dataRetriever = new SqlDataRetriever();
                SqlDataReader reader = dataRetriever.RetrieveStudentData(inputNume);

               

                if (reader.Read())
                {
                    string Nume = reader["Nume"].ToString();
                    string Prenume = reader["Prenume"].ToString();
                    string Adresa = reader["Adresa"].ToString();
                    string CNP = reader["CNP"].ToString();
                    string SerieCI = reader["SerieCI"].ToString();
                    string NrCI = reader["NrCI"].ToString();
                    string NumeMama = reader["NumeMama"].ToString();
                    string NumeTata = reader["NumeTata"].ToString();
                    string Facultatea = reader["Facultatea"].ToString();
                    string AnStudiu = reader["AnStudiu"].ToString();
                    string Specializarea = reader["Specializarea"].ToString();
                    string TelefonParinte = reader["TeleofonParinte"].ToString();
                    string TelefonStudent = reader["TelefonStudent"].ToString();
                    string Gen = reader["Gen"].ToString();
                    string NrMatricol = reader["NrMatricol"].ToString();
                    string Judet = reader["Judet"].ToString();





                    CreateWordDocument(Nume, Prenume,  Adresa,  CNP,  SerieCI,  NrCI,  NumeMama,  NumeTata,  Facultatea,  AnStudiu,  Specializarea,  TelefonParinte,  TelefonStudent, Gen, NrMatricol, Judet, @"C:\Users\daria\Desktop\contract_template.docx", @"C:\Users\daria\Desktop\contract_Nou.docx");


                    string currentFilePath = @"C:\Users\daria\Desktop\contract_Nou.docx";

                    string newFileName = $"contract_{Nume}.docx";

                    FileRenamer fileRenamer = new FileRenamer();
                    fileRenamer.RenameFile(currentFilePath, newFileName);

                    LabelEroare.Text = "Contractul a fost generat cu success!";
                    
                    
                }
                   
                else
                    LabelEroare.Text = "Eroare la generarea contractului!";

                reader.Close();
            }
            catch (Exception ex)
            {
                LabelEroare.Text = "Eroare la deschidere baza date " + ex.Message;
            }

            finally
            {
                //string url = "Home.aspx";
                //Response.Redirect(url);
                ConexiuneBD.conn.Close();

            }
        }
        private void FindAndReplace(Microsoft.Office.Interop.Word.Application wordApp, object FindText, object replaceText)
        {

            object matchCase = true;

            object matchwholeWord = true;

            object matchwildCards = false;

            object matchSoundLike = false;

            object nmatchAllforms = false;

            object forward = true;

            object format = false;

            object matchKashida = false;

            object matchDiactitics = false;

            object matchAlefHamza = false;

            object matchControl = false;

            object read_only = false;

            object visible = true;

            object replace = -2;

            object wrap = 1;

            wordApp.Selection.Find.Execute(ref FindText, ref matchCase,
                                            ref matchwholeWord, ref matchwildCards, ref matchSoundLike,

                                            ref nmatchAllforms, ref forward,

                                            ref wrap, ref format, ref replaceText,

                                                ref replace, ref matchKashida,

                                            ref matchDiactitics, ref matchAlefHamza,
            ref matchControl);
        }

        private void CreateWordDocument(string Nume, string Prenume, string Adresa, string CNP, string SerieCI, string NrCI, string NumeMama, string NumeTata, string Facultatea, string AnStudiu, string Specializarea, string TeleofonParinte, string TelefonStudent, string Gen, string NrMatricol, string Judet, object filename, object SaveAs)
        {
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            object missing = Missing.Value;

            Microsoft.Office.Interop.Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;

                object isvisible = false;

                wordApp.Visible = false;
                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                                    ref missing, ref missing, ref missing,
                                                    ref missing, ref missing, ref missing,
                                                    ref missing, ref missing, ref missing,
                                                     ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();
                this.FindAndReplace(wordApp, "<nume_student> ", Nume);
                this.FindAndReplace(wordApp, "<prenume_student>", Prenume);
                this.FindAndReplace(wordApp, "<nume_tata>", NumeTata);
                this.FindAndReplace(wordApp, "<nume_mama>", NumeMama);
                this.FindAndReplace(wordApp, "<facultate>", Facultatea);
                this.FindAndReplace(wordApp, "<specializare>", Specializarea);
                this.FindAndReplace(wordApp, "<an_studiu>", AnStudiu);
                this.FindAndReplace(wordApp, "<adresa>", Adresa);
                this.FindAndReplace(wordApp, "<telefon_student>", TelefonStudent);
                this.FindAndReplace(wordApp, "<telefon_parinte> ", TelefonStudent);
                this.FindAndReplace(wordApp, "<CI>", SerieCI);
                this.FindAndReplace(wordApp, "<nr>", NrCI);
                this.FindAndReplace(wordApp, "<nr_matricol>", NrMatricol);
                this.FindAndReplace(wordApp, "<CNP>", CNP);
                this.FindAndReplace(wordApp, "<judet>", Judet);



                myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                                                                ref missing, ref missing, ref missing,
                                                                ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                                                                ref missing, ref missing, ref missing);

                myWordDoc.Close();
                wordApp.Quit();
            }


        }
    }
}