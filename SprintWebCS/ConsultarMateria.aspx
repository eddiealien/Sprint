<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultarMateria.aspx.cs" Inherits="SprintWebCS.ConsultarMateria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <table>
                <tr>
                    <td>
                    </td>
                    <td colspan="3">
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblNome" runat="server" Text="Nome" Width="80px"></asp:Label></td>
                    <td colspan="3">
                        <asp:TextBox ID="txtNome" runat="server" MaxLength="100" Width="600px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnConsultar" runat="server"
                            Text="Consultar" OnClick="btnConsultar_Click" />
                        <asp:Button ID="btnNovo" runat="server"
                            Text="Novo" OnClick="btnNovo_Click"  />
                    </td>
                    <td colspan="3"></td>
                </tr>

                </table>
        <table>
            <tr>
                <td>
                    <asp:GridView ID="gridViewConsultar" runat="server" Width="700px" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" GridLines="Vertical" OnRowDeleting="gridViewConsultar_RowDeleting" OnSelectedIndexChanged="gridViewConsultar_SelectedIndexChanged" style="margin-right: 148px" ForeColor="Black">
                        <AlternatingRowStyle BackColor="#CCCCCC" />
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" DeleteText="Apagar" HeaderText="Apagar" />
                            <asp:CommandField SelectText="Alterar" ShowSelectButton="True" HeaderText="Alterar" />
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                </td>
            </tr>
        </table>

</asp:Content>
