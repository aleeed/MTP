<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Generare_contract.aspx.cs" Inherits="MTP.Generare_contract" %>

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
            
            <h2>Genereaza contract </h2>
            <h3> Introduce-ti numele studentului pentru care doriti sa generati un contract</h3>
            <form runat="server">
               
                    
                 <asp:DropDownList ID="DropDownList1"  style="color: tan"  CssClass="txtdropdownlist" placeholder=" Selectati Nume Student" runat="server" >
                     </asp:DropDownList>

                 <asp:DropDownList ID="DropDownList2"  style="color: tan"  CssClass="txtdropdownlist" placeholder=" Selectati Prenume Student" runat="server" >

                    
                     </asp:DropDownList>


                     <asp:Button ID="Button1" runat="server" CssClass="btn_login" OnClick="Button1_Click" Text="Genereaza contract" />

                  <asp:Label ID="LabelEroare" runat="server"></asp:Label>

               
               

            </form>
        </div>
   </section>
</body>
</html>
