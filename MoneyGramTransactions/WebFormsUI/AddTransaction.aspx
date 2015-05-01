<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddTransaction.aspx.cs" Inherits="WebFormsUI.AddTransaction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="listCurrencies" runat="server">
        </asp:DropDownList>
        <br />

        <br />
        <asp:Label ID="Imie" runat="server" Text="Imie"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>

        <br />
        <asp:Label ID="Nazwisko" runat="server" Text="Nazwisko"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
    
        <br />
        <asp:Label ID="Kwota" runat="server" Text="Kwota"></asp:Label>
        <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>

    </div>
    </form>
</body>
</html>
