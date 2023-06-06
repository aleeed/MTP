<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cautare1.aspx.cs" Inherits="MTP.Cautare1" %>

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
            
            <h2>Cauta Student </h2>
            <form runat="server">
               
                    

                     <asp:DropDownList ID="DropDownList1"  style="color: black"  CssClass="txtdropdownlist" placeholder=" Selectati Nume Student" runat="server" />


                     <asp:Button ID="Button1" runat="server" CssClass="btn_login" OnClick="Button1_Click" Text="Cauta Student" />

                       <asp:Label ID="LabelEroare" runat="server"></asp:Label>
                       S<asp:Label ID="lblTable" CssClass="lbltabel" runat="server" />
               
               

            </form>
        </div>
   </section>
</body>
</html>