<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Stergere.aspx.cs" Inherits="MTP.Stergere" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

     <link href="css/my.css" rel="stylesheet" />
    



        <div class="container-fluid">
    <!-- Background animtion-->
        <div class="background">
           <div class="cube"></div>
           <div class="cube"></div>
           <div class="cube"></div>
           <div class="cube"></div>
          <div class="cube"></div>
        </div>
    <!-- header -->
       <header>
    <!-- navbar -->
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
      
           <div class="loginbox">
           
            <h2>Stergere Student </h2>
            <h3> Introduceti numele pe care doriti sa il stergeti</h3>
            <form runat="server">
                <asp:Label ID="Label1" Text="" CssClass="lblmail" runat="server" />
      
                <asp:TextBox ID="TextBox1" runat="server" CssClass="txtpass"  placeholder="Nume Student"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" CssClass="btn_login" OnClick="Button1_Click" Text="Sterge Student" />
                  <asp:Label ID="LabelEroare" runat="server"></asp:Label>

            </form>
        </div>
      </section>
</body>
</html>
