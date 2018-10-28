<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ex4.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 61%;
        }
        .auto-style2 {
            width: 223px;
            height: 30px;
            text-align: center;
        }
        .auto-style3 {
            text-align: center;
            width: 169px;
        }
        .auto-style4 {
            width: 223px;
            text-align: center;
        }
        .auto-style5 {
            height: 30px;
            text-align: center;
            width: 169px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style4"><strong>Get a number between 1 to 50</strong></td>
                <td class="auto-style3"><strong>The number is:</strong></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button_number" runat="server" Text="Get number" OnClick="Button_number_Click" />
                </td>
                <td id="Label_number" class="auto-style5">
                    <asp:Label ID="Label_number" runat="server" Text="..."></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

