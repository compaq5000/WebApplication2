<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CorresHome.aspx.cs" Inherits="WebApplication2.CorresHome" %>
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
            <div>
            <telerik:RadScriptManager runat="server" ID="RadScriptManager1" />

            <telerik:RadTabStrip RenderMode="Lightweight" ID="RadTabStrip1" runat="server" MultiPageID="RadMultiPage1"  SelectedIndex="2" Skin="Bootstrap">
                <Tabs>
                    <telerik:RadTab Text="" ImageUrl="IMG/Docorres.png"  Selected="True"></telerik:RadTab>
                    <telerik:RadTab Text="DETALLE" visible="true" ImageUrl="IMG/METADATA.png" ></telerik:RadTab>
                    <telerik:RadTab Text="SEGUIMIENTO"  ImageUrl="IMG/reply.png"  ></telerik:RadTab>
                    <telerik:RadTab Text="TEAM" ImageUrl="IMG/statuscorrespondencia/TEM.png" ></telerik:RadTab>
                    <telerik:RadTab Text="REPORTE"  ImageUrl="IMG/NEW.png" ></telerik:RadTab>
                    <telerik:RadTab Text="ACTUALIZAR ARCHIVO" ImageUrl="IMG/fileadjunto.png"></telerik:RadTab>
                     <%-- <telerik:RadTab Text="PERSONAS"></telerik:RadTab>--%>
                    <%--   <telerik:RadTab Text="TreeView"></telerik:RadTab>--%>
                </Tabs>
            </telerik:RadTabStrip>
                <telerik:RadMultiPage ID="RadMultiPage1" CssClass="RadMultiPage" runat="server" SelectedIndex="2">
                <telerik:RadPageView ID="RadPageView2" Selected="true" runat="server" Height="1200px" ContentUrl="LoadExpediente.aspx"></telerik:RadPageView>
                <telerik:RadPageView ID="RadPageView5"  runat="server" Height="1200px" ContentUrl="Detalle.aspx"></telerik:RadPageView>         
                <telerik:RadPageView ID="RadPageView1"  runat="server" Height="2000px" ContentUrl="FileCorrespondencia.aspx" ></telerik:RadPageView>
                <telerik:RadPageView ID="RadPageView3"  runat="server" Height="1200px" ContentUrl="TEAM.aspx"></telerik:RadPageView>

<%--ESTE ES ARCHIVO PARA RESPUESTA--%>
                <telerik:RadPageView ID="RadPageView6"  runat="server" Height="1200px" ContentUrl="FileUploadarchivo.aspx"></telerik:RadPageView>
                <telerik:RadPageView ID="RadPageView4"  runat="server" Height="2000px" ContentUrl="ActualizarCorrespondencia.aspx"></telerik:RadPageView>
             
                
<%--                <telerik:RadPageView ID="RadPageView6" runat="server" Height="1500px"  ContentUrl="team.aspx"></telerik:RadPageView>--%>
                <%--            <telerik:RadPageView ID="RadPageView7" runat="server" Height="700px" ContentUrl="https://docs.telerik.com/devtools/aspnet-ajax/controls/treeview/overview"></telerik:RadPageView>--%>
            </telerik:RadMultiPage>


        </div>
    </form>
</body>
</html>
