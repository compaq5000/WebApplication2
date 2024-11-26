<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileCorrespondencia.aspx.cs" Inherits="WebApplication2.FileCorrespondencia" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title></title>
    <script type="text/javascript" src="javasscript/Funcs.js"></script>
</head>
<body>
    <form id="form1" runat="server">
          <div>
            <telerik:RadScriptManager ID="RadScriptManager1" runat="server"></telerik:RadScriptManager>
            <telerik:RadFormDecorator RenderMode="Lightweight" ID="RadFormDecorator1" runat="server" DecoratedControls="Fieldset" EnableRoundedCorners="false" />
            <fieldset style="font-family: Arial; font-family: Arial; font-size: 20px">
                <legend style="background-image: url('img/naranja.png'); text-align: left;font-size:larger;font-family:Arial; margin-top: 0; height: 30px; box-shadow: 0 8px 6px -6px black;"><strong>FORMATOS PERMITIDOS WORD, EXCEL, PDF E IMAGENES DE FORMATO JPG y PNG </strong></legend>
                <table style="width: 100%; text-align: center">

                    <tr>
                        <td>
                            <fieldset>
                                <legend>
                                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></legend>

                                <table>
                                    <tr>
                                        <td style="height: 20px; text-align: left">
                                            <fieldset>
                                                <legend>DAR CONTESTACIÓN CON:</legend>
                                                <table>
                                                   <%-- <tr>
                                                        <td>
                                                            <asp:Label Style="font-family: Arial; font-size: 20px" ID="Label5" runat="server" Text="ARCHIVO" Font-Bold="true"></asp:Label></td>
                                                    </tr>--%>
                                                     <tr>
                                        <td style="height: 20px; text-align: left">
                                            <asp:DropDownList ID="DropDownListTipoARchivo" runat="server" Width="350px" Height="35px"></asp:DropDownList>
                                            <%--   <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion_test %>" SelectCommand="SELECT [Descripcion], [ID] FROM [CatTipoArchivo__Inventarios] WHERE ([status] = @status)">
                            <SelectParameters>
                                <asp:Parameter DefaultValue="true" Name="status" Type="Boolean" />
                            </SelectParameters>
                        </asp:SqlDataSource>--%>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="height: 20px; text-align: left">
                                            <asp:Label Style="font-family: Arial; font-size: 20px" ID="Label1" runat="server" Text="ARCHIVO" Font-Bold="true"></asp:Label>

                                        </td>
                                    </tr>

                                    <tr>

                                        <td style="text-align: left">
                                            <asp:FileUpload ID="FileUpload1" runat="server" Height="20px" /></td>
                                    </tr>
                                    <tr>
                                        <td style="height: 20px; text-align: left">
                                            <asp:Label Style="font-family: Arial; font-size: 20px" ID="Label2" runat="server" Text="DESCRIPCIÓN" Font-Bold="true"></asp:Label></td>


                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Width="100%" Height="120px"></asp:TextBox></td>
                                    </tr>
                                                    <tr><td>

                                                        <telerik:RadButton Width="350px" Height="50px" SingleClick="true" SingleClickText="Guardando..." Style="clear: both; float: right; margin: 10px 0; top: 0px; left: -1px;"
                                ID="RadButton1" runat="server" Text="Confirmar" OnClick="Button1_Click" Skin="Bootstrap">
                                <Icon PrimaryIconCssClass="rbSave"></Icon>
                            </telerik:RadButton>

                                                        </td></tr>
                                                </table>

                                            </fieldset>



                                        </td>
                                        <td rowspan="6" style="width: 100%; vertical-align:top" >

                                            <fieldset  runat="server">
                                                <legend >GALERIA DIGITAL</legend>
                                                <table style="width: 100%">
                                                    <tr>
                                                        <td>
                                                            <div class="demo-container size-medium">
                                                                <asp:Panel ID="galleriesPanel" runat="server">
                                                                    <telerik:RadImageGallery Skin="Bootstrap" RenderMode="Mobile" Width="350px" runat="server" ID="RadImageGallery2" DisplayAreaMode="Image">
                                                                        <ImageAreaSettings ResizeMode="Fit" Height="250px" ShowDescriptionBox="true" NavigationMode="Button" />
                                                                        <ToolbarSettings EnterFullScreenButtonText="Pantalla Completa" HideThumbnailsButtonText="Ocultar Miniaturas" PlayButtonText="Modo Presentación" />
                                                                        <ThumbnailsAreaSettings Mode="ImageSlider" ThumbnailsSpacing="20px" />
                                                                    </telerik:RadImageGallery>
                                                                </asp:Panel>
                                                            </div>


                                                            <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server" UpdatePanelRenderMode="Block">
                                                                <AjaxSettings>
                                                                    <telerik:AjaxSetting AjaxControlID="ConfiguratorPanel">
                                                                        <UpdatedControls>
                                                                            <telerik:AjaxUpdatedControl ControlID="galleriesPanel" LoadingPanelID="RadAjaxLoadingPanel1" />
                                                                        </UpdatedControls>
                                                                    </telerik:AjaxSetting>
                                                                </AjaxSettings>
                                                            </telerik:RadAjaxManager>
                                                            <telerik:RadAjaxLoadingPanel runat="server" ID="RadAjaxLoadingPanel1">
                                                            </telerik:RadAjaxLoadingPanel>
                                                        </td>
                                                        <td>

                                                            <telerik:RadAsyncUpload MultipleFileSelection="Automatic" Skin="Bootstrap" OnClientFilesUploaded="OnClientFilesUploaded" RenderMode="Lightweight" ID="RadAsyncUpload1" runat="server" OnFileUploaded="RadAsyncUpload1_FileUploaded1" />
                                <br />
                                <br />
                                <br />
                                <telerik:RadButton Width="100%" runat="server" SingleClickText="Enviando..." ID="Button2" Height="40PX" Text="Cargar Imagenes" Skin="Bootstrap" OnClick="Button2_Click"></telerik:RadButton>
                                <br />
                                <br />

                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td></td>
                                                    </tr>
                                                </table>
                                            </fieldset>


                                        </td>
                                    </tr>
                                   
                                </table>
                            </fieldset>
                        </td>
                    </tr>




                    <tr>
                        <td style="height: 20px; text-align: right">

                            <%--<asp:CheckBox  Style="font-family: Arial" Font-Bold="true" ID="CheckBoxRegresaCorresp" runat="server" AutoPostBack="true" Text="No Corresponde a nuestra area." OnCheckedChanged="CheckBoxRegresaCorresp_CheckedChanged" Font-Size="Larger" /></td>--%>


                    </tr>
                    <tr>
                        <td>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <asp:Label ID="LabelRecomendacion" runat="server" Text="" ForeColor="DarkRed"></asp:Label>
                                </ContentTemplate>
                            </asp:UpdatePanel>

                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1;" style="text-align: right">
                            <telerik:RadDatePicker ID="RadDatePicker1" runat="server" Skin="Bootstrap">
                                <Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" EnableWeekends="True" Culture="es-ES" FastNavigationNextText="&amp;lt;&amp;lt;" Skin="Bootstrap"></Calendar>

                                <DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy" LabelWidth="40%">
                                    <EmptyMessageStyle Resize="None"></EmptyMessageStyle>

                                    <ReadOnlyStyle Resize="None"></ReadOnlyStyle>

                                    <FocusedStyle Resize="None"></FocusedStyle>

                                    <DisabledStyle Resize="None"></DisabledStyle>

                                    <InvalidStyle Resize="None"></InvalidStyle>

                                    <HoveredStyle Resize="None"></HoveredStyle>

                                    <EnabledStyle Resize="None"></EnabledStyle>
                                </DateInput>

                                <DatePopupButton ImageUrl="" HoverImageUrl=""></DatePopupButton>
                            </telerik:RadDatePicker>
                        </td>

                    </tr>
                    <tr>
                        <td class="auto-style1">








                            
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <telerik:RadGrid ID="RadGrid2" Visible="true" runat="server" AutoGenerateColumns="False" OnNeedDataSource="RadGrid1_NeedDataSource"
                                AllowMultiRowSelection="True" AllowPaging="True" ShowStatusBar="True" EnableAJAX="True" PageSize="70"
                                Style="margin-bottom: 0px"
                                Culture="es-ES" AllowSorting="True" Skin="Bootstrap">
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

                                        <telerik:GridTemplateColumn HeaderText="DETALLE " HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center">
                                            <HeaderStyle Width="70%" />
                                            <ItemTemplate>
                                                <table width="100%" style="font-family: Arial" >
                                                    <tr style="text-align: left">



                                                        <td rowspan="7" style="width: 60PX">
                                                            <asp:Image ID="Image4" ImageUrl='<%# String.Format("IMG/extensiones/{0}.png", Eval("Extencion")) %>' runat="server" />
                                                            <%--                                                            <asp:HyperLink ID="HyperLink1" Target="_blank" href='<%# String.Format(" files/Correspondencia/{0}{1}", Eval("ID"), Eval("Extencion")) %>' runat="server">'<%# String.Format("{0}{1}", Eval("Nombre"),Eval("Extencion")) %>'</asp:HyperLink>--%>
                                                            <%--<asp:ImageButton ID="ImageButton3" runat="server" ImageUrl='<%# String.Format("~/IMG/{0}.png", Eval("IDTIpoContenido")) %>'
                                                                CommandArgument='<%# String.Format("{0} {1}", Eval("Id"),Eval("IDTIpoContenido")) %>' />
                                                            <asp:Label Style="color: #000000;" ID="Label10" ToolTip='<%# String.Format("{0}",ProcessMyDataItemaCTUALIZADOCorrespondencia( Eval("ID"), Eval("IDTIpoContenido"))) %>' CommandArgument='<%# String.Format("{0} {1}", Eval("Id"),Eval("IDTIpoContenido")) %>' runat="server" Text='<%# ProcessMyDataItem(Eval("Descripcion")) %>'></asp:Label>--%>
                                                        </td>
                                                        <td style="text-align: left; width:50%">
                                                            <strong>TIPO:</strong>
                                                            <asp:Label Style="color: #000000;" ID="Label10" runat="server" Text='<%# Eval("inventario") %>'></asp:Label>

                                                        </td>
                                                        <td style="text-align:left"><strong>DESCRIPCIÓN:</strong>
                                                            <asp:Label Style="color: #000000;" ID="Label6" runat="server" Text='<%# Eval("Descripcion") %>'></asp:Label></td>
                                                        <td rowspan="2" style="width: 40PX">
                                                            
                                                            
                                                            
                                                            <asp:HyperLink ID="HyperLink1"  Target="_blank" Visible='<%#bool.Parse( string.Format("{0}",ProcessMyDataItem( Eval("ID")))) %>' href='<%# String.Format(" files/Correspondencia/{0}{1}", Eval("ID"), Eval("Extencion")) %>' runat="server">ABRIR</asp:HyperLink>

                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="text-align: left">
                                                            <strong>CARGADO:</strong>
                                                            <asp:Label Style="color: #000000;" ID="Label3" runat="server" Text='<%# Eval("FECHA") %>'></asp:Label>


                                                        </td>
                                                        <td style="text-align: left">
                                                            <strong>POR:
                                                            <asp:Label Style="color: #000000;" ID="Label4" runat="server" Text='<%# Eval("NombreCompleto") %>'></asp:Label>
                                                        </strong></td>

                                                    </tr>
                                                </table>
                                            </ItemTemplate>
                                        </telerik:GridTemplateColumn>






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


                        </td>
                    </tr>
                </table>
            </fieldset>



















        </div>
    </form>
</body>
</html>
