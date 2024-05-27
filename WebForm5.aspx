<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication2.WebForm5" %>


<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register Assembly="Telerik.ReportViewer.Html5.WebForms, Version=15.2.21.1125, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" Namespace="Telerik.ReportViewer.Html5.WebForms" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="Scripts/jquery-3.4.1.min.js"></script>
    <link href="CSS/kendo.common.min.css" rel="stylesheet" />
    <link href="CSS/kendo.blueopal.min.css" rel="stylesheet" />
    <%-- <link href="https://kendo.cdn.telerik.com/2020.3.1118/styles/kendo.common.min.css" rel="stylesheet" />--%>
    <%--<link href="https://kendo.cdn.telerik.com/2020.3.1118/styles/kendo.blueopal.min.css" rel="stylesheet" />--%>



    <!--If Kendo is used it should be added before the report viewer.-->
    <script src="/api/reports/resources/js/telerikReportViewer-15.2.21.1125.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <telerik:ReportViewer ID="ReportViewer2" runat="server" ScaleMode="FitPageWidth">
                <ReportSource Identifier="ReportLibrary.IMPRIMIRFOLIOS, ReportLibrary, Version=15.2.21.915, Culture=neutral, PublicKeyToken=null" IdentifierType="TypeReportSource"></ReportSource>
            </telerik:ReportViewer>


        </div>
    </form>
</body>
</html>
