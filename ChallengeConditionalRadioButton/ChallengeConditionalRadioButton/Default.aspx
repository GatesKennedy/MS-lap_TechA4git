<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeConditionalRadioButton.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style2 {
            text-align: left;
        }
        .auto-style3 {
            text-align: center;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style4 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
            <h2 class="auto-style3">&nbsp;</h2>
            <h2 class="auto-style3">Your Note Taking Preferences</h2>
            <p class="auto-style3">
                &nbsp;</p>
            <div class="auto-style4">
                Please Select from the following...<br />
            <br class="auto-style1" />
            <asp:RadioButton ID="PenRadioButton" runat="server" GroupName="NotesPreferences" Text="Pen" CssClass="auto-style1" />
                <br />
            <asp:RadioButton ID="PencilRadioButton" runat="server" GroupName="NotesPreferences" Text="Pencil" CssClass="auto-style1" />
            <br class="auto-style1" />
            <asp:RadioButton ID="PhoneRadioButton" runat="server" GroupName="NotesPreferences" Text="Phone" CssClass="auto-style1" />
            <br class="auto-style1" />
            <asp:RadioButton ID="TabletRadioButton" runat="server" GroupName="NotesPreferences" Text="Tablet" CssClass="auto-style1" />
            </div>
        </div>
        <p style="text-align: center">
            <asp:Button ID="OkButton" runat="server" OnClick="OkButton_Click" Text="Ok" CssClass="auto-style1" />
        </p>
        <p style="text-align: center">
            <asp:Image ID="ResultImage" runat="server" BorderStyle="None" OnLoad="Page_Load" CssClass="auto-style1" />
        </p>
        <p class="auto-style4">
            <asp:Label ID="ResultLabel" runat="server" CssClass="auto-style1"></asp:Label>
        </p>
    </form>
</body>
</html>
