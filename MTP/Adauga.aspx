<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adauga.aspx.cs" Inherits="MTP.Adauga" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="css/my.css" rel="stylesheet" />


     <div class="container-fluid">

        <div class="background">
           <div class="cube"></div>
           <div class="cube"></div>
           <div class="cube"></div>
           <div class="cube"></div>
          <div class="cube"></div>
        </div>
        
           <header>

         <nav>
            <ul>
                <li><a href="Home.aspx">Home</a></li>
             </ul>
           </nav>

    </header>

  </div>
</head>
<body>
    
     <section class="header-content">
        <div class="adaugbox">
            
            <h2>Adauga un student nou </h2>
            <h2>                    </h2>
            <form runat="server">
               
                    

                    <asp:TextBox ID="TextBox1" runat="server" CssClass="txtadg" placeholder="Email student"></asp:TextBox>
                    
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="txtadg" placeholder="Nume student"></asp:TextBox>
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="txtadg" placeholder="Prenume student"></asp:TextBox>

                <asp:DropDownList ID="DropDownList3" CssClass="txtdropdownlist" runat="server" Height="35px" Width="200px" placeholder="Gen"> 
                        
                        <asp:ListItem Value="">Selectati Genul</asp:ListItem>
                        <asp:ListItem style="color: black"> Masculin </asp:ListItem>
                        <asp:ListItem style="color: black"> Feminin </asp:ListItem>
                        
                </asp:DropDownList>

                        <asp:TextBox ID="TextBox10" runat="server" CssClass="txtadg" placeholder="Judet"></asp:TextBox>
                    
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="txtadg" placeholder="Adresa"></asp:TextBox>

                    <asp:TextBox ID="TextBox5" runat="server" CssClass="txtadg" placeholder="CNP"></asp:TextBox>
               
                    <asp:TextBox ID="TextBox6" runat="server" CssClass="txtadg" placeholder="Serie CI"></asp:TextBox>
                    <asp:TextBox ID="TextBox7" runat="server" CssClass="txtadg" placeholder="Numar CI"></asp:TextBox>

                      
                        <asp:TextBox ID="TextBox8" runat="server" CssClass="txtadg" placeholder="Nume mama"></asp:TextBox>
                        <asp:TextBox ID="TextBox9" runat="server" CssClass="txtadg" placeholder="Nume tata"></asp:TextBox>
                        <%--<asp:TextBox ID="TextBox10" runat="server" CssClass="txtadg" placeholder="Facultate"></asp:TextBox>--%>
                        
                           <asp:TextBox ID="TextBox12" runat="server" CssClass="txtadg" placeholder="Specializarea"></asp:TextBox>
                        <asp:TextBox ID="TextBox13" runat="server" CssClass="txtadg" placeholder="Telefon parinte"></asp:TextBox>
                        <asp:TextBox ID="TextBox14" runat="server" CssClass="txtadg" placeholder="Telefon Student"></asp:TextBox>
                        <asp:TextBox ID="TextBox11" runat="server" CssClass="txtadg" placeholder="Numar Matricol"></asp:TextBox>

                <asp:DropDownList ID="DropDownList1" CssClass="txtdropdownlist" runat="server" Height="35px" Width="200px" placeholder="Facultatea"> 
                        
                        <asp:ListItem Value="">Selectati Facultatea</asp:ListItem>
                        <asp:ListItem style="color: black"> Facultatea Automatica si Calculatoare </asp:ListItem>

                        <asp:ListItem style="color: black"> Facultatea Mecanica </asp:ListItem>
                        <asp:ListItem style="color: black"> Facultatea Electotehnica </asp:ListItem>
                        <asp:ListItem style="color: black"> Facultatea Stinte ale comunicarii </asp:ListItem>
                        <asp:ListItem style="color: black"> Facultatea Management </asp:ListItem>
                        <asp:ListItem style="color: black"> Facultatea Arhitectura </asp:ListItem>
                        <asp:ListItem style="color: black"> Facultatea Constructii </asp:ListItem>


                    </asp:DropDownList>


                 <asp:DropDownList ID="DropDownList2" CssClass="txtdropdownlist" runat="server" Height="35px" Width="200px" placeholder="Anul de Studiu"> 
                        
                        <asp:ListItem Value="">Selectati Anul de Studiu</asp:ListItem>
                        <asp:ListItem style="color: black"> 1 </asp:ListItem>
                        <asp:ListItem style="color: black"> 2 </asp:ListItem>
                        <asp:ListItem style="color: black"> 3 </asp:ListItem>
                        <asp:ListItem style="color: black"> 4 </asp:ListItem>
                        <asp:ListItem style="color: black"> 5 </asp:ListItem>
                        <asp:ListItem style="color: black"> 6 </asp:ListItem>


                </asp:DropDownList>


                <%--<asp:TextBox ID="TextBox11" runat="server" CssClass="txtadg" placeholder="An studiu"></asp:TextBox>--%>
                        
                    <h2>                    </h2>
                  
                

                 <asp:Button ID="Button1" runat="server" CssClass="btn_login" OnClick="Button1_Click" Text="Adauga" />


                <asp:Label ID="Label1" runat="server" Text="CNP incorect! CNP trebuie sa contina 13 numere" Visible="False"></asp:Label>
                <asp:Label ID="Label2" runat="server" Text="Seria CI incorecta! Seria CI trebuie sa contina 2 litere" Visible="False"></asp:Label>
                <asp:Label ID="Label3" runat="server" Text="Numar CI incorect! Numar CI trebuie sa contina 6 cifre" Visible="False"></asp:Label>
                <asp:Label ID="Label4" runat="server" Text="Telefon Parinte incorect! Numar de telefon trebuie sa contina 10 cifre" Visible="False"></asp:Label>

                <asp:Label ID="Label5" runat="server" Text="Telefon Student incorect! Numar de telefon trebuie sa contina 10 cifre" Visible="False"></asp:Label>
                <asp:Label ID="Label6" runat="server" Text="Va rugam alegeti o facultate" Visible="False"></asp:Label>
                <asp:Label ID="Label7" runat="server" Text="Va rugam alegeti anul de studiu" Visible="False"></asp:Label>

                <asp:Label ID="LabelEroare" runat="server"></asp:Label>

               
               

            </form>
        </div>
   </section>
</body>
</html>
