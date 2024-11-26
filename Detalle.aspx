<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="WebApplication2.Detalle" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link rel="shortcut icon" type="image/png" href="IMG/3.png"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script type="text/javascript" src="javasscript/Funcs.js"></script>
    <style type="text/css">
        .auto-style1 {
            height: 28px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <telerik:RadScriptManager ID="RadScriptManager1" runat="server"></telerik:RadScriptManager>
            <telerik:RadFormDecorator RenderMode="Lightweight" ID="RadFormDecorator1" runat="server" DecoratedControls="Fieldset" EnableRoundedCorners="false" />
            <fieldset style="text-align: center; align-content:center">
                <legend></legend>
                <table  style="font-family: Arial; font-family: Arial; font-size: 20px; align-content:center" >

                    <tr>
                        <td colspan="2" style="text-align: right" >
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 35%; text-align: right">
                            <asp:Label ID="Label6" runat="server" Text="FOLIO:" Font-Bold="true"></asp:Label>

                        </td>
                        <td style="text-align:left; font-style:italic">
                            <asp:Label ID="Labelfolio" runat="server" Text="" ></asp:Label>
                            <%--<asp:DropDownList Width="100%" Height="40px" ID="DropDownListDependenciaEjecutoria" runat="server"></asp:DropDownList>--%></td>
                    </tr>
                    <tr>
                        <td style="text-align: right">
                            <asp:Label Font-Bold="true" ID="Label1" runat="server" Text="PAGINAS:"></asp:Label></td>
                        <td style="text-align:left; font-style:italic">
                            <asp:Label ID="LabelPaginas" runat="server" Text=""></asp:Label></td>



                    </tr>
                    <tr>
                        <td style="text-align: right" class="auto-style1">
                            <asp:Label ID="Label2" Font-Bold="true" runat="server" Text="REMITENTE:"></asp:Label></td>
                        <td style="text-align:left; font-style:italic" class="auto-style1">
                            <asp:Label ID="LabelRemitente" runat="server" Text=""></asp:Label></td>



                    </tr>
                    <tr>
                        <td style="text-align: right">
                            <asp:Label ID="Label3" runat="server" Text="DESTINO:" Font-Bold="true"></asp:Label></td>
                        <td style="text-align:left; font-style:italic">
                            <asp:Label ID="LabelDestino" runat="server" Text=""></asp:Label></td>
                        <%--                            <asp:DropDownList Width="100%" Height="40px" ID="DropDownListPrioridadnacional" runat="server"></asp:DropDownList></td>--%>
                    </tr>
                    <tr>
                        <td style="text-align: right">
                            <asp:Label Font-Bold="true" ID="Label4" runat="server" Text="ASUNTO:"></asp:Label></td>
                        <td style="text-align:left">
                            <asp:TextBox ID="TextBoxBservaciones" runat="server" TextMode="MultiLine" Enabled="false" Width="70%" Height="150px"> </asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td  style="text-align: right">
                            <asp:Label ID="Label5" runat="server" Text="FECHA:" Font-Bold="true"></asp:Label></td>
                        <td style="text-align: left">
                            <telerik:RadDatePicker  ID="TextBoxCorrespondenciaFecha" runat="server" Enabled="false" Skin="Bootstrap">


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
                        <td colspan="2" style="text-align: right">



                        </td>
                    </tr>
                </table>
            </fieldset>

            <telerik:RadWindow ID="RadWindow1" EnableEmbeddedScripts="true" ViewStateMode="Enabled" Behaviors="Default" runat="server" Width="450px" Height="450px" Modal="true"
                VisibleStatusbar="FALSE" Animation="FlyIn" Title="FORMULARIO PARA ITEMS " CssClass="ZindeX" VisibleOnPageLoad="True" Skin="Bootstrap">
            </telerik:RadWindow>


        </div>
    </form>
</body>
</html>
