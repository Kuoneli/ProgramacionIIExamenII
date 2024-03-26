using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProgramacionIIExamenII
{
    public partial class Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EncuestasTotales();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void VerificarEdad_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(TextoEdad.Text);
            
            if (edad < 18 || edad > 50)
            {
                AlertaEdad.Visible = true;
                AlertaEdad.Text = "Debe ser mayor a 17 años y menor a 51 para poder completar la Encuesta";
               
                LabelNombre.Visible = false;
                TextoNombre.Visible = false;
                LabelApellido.Visible = false;
                TextoApellido.Visible = false;
                LabelNacimiento.Visible = false;
                TextoNacimiento.Visible = false;
                LabelCarro.Visible = false;
                TextoCarro.Visible=false;
                LabelCorreo.Visible = false;
                TextoCorreo.Visible = false;
                IngresarDatos.Visible = false;
            } else
            {                
                AlertaEdad.Visible = true;
                AlertaEdad.Text = "Puede Completar la Encuesta";
                LabelNombre.Visible = true;
                TextoNombre.Visible = true;
                LabelApellido.Visible = true; 
                TextoApellido.Visible=true;
                LabelNacimiento.Visible = true; 
                TextoNacimiento.Visible=true;
                LabelCarro.Visible = true; 
                LabelCorreo.Visible = true;
                TextoCorreo.Visible = true;
                LabelCarro.Visible =true;
                TextoCarro.Visible=true;
                IngresarDatos.Visible = true;   

            }
            
        }

        protected void FNacimiento_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void IngresarDatos_Click(object sender, EventArgs e)
        {
            if (TextoNombre.Text.Equals(("")) || TextoApellido.Text.Equals(("")) || TextoCarro.Equals(("")) || TextoCorreo.Text.Equals("") || TextoNacimiento.Text.Equals(""))
            {
                AlertaEdad.Text = "Uno o mas campos estan vacios";
            }
            else
            {
                AlertaEdad.Text = "Puede Completar la Encuesta";
                String s = System.Configuration.ConfigurationManager.ConnectionStrings["ToServer"].ConnectionString;
                SqlConnection conexion = new SqlConnection(s);
                conexion.Open();
                SqlCommand comando = new SqlCommand(" INSERT INTO Encuestas VALUES('" + TextoNombre.Text + "', '" + TextoApellido.Text + "', '" + TextoNacimiento.Text + "','" + TextoEdad.Text + "','" + TextoCorreo.Text + "','" + TextoCarro.Text + "')", conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
            }
           
        }

        protected void EncuestasTotales()
        {
            string constr = ConfigurationManager.ConnectionStrings["ToServer"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select COUNT (*) from Encuestas"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind(); // refrescar la tabla
                        }
                    }
                }
            }
        }

    
    }
}