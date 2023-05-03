using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Permisos_y_Roles_de_Usuarios.Pages
{
    public partial class Index : System.Web.UI.Page
    {
        int id_rol = 0;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.AppendHeader("Cache-Control", "no-store");

            if (!IsPostBack && Session["usuario"] != null) {
                id_rol = Convert.ToInt32(Session["id_rol"].ToString());
                Datos();
                Permisos(id_rol);
            }

        }

        void Datos() {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_datos", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                datos.DataSource = dt;
                datos.DataBind();
                conn.Close();

            }
            catch (Exception) {
                throw;
            }
        }

        void Permisos(int id_rol) {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_permisos", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id_rol", SqlDbType.Int).Value = id_rol;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                bool Create, Read, Update, Delete;
                while (reader.Read())
                {
                    foreach (GridViewRow fila in datos.Rows) {
                   
                        switch (reader[0].ToString())
                        {
                            case "Create":
                                Create = Convert.ToBoolean(reader[1].ToString());
                                if (Create)
                                {
                                    btnCreate.Visible = true;
                                }
                                else {
                                    btnCreate.Visible = false;
                                }
                                break;
                            case "Read":
                                Read = Convert.ToBoolean(reader[1].ToString());
                                Button btn1 = fila.FindControl("btnRead") as Button;
                                if (Read)
                                {
                                    btn1.Visible = true;
                                }
                                else
                                {
                                    btn1.Visible = false;
                                }
                                break;
                            case "Update":
                                Update = Convert.ToBoolean(reader[1].ToString());
                                Button btn2 = fila.FindControl("btnUpdate") as Button;
                                if (Update)
                                {
                                    btn2.Visible = true;
                                }
                                else
                                {
                                    btn2.Visible = false;
                                }
                                break;
                            case "Delete":
                                Delete = Convert.ToBoolean(reader[1].ToString());
                                Button btn3 = fila.FindControl("btnDelete") as Button;
                                if (Delete)
                                {
                                    btn3.Visible = true;
                                }
                                else
                                {
                                    btn3.Visible = false;
                                }
                                break;
                        }
                    }
                }  
                conn.Close();
                reader.Close();
            } 
            catch (Exception){
                throw;
            }
        }
    }
}