<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication2.Index" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script type="text/javascript" src="JS/JavaScript.js"></script>



    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

            <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                <ContentTemplate>

                    <telerik:RadAjaxPanel ID="RadAjaxPanel4" LoadingPanelID="RadAjaxLoadingPanel3" EnableAJAX="true" runat="server">
                        <table style="width: 95%">
                            <tr>
                                <%--    <td style="width:33%">
                    <asp:Image Width="100%" ID="Image1" runat="server" ImageUrl="~/IMG/login/escudo.png" /></td>--%>
                                <%--  <td  style="width:33%; text-align:center">
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/IMG/login/admin.png" /></td>--%>
                                <td style="width: 100%; text-align: center">
                                    <asp:Image ID="Image3" runat="server" ImageUrl="~/IMG/login/asuntosjuridicos.png" /></td>
                            </tr>
                            <tr>
                                <%--                                <td colspan="3" style="background-image: url('img/login/sintillo.png'); margin-top: 0; height: 5px"></td>--%>
                            </tr>
                            <tr>
                                <%-- <td>
                    <asp:Image ID="Image4" runat="server" ImageUrl="~/IMG/login/izquierdo.png" />
                </td>--%>
                                <td colspan="2">

                                    <table style="width: 100%" border="0">
                                        <tr>
                                            <td colspan="2" style="font-family: Arial; font-size: x-large; text-align: center">
                                                <asp:Image runat="server" ID="IMG" ImageUrl="~/IMG/secretariado.png" Height="70px" />
                                                <%--                       <asp:Label Font-Bold="true" ID="Label2" runat="server" Text="LEGAL SCAN" ></asp:Label>--%>
                                            </td>

                                        </tr>
                                        <tr style="height: 50px">
                                            <td style="width: 30%; text-align: right">
                                                <asp:Label ID="Usuar" runat="server" Text="Usuario" Style="font-family: Arial" Font-Bold="true"></asp:Label>
                                            </td>
                                            <td style="width: 70%">
                                                <telerik:RadTextBox ID="RadTextBoxUsuario" Height="40px" EmptyMessage="Escribe Usuario" runat="server" Width="100%" Skin="Bootstrap">
                                                </telerik:RadTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="text-align: right">
                                                <asp:Label ID="Label1" Font-Bold="true" runat="server" Text="Contraseña" Style="font-family: Arial"></asp:Label></td>
                                            <td>
                                                <asp:Panel DefaultButton="RadButton1" ID="Panel1" runat="server">
                                                    <telerik:RadTextBox ID="RadTextBoxpassw" Height="40px" TextMode="Password" EmptyMessage="Escribe contraseña" runat="server" Width="100%" Skin="Bootstrap">
                                                    </telerik:RadTextBox>
                                                </asp:Panel>

                                            </td>
                                        </tr>
                                        <tr>

                                            <td style="text-align: right" colspan="3">
                                                <telerik:RadButton RenderMode="Lightweight" Width="100%" Height="60px" SingleClick="true" SingleClickText="Enviando..." ID="RadButton1" runat="server" Text="Confirmar" OnClick="btn_Click">
                                                </telerik:RadButton>
                                            </td>

                                        </tr>
                                    </table>

                                </td>
                            </tr>

                            <tr style="background-image: url('img/tejido.jpg'); margin-top: 0; height: 40px">
                                <td colspan="3">
                                    <%--<asp:Image ID="Image6" runat="server" ImageUrl="~/IMG/login/sintillo2.png" />--%>
                                </td>
                            </tr>
                        </table>

                    </telerik:RadAjaxPanel>
                    <telerik:RadAjaxLoadingPanel IsSticky="false" Width="100%" BackgroundPosition="center" EnableSkinTransparency="true" ID="RadAjaxLoadingPanel3" runat="server">

                        <table style="width: 100%">
                            <tr>
                                <td>
                                    <asp:Image ID="Image5" Width="70%" runat="server" ImageUrl="~/IMG/cargando2.gif" />
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: center">
                                    <asp:Label ID="Label3" Font-Bold="true" Font-Names="Arial" Font-Size="XX-Large" runat="server" ForeColor="Red">Un momento cargando... </asp:Label>
                                </td>
                            </tr>
                        </table>

                        <%-- <img alt="Loading..." src='<%= RadAjaxLoadingPanel.GetWebResourceUrl(Page, "Telerik.Web.UI.Skins.Default.Ajax.loading.gif") %>' style="border: 0;" />--%>
                    </telerik:RadAjaxLoadingPanel>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
