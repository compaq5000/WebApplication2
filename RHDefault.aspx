<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RHDefault.aspx.cs" Inherits="WebApplication2.RHDefault" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script type="text/javascript">
        function TrimIt(sender, args) {
            var value = args.get_newValue();
            var trimmed = value.replace(/^\s+|\s+$/g, '');
            args.set_newValue(trimmed);
        }
    </script>
    <style type="text/css">
        .auto-style1 {
            height: 65px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
            <ContentTemplate>
                <table style="width: 100%">
                    <tr style="background-image: url('img/tejido.jpg'); margin-top: 0; height: 30px">
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <telerik:RadToolBar Style="font-family: Arial" RenderMode="Lightweight" ID="RadToolBar1" runat="server" OnButtonClick="RadToolBar1_ButtonClick"
                                EnableRoundedCorners="true" EnableShadows="true" Skin="Bootstrap">
                                <Items>
                                    <telerik:RadToolBarButton ImageUrl="IMG/home.png"
                                        Text="Principal" ToolTip="Ir a Principal" Value="principal">
                                    </telerik:RadToolBarButton>
                                    <telerik:RadToolBarButton ImageUrl="IMG/1.png" Enabled="false"
                                        Text="Nuevo" ToolTip="Nuevo Folder" Value="folder">
                                    </telerik:RadToolBarButton>
                                    <telerik:RadToolBarButton ImageUrl="IMG/back.png" Enabled="false"
                                        Text="atras" ToolTip="Atras" Value="back">
                                    </telerik:RadToolBarButton>
                                    <telerik:RadToolBarButton ImageUrl="IMG/next.png" Enabled="false"
                                        Text="Siguiente" Group="Bold" ToolTip="Bold" Value="3">
                                    </telerik:RadToolBarButton>
                                    <telerik:RadToolBarButton ImageUrl="IMG/cut.png" Enabled="false"
                                        Text="Cortar" Group="Italic" ToolTip="Italic" Value="cut">
                                    </telerik:RadToolBarButton>
                                    <telerik:RadToolBarButton ImageUrl="IMG/copy.png" Value="copy" Enabled="false"
                                        Text="Copiar"
                                        ToolTip="Copiar">
                                    </telerik:RadToolBarButton>
                                    <telerik:RadToolBarButton Text="Pegar" ImageUrl="IMG/paste.png" Value="paste" Enabled="false"
                                        ToolTip="Pegar">
                                        <%-- <Buttons>
                                    <telerik:RadToolBarButton Text="Left" ImageUrl="~/ToolBar/Examples/Appearance/Images/images/left.png"
                                        CheckOnClick="true" Group="Align" ToolTip="Align Left">
                                    </telerik:RadToolBarButton>
                                    <telerik:RadToolBarButton Text="Center" ImageUrl="~/ToolBar/Examples/Appearance/Images/images/center.png"
                                        CheckOnClick="true" Group="Align" ToolTip="Align Center">
                                    </telerik:RadToolBarButton>
                                    <telerik:RadToolBarButton Text="Right" ImageUrl="~/ToolBar/Examples/Appearance/Images/images/right.png"
                                        CheckOnClick="true" Group="Align" ToolTip="Align Right">
                                    </telerik:RadToolBarButton>
                                </Buttons>--%>
                                    </telerik:RadToolBarButton>
                                    <%--    <telerik:RadToolBarSplitButton>
                                <Buttons>
                                    <telerik:RadToolBarButton Text="Red" ImageUrl="~/ToolBar/Examples/Appearance/Images/images/red.png"
                                        CheckOnClick="true" Group="Color" ToolTip="Set Color Red">
                                    </telerik:RadToolBarButton>
                                    <telerik:RadToolBarButton Text="Blue" ImageUrl="~/ToolBar/Examples/Appearance/Images/images/blue.png"
                                        CheckOnClick="true" Group="Color" ToolTip="Set Color Blue">
                                    </telerik:RadToolBarButton>
                                    <telerik:RadToolBarButton Text="Green" ImageUrl="~/ToolBar/Examples/Appearance/Images/images/green.png"
                                        CheckOnClick="true" Group="Color" ToolTip="Set Color Green">
                                    </telerik:RadToolBarButton>
                                </Buttons>
                            </telerik:RadToolBarSplitButton>--%>
                                    <telerik:RadToolBarButton ImageUrl="IMG/adduser.png" Value="newuser" Enabled="true"
                                        Text="Nuevo Usuario" ToolTip="Nuevo usuario" Visible="false">
                                    </telerik:RadToolBarButton>
                                    <telerik:RadToolBarButton ImageUrl="IMG/users.png" Value="Users" Enabled="false"
                                        Text="Seguridad" ToolTip="Configurar Seguridad de acceso para los usuarios">
                                    </telerik:RadToolBarButton>
                                    <telerik:RadToolBarButton ImageUrl="IMG/exit.png" Value="exit"
                                        Text="Cerrar Sesión" ToolTip="Cerrar sesión actual">
                                    </telerik:RadToolBarButton>
                               </Items>
                            </telerik:RadToolBar>
                        </td>
                    </tr>
                    <tr style="background-image: url('img/tejido.jpg'); margin-top: 0; height: 30px">
                        <td></td>
                    </tr>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>




        <telerik:RadSplitter RenderMode="Lightweight" ID="RadSplitter1" ResizeMode="AdjacentPane" Font-Names="Arial" Font-Size="Medium" runat="server" Width="100%" LiveResize="true" Height="900PX" Skin="Bootstrap">

            <telerik:RadPane ID="LeftPane" runat="server" Scrolling="none" Width="22px">
                <telerik:RadSlidingZone ID="SlidingZone1" runat="server" ClickToOpen="true" DockedPaneId="RadSlidingPane1" Width="22px">
                    <telerik:RadSlidingPane Visible="false" ID="RadSlidingPane1" runat="server" Font-Names="Arial" IconUrl="~/IMG/newuser.png" Title="ALTA" Width="500px">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <telerik:RadAjaxPanel ID="RadAjaxPanel21" runat="server" EnableAJAX="true" LoadingPanelID="RadAjaxLoadingPanel3">
                                    <fieldset style="font-family: Arial; font-style: normal">
                                        <legend><strong>NUEVO REGISTRO</strong></legend>
                                        <table style="width: 100%">
                                            <tr>
                                                <td>
                                                    <telerik:RadTextBox ID="RadTextBoxNOMBRE" runat="server" EmptyMessage="NOMBRE(S)" Skin="Bootstrap">
                                                    </telerik:RadTextBox>
                                                </td>
                                                <td>
                                                    <telerik:RadTextBox ID="RadTextBoxPATERNO" runat="server" EmptyMessage="PATERNO" Skin="Bootstrap">
                                                    </telerik:RadTextBox>
                                                </td>
                                                <td>
                                                    <telerik:RadTextBox ID="RadTextBoxMATERNO" runat="server" EmptyMessage="MATERNO" Skin="Bootstrap">
                                                    </telerik:RadTextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label4" runat="server" Font-Bold="true" Text="NOMBRE(S)"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label2" runat="server" Font-Bold="true" Text="PATERNO"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label8" runat="server" Font-Bold="true" Text="MATERNO"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <telerik:RadNumericTextBox ID="RadTextBoxNoEmpledo" runat="server" EmptyMessage="NO. EMPLEADO" Skin="Bootstrap">
                                                    </telerik:RadNumericTextBox>
                                                </td>
                                                <td>
                                                    <telerik:RadComboBox ID="RadComboBoxCATEGORIA" runat="server" EmptyMessage="CATEGORIA" Skin="Bootstrap">
                                                    </telerik:RadComboBox>
                                                </td>
                                                <td>
                                                    <telerik:RadComboBox ID="RadComboBoxADSCRIPCION" runat="server" EmptyMessage="ADSCRIPCION" Skin="Bootstrap">
                                                    </telerik:RadComboBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label5" runat="server" Font-Bold="true" Text="NO. EMPLEADO"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label9" runat="server" Font-Bold="true" Text="CATEGORIA"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label11" runat="server" Font-Bold="true" Text="ADSCRIPCION"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <telerik:RadDatePicker ID="RadDatePickerfECHAiNGRESO" runat="server" DateInput-EmptyMessage="FECHA DE INGRESO" Skin="Bootstrap" Width="100%">
                                                        <Calendar Culture="es-ES" EnableWeekends="True" FastNavigationNextText="&amp;lt;&amp;lt;" Skin="Bootstrap" UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False">
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
                                                    </telerik:RadDatePicker>
                                                </td>
                                                <td>
                                                    <telerik:RadNumericTextBox ID="RadNumericTextBoxSueldo" runat="server" Culture="es-MX" DbValueFactor="1" EmptyMessage="SUELDO TOTAL" LabelWidth="64px" MaxValue="30000" MinValue="1" Skin="Bootstrap" Type="Currency" Width="160px">
                                                        <NegativeStyle Resize="None" />
                                                        <NumberFormat ZeroPattern="$n" />
                                                        <EmptyMessageStyle Resize="None" />
                                                        <ReadOnlyStyle Resize="None" />
                                                        <FocusedStyle Resize="None" />
                                                        <DisabledStyle Resize="None" />
                                                        <InvalidStyle Resize="None" />
                                                        <HoveredStyle Resize="None" />
                                                        <EnabledStyle Resize="None" />
                                                    </telerik:RadNumericTextBox>
                                                </td>
                                                <td>
                                                    <telerik:RadTextBox ID="RadTextBoxRFC" runat="server" EmptyMessage="RFC" Skin="Bootstrap">
                                                    </telerik:RadTextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label7" runat="server" Font-Bold="true" Text="FECHA INGRESO"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label12" runat="server" Font-Bold="true" Text="SUELDO"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label13" runat="server" Font-Bold="true" Text="RFC"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <telerik:RadTextBox ID="RadtextboxCorreo" runat="server" EmptyMessage="CORREO@ELECTRONICO" Skin="Bootstrap">
                                                        <ClientEvents OnValueChanging="TrimIt" />
                                                    </telerik:RadTextBox>
                                                    <asp:RegularExpressionValidator ID="emailValidator" runat="server" ControlToValidate="RadtextboxCorreo" Display="Dynamic" ErrorMessage="Porfavor, escriba un correo valido!" ValidationExpression="^[\w\.\-]+@[a-zA-Z0-9\-]+(\.[a-zA-Z0-9\-]{1,})*(\.[a-zA-Z]{2,3}){1,2}$">
                                                    </asp:RegularExpressionValidator>
                                                    <%--                                                    <asp:RequiredFieldValidator ID="Requiredfieldvalidator1" runat="server" ControlToValidate="RadtextboxCorreo" Display="Dynamic" ErrorMessage="Porfavor, escriba un correo valido!" />--%></td>
                                                <td>
                                                    <telerik:RadMaskedTextBox ID="RadMaskedTextBoxTelCasa" runat="server" EmptyMessage="TEL. CASA" Mask="(###)-#######" Skin="Bootstrap">
                                                    </telerik:RadMaskedTextBox>
                                                </td>
                                                <td>
                                                    <telerik:RadMaskedTextBox ID="RadMaskedTextBoxMovil" runat="server" EmptyMessage="CELULAR" Mask="##########" Skin="Bootstrap">
                                                    </telerik:RadMaskedTextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label18" runat="server" Font-Bold="true" Text="CORREO ELECTRONICO"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label19" runat="server" Font-Bold="true" Text="TEL. CASA"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label20" runat="server" Font-Bold="true" Text="MOVIL"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="3">
                                                    <telerik:RadTextBox ID="RadTextBoxFunciones" runat="server" EmptyMessage="FUNCIONES QUE DESEMPEÑA" Skin="Bootstrap" TextMode="MultiLine" Width="100%">
                                                    </telerik:RadTextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="3">
                                                    <asp:Label ID="Label14" runat="server" Font-Bold="true" Text="FUNCIONES QUE DESEMPEÑA"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <telerik:RadTextBox ID="RadTextBoxCalle" runat="server" EmptyMessage="CALLE" Skin="Bootstrap">
                                                    </telerik:RadTextBox>
                                                </td>
                                                <td>
                                                    <telerik:RadTextBox ID="RadTextBoxNo" runat="server" EmptyMessage="NUMERO" Skin="Bootstrap">
                                                    </telerik:RadTextBox>
                                                </td>
                                                <td>
                                                    <telerik:RadTextBox ID="RadTextBoxColonia" runat="server" EmptyMessage="COLONIA" Skin="Bootstrap">
                                                    </telerik:RadTextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label15" runat="server" Font-Bold="true" Text="CALLE"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label16" runat="server" Font-Bold="true" Text="NUMERO"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label17" runat="server" Font-Bold="true" Text="COLONIA"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    <telerik:RadTextBox ID="RadTextBoxNomContacto" runat="server" EmptyMessage="NOMBRE DE UN CONTACTO" Skin="Bootstrap" Width="100%">
                                                    </telerik:RadTextBox>
                                                </td>
                                                <td>
                                                    <telerik:RadMaskedTextBox ID="RadTextBoxTelContacto" runat="server" EmptyMessage="TELEFONO DEL CONTACTO" Mask="##########" Skin="Bootstrap">
                                                    </telerik:RadMaskedTextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    <asp:Label ID="Label21" runat="server" Font-Bold="true" Text="NOMBRE DE UN CONTACTO"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label22" runat="server" Font-Bold="true" Text="TELEFONO CONTACTO"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="3">
                                                    <telerik:RadButton ID="RadButton1" runat="server" Height="70PX" OnClick="RadButton1_Click" SingleClick="true" SingleClickText="Enviando..." Skin="Bootstrap" Text="GUARDAR" Width="90%">
                                                    </telerik:RadButton>
                                                </td>
                                            </tr>
                                        </table>
                                    </fieldset>
                                </telerik:RadAjaxPanel>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </telerik:RadSlidingPane>
                    <telerik:RadSlidingPane ID="Radslidingpane3" runat="server" IconUrl="~/IMG/vacaciones.png" MinWidth="130" Title="ASIGNACION RECURSOS" Width="500px">
                        <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                            <ContentTemplate>
                                <telerik:RadAjaxPanel ID="RadAjaxPanel1" runat="server" EnableAJAX="true" LoadingPanelID="RadAjaxLoadingPanel3">
                                    <fieldset style="font-family: Arial; font-style: normal">
                                        <legend><strong>FORMATO DE ASIGNACION</strong></legend>
                                        <table>
                                            <tr>
                                                <td colspan="2">
                                                    <telerik:RadComboBox ID="RadComboBoxTipoPermiso" runat="server" Skin="Bootstrap" Width="100%">
                                                    </telerik:RadComboBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label28" runat="server" Font-Bold="true" Text="AÑO:"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <telerik:RadComboBox ID="RadComboBoxPeriodo" runat="server" Skin="Bootstrap" Width="100%">
                                                    </telerik:RadComboBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    <asp:Label ID="Label26" runat="server" Font-Bold="true" Text="TRIMESTRE:"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    <telerik:RadAutoCompleteBox ID="RadAutoCompleteBoxUsuarios" runat="server" AllowCustomEntry="true" AutoPostBack="true" EmptyMessage="NOMBRE" InputType="Token" MaxResultCount="6" MinFilterLength="5" OnLoad="RadAutoCompleteUsuarioas_Load" RenderMode="Lightweight" Skin="Bootstrap" Width="450px">
                                                    </telerik:RadAutoCompleteBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    <asp:Label ID="Label24" runat="server" Font-Bold="true" Text="NOMBRE DEL PERSONAL:"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                           
                                                </td>
                                                <td>
                                              
                                                </td>
                                            </tr>
                                            
                                            <tr>
                                                <td colspan="2">
                                                    <telerik:RadTextBox ID="RadTextBoxObservaciones" runat="server" Height="75px" Width="100%">
                                                    </telerik:RadTextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label29" runat="server" Font-Bold="true" Text="OBSERVACIONES:"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    <telerik:RadButton ID="RadButtonVACACIONES" runat="server" Enabled="true" Height="70PX" OnClick="RadButton1_ClickVACACIONES" SingleClick="true" SingleClickText="Enviando..." Skin="Bootstrap" Text="GUARDAR" Width="90%">
                                                    </telerik:RadButton>
                                                </td>
                                            </tr>
                                        </table>
                                    </fieldset>
                                </telerik:RadAjaxPanel>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </telerik:RadSlidingPane>
                    <telerik:RadSlidingPane ID="Radslidingpane2" runat="server" IconUrl="~/IMG/COMISION.png" MinWidth="130" Title="PERMISOS" Visible="true" Width="500px">
                        <telerik:RadFormDecorator ID="RadFormDecorator1" runat="server" DecoratedControls="Fieldset" EnableRoundedCorners="false" RenderMode="Lightweight" />
                        <table style="width: 100px">
                            <tr>
                                <td>
                                    <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                        <ContentTemplate>
                                            <telerik:RadGrid ID="RadGrid1" runat="server" AllowMultiRowSelection="True" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" Culture="es-ES" EnableAJAX="True" OnItemCommand="RadGrid22_ItemCommand" OnNeedDataSource="RadGrid1Pases_NeedDataSource" PageSize="20" ShowStatusBar="True" Skin="Bootstrap" Style="margin-bottom: 0px" Visible="true">
                                                <ClientSettings AllowColumnsReorder="True" AllowDragToGroup="false" EnablePostBackOnRowClick="false">
                                                    <Selecting AllowRowSelect="true" CellSelectionMode="MultiCell" />
                                                </ClientSettings>
                                                <GroupingSettings CollapseAllTooltip="Collapse all groups" />
                                                <ExportSettings>
                                                    <Pdf PageBottomMargin="" PageFooterMargin="" PageHeaderMargin="" PageHeight="5in" PageLeftMargin="" PageRightMargin="" PageTopMargin="" PageWidth="2.5in">
                                                    </Pdf>
                                                </ExportSettings>
                                                <MasterTableView DataKeyNames="ID" ShowHeadersWhenNoRecords="true" Width="100%">
                                                    <PagerTemplate>
                                                        <table border="0" cellpadding="0" cellspacing="0" style="height: 20px" width="70%">
                                                            <tr>
                                                                <td style="padding-left: 10px;">
                                                                    <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="false" CommandArgument="First" CommandName="Page" ImageUrl="~/img/Grid/Img/first.png" Style="vertical-align: middle;" />
                                                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" CommandArgument="First" CommandName="Page">Primera</asp:LinkButton>
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
                                                                    <asp:Label ID="maxPage" runat="server" Text='<%# DataBinder.Eval(Container,"Paging.PageCount") %>'></asp:Label></td>
                                                                <td>
                                                                    <asp:LinkButton ID="LinkButton3" runat="server" CausesValidation="false" CommandArgument="Next" CommandName="Page">Siguiente</asp:LinkButton><asp:ImageButton ID="Image2" runat="server" CausesValidation="false" CommandArgument="Next" CommandName="Page" ImageUrl="~/img/Grid/Img/arrowRight.png" Style="vertical-align: middle;" />
                                                                </td>
                                                                <td>
                                                                    <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="false" CommandArgument="Last" CommandName="Page">Ultima</asp:LinkButton>
                                                                    <asp:ImageButton ID="Image3" runat="server" CausesValidation="false" CommandArgument="Last" CommandName="Page" ImageUrl="~/img/Grid/Img/last.png" Style="vertical-align: middle;" />
                                                                </td>
                                                                <td align="center" style="padding-right: 10px;"></td>
                                                            </tr>
                                                        </table>
                                                    </PagerTemplate>
                                                    <Columns>
                                                        <telerik:GridClientSelectColumn>
                                                            <HeaderStyle Width="5%" />
                                                        </telerik:GridClientSelectColumn>
                                                        <telerik:GridTemplateColumn HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center" HeaderText="STATUS" ItemStyle-HorizontalAlign="Center">
                                                            <HeaderStyle HorizontalAlign="Center" Width="25%" />
                                                            <ItemTemplate>
                                                                <table style="font-family: Arial" width="100%">
                                                                    <tr>
                                                                        <td>
                                                                            <asp:Image ID="Image4" runat="server" ImageUrl='<%# String.Format("~/img/stados/{0}.png", Eval("AUTORIZADO")) %>' />
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </ItemTemplate>
                                                            <ItemStyle HorizontalAlign="Center" />
                                                        </telerik:GridTemplateColumn>
                                                        <telerik:GridTemplateColumn HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center" HeaderText="DETALLE ">
                                                            <HeaderStyle Width="80%" />
                                                            <ItemTemplate>
                                                                <table style="font-family: Arial" width="100%">
                                                                    <tr>
                                                                        <td colspan="3">
                                                                            <asp:Label ID="Label31" runat="server" Style="background-image: url('img/naranja.png'); text-align: left; font-size: larger; font-family: 'Century Gothic'; margin-top: 0; height: 30px; box-shadow: 0 8px 6px -6px black;" Text='<%# Eval("NOMBRECOMPLETO") %>'></asp:Label>
                                                                        </td>
                                                                    </tr>
                                                                    <tr style="text-align: left">
                                                                        <td rowspan="7" style="width: 60PX">
                                                                            <asp:ImageButton ID="ImageButton4" runat="server" CommandArgument='<%# String.Format("{0},{1}", Eval("ID"), Eval("IDTIPOINSID")) %>' Height="65px" ImageUrl="~/IMG/EXTENSIONES/.PDF.PNG" Width="55px" />
                                                                            <%--                                            <asp:Image ID="Image4" ImageUrl="~/IMG/EXTENSIONES/.PDF.PNG" runat="server" />--%><%--                                                            <asp:HyperLink ID="HyperLink1" Target="_blank" href='<%# String.Format(" files/Correspondencia/{0}{1}", Eval("ID"), Eval("Extencion")) %>' runat="server">'<%# String.Format("{0}{1}", Eval("Nombre"),Eval("Extencion")) %>'</asp:HyperLink>--%>
                                                                            <%--<asp:ImageButton ID="ImageButton3" runat="server" ImageUrl='<%# String.Format("~/IMG/{0}.png", Eval("IDTIpoContenido")) %>'
                                                                CommandArgument='<%# String.Format("{0} {1}", Eval("Id"),Eval("IDTIpoContenido")) %>' />
                                                            <asp:Label Style="color: #000000;" ID="Label10" ToolTip='<%# String.Format("{0}",ProcessMyDataItemaCTUALIZADOCorrespondencia( Eval("ID"), Eval("IDTIpoContenido"))) %>' CommandArgument='<%# String.Format("{0} {1}", Eval("Id"),Eval("IDTIpoContenido")) %>' runat="server" Text='<%# ProcessMyDataItem(Eval("Descripcion")) %>'></asp:Label>--%></td>
                                                                        <td style="text-align: left"><strong>FECHA:</strong>
                                                                            <asp:Label ID="Label10" runat="server" Style="color: #000000;" Text='<%# Eval("FECHA") %>'></asp:Label>- </td>
                                                                        <td style="text-align: center"><strong>DESDE:</strong>
                                                                            <asp:Label ID="Label6" runat="server" Style="color: #000000;" Text='<%# Eval("SALIDA")%>'></asp:Label></td>
                                                                        <%--   <td rowspan="2" style="width: 40PX">
                                            <asp:HyperLink ID="HyperLink1" Target="_blank" href='<%# String.Format(" files/personal/{0}{1}",Eval("ID"), Eval("ID")) %>' runat="server">ABRIR</asp:HyperLink>
                                        </td>--%>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="text-align: left"><strong>ASUNTO:</strong>
                                                                            <asp:Label ID="Label3" runat="server" Style="color: #000000;" Text='<%# Eval("ASUNTO") %>'></asp:Label></td>
                                                                        <td style="text-align: center"><strong>HASTA:
                                                                            <asp:Label ID="Label4" runat="server" Style="color: #000000;" Text='<%# Eval("ENTRADA") %>'></asp:Label></strong></td>
                                                                    </tr>
                                                                </table>
                                                            </ItemTemplate>
                                                        </telerik:GridTemplateColumn>
                                                        <telerik:GridTemplateColumn HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center" HeaderText="">
                                                            <HeaderStyle Width="250px" />
                                                            <ItemTemplate>
                                                                <table style="font-family: Arial" width="100%">
                                                                    <tr>
                                                                        <td rowspan="2" style="text-align: center">
                                                                            <asp:ImageButton ID="ImageButton41" runat="server" CommandArgument='<%# String.Format("{0}?", Eval("ID")) %>' Height="65px" ImageUrl="~/IMG/garbage.png" Width="55px" />
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </ItemTemplate>
                                                        </telerik:GridTemplateColumn>
                                                        <%--               <telerik:GridTemplateColumn HeaderStyle-Font-Bold="true" HeaderText="STATUS" HeaderStyle-HorizontalAlign="Center">
                            <HeaderStyle Width="250px" />
                            <ItemTemplate>
                                <table width="100%" style="font-family: Arial">
                                    <tr>
                                        <td rowspan="2">
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>
                                                        --%><%--    <telerik:GridBoundColumn HeaderText="Descripcion" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                            UniqueName="Descripcion" DataField="Descripcion" SortExpression="Descripcion">
                                            <HeaderStyle Width="50%" />
                                        </telerik:GridBoundColumn>--%><%--    <telerik:GridBoundColumn HeaderStyle-Font-Bold="true" HeaderText="RESPONSABLE" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                            UniqueName="NombreCompleto" DataField="NombreCompleto" SortExpression="NombreCompleto">
                                            <HeaderStyle Width="50%" />
                                        </telerik:GridBoundColumn>--%>
                                                        <%--       <telerik:GridTemplateColumn HeaderText="ABRIR" HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle Width="350px" />
                                            <ItemTemplate>
                                                <table width="100%" style="font-family: Arial">
                                                    <tr>
                                                        <td rowspan="7">
                                                            <asp:HyperLink ID="HyperLink1" Target="_blank" href='<%# String.Format(" files/Correspondencia/{0}{1}", Eval("ID"), Eval("Extencion")) %>' runat="server">ABRIR</asp:HyperLink>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </ItemTemplate>
                                        </telerik:GridTemplateColumn>--%><%--   <telerik:GridBoundColumn HeaderText="Fecha" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                            UniqueName="Fecha" DataField="Fecha" SortExpression="Fecha">
                                            <HeaderStyle Width="50%" />
                                        </telerik:GridBoundColumn>--%>
                                                    </Columns>
                                                </MasterTableView>
                                            </telerik:RadGrid>
                                            <%--     <telerik:RadWindow ID="RadWindow3" EnableEmbeddedScripts="true" ViewStateMode="Enabled" Behaviors="Default" runat="server" Visible="false" Width="450px" Height="450px" Modal="true"
                        VisibleStatusbar="true" Animation="FlyIn" Title="" CssClass="ZindeX" VisibleOnPageLoad="True" Skin="Bootstrap">
                    </telerik:RadWindow>--%>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: right">
                                    <telerik:RadButton ID="RadButton2" runat="server" OnClick="RadButton2_Click" Skin="Bootstrap" Text="Aprobar" Width="150px">
                                    </telerik:RadButton>
                                </td>
                            </tr>
                        </table>
                        <asp:Label ID="Label30" runat="server" Font-Bold="true" Style="font-family: Arial" Text=""></asp:Label>
                        <telerik:RadWindow ID="RadWindow2" runat="server" Animation="FlyIn" Behaviors="Default" CssClass="ZindeX" EnableEmbeddedScripts="true" Height="450px" Modal="true" Skin="Bootstrap" Title="" ViewStateMode="Enabled" VisibleOnPageLoad="True" VisibleStatusbar="true" Width="450px">
                        </telerik:RadWindow>
                    </telerik:RadSlidingPane>
                </telerik:RadSlidingZone>
            </telerik:RadPane>
            <%-- <telerik:RadSplitBar ID="RadSplitBar2" runat="server">
            </telerik:RadSplitBar>--%><telerik:RadSplitBar ID="Radsplitbar1" runat="server">
            </telerik:RadSplitBar>

            <telerik:RadPane ID="MiddlePane1" runat="server" Scrolling="None">
                <telerik:RadSplitter ID="Radsplitter2" runat="server" Orientation="Horizontal" RenderMode="Lightweight" VisibleDuringInit="false">
                    <telerik:RadPane ID="Radpane1" runat="server" Height="22px" Scrolling="none" Visible="true">
                        <telerik:RadSlidingZone ID="Radslidingzone2" runat="server" ClickToOpen="true" Height="22px" SlideDirection="Bottom" Visible="true">
                            <telerik:RadSlidingPane ID="Radslidingpane4" runat="server" Height="150px" Title="Alertas Correspondencia" Visible="false">
                            </telerik:RadSlidingPane>
                        </telerik:RadSlidingZone>
                    </telerik:RadPane>
                    <telerik:RadPane ID="Radpane2" runat="server">
                        <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                            <ContentTemplate>
                                <table>
                                    <tr>
                                        <td class="auto-style1">
                                            <asp:Label ID="Label23" runat="server" Font-Bold="true" Style="font-family: Arial" Text="Buscar:"></asp:Label>
                                        </td>
                                        <td class="auto-style1">
                                            <telerik:RadTextBox ID="TextBoxBusca" runat="server" EmptyMessage="Escribe aqui tu expresion de busqueda" Height="50PX" Skin="Bootstrap" Width="450px">
                                            </telerik:RadTextBox>
                                        </td>
                                        <td class="auto-style1">
                                            <telerik:RadButton ID="Button1" runat="server" Font-Names="Arial" Font-Size="Large" Height="40px" OnClick="ImageButtonBusqueda_Click" SingleClick="true" SingleClickText="Buscando..." Skin="Bootstrap" Text="Buscar">
                                                <Icon PrimaryIconCssClass="rbSearch" />
                                            </telerik:RadButton>
                                        </td>
                                        <td>
                                            <telerik:RadButton ID="Button2" runat="server" Font-Names="Arial" Font-Size="Large" Height="40px" OnClick="Button2_Click" SingleClick="true" SingleClickText="Un Momento Por Favor..." Skin="Bootstrap" Text="Actualizar">
                                                <Icon PrimaryIconCssClass="rbRefresh" />
                                            </telerik:RadButton>
                                        </td>
                                    </tr>
                                </table>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                <telerik:RadAjaxPanel ID="RadAjaxPanel3" runat="server" EnableAJAX="true" LoadingPanelID="RadAjaxLoadingPanel3">
                                    <table>
                                        <tr>
                                            <td class="auto-style1">
                                                <telerik:RadGrid ID="RadGrid2" runat="server" AllowMultiRowSelection="True" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" Culture="es-ES" EnableAJAX="True" OnItemCommand="RadGrid3_ItemCommandCorrespondencia" OnNeedDataSource="RadGrid1_NeedDataSource" PageSize="4" ShowStatusBar="True" Skin="Bootstrap" Style="margin-bottom: 0px" Visible="true">
                                                    <ClientSettings AllowColumnsReorder="True" AllowDragToGroup="false" EnablePostBackOnRowClick="false">
                                                        <Selecting AllowRowSelect="true" CellSelectionMode="MultiCell" />
                                                    </ClientSettings>
                                                    <GroupingSettings CollapseAllTooltip="Collapse all groups" />
                                                    <ExportSettings>
                                                        <Pdf PageBottomMargin="" PageFooterMargin="" PageHeaderMargin="" PageHeight="5in" PageLeftMargin="" PageRightMargin="" PageTopMargin="" PageWidth="2.5in">
                                                        </Pdf>
                                                    </ExportSettings>
                                                    <MasterTableView DataKeyNames="ID" ShowHeadersWhenNoRecords="true" Width="100%">
                                                        <PagerTemplate>
                                                            <table border="0" cellpadding="0" cellspacing="0" style="height: 20px" width="70%">
                                                                <tr>
                                                                    <td style="padding-left: 10px;">
                                                                        <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="false" CommandArgument="First" CommandName="Page" ImageUrl="~/img/Grid/Img/first.png" Style="vertical-align: middle;" />
                                                                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" CommandArgument="First" CommandName="Page">Primera</asp:LinkButton>
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
                                                                        <asp:LinkButton ID="LinkButton3" runat="server" CausesValidation="false" CommandArgument="Next" CommandName="Page">Siguiente</asp:LinkButton>
                                                                        <asp:ImageButton ID="Image2" runat="server" CausesValidation="false" CommandArgument="Next" CommandName="Page" ImageUrl="~/img/Grid/Img/arrowRight.png" Style="vertical-align: middle;" />
                                                                    </td>
                                                                    <td>
                                                                        <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="false" CommandArgument="Last" CommandName="Page">Ultima</asp:LinkButton>
                                                                        <asp:ImageButton ID="Image3" runat="server" CausesValidation="false" CommandArgument="Last" CommandName="Page" ImageUrl="~/img/Grid/Img/last.png" Style="vertical-align: middle;" />
                                                                    </td>
                                                                    <td align="center" style="padding-right: 10px;"></td>
                                                                </tr>
                                                            </table>
                                                        </PagerTemplate>
                                                        <Columns>
                                                            <telerik:GridTemplateColumn HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center" HeaderText="Nombre">
                                                                <HeaderStyle Width="250px" />
                                                                <ItemTemplate>
                                                                    <table style="font-family: Arial" width="100%">
                                                                        <tr>
                                                                            <td rowspan="2">
                                                                                <asp:ImageButton ID="ImageButton3" runat="server" CommandArgument='<%# String.Format("{0}", Eval("Id")) %>' Height="65px" ImageUrl='<%# String.Format("IMG/users/{0}{1}", Eval("Imagen"),Eval("Extension")) %>' Width="55px" />
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </ItemTemplate>
                                                            </telerik:GridTemplateColumn>
                                                            <telerik:GridTemplateColumn HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center" HeaderText="PERSONAL ">
                                                                <HeaderStyle Width="70%" />
                                                                <ItemTemplate>
                                                                    <table border="0" style="font-family: Arial" width="100%">
                                                                        <tr style="text-align: left">
                                                                            <td rowspan="7" style="width: 60PX"><%--                         <asp:Image ID="Image4" Width="55px" Height="65px" ImageUrl='<%# String.Format("IMG/users/{0}{1}", Eval("Imagen"),Eval("Extension")) %>' runat="server" />
                                                                            --%></td>
                                                                            <td colspan="2" style="text-align: left">
                                                                                <asp:Label ID="Label10" runat="server" Font-Bold="true" Style="color: #000000;" Text='<%# Eval("NOMBRE") %>'></asp:Label>
                                                                            </td>
                                                                            <td rowspan="3"></td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td colspan="2" style="text-align: left"><strong>ADSCRIPCION:</strong>
                                                                                <asp:Label ID="Label6" runat="server" Style="color: #000000;" Text='<%# Eval("ADSCRIPCION") %>'></asp:Label>
                                                                                -</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td colspan="2" style="text-align: left"><strong>CATEGORÍA:</strong>
                                                                                <asp:Label ID="Label3" runat="server" Style="color: #000000;" Text='<%# Eval("Categoria") %>'></asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td colspan="2"><strong>ACTIVIDADES:</strong>
                                                                                <asp:Label ID="Label1" runat="server" Style="color: #000000;" Text='<%# Eval("FUNCIONES") %>'></asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </ItemTemplate>
                                                            </telerik:GridTemplateColumn>
                                                            <%--    <telerik:GridBoundColumn HeaderText="Descripcion" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                            UniqueName="Descripcion" DataField="Descripcion" SortExpression="Descripcion">
                                            <HeaderStyle Width="50%" />
                                        </telerik:GridBoundColumn>--%><%--    <telerik:GridBoundColumn HeaderStyle-Font-Bold="true" HeaderText="RESPONSABLE" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                            UniqueName="NombreCompleto" DataField="NombreCompleto" SortExpression="NombreCompleto">
                                            <HeaderStyle Width="50%" />
                                        </telerik:GridBoundColumn>--%>
                                                            <telerik:GridTemplateColumn HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center" HeaderText="STATUS">
                                                                <HeaderStyle Width="250px" />
                                                                <ItemTemplate>
                                                                    <table style="font-family: Arial" width="100%">
                                                                        <tr>
                                                                            <td rowspan="2">
                                                                                <asp:ImageButton ID="ImageButton4" runat="server" CommandArgument='<%# String.Format("{0}", Eval("Id")) %>' Height="65px" ImageUrl='<%# String.Format("IMG/stados/{0}.png", Eval("StatusUser")) %>' Width="55px" />
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </ItemTemplate>
                                                            </telerik:GridTemplateColumn>
                                                            <telerik:GridTemplateColumn HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center" HeaderText="BAJA">
                                                                <HeaderStyle Width="250px" />
                                                                <ItemTemplate>
                                                                    <table style="font-family: Arial" width="100%">
                                                                        <tr>
                                                                            <td rowspan="2">
                                                                                <asp:ImageButton ID="ImageButtonDelete1" runat="server" CommandArgument='<%# String.Format("{0} -", Eval("Id")) %>' Height="65px" ImageUrl="~/IMG/garbage.png" Width="55px" />
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </ItemTemplate>
                                                            </telerik:GridTemplateColumn>
                                                        </Columns>
                                                    </MasterTableView>
                                                </telerik:RadGrid>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td></td>
                                        </tr>
                                    </table>
                                    <asp:Label ID="TotaldeRegistros" runat="server" Font-Bold="true" Style="font-family: Arial" Text=""></asp:Label>
                                    <telerik:RadWindow ID="RadWindow1" runat="server" Animation="FlyIn" Behaviors="Default" CssClass="ZindeX" EnableEmbeddedScripts="true" Height="450px" Modal="true" Skin="Bootstrap" Title="" ViewStateMode="Enabled" Visible="false" VisibleOnPageLoad="True" VisibleStatusbar="true" Width="450px">
                                    </telerik:RadWindow>
                                </telerik:RadAjaxPanel>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </telerik:RadPane>
                </telerik:RadSplitter>
            </telerik:RadPane>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <%-- <telerik:RadSplitBar ID="RadSplitBar2" runat="server">
            </telerik:RadSplitBar>--%>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <telerik:RadPane ID="EndPane" runat="server" Scrolling="None" Width="22px">
                <telerik:RadSlidingZone ID="Radslidingzone1" runat="server" ClickToOpen="true" SlideDirection="Left" Visible="true" Width="22px">
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

                        </asp:UpdatePanel>--%><%--     Pane 1 Content
                    </telerik:RadSlidingPane>--%>
                    <telerik:RadSlidingPane ID="Radslidingpane7" runat="server" IconUrl="~/IMG/log.png" MinWidth="450" Title="Bitacora" Visible="false" Width="450px">
                        <asp:UpdatePanel ID="UpdatePanel31" runat="server">
                        </asp:UpdatePanel>
                    </telerik:RadSlidingPane>
                    <telerik:RadSlidingPane ID="Radslidingpane6" runat="server" IconUrl="~/IMG/newdocument.png" MinWidth="450" Title="Nuevo Expediente" Visible="false" Width="450px">
                    </telerik:RadSlidingPane>
                    <%--     <telerik:RadSlidingPane ID="Radslidingpanel8" Title="Correspondencia" runat="server" Width="450px"
                        MinWidth="450" IconUrl="~/IMG/metadato.png">
                    </telerik:RadSlidingPane>--%>
                </telerik:RadSlidingZone>
            </telerik:RadPane>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </telerik:RadSplitter>
    </form>
</body>
</html>
