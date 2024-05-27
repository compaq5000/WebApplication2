<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MINDEX.aspx.cs" Inherits="WebApplication2.MINDEX" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
  
    <%-- <link rel="stylesheet" href="styles/kendo.common.min.css" />
    <link rel="stylesheet" href="styles/kendo.default.min.css" />
    <link rel="stylesheet" href="styles/kendo.default.mobile.min.css" />--%>
    <link rel="stylesheet" href="https://kendo.cdn.telerik.com/2020.3.1118/styles/kendo.default-v2.min.css" />
    <script src="https://kendo.cdn.telerik.com/2020.3.1118/js/jquery.min.js"></script>
    <script src="https://kendo.cdn.telerik.com/2020.3.1118/js/kendo.all.min.js"></script>
    <script type="text/javascript"> 
        function OnKeyPress(sender, eventArgs) {
            var c = eventArgs.get_keyCode();
            if (c == 13) {
                __doPostBack('Button1', '');
            }
        }
    </script>


        <style type="text/css">

.MyLoadingImage
{
	position:absolute;
	top:50%;
	margin-top:-30px;
	left:50%;
	margin-left:-65px;
}

</style>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          <telerik:RadScriptManager ID="RadScriptManager1" runat="server"></telerik:RadScriptManager>








<telerik:RadAjaxPanel ID="RadAjaxPanel1" runat="server" LoadingPanelID="RadAjaxLoadingPanel3" EnableAJAX="true">
        <div id="example">
            <div class="demo-section k-content wide">
                <div id="toolbar"></div>
                <div id="drawer">
                    <div id="drawer-content">
                        <div id="Inbox" style="font-family: Arial">

             
                            <%--                            <ul class="inboxList">
                                <li>
                                    <h6>Monday meeting</h6>
                                    <p>Hi Tom, Since Monday I'll be out of office, I'm rescheduling the meeting for Tuesday.</p>
                                </li>
                                <li>
                                    <h6>I'm sorry, Tom</h6>
                                    <p>Hi Tom, my aunt comes for a visit this Saturday, so I can't come back to St. Pete...</p>
                                </li>
                            </ul>--%>
                        </div>
                        <div id="Expedientes" class="hidden" style="font-family: Arial">

          





                        </div>
                        <%--      <div id="Calendar" style="font-family: Arial" class="hidden">
                        </div>
                        <div id="Attachments" style="font-family: Arial" class="hidden">
                            <ul>
                                <li>Build enterprise apps</li>
                                <li>Fw: Regarding Multiline textbox</li>
                                <li>Away next week</li>
                                <li>Fw: Your Costume is ready</li>
                                <li>Update completed</li>
                            </ul>
                        </div>--%>

                        <div id="Salir" style="font-family: Arial" class="hidden">



           


                            <%--                            <ul>


                                <li>90% Discount!</li>
                                <li>90% Discount!</li>
                                <li>One time offer!</li>
                            </ul>--%>
                        </div>
                    </div>
                </div>
            </div>
            <script>
                $(document).ready(function () {
                    $("#drawer").kendoDrawer({
                        template: "<ul> \
                            <li data-role='drawer-item' class='k-state-selected'><span class='k-icon k-i-inbox'></span><span class='k-item-text' data-id='Inbox'>CORRESPONDENCIA</span></li> \
                            <li data-role='drawer-separator'></li> \
                            <li data-role='drawer-item'><span class='k-icon k-i-notification k-i-file'></span><span class='k-item-text' data-id='Expedientes'>EXPEDIENTES</span></li> \
                            <li data-role='drawer-separator'></li> \
                            <li data-role='drawer-item'><span class='k-icon k-i-x-outline'></span><span class='k-item-text' data-id='Salir'>SALIR</span></li> \
                          </ul>",
                        mode: "push",
                        mini: true,
                        itemClick: function (e) {
                            if (!e.item.hasClass("k-drawer-separator")) {
                                e.sender.drawerContainer.find("#drawer-content > div").addClass("hidden");
                                e.sender.drawerContainer.find("#drawer-content").find("#" + e.item.find(".k-item-text").attr("data-id")).removeClass("hidden");
                            }
                        },
                        position: 'left',
                        minHeight: 330,
                        swipeToOpen: true
                    });
                });

                function toggleDrawer() {
                    var drawerInstance = $("#drawer").data().kendoDrawer;
                    var drawerContainer = drawerInstance.drawerContainer;

                    if (drawerContainer.hasClass("k-drawer-expanded")) {
                        drawerInstance.hide();
                    } else {
                        drawerInstance.show();
                    }
                }

                $("#toolbar").kendoToolBar({
                    items: [
                        { type: "button", icon: "menu", attributes: { "class": "k-flat" }, click: toggleDrawer },
                        { template: "  <h3 style='margin-left: 10px; '>SECRETARIADO EJECUTIVO</h3>  " }
                    ]
                });
            </script>
            <style>
                #drawer-content li {
                    font-size: 1.2em;
                    padding-left: .89em;
                    background: 0 0;
                    border-radius: 0;
                    border-width: 0 0 1px;
                    border-color: rgba(33, 37, 41, 0.125);
                    border-style: solid;
                    line-height: 1.5em;
                    padding: 1.09em .84em 1.23em .84em;
                }

                    #drawer-content li:last-child {
                        border: 0;
                    }

                .hidden {
                    display: none;
                }

                #example .demo-section {
                    max-width: 640px;
                }

                .k-toolbar .k-icon {
                    font-size: 25px;
                }
            </style>
        </div>
</telerik:RadAjaxPanel>

        <telerik:RadAjaxLoadingPanel 
	     
            runat="server" Transparency="60"  Width="100%" BackColor="#666666" BackgroundPosition="center" EnableSkinTransparency="true" ID="RadAjaxLoadingPanel3">
            <table style="width: 100%">
               <%-- <tr>
                    <td>
                  <asp:Image ID="Image5" Height="6000px" runat="server" ImageUrl="~/IMG/cargando2.gif" />
                    </td>
                </tr>--%>
                <tr>
                    <td style="text-align: center">
                        <br />
                        <asp:Label ID="Label3" Font-Bold="true" Font-Names="Arial" Font-Size="Small" runat="server" ForeColor="#006699">Un momento cargando... </asp:Label>
                    </td>
                </tr>
            </table>
                                 <img  alt="Loading..." src='<%= RadAjaxLoadingPanel.GetWebResourceUrl(Page, "Telerik.Web.UI.Skins.Default.Ajax.loading.gif") %>' class="MyLoadingImage" />

        </telerik:RadAjaxLoadingPanel>
    </form>
</body>
</html>
