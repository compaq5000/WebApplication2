<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PermisosyPases.aspx.cs" Inherits="WebApplication2.PermisosyPases" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script type="text/javascript">
        function TrimIt(sender, args) {
            var value = args.get_newValue();
            var trimmed = value.replace(/^\s+|\s+$/g, '');
            args.set_newValue(trimmed);
        }
    </script>
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

        <div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <fieldset>
                        <legend>NUEVO</legend>
                        <table style="width: 100%">
                            <tr>
                                <td>
                                    <asp:Label ID="Label7" runat="server" Text="TIPO:"></asp:Label>
                                </td>
                                <td>
                                    <telerik:RadComboBox ID="RadComboBoxtIPO" runat="server" AutoPostBack="true" OnSelectedIndexChanged="RadComboBoxtIPO_SelectedIndexChanged" Skin="Bootstrap" Width="250px">
                                    </telerik:RadComboBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 350px">
                                    <asp:Label ID="Label2" runat="server" Text="FECHA"></asp:Label>
                                </td>
                                <td>
                                    <telerik:RadDatePicker ID="RadDatePicker1" runat="server" Skin="Bootstrap">
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
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label8" runat="server" Text="JUSTIFICAR" Visible="true"></asp:Label>
                                </td>
                                <td>
                                    <telerik:RadComboBox ID="RadComboBoxJUSTIFI" runat="server" Skin="Bootstrap">
                                    </telerik:RadComboBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: left">
                                    <asp:Label ID="lBL1" runat="server" Text="HORARIO DE SALIDA"></asp:Label>
                                </td>
                                <td>
                                    <telerik:RadTimePicker ID="RadTimePicker1" runat="server" Skin="Bootstrap">
                                    </telerik:RadTimePicker>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text="HORARIO DE ENTRADA"></asp:Label>
                                </td>
                                <td style="text-align: left">
                                    <telerik:RadTimePicker ID="RadTimePicker2" runat="server" Skin="Bootstrap">
                                    </telerik:RadTimePicker>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label5" runat="server" Text="ASUNTO"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBoxAsunto" runat="server" Height="80px" TextMode="MultiLine" Width="370px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" style="text-align: right">
                                    <telerik:RadButton ID="RadButton1" runat="server" Height="50PX" OnClick="RadButton1_Click" Skin="Bootstrap" Text="GUARDAR" Width="150PX">
                                    </telerik:RadButton>
                                </td>
                            </tr>
                        </table>
                    </fieldset>
                </ContentTemplate>
            </asp:UpdatePanel>
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <telerik:RadGrid ID="RadGrid2" runat="server" AllowMultiRowSelection="True" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" Culture="es-ES" EnableAJAX="True" OnItemCommand="RadGrid2_ItemCommand" OnNeedDataSource="RadGrid1_NeedDataSource" PageSize="7" ShowStatusBar="True" Skin="Bootstrap" Style="margin-bottom: 0px" Visible="true">
                        <ClientSettings AllowColumnsReorder="True"  AllowDragToGroup="false" EnablePostBackOnRowClick="false">
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

                                          <telerik:GridTemplateColumn HeaderStyle-Font-Bold="true" HeaderText="STATUS" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                                                    <HeaderStyle Width="25%" HorizontalAlign="Center" />
                                                    <ItemTemplate>
                                                        <table width="100%" style="font-family: Arial">
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
                                    <HeaderStyle Width="70%" />
                                    <ItemTemplate>
                                        <table style="font-family: Arial" width="100%">
                                            <tr style="text-align: left">
                                                <td rowspan="7" style="width: 60PX">
                                                    <asp:ImageButton ID="ImageButton4" runat="server" CommandArgument='<%# String.Format("{0},{1}", Eval("ID"), Eval("IDTIPOINSID")) %>' Height="65px" ImageUrl="~/IMG/EXTENSIONES/.PDF.PNG" Width="55px" />
                                                    <%--                                            <asp:Image ID="Image4" ImageUrl="~/IMG/EXTENSIONES/.PDF.PNG" runat="server" />--%>
                                                    <%--                                                            <asp:HyperLink ID="HyperLink1" Target="_blank" href='<%# String.Format(" files/Correspondencia/{0}{1}", Eval("ID"), Eval("Extencion")) %>' runat="server">'<%# String.Format("{0}{1}", Eval("Nombre"),Eval("Extencion")) %>'</asp:HyperLink>--%>
                                                    <%--<asp:ImageButton ID="ImageButton3" runat="server" ImageUrl='<%# String.Format("~/IMG/{0}.png", Eval("IDTIpoContenido")) %>'
                                                                CommandArgument='<%# String.Format("{0} {1}", Eval("Id"),Eval("IDTIpoContenido")) %>' />
                                                            <asp:Label Style="color: #000000;" ID="Label10" ToolTip='<%# String.Format("{0}",ProcessMyDataItemaCTUALIZADOCorrespondencia( Eval("ID"), Eval("IDTIpoContenido"))) %>' CommandArgument='<%# String.Format("{0} {1}", Eval("Id"),Eval("IDTIpoContenido")) %>' runat="server" Text='<%# ProcessMyDataItem(Eval("Descripcion")) %>'></asp:Label>--%>
                                                </td>
                                                <td style="text-align: left"><strong>FECHA:</strong>
                                                    <asp:Label ID="Label10" runat="server" Style="color: #000000;" Text='<%# Eval("FECHA") %>'></asp:Label>
                                                    - </td>
                                                <td style="text-align: center"><strong>DESDE:</strong>
                                                    <asp:Label ID="Label6" runat="server" Style="color: #000000;" Text='<%# Eval("SALIDA")%>'></asp:Label>
                                                </td>
                                                <%--   <td rowspan="2" style="width: 40PX">
                                            <asp:HyperLink ID="HyperLink1" Target="_blank" href='<%# String.Format(" files/personal/{0}{1}",Eval("ID"), Eval("ID")) %>' runat="server">ABRIR</asp:HyperLink>
                                        </td>--%>
                                            </tr>
                                            <tr>
                                                <td style="text-align: left"><strong>ASUNTO:</strong>
                                                    <asp:Label ID="Label3" runat="server" Style="color: #000000;" Text='<%# Eval("ASUNTO") %>'></asp:Label>
                                                </td>
                                                <td style="text-align: center"><strong>HASTA:
                                                    <asp:Label ID="Label4" runat="server" Style="color: #000000;" Text='<%# Eval("ENTRADA") %>'></asp:Label>
                                                    </strong></td>
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
                                --%>
                                <%--    <telerik:GridBoundColumn HeaderText="Descripcion" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                            UniqueName="Descripcion" DataField="Descripcion" SortExpression="Descripcion">
                                            <HeaderStyle Width="50%" />
                                        </telerik:GridBoundColumn>--%>
                                <%--    <telerik:GridBoundColumn HeaderStyle-Font-Bold="true" HeaderText="RESPONSABLE" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
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
                                        </telerik:GridTemplateColumn>--%>
                                <%--   <telerik:GridBoundColumn HeaderText="Fecha" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                            UniqueName="Fecha" DataField="Fecha" SortExpression="Fecha">
                                            <HeaderStyle Width="50%" />
                                        </telerik:GridBoundColumn>--%>
                            </Columns>
                        </MasterTableView>
                    </telerik:RadGrid>
                    <telerik:RadWindow ID="RadWindow1" runat="server" Animation="FlyIn" Behaviors="Default" CssClass="ZindeX" EnableEmbeddedScripts="true" Height="450px" Modal="true" Skin="Bootstrap" Title="" ViewStateMode="Enabled" VisibleOnPageLoad="True" VisibleStatusbar="true" Width="450px">
                    </telerik:RadWindow>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
            </form>
</body>
</html>
