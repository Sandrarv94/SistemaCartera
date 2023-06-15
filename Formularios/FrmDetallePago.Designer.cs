namespace SistemaCartera.Formularios
{
    partial class FrmDetallePago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCTitular = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPoliza = new System.Windows.Forms.TextBox();
            this.dtgDetallePagos = new System.Windows.Forms.DataGridView();
            this.IdRecibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlrAbonado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRecibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtvlrCuota = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetallePagos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte Pagos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 10);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cédula Titular";
            // 
            // txtCTitular
            // 
            this.txtCTitular.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCTitular.Location = new System.Drawing.Point(180, 100);
            this.txtCTitular.Name = "txtCTitular";
            this.txtCTitular.Size = new System.Drawing.Size(188, 28);
            this.txtCTitular.TabIndex = 3;
            this.txtCTitular.Leave += new System.EventHandler(this.txtCTitular_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Póliza";
            // 
            // txtPoliza
            // 
            this.txtPoliza.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoliza.Location = new System.Drawing.Point(106, 147);
            this.txtPoliza.Name = "txtPoliza";
            this.txtPoliza.Size = new System.Drawing.Size(116, 28);
            this.txtPoliza.TabIndex = 5;
            // 
            // dtgDetallePagos
            // 
            this.dtgDetallePagos.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dtgDetallePagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetallePagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRecibo,
            this.vlrAbonado,
            this.fechaRecibo,
            this.mesCuota});
            this.dtgDetallePagos.Location = new System.Drawing.Point(0, 195);
            this.dtgDetallePagos.Name = "dtgDetallePagos";
            this.dtgDetallePagos.RowHeadersVisible = false;
            this.dtgDetallePagos.Size = new System.Drawing.Size(792, 243);
            this.dtgDetallePagos.TabIndex = 6;
            // 
            // IdRecibo
            // 
            this.IdRecibo.HeaderText = "N° Recibo";
            this.IdRecibo.Name = "IdRecibo";
            // 
            // vlrAbonado
            // 
            this.vlrAbonado.HeaderText = "Valor Abonado";
            this.vlrAbonado.Name = "vlrAbonado";
            this.vlrAbonado.Width = 190;
            // 
            // fechaRecibo
            // 
            this.fechaRecibo.HeaderText = "Fecha Recibo";
            this.fechaRecibo.Name = "fechaRecibo";
            this.fechaRecibo.Width = 240;
            // 
            // mesCuota
            // 
            this.mesCuota.HeaderText = "Mes Pagado";
            this.mesCuota.Name = "mesCuota";
            this.mesCuota.Width = 250;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor ";
            // 
            // txtvlrCuota
            // 
            this.txtvlrCuota.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvlrCuota.Location = new System.Drawing.Point(315, 143);
            this.txtvlrCuota.Name = "txtvlrCuota";
            this.txtvlrCuota.Size = new System.Drawing.Size(116, 28);
            this.txtvlrCuota.TabIndex = 8;
            // 
            // btnGenerar
            // 
            this.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(511, 137);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(253, 47);
            this.btnGenerar.TabIndex = 9;
            this.btnGenerar.Text = "Generar Reporte de Pagos";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // FrmDetallePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtvlrCuota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgDetallePagos);
            this.Controls.Add(this.txtPoliza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCTitular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmDetallePago";
            this.Text = "FrmDetallePago";
            this.Load += new System.EventHandler(this.FrmDetallePago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetallePagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCTitular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPoliza;
        private System.Windows.Forms.DataGridView dtgDetallePagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlrAbonado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesCuota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtvlrCuota;
        private System.Windows.Forms.Button btnGenerar;
    }
}