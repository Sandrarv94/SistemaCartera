using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SistemaCartera.Clases;
using SistemaCartera.Formularios;


namespace SistemaCartera
{
    public partial class FrmTitular : Form
    {
        cConexion cn; //creando variable de la clase cConexion
        int i, boton, contador;
        SqlCommand cmd; //variable para traer los comandos de sql
        SqlDataAdapter da; //se necesita para las consultas
        DataTable dt;
        public FrmTitular()
        {
            InitializeComponent();
            cn = new cConexion();
            i = 0; boton = 0;
            cmd = new SqlCommand("select * from tblCliente", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt); // llena el dt o la tabla con la consulta de cmd
        }

        void habilita()
        {
            txtCedula.Enabled = true;
            txtNombre.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            dateFechaN.Enabled = true;
            dateFechaA.Enabled = true;
            
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from tblCliente where cedula = '" + txtCedula.Text + "'", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                switch (boton)
                {
                    case 1:

                        llenar(dt, 0);
                        MessageBox.Show("Ya está el titular");
                        break;
                    case 2:
                        llenar(dt, 0);
                        break;
                    case 3:
                        llenar(dt, 0);
                        deshabilita();
                        break;
                    case 4:
                        llenar(dt, 0);
                        if (MessageBox.Show("Desea eliminar el titular?", "Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SqlCommand cm = new SqlCommand("delete from tblCliente where cedula = '" + txtCedula.Text + "'", cn.AbrirConexion());
                            cm.ExecuteNonQuery();
                        }
                        break;

                }
            }
            else
            {
                MessageBox.Show("El titular no existe");
            }
        }

        private void FrmTitular_Load(object sender, EventArgs e)
        {
            llenar(dt, i);
        }


        void llenar(DataTable dt, int i)
        {   
            
            txtCedula.Text = dt.Rows[i][0].ToString();
            txtNombre.Text = dt.Rows[i][1].ToString();
            txtDireccion.Text = dt.Rows[i][2].ToString();
            txtTelefono.Text = dt.Rows[i][3].ToString();
            dateFechaN.Value = DateTime.Parse(dt.Rows[i][4].ToString());
            dateFechaA.Value = DateTime.Parse(dt.Rows[i][5].ToString());
            txtEdad.Text = (DateTime.Now.Year - dateFechaN.Value.Year).ToString();


            //almacena la cantidad de registros de la tabla
            contador = dt.Rows.Count;
        }


        void deshabilita()
        {
            txtCedula.Enabled = false;
            txtNombre.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            txtEdad.Enabled = false;
            dateFechaN.Enabled = false;
            dateFechaA.Enabled = false;
            
        }

        void limpia()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEdad.Clear();
            
        }


        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            boton = 1;
            limpia();
            habilita();
            txtCedula.Focus();
        }
                

        private void btnModificar_Click(object sender, EventArgs e)
        {
            boton = 2;
            limpia();
            habilita();
            txtCedula.Focus();
        }

        

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            boton = 3;
            limpia();
            txtCedula.Enabled = true;
            txtCedula.Focus();
        }

        private void btnVerBeneficiarios_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmVerBeneficiario(txtCedula.Text);
            formulario.Show();
        }

        private void btnAgregarBeneficiario_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmAgregarBeneficiario(txtCedula.Text);
            formulario.Show();
        }

        

        private void dateFechaN_Leave(object sender, EventArgs e)
        {
            txtEdad.Text = (DateTime.Now.Year - dateFechaN.Value.Year).ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            boton = 4;
            limpia();
            txtCedula.Enabled = true;
            txtCedula.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (boton == 1)
            {
                cmd = new SqlCommand("insert into tblCliente values('" + txtCedula.Text + "', '" + txtNombre.Text + "', '" + txtDireccion.Text + "', '" + txtTelefono.Text + "', '" + dateFechaN.Value.ToString("dd/MM/yyyy") + "', '" + dateFechaA.Value.ToString("dd/MM/yyyy") + "' )", cn.AbrirConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Titular guardado");
                btnGuardar.Enabled = false;
            }
            if (boton == 2)
            {
                cmd = new SqlCommand("update tblCliente set nombre= '" + txtNombre.Text + "', direccion='" + txtDireccion.Text + "', telefono='" + txtTelefono.Text + "', fechaNacimiento='" + dateFechaN.Value.ToString("dd/MM/yyyy") + "', fechaAfiliacion='" + dateFechaA.Value.ToString("dd/MM/yyyy") + "' ", cn.AbrirConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Titular modificado");
                btnGuardar.Enabled = false;
            }
        }

    }
}
