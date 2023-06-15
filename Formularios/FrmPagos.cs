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

namespace SistemaCartera.Formularios
{
    public partial class FrmPagos : Form
    {
        cConexion cn; //creando variable de la clase cConexion
        SqlCommand cmd; //variable para traer los comandos de sql
        SqlDataAdapter da; //se necesita para las consultas
        DataTable dt;
        public FrmPagos()
        {
            InitializeComponent();
            cn = new cConexion();
        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select max(idRecibo) from tblRecibo", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            lblNumRecibo.Text = Convert.ToString(Convert.ToInt32(dt.Rows[0][0].ToString())+1);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into tblRecibo values('" + lblNumRecibo.Text + "','" + txtPoliza.Text + "', '" + txtValorAbonado.Text + "', '" + dateFecha.Value.ToString("dd/MM/yyyy") + "', '" + cmbMesCuota.Text + "')", cn.AbrirConexion());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Recibo guardado");
        }

        private void txtPoliza_Leave(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from tblPoliza where idPoliza = '" + txtPoliza.Text + "'", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            txtValorAbonado.Text = dt.Rows[0][1].ToString();
            
        }
    }
}
