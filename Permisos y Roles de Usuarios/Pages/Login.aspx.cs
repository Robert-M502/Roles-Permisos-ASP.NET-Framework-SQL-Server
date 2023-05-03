using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Permisos_y_Roles_de_Usuarios.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.AppendHeader("Cache-Control", "no-store"); // liberar el cache para que la vista siempre se actualice
        }

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

        void Limpiar() {
            usuario.Text = string.Empty;
            clave.Text = string.Empty;
        }

        protected void btnIngresar_Click(object sender, EventArgs e) {
            try {
                SqlCommand cmd = new SqlCommand("sp_Login", conn);
               cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@Usuario", System.Data.SqlDbType.VarChar).Value = usuario.Text.Trim();
                cmd.Parameters.Add("@Clave", System.Data.SqlDbType.VarChar).Value = clave.Text.Trim();
                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    Session["Id_rol"] = rd[5].ToString();
                    Session["usuario"] = rd[1].ToString();
                    
                    Response.Redirect("Index.aspx");
                }
                else {
                    Limpiar();
                }
                conn.Close();
            } 
            catch (Exception ex) {
                string Error = "Error inesperado en la aplicación: " + ex.Message;
                messageError.Text = Error;
            } 
        }
    }
}