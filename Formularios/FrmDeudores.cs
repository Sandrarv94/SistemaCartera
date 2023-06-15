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
    public partial class FrmDeudores : Form
    {
        cConexion cn; //creando variable de la clase cConexion
        SqlCommand cmd; //variable para traer los comandos de sql
        SqlDataAdapter da; //se necesita para las consultas
        DataTable dt;
        string[] meses = new string[12] { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };
        public FrmDeudores()
        {
            InitializeComponent();
            cn = new cConexion();

            cmd = new SqlCommand("select c.cedula, c.nombre, r.IdPoliza, r.vlrAbonado, r.mesCuota, p.vlrCuota, r.IdRecibo from tblCliente c, tblRecibo r, tblPoliza p where p.IdPoliza = r.IdPoliza AND p.cedula = c.cedula ORDER BY c.cedula, r.IdRecibo", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt); // llena el dt o la tabla con la consulta de cmd
        }
        
        private void FrmDeudores_Load(object sender, EventArgs e)
        {
            
            dtgDeudores.Rows.Add(dt.Rows.Count);

            var filaActual = dt.Rows[0];
            var count = 0;
            var mes = DateTime.Now.ToString("MM");
            var mesActual = meses[Int32.Parse(mes) - 1];
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                var cedulaActual = filaActual[0];
                var proximaCedula = dt.Rows[i][0];
                if (!cedulaActual.Equals(proximaCedula))
                {
                    // validar filaActual
                    var mesCliente = filaActual[4].ToString();
                    var abono = Int32.Parse(filaActual[3].ToString());
                    var cuota = Int32.Parse(filaActual[5].ToString());
                    if (mesCliente.ToLower() != mesActual.ToLower() && abono < cuota)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            
                            dtgDeudores.Rows[count].Cells[j].Value = filaActual[j];
                        }

                    }
                    
                    
                } else
                {
                    filaActual = dt.Rows[i];
                }
                

            }

            for (int j = 0; j < 5; j++)
            {
                dtgDeudores.Rows[count].Cells[j].Value = dt.Rows[dt.Rows.Count - 1][j];
            }

            for (int i = 0; i <dtgDeudores.Rows.Count ; i ++)
            {

                DataGridViewRow row = dtgDeudores.Rows[i];

                if (row.Cells[i].Value == DBNull.Value)
                    dtgDeudores.Rows.Remove(row);
            }
            

        }
    }
}
