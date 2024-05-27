<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RHHome.aspx.cs" Inherits="WebApplication2.RHHome" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
              <table style="width: 100%">
            <tr>
                <td>
                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                    <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                        <ContentTemplate>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
        </table>

        <div>
            <%--   <telerik:RadScriptManager runat="server" ID="RadScriptManager1" />--%>



            <telerik:RadTabStrip RenderMode="Lightweight" ID="RadTabStrip1" runat="server" MultiPageID="RadMultiPage1" SelectedIndex="4" Skin="Bootstrap">
                <Tabs>
                    <%--  <telerik:RadTab Text="" ImageUrl="IMG/Docorres.png" Selected="True" ></telerik:RadTab>--%>
                    <telerik:RadTab Text="GENERALES" ImageUrl="IMG/METADATA.png" Selected="true"></telerik:RadTab>
                    <telerik:RadTab Text="ARCHIVO DIGITAL" ImageUrl="IMG/2.png"></telerik:RadTab>
                    <telerik:RadTab Text="VACACIONES Y PERMISOS" ImageUrl="IMG/VACATIONS.png"></telerik:RadTab>
                    <telerik:RadTab Text="PASES Y JUSTIFICANTES" ImageUrl="IMG/NEW.png"></telerik:RadTab>
                    <%--<telerik:RadTab Text="GUARDIAS" ImageUrl="IMG/fileadjunto.png" ></telerik:RadTab>--%>
                    <telerik:RadTab Text="EXPEDIENTE" ImageUrl="IMG/expediente.png" ></telerik:RadTab>
                    <%-- <telerik:RadTab Text="PERSONAS"></telerik:RadTab>--%>
                    <%--   <telerik:RadTab Text="TreeView"></telerik:RadTab>--%>
                </Tabs>
            </telerik:RadTabStrip>
                <telerik:RadMultiPage ID="RadMultiPage1" CssClass="RadMultiPage" runat="server" SelectedIndex="4">
                <telerik:RadPageView ID="RadPageView2" Selected="true" runat="server" Height="1200px" ContentUrl="rh.aspx"></telerik:RadPageView>
                <telerik:RadPageView ID="RadPageView5" runat="server" Height="1200px" ContentUrl="RHArchivoDigital.aspx"></telerik:RadPageView>
                <telerik:RadPageView ID="RadPageView1" runat="server" Height="2000px" ContentUrl="VACACIONES.aspx"></telerik:RadPageView>
                <telerik:RadPageView ID="RadPageView3" runat="server" Height="1200px" ContentUrl="pases.aspx"></telerik:RadPageView>

                <%--ESTE ES ARCHIVO PARA RESPUESTA--%>
                
                   
<%--                    <telerik:RadPageView ID="RadPageView6" runat="server" Height="1200px" ContentUrl="FileUploadarchivo.aspx"></telerik:RadPageView>--%>
                      <telerik:RadPageView ID="RadPageView7" runat="server" Height="2000px" ContentUrl="ExpedienteInsidencia.aspx"></telerik:RadPageView>

<%--                <telerik:RadPageView ID="RadPageView4" runat="server" Height="2000px" ContentUrl="ActualizarCorrespondencia.aspx"></telerik:RadPageView>--%>
                

                <%--                <telerik:RadPageView ID="RadPageView6" runat="server" Height="1500px"  ContentUrl="team.aspx"></telerik:RadPageView>--%>
                <%--            <telerik:RadPageView ID="RadPageView7" runat="server" Height="700px" ContentUrl="https://docs.telerik.com/devtools/aspnet-ajax/controls/treeview/overview"></telerik:RadPageView>--%>
            </telerik:RadMultiPage>


        </div>
    </form>
</body>
</html>
