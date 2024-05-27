<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SoporteTecnico.aspx.cs" Inherits="WebApplication2.SoporteTecnico" %>

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
        <div>
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


            <table style="width: 100%">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="TIPO DE SERVICIO"></asp:Label></td>
                    <td>
                        <telerik:RadComboBox ID="RadComboBoxServicio" Width="450PX" Runat="server" Skin="Bootstrap">
                        </telerik:RadComboBox>
                    </td>
                </tr> <tr>
                    <td><asp:Label ID="Label2" runat="server" Text="DESCRIPCION DE LA SOLICITUD"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="TextBoxDescripcion" runat="server" Width="500px"  TextMode="MultiLine" Height="150px" ></asp:TextBox>
                    
                    </td>
                </tr> <tr>
                    <td style="text-align:right" colspan="2">
                        <telerik:RadButton ID="RadButton1" Height="50px" Width="120px" runat="server" Text="SOLICITAR" Skin="Bootstrap" OnClick="RadButton1_Click" ></telerik:RadButton>
                    </td>
                   
                </tr> 




                <tr>
                    <td colspan="2">


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
                            <MasterTableView Width="100%" ShowHeadersWhenNoRecords="true" DataKeyNames="IDUser">
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
                                                        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl='<%# String.Format("~/IMG/3.png") %>'
                                                            CommandArgument='<%# String.Format("{0} {1}", Eval("IdUser"), Eval("IdUser")) %>' />
                                                        <%--                                                                    <asp:Label Style="coor: #000000; font-size: larger" Font-Bold="true" ID="Label10" ToolTip='<%# String.Format("{0}",ProcessMyDataItemaCTUALIZADOCorrespondencia( Eval("ID"), Eval("IDTIpoContenido"))) %>' CommandArgument='<%# String.Format("{0} {1}", Eval("Id"),Eval("IDTIpoContenido")) %>' runat="server" Text='<%# ProcessMyDataItem(Eval("Descripcion")) %>'></asp:Label>--%>
                                                    </td>
                                                </tr>
                                            </table>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>

                                    <telerik:GridBoundColumn HeaderText="Descripcion" HeaderStyle-Font-Bold="true" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                        UniqueName="Descripcion" DataField="Descripcion" SortExpression="Descripcion">
                                        <HeaderStyle Width="35%" />
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn HeaderText="NombreCompleto" HeaderStyle-Font-Bold="true" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                        UniqueName="NombreCompleto" DataField="NombreCompleto" SortExpression="NombreCompleto">
                                        <HeaderStyle Width="25%" />
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn HeaderText="FechaAlta" HeaderStyle-Font-Bold="true" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                        UniqueName="FechaAlta" DataField="FechaAlta" SortExpression="FechaAlta">
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



                                        <telerik:GridTemplateColumn HeaderStyle-Font-Bold="true" HeaderText="STATUS" HeaderStyle-HorizontalAlign="Center">
                                        <HeaderStyle Width="250px" />
                                        <ItemTemplate>
                                            <table width="100%" style="font-family: Arial">

                                                <tr>
                                                    <td rowspan="2">
                                                        <asp:Image ID="Image3" runat="server" ImageUrl='<%# String.Format("~/IMG/grid/{0}.png", Eval("status")) %>'
                                                             />
                                                        <%--                                                                    <asp:Label Style="coor: #000000; font-size: larger" Font-Bold="true" ID="Label10" ToolTip='<%# String.Format("{0}",ProcessMyDataItemaCTUALIZADOCorrespondencia( Eval("ID"), Eval("IDTIpoContenido"))) %>' CommandArgument='<%# String.Format("{0} {1}", Eval("Id"),Eval("IDTIpoContenido")) %>' runat="server" Text='<%# ProcessMyDataItem(Eval("Descripcion")) %>'></asp:Label>--%>
                                                    </td>
                                                </tr>
                                            </table>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>

                                 
                                </Columns>
                            </MasterTableView>
                        </telerik:RadGrid>
                            <telerik:RadWindow ID="RadWindow1" runat="server">
                        </telerik:RadWindow>
                    </td>
                </tr>
            </table>
        </div>

    </form>
</body>
</html>
