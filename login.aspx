<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication2.login" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <title></title>
    <script src="https://cdn.polyfill.io/v2/polyfill.min.js?features=Promise"></script>

<script type="text/javascript"> 
function OnKeyPress(sender, eventArgs) 
{ 
   var c = eventArgs.get_keyCode(); 
   if (c == 13) 
   { 
       __doPostBack('RadButton1','');      
   }      
} 
</script> 
</head>
<body>
    <form id="form1" runat="server">
             <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>


  
        <asp:UpdatePanel ID="UpdatePanel4" runat="server">
            <ContentTemplate>

                <telerik:RadAjaxPanel ID="RadAjaxPanel4" LoadingPanelID="RadAjaxLoadingPanel3" EnableAJAX="true" runat="server">
                    <table style="width: 100%" border="0">
                        <tr>
                            <td style="width: 33%">
                                <asp:Image ID="Image1" runat="server" ImageUrl="~/IMG/login/escudo.png" /></td>
                            <td style="width: 33%; text-align: center; font-family:'Century Gothic'; font-size:large">
                                <label runat="server" id="LABELTEXTO"  > SECRETARIADO EJECUTIVO DEL SISTEMA ESTATAL DE SEGURIDAD PÚBLICA</label></td>
                            <td style="width: 33%; text-align: right">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="3" style="background-image: url('img/login/sintillo.png'); margin-top: 0; height: 5px"></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Image ID="Image4" runat="server" ImageUrl="~/IMG/login/izquierdo.png" />
                            </td>
                            <td colspan="2">
                               
                                <table style="width: 100%" border="0" runat="server">
                                    <tr>
                                        <td colspan="2" style="font-family: Arial; font-size: x-large; text-align: center">
                                            <asp:Image ID="Image6" Height="250px" runat="server" Visible="false" ImageUrl="~/IMG/legalscan.png" />
                                            <td>&nbsp;</td>
                                        </td>

                                    </tr>
                                    <tr style="height: 50px">
                                        <td style="width: 300px; text-align: right">
                                            <asp:Label ID="Usuar" runat="server" Text="USUARIO" Style="font-family: Arial; font-size:larger" Font-Bold="true"></asp:Label>
                                        </td>
                                        <td style="width: 300px">
                                            
                                            <telerik:RadTextBox Height="50px" ID="RadTextBoxUsuario" EmptyMessage="Escribe Usuario" runat="server" Width="250px" Skin="Bootstrap">
                                            
                                            </telerik:RadTextBox>


                                            <br />
                                            <br />
                                        </td>
                                        <td style="width: 300px ; vertical-align:central" rowspan="2" >
                                            
                                            
                                            <asp:Image runat="server" ID="Lookpad" Height="100px" ImageUrl="~/IMG/lookpad.png" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: right">
                                            <asp:Label ID="Label1" Font-Bold="true" runat="server" Text="CONTRASEÑA" Style="font-family: Arial; font-size:larger"></asp:Label></td>
                                        <td>
                                            <telerik:RadTextBox ID="RadTextBoxpassw" Height="50px" TextMode="Password" EmptyMessage="Escribe contraseñña" runat="server" Width="250px" Skin="Bootstrap" >
                                           <ClientEvents OnKeyPress="OnKeyPress" />  
                                                </telerik:RadTextBox>

                                        </td>
                                     <%--   <td></td>--%>
                                    </tr>
                                    <tr>
                                        <td>
                                            &nbsp;</td>
                                        <td style="text-align: right">
                                            <telerik:RadButton  RenderMode="Lightweight" Width="200px" Height="50px" SingleClick="true" SingleClickText="Enviando..."  ID="RadButton1" runat="server" Text="Confirmar" OnClick="btn_Click" Skin="Bootstrap" >
                                            </telerik:RadButton>
                                        </td>
                                        <td></td>
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




                <telerik:RadAjaxLoadingPanel AnimationDuration="100"  IsSticky="false" Width="100%" BackgroundPosition="center" EnableSkinTransparency="true" ID="RadAjaxLoadingPanel3" runat="server">

                    <table style="width: 100%">
                        <tr>
                            <td>
                                <asp:Image ID="Image5" runat="server" ImageUrl="~/IMG/cargando.gif" />
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
    </form>
</body>
</html>
