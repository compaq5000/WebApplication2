<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ActualizarCorrespondencia.aspx.cs" Inherits="WebApplication2.ActualizarCorrespondencia" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <telerik:RadScriptManager ID="RadScriptManager1" runat="server"></telerik:RadScriptManager>
            <telerik:RadFormDecorator RenderMode="Lightweight" ID="RadFormDecorator1" runat="server" DecoratedControls="Fieldset" EnableRoundedCorners="false" />
            <%--    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>--%>
            <%--                              <telerik:RadAjaxPanel ID="RadAjaxPanel4" LoadingPanelID="RadAjaxLoadingPanel3"  EnableAJAX="true" runat="server">--%>

            <fieldset>
                <legend style="background-image: url('img/naranja.png'); text-align: left; font-size: larger; font-family: Arial; margin-top: 0; height: 30px; box-shadow: 0 8px 6px -6px black;">CARGAR ARCHIVO PDF</legend>
                <%--  <table style="width: 100%">
                            <tr>
                                <td>
                                                                        </td>

                                </td>
                            </tr>
                        </table>--%>



                <table style="width: 100%">
                    <tr>
                        <td rowspan="2">
                            <%--                            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>--%>
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/IMG/uploading.png" />
                        </td>
                        <td style="text-align: left">
                            <asp:FileUpload ID="FileUpload1" runat="server" /></td>
                    </tr>
                    <%--  <tr>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text="Label" Font-Bold="true"></asp:Label></td>
                                <td>
                                    <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Width="100%" Height="100px"></asp:TextBox></td>
                            </tr>--%>
                    <tr>

                        <td>

                            <telerik:RadButton Width="100%" Height="70PX" SingleClick="true" SingleClickText="Guardando..." Style="clear: both; float: right; margin: 10px 0;"
                                ID="RadButton1" runat="server" Text="Guardar Correspondencia" OnClick="Button1_Click" Skin="Bootstrap">
                                <Icon PrimaryIconCssClass="rbSave"></Icon>
                            </telerik:RadButton>

                        </td>
                    </tr>

                    <tr><td colspan="2">
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

                             <telerik:GridTemplateColumn HeaderText="ACTUALIZACIONES " HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center">
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
                                                 <asp:Label Style="color: #000000;" ID="Label10" runat="server" Text='<%# Eval("nombre") %>'></asp:Label>

                                             </td>
                                             <td style="text-align:left"><strong>DESCRIPCIÓN:</strong>
                                                 <asp:Label Style="color: #000000;" ID="Label6" runat="server" Text='<%# Eval("nombre") %>'></asp:Label></td>
                                             <td rowspan="2" style="width: 40PX">
                                                 
                                                 
                                                 
                                                 <asp:HyperLink ID="HyperLink1"  Target="_blank" Visible='<%#bool.Parse( string.Format("{0}",ProcessMyDataItem( Eval("ID")))) %>' href='<%# String.Format(" files/Correspondencia/{0}{1}", Eval("ID"), Eval("Extencion")) %>' runat="server">ABRIR</asp:HyperLink>

                                             </td>
                                         </tr>
                                         <tr>
                                             <td style="text-align: left">
                                                 <strong>CARGADO:</strong>
                                                 <asp:Label Style="color: #000000;" ID="Label3" runat="server" Text='<%# Eval("FechaCarga") %>'></asp:Label>


                                             </td>
                                             <td style="text-align: left">
                                                 <strong>POR:
                                                 <asp:Label Style="color: #000000;" ID="Label4" runat="server" Text='<%# Eval("NAM") %>'></asp:Label>
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




                        </td></tr>
                </table>
            </fieldset>

            <%--            </telerik:RadAjaxPanel>
                             <telerik:RadAjaxLoadingPanel Width="100%" BackgroundPosition="Top"   ID="RadAjaxLoadingPanel3" runat="server" >--%>
            <%-- <img alt="Loading..." src='<%= RadAjaxLoadingPanel.GetWebResourceUrl(Page, "Telerik.Web.UI.Skins.Default.Ajax.loading.gif") %>' style="border: 0;" />--%>

            <%--        </telerik:RadAjaxLoadingPanel>--%>

            <%--                </ContentTemplate>
            </asp:UpdatePanel>--%>
        </div>
    </form>
</body>
</html>
