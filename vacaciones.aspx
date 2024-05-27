<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vacaciones.aspx.cs" Inherits="WebApplication2.vacaciones" %>

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
            <telerik:RadGrid ID="RadGrid2" Visible="true" runat="server" AutoGenerateColumns="False" OnNeedDataSource="RadGrid1_NeedDataSource" OnItemCommand="RadGrid2_ItemCommand"
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
                                <table width="100%" style="font-family: Arial">
                                    <tr style="text-align: left">
                                        <td rowspan="7" style="width: 60PX">
                                            <asp:ImageButton Height="65px" Width="55px" ID="ImageButton4" runat="server" ImageUrl="~/IMG/EXTENSIONES/.PDF.PNG"
                                                CommandArgument='<%# String.Format("{0}", Eval("ID")) %>' />
<%--                                            <asp:Image ID="Image4" ImageUrl="~/IMG/EXTENSIONES/.PDF.PNG" runat="server" />--%>
                                            <%--                                                            <asp:HyperLink ID="HyperLink1" Target="_blank" href='<%# String.Format(" files/Correspondencia/{0}{1}", Eval("ID"), Eval("Extencion")) %>' runat="server">'<%# String.Format("{0}{1}", Eval("Nombre"),Eval("Extencion")) %>'</asp:HyperLink>--%>
                                            <%--<asp:ImageButton ID="ImageButton3" runat="server" ImageUrl='<%# String.Format("~/IMG/{0}.png", Eval("IDTIpoContenido")) %>'
                                                                CommandArgument='<%# String.Format("{0} {1}", Eval("Id"),Eval("IDTIpoContenido")) %>' />
                                                            <asp:Label Style="color: #000000;" ID="Label10" ToolTip='<%# String.Format("{0}",ProcessMyDataItemaCTUALIZADOCorrespondencia( Eval("ID"), Eval("IDTIpoContenido"))) %>' CommandArgument='<%# String.Format("{0} {1}", Eval("Id"),Eval("IDTIpoContenido")) %>' runat="server" Text='<%# ProcessMyDataItem(Eval("Descripcion")) %>'></asp:Label>--%>
                                        </td>
                                        <td style="text-align: left">
                                            <strong>AÑO:</strong>
                                            <asp:Label Style="color: #000000;" ID="Label10" runat="server" Text='<%# Eval("Descripcion") %>'></asp:Label>-
                                        </td>
                                        <td style="text-align: center"><strong>DESDE:</strong>
                                            <asp:Label Style="color: #000000;" ID="Label6" runat="server" Text='<%# Eval("fechainicio") %>'></asp:Label>-</td>
                                     <%--   <td rowspan="2" style="width: 40PX">
                                            <asp:HyperLink ID="HyperLink1" Target="_blank" href='<%# String.Format(" files/personal/{0}{1}",Eval("ID"), Eval("ID")) %>' runat="server">ABRIR</asp:HyperLink>
                                        </td>--%>
                                    </tr>
                                    <tr>
                                        <td style="text-align: left">
                                            <strong>CARGADO:</strong>
                                            <asp:Label Style="color: #000000;" ID="Label3" runat="server" Text='<%# Eval("PERIODO") %>'></asp:Label>
                                        </td>
                                        <td style="text-align: center"><strong>HASTA:
                                                            <asp:Label Style="color: #000000;" ID="Label4" runat="server" Text='<%# Eval("FECHAFIN") %>'></asp:Label>
                                        </strong></td>
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
        </div>
    </form>
</body>
</html>
