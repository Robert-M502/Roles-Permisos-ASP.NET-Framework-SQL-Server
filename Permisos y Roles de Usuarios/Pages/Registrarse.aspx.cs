using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Permisos_y_Roles_de_Usuarios.Pages
{
    public partial class Registrarse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.AppendHeader("Cache-Control", "no-store"); 
        }

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ToString());

        void Limpiar() {
            nombre.Text = string.Empty;
            edad.Text = string.Empty;
            usuario.Text = string.Empty;
            clave.Text = string.Empty;
        }

        protected void btnRegistrar_Click(object sender, EventArgs e) {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_registrar", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar).Value = nombre.Text;
                cmd.Parameters.Add("@Edad", System.Data.SqlDbType.Int).Value = edad.Text;
                cmd.Parameters.Add("@Usuario", System.Data.SqlDbType.VarChar).Value = usuario.Text;
                cmd.Parameters.Add("@Clave", System.Data.SqlDbType.VarChar).Value = clave.Text;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Limpiar();
                Response.Redirect("Login.aspx");
            }
            catch (Exception) {
                throw;
            }
         
        }
    }
}