using SistemaCartera.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCartera.Formularios
{
    public partial class FrmPoliza : Form
    {
        cConexion cn; //creando variable de la clase cConexion
        int i, boton, contador;
        SqlCommand cmd; //variable para traer los comandos de sql
        SqlDataAdapter da; //se necesita para las consultas
        DataTable dt;
        public FrmPoliza()
        {
            InitializeComponent();
            cn = new cConexion();
            i = 0; boton = 0;
            cmd = new SqlCommand("select * from tblPoliza", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt); // llena el dt o la tabla con la consulta de cmd
        }

       
        private void FrmPoliza_Load(object sender, EventArgs e)
        {
            llenar(dt, i);
        }
        void llenar(DataTable dt, int i)
        {
            
            txtIdPoliza.Text = dt.Rows[i][0].ToString();
            txtvlrCuota.Text = dt.Rows[i][1].ToString();
            txtCedulaTitular.Text = dt.Rows[i][2].ToString();
           
            //almacena la cantidad de registros de la tabla
            contador = dt.Rows.Count;
        }

        private void txtIdPoliza_Leave(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from tblPoliza where IdPoliza = '" + txtIdPoliza.Text + "'", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                switch (boton)
                {
                    case 1:

                        llenar(dt, 0);
                        MessageBox.Show("Ya está la póliza");
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
                        if (MessageBox.Show("Desea eliminar la póliza?", "Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SqlCommand cm = new SqlCommand("delete from tblPoliza where IdPoliza = '" + txtIdPoliza.Text + "'", cn.AbrirConexion());
                            cm.ExecuteNonQuery();
                        }
                        break;

                }
            }
            else
            {
                MessageBox.Show("La póliza no existe");
            }
        }

        void habilita()
        {
            txtCedulaTitular.Enabled = true;
            txtIdPoliza.Enabled = true;
            txtvlrCuota.Enabled = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            boton = 1;
            limpia();
            habilita();
            txtIdPoliza.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            boton = 2;
            limpia();
            habilita();
            txtIdPoliza.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            boton = 3;
            limpia();
            txtIdPoliza.Enabled = true;
            txtIdPoliza.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            boton = 4;
            limpia();
            txtIdPoliza.Enabled = true;
            txtIdPoliza.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (boton == 1)
            {
                cmd = new SqlCommand("insert into tblPoliza values('" + txtIdPoliza.Text + "', '" + txtvlrCuota.Text + "', '" + txtCedulaTitular.Text + "' )", cn.AbrirConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Póliza guardada");
                btnGuardar.Enabled = false;
            }
            if (boton == 2)
            {
                cmd = new SqlCommand("update tblCliente set vlrCuota= '" + txtvlrCuota.Text + "', cedula='" + txtCedulaTitular.Text + "' ", cn.AbrirConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Póliza modificada");
                btnGuardar.Enabled = false;
            }
        }

        void deshabilita()
        {
            txtCedulaTitular.Enabled = false;
            txtIdPoliza.Enabled = false;
            txtvlrCuota.Enabled = false;
        }
        void limpia()
        {
            txtIdPoliza.Clear();
            txtvlrCuota.Clear();
            txtCedulaTitular.Clear();
            
        }
    }
}
