namespace Cliente_Vistas
{
    partial class M_Efan
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(M_Efan));
            this.btnBuscarFans = new System.Windows.Forms.Button();
            this.txtNomFan = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.btndesactivarfan = new System.Windows.Forms.Button();
            this.dgvFans = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFans)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("8-bit Operator+", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(174, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(126, 21);
            label1.TabIndex = 77;
            label1.Text = "ID de Usuario";
            // 
            // btnBuscarFans
            // 
            this.btnBuscarFans.BackgroundImage = global::Cliente_Vistas.Properties.Resources.icons8_búsqueda;
            this.btnBuscarFans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarFans.Location = new System.Drawing.Point(514, 15);
            this.btnBuscarFans.Name = "btnBuscarFans";
            this.btnBuscarFans.Size = new System.Drawing.Size(39, 35);
            this.btnBuscarFans.TabIndex = 79;
            this.btnBuscarFans.UseVisualStyleBackColor = true;
            this.btnBuscarFans.Click += new System.EventHandler(this.btnBuscarFans_Click);
            // 
            // txtNomFan
            // 
            this.txtNomFan.Font = new System.Drawing.Font("AcadEref", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomFan.Location = new System.Drawing.Point(317, 22);
            this.txtNomFan.Name = "txtNomFan";
            this.txtNomFan.Size = new System.Drawing.Size(191, 24);
            this.txtNomFan.TabIndex = 78;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(804, 22);
            this.statusStrip1.TabIndex = 76;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("8-bit Operator+", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(429, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 30);
            this.button1.TabIndex = 75;
            this.button1.Text = "Eliminar Cuenta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndesactivarfan
            // 
            this.btndesactivarfan.Font = new System.Drawing.Font("8-bit Operator+", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndesactivarfan.Location = new System.Drawing.Point(68, 381);
            this.btndesactivarfan.Name = "btndesactivarfan";
            this.btndesactivarfan.Size = new System.Drawing.Size(311, 30);
            this.btndesactivarfan.TabIndex = 70;
            this.btndesactivarfan.Text = "Desactivar/Habilitar Cuenta";
            this.btndesactivarfan.UseVisualStyleBackColor = true;
            this.btndesactivarfan.Click += new System.EventHandler(this.btndesactivarfan_Click);
            // 
            // dgvFans
            // 
            this.dgvFans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFans.Location = new System.Drawing.Point(26, 69);
            this.dgvFans.Name = "dgvFans";
            this.dgvFans.Size = new System.Drawing.Size(753, 291);
            this.dgvFans.TabIndex = 62;
            this.dgvFans.SelectionChanged += new System.EventHandler(this.dgvFans_SelectionChanged);
            // 
            // M_Efan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cliente_Vistas.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.btnBuscarFans);
            this.Controls.Add(this.txtNomFan);
            this.Controls.Add(label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btndesactivarfan);
            this.Controls.Add(this.dgvFans);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "M_Efan";
            this.Text = "Fan";
            this.Load += new System.EventHandler(this.M_Efan_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarFans;
        private System.Windows.Forms.TextBox txtNomFan;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btndesactivarfan;
        private System.Windows.Forms.DataGridView dgvFans;
    }
}