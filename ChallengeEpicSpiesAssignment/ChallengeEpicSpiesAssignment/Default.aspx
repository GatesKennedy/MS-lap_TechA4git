<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" />
            <br />
            <h2>Spy New Assignment Form</h2>
            <br />
            <span class="auto-style1">Spy Code Name: </span>
            <asp:TextBox ID="SpyNameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <span class="auto-style1">New Assignment Name:</span>
            <asp:TextBox ID="AssignNameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <span class="auto-style1"><strong>Previous Assignment: End Date</strong></span><asp:Calendar ID="OldEndCalendar" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            <br />
            <span class="auto-style1"><strong>New Assignment: Start Date</strong></span><asp:Calendar ID="NewStartCalendar" runat="server"></asp:Calendar>
            <br />
            <span class="auto-style1"><strong>New Assignment: End Date (projected)</strong></span><asp:Calendar ID="NewEndCalendar" runat="server"></asp:Calendar>
            <br />
            <br />
            <asp:Button ID="ResultButton" runat="server" OnClick="ResultButton_Click" Text="Assign Spy" />
            <br />
            <br />
            <asp:Label ID="ResultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
