<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastrarMateria.aspx.cs" Inherits="SprintWebCS.CadastrarMateria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td></td>
            <td colspan="3">&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblID" runat="server" Text="ID" Width="80px"></asp:Label></td>
            <td colspan="3">
                <asp:TextBox ID="txtID" runat="server" MaxLength="100" Width="20px" Enabled="false"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDesc" runat="server" Text="Nome" Width="80px"></asp:Label></td>
            <td colspan="3">
                <asp:TextBox ID="txtDesc" runat="server" MaxLength="100" Width="600px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnSalvar" runat="server"
                    Text="Salvar" OnClick="btnSalvar_Click" />
            </td>
            <td colspan="3">&nbsp;</td>
        </tr>

    </table>

</asp:Content>
