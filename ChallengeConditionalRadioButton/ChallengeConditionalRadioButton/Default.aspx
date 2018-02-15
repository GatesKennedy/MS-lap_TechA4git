<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeConditionalRadioButton.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Your Note Taking Preferences<br />
            <br />
            <asp:RadioButton ID="PencilRadioButton" runat="server" GroupName="NotesPreferences" Text="Pencil" />
            <br />
            <asp:RadioButton ID="PenRadioButton" runat="server" GroupName="NotesPreferences" Text="Pen" />
            <br />
            <asp:RadioButton ID="PhoneRadioButton" runat="server" GroupName="NotesPreferences" Text="Phone" />
            <br />
            <asp:RadioButton ID="TabletRadioButton" runat="server" GroupName="NotesPreferences" Text="Tablet" />
        </div>
        <p>
            <asp:Button ID="OkButton" runat="server" OnClick="OkButton_Click" Text="Ok" />
        </p>
        <p>
            <asp:Image ID="ResultImage" runat="server" BorderStyle="None" OnLoad="Page_Load" />
        </p>
        <p>
            <asp:Label ID="ResultLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
