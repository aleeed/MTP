<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="MTP.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <%--<title></title>--%>
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
               <li><a href="Adauga.aspx">Adauga student student</a></li>
                <li><a href="Cautare1.aspx">Cautare Student</a></li>
                <li><a href="Stergere.aspx">Sterge Student</a></li>
                <li><a href="WebForm1.aspx">Log out</a></li>
             </ul>
           </nav>

    </header>


                   <title>W3.CSS Template</title>
            <meta charset="UTF-8">
            <meta name="viewport" content="width=device-width, initial-scale=1">
            <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
            <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Poppins">
            <style>
            body,h1,h2,h3,h4,h5 {font-family: "Poppins", sans-serif}
            body {font-size:16px;}
            .w3-half img{margin-bottom:-6px;margin-top:16px;opacity:0.8;cursor:pointer}
            .w3-half img:hover{opacity:1}
            </style>

</head>
<body>
    
        <nav class="w3-sidebar w3-red w3-collapse w3-top w3-large w3-padding" style="z-index:3;width:300px;font-weight:bold;" id="mySidebar"><br>
          <a href="javascript:void(0)" onclick="w3_close()" class="w3-button w3-hide-large w3-display-topleft" style="width:100%;font-size:22px">Close Menu</a>
          <div class="w3-container">
            <h3 class="w3-padding-64"><b>Company<br>Name</b></h3>
          </div>
          <div class="w3-bar-block">
            <a href="#" onclick="w3_close()" class="w3-bar-item w3-button w3-hover-white">Home</a> 
            <a href="#showcase" onclick="w3_close()" class="w3-bar-item w3-button w3-hover-white">Showcase</a> 
            <a href="#services" onclick="w3_close()" class="w3-bar-item w3-button w3-hover-white">Services</a> 
            <a href="#designers" onclick="w3_close()" class="w3-bar-item w3-button w3-hover-white">Designers</a> 
            <a href="#packages" onclick="w3_close()" class="w3-bar-item w3-button w3-hover-white">Packages</a> 
            <a href="#contact" onclick="w3_close()" class="w3-bar-item w3-button w3-hover-white">Contact</a>
              </div>
            </nav>
        

        <asp:Label ID="lblTable" CssClass="lbltabel" runat="server" />
      <asp:Label ID="LabelEroare" runat="server"></asp:Label>

</body>
</html>
