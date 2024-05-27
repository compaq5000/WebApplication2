<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoadExpediente.aspx.cs" Inherits="WebApplication2.LoadExpediente" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
       <%--    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/pdf.js/2.2.2/pdf.js"></script>--%>
    <script type="text/javascript" src="javasscript/pdf.js"></script>
</head>
<body>
    <form id="form1" runat="server">
              <telerik:RadScriptManager ID="RadScriptManager1" runat="server"></telerik:RadScriptManager>

            <table style="width: 100%">
                <tr>
                    <td style="text-align:right">
                        <telerik:RadButton ID="RadButton1" Visible="false" runat="server" Height="60px" Width="20%" Text="Descargar" OnClick="RadButton1_Click"  >
                            <Icon PrimaryIconCssClass="rbDownload"></Icon>
                        </telerik:RadButton>

                    </td>
                </tr>
            </table>



        <script type="text/javascript">
            //window.pdfjsLib.GlobalWorkerOptions.workerSrc = 'https://cdnjs.cloudflare.com/ajax/libs/pdf.js/2.2.2/pdf.worker.js';
            //window.pdfjsLib.GlobalWorkerOptions.workerSrc = 'http://192.168.1.2/javasscript/pdf.worker.js';
            window.pdfjsLib.GlobalWorkerOptions.workerSrc = 'http://localhost/javasscript/pdf.worker.js';

        </script>
        <div>
              
            <telerik:RadPdfViewer ID="RadPdfViewer1" Visible="false" runat="server" Scale="1.5" Width="100%" RenderMode="Lightweight">
                <PdfjsProcessingSettings>
                </PdfjsProcessingSettings>
                <%--                <ToolBarSettings Items="pager, spacer, zoom" />--%>
            </telerik:RadPdfViewer>

        </div>


    </form>
</body>
</html>
