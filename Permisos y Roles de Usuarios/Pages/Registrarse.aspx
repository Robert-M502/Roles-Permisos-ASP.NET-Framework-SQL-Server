<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MP.Master" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="Permisos_y_Roles_de_Usuarios.Pages.Registrarse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Registrase
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <div class="container box">
        <h1 class="title">Registro de usuarios</h1>

        <div class="field">
            <label class="label">Nombre</label>
            <div class="control">
                <asp:TextBox runat="server" ID="nombre" CssClass="input" type="text" placeholder="ej. Roberto Morales"></asp:TextBox>
            </div>
        </div>
        <div class="field">
            <label class="label">Edad</label>
            <div class="control">
                <asp:TextBox runat="server" ID="edad" CssClass="input" type="text" placeholder="ej. 23"></asp:TextBox>
            </div>
        </div>
        <div class="field">
            <label class="label">Usuario</label>
            <div class="control">
                <asp:TextBox runat="server" ID="usuario" CssClass="input" type="text" placeholder="ej. Robert_M502"></asp:TextBox>
            </div>
        </div>
        <div class="field">
            <label class="label">Clave</label>
            <div class="control">
                <asp:TextBox runat="server" ID="clave" CssClass="input" type="password" placeholder="ej. *****"></asp:TextBox>
            </div>
        </div>

        <div class="field is-grouped">
            <div class="control">
                <asp:Button runat="server" ID="registrar" CssClass="button is-link" Onclick="btnRegistrar_Click" Text="Enviar"/>
            </div>
            <div class="control">
                <a class="button is-link is-light" href="Index.aspx">Cancelar</a>
            </div>
        </div>
    </div>
</asp:Content>
