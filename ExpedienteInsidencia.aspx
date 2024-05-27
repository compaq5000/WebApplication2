<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExpedienteInsidencia.aspx.cs" Inherits="WebApplication2.ExpedienteInsidencia" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
      <script type="text/javascript" src="javasscript/Funcs.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                  <telerik:RadScriptManager ID="RadScriptManager1" runat="server"></telerik:RadScriptManager>

        <fieldset>
            <legend style="background-image: url('img/naranja.png'); text-align: left;font-size:larger;font-family:'Century Gothic'; margin-top: 0; height: 30px; box-shadow: 0 8px 6px -6px black;"><strong>
                <asp:Label ID="Label1" runat="server" Text="DOCUMENTACIÓN EXISTENTE DENTRO DEL EXPEDIENTE LABORAL "></asp:Label>
            </strong></legend>
            <table style="width: 100%">
                <tr><td style="font-family: 'Century Gothic'; text-align: left">
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td></tr>
                <tr><td  style="text-align:right">

                    <telerik:RadButton ID="RadButton1" runat="server" Text="Actualizar Grid" Skin="Bootstrap" OnClick="RadButton1_Click"></telerik:RadButton>
                    </td></tr>
                <tr>
                    <td>
                        <telerik:RadGrid ID="RadGrid1" runat="server" CellSpacing="-1" Culture="es-ES" GridLines="Both" OnNeedDataSource="RadGrid1_NeedDataSource" Skin="Bootstrap">
<GroupingSettings CollapseAllTooltip="Collapse all groups"></GroupingSettings>
                            <ClientSettings>
                                <Selecting AllowRowSelect="True" />
                            </ClientSettings>
                        </telerik:RadGrid>
                    </td>
                </tr>
            </table>
        </fieldset>
        </div>
    </form>
</body>
</html>
