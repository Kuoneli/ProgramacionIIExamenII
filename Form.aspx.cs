using System;
using System.Collections.Generic;
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
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["ToServer"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand(" INSERT INTO Encuestas VALUES('" + "' , '" + TextoNombre.Text + "', '" + TextoApellido.Text + "', '" + TextoNacimiento.Text + "','" + TextoEdad.Text + "','" + TextoCorreo.Text + "','" + TextoCarro.Text + "')", conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

    
    }
}