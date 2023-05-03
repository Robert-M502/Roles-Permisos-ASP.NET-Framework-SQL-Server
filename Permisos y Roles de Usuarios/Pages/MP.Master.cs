using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Permisos_y_Roles_de_Usuarios.Pages
{
    public partial class MP : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.AppendHeader("Cache-Control", "no-store"); // liberar el cache para que la vista siempre se actualice

            if (Session["usuario"] != null) {
                divUser.Visible = true;
                divbuttons.Visible = false;

                lblUsuario.Text = Session["usuario"].ToString();
            } else
            {
                divUser.Visible = false;
                divbuttons.Visible = true;
                lblUsuario.Text = string.Empty;
            }
        }
        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registrarse.aspx");
        }
        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
        protected void btnSalir_Click(object sender, EventArgs e) {
            Session["usuario"] = null;
            Session["Id_rol"] = null;
            Response.Redirect("Login.aspx");

            HttpContext.Current.Session.Abandon();
        }
    }
}