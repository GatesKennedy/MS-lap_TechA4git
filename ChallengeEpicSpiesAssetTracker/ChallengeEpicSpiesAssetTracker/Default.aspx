<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            background-color: #282828;
            font-family: Arial, Helvetica, sans-serif;
            font-weight: bold;
            font-size: medium;
            color: #f0f0f0;
        }
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <div class="auto-style1">
                <br />
                <br />
            <asp:Image ID="Image1" runat="server" Height="150px" ImageUrl="~/epic-spies-logo.jpg" />
            </div>
            <h2 class="auto-style1">Asset Performance Tracker</h2>
            <div class="auto-style1">
                Asset Name:
            <asp:TextBox ID="AssetTextBox" runat="server" BorderStyle="None"></asp:TextBox>
            <br />
            <br />
            &nbsp;Elections Rigged:
            <asp:TextBox ID="ElectionsTextBox" runat="server" BorderStyle="None"></asp:TextBox>
            <br />
            <br />
                Acts of Subterfuge Performed: <asp:TextBox ID="SubterfugeTextBox" runat="server" BorderStyle="None"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="AddButton" runat="server" OnClick="AddButton_Click" Text="Add Asset" BackColor="Gray" BorderStyle="None" Font-Bold="True" ForeColor="Black" />
            <br />
            <br />
            <asp:Label ID="ResultLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="RecordsLabel" runat="server"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
