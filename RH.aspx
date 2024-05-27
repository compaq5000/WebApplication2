<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RH.aspx.cs" Inherits="WebApplication2.RH" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
              <table style="width: 100%">



                  <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>


                    <%-- <tr style="background-image: url('img/tejido.jpg'); margin-top: 0; height: 30px">
                        <td></td>
                        <td></td>

                    </tr>--%>
                    <tr style="vertical-align: top">
                        <td style="vertical-align: top; text-align: center" rowspan="2">

                            <asp:ImageButton ID="ImageButtonImg" runat="server" ToolTip="Click para cambiar la imagen al usuario" OnClick="ImageButton2_Click" Width="250px" />
                            <br />
                            <telerik:RadWindow ID="RadWindow1" Behaviors="Default" runat="server" Width="450px" Height="200px" Modal="true"
                                VisibleStatusbar="true" Animation="FlyIn" Title="Cambiar imagen" CssClass="ZindeX" Skin="Bootstrap">
                            </telerik:RadWindow>
                            <asp:ImageButton ID="ImageButton2" runat="server" OnClick="ImageButton2_Click1" ToolTip="Recarga imagen" ImageUrl="~/IMG/refres.png" />



                        </td>
                        <td style="height: 70px">

                            <fieldset style="font-family: Arial; vertical-align: top">
                                <legend><strong>GENERALES </strong></legend>

                                <table style="width: 100%">
                                    <tr>
                                        <td bgcolor="#D6E0C9">
                                            <asp:Label ID="Label2" runat="server" Text="NOMBRE:" Font-Bold="true"></asp:Label>

                                        </td>
                                        <td bgcolor="#D6E0C9">
                                            <asp:Label ID="Label3" runat="server" Text="PATERNO:" Font-Bold="true"></asp:Label>
                                        </td>
                                        <td bgcolor="#D6E0C9">
                                            <asp:Label ID="Label1" runat="server" Text="MATERNO:" Font-Bold="true"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="LabelName" runat="server" Text="" Font-Bold="true"></asp:Label></td>
                                        <td>
                                            <asp:Label ID="LabelPaterno" runat="server" Text="" Font-Bold="true"></asp:Label></td>
                                        <td>
                                            <asp:Label ID="LabelMaterno" runat="server" Text="" Font-Bold="true"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td bgcolor="#D6E0C9">
                                            <asp:Label ID="Label4" runat="server" Text="NO. EMPLEADO:" Font-Bold="true"></asp:Label>

                                        </td>
                                        <td bgcolor="#D6E0C9">
                                            <asp:Label ID="Label5" runat="server" Text="CATEGORIA" Font-Bold="true"></asp:Label>
                                        </td>
                                        <td bgcolor="#D6E0C9">
                                            <asp:Label ID="Label6" runat="server" Text="TIPO PLAZA:" Font-Bold="true"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="LabelNOEMPLEADO" runat="server" Text="" Font-Bold="true"></asp:Label></td>
                                        <td>
                                            <asp:Label ID="LabelCATEGORIA" runat="server" Text="" Font-Bold="true"></asp:Label></td>
                                        <td>
                                            <asp:Label ID="LabelTIPOPLAZA" runat="server" Text="" Font-Bold="true"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td bgcolor="#D6E0C9">
                                            <asp:Label ID="Label10" runat="server" Text="SUELDO:" Font-Bold="true"></asp:Label>

                                        </td>
                                        <td bgcolor="#D6E0C9">
                                            <asp:Label ID="Label11" runat="server" Text="FECHA DE INGRESO" Font-Bold="true"></asp:Label>
                                        </td>
                                        <td bgcolor="#D6E0C9">
                                            <asp:Label ID="Label12" runat="server" Text="RFC:" Font-Bold="true"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <telerik:RadNumericTextBox ID="LabelSUELDO" runat="server" Culture="es-MX" DbValueFactor="1" LabelWidth="64px" Skin="Bootstrap" Type="Currency" Width="160px">
                                                <NegativeStyle Resize="None"></NegativeStyle>

                                                <NumberFormat ZeroPattern="$n"></NumberFormat>

                                                <EmptyMessageStyle Resize="None"></EmptyMessageStyle>

                                                <ReadOnlyStyle Resize="None"></ReadOnlyStyle>

                                                <FocusedStyle Resize="None"></FocusedStyle>

                                                <DisabledStyle Resize="None"></DisabledStyle>

                                                <InvalidStyle Resize="None"></InvalidStyle>

                                                <HoveredStyle Resize="None"></HoveredStyle>

                                                <EnabledStyle Resize="None"></EnabledStyle>
                                            </telerik:RadNumericTextBox>
                                            <%--<asp:Label ID="" runat="server" Text="" Font-Bold="true"></asp:Label>--%></td>
                                        <td>
                                            <asp:Label ID="LabelFECHAINGRESO" runat="server" Text="" Font-Bold="true"></asp:Label></td>
                                        <td>
                                            <asp:Label ID="LabelRFC" runat="server" Text="" Font-Bold="true"></asp:Label></td>
                                    </tr>


                                    <tr>
                                        <td bgcolor="#D6E0C9">
                                            <asp:Label ID="Label13" runat="server" Text="AREA DE ADSCRIPCION:" Font-Bold="true"></asp:Label>

                                        </td>
                                        <td bgcolor="#D6E0C9">
                                            <asp:Label ID="Label18" runat="server" Text="JEFE DIRECTO" Font-Bold="true"></asp:Label>
                                        </td>
                                        <td bgcolor="#D6E0C9">
                                            <asp:Label ID="Label14" runat="server" Text="STATUS:" Font-Bold="true"></asp:Label></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <asp:Label ID="LabelaDSCRIPCION" runat="server" Text="" Font-Bold="true"></asp:Label></td>
                                        <td><asp:Label ID="LabelJefe" runat="server" Text="" Font-Bold="true"></asp:Label></td>
                                        <td>
                                            <asp:ImageButton ID="ImageButtonstatus" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">

                                            <%--      <telerik:RadComboBox ID="RadComboBoxUsuarios" Width="350px" runat="server" AutoPostBack="true" OnSelectedIndexChanged="RadComboBoxUsuarios_SelectedIndexChanged" Skin="Bootstrap"></telerik:RadComboBox>

                                            --%>



                                        </td>

                                        <td></td>
                                    </tr>
                                </table>
                            </fieldset>

                            <fieldset style="font-family: Arial; vertical-align: top">
                                <legend><strong>DOMICILIO</strong></legend>

                                <table style="width: 100%">
                                    <tr>
                                        <td bgcolor="#D6E0C9">
                                            <asp:Label ID="Label7" runat="server" Text="CALLE:" Font-Bold="true"></asp:Label>
                                        </td>
                                        <td bgcolor="#D6E0C9">
                                            <asp:Label ID="Label8" runat="server" Text="NO. EXTERIOR:" Font-Bold="true"></asp:Label>
                                        </td>
                                        <td bgcolor="#D6E0C9">
                                            <asp:Label ID="Label9" runat="server" Text="COLONIA:" Font-Bold="true"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="LabelCalle" runat="server" Text="" Font-Bold="true"></asp:Label></td>
                                        <td>
                                            <asp:Label ID="LabelNumero" runat="server" Text="" Font-Bold="true"></asp:Label></td>
                                        <td>
                                            <asp:Label ID="LabelColonia" runat="server" Text="" Font-Bold="true"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td bgcolor="#D6E0C9">
                                            <asp:Label ID="Label16" runat="server" Text="TELEFONO CASA:" Font-Bold="true"></asp:Label>
                                        </td>
                                        <td bgcolor="#D6E0C9">
                                            <asp:Label ID="Label19" runat="server" Text="TELEFONO CELULAR:" Font-Bold="true"></asp:Label>
                                        </td>
                                        <td bgcolor="#D6E0C9">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="LabelTelCasa" runat="server" Text="" Font-Bold="true"></asp:Label></td>
                                        <td>
                                            <asp:Label ID="LabelTelCelular" runat="server" Text="" Font-Bold="true"></asp:Label></td>
                                        <td></td>
                                    </tr>
                                </table>

                            </fieldset>

                            <fieldset style="font-family: Arial; vertical-align: top">
                                <legend><strong>CONTACTO</strong></legend>

                                <table style="width: 100%">
                                    <tr>
                                        <td colspan="2" bgcolor="#D6E0C9">
                                            <asp:Label ID="Label15" runat="server" Text="NOMBRE DEL CONTACTO" Font-Bold="true"></asp:Label></td>
                                        <td bgcolor="#D6E0C9">
                                            <asp:Label ID="Label17" runat="server" Text="TELEFONO DEL CONTACTO" Font-Bold="true"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:Label ID="LabelNoContacto"   runat="server" Text="TELEFONO DEL CONTACTO" Font-Bold="true"></asp:Label></td>
                                        <td>
                                            <asp:Label ID="LabelTelContacto" runat="server" Text="" Font-Bold="true"></asp:Label></td>
                                    </tr>
                                </table>
                            </fieldset>
                        </td>

                    </tr>
                    <tr style="vertical-align: top">

                        <td style="vertical-align: top">&nbsp;</td>
                    </tr>
                    <tr style="background-image: url('img/tejido.jpg'); margin-top: 0; height: 30px">
                        <td colspan="2"></td>
                    </tr>


                </table>
    </form>
</body>
</html>
