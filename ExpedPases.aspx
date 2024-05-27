<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExpedPases.aspx.cs" Inherits="WebApplication2.ExpedPases" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 576px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <telerik:RadScriptManager ID="RadScriptManager1" runat="server"></telerik:RadScriptManager>
            <fieldset>
                <legend style="background-image: url('img/naranja.png'); text-align: left; font-size: larger; font-family: 'Century Gothic'; margin-top: 0; height: 30px; box-shadow: 0 8px 6px -6px black;">GENERADOR DE PASES DE SALIDA</legend>
                <table style="width: 100px">
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="Label1" Text="Adscripción"></asp:Label></td>
                        <td>
                            <telerik:RadComboBox Width="300px" ID="RadComboBoxAdscripciones1" runat="server" Skin="Bootstrap"></telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="Labl1" Text="Página"></asp:Label>
                        </td>
                        <td>
                            <telerik:RadComboBox ID="RadComboBoxHojas" runat="server" Skin="Bootstrap" Culture="es-ES">
                                <Items>
                                    <telerik:RadComboBoxItem runat="server" Text="1" Value="1" />
                                    <telerik:RadComboBoxItem runat="server" Text="2" Value="2" />
                                    <telerik:RadComboBoxItem runat="server" Text="3" Value="3" />
                                    <telerik:RadComboBoxItem runat="server" Text="4" Value="4" />
                                    <telerik:RadComboBoxItem runat="server" Text="5" Value="5" />
                                    <telerik:RadComboBoxItem runat="server" Text="6" Value="6" />
                                    <telerik:RadComboBoxItem runat="server" Text="7" Value="7" />
                                    <telerik:RadComboBoxItem runat="server" Text="8" Value="8" />
                                    <telerik:RadComboBoxItem runat="server" Text="9" Value="9" />
                                    <telerik:RadComboBoxItem runat="server" Text="10" Value="10" />
                                </Items>
                            </telerik:RadComboBox>
                        </td>

                    </tr>
                    <tr>
                        <td colspan="2">
                            <telerik:RadButton ID="RadButton2" runat="server" Text="Generar" Skin="Bootstrap" Width="150px" OnClick="RadButton2_Click"></telerik:RadButton>
                        </td>
                    </tr>
                </table>
            </fieldset>
            <telerik:RadWindow ID="RadWindow2" EnableEmbeddedScripts="true" ViewStateMode="Enabled" Behaviors="Default" runat="server" Width="450px" Height="450px" Modal="true"
                VisibleStatusbar="true" Animation="FlyIn" Title="" CssClass="ZindeX" VisibleOnPageLoad="True" Skin="Bootstrap">
            </telerik:RadWindow>
        </div>
    </form>
</body>
</html>
