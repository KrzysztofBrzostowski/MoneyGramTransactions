<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebFormsUI.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/TransactionStyle.css" rel="stylesheet" />
    <script src="JavaScript1.js" type="text/javascript"></script>
    <style type="text/css">
        #form1 {
            height: 73px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="CenterObject">
    



        <asp:TextBox CssClass="CenterObject" ID="TextBox1" runat="server" Height="32px" Width="169px" ></asp:TextBox>
    
        <asp:Button ID="Button1" OnClientClick="ButtonClickClientSide()" runat="server" OnClick="Button1_Click" style="margin-left: 53px" Text="Button" Width="93px" />
   
        
    </div>
    </form>

            <button class="CenterObject" onclick="ButtonClick()">Kliknij mnie</button>
</body>
</html>
