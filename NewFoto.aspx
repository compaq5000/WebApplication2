<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewFoto.aspx.cs" Inherits="WebApplication2.NewFoto" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <fieldset><legend style="background-image: url('img/naranja.png'); text-align: left;font-size:larger;font-family:'Century Gothic'; margin-top: 0; height: 30px; box-shadow: 0 8px 6px -6px black;">Selecciona la nueva Imagen con formato JPG</legend>
                <table style="width:100%; font-family:Arial"><tr><td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Imagen"></asp:Label>
                    </td><td>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td></tr>
                    <tr><td colspan="2" style="text-align:right">
                        <asp:Label ID="Label2" runat="server" Text="" Font-Bold="true"></asp:Label>
                        <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" />
                        </td></tr>
                </table>

            </fieldset>
        </div>
    </form>
</body>
</html>
