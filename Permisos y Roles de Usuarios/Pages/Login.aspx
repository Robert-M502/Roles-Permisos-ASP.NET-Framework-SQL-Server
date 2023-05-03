<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MP.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Permisos_y_Roles_de_Usuarios.Pages.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Iniciar Sesión
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <div class="container box">
        <h1 class="title">Iniciar Sesión</h1>

        <div class="field">
            <label class"lavel">Usuarios</label>
            <div class="control">
                <asp:Textbox runat="server" id="usuario" class="input" type="text" placeholder="ej. Robert_M502"></asp:Textbox>
            </div>
        </div>
        <div class="field">
            <label class"lavel">Clave</label>
            <div class="control">
                <asp:Textbox runat="server" id="clave" class="input" type="password" placeholder="ej. ****"></asp:Textbox>
            </div>
        </div>

        <asp:Button runat="server" id="ingresar" class="button is-primary" OnClick="btnIngresar_Click" text="Ingresar"/>



    </div>
    <asp:Label ID="messageError" runat="server" Text=""></asp:Label>
</asp:Content>
