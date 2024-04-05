using ExcelDataReader;
using MaterialSkin;
using MaterialSkin.Controls;
using OfficeOpenXml;
using ParticleReader.Responsabilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleReader.View
{
    public partial class LoadFile : MaterialForm
    {
        public DataTable ParticleData;
        public DataTable SampleInformation;
        public LoadFile()
        {
            InitializeComponent();
        }

        private void LoadFile_Load(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue700,
                Primary.Blue700, Accent.LightBlue100, TextShade.WHITE);
        }

        private void Btn_Load_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            string path = openFileDialog.FileName.ToString();
            DataFile dataFile = new DataFile();
            bool fileIsValid = dataFile.checkIfFileIsValid(path);        
            if (fileIsValid)
            {
                try
                {
                    this.readExcelFile(path);
                }
                catch(Exception)
                {
                    MessageBox.Show("Elige un archivo excell con el formato correcto");
                }

                MainMenu menu = new MainMenu(ParticleData, SampleInformation);
                menu.Show();
                this.Hide();
            }           
        }

        public void readExcelFile(string path)
        {
            var stream = File.Open(path, FileMode.Open, FileAccess.Read);
            var reader = ExcelReaderFactory.CreateReader(stream);
            var result = reader.AsDataSet();
            var tables = result.Tables.Cast<DataTable>();

            foreach (DataTable table in tables)
            {
                if (table.ToString() == "Data")
                {
                    ParticleData = table;
                }
                if (table.ToString() == "Sample Info")
                {
                    SampleInformation = table;
                }
            }
        }

    }
}
