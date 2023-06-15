namespace SistemaCartera.Formularios
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeudores = new System.Windows.Forms.Button();
            this.btnDetallePago = new System.Windows.Forms.Button();
            this.btnPagoCuota = new System.Windows.Forms.Button();
            this.btnTitular = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPoliza = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnTitular);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 525);
            this.panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(32, 420);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 93);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDeudores);
            this.panel3.Controls.Add(this.btnDetallePago);
            this.panel3.Controls.Add(this.btnPagoCuota);
            this.panel3.Location = new System.Drawing.Point(3, 202);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 191);
            this.panel3.TabIndex = 6;
            // 
            // btnDeudores
            // 
            this.btnDeudores.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDeudores.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnDeudores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeudores.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeudores.Location = new System.Drawing.Point(3, 136);
            this.btnDeudores.Name = "btnDeudores";
            this.btnDeudores.Size = new System.Drawing.Size(167, 52);
            this.btnDeudores.TabIndex = 5;
            this.btnDeudores.Text = "Deudores";
            this.btnDeudores.UseVisualStyleBackColor = false;
            this.btnDeudores.Click += new System.EventHandler(this.btnDeudores_Click);
            // 
            // btnDetallePago
            // 
            this.btnDetallePago.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDetallePago.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnDetallePago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetallePago.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetallePago.Location = new System.Drawing.Point(0, 56);
            this.btnDetallePago.Name = "btnDetallePago";
            this.btnDetallePago.Size = new System.Drawing.Size(173, 74);
            this.btnDetallePago.TabIndex = 4;
            this.btnDetallePago.Text = "Detalle Pagos";
            this.btnDetallePago.UseVisualStyleBackColor = false;
            this.btnDetallePago.Click += new System.EventHandler(this.btnDetallePago_Click);
            // 
            // btnPagoCuota
            // 
            this.btnPagoCuota.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPagoCuota.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPagoCuota.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnPagoCuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagoCuota.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagoCuota.Location = new System.Drawing.Point(0, 0);
            this.btnPagoCuota.Name = "btnPagoCuota";
            this.btnPagoCuota.Size = new System.Drawing.Size(173, 50);
            this.btnPagoCuota.TabIndex = 3;
            this.btnPagoCuota.Text = "Pago Cuota";
            this.btnPagoCuota.UseVisualStyleBackColor = false;
            this.btnPagoCuota.Click += new System.EventHandler(this.btnPagoCuota_Click);
            // 
            // btnTitular
            // 
            this.btnTitular.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTitular.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTitular.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnTitular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitular.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitular.Location = new System.Drawing.Point(0, 86);
            this.btnTitular.Name = "btnTitular";
            this.btnTitular.Size = new System.Drawing.Size(179, 53);
            this.btnTitular.TabIndex = 1;
            this.btnTitular.Text = "Titulares";
            this.btnTitular.UseVisualStyleBackColor = false;
            this.btnTitular.Click += new System.EventHandler(this.btnTitular_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnPoliza);
            this.panel4.Location = new System.Drawing.Point(1, 145);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(178, 54);
            this.panel4.TabIndex = 7;
            // 
            // btnPoliza
            // 
            this.btnPoliza.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPoliza.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnPoliza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoliza.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoliza.Location = new System.Drawing.Point(0, 0);
            this.btnPoliza.Name = "btnPoliza";
            this.btnPoliza.Size = new System.Drawing.Size(178, 51);
            this.btnPoliza.TabIndex = 2;
            this.btnPoliza.Text = "Pólizas";
            this.btnPoliza.UseVisualStyleBackColor = false;
            this.btnPoliza.Click += new System.EventHandler(this.btnPoliza_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 86);
            this.panel2.TabIndex = 0;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.AutoSize = true;
            this.pnlContenedor.Location = new System.Drawing.Point(180, 2);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(783, 523);
            this.pnlContenedor.TabIndex = 1;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(964, 525);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTitular;
        private System.Windows.Forms.Button btnPoliza;
        private System.Windows.Forms.Button btnPagoCuota;
        private System.Windows.Forms.Button btnDetallePago;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnDeudores;
    }
}