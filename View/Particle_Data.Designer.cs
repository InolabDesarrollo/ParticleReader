namespace ParticleReader.View
{
    partial class Particle_Data
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
            Particle_DataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Particle_DataGridView).BeginInit();
            SuspendLayout();
            // 
            // Particle_DataGridView
            // 
            Particle_DataGridView.AllowUserToAddRows = false;
            Particle_DataGridView.AllowUserToDeleteRows = false;
            Particle_DataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Particle_DataGridView.BackgroundColor = SystemColors.Control;
            Particle_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Particle_DataGridView.GridColor = Color.White;
            Particle_DataGridView.Location = new Point(3, 3);
            Particle_DataGridView.Name = "Particle_DataGridView";
            Particle_DataGridView.RowTemplate.Height = 25;
            Particle_DataGridView.Size = new Size(912, 407);
            Particle_DataGridView.TabIndex = 0;
            // 
            // ParticleData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Particle_DataGridView);
            Name = "ParticleData";
            Size = new Size(918, 431);
            ((System.ComponentModel.ISupportInitialize)Particle_DataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Particle_DataGridView;
    }
}
