namespace ParticleReader.View
{
    partial class Mesh_Selection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mesh_Selection));
            Lbl_Mesh_Selection = new Label();
            ComboBox_Mesh = new ComboBox();
            Dgv_ASTM95 = new DataGridView();
            Nominal_Sieve_Size = new DataGridViewTextBoxColumn();
            Mesh = new DataGridViewTextBoxColumn();
            Dgv_Single_Aperture = new DataGridView();
            Nominal_Sieve_Size_SA = new DataGridViewTextBoxColumn();
            Mesh_SA = new DataGridViewTextBoxColumn();
            Lbl_ASTM95 = new Label();
            Lbl_Single_Aperture = new Label();
            Btn_Clean_Data = new Button();
            Selected_Meshes_ASTM95 = new DataGridView();
            Particle_Size = new DataGridViewTextBoxColumn();
            Mesh_1 = new DataGridViewTextBoxColumn();
            DetectorNumber = new DataGridViewTextBoxColumn();
            Lbl_Selected_Meshes = new Label();
            Selected_Meshes_Single_Aperture = new DataGridView();
            Particle_Size_SA = new DataGridViewTextBoxColumn();
            Mesh_2 = new DataGridViewTextBoxColumn();
            Detector__Number = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Dgv_ASTM95).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_Single_Aperture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Selected_Meshes_ASTM95).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Selected_Meshes_Single_Aperture).BeginInit();
            SuspendLayout();
            // 
            // Lbl_Mesh_Selection
            // 
            resources.ApplyResources(Lbl_Mesh_Selection, "Lbl_Mesh_Selection");
            Lbl_Mesh_Selection.ForeColor = SystemColors.ControlLight;
            Lbl_Mesh_Selection.Name = "Lbl_Mesh_Selection";
            // 
            // ComboBox_Mesh
            // 
            ComboBox_Mesh.Items.AddRange(new object[] { resources.GetString("ComboBox_Mesh.Items"), resources.GetString("ComboBox_Mesh.Items1"), resources.GetString("ComboBox_Mesh.Items2"), resources.GetString("ComboBox_Mesh.Items3"), resources.GetString("ComboBox_Mesh.Items4"), resources.GetString("ComboBox_Mesh.Items5"), resources.GetString("ComboBox_Mesh.Items6"), resources.GetString("ComboBox_Mesh.Items7"), resources.GetString("ComboBox_Mesh.Items8"), resources.GetString("ComboBox_Mesh.Items9"), resources.GetString("ComboBox_Mesh.Items10"), resources.GetString("ComboBox_Mesh.Items11"), resources.GetString("ComboBox_Mesh.Items12"), resources.GetString("ComboBox_Mesh.Items13"), resources.GetString("ComboBox_Mesh.Items14"), resources.GetString("ComboBox_Mesh.Items15"), resources.GetString("ComboBox_Mesh.Items16"), resources.GetString("ComboBox_Mesh.Items17"), resources.GetString("ComboBox_Mesh.Items18"), resources.GetString("ComboBox_Mesh.Items19"), resources.GetString("ComboBox_Mesh.Items20"), resources.GetString("ComboBox_Mesh.Items21"), resources.GetString("ComboBox_Mesh.Items22"), resources.GetString("ComboBox_Mesh.Items23"), resources.GetString("ComboBox_Mesh.Items24"), resources.GetString("ComboBox_Mesh.Items25"), resources.GetString("ComboBox_Mesh.Items26"), resources.GetString("ComboBox_Mesh.Items27"), resources.GetString("ComboBox_Mesh.Items28"), resources.GetString("ComboBox_Mesh.Items29") });
            resources.ApplyResources(ComboBox_Mesh, "ComboBox_Mesh");
            ComboBox_Mesh.Name = "ComboBox_Mesh";
            ComboBox_Mesh.SelectedIndexChanged += ComboBox_Mesh_SelectedIndexChanged_1;
            // 
            // Dgv_ASTM95
            // 
            resources.ApplyResources(Dgv_ASTM95, "Dgv_ASTM95");
            Dgv_ASTM95.BackgroundColor = Color.FromArgb(218, 238, 243);
            Dgv_ASTM95.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_ASTM95.Columns.AddRange(new DataGridViewColumn[] { Nominal_Sieve_Size, Mesh });
            Dgv_ASTM95.Name = "Dgv_ASTM95";
            Dgv_ASTM95.RowTemplate.Height = 25;
            // 
            // Nominal_Sieve_Size
            // 
            resources.ApplyResources(Nominal_Sieve_Size, "Nominal_Sieve_Size");
            Nominal_Sieve_Size.Name = "Nominal_Sieve_Size";
            // 
            // Mesh
            // 
            resources.ApplyResources(Mesh, "Mesh");
            Mesh.Name = "Mesh";
            // 
            // Dgv_Single_Aperture
            // 
            resources.ApplyResources(Dgv_Single_Aperture, "Dgv_Single_Aperture");
            Dgv_Single_Aperture.BackgroundColor = Color.FromArgb(218, 238, 243);
            Dgv_Single_Aperture.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Single_Aperture.Columns.AddRange(new DataGridViewColumn[] { Nominal_Sieve_Size_SA, Mesh_SA });
            Dgv_Single_Aperture.Name = "Dgv_Single_Aperture";
            Dgv_Single_Aperture.RowTemplate.Height = 25;
            // 
            // Nominal_Sieve_Size_SA
            // 
            resources.ApplyResources(Nominal_Sieve_Size_SA, "Nominal_Sieve_Size_SA");
            Nominal_Sieve_Size_SA.Name = "Nominal_Sieve_Size_SA";
            // 
            // Mesh_SA
            // 
            resources.ApplyResources(Mesh_SA, "Mesh_SA");
            Mesh_SA.Name = "Mesh_SA";
            // 
            // Lbl_ASTM95
            // 
            resources.ApplyResources(Lbl_ASTM95, "Lbl_ASTM95");
            Lbl_ASTM95.ForeColor = SystemColors.ControlLight;
            Lbl_ASTM95.Name = "Lbl_ASTM95";
            // 
            // Lbl_Single_Aperture
            // 
            resources.ApplyResources(Lbl_Single_Aperture, "Lbl_Single_Aperture");
            Lbl_Single_Aperture.ForeColor = SystemColors.ControlLight;
            Lbl_Single_Aperture.Name = "Lbl_Single_Aperture";
            // 
            // Btn_Clean_Data
            // 
            resources.ApplyResources(Btn_Clean_Data, "Btn_Clean_Data");
            Btn_Clean_Data.Name = "Btn_Clean_Data";
            Btn_Clean_Data.UseVisualStyleBackColor = true;
            Btn_Clean_Data.Click += Btn_Clean_Data_Click;
            // 
            // Selected_Meshes_ASTM95
            // 
            Selected_Meshes_ASTM95.BackgroundColor = Color.FromArgb(218, 238, 243);
            Selected_Meshes_ASTM95.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Selected_Meshes_ASTM95.Columns.AddRange(new DataGridViewColumn[] { Particle_Size, Mesh_1, DetectorNumber });
            resources.ApplyResources(Selected_Meshes_ASTM95, "Selected_Meshes_ASTM95");
            Selected_Meshes_ASTM95.Name = "Selected_Meshes_ASTM95";
            Selected_Meshes_ASTM95.RowTemplate.Height = 25;
            // 
            // Particle_Size
            // 
            resources.ApplyResources(Particle_Size, "Particle_Size");
            Particle_Size.Name = "Particle_Size";
            // 
            // Mesh_1
            // 
            resources.ApplyResources(Mesh_1, "Mesh_1");
            Mesh_1.Name = "Mesh_1";
            // 
            // DetectorNumber
            // 
            resources.ApplyResources(DetectorNumber, "DetectorNumber");
            DetectorNumber.Name = "DetectorNumber";
            // 
            // Lbl_Selected_Meshes
            // 
            resources.ApplyResources(Lbl_Selected_Meshes, "Lbl_Selected_Meshes");
            Lbl_Selected_Meshes.ForeColor = SystemColors.ControlLight;
            Lbl_Selected_Meshes.Name = "Lbl_Selected_Meshes";
            // 
            // Selected_Meshes_Single_Aperture
            // 
            Selected_Meshes_Single_Aperture.BackgroundColor = Color.FromArgb(218, 238, 243);
            Selected_Meshes_Single_Aperture.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Selected_Meshes_Single_Aperture.Columns.AddRange(new DataGridViewColumn[] { Particle_Size_SA, Mesh_2, Detector__Number });
            resources.ApplyResources(Selected_Meshes_Single_Aperture, "Selected_Meshes_Single_Aperture");
            Selected_Meshes_Single_Aperture.Name = "Selected_Meshes_Single_Aperture";
            Selected_Meshes_Single_Aperture.RowTemplate.Height = 25;
            // 
            // Particle_Size_SA
            // 
            resources.ApplyResources(Particle_Size_SA, "Particle_Size_SA");
            Particle_Size_SA.Name = "Particle_Size_SA";
            // 
            // Mesh_2
            // 
            resources.ApplyResources(Mesh_2, "Mesh_2");
            Mesh_2.Name = "Mesh_2";
            // 
            // Detector__Number
            // 
            resources.ApplyResources(Detector__Number, "Detector__Number");
            Detector__Number.Name = "Detector__Number";
            // 
            // Mesh_Selection
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 112, 192);
            Controls.Add(Selected_Meshes_Single_Aperture);
            Controls.Add(Lbl_Selected_Meshes);
            Controls.Add(Selected_Meshes_ASTM95);
            Controls.Add(Btn_Clean_Data);
            Controls.Add(Lbl_Single_Aperture);
            Controls.Add(Lbl_ASTM95);
            Controls.Add(Dgv_Single_Aperture);
            Controls.Add(Dgv_ASTM95);
            Controls.Add(ComboBox_Mesh);
            Controls.Add(Lbl_Mesh_Selection);
            Name = "Mesh_Selection";
            ((System.ComponentModel.ISupportInitialize)Dgv_ASTM95).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_Single_Aperture).EndInit();
            ((System.ComponentModel.ISupportInitialize)Selected_Meshes_ASTM95).EndInit();
            ((System.ComponentModel.ISupportInitialize)Selected_Meshes_Single_Aperture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label Lbl_Mesh_Selection;
        private ComboBox ComboBox_Mesh;
        private DataGridView Dgv_ASTM95;
        private DataGridView Dgv_Single_Aperture;
        private Label Lbl_ASTM95;
        private Label Lbl_Single_Aperture;
        private Button Btn_Clean_Data;
        private DataGridView Selected_Meshes_ASTM95;
        private Label Lbl_Selected_Meshes;
        private DataGridView Selected_Meshes_Single_Aperture;
        private DataGridViewTextBoxColumn Particle_Size;
        private DataGridViewTextBoxColumn Mesh_1;
        private DataGridViewTextBoxColumn DetectorNumber;
        private DataGridViewTextBoxColumn Particle_Size_SA;
        private DataGridViewTextBoxColumn Mesh_2;
        private DataGridViewTextBoxColumn Detector__Number;
        private DataGridViewTextBoxColumn Nominal_Sieve_Size;
        private DataGridViewTextBoxColumn Mesh;
        private DataGridViewTextBoxColumn Nominal_Sieve_Size_SA;
        private DataGridViewTextBoxColumn Mesh_SA;
    }
}
