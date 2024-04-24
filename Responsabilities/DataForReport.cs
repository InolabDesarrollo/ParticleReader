using Particle_Reader.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle_Reader.Responsabilities
{
    public class DataForReport
    {
        private readonly int numberOfRuns;

        public DataForReport(int numberOfRuns) 
        {
            this.numberOfRuns = numberOfRuns;
        }

        public ObservableCollection<SampleInformation> getDataOfSampleForReport(DataTable sampleInformationForReport)
        {
            ObservableCollection<SampleInformation> sampleInformationColection = new ObservableCollection<SampleInformation>();
            SampleInformation sampleInformation = new SampleInformation();

            if (numberOfRuns == 1)
            {
                this.fillSampleInformationRunOne(sampleInformationForReport, sampleInformation);
            }
            if (numberOfRuns == 2)
            {
                this.fillSampleInformationRunOne(sampleInformationForReport, sampleInformation);
                this.fillSampleInformationRunTwo(sampleInformationForReport, sampleInformation);
            }
            if (numberOfRuns == 3)
            {
                this.fillSampleInformationRunOne(sampleInformationForReport, sampleInformation);
                this.fillSampleInformationRunTwo(sampleInformationForReport, sampleInformation);
                this.fillSampleInformationRunThree(sampleInformationForReport, sampleInformation);
            }
            sampleInformationColection.Add(sampleInformation);
            return sampleInformationColection;
        }

        private void fillSampleInformationRunOne(DataTable sampleInformationForReport,
            SampleInformation sampleInformation)
        {
            sampleInformation.Name = sampleInformationForReport.Rows[0]["Value"].ToString();
            sampleInformation.SampleData = sampleInformationForReport.Rows[1]["Value"].ToString();
            sampleInformation.User = sampleInformationForReport.Rows[2]["Value"].ToString();
            sampleInformation.Device = sampleInformationForReport.Rows[3]["Value"].ToString();
            sampleInformation.SampleId = sampleInformationForReport.Rows[4]["Value"].ToString();
            sampleInformation.GroupId = sampleInformationForReport.Rows[5]["Value"].ToString();
        }

        private void fillSampleInformationRunTwo(DataTable sampleInformationForReport
            , SampleInformation sampleInformation)
        {
            sampleInformation.Name_RunTwo = sampleInformationForReport.Rows[6]["Value"].ToString();
            sampleInformation.SampleData_RunTwo = sampleInformationForReport.Rows[7]["Value"].ToString();
            sampleInformation.User_RunTwo = sampleInformationForReport.Rows[8]["Value"].ToString();
            sampleInformation.Device_RunTwo = sampleInformationForReport.Rows[9]["Value"].ToString();
            sampleInformation.SampleId_RunTwo = sampleInformationForReport.Rows[10]["Value"].ToString();
            sampleInformation.GroupId_RunTwo = sampleInformationForReport.Rows[11]["Value"].ToString();
        }

        private void fillSampleInformationRunThree(DataTable sampleInformationForReport
            ,SampleInformation sampleInformation)
        {
            sampleInformation.Name_RunThree = sampleInformationForReport.Rows[12]["Value"].ToString();
            sampleInformation.SampleData_RunThree = sampleInformationForReport.Rows[13]["Value"].ToString();
            sampleInformation.User_RunThree = sampleInformationForReport.Rows[14]["Value"].ToString();
            sampleInformation.Device_RunThree = sampleInformationForReport.Rows[15]["Value"].ToString();
            sampleInformation.SampleId_RunThree = sampleInformationForReport.Rows[16]["Value"].ToString();
            sampleInformation.GroupId_RunThree = sampleInformationForReport.Rows[17]["Value"].ToString();
        }
    }
}
