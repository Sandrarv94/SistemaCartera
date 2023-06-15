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
    public partial class FrmDetallePago : Form
    {
        cConexion cn; //creando variable de la clase cConexion
        SqlCommand cmd; //variable para traer los comandos de sql
        SqlDataAdapter da; //se necesita para las consultas
        DataTable dt;
        public FrmDetallePago()
        {
            InitializeComponent();
            cn = new cConexion();
            
        }

        private void FrmDetallePago_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select idRecibo, vlrAbonado, fecha, mesCuota from tblRecibo where idPoliza = '" + txtPoliza.Text + "'", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            dtgDetallePagos.Rows.Add(dt.Rows.Count);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    dtgDetallePagos.Rows[i].Cells[j].Value = dt.Rows[i][j].ToString();
                }
            }
        }

        private void txtCTitular_Leave(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from tblPoliza where cedula = '" + txtCTitular.Text + "'", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            txtPoliza.Text = dt.Rows[0][0].ToString();
            txtvlrCuota.Text = dt.Rows[0][1].ToString();
        }
    }
}
