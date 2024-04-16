using MaterialSkin.Controls;
using ParticleReader.View;
using System.Data;

namespace ParticleReader
{
    public partial class MainMenu : MaterialForm
    {
        private readonly DataTable particleData;
        private readonly DataTable sampleInformation;

        Particle_Data particleDataView;
        Mesh_Selection meshSelectionView;
        Accumulated_Differential accumulatedifferential;

        private bool allowSelectPageToUser = false;
        public MainMenu(DataTable particleData, DataTable sampleInformation)
        {
            InitializeComponent();
            this.particleData = particleData;
            this.sampleInformation = sampleInformation;

            particleDataView = new Particle_Data(particleData);
            meshSelectionView = new Mesh_Selection(particleData, sampleInformation);           

            Pnl_Load_Data.Controls.Add(particleDataView);            
        }

        private void Pnl_Load_Data_Resize(object sender, EventArgs e)
        {
            particleDataView.Width = Pnl_Load_Data.Width;
            particleDataView.Height = Pnl_Load_Data.Height;
        }
        private void Pnl_Mesh_Selection_Resize(object sender, EventArgs e)
        {
            meshSelectionView.Width = Pnl_Mesh_Selection.Width;
            meshSelectionView.Height = Pnl_Mesh_Selection.Height;
        }

        private void Pnl_Accumulated_Differential_Resize(object sender, EventArgs e)
        {
            accumulatedifferential.Height = Pnl_Accumulated_Differential.Height;
            accumulatedifferential.Width = Pnl_Accumulated_Differential.Width;
        }

        private void Btn_Load_Data_Click(object sender, EventArgs e)
        {
            LoadFile load = new LoadFile();
            load.Show();
            this.Close();
        }

        private void Btn_Go_Mesh_Selection_Click(object sender, EventArgs e)
        {
            allowSelectPageToUser = true;
            Main_Menu_Control.SelectedTab = Page_Mesh_Selection;
            Pnl_Mesh_Selection.Controls.Add(meshSelectionView);
            allowSelectPageToUser = false;
        }

        private void Btn_Return_To_Mesh_Selection_Click(object sender, EventArgs e)
        {
            allowSelectPageToUser = true;
            Main_Menu_Control.SelectedTab = Page_Mesh_Selection;
            allowSelectPageToUser = false;
        }

        private void Main_Menu_Control_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!allowSelectPageToUser)
                e.Cancel = true;
        }

        private void Btn_Go_To_Accumulated_Differential_Click(object sender, EventArgs e)
        {
            allowSelectPageToUser = true;
            Pnl_Accumulated_Differential.Controls.Clear();

            DataTable astm95Information = meshSelectionView.getDataOfASTM95();
            DataTable singleApertureInformation = meshSelectionView.getDataOfSingleAperture();
            DataTable sampleInformation = meshSelectionView.getSampleInformation();

            accumulatedifferential = new Accumulated_Differential(particleData, astm95Information, singleApertureInformation, sampleInformation);
            
            Pnl_Accumulated_Differential.Controls.Add(accumulatedifferential);

            Main_Menu_Control.SelectedTab = Page_Accumulated_Differentials;
            accumulatedifferential.Height = Pnl_Accumulated_Differential.Height;
            accumulatedifferential.Width = Pnl_Accumulated_Differential.Width;
            allowSelectPageToUser = false;
        }

        private void Btn_Return_To_Data_Page_Click(object sender, EventArgs e)
        {
            allowSelectPageToUser = true;
            Main_Menu_Control.SelectedTab = Page_Data;
            allowSelectPageToUser = false;
        }
    }
}