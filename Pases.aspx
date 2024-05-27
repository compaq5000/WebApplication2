<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pases.aspx.cs" Inherits="WebApplication2.Pases" %>

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

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <fieldset>
                        <legend>NUEVO</legend>

                        <table style="width: 100%">
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="Label7" Text="TIPO:"></asp:Label></td>
                                <td>
                                    <telerik:RadComboBox ID="RadComboBoxtIPO" AutoPostBack="true" Width="250px" runat="server" Skin="Bootstrap" OnSelectedIndexChanged="RadComboBoxtIPO_SelectedIndexChanged"></telerik:RadComboBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 350px">
                                    <asp:Label runat="server" ID="Label2" Text="FECHA"></asp:Label></td>
                                <td>
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
                                <td>
                                    <asp:Label runat="server" ID="Label8" Text="JUSTIFICAR" Visible="true"></asp:Label></td>
                                <td>
                                    <telerik:RadComboBox ID="RadComboBoxJUSTIFI" runat="server" Skin="Bootstrap"></telerik:RadComboBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: left">
                                    <asp:Label runat="server" ID="lBL1" Text="HORARIO DE SALIDA"></asp:Label></td>
                                <td>
                                    <telerik:RadTimePicker ID="RadTimePicker1" runat="server" Skin="Bootstrap"></telerik:RadTimePicker>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="Label1" Text="HORARIO DE ENTRADA"></asp:Label></td>
                                <td style="text-align: left">
                                    <telerik:RadTimePicker ID="RadTimePicker2" runat="server" Skin="Bootstrap">
                                    </telerik:RadTimePicker>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="Label5" Text="ASUNTO"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBoxAsunto" runat="server" TextMode="MultiLine" Width="370px" Height="80px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" style="text-align: right">
                                    <telerik:RadButton ID="RadButton1" Width="150PX" Height="50PX" runat="server" Text="GUARDAR" Skin="Bootstrap" OnClick="RadButton1_Click"></telerik:RadButton>
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
              



                    <telerik:RadWindow ID="RadWindow1" EnableEmbeddedScripts="true" ViewStateMode="Enabled" Behaviors="Default" runat="server" Width="450px" Height="450px" Modal="true"
                        VisibleStatusbar="true" Animation="FlyIn" Title="" CssClass="ZindeX" VisibleOnPageLoad="True" Skin="Bootstrap">
                    </telerik:RadWindow>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
