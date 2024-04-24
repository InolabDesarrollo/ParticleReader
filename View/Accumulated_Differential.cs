using Microsoft.VisualBasic;
using Particle_Reader.Model;
using Particle_Reader.Responsabilities;
using Particle_Reader.View;
using ParticleReader.Responsabilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleReader.View
{
    public partial class Accumulated_Differential : UserControl
    {
        private readonly DataTable astm95Information;
        private readonly DataTable singleApertureInformation;
        private readonly DataTable sampleInformation;

        private int numberOfRuns;
        private Accumulated accumulated;
        private DataTable differentialASTM95;
        private DataTable differentialSingleAperture;
        public Accumulated_Differential(DataTable particleData, DataTable astm95Information, DataTable singleApertureInformation, DataTable sampleInformation)
        {
            InitializeComponent();
            this.astm95Information = astm95Information;
            this.singleApertureInformation = singleApertureInformation;
            this.sampleInformation = sampleInformation;
            numberOfRuns = this.checkNumberOfRuns(particleData);

            accumulated = new Accumulated(particleData);
            this.fillAcumulatedValues();
            this.fillDifferentialValues();
        }

        private int checkNumberOfRuns(DataTable data)
        {
            int numberOfRuns = 1;
            if (data.Rows[0][3].ToString().Equals("Run_2 (Vol%)"))
            {
                numberOfRuns++;
            }
            if (data.Rows[0][4].ToString().Equals("Run_3 (Vol%)"))
            {
                numberOfRuns++;
            }
            return numberOfRuns;
        }

        private void fillAcumulatedValues()
        {
            if (numberOfRuns == 1)
            {
                this.addAcummulativeToRightRunOne(astm95Information, Dgv_ASTM95_Accumulated);
                this.addAcummulativeToRightRunOne(singleApertureInformation, Dgv_Single_Aperture_Accumulated);

                this.addAcummulativeToLeftRunOne(astm95Information, Dgv_ASTM95_Accumulated, 3);
                this.addAcummulativeToLeftRunOne(singleApertureInformation, Dgv_Single_Aperture_Accumulated, 3);
            }
            if (numberOfRuns == 2)
            {
                this.addAcummulativeToRightRunOne(astm95Information, Dgv_ASTM95_Accumulated);
                this.addAcummulativeToRightRunOne(singleApertureInformation, Dgv_Single_Aperture_Accumulated);
                this.addAcummulativeToRightRunTwo(astm95Information, Dgv_ASTM95_Accumulated);
                this.addAcummulativeToRightRunTwo(singleApertureInformation, Dgv_Single_Aperture_Accumulated);

                this.addAcummulativeToLeftRunOne(astm95Information, Dgv_ASTM95_Accumulated, 4);
                this.addAcummulativeToLeftRunOne(singleApertureInformation, Dgv_Single_Aperture_Accumulated, 4);
                this.addAcummulativeToLeftRunTwo(astm95Information, Dgv_ASTM95_Accumulated, 5);
                this.addAcummulativeToLeftRunTwo(singleApertureInformation, Dgv_Single_Aperture_Accumulated, 5);

            }
            if (numberOfRuns == 3)
            {
                this.addAcummulativeToRightRunOne(astm95Information, Dgv_ASTM95_Accumulated);
                this.addAcummulativeToRightRunOne(singleApertureInformation, Dgv_Single_Aperture_Accumulated);

                this.addAcummulativeToRightRunTwo(astm95Information, Dgv_ASTM95_Accumulated);
                this.addAcummulativeToRightRunTwo(singleApertureInformation, Dgv_Single_Aperture_Accumulated);

                this.addAcummulativeToRightRunThree(astm95Information, Dgv_ASTM95_Accumulated);
                this.addAcummulativeToRightRunThree(singleApertureInformation, Dgv_Single_Aperture_Accumulated);


                this.addAcummulativeToLeftRunOne(astm95Information, Dgv_ASTM95_Accumulated, 5);
                this.addAcummulativeToLeftRunOne(singleApertureInformation, Dgv_Single_Aperture_Accumulated, 5);

                this.addAcummulativeToLeftRunTwo(astm95Information, Dgv_ASTM95_Accumulated, 6);
                this.addAcummulativeToLeftRunTwo(singleApertureInformation, Dgv_Single_Aperture_Accumulated, 6);

                this.addAcummulativeToLeftRunTree(astm95Information, Dgv_ASTM95_Accumulated);
                this.addAcummulativeToLeftRunTree(singleApertureInformation, Dgv_Single_Aperture_Accumulated);
            }
        }

        private void addAcummulativeToRightRunOne(DataTable information, DataGridView dataGridViewToAddValues)
        {
            double cumulated;
            int detectorNumber;
            this.addColumnToDatagridView("Run_1 Cumulatives <", dataGridViewToAddValues);
            dataGridViewToAddValues.Rows.Add();
            dataGridViewToAddValues.Rows[0].Cells[1].Value = 999;
            dataGridViewToAddValues.Rows[0].Cells[2].Value = 0;

            for (int i = 0; i < information.Rows.Count; i++)
            {
                detectorNumber = Convert.ToInt32(information.Rows[i][2].ToString());
                cumulated = accumulated.getAccumulatedValueRight(detectorNumber, 2);

                dataGridViewToAddValues.Rows.Add();
                dataGridViewToAddValues.Rows[i + 1].Cells[0].Value = information.Rows[i][0];
                dataGridViewToAddValues.Rows[i + 1].Cells[1].Value = information.Rows[i][1];
                dataGridViewToAddValues.Rows[i + 1].Cells[2].Value = cumulated;
            }
        }

        private void addAcummulativeToLeftRunOne(DataTable information, DataGridView dataGridViewToAddValues, int columnToAddValue)
        {
            double cumulated;
            int detectorNumber;
            this.addColumnToDatagridView("Run_1 Cumulatives >", dataGridViewToAddValues);

            for (int i = 0; i < information.Rows.Count; i++)
            {
                detectorNumber = Convert.ToInt32(information.Rows[i][2].ToString());
                cumulated = accumulated.getAccumulatedValueLeft(detectorNumber, 2);

                dataGridViewToAddValues.Rows.Add();
                dataGridViewToAddValues.Rows[i + 1].Cells[columnToAddValue].Value = cumulated;
            }
            dataGridViewToAddValues.Rows[0].Cells[columnToAddValue].Value = 0;
        }

        private void addAcummulativeToRightRunTwo(DataTable information, DataGridView dataGridViewToAddValues)
        {
            double cumulated;
            int detectorNumber;
            this.addColumnToDatagridView("Run_2 Cumulatives <", dataGridViewToAddValues);
            dataGridViewToAddValues.Rows.Add();
            dataGridViewToAddValues.Rows[0].Cells[3].Value = 0;

            for(int i = 0; i < information.Rows.Count; i++)
            {
                detectorNumber = Convert.ToInt32(information.Rows[i][2].ToString());
                cumulated = accumulated.getAccumulatedValueRight(detectorNumber, 3);

                dataGridViewToAddValues.Rows.Add();
                dataGridViewToAddValues.Rows[i + 1].Cells[3].Value = cumulated;
            }
        }

        private void addAcummulativeToLeftRunTwo(DataTable information, DataGridView dataGridViewToAddValues, int columnToAddValue)
        {
            double cumulated;
            int detectorNumber;
            this.addColumnToDatagridView("Run_2 Cumulatives >", dataGridViewToAddValues);

            for (int i = 0; i < information.Rows.Count; i++)
            {
                detectorNumber = Convert.ToInt32(information.Rows[i][2].ToString());
                cumulated = accumulated.getAccumulatedValueLeft(detectorNumber, 3);

                dataGridViewToAddValues.Rows.Add();
                dataGridViewToAddValues.Rows[i + 1].Cells[columnToAddValue].Value = cumulated;
            }
            dataGridViewToAddValues.Rows[0].Cells[columnToAddValue].Value = 0;
        }

        private void addAcummulativeToRightRunThree(DataTable information, DataGridView dataGridViewToAddValues)
        {
            double cumulated;
            int detectorNumber;
            this.addColumnToDatagridView("Run_3 Cumulatives <", dataGridViewToAddValues);
            dataGridViewToAddValues.Rows.Add();
            dataGridViewToAddValues.Rows[0].Cells[4].Value = 0;

            for (int i = 0; i < information.Rows.Count; i++)
            {
                detectorNumber = Convert.ToInt32(information.Rows[i][2].ToString());
                cumulated = accumulated.getAccumulatedValueRight(detectorNumber, 4);

                dataGridViewToAddValues.Rows.Add();
                dataGridViewToAddValues.Rows[i + 1].Cells[4].Value = cumulated;
            }
        }

        private void addAcummulativeToLeftRunTree(DataTable information, DataGridView dataGridViewToAddValues)
        {
            double cumulated;
            int detectorNumber;
            this.addColumnToDatagridView("Run_3 Cumulatives >", dataGridViewToAddValues);

            for (int i = 0; i < information.Rows.Count; i++)
            {
                detectorNumber = Convert.ToInt32(information.Rows[i][2].ToString());
                cumulated = accumulated.getAccumulatedValueLeft(detectorNumber, 4);

                dataGridViewToAddValues.Rows.Add();
                dataGridViewToAddValues.Rows[i + 1].Cells[7].Value = cumulated;
            }
            dataGridViewToAddValues.Rows[0].Cells[7].Value = 0;
        }

        public void addColumnToDatagridView(string headerText, DataGridView dataGridView)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.HeaderText = headerText;
            column.Width = 100;
            dataGridView.Columns.Add(column);
        }

        private void fillDifferentialValues()
        {
            ManageData data = new ManageData();
            DataTable accumulatedValuesASTM95 = data.convertDataGridViewToTable(Dgv_ASTM95_Accumulated);
            DataTable accumulatedValuesSingleAperture = data.convertDataGridViewToTable(Dgv_Single_Aperture_Accumulated);

            accumulatedValuesASTM95 = data.deleteEmptyRowsOfDataTable(accumulatedValuesASTM95);
            accumulatedValuesSingleAperture = data.deleteEmptyRowsOfDataTable(accumulatedValuesSingleAperture);

            Differential astm95 = new Differential(accumulatedValuesASTM95);
            differentialASTM95 = astm95.getDifferentialTable();

            Differential singleAperture = new Differential(accumulatedValuesSingleAperture);
            differentialSingleAperture = singleAperture.getDifferentialTable();

            data.addDataTableToDataGridView(differentialASTM95, Dgv_ASTM95_Differential);
            data.addDataTableToDataGridView(differentialSingleAperture, Dgv_Single_Aperture_Differential);
        }

        private void Btn_Generate_Report_Click(object sender, EventArgs e)
        {
            DataTable sampleInformationForReport = this.serchInformationOfRuns();
            ObservableCollection<SampleInformation> sampleInformationColection;

            DataForReport dataForReport = new DataForReport(numberOfRuns);
            sampleInformationColection = dataForReport.getDataOfSampleForReport(sampleInformationForReport);
            DataTable accumulatedAstm95 = this.getAccumulatedValues(Dgv_ASTM95_Accumulated);
            DataTable accumulatedSingleAperture = this.getAccumulatedValues(Dgv_Single_Aperture_Accumulated);

            Report_View report = new Report_View(sampleInformationColection, accumulatedAstm95, differentialASTM95, accumulatedSingleAperture, numberOfRuns, differentialSingleAperture);           
            report.Show();
        }

        private DataTable serchInformationOfRuns()
        {
            string[] valuesToSerch = { "Name", "Sample Date", "User", "Device", "Sample ID", "Group ID" };
            DataTable information = new DataTable();
            information.Columns.Add(new DataColumn("Title", typeof(string)));
            information.Columns.Add(new DataColumn("Value", typeof(string)));

            string cellValue;
            int index = 0;
            for (int i = 0; i < sampleInformation.Rows.Count; i++)
            {
                cellValue = sampleInformation.Rows[i][1].ToString();
                if (valuesToSerch.Contains(cellValue))
                {
                    information.Rows.Add();
                    information.Rows[index]["Title"] = sampleInformation.Rows[i][1].ToString();
                    information.Rows[index]["Value"] = sampleInformation.Rows[i][2].ToString();
                    index++;
                }
            }
            return information;
        }

        private DataTable getAccumulatedValues(DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                dataTable.Columns.Add(column.HeaderText, typeof(string));
            }
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value;
                }
                dataTable.Rows.Add(dataRow);
            }
            return dataTable;
        }

    }
}
