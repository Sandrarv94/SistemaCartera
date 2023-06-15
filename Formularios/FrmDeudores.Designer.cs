namespace SistemaCartera.Formularios
{
    partial class FrmDeudores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeudores));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgDeudores = new System.Windows.Forms.DataGridView();
            this.CedulaTitular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTitular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlrCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDeudores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deudores";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 10);
            this.panel1.TabIndex = 1;
            // 
            // dtgDeudores
            // 
            this.dtgDeudores.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDeudores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDeudores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CedulaTitular,
            this.NombreTitular,
            this.poliza,
            this.vlrCuota,
            this.debe});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDeudores.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgDeudores.Location = new System.Drawing.Point(4, 84);
            this.dtgDeudores.Name = "dtgDeudores";
            this.dtgDeudores.RowHeadersVisible = false;
            this.dtgDeudores.Size = new System.Drawing.Size(795, 251);
            this.dtgDeudores.TabIndex = 2;
            // 
            // CedulaTitular
            // 
            this.CedulaTitular.HeaderText = "Cédula Titular";
            this.CedulaTitular.Name = "CedulaTitular";
            this.CedulaTitular.Width = 150;
            // 
            // NombreTitular
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTitular.DefaultCellStyle = dataGridViewCellStyle2;
            this.NombreTitular.HeaderText = "Nombre Titular";
            this.NombreTitular.Name = "NombreTitular";
            this.NombreTitular.Width = 250;
            // 
            // poliza
            // 
            this.poliza.HeaderText = "Póliza";
            this.poliza.Name = "poliza";
            this.poliza.Width = 92;
            // 
            // vlrCuota
            // 
            this.vlrCuota.HeaderText = "Valor Cuota";
            this.vlrCuota.Name = "vlrCuota";
            this.vlrCuota.Width = 120;
            // 
            // debe
            // 
            this.debe.HeaderText = "Ultimo mes pagado";
            this.debe.Name = "debe";
            this.debe.Width = 180;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(4, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 109);
            this.panel2.TabIndex = 3;
            // 
            // FrmDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtgDeudores);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmDeudores";
            this.Text = "FrmDeudores";
            this.Load += new System.EventHandler(this.FrmDeudores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDeudores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgDeudores;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaTitular;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTitular;
        private System.Windows.Forms.DataGridViewTextBoxColumn poliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlrCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn debe;
        private System.Windows.Forms.Panel panel2;
    }
}