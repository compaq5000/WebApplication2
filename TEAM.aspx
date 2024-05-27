<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TEAM.aspx.cs" Inherits="WebApplication2.TEAM" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <telerik:RadScriptManager runat="server" ID="RadScriptManager1" />

        <div>
              <telerik:RadFormDecorator RenderMode="Lightweight" ID="RadFormDecorator1" runat="server" DecoratedControls="Fieldset"  EnableRoundedCorners="false" />
                            <telerik:RadListView ID="TableDatos" runat="server" RenderMode="Lightweight"
                                ItemPlaceholderID="EmployeesContainer"   PageSize="3" AllowPaging="True" DataKeyNames="ID">


                                <ItemTemplate>
                                    <fieldset>
                                        <legend style="background-image: url('img/menu.gif'); font-size: 20; font-family: Arial; color: white; margin-top: 0; height: 30px"></legend>

                                        <table border="0" style="width: 100%; text-align: center">

                                            <tr>
                                                <td style="text-align: center" >
                                                    <asp:ImageButton  ID="ImageButton16" runat="server" ImageUrl='<%# String.Format("~/IMG/Users/{0}{1}", ProcessMyDataItemIMG(Eval("ValueX")), ProcessMyDataItemExt( Eval("ValueX"))) %>' Width="150px" />

                                                </td>


                                            </tr>
                                            <tr>
                                                <td style="font-size:50px; font-family:'Century Gothic'">
                                                    <strong>ASIGNADO A:</strong><br />
                                                    <strong><%# String.Format("{0}",ProcessMyDataItem( Eval("ValueX"))) %>'</strong> </td>

                                            </tr>
                                           
                                        </table>

                                    </fieldset>
                                </ItemTemplate>
                            </telerik:RadListView>

        </div>
    </form>
</body>
</html>
