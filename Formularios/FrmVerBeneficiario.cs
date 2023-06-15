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
    public partial class FrmVerBeneficiario : Form
    {
        cConexion cn; //creando variable de la clase cConexion
        SqlCommand cmd; //variable para traer los comandos de sql
        SqlDataAdapter da; //se necesita para las consultas
        DataTable dt;
        string cedulaTitularGlb;
        // ['1', '2']
        public FrmVerBeneficiario(string cedulaTitular)
        {
            cedulaTitularGlb = cedulaTitular;
            InitializeComponent();
            cn = new cConexion();
            cmd = new SqlCommand("select cedulaBeneficiario, nombre, parentesco, fechaNacimiento from tblBeneficiario where cedula = '" + cedulaTitular + "'", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt); // llena el dt o la tabla con la consulta de cmd
        }

        private void FrmBeneficiario_Load(object sender, EventArgs e)
        {   
            dtgBeneficiarios.Rows.Add(dt.Rows.Count);
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    dtgBeneficiarios.Rows[i].Cells[j].Value = dt.Rows[i][j];
                }
            }
        }

        
    }
}
