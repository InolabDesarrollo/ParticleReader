using Microsoft.Reporting.WinForms;
using Particle_Reader.Model;
using ParticleReader.Responsabilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Particle_Reader.View
{
    public partial class Report_View : Form
    {
        private readonly ObservableCollection<SampleInformation> sampleObservation;
        private readonly int numberOfRuns;
        private static ObservableCollection<Accumulative_Values> accumulativeCollection;
        private static ObservableCollection<Accumulative_Values> accumulativeCollectionSingleAperture;
        private static ObservableCollection<Differential_Values> differentialCollectionAstm95;
        private static ObservableCollection<Differential_Values> differentialCollectionSingleAperture;

        public Report_View(ObservableCollection<SampleInformation> sampleObservation, DataTable accumulativeValuesAstm95, 
            DataTable differentialValuesAstm95, DataTable accumulatedValuesSingleAperture, int numberOfRuns, DataTable differentialValuesSingleAperture)
        {
            InitializeComponent();
            this.sampleObservation = sampleObservation;
            this.numberOfRuns = numberOfRuns;
            accumulativeCollection = new ObservableCollection<Accumulative_Values>();
            accumulativeCollectionSingleAperture = new ObservableCollection<Accumulative_Values>();

            differentialCollectionAstm95 = new ObservableCollection<Differential_Values>();
            differentialCollectionSingleAperture = new ObservableCollection<Differential_Values>();

            this.getCollectionOfAccumulatedValues(accumulativeValuesAstm95, accumulativeCollection);
            this.getCollectionOfAccumulatedValues(accumulatedValuesSingleAperture, accumulativeCollectionSingleAperture);
            this.getCollectionDifferentialValues(differentialValuesAstm95, differentialCollectionAstm95);
            this.getCollectionDifferentialValues(differentialValuesSingleAperture, differentialCollectionSingleAperture);
        }    

        private void getCollectionOfAccumulatedValues(DataTable accumulativeValues, ObservableCollection<Accumulative_Values> accumulativeCollection)
        {
            Accumulative_Values accumulative;
            ManageData manageData = new ManageData();
            manageData.deleteEmptyRowsOfDataTable(accumulativeValues);
            if (numberOfRuns == 1)
            {
                for (int i = 0; i < accumulativeValues.Rows.Count; i++)
                {
                    accumulative = new Accumulative_Values();
                    accumulative.ParticleSize = accumulativeValues.Rows[i][0].ToString();
                    accumulative.Mesh = accumulativeValues.Rows[i][1].ToString();
                    accumulative.RunOneAccumulativeRight = accumulativeValues.Rows[i][2].ToString();
                    accumulative.RunOneAccumulativeLeft = accumulativeValues.Rows[i][3].ToString();

                    accumulativeCollection.Add(accumulative);
                }
            }
            if (numberOfRuns == 2)
            {
                for (int i = 0; i < accumulativeValues.Rows.Count; i++)
                {
                    accumulative = new Accumulative_Values();
                    accumulative.ParticleSize = accumulativeValues.Rows[i][0].ToString();
                    accumulative.Mesh = accumulativeValues.Rows[i][1].ToString();
                    accumulative.RunOneAccumulativeRight = accumulativeValues.Rows[i][2].ToString();
                    accumulative.RunOneAccumulativeLeft = accumulativeValues.Rows[i][3].ToString();
                    accumulative.RunTwoAccumulativeRight = accumulativeValues.Rows[i][4].ToString();
                    accumulative.RunTwoAccumulativeLeft = accumulativeValues.Rows[i][5].ToString();

                    accumulativeCollection.Add(accumulative);
                }
            }
            if (numberOfRuns == 3)
            {
                for (int i = 0; i < accumulativeValues.Rows.Count; i++)
                {
                    accumulative = new Accumulative_Values();
                    accumulative.ParticleSize = accumulativeValues.Rows[i][0].ToString();
                    accumulative.Mesh = accumulativeValues.Rows[i][1].ToString();
                    accumulative.RunOneAccumulativeRight = accumulativeValues.Rows[i][2].ToString();
                    accumulative.RunOneAccumulativeLeft = accumulativeValues.Rows[i][3].ToString();
                    accumulative.RunTwoAccumulativeRight = accumulativeValues.Rows[i][4].ToString();
                    accumulative.RunTwoAccumulativeLeft = accumulativeValues.Rows[i][5].ToString();
                    accumulative.RunThreeAccumulativeRight = accumulativeValues.Rows[i][6].ToString();
                    accumulative.RunThreeAccumulativeLeft = accumulativeValues.Rows[i][6].ToString();

                    accumulativeCollection.Add(accumulative);
                }
            }

        }


        private void getCollectionDifferentialValues(DataTable differentialValues, ObservableCollection<Differential_Values> differentialCollection)
        {
            Differential_Values differential;
            ManageData manageData = new ManageData();
            manageData.deleteEmptyRowsOfDataTable(differentialValues);

            if (numberOfRuns == 1)
            {
                for (int i = 0; i < differentialValues.Rows.Count; i++)
                {
                    differential = new Differential_Values();
                    differential.Mesh = differentialValues.Rows[i][0].ToString();
                    differential.DifferentialRunOne = differentialValues.Rows[i][1].ToString();

                    differentialCollection.Add(differential);
                }
            }
            if (numberOfRuns == 2)
            {
                for (int i = 0; i < differentialValues.Rows.Count; i++)
                {
                    differential = new Differential_Values();
                    differential.Mesh = differentialValues.Rows[i][0].ToString();
                    differential.DifferentialRunOne = differentialValues.Rows[i][1].ToString();
                    differential.DifferentialRunTwo = differentialValues.Rows[i][2].ToString();

                    differentialCollection.Add(differential);
                }
            }
            if (numberOfRuns == 3)
            {
                for (int i = 0; i < differentialValues.Rows.Count; i++)
                {
                    differential = new Differential_Values();
                    differential.Mesh = differentialValues.Rows[i][0].ToString();
                    differential.DifferentialRunOne = differentialValues.Rows[i][1].ToString();
                    differential.DifferentialRunTwo = differentialValues.Rows[i][2].ToString();
                    differential.DifferentialRunThree = differentialValues.Rows[i][3].ToString();
                    differentialCollection.Add(differential);
                }
            }

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Report_View_Load(object sender, EventArgs e)
        {
            ReportDataSource sampleInformation = new ReportDataSource("Sample_Information", sampleObservation);
            ReportDataSource accumulative = new ReportDataSource("Accumulative_Values", accumulativeCollection);
            ReportDataSource accumulativeSingleAperture = new ReportDataSource("Accumulative_Values_Single_Aperture", accumulativeCollectionSingleAperture);

            ReportDataSource differentialAstm95 = new ReportDataSource("Differential_Values", differentialCollectionAstm95);
            ReportDataSource differentialSingleAperture = new ReportDataSource("Differential_Values_Single_Aperture", differentialCollectionSingleAperture);

            Trace.WriteLine(accumulativeCollection.Count.ToString());

            this.ReportViewer.ProcessingMode = (Microsoft.Reporting.WinForms.ProcessingMode)ProcessingMode.Local;

            this.ReportViewer.LocalReport.ReportPath = this.defineReport(); 
            this.ReportViewer.LocalReport.DataSources.Clear();
            this.ReportViewer.LocalReport.DataSources.Add(sampleInformation);

            this.ReportViewer.LocalReport.DataSources.Add(accumulative);
            this.ReportViewer.LocalReport.DataSources.Add(differentialAstm95);

            this.ReportViewer.LocalReport.DataSources.Add(accumulativeSingleAperture);
            this.ReportViewer.LocalReport.DataSources.Add(differentialSingleAperture);

            ReportViewer.RefreshReport();
        }

        private string defineReport()
        {
            string reportPath = "";
            switch (numberOfRuns)
            {
                case 1:
                    reportPath = @"Reports\RunOneReport.rdlc";
                    break;
                case 2:
                    reportPath = @"Reports\RunTwoReport.rdlc";
                    break;
                case 3:
                    reportPath = @"Reports\RunThreeReport.rdlc";
                    break;
            }
            return reportPath;
        }
    }
}
