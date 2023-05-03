<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MP.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Permisos_y_Roles_de_Usuarios.Pages.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Inicio
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">

    <br />
    <asp:Button runat="server" CssClass="button is-light" ID="btnCreate" Visible="false" Text="Create" />
    <asp:GridView CssClass="table center mx-auto" runat="server" ID="datos">
        <Columns>
            <asp:TemplateField HeaderText="Opciones">
                <ItemTemplate>
                    <asp:Button runat="server" CssClass="button is-primary" ID="btnRead" Text="Read" />
                    <asp:Button runat="server" CssClass="button is-warning" ID="btnUpdate" Text="Update" />
                    <asp:Button runat="server" CssClass="button is-danger" ID="btnDelete" Text="Delete" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>
