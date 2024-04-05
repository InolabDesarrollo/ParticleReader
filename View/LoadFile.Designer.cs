namespace ParticleReader.View
{
    partial class LoadFile
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
            Btn_Load_File = new Button();
            SuspendLayout();
            // 
            // Btn_Load_File
            // 
            Btn_Load_File.BackColor = Color.FromArgb(0, 112, 192);
            Btn_Load_File.FlatStyle = FlatStyle.Flat;
            Btn_Load_File.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Load_File.ForeColor = SystemColors.Control;
            Btn_Load_File.Location = new Point(181, 174);
            Btn_Load_File.Name = "Btn_Load_File";
            Btn_Load_File.Size = new Size(174, 70);
            Btn_Load_File.TabIndex = 0;
            Btn_Load_File.Text = "LOAD FILE";
            Btn_Load_File.UseVisualStyleBackColor = false;
            Btn_Load_File.Click += Btn_Load_File_Click;
            // 
            // LoadFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(539, 426);
            Controls.Add(Btn_Load_File);
            Name = "LoadFile";
            Sizable = false;
            Text = "LoadFile";
            Load += LoadFile_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_Load_File;
    }
}