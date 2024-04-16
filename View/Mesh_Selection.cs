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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ParticleReader.View
{
    public partial class Mesh_Selection : UserControl
    {
        private readonly DataTable particleData;
        private readonly DataTable sampleInformation;
        private DataTable referenceData;
        private ManageData manageData;
        private Responsabilities.Particle_Data particle_data;

        public static DataTable astm95Information;
        public static DataTable singleApertureInformation;
        public Mesh_Selection(DataTable particleData, DataTable sampleInformation)
        {
            InitializeComponent();
            this.particleData = particleData;
            this.sampleInformation = sampleInformation;
            manageData = new ManageData();
            referenceData = manageData.createDgvToleranceTableReference();
            particle_data = new Responsabilities.Particle_Data(particleData);

            singleApertureInformation = new DataTable();
            singleApertureInformation.Columns.Add("Particle_Size", typeof(string));
            singleApertureInformation.Columns.Add("Mesh", typeof(string));
            singleApertureInformation.Columns.Add("Detector_Number", typeof(int));

            astm95Information = new DataTable();
            astm95Information.Columns.Add("Particle_Size", typeof(string));
            astm95Information.Columns.Add("Mesh", typeof(string));
            astm95Information.Columns.Add("Detector_Number", typeof(int));
        }

        private void MeshSelection_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox_Mesh_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedMesh = ComboBox_Mesh.SelectedItem.ToString();
            string micronASTM95 = referenceData.Rows[ComboBox_Mesh.SelectedIndex][2].ToString();
            string micronSingleAperture = referenceData.Rows[ComboBox_Mesh.SelectedIndex][3].ToString();

            Dgv_ASTM95.Rows.Add(micronASTM95, selectedMesh);
            Dgv_Single_Aperture.Rows.Add(micronSingleAperture, selectedMesh);

            this.fillDgvSelectedMesh(Selected_Meshes_ASTM95, micronASTM95, selectedMesh);
            this.fillDgvSelectedMesh(Selected_Meshes_Single_Aperture, micronSingleAperture, selectedMesh);

            this.fillDataTable(astm95Information, micronASTM95, selectedMesh);
            this.fillDataTable(singleApertureInformation, micronSingleAperture, selectedMesh);
        }

        private void fillDgvSelectedMesh(DataGridView dgvToFill, string micron, string selectedMesh)
        {
            double particleSize = Convert.ToDouble(micron.Substring(0, micron.Length - 2));
            int detectorNumber = particle_data.serchDetectorNumber(particleSize);
            dgvToFill.Rows.Add(micron, selectedMesh, detectorNumber);
        }

        private void fillDataTable(DataTable dataTableToFill, string micron, string selectedMesh)
        {
            double particleSize = Convert.ToDouble(micron.Substring(0, micron.Length - 2));
            int detectorNumber = particle_data.serchDetectorNumber(particleSize);
            dataTableToFill.Rows.Add(particleSize, selectedMesh, detectorNumber);
        }

        private void Btn_Clean_Data_Click(object sender, EventArgs e)
        {
            Dgv_ASTM95.Rows.Clear();
            Dgv_Single_Aperture.Rows.Clear();
            Selected_Meshes_ASTM95.Rows.Clear();
            Selected_Meshes_Single_Aperture.Rows.Clear();
            singleApertureInformation.Rows.Clear();
            astm95Information.Rows.Clear();
        }

        public DataTable getDataOfSingleAperture()
        {
            return singleApertureInformation;
        }

        public DataTable getDataOfASTM95()
        {
            return astm95Information;
        }

        public DataTable getSampleInformation()
        {
            return sampleInformation;
        }

    }
}
