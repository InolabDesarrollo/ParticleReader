namespace ParticleReader.View
{
    partial class Accumulated_Differential
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Dgv_ASTM95_Accumulated = new DataGridView();
            Particle_Size = new DataGridViewTextBoxColumn();
            Mesh = new DataGridViewTextBoxColumn();
            Dgv_ASTM95_Differential = new DataGridView();
            Dgv_Single_Aperture_Accumulated = new DataGridView();
            Particle_Size_ = new DataGridViewTextBoxColumn();
            Mesh_ = new DataGridViewTextBoxColumn();
            Dgv_Single_Aperture_Differential = new DataGridView();
            Lbl_ASTM95 = new Label();
            Lbl_Single_Aperture = new Label();
            Btn_Hide_Cumulatives = new Button();
            Btn_Hide_Differential = new Button();
            Lbl_Accumulated = new Label();
            label1 = new Label();
            Lbl_Differential = new Label();
            Lbl_Diferential = new Label();
            Btn_Generate_Report = new Button();
            ((System.ComponentModel.ISupportInitialize)Dgv_ASTM95_Accumulated).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_ASTM95_Differential).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_Single_Aperture_Accumulated).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_Single_Aperture_Differential).BeginInit();
            SuspendLayout();
            // 
            // Dgv_ASTM95_Accumulated
            // 
            Dgv_ASTM95_Accumulated.BackgroundColor = Color.FromArgb(218, 238, 243);
            Dgv_ASTM95_Accumulated.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_ASTM95_Accumulated.Columns.AddRange(new DataGridViewColumn[] { Particle_Size, Mesh });
            Dgv_ASTM95_Accumulated.Location = new Point(33, 76);
            Dgv_ASTM95_Accumulated.Name = "Dgv_ASTM95_Accumulated";
            Dgv_ASTM95_Accumulated.RowTemplate.Height = 25;
            Dgv_ASTM95_Accumulated.Size = new Size(399, 143);
            Dgv_ASTM95_Accumulated.TabIndex = 3;
            // 
            // Particle_Size
            // 
            Particle_Size.HeaderText = "Particle Size (micron)";
            Particle_Size.Name = "Particle_Size";
            // 
            // Mesh
            // 
            Mesh.HeaderText = "Mesh";
            Mesh.Name = "Mesh";
            // 
            // Dgv_ASTM95_Differential
            // 
            Dgv_ASTM95_Differential.BackgroundColor = Color.FromArgb(218, 238, 243);
            Dgv_ASTM95_Differential.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_ASTM95_Differential.Location = new Point(33, 255);
            Dgv_ASTM95_Differential.Name = "Dgv_ASTM95_Differential";
            Dgv_ASTM95_Differential.RowTemplate.Height = 25;
            Dgv_ASTM95_Differential.Size = new Size(399, 127);
            Dgv_ASTM95_Differential.TabIndex = 4;
            // 
            // Dgv_Single_Aperture_Accumulated
            // 
            Dgv_Single_Aperture_Accumulated.BackgroundColor = Color.FromArgb(218, 238, 243);
            Dgv_Single_Aperture_Accumulated.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Single_Aperture_Accumulated.Columns.AddRange(new DataGridViewColumn[] { Particle_Size_, Mesh_ });
            Dgv_Single_Aperture_Accumulated.Location = new Point(476, 76);
            Dgv_Single_Aperture_Accumulated.Name = "Dgv_Single_Aperture_Accumulated";
            Dgv_Single_Aperture_Accumulated.RowTemplate.Height = 25;
            Dgv_Single_Aperture_Accumulated.Size = new Size(399, 143);
            Dgv_Single_Aperture_Accumulated.TabIndex = 5;
            // 
            // Particle_Size_
            // 
            Particle_Size_.HeaderText = "Particle Size (micron)";
            Particle_Size_.Name = "Particle_Size_";
            // 
            // Mesh_
            // 
            Mesh_.HeaderText = "Mesh";
            Mesh_.Name = "Mesh_";
            // 
            // Dgv_Single_Aperture_Differential
            // 
            Dgv_Single_Aperture_Differential.BackgroundColor = Color.FromArgb(218, 238, 243);
            Dgv_Single_Aperture_Differential.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Single_Aperture_Differential.Location = new Point(476, 255);
            Dgv_Single_Aperture_Differential.Name = "Dgv_Single_Aperture_Differential";
            Dgv_Single_Aperture_Differential.RowTemplate.Height = 25;
            Dgv_Single_Aperture_Differential.Size = new Size(399, 127);
            Dgv_Single_Aperture_Differential.TabIndex = 6;
            // 
            // Lbl_ASTM95
            // 
            Lbl_ASTM95.AutoSize = true;
            Lbl_ASTM95.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_ASTM95.ForeColor = SystemColors.Control;
            Lbl_ASTM95.Location = new Point(144, 19);
            Lbl_ASTM95.Name = "Lbl_ASTM95";
            Lbl_ASTM95.Size = new Size(89, 25);
            Lbl_ASTM95.TabIndex = 7;
            Lbl_ASTM95.Text = "ASTM_95";
            // 
            // Lbl_Single_Aperture
            // 
            Lbl_Single_Aperture.AutoSize = true;
            Lbl_Single_Aperture.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Single_Aperture.ForeColor = SystemColors.Control;
            Lbl_Single_Aperture.Location = new Point(559, 19);
            Lbl_Single_Aperture.Name = "Lbl_Single_Aperture";
            Lbl_Single_Aperture.Size = new Size(143, 25);
            Lbl_Single_Aperture.TabIndex = 8;
            Lbl_Single_Aperture.Text = "Single Aperture";
            // 
            // Btn_Hide_Cumulatives
            // 
            Btn_Hide_Cumulatives.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Hide_Cumulatives.Location = new Point(630, 391);
            Btn_Hide_Cumulatives.Margin = new Padding(1, 3, 3, 3);
            Btn_Hide_Cumulatives.Name = "Btn_Hide_Cumulatives";
            Btn_Hide_Cumulatives.Size = new Size(114, 37);
            Btn_Hide_Cumulatives.TabIndex = 9;
            Btn_Hide_Cumulatives.Text = "Hide Cumulatives";
            Btn_Hide_Cumulatives.UseVisualStyleBackColor = true;
            // 
            // Btn_Hide_Differential
            // 
            Btn_Hide_Differential.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Hide_Differential.Location = new Point(761, 391);
            Btn_Hide_Differential.Margin = new Padding(1, 3, 3, 3);
            Btn_Hide_Differential.Name = "Btn_Hide_Differential";
            Btn_Hide_Differential.Size = new Size(114, 37);
            Btn_Hide_Differential.TabIndex = 10;
            Btn_Hide_Differential.Text = "Hide_Differential";
            Btn_Hide_Differential.UseVisualStyleBackColor = true;
            // 
            // Lbl_Accumulated
            // 
            Lbl_Accumulated.AutoSize = true;
            Lbl_Accumulated.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Accumulated.ForeColor = SystemColors.Control;
            Lbl_Accumulated.Location = new Point(144, 53);
            Lbl_Accumulated.Name = "Lbl_Accumulated";
            Lbl_Accumulated.Size = new Size(91, 20);
            Lbl_Accumulated.TabIndex = 11;
            Lbl_Accumulated.Text = "Acumulados";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(586, 53);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 12;
            label1.Text = "Acumulados";
            // 
            // Lbl_Differential
            // 
            Lbl_Differential.AutoSize = true;
            Lbl_Differential.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Differential.ForeColor = SystemColors.Control;
            Lbl_Differential.Location = new Point(144, 232);
            Lbl_Differential.Name = "Lbl_Differential";
            Lbl_Differential.Size = new Size(81, 20);
            Lbl_Differential.TabIndex = 13;
            Lbl_Differential.Text = "Diferencial";
            // 
            // Lbl_Diferential
            // 
            Lbl_Diferential.AutoSize = true;
            Lbl_Diferential.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Diferential.ForeColor = SystemColors.Control;
            Lbl_Diferential.Location = new Point(586, 232);
            Lbl_Diferential.Name = "Lbl_Diferential";
            Lbl_Diferential.Size = new Size(81, 20);
            Lbl_Diferential.TabIndex = 14;
            Lbl_Diferential.Text = "Diferencial";
            // 
            // Btn_Generate_Report
            // 
            Btn_Generate_Report.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Generate_Report.Location = new Point(494, 391);
            Btn_Generate_Report.Name = "Btn_Generate_Report";
            Btn_Generate_Report.Size = new Size(127, 37);
            Btn_Generate_Report.TabIndex = 15;
            Btn_Generate_Report.Text = "Generate Report";
            Btn_Generate_Report.UseVisualStyleBackColor = true;
            Btn_Generate_Report.Click += Btn_Generate_Report_Click;
            // 
            // Accumulated_Differential
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 112, 192);
            Controls.Add(Btn_Generate_Report);
            Controls.Add(Lbl_Diferential);
            Controls.Add(Lbl_Differential);
            Controls.Add(label1);
            Controls.Add(Lbl_Accumulated);
            Controls.Add(Btn_Hide_Differential);
            Controls.Add(Btn_Hide_Cumulatives);
            Controls.Add(Lbl_Single_Aperture);
            Controls.Add(Lbl_ASTM95);
            Controls.Add(Dgv_Single_Aperture_Differential);
            Controls.Add(Dgv_Single_Aperture_Accumulated);
            Controls.Add(Dgv_ASTM95_Differential);
            Controls.Add(Dgv_ASTM95_Accumulated);
            Name = "Accumulated_Differential";
            Size = new Size(922, 431);
            ((System.ComponentModel.ISupportInitialize)Dgv_ASTM95_Accumulated).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_ASTM95_Differential).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_Single_Aperture_Accumulated).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_Single_Aperture_Differential).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Dgv_ASTM95_Accumulated;
        private DataGridView Dgv_ASTM95_Differential;
        private DataGridView Dgv_Single_Aperture_Accumulated;
        private DataGridView Dgv_Single_Aperture_Differential;
        private Label Lbl_ASTM95;
        private Label Lbl_Single_Aperture;
        private Button Btn_Hide_Cumulatives;
        private Button Btn_Hide_Differential;
        private DataGridViewTextBoxColumn Particle_Size;
        private DataGridViewTextBoxColumn Mesh;
        private DataGridViewTextBoxColumn Particle_Size_;
        private DataGridViewTextBoxColumn Mesh_;
        private Label Lbl_Accumulated;
        private Label label1;
        private Label Lbl_Differential;
        private Label Lbl_Diferential;
        private Button Btn_Generate_Report;
    }
}
