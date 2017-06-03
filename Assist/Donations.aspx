<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Donations.aspx.cs" Inherits="Donations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Donations</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="donationsform" runat="server">
    <div>
        <h1>Your Donations</h1>
        <asp:GridView ID="DonationsGridView" runat="server" CssClass="donationsGrid"></asp:GridView>
    <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Donate.aspx">Donate</asp:LinkButton>
        &nbsp;
        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/Default.aspx">Home</asp:LinkButton>
    </div>
        
    </form>
</body>
</html>
