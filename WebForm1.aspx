<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>
<%@ Register Assembly="Telerik.ReportViewer.Html5.WebForms, Version=15.2.21.915, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" Namespace="Telerik.ReportViewer.Html5.WebForms" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    	<script src="/api/reports/resources/js/telerikReportViewer-15.2.21.915.min.js/"></script>
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>

    <link href="https://kendo.cdn.telerik.com/2020.3.1118/styles/kendo.common.min.css" rel="stylesheet" />
    <link href="https://kendo.cdn.telerik.com/2020.3.1118/styles/kendo.blueopal.min.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <telerik:ReportViewer ID="ReportViewer1" runat="server">
                <ReportSource Identifier="ReportLibrary.Report2, ReportLibrary, Version=15.2.21.915, Culture=neutral, PublicKeyToken=null" IdentifierType="TypeReportSource">
                </ReportSource>
            </telerik:ReportViewer>
        </div>
    </form>
</body>
</html>
