<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleCalculator1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Simple Calculator</h1>
            Value One:
            <asp:TextBox ID="InputOne" runat="server"></asp:TextBox>
            <br />
            Value Two: <asp:TextBox ID="InputTwo" runat="server"></asp:TextBox>
            <br />
            <br />
            Operators:<br />
            <asp:Button ID="SumButton" runat="server" Text="+" OnClick="SumButton_Click" />
            <asp:Button ID="SubtractButton" runat="server" Text="-" OnClick="SubtractButton_Click" />
            <asp:Button ID="MultiplyButton" runat="server" Text="x" OnClick="MultiplyButton_Click" />
            <asp:Button ID="DivideButton" runat="server" Text="/" OnClick="DivideButton_Click" />
            <br />
            <br />
            Result:
            <asp:Label ID="ResultLabel" runat="server" BackColor="#FF0066" Font-Bold="True"></asp:Label>
        </div>
    </form>
</body>
</html>
