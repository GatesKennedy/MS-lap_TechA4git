<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="150px" ImageUrl="~/epic-spies-logo.jpg" />
            <h2>Asset Performance Tracker</h2>
            Asset Name:
            <asp:TextBox ID="AssetTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Elections Rigged:
            <asp:TextBox ID="ElectionsTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Acts of Subterfuge Performed:
            <asp:TextBox ID="SubterfugeTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="AddButton" runat="server" OnClick="AddButton_Click" Text="Add Asset" />
            <br />
            <br />
            <asp:Label ID="ResultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
