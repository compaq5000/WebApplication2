<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImageUploader1.aspx.cs" Inherits="ImageUploader1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server" />
</head>
<body>
    <form id="form1" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js" />
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js" />
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js" />
        </Scripts>
    </telerik:RadScriptManager>
     <script type="text/javascript">
    //<![CDATA[
        function fileUploaded(sender, args) {
            var id = args.get_fileInfo().ImageID;
            $(".imageContainer")
                .empty()
                .append($("<img />")
                        .attr("src", getImageUrl(id)));
           
            $(".info")
                .html(String.format("<strong>{0}</strong> succesfully inserted. Record ID - {1}", args.get_fileName(), id));

        }

        function getImageUrl(id) {
            var url = window.location.href;
            var handler = "StreamImage.ashx?imageID=" + id;
            var index = url.lastIndexOf("/");
            var completeUrl = url.substring(0, index + 1) + handler;
            return completeUrl
        }

        function OnClientFileUploadRemoving(sender, args) {
            var index = args.get_rowIndex();
            $(".imageContainer img:eq(" + index + ")").remove();
        }
     //]]>
    </script>
     <span class="info"></span>
    <telerik:RadAsyncUpload runat="server" ID="RadAsyncUpload1" HttpHandlerUrl="~/Handler.ashx"
        OnClientFileUploaded="fileUploaded" OnClientFileUploadRemoving="OnClientFileUploadRemoving" MultipleFileSelection="Disabled">
    </telerik:RadAsyncUpload>
    <div class="imageContainer">
    </div>
    </form>
</body>
</html>
