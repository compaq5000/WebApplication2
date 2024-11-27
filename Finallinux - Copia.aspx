<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Finallinux - Copia.aspx.cs" Inherits="WebApplication2.Final" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title></title>

    <script type="text/javascript">

        //<![CDATA[
        function onClientButtonClicking(sender, args) {
            var button = args.get_item();
            var parent = button.get_parent();
            var toolBar = button.get_toolBar();
            var alignDropDown = toolBar.get_items().getItem(5);

            if (parent == alignDropDown)
                alignDropDown.set_imageUrl(button.get_imageUrl());
            //]]>
        }
        //function OnClientLoad(sender, args) {
        //    var nodes = sender.get_allNodes();
        //    for (var i = 0; i < nodes.length; i++) {
        //        if (nodes[i].get_level() == 0) {
        //            nodes[i].set_imageUrl("../Images/button_edit_grey.gif");
        //        }
        //        else {
        //            nodes[i].set_imageUrl("../Images/edit.jpg");
        //        }
        //    }
        //}
    </script>
    <%--   <style type="text/css">
        .icon1 .rmLeftImage, .icon2 .rmLeftImage {
            background: transparent url('sprite.png') 0 0;
            width: 50px;
            height: 45px;
        }
    </style>--%>
    <%--<style type="text/css">
    html, body, form  
{  
   height: 100%;  
   margin: 0px;  
   padding: 0px;  
} 
     </style>  --%>
    <style type="text/css">
        .auto-style1 {
            height: 59px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <%--        <telerik:RadScriptManager ID="RadScriptManager1" runat="server"></telerik:RadScriptManager>--%>
        <telerik:RadAjaxLoadingPanel AnimationDuration="1000" RenderMode="Lightweight" IsSticky="true" Width="100%" Height="100%" BackgroundPosition="Center" ID="RadAjaxLoadingPanel3" runat="server">
            <%--                      <asp:Label ID="Label3" runat="server" ForeColor="Red">Loading... </asp:Label>                --%>
            <%--               <img alt="Loading..." src='<%= RadAjaxLoadingPanel.GetWebResourceUrl(Page, "Telerik.Web.UI.Skins.Default.Ajax.loading.gif") %>' style="border: 0;" />--%>
            <%--        <asp:Image ID="Image4" runat="server" ImageUrl="~/IMG/cargando.gif" />--%>
            <table style="width: 100%">
                <tr>
                    <td style="text-align: center">
                        <%--                        <asp:Image ID="Image4" runat="server" ImageUrl="~/IMG/cargando.gif" />--%>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <br />
                        <asp:Label ID="Label3" Font-Bold="true" Font-Names="Arial" Font-Size="Small" runat="server" ForeColor="#006699">Un momento cargando... </asp:Label>
                    </td>
                </tr>
            </table>
        </telerik:RadAjaxLoadingPanel>
        <table style="width: 100%; z-index: -20">
            <tr style="background-image: url('img/menu.png'); margin-top: 0; height: 30px">
                <td colspan="3">
                    <table style="width: 100%">
                        <tr>

                            <td>&nbsp;</td>
                            <td style="width: 100%"></td>
                            <td align="right" valign="top" style="margin-right: 30px">
                                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                    <ContentTemplate>
                                        <%--                                 <telerik:RadAjaxPanel ID="RadAjaxPanel4" LoadingPanelID="RadAjaxLoadingPanel3" EnableAJAX="true" runat="server">--%>
                                        <telerik:RadMenu RenderMode="Lightweight" ID="RadMenu1" runat="server" ShowToggleHandle="true" Width="60px" Height="60px" Font-Names="Arial" Skin="Bootstrap">
                                            <Items>
                                                <telerik:RadMenuItem Text="" ImageUrl="IMG/Users/14427.jpg">
                                                    <GroupSettings />
                                                    <Items>
                                                        <telerik:RadMenuItem Text="Perfil" NavigateUrl="Perfil.aspx" EnableImageSprite="true"></telerik:RadMenuItem>
                                                        <telerik:RadMenuItem Text="Bitacora" NavigateUrl="bitacora.aspx" EnableImageSprite="true" Enabled="false"></telerik:RadMenuItem>
                                                        <telerik:RadMenuItem Text="Cerrar Sesion" NavigateUrl="LogOff.aspx" EnableImageSprite="true"></telerik:RadMenuItem>
                                                    </Items>
                                                </telerik:RadMenuItem>
                                            </Items>
                                        </telerik:RadMenu>
                                        <%--  </telerik:RadAjaxPanel>--%>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr style="background-image: url('img/tejido.jpg'); margin-top: 0; height: 30px">
                <td colspan="3"></td>
            </tr>
            <tr>
                <td colspan="3" style="z-index: -20">
                    <telerik:RadAjaxPanel ID="RadAjaxPanel5" LoadingPanelID="RadAjaxLoadingPanel3" EnableAJAX="true" runat="server">
                        <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                            <ContentTemplate>
                                <telerik:RadToolBar SingleClick="Button" SingleClickText="Un Monento..." Style="font-family: Arial" RenderMode="Lightweight" ID="RadToolBar1" runat="server" OnButtonClick="onClientButtonClicking"
                                    EnableRoundedCorners="true" EnableShadows="true" Skin="Bootstrap">
                                    <Items>
                                        <telerik:RadToolBarButton ImageUrl="IMG/new.png"
                                            Text="MINUTAS" ToolTip="Nuevo Folder" Visible="false" Value="folder" Height="32px">
                                        </telerik:RadToolBarButton>
                                        <telerik:RadToolBarButton ImageUrl="IMG/CONTACT.png"
                                            Text="AGENDA" ToolTip="AGENDA MUNICIPAL" Value="C" Visible="false">
                                        </telerik:RadToolBarButton>
                                        <telerik:RadToolBarButton ImageUrl="IMG/FORTAMUN.png"
                                            Text="FORTAMUN" Group="Bold" ToolTip="Bold" Value="RH" Enabled="TRUE">
                                        </telerik:RadToolBarButton>
                                        <telerik:RadToolBarButton ImageUrl="IMG/RH.png"
                                            Text="Pases de Salida" Group="Bold" ToolTip="Bold" Value="Pases de Salida" Visible="false" Enabled="false">
                                        </telerik:RadToolBarButton>

                                        <telerik:RadToolBarButton ImageUrl="IMG/cut.png"
                                            Text="CORTAR" Group="Italic" ToolTip="Italic" Value="cut">
                                        </telerik:RadToolBarButton>
                                        <telerik:RadToolBarButton ImageUrl="IMG/copy.png" Value="copy"
                                            Text="COPIAR"
                                            ToolTip="Copiar">
                                        </telerik:RadToolBarButton>
                                        <telerik:RadToolBarButton Text="PEGAR" ImageUrl="IMG/paste.png" Value="paste"
                                            ToolTip="Pegar">
                                        </telerik:RadToolBarButton>

                                        <telerik:RadToolBarButton ImageUrl="IMG/security.png" Value="Users"
                                            Text="SEGURIDAD" Visible="false" Enabled="TRUE" ToolTip="Configurar Seguridad de acceso para los usuarios">
                                        </telerik:RadToolBarButton>
                                        <telerik:RadToolBarButton Visible="false" ImageUrl="IMG/Bitacora.png" Value="Bitacora"
                                            Text="BITACORA" ToolTip="Ir al modulo de bitacora de actividades">
                                        </telerik:RadToolBarButton>
                                        <telerik:RadToolBarButton ImageUrl="IMG/soportecnico.png"
                                            Text="Soporte técnico" Group="Bold" ToolTip="Bold" Value="Soporte" Enabled="TRUE">
                                        </telerik:RadToolBarButton>
                                        <telerik:RadToolBarButton ImageUrl="IMG/exit.png" Value="exit"
                                            Text="CERRAR SESIÓN" ToolTip="Cerrar sesión actual">
                                        </telerik:RadToolBarButton>
                                    </Items>
                                </telerik:RadToolBar>

                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </telerik:RadAjaxPanel>

                </td>
            </tr>
            <tr>
                <td colspan="3">

                    <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                        <ContentTemplate>
                            <i>
                                <asp:Label ID="Label1" runat="server" Text="" Font-Bold="true" Style="font-family: Arial"></asp:Label>
                            </i>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>


            </tr>

            <%-- <tr><td colspan="3">
              


                </td></tr>--%>
        </table>



        <telerik:RadSplitter RenderMode="Lightweight" ID="RadSplitter1" ResizeMode="AdjacentPane" Font-Names="Arial" Font-Size="Medium" runat="server" Width="100%" LiveResize="true" Height="900PX" Skin="Bootstrap">
            <telerik:RadPane ID="LeftPane" runat="server" Width="22px" Scrolling="none">
                <telerik:RadSlidingZone ClickToOpen="true" ID="SlidingZone1" runat="server" Width="22px" DockedPaneId="RadSlidingPane1">
                    <telerik:RadSlidingPane ID="RadSlidingPane1" Font-Names="Arial" Title="Carpetas" runat="server" Width="500px" IconUrl="~/IMG/1.png">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <telerik:RadAjaxPanel ID="RadAjaxPanel21" LoadingPanelID="RadAjaxLoadingPanel3" EnableAJAX="true" runat="server">

                                    <telerik:RadTreeView RenderMode="Lightweight" ID="RadTreeView1" runat="server" OnNodeClick="RadTreeView1_NodeClick" Skin="Bootstrap">
                                        <ContextMenus>
                                            <telerik:RadTreeViewContextMenu ID="MainContextMenu" runat="server"
                                                enderMode="Lightweight">
                                                <Items>
                                                    <telerik:RadMenuItem Value="NewFolder" Text="New Folder" ImageUrl="~/TreeView/images/Outlook/12.gif">
                                                    </telerik:RadMenuItem>
                                                </Items>
                                                <CollapseAnimation Type="none"></CollapseAnimation>
                                            </telerik:RadTreeViewContextMenu>
                                        </ContextMenus>
                                        <NodeTemplate>
                                            <asp:Image ImageUrl="~/IMG/1.png" runat="server" /><%# Eval("Descripcion")%>
                                        </NodeTemplate>
                                        <Nodes>
                                        </Nodes>
                                    </telerik:RadTreeView>
                                </telerik:RadAjaxPanel>
                            </ContentTemplate>
                        </asp:UpdatePanel>

                    </telerik:RadSlidingPane>

                    <telerik:RadSlidingPane ID="Radslidingpane3" Title="" runat="server" Width="500px"
                        MinWidth="130" IconUrl="~/IMG/New_Folder_2-128.png">
                        <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                            <ContentTemplate>
                                <telerik:RadAjaxPanel ID="RadAjaxPanel2" LoadingPanelID="RadAjaxLoadingPanel3" EnableAJAX="true" runat="server">
                                    <fieldset>
                                        <legend><strong>CREAR Y CREAR NOMBRE AL DIRECTORIO</strong></legend>
                                        <table width="100%">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="LabelNomFolder" runat="server" Text="NOMBRE" Font-Bold="true" Style="font-family: Arial"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>

                                                <td>
                                                    <telerik:RadTextBox ID="TextBoxNomFolder" Width="100%" Height="40px" EmptyMessage="Escribe aqui el nombre del directorio" runat="server" Skin="Bootstrap"></telerik:RadTextBox>
                                                    <%--                                                <asp:TextBox ID="TextBoxNomFolder" runat="server" Width="100%" Height="40px"></asp:TextBox>--%>

                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <%--                                            <asp:Button ID="ButtonSaveFolder" runat="server" OnClick="Button1_Click1" Text="Guardar" Width="80px" />--%>


                                                    <telerik:RadButton SingleClick="true" SingleClickText="Guardando..." ID="ButtonSaveFolder" runat="server" Width="100%" Height="50px" Text="Guardar" OnClick="Button1_Click1" Style="top: 0px" Skin="Bootstrap">
                                                        <Icon PrimaryIconCssClass="rbSave"></Icon>
                                                    </telerik:RadButton>

                                                </td>
                                            </tr>
                                        </table>
                                    </fieldset>
                                </telerik:RadAjaxPanel>


                            </ContentTemplate>

                        </asp:UpdatePanel>

                    </telerik:RadSlidingPane>







                    <telerik:RadSlidingPane ID="Radslidingpane5" Title="Libreta de Direcciones" runat="server" Width="500px" IconUrl="~/IMG/CONTACT.png">
                        <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                            <ContentTemplate>
                                <telerik:RadAjaxPanel ID="RadAjaxPanel41" EnableAJAX="true" runat="server">
                                    <fieldset>
                                        <legend><strong>NUEVO CONTACTO </strong></legend>
                                        <table width="100%">
                                            <tr>
                                                <td>
                                                    <asp:Label runat="server" ID="Label8" Text="Tipo Contacto" Font-Bold="true"></asp:Label>

                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <telerik:RadComboBox ID="RadComboBoxTipoContactoFortamun" Width="100%" runat="server" Culture="es-ES" Skin="Bootstrap"></telerik:RadComboBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label runat="server" ID="LblContacto" Text="NOMBRE COMPLETO" Font-Bold="true"></asp:Label>

                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <telerik:RadTextBox ID="RadTextBoxNombreContacto" Width="100%" Height="40px" EmptyMessage="Escribe aquí el nombre completo del contacto" runat="server" Skin="Bootstrap"></telerik:RadTextBox></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label runat="server" ID="Label5" Text="E-mail" Font-Bold="true"></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <telerik:RadTextBox ID="RadTextBoxEmailContacto" Width="100%" Height="40px" EmptyMessage="Escribe aqui el Correo electronico" runat="server" Skin="Bootstrap"></telerik:RadTextBox></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label runat="server" ID="Label6" Text="Movil" Font-Bold="true"></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <telerik:RadTextBox ID="RadTextBoxMovilContacto" Width="100%" Height="40px" EmptyMessage="Escribe aqui el Tel. movil del contacto" runat="server" Skin="Bootstrap"></telerik:RadTextBox></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label runat="server" ID="Label7" Text="Otro Tel" Font-Bold="true"></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <telerik:RadTextBox ID="RadTextBoxOtroTel" Width="100%" Height="40px" EmptyMessage="Escribe aqui otro telefono del contacto" runat="server" Skin="Bootstrap"></telerik:RadTextBox></td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: right">
                                                    <telerik:RadButton ID="RadButtonSaveContacto" runat="server" Width="100%" Text="Guardar" Skin="Bootstrap" OnClick="RadButtonSaveContacto_Click" Style="top: 13px; left: 1px"></telerik:RadButton>
                                                </td>
                                            </tr>

                                        </table>
                                        <br />
                                        <hr />

                                        <telerik:RadGrid ID="RadGridContactos" runat="server" AutoGenerateColumns="False" OnNeedDataSource="RadGrid1_NeedDataSourContactos"
                                            AllowMultiRowSelection="false" AllowPaging="True" ShowStatusBar="True"
                                            Style="margin-bottom: 0px" Width="100%"
                                            Culture="es-ES" AllowSorting="True" Skin="Bootstrap">
                                            <ClientSettings AllowDragToGroup="false" Selecting-AllowRowSelect="true">
                                                <Selecting CellSelectionMode="SingleCell" />
                                            </ClientSettings>
                                            <GroupingSettings CollapseAllTooltip="Collapse all groups" />
                                            <ExportSettings>
                                                <Pdf PageWidth="2.5in" PageHeight="5in" PageTopMargin="" PageBottomMargin="" PageLeftMargin=""
                                                    PageRightMargin="" PageHeaderMargin="" PageFooterMargin="">
                                                </Pdf>
                                            </ExportSettings>
                                            <MasterTableView Width="100%" ShowHeadersWhenNoRecords="true" DataKeyNames="Id">
                                                <PagerTemplate>
                                                    <table border="0" cellpadding="0" cellspacing="0" style="height: 20px" width="70%">
                                                        <tr>
                                                            <td style="padding-left: 10px;">
                                                                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Grid/Img/first.png"
                                                                    CommandName="Page" CommandArgument="First" CausesValidation="false" Style="vertical-align: middle;" />
                                                                <asp:LinkButton ID="LinkButton1" CommandName="Page" CausesValidation="false" CommandArgument="First"
                                                                    runat="server">Primera</asp:LinkButton>
                                                            </td>
                                                            <td>
                                                                <asp:ImageButton ID="Image1" runat="server" CausesValidation="false" CommandArgument="Prev" CommandName="Page" ImageUrl="~/img/Grid/Img/arrow.png" Style="vertical-align: middle;" />
                                                                <asp:LinkButton ID="LinkButton5" runat="server" CausesValidation="false" CommandArgument="Prev" CommandName="Page">Anterior</asp:LinkButton>
                                                            </td>
                                                            <td>Pagina Actual:
             <asp:TextBox ID="tbPageNumber" runat="server" Columns="3" Text='<%# (int)DataBinder.Eval(Container, "OwnerTableView.CurrentPageIndex") + 1 %>' />
                                                                <asp:RangeValidator ID="RangeValidator1" runat="Server" ControlToValidate="tbPageNumber" Display="Dynamic" EnableClientScript="true" ErrorMessage='<%# "Elija un rango de 1 - " + DataBinder.Eval(Container, "Paging.PageCount") %>' MaximumValue='<%# DataBinder.Eval(Container, "Paging.PageCount") %>' MinimumValue="1" Type="Integer"></asp:RangeValidator>
                                                                <asp:LinkButton ID="LinkButton4" runat="server" CommandName="CustomChangePage">Ir</asp:LinkButton>
                                                                Total de pag.
             <asp:Label ID="maxPage" runat="server" Text='<%# DataBinder.Eval(Container,"Paging.PageCount") %>'></asp:Label>
                                                            </td>
                                                            <td>
                                                                <asp:LinkButton ID="LinkButton3" CommandName="Page" CausesValidation="false" CommandArgument="Next"
                                                                    runat="server">Siguiente</asp:LinkButton>
                                                                <asp:ImageButton ID="Image2" runat="server" ImageUrl="~/img/Grid/Img/arrowRight.png"
                                                                    CommandName="Page" CommandArgument="Next" CausesValidation="false" Style="vertical-align: middle;" />
                                                            </td>
                                                            <td>
                                                                <asp:LinkButton ID="LinkButton2" CommandName="Page" CausesValidation="false" CommandArgument="Last"
                                                                    runat="server">Ultima</asp:LinkButton>
                                                                <asp:ImageButton ID="Image3" runat="server" ImageUrl="~/img/Grid/Img/last.png" CommandName="Page"
                                                                    CommandArgument="Last" CausesValidation="false" Style="vertical-align: middle;" />
                                                            </td>
                                                            <td align="center" style="padding-right: 10px;"></td>
                                                        </tr>
                                                    </table>
                                                </PagerTemplate>
                                                <Columns>

                                                    <telerik:GridClientSelectColumn>
                                                        <HeaderStyle Width="5%" />
                                                    </telerik:GridClientSelectColumn>

                                                    <%--                                                     <telerik:GridBoundColumn HeaderText="pag" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
             UniqueName="pag" DataField="pag" SortExpression="pag">
             <HeaderStyle Width="20%" />
         </telerik:GridBoundColumn>--%>

                                                    <telerik:GridBoundColumn HeaderText="NOMBRE" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                                        UniqueName="NombreUser" DataField="Nombre" SortExpression="NombreUser">
                                                        <HeaderStyle Width="20%" />
                                                    </telerik:GridBoundColumn>

                                                    <telerik:GridBoundColumn HeaderText="TIPO USUARIO" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                                        UniqueName="TIPOCONTACTO" DataField="TIPOCONTACTO" SortExpression="TIPOCONTACTO">
                                                        <HeaderStyle Width="20%" />
                                                    </telerik:GridBoundColumn>
                                                </Columns>
                                            </MasterTableView>
                                        </telerik:RadGrid>
                                        <br>
                                        <telerik:RadButton ID="RadButtonQuitar" runat="server" Width="100%"  Text="QUITAR" Skin="Bootstrap" OnClick="RadButtonQuitar_Click"></telerik:RadButton>

                                        <hr />







                                    </fieldset>
                                </telerik:RadAjaxPanel>
                            </ContentTemplate>
                        </asp:UpdatePanel>

                    </telerik:RadSlidingPane>



                    <telerik:RadSlidingPane ID="Radslidingpane2" Title="Correspondencia" runat="server" Width="500px"
                        MinWidth="130" IconUrl="~/IMG/excel.png" Visible="true">
                        <telerik:RadFormDecorator RenderMode="Lightweight" ID="RadFormDecorator1" runat="server" DecoratedControls="Fieldset" EnableRoundedCorners="false" />
                        <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                            <ContentTemplate>

                                <%--                                <telerik:RadAjaxPanel ID="RadAjaxPanel2" LoadingPanelID="RadAjaxLoadingPanel3" EnableAJAX="true" runat="server">
                                --%>
                                <fieldset style="font-family: Arial">
                                    <legend>
                                        <asp:RadioButtonList Font-Bold="true" ID="RadioButtonListTipoCorrespondencia" runat="server" RepeatDirection="Horizontal">
                                            <asp:ListItem Value="3">CORRESPONDENCIA</asp:ListItem>
                                            
                                        </asp:RadioButtonList>

                                    </legend>
                                    <table width="100%">

                                        <tr>
                                            <td>
                                                <asp:Label ID="Label12" Font-Bold="true" Visible="false" runat="server" Text="ASIGNAR A:"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <telerik:RadAutoCompleteBox OnLoad="RadAutoCompleteUsuarioas_Load" MinFilterLength="5" MaxResultCount="6"
                                                    EmptyMessage="PARA" AllowCustomEntry="true" InputType="Token" Width="450px"
                                                    AutoPostBack="true" RenderMode="Lightweight" ID="RadAutoCompleteBoxUsuarios" runat="server" Skin="Bootstrap">
                                                </telerik:RadAutoCompleteBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>

                                                <asp:Label ID="Label14" Font-Bold="true" runat="server" Text="REMITENTE:"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <telerik:RadAutoCompleteBox OnLoad="RadAutoCompleteOrigen_Load"
                                                    EmptyMessage="REMITENTE" AllowCustomEntry="true" InputType="Token" Width="450px"
                                                    AutoPostBack="true" RenderMode="Lightweight" ID="RadAutoCompleteBoxOrigen" runat="server" Skin="Bootstrap">
                                                </telerik:RadAutoCompleteBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label4" Font-Bold="true" runat="server" Text="AREA DIRIGIDA A:"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <telerik:RadAutoCompleteBox OnLoad="RadAutoCompleteDestino_Load"
                                                    EmptyMessage="DIRIGIDO A..." AllowCustomEntry="true" InputType="Token" Width="450px"
                                                    AutoPostBack="true" RenderMode="Lightweight" ID="RadAutoCompleteBoxDestino" runat="server" Skin="Bootstrap">
                                                </telerik:RadAutoCompleteBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label17" Font-Bold="true" runat="server" Text="FOLIO:"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <telerik:RadTextBox ID="RadTextBoxCorresondenciaFolio" runat="server" EmptyMessage="Folio" Skin="Bootstrap"></telerik:RadTextBox>
                                                <%--                                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>--%>
                                                <telerik:RadNumericTextBox EmptyMessage="No. Paginas" ID="RadNumericTextBoxCantidad" runat="server" Skin="Bootstrap"></telerik:RadNumericTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label13" Font-Bold="true" runat="server" Text="ASUNTO y OBSERVACIONES:"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:TextBox ID="TextBoxAsunto" Width="430px" runat="server" Height="120PX" TextMode="MultiLine"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td></td>
                                        </tr>
                                        <tr>
                                            <td style="text-align: right">
                                                <asp:Label ID="Label18" Font-Bold="true" runat="server" Text="SE RECIBE:"></asp:Label>
                                                <telerik:RadDatePicker ID="TextBoxCorrespondenciaFecha" runat="server" Enabled="true" Skin="Bootstrap">
                                                    <Calendar runat="server" Culture="es-ES" EnableWeekends="True" FastNavigationNextText="&amp;lt;&amp;lt;" UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" Skin="Bootstrap">
                                                    </Calendar>
                                                    <DateInput runat="server" DateFormat="dd/MM/yyyy" DisplayDateFormat="dd/MM/yyyy" LabelWidth="40%">
                                                        <EmptyMessageStyle Resize="None" />
                                                        <ReadOnlyStyle Resize="None" />
                                                        <FocusedStyle Resize="None" />
                                                        <DisabledStyle Resize="None" />
                                                        <InvalidStyle Resize="None" />
                                                        <HoveredStyle Resize="None" />
                                                        <EnabledStyle Resize="None" />
                                                    </DateInput>
                                                    <DatePopupButton HoverImageUrl="" ImageUrl="" />
                                                </telerik:RadDatePicker>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right">

                                                <%--                                                <telerik:RadDatePicker ID="TextBoxCorrespondenciaFecha" runat="server"   Enabled="true">
                                                    <Calendar Culture="es-ES" EnableWeekends="True" FastNavigationNextText="&amp;lt;&amp;lt;"   UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False">
                                                    </Calendar>
                                                    <DateInput DateFormat="dd/MM/yyyy" DisplayDateFormat="dd/MM/yyyy" LabelWidth="40%">
                                                        <EmptyMessageStyle Resize="None" />
                                                        <ReadOnlyStyle Resize="None" />
                                                        <FocusedStyle Resize="None" />
                                                        <DisabledStyle Resize="None" />
                                                        <InvalidStyle Resize="None" />
                                                        <HoveredStyle Resize="None" />
                                                        <EnabledStyle Resize="None" />
                                                    </DateInput>
                                                    <DatePopupButton HoverImageUrl="" ImageUrl="" />
                                                </telerik:RadDatePicker>--%>
                                                <%--                                        <asp:TextBox ID="TextBoxCorrespondenciaFecha" runat="server" TextMode="Date"></asp:TextBox></td>--%>
                                        </tr>
                                        <tr>
                                            <td>

                                                <%--  <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                                            <ContentTemplate>--%>

                                                <telerik:RadButton SingleClick="true" SingleClickText="Guardando..." ID="RadButton1" runat="server" Width="450px" Height="40px" Text="Guardar" OnClick="RadButtonNewCorrespondencia_Click" Style="top: 0px" Skin="Bootstrap">
                                                    <Icon PrimaryIconCssClass="rbSave"></Icon>
                                                </telerik:RadButton>
                                                <%--      </ContentTemplate>
                                        </asp:UpdatePanel>--%>

                                    




                                            </td>
                                        </tr>

                                    </table>






                                </fieldset>
                                <br />





                                <table style="width: 100%">
                                    <tr>
                                        <td>
                                           <%-- <telerik:RadSlider Visible="true" RenderMode="Lightweight" ID="RadSlider2" runat="server" LargeChange="1" SmallChange="1" IsSelectionRangeEnabled="true"
                                                Value="0" MinimumValue="1" MaximumValue="12" Width="450PX" Height="60" ItemType="Tick" AutoPostBack="true" SelectionStart="1" SelectionEnd="2"
                                                TrackPosition="TopLeft" OnValueChanged="RadSlider2_ValueChanged" Skin="Bootstrap">
                                            </telerik:RadSlider>--%>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
<%--                                            <telerik:RadComboBox ID="RadComboBoxGrafic" Width="60px" AutoPostBack="true" runat="server" OnSelectedIndexChanged="RadComboBoxGrafic_SelectedIndexChanged" Visible="true" Skin="Bootstrap"></telerik:RadComboBox>--%>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <%-- <asp:Chart ID="Chart1" runat="server">
                                                <Series>
                                                    <asp:Series Name="Series1"></asp:Series>
                                                </Series>
                                                <ChartAreas>
                                                    <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                                                </ChartAreas>
                                            </asp:Chart>--%>
                                            <%--    <asp:Chart ID="Chart2" runat="server" Width="350px" Height="400px">
                                                <Series>
                                                    <asp:Series ToolTip="Asignados" Name="Series1" ChartArea="ChartArea1" Color="" LabelForeColor="#cc3300" CustomProperties="PointWidth=.9">
                                                    </asp:Series>
                                                    <asp:Series ToolTip="Contestados" Name="Series3" ChartArea="ChartArea1" Color="#009900" CustomProperties="PointWidth=.9"></asp:Series>
                                                    <asp:Series ToolTip="Atendiendo" Name="Series2" ChartArea="ChartArea1" CustomProperties="PointWidth=.9"></asp:Series>
                                                    <asp:Series ToolTip="En Espera a ser atendidos" Name="Series4" ChartArea="ChartArea1" CustomProperties="PointWidth=.9"></asp:Series>
                                                </Series>
                                                <ChartAreas>
                                                    <asp:ChartArea Name="ChartArea1">
                                                    </asp:ChartArea>
                                                </ChartAreas>
                                         
                                                <Titles>
                                                    <asp:Title Font="Arial, 12pt, style=Bold, Italic" Visible="false" Name="Title1"
                                                        Text="Estadisticas de correspondencia">
                                                    </asp:Title>
                                                </Titles>
                                            </asp:Chart>--%>

                                        </td>
                                    </tr>
                                    <tr>
                                        <td>

                                      <%--      <telerik:RadGrid OnSelectedCellChanged="RadGridGRafic_SelectedCellChanged1" ID="RadGridGRafic" runat="server" AutoGenerateColumns="False" OnNeedDataSource="RadGrid1_NeedDataSourGrafic"
                                                AllowMultiRowSelection="True" AllowPaging="True" ShowStatusBar="True"
                                                Style="margin-bottom: 0px" Width="350px"
                                                Culture="es-ES" AllowSorting="True" Skin="Bootstrap">
                                                <ClientSettings AllowDragToGroup="false" EnablePostBackOnRowClick="true" Selecting-AllowRowSelect="true">
                                                    <Selecting CellSelectionMode="SingleCell" />
                                                </ClientSettings>
                                                <GroupingSettings CollapseAllTooltip="Collapse all groups" />
                                                <ExportSettings>
                                                    <Pdf PageWidth="2.5in" PageHeight="5in" PageTopMargin="" PageBottomMargin="" PageLeftMargin=""
                                                        PageRightMargin="" PageHeaderMargin="" PageFooterMargin="">
                                                    </Pdf>
                                                </ExportSettings>
                                                <MasterTableView Width="100%" ShowHeadersWhenNoRecords="true" DataKeyNames="IdUser">
                                                    <PagerTemplate>
                                                        <table border="0" cellpadding="0" cellspacing="0" style="height: 20px" width="70%">
                                                            <tr>
                                                                <td style="padding-left: 10px;">
                                                                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Grid/Img/first.png"
                                                                        CommandName="Page" CommandArgument="First" CausesValidation="false" Style="vertical-align: middle;" />
                                                                    <asp:LinkButton ID="LinkButton1" CommandName="Page" CausesValidation="false" CommandArgument="First"
                                                                        runat="server">Primera</asp:LinkButton>
                                                                </td>
                                                                <td>
                                                                    <asp:ImageButton ID="Image1" runat="server" CausesValidation="false" CommandArgument="Prev" CommandName="Page" ImageUrl="~/img/Grid/Img/arrow.png" Style="vertical-align: middle;" />
                                                                    <asp:LinkButton ID="LinkButton5" runat="server" CausesValidation="false" CommandArgument="Prev" CommandName="Page">Anterior</asp:LinkButton>
                                                                </td>
                                                                <td>Pagina Actual:
                                                        <asp:TextBox ID="tbPageNumber" runat="server" Columns="3" Text='<%# (int)DataBinder.Eval(Container, "OwnerTableView.CurrentPageIndex") + 1 %>' />
                                                                    <asp:RangeValidator ID="RangeValidator1" runat="Server" ControlToValidate="tbPageNumber" Display="Dynamic" EnableClientScript="true" ErrorMessage='<%# "Elija un rango de 1 - " + DataBinder.Eval(Container, "Paging.PageCount") %>' MaximumValue='<%# DataBinder.Eval(Container, "Paging.PageCount") %>' MinimumValue="1" Type="Integer"></asp:RangeValidator>
                                                                    <asp:LinkButton ID="LinkButton4" runat="server" CommandName="CustomChangePage">Ir</asp:LinkButton>
                                                                    Total de pag.
                                                        <asp:Label ID="maxPage" runat="server" Text='<%# DataBinder.Eval(Container,"Paging.PageCount") %>'></asp:Label>
                                                                </td>
                                                                <td>
                                                                    <asp:LinkButton ID="LinkButton3" CommandName="Page" CausesValidation="false" CommandArgument="Next"
                                                                        runat="server">Siguiente</asp:LinkButton>
                                                                    <asp:ImageButton ID="Image2" runat="server" ImageUrl="~/img/Grid/Img/arrowRight.png"
                                                                        CommandName="Page" CommandArgument="Next" CausesValidation="false" Style="vertical-align: middle;" />
                                                                </td>
                                                                <td>
                                                                    <asp:LinkButton ID="LinkButton2" CommandName="Page" CausesValidation="false" CommandArgument="Last"
                                                                        runat="server">Ultima</asp:LinkButton>
                                                                    <asp:ImageButton ID="Image3" runat="server" ImageUrl="~/img/Grid/Img/last.png" CommandName="Page"
                                                                        CommandArgument="Last" CausesValidation="false" Style="vertical-align: middle;" />
                                                                </td>
                                                                <td align="center" style="padding-right: 10px;"></td>
                                                            </tr>
                                                        </table>
                                                    </PagerTemplate>
                                                    <Columns>



                                                

                                                        <telerik:GridBoundColumn HeaderText="Nombre" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                                            UniqueName="NombreUser" DataField="NombreUser" SortExpression="NombreUser">
                                                            <HeaderStyle Width="20%" />
                                                        </telerik:GridBoundColumn>

                                                        <telerik:GridBoundColumn HeaderText="ASIG" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                                            UniqueName="StatusRecibidos" DataField="StatusRecibidos" SortExpression="StatusRecibidos">
                                                            <HeaderStyle Width="20%" />
                                                        </telerik:GridBoundColumn>

                                                        <telerik:GridBoundColumn HeaderText="CONTES" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                                            UniqueName="StatusContestados" DataField="StatusContestados" SortExpression="StatusContestados">
                                                            <HeaderStyle Width="20%" />
                                                        </telerik:GridBoundColumn>

                                                        <telerik:GridBoundColumn HeaderText="ATDO" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                                            UniqueName="StatusRevisados" DataField="StatusRevisados" SortExpression="StatusRevisados">
                                                            <HeaderStyle Width="20%" />
                                                        </telerik:GridBoundColumn>
                                                        <telerik:GridBoundColumn HeaderText="PxR" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                                            UniqueName="StatusPorRevisar" DataField="StatusPorRevisar" SortExpression="StatusPorRevisar">
                                                            <HeaderStyle Width="20%" />
                                                        </telerik:GridBoundColumn>
                                                        <telerik:GridBoundColumn HeaderText="RESULT" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                                            UniqueName="PRODUCTIVIDAD" DataField="PRODUCTIVIDAD" SortExpression="PRODUCTIVIDAD">
                                                            <HeaderStyle Width="20%" />
                                                        </telerik:GridBoundColumn>


                                                    </Columns>
                                                </MasterTableView>
                                            </telerik:RadGrid>--%>

                                        </td>
                                    </tr>
                                </table>
                                <%--                                </telerik:RadAjaxPanel>--%>
                            </ContentTemplate>

                        </asp:UpdatePanel>
                    </telerik:RadSlidingPane>
                </telerik:RadSlidingZone>
            </telerik:RadPane>
            <telerik:RadSplitBar ID="Radsplitbar1" runat="server">
            </telerik:RadSplitBar>
            <telerik:RadPane ID="MiddlePane1" runat="server" Scrolling="None">

                <telerik:RadSplitter RenderMode="Lightweight" ID="Radsplitter2" runat="server" Orientation="Horizontal" VisibleDuringInit="false">
                    <telerik:RadPane ID="Radpane1" runat="server" Height="22px" Scrolling="none" Visible="true">
                        <telerik:RadSlidingZone ClickToOpen="true" ID="Radslidingzone2" Visible="true" runat="server" Height="22px" SlideDirection="Bottom">
                            <telerik:RadSlidingPane ID="Radslidingpane4" Visible="false" Title="Alertas Correspondencia" runat="server" Height="150px">
                                <%--                                <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                                    <ContentTemplate>


                                        <telerik:RadGrid ID="RadGrid3" Visible="true" runat="server" AutoGenerateColumns="False" OnNeedDataSource="RadGrid1_NeedDataSourceCorres"
                                            AllowMultiRowSelection="True" AllowPaging="True" ShowStatusBar="True" PageSize="70"
                                            Style="margin-bottom: 0px"
                                              Culture="es-ES" AllowSorting="True">
                                            <ClientSettings AllowDragToGroup="false" EnablePostBackOnRowClick="false" AllowColumnsReorder="True">
                                                <Selecting AllowRowSelect="true" CellSelectionMode="MultiCell" />
                                            </ClientSettings>
                                            <GroupingSettings CollapseAllTooltip="Collapse all groups" />
                                            <ExportSettings>
                                                <Pdf PageWidth="2.5in" PageHeight="5in" PageTopMargin="" PageBottomMargin="" PageLeftMargin=""
                                                    PageRightMargin="" PageHeaderMargin="" PageFooterMargin="">
                                                </Pdf>
                                            </ExportSettings>
                                            <MasterTableView Width="100%" ShowHeadersWhenNoRecords="true" DataKeyNames="IDRegistro,IDExpedienteOri">
                                                <PagerTemplate>
                                                    <table border="0" cellpadding="0" cellspacing="0" style="height: 20px" width="70%">
                                                        <tr>
                                                            <td style="padding-left: 10px;">
                                                                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Grid/Img/first.png"
                                                                    CommandName="Page" CommandArgument="First" CausesValidation="false" Style="vertical-align: middle;" />
                                                                <asp:LinkButton ID="LinkButton1" CommandName="Page" CausesValidation="false" CommandArgument="First"
                                                                    runat="server">Primera</asp:LinkButton>
                                                            </td>
                                                            <td>
                                                                <asp:ImageButton ID="Image1" runat="server" CausesValidation="false" CommandArgument="Prev" CommandName="Page" ImageUrl="~/img/Grid/Img/arrow.png" Style="vertical-align: middle;" />
                                                                <asp:LinkButton ID="LinkButton5" runat="server" CausesValidation="false" CommandArgument="Prev" CommandName="Page">Anterior</asp:LinkButton>
                                                            </td>
                                                            <td>Pagina Actual:
                                                        <asp:TextBox ID="tbPageNumber" runat="server" Columns="3" Text='<%# (int)DataBinder.Eval(Container, "OwnerTableView.CurrentPageIndex") + 1 %>' />
                                                                <asp:RangeValidator ID="RangeValidator1" runat="Server" ControlToValidate="tbPageNumber" Display="Dynamic" EnableClientScript="true" ErrorMessage='<%# "Elija un rango de 1 - " + DataBinder.Eval(Container, "Paging.PageCount") %>' MaximumValue='<%# DataBinder.Eval(Container, "Paging.PageCount") %>' MinimumValue="1" Type="Integer"></asp:RangeValidator>
                                                                <asp:LinkButton ID="LinkButton4" runat="server" CommandName="CustomChangePage">Ir</asp:LinkButton>
                                                                Total de pag.
                                                        <asp:Label ID="maxPage" runat="server" Text='<%# DataBinder.Eval(Container,"Paging.PageCount") %>'></asp:Label>
                                                            </td>
                                                            <td>
                                                                <asp:LinkButton ID="LinkButton3" CommandName="Page" CausesValidation="false" CommandArgument="Next"
                                                                    runat="server">Siguiente</asp:LinkButton>
                                                                <asp:ImageButton ID="Image2" runat="server" ImageUrl="~/img/Grid/Img/arrowRight.png"
                                                                    CommandName="Page" CommandArgument="Next" CausesValidation="false" Style="vertical-align: middle;" />
                                                            </td>
                                                            <td>
                                                                <asp:LinkButton ID="LinkButton2" CommandName="Page" CausesValidation="false" CommandArgument="Last"
                                                                    runat="server">Ultima</asp:LinkButton>
                                                                <asp:ImageButton ID="Image3" runat="server" ImageUrl="~/img/Grid/Img/last.png" CommandName="Page"
                                                                    CommandArgument="Last" CausesValidation="false" Style="vertical-align: middle;" />
                                                            </td>
                                                            <td align="center" style="padding-right: 10px;"></td>
                                                        </tr>
                                                    </table>
                                                </PagerTemplate>
                                                <Columns>
                                                    <telerik:GridClientSelectColumn>
                                                        <HeaderStyle Width="5%" />
                                                    </telerik:GridClientSelectColumn>


                                                    <telerik:GridTemplateColumn HeaderText="Nombre" HeaderStyle-HorizontalAlign="Center">
                                                        <HeaderStyle Width="250px" />
                                                        <ItemTemplate>
                                                            <table width="30%" style="font-family: Arial">
                                                                <tr>
                                                                    <td rowspan="7">
                                                                        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/IMG/3.png"
                                                                            CommandArgument='<%# String.Format("{0}", Eval("IDRegistro")) %>' />
                                                                        <asp:Label Style="color: #000000;" ID="Label10" runat="server" Text='<%# String.Format("Folio:{0}", Eval("Descripcion")) %>'>></asp:Label>
                                                                </tr>
                                                            </table>
                                                        </ItemTemplate>
                                                    </telerik:GridTemplateColumn>





                                                    <telerik:GridBoundColumn HeaderText="Descripcion" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                                        UniqueName="Expr1" DataField="Expr1" SortExpression="Expr1">
                                                        <HeaderStyle Width="50%" />
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn HeaderText="Responsable" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                                        UniqueName="NombreCompleto" DataField="NombreCompleto" SortExpression="NombreCompleto">
                                                        <HeaderStyle Width="50%" />
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn HeaderText="Fecha" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                                        UniqueName="Fecha" DataField="Fecha" SortExpression="Fecha">
                                                        <HeaderStyle Width="50%" />
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridTemplateColumn HeaderText="Nombre" HeaderStyle-HorizontalAlign="Center">
                                                        <HeaderStyle Width="250px" />
                                                        <ItemTemplate>
                                                            <telerik:RadComboBox ID="RadComboBox2" runat="server" Culture="es-ES" DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="ID" OnSelectedIndexChanged="RadComboBox1_SelectedIndexChangedCambiarDestinatario" AutoPostBack="true"></telerik:RadComboBox>
                                                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion_test %>" SelectCommand="SELECT [Nombre], [status], [ID] FROM [CatUsuarios] WHERE ([status] = @status)">
                                                                <SelectParameters>
                                                                    <asp:Parameter DefaultValue="true" Name="status" Type="Boolean" />
                                                                </SelectParameters>
                                                            </asp:SqlDataSource>
                                                            <%--                                                        <telerik:RadComboBox ID="RadComboBox1" runat="server" OnSelectedIndexChanged="RadComboBox1_SelectedIndexChangedCambiarDestinatario" ></telerik:RadComboBox>--%>
                                <%-- </ItemTemplate>
                                                    </telerik:GridTemplateColumn>
                                                </Columns>
                                            </MasterTableView>
                                        </telerik:RadGrid>
                                        <telerik:RadButton SingleClick="true" Font-Names="Arial" Font-Size="Large" SingleClickText="Un Momento Por Favor..." Text="Actualizar" ID="RadButton2" runat="server" OnClick="Button3_Click"  >
                                            <Icon PrimaryIconCssClass="rbRefresh"></Icon>
                                        </telerik:RadButton>
                                    </ContentTemplate>
                                </asp:UpdatePanel>--%>
                            </telerik:RadSlidingPane>
                        </telerik:RadSlidingZone>
                    </telerik:RadPane>
                    <telerik:RadPane ID="Radpane2" runat="server">
                        <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                            <ContentTemplate>
                                <telerik:RadAjaxPanel ID="RadAjaxPanel1" LoadingPanelID="RadAjaxLoadingPanel3" EnableAJAX="true" runat="server">
                                    <table style="width: max-content">
                                        <tr>
                                            <td class="auto-style1">
                                                <asp:Label ID="Label16" runat="server" Text="Buscar:" Font-Bold="true" Style="font-family: Arial"></asp:Label>
                                            </td>
                                            <td class="auto-style1">
                                                <telerik:RadTextBox ID="TextBoxBusca" EmptyMessage="Escribe aqui tu expresion de busqueda" Width="450px" Height="50PX" runat="server" Skin="Bootstrap">
                                                </telerik:RadTextBox>
                                                <%--                                            <asp:TextBox ID="TextBoxBusca" runat="server" Text="" Width="220px"></asp:TextBox>--%>
                                            </td>
                                            <td class="auto-style1">
                                                <%--                                            <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="ImageButtonBusqueda_Click" />--%>
                                                <telerik:RadButton SingleClick="true" Font-Names="Arial" Font-Size="Large" SingleClickText="Buscando..." Text="Buscar" ID="Button1" runat="server" OnClick="ImageButtonBusqueda_Click" Height="40px" Skin="Bootstrap">
                                                    <Icon PrimaryIconCssClass="rbSearch"></Icon>
                                                </telerik:RadButton>
                                            </td>
                                            <td class="auto-style1">
                                                <telerik:RadButton ID="Button2" SingleClick="true" Height="40px" Font-Names="Arial" Font-Size="Large" Text="Actualizar" SingleClickText="Un Momento Por Favor..." runat="server" OnClick="Button2_Click" Skin="Bootstrap">
                                                    <Icon PrimaryIconCssClass="rbRefresh"></Icon>
                                                </telerik:RadButton>
                                                <br />


                                                <%--                                            <asp:Button ID="Button3" runat="server" Text="Show SlidingPane2" OnClientClick="ShowSlidingPane(); return false;" />--%>

                                                <%--                                            <asp:Button ID="Button2" runat="server" Text="Actualizar" OnClick="Button2_Click" /></td>--%>
                                        </tr>
                                        <tr>
                                            <td colspan="5" style="background-image: url('img/naranja.png'); text-align: left; font-size: larger; font-family: 'Century Gothic'; margin-top: 0; height: 30px; box-shadow: 0 8px 6px -6px black;">

                                                <asp:RadioButtonList ID="RadioButtonListBuscarEn" runat="server" Font-Bold="true" Font-Names="Arial" RepeatDirection="Horizontal">
                                                    <%--<asp:ListItem   Text="EXPEDIENTES" Value="1" Selected="True"  >
                                                    
                                                    </asp:ListItem>--%>
                                                    <asp:ListItem Text="CORRESPONDENCIA" Value="2" Selected="True">
                                                    
                                                    </asp:ListItem>
                                                </asp:RadioButtonList>

                                                <%--         <telerik:RadComboBox ID="RadComboBoxUsuarios" runat="server" AutoPostBack="true"></telerik:RadComboBox>--%>



                                            </td>
                                        </tr>

                                    </table>
                                </telerik:RadAjaxPanel>
                            </ContentTemplate>
                        </asp:UpdatePanel>




                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                <telerik:RadAjaxPanel ID="RadAjaxPanel3" runat="server" LoadingPanelID="RadAjaxLoadingPanel3" EnableAJAX="true">
                                    <telerik:RadGrid ID="RadGrid1" Visible="true" runat="server" AutoGenerateColumns="False" OnNeedDataSource="RadGrid1_NeedDataSource"
                                        AllowMultiRowSelection="True" AllowPaging="True" ShowStatusBar="True" EnableAJAX="True" PageSize="70"
                                        Style="margin-bottom: 0px" OnItemCommand="RadGrid3_ItemCommand"
                                        OnSelectedIndexChanged="RadGrid1_SelectedIndexChanged" Culture="es-ES" AllowSorting="True" Skin="Bootstrap">
                                        <ClientSettings AllowDragToGroup="false" EnablePostBackOnRowClick="false" AllowColumnsReorder="True">
                                            <Selecting AllowRowSelect="true" CellSelectionMode="MultiCell" />
                                        </ClientSettings>
                                        <GroupingSettings CollapseAllTooltip="Collapse all groups" />
                                        <ExportSettings>
                                            <Pdf PageWidth="2.5in" PageHeight="5in" PageTopMargin="" PageBottomMargin="" PageLeftMargin=""
                                                PageRightMargin="" PageHeaderMargin="" PageFooterMargin="">
                                            </Pdf>
                                        </ExportSettings>
                                        <MasterTableView Width="100%" ShowHeadersWhenNoRecords="true" DataKeyNames="ID">
                                            <PagerTemplate>
                                                <table border="0" cellpadding="0" cellspacing="0" style="height: 20px" width="70%">
                                                    <tr align="center">
                                                        <td style="padding-left: 10px;">
                                                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Grid/Img/first.png"
                                                                CommandName="Page" CommandArgument="First" CausesValidation="false" Style="vertical-align: middle;" />
                                                            <asp:LinkButton ID="LinkButton1" CommandName="Page" CausesValidation="false" CommandArgument="First"
                                                                runat="server"></asp:LinkButton>
                                                        </td>
                                                        <td>
                                                            <asp:ImageButton ID="Image1" runat="server" CausesValidation="false" CommandArgument="Prev" CommandName="Page" ImageUrl="~/img/Grid/Img/arrow.png" Style="vertical-align: middle;" />
                                                            <asp:LinkButton ID="LinkButton5" runat="server" CausesValidation="false" CommandArgument="Prev" CommandName="Page"></asp:LinkButton>
                                                        </td>
                                                        <td>Pagina Actual:
                                                        <asp:TextBox ID="tbPageNumber" runat="server" Columns="3" Text='<%# (int)DataBinder.Eval(Container, "OwnerTableView.CurrentPageIndex") + 1 %>' />
                                                            <asp:RangeValidator ID="RangeValidator1" runat="Server" ControlToValidate="tbPageNumber" Display="Dynamic" EnableClientScript="true" ErrorMessage='<%# "Elija un rango de 1 - " + DataBinder.Eval(Container, "Paging.PageCount") %>' MaximumValue='<%# DataBinder.Eval(Container, "Paging.PageCount") %>' MinimumValue="1" Type="Integer"></asp:RangeValidator>
                                                            <asp:LinkButton ID="LinkButton4" runat="server" CommandName="CustomChangePage">Ir</asp:LinkButton>
                                                            Total de pag.
                                                        <asp:Label ID="maxPage" runat="server" Text='<%# DataBinder.Eval(Container,"Paging.PageCount") %>'></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:LinkButton ID="LinkButton3" CommandName="Page" CausesValidation="false" CommandArgument="Next"
                                                                runat="server"></asp:LinkButton>
                                                            <asp:ImageButton ID="Image2" runat="server" ImageUrl="~/img/Grid/Img/arrowRight.png"
                                                                CommandName="Page" CommandArgument="Next" CausesValidation="false" Style="vertical-align: middle;" />
                                                        </td>
                                                        <td>
                                                            <asp:LinkButton ID="LinkButton2" CommandName="Page" CausesValidation="false" CommandArgument="Last"
                                                                runat="server"></asp:LinkButton>
                                                            <asp:ImageButton ID="Image3" runat="server" ImageUrl="~/img/Grid/Img/last.png" CommandName="Page"
                                                                CommandArgument="Last" CausesValidation="false" Style="vertical-align: middle;" />
                                                        </td>
                                                        <td align="center" style="padding-right: 10px;"></td>
                                                    </tr>
                                                </table>
                                            </PagerTemplate>
                                            <Columns>
                                                <telerik:GridClientSelectColumn>
                                                    <HeaderStyle Width="5%" />
                                                </telerik:GridClientSelectColumn>
                                                <telerik:GridTemplateColumn HeaderText="Nombre" HeaderStyle-HorizontalAlign="Center">
                                                    <HeaderStyle Width="250px" Font-Bold="true" />
                                                    <ItemTemplate>
                                                        <table width="100%" style="font-family: Arial">
                                                            <tr>
                                                                <td rowspan="7">
                                                                    <%--<asp:ImageButton ID="ImageButton3" runat="server" ImageUrl='<%# String.Format("~/IMG/{0}.png", Eval("IDTIpoContenido")) %>'
                                                                        CommandArgument='<%# String.Format("{0} {1}", Eval("Id"),Eval("IDTIpoContenido")) %>'
                                                                        ToolTip='<%# String.Format("{0}",ProcessMyDataItemaCTUALIZADO( Eval("ID"), Eval("IDTIpoContenido"))) %>' />--%>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                </telerik:GridTemplateColumn>
                                                <telerik:GridTemplateColumn HeaderText="status">
                                                    <HeaderStyle Width="90px" Font-Bold="true" />
                                                    <ItemTemplate>
                                                        <%--                                                        <asp:Label ID="Label11" runat="server" Text='<%# ProcessMyDataItemEtapa(Eval("IDEtapa"), Eval("IDTIpoContenido")) %>'></asp:Label>--%>
                                                    </ItemTemplate>
                                                </telerik:GridTemplateColumn>
                                                <telerik:GridTemplateColumn HeaderText="Tipo" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                                                    <HeaderStyle Width="90px" HorizontalAlign="Center" Font-Bold="true" />
                                                    <ItemTemplate>
                                                        <table width="100%" style="font-family: Arial">
                                                            <tr>
                                                                <td rowspan="7">
                                                                    <%--                                                                    <asp:Label ID="Label15" runat="server" Text='<%# ProcessMyDataItemTipoContenido(Eval("IDTIpoContenido")) %>'></asp:Label>--%>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
                                                </telerik:GridTemplateColumn>
                                                <telerik:GridTemplateColumn ItemStyle-HorizontalAlign="Center" HeaderText="Tamaño" HeaderStyle-HorizontalAlign="Center">
                                                    <HeaderStyle Width="90px" Font-Bold="true" />
                                                    <ItemTemplate>
                                                        <table width="100%" style="font-family: Arial">
                                                            <tr>
                                                                <td rowspan="7">
                                                                    <%--                                                                    <asp:Label ID="LabelTamano" runat="server" Text='<%#ProcessMyDataItemTamano(Eval("ID")) %>' Visible='<%#ProcessMyDataItemVisible(Eval("IDTIpoContenido")) %>'></asp:Label>--%>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
                                                </telerik:GridTemplateColumn>


                                            </Columns>
                                        </MasterTableView>
                                    </telerik:RadGrid>

                                    <%--                                    /**************************************SEGUNDO GRID DE CORRESPONDENCIA**************************************+--%>
                                    <telerik:RadGrid ID="RadGrid2" Visible="true" runat="server" AutoGenerateColumns="False" OnNeedDataSource="RadGrid1_NeedDataSource"
                                        AllowMultiRowSelection="True" AllowPaging="True" ShowStatusBar="True" EnableAJAX="True" PageSize="63"
                                        Style="margin-bottom: 0px" OnItemCommand="RadGrid3_ItemCommandCorrespondencia"
                                        OnSelectedIndexChanged="RadGrid1_SelectedIndexChanged" Culture="es-ES" AllowSorting="True" Skin="Bootstrap">
                                        <ClientSettings AllowDragToGroup="false" EnablePostBackOnRowClick="false" AllowColumnsReorder="True">
                                            <%--  <Virtualization EnableVirtualization="true" InitiallyCachedItemsCount="63"
                                            LoadingPanelID="RadAjaxLoadingPanel3" ItemsPerView="63" />--%>

                                            <Selecting AllowRowSelect="true" CellSelectionMode="MultiCell" />
                                        </ClientSettings>
                                        <GroupingSettings CollapseAllTooltip="Collapse all groups" />
                                        <ExportSettings>
                                            <Pdf PageWidth="2.5in" PageHeight="5in" PageTopMargin="" PageBottomMargin="" PageLeftMargin=""
                                                PageRightMargin="" PageHeaderMargin="" PageFooterMargin="">
                                            </Pdf>
                                        </ExportSettings>
                                        <MasterTableView Width="100%" ShowHeadersWhenNoRecords="true" DataKeyNames="ID">
                                            <PagerTemplate>
                                                <table border="0" cellpadding="0" cellspacing="0" style="height: 20px" width="70%">
                                                    <tr>
                                                        <td style="padding-left: 10px;">
                                                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Grid/Img/first.png"
                                                                CommandName="Page" CommandArgument="First" CausesValidation="false" Style="vertical-align: middle;" />
                                                            <asp:LinkButton ID="LinkButton1" CommandName="Page" CausesValidation="false" CommandArgument="First"
                                                                runat="server"></asp:LinkButton>
                                                        </td>
                                                        <td>
                                                            <asp:ImageButton ID="Image1" runat="server" CausesValidation="false" CommandArgument="Prev" CommandName="Page" ImageUrl="~/img/Grid/Img/arrow.png" Style="vertical-align: middle;" />
                                                            <asp:LinkButton ID="LinkButton5" runat="server" CausesValidation="false" CommandArgument="Prev" CommandName="Page"></asp:LinkButton>
                                                        </td>
                                                        <td>Pagina Actual:
                                                        <asp:TextBox ID="tbPageNumber" runat="server" Columns="3" Text='<%# (int)DataBinder.Eval(Container, "OwnerTableView.CurrentPageIndex") + 1 %>' />
                                                            <asp:RangeValidator ID="RangeValidator1" runat="Server" ControlToValidate="tbPageNumber" Display="Dynamic" EnableClientScript="true" ErrorMessage='<%# "Elija un rango de 1 - " + DataBinder.Eval(Container, "Paging.PageCount") %>' MaximumValue='<%# DataBinder.Eval(Container, "Paging.PageCount") %>' MinimumValue="1" Type="Integer"></asp:RangeValidator>
                                                            <asp:LinkButton ID="LinkButton4" runat="server" CommandName="CustomChangePage">Ir</asp:LinkButton>
                                                            Total de pag.
                                                        <asp:Label ID="maxPage" runat="server" Text='<%# DataBinder.Eval(Container,"Paging.PageCount") %>'></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:LinkButton ID="LinkButton3" CommandName="Page" CausesValidation="false" CommandArgument="Next"
                                                                runat="server"></asp:LinkButton>
                                                            <asp:ImageButton ID="Image2" runat="server" ImageUrl="~/img/Grid/Img/arrowRight.png"
                                                                CommandName="Page" CommandArgument="Next" CausesValidation="false" Style="vertical-align: middle;" />
                                                        </td>
                                                        <td>
                                                            <asp:LinkButton ID="LinkButton2" CommandName="Page" CausesValidation="false" CommandArgument="Last"
                                                                runat="server"></asp:LinkButton>
                                                            <asp:ImageButton ID="Image3" runat="server" ImageUrl="~/img/Grid/Img/last.png" CommandName="Page"
                                                                CommandArgument="Last" CausesValidation="false" Style="vertical-align: middle;" />
                                                        </td>
                                                        <td align="center" style="padding-right: 10px;"></td>
                                                    </tr>
                                                </table>
                                            </PagerTemplate>
                                            <Columns>
                                                <telerik:GridClientSelectColumn>
                                                    <HeaderStyle Width="5%" />
                                                </telerik:GridClientSelectColumn>
                                                <%--            <telerik:GridTemplateColumn HeaderStyle-Font-Bold="true" HeaderText="Estatus" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                                    <ItemTemplate>
                                                        <table width="100%" style="font-family: Arial">
                                                            <tr>
                                                                <td rowspan="7">

                                                                    <asp:Image ID="ImageButton4" runat="server" Visible='<%# ProcessMyDataItemVisibleCorrespondencia(Eval("IDTIpoContenido")) %>' ImageUrl='<%# String.Format("~/IMG/statuscorrespondencia/{0}.png", Eval("IDStatusCorrespondencia")) %>' CommandArgument='<%# String.Format("{0} {1}", Eval("Id"),Eval("IDStatusCorrespondencia")) %>' />

                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
                                                </telerik:GridTemplateColumn>--%>


                                                <telerik:GridTemplateColumn HeaderStyle-Font-Bold="true" HeaderText="Nombre" HeaderStyle-HorizontalAlign="Center">
                                                    <HeaderStyle Width="250px" />
                                                    <ItemTemplate>
                                                        <table width="100%" style="font-family: Arial">

                                                            <tr>
                                                                <td rowspan="2">
                                                                    <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl='<%# String.Format("~/IMG/{0}.png", Eval("IDTIpoContenido")) %>'
                                                                        CommandArgument='<%# String.Format("{0} {1}", Eval("Id"), Eval("IDTIpoContenido")) %>' />
                                                                    <%--                                                                    <asp:Label Style="color: #000000; font-size: larger" Font-Bold="true" ID="Label10" ToolTip='<%# String.Format("{0}",ProcessMyDataItemaCTUALIZADOCorrespondencia( Eval("ID"), Eval("IDTIpoContenido"))) %>' CommandArgument='<%# String.Format("{0} {1}", Eval("Id"),Eval("IDTIpoContenido")) %>' runat="server" Text='<%# ProcessMyDataItem(Eval("Descripcion")) %>'></asp:Label>--%>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                </telerik:GridTemplateColumn>






                                                <telerik:GridBoundColumn HeaderText="Causa" HeaderStyle-Font-Bold="true" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                                    UniqueName="causa" DataField="causa" SortExpression="causa">
                                                    <HeaderStyle Width="35%" />
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn HeaderText="Remitente" HeaderStyle-Font-Bold="true" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                                    UniqueName="OrigenCorresp" DataField="OrigenCorresp" SortExpression="OrigenCorresp">
                                                    <HeaderStyle Width="25%" />
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn HeaderText="Digido a" HeaderStyle-Font-Bold="true" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                                    UniqueName="Destiny" DataField="Destiny" SortExpression="Destiny">
                                                    <HeaderStyle Width="25%" />
                                                </telerik:GridBoundColumn>




                                                <%-- <telerik:GridTemplateColumn HeaderStyle-Font-Bold="true" HeaderText="Destinatario(s)" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                                                    <HeaderStyle Width="25%" HorizontalAlign="Center" />
                                                    <ItemTemplate>
                                                        <table width="100%" style="font-family: Arial">
                                                            <tr>
                                                                <td rowspan="7">
                                                                    <asp:Label ID="Label15" runat="server" Text='<%# ProcessMyDataItemTipoContenidoPara(Eval("IDTIpoContenido"), Eval("ID")) %>'></asp:Label>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
                                                </telerik:GridTemplateColumn>--%>





                                                <telerik:GridBoundColumn HeaderStyle-Font-Bold="true" HeaderText="Fecha" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                                    UniqueName="FechaConoce" DataField="FechaConoce" SortExpression="FechaConoce">
                                                    <HeaderStyle Width="25%" />
                                                </telerik:GridBoundColumn>
                                            </Columns>
                                        </MasterTableView>
                                    </telerik:RadGrid>


                                    <asp:Label ID="TotaldeRegistros" runat="server" Text="" Style="font-family: Arial" Font-Bold="true"></asp:Label>
                                    <telerik:RadWindow ID="RadWindow1" EnableEmbeddedScripts="true" ViewStateMode="Enabled" Behaviors="Default" runat="server" Width="450px" Height="450px" Modal="true"
                                        VisibleStatusbar="true" Animation="FlyIn" Title="" CssClass="ZindeX" VisibleOnPageLoad="True">
                                    </telerik:RadWindow>

                                </telerik:RadAjaxPanel>

                                <%--                             aqui va el ajax panel--%>
                            </ContentTemplate>
                        </asp:UpdatePanel>



                    </telerik:RadPane>
                </telerik:RadSplitter>



            </telerik:RadPane>
            <%-- <telerik:RadSplitBar ID="RadSplitBar2" runat="server">
            </telerik:RadSplitBar>--%>
            <telerik:RadPane ID="EndPane" runat="server" Width="22px" Scrolling="None">
                <telerik:RadSlidingZone ClickToOpen="true" ID="Radslidingzone1" runat="server" Width="22px"
                    SlideDirection="Left" Visible="true">
                    <%--    <telerik:RadSlidingPane ID="Radslidingpane5" Title="Meta Datos" runat="server" Width="450px" Visible="false"
                        MinWidth="450" IconUrl="~/IMG/metadato.png">--%>
                    <%--   <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                          <ContentTemplate>
                              <table runat="server">
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label9" runat="server" Text="Detalle" Visible="false" Style="font-family: Arial"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <telerik:RadListView ID="RadListView1" runat="server" RenderMode="Lightweight"
                                                ItemPlaceholderID="ProductItemContainer" Visible="true">
                                                <LayoutTemplate>
                                                    <fieldset id="ProductItemContainer" runat="server">
                                                    </fieldset>
                                                </LayoutTemplate>
                                                <ItemTemplate>
                                                    <table border="0">
                                                        <tr>
                                                            <td>
                                                                <asp:Label Style="font-family: Arial" ID="Label2" runat="server" Text="Expediente"></asp:Label></td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:TextBox Style="font-family: Arial" ID="TextBox1" TextMode="MultiLine" runat="server" Text='<%#Eval("Descripcion")%>' Enabled="false" Width="400px"></asp:TextBox></td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:Label Style="font-family: Arial" ID="Label3" runat="server" Text="Actor"></asp:Label></td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:TextBox Style="font-family: Arial" ID="TextBox2" runat="server" Text='<%#Eval("Actor")%>' Enabled="false" Width="450px" TextMode="MultiLine" Height="40px"></asp:TextBox></td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:Label Style="font-family: Arial" ID="Label4" runat="server" Text="Abogado del Actor"></asp:Label></td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:TextBox Style="font-family: Arial" ID="TextBox3" runat="server" Text='<%#Eval("AbogadoActor")%>' Enabled="false" Width="450px" TextMode="MultiLine" Height="40px"></asp:TextBox></td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:Label Style="font-family: Arial" ID="Label5" runat="server" Text="Demandado"></asp:Label></td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:TextBox Style="font-family: Arial" ID="TextBox4" runat="server" Text='<%#Eval("Demandado")%>' Enabled="false" Width="450px" Height="40px" TextMode="MultiLine"></asp:TextBox></td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:Label Style="font-family: Arial" ID="Label6" runat="server" Text="Causa"></asp:Label></td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:TextBox Style="font-family: Arial" ID="TextBox5" runat="server" Text='<%#Eval("Causa")%>' Enabled="false" Width="450px" TextMode="MultiLine" Height="50px"></asp:TextBox></td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:Label Style="font-family: Arial" ID="Label7" runat="server" Text="Etapa"></asp:Label></td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:TextBox Style="font-family: Arial" ID="TextBox6" runat="server" Text='<%#Eval("Etapa")%>' Enabled="false" Width="450px" TextMode="MultiLine" Height="50px"></asp:TextBox></td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:Label Style="font-family: Arial" ID="Label8" runat="server" Text="Fecha que se conoce el caso"></asp:Label></td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:TextBox Style="font-family: Arial" ID="TextBox7" runat="server" Text='<%#Eval("Fechaconoce")%>' Enabled="false" Width="450px"></asp:TextBox></td>
                                                        </tr>


                                                    </table>



                                                </ItemTemplate>
                                            </telerik:RadListView>


                                        </td>
                                    </tr>

                                </table>
                            </ContentTemplate>

                        </asp:UpdatePanel>--%>





                    <%--     Pane 1 Content
                    </telerik:RadSlidingPane>--%>

                    <telerik:RadSlidingPane ID="Radslidingpane7" Title="Bitacora" Visible="false" runat="server" Width="450px"
                        MinWidth="450" IconUrl="~/IMG/log.png">


                        <asp:UpdatePanel ID="UpdatePanel31" runat="server">
                            <ContentTemplate>


                                <telerik:RadListBox ID="RadListBoxBitacora" runat="server"></telerik:RadListBox>

                            </ContentTemplate>
                        </asp:UpdatePanel>

                    </telerik:RadSlidingPane>

                    <telerik:RadSlidingPane Visible="false" ID="Radslidingpane6" Title="Nuevo Expediente" runat="server" Width="450px"
                        MinWidth="450" IconUrl="~/IMG/newdocument.png">




                        <fieldset runat="server" id="Detalle">
                            <legend style="font-family: Arial">Nuevo Registro de Expediente</legend>
                            <table border="0" runat="server" id="uploadFields">
                                <tr>
                                    <td>
                                        <asp:Label ID="Label2" runat="server" Text="Expediente" Style="font-family: Arial"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="align-self: end">
                                        <telerik:RadMaskedTextBox ID="TextBoxExpedienteUpload" runat="server"></telerik:RadMaskedTextBox>
                                        <telerik:RadComboBox ID="RadComboBoxTomo" Width="55px" runat="server" ToolTip="TOMO DEL EXPEDIENTE"></telerik:RadComboBox>
                                    </td>
                                </tr>

                                <tr>
                                    <td>
                                        <telerik:RadAutoCompleteBox OnLoad="RadAutoCompleteBoxActor_Load" MinFilterLength="5" MaxResultCount="6"
                                            EmptyMessage="Actor" AllowCustomEntry="true" InputType="Token" Width="450px"
                                            AutoPostBack="true" RenderMode="Lightweight" ID="IDActor" runat="server">
                                        </telerik:RadAutoCompleteBox>
                                    </td>
                                </tr>

                                <tr>
                                    <td>
                                        <telerik:RadAutoCompleteBox OnLoad="RadAutoCompleteBoxAbogado_Load"
                                            EmptyMessage="Abogado" AllowCustomEntry="true" InputType="Token" Width="450px"
                                            AutoPostBack="true" RenderMode="Lightweight" ID="RadAutoCompleteBoxAbogado" runat="server">
                                        </telerik:RadAutoCompleteBox>
                                    </td>
                                </tr>

                                <tr>
                                    <td>
                                        <telerik:RadAutoCompleteBox OnLoad="RadAutoCompleteBoxDemandado_Load"
                                            EmptyMessage="Demandado" AllowCustomEntry="true" InputType="Token" Width="450px"
                                            AutoPostBack="true" RenderMode="Lightweight" ID="RadAutoCompleteBoxDemandado" runat="server">
                                        </telerik:RadAutoCompleteBox>
                                    </td>
                                </tr>

                                <tr>
                                    <td>
                                        <telerik:RadAutoCompleteBox OnLoad="RadAutoCompleteBoxAutoridadCaso_Load"
                                            EmptyMessage="Autoridad que conose  el caso" AllowCustomEntry="true" InputType="Token" Width="450px"
                                            AutoPostBack="true" RenderMode="Lightweight" ID="RadAutoCompleteBoxAutocasos" runat="server">
                                        </telerik:RadAutoCompleteBox>

                                    </td>
                                </tr>

                                <tr>
                                    <td>
                                        <telerik:RadAutoCompleteBox OnLoad="RadAutoCompleteBoxTipoJuicio_Load"
                                            EmptyMessage="Tipo de juicio" AllowCustomEntry="true" InputType="Token" Width="450px"
                                            AutoPostBack="true" RenderMode="Lightweight" ID="RadAutoCompleteBoxTipoJuicio" runat="server">
                                        </telerik:RadAutoCompleteBox>


                                    </td>
                                </tr>

                                <tr>
                                    <td>
                                        <telerik:RadTextBox ID="TextBoxCAusaUpload" EmptyMessage="Causa del caso" runat="server" Text="" Enabled="true" Width="450px" TextMode="MultiLine" Height="100px"></telerik:RadTextBox>

                                    </td>
                                </tr>

                                <tr>
                                    <td>

                                        <telerik:RadTextBox ID="TextBoxEtapa" EmptyMessage="Etapa" runat="server" Text="" Enabled="true" Width="450px" TextMode="MultiLine" Height="100px"></telerik:RadTextBox>
                                    </td>
                                </tr>

                                <tr>
                                    <td>&nbsp;</td>
                                </tr>

                            </table>

                        </fieldset>

                        <table style="width: 100%">
                            <tr>
                                <td>
                                    <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                                        <ContentTemplate>
                                            <telerik:RadButton ID="ButtonUpload" SingleClick="true" SingleClickText="Guardando..." runat="server" Width="150px" OnClick="Button1_Click" Text="Guardar" Skin="Bootstrap">
                                                <Icon PrimaryIconCssClass="rbSave"></Icon>
                                            </telerik:RadButton>
                                            <%--                                            <asp:Button ID="ButtonUpload" runat="server" OnClick="Button1_Click" Text="Guardar" />--%>
                                            <telerik:RadButton ID="ButtonCancelar" SingleClick="true" SingleClickText="Un momento..." runat="server" OnClick="ButtonCancelar_Click" Width="150px" Text="Cancelar" Skin="Bootstrap">
                                                <Icon PrimaryIconCssClass="rbCancel"></Icon>
                                            </telerik:RadButton>

                                            <%--                                            <asp:Button ID="ButtonCancelar" runat="server" Text="Cancelar" OnClick="ButtonCancelar_Click" />--%>
                                        </ContentTemplate>

                                    </asp:UpdatePanel>

                                </td>
                            </tr>
                        </table>
                    </telerik:RadSlidingPane>

                    <%--     <telerik:RadSlidingPane ID="Radslidingpanel8" Title="Correspondencia" runat="server" Width="450px"
                        MinWidth="450" IconUrl="~/IMG/metadato.png">
                    </telerik:RadSlidingPane>--%>
                </telerik:RadSlidingZone>

            </telerik:RadPane>
        </telerik:RadSplitter>

    </form>
</body>
</html>
