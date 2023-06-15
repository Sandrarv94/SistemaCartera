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


namespace SistemaCartera.Formularios
{
    public partial class FrmAgregarBeneficiario : Form
    {
        string cedulaTitularGlb;
        cConexion cn; //creando variable de la clase cConexion
        int i, boton, contador;
        SqlCommand cmd; //variable para traer los comandos de sql
        SqlDataAdapter da; //se necesita para las consultas
        DataTable dt;
        public FrmAgregarBeneficiario(string cedulaTitular)
        {
            cedulaTitularGlb = cedulaTitular;
            InitializeComponent();
            cn = new cConexion();
            i = 0; boton = 0;
            cmd = new SqlCommand("select cedulaBeneficiario, nombre, parentesco, fechaNacimiento from tblBeneficiario where cedula = '" + cedulaTitular + "'", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt); // llena el dt o la tabla con la consulta de cmd
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            boton = 1;
            limpia();
            habilita();
            txtCedulaBeneficiario.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            boton = 2;
            limpia();
            habilita();
            txtCedulaBeneficiario.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            boton = 3;
            limpia();
            txtCedulaBeneficiario.Enabled = true;
            txtCedulaBeneficiario.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            boton = 4;
            limpia();
            txtCedulaBeneficiario.Enabled = true;
            txtCedulaBeneficiario.Focus();
        }

        void habilita()
        {
            txtCcTitular.Enabled = true;
            txtCedulaBeneficiario.Enabled = true;
            txtParentesco.Enabled = true;
            txtNombreBeneficiario.Enabled = true;
            dateFechaNacimiento.Enabled = true;

        }

        void deshabilita()
        {
            txtCcTitular.Enabled = false;
            txtCedulaBeneficiario.Enabled = false;
            txtParentesco.Enabled = false;
            txtNombreBeneficiario.Enabled = false;
            dateFechaNacimiento.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (boton == 1)
            {
                cmd = new SqlCommand("insert into tblBeneficiario values('" + txtCedulaBeneficiario.Text + "', '" + txtNombreBeneficiario.Text + "','" + txtParentesco.Text + "','" + dateFechaNacimiento.Value.ToString("dd/MM/yyyy") + "', '" + txtCcTitular.Text + "'  )", cn.AbrirConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Beneficiario guardado");
                btnGuardar.Enabled = false;
            }
            if (boton == 2)
            {
                cmd = new SqlCommand("update tblBeneficiario set nombre= '" + txtNombreBeneficiario.Text + "', parentesco='" + txtParentesco.Text + "' , fechaNacimiento='" + dateFechaNacimiento.Value.ToString("dd/MM/yyyy") + "' ", cn.AbrirConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Beneficiario modificado");
                btnGuardar.Enabled = false;
            }
        }

        void llenar(DataTable dt, int i)
        {

            txtCcTitular.Text = dt.Rows[i][0].ToString();
            //almacena la cantidad de registros de la tabla
            contador = dt.Rows.Count;
        }

        void limpia()
        {
            txtCcTitular.Clear();
            txtCedulaBeneficiario.Clear();
            txtNombreBeneficiario.Clear();
            
        }
    }
}
