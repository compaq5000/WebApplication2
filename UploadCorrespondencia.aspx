<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadCorrespondencia.aspx.cs" Inherits="WebApplication2.UploadCorrespondencia" %>
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
            <telerik:RadScriptManager ID="RadScriptManager1" runat="server"></telerik:RadScriptManager>
            <telerik:RadFormDecorator RenderMode="Lightweight" ID="RadFormDecorator1" runat="server" DecoratedControls="Fieldset" EnableRoundedCorners="false" />
            <%--    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>--%>
            <%--                              <telerik:RadAjaxPanel ID="RadAjaxPanel4" LoadingPanelID="RadAjaxLoadingPanel3"  EnableAJAX="true" runat="server">--%>

            <fieldset>
                <legend style="background-image: url('img/naranja.png'); text-align: left;font-size:larger;font-family:Arial; margin-top: 0; height: 30px; box-shadow: 0 8px 6px -6px black;" >CARGAR ARCHIVO PDF</legend>
                <%--  <table style="width: 100%">
                            <tr>
                                <td>
                                                                        </td>

                                </td>
                            </tr>
                        </table>--%>



                <table style="width: 100%">
                    <tr>
                        <td rowspan="2">
<%--                            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>--%>
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/IMG/uploading.png" />
                        </td>
                        <td style="text-align:left">
                            <asp:FileUpload ID="FileUpload1" runat="server" /></td>
                    </tr>
                    <%--  <tr>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text="Label" Font-Bold="true"></asp:Label></td>
                                <td>
                                    <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Width="100%" Height="100px"></asp:TextBox></td>
                            </tr>--%>
                    <tr>

                        <td>

                            <telerik:RadButton Width="100%" Height="70PX" SingleClick="true" SingleClickText="Guardando..." Style="clear: both; float: right; margin: 10px 0;"
                                ID="RadButton1" runat="server" Text="Guardar Correspondencia" OnClick="Button1_Click" Skin="Bootstrap"  >
                                <Icon PrimaryIconCssClass="rbSave"></Icon>
                            </telerik:RadButton>
                        </td>
                    </tr>
                </table>
            </fieldset>

            <%--            </telerik:RadAjaxPanel>
                             <telerik:RadAjaxLoadingPanel Width="100%" BackgroundPosition="Top"   ID="RadAjaxLoadingPanel3" runat="server" >--%>
            <%-- <img alt="Loading..." src='<%= RadAjaxLoadingPanel.GetWebResourceUrl(Page, "Telerik.Web.UI.Skins.Default.Ajax.loading.gif") %>' style="border: 0;" />--%>

            <%--        </telerik:RadAjaxLoadingPanel>--%>

            <%--                </ContentTemplate>
            </asp:UpdatePanel>--%>
        </div>
    </form>
</body>
</html>
