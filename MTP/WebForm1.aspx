 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MTP.WebForm1" %>

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
               <li><a href="WebForm1.aspx">Login</a></li>
                <li><a href="Register.aspx">Register</a></li>
                <li><a href="https://ac.upt.ro">Contact</a></li>
             </ul>
           </nav>
    </header>
    </div>
</head>
<body>
      <section class="header-content">
      
           <div class="loginbox">
            <img src="user1.png" alt "Altenarte Text" class ="user"/>
            <h2>Welcome </h2>
            <form runat="server">
                <asp:Label ID="Label1" Text="" CssClass="lblmail" runat="server" />
                <asp:TextBox ID="TextBox2" runat="server" CssClass="txtpass"   placeholder="Enter your email"></asp:TextBox>
               
                <asp:TextBox ID="TextBox1" runat="server" CssClass="txtpass" TextMode="Password"  placeholder="Password*"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" CssClass="btn_login" OnClick="Button1_Click" Text="Log in" />
                <asp:Button ID="Button2" runat="server" CssClass="btn_register" OnClick="Button2_Click" Text="Register" />

            </form>
        </div>


      </section>
 
       
    
</body>
</html>

