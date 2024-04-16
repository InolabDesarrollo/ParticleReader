using OfficeOpenXml.FormulaParsing.Excel.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleReader.Responsabilities
{
    public class Accumulated
    {
        private readonly DataTable particleData;

        public Accumulated(DataTable particleData) {
            this.particleData = particleData;
        }

        public void addColumnToDatagridView(string headerText, DataGridView dataGridView)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.HeaderText = headerText;
            column.Width = 100;
            dataGridView.Columns.Add(column);
        }

        public double getAccumulatedValueRight(int detectorValue, int columnToSerchValue)
        {
            double cellValue;
            double accumulated = 0;

            for (int i=1; i<= detectorValue; i++)
            {
                cellValue = Convert.ToDouble(particleData.Rows[i][columnToSerchValue].ToString());
                accumulated +=cellValue;
            }
            return this.roundToTwoDecimals(accumulated);
        }

        public double getAccumulatedValueLeft(int detectorValue, int columnToSerchValue)
        {
            double cellValue;
            double accumulated = 0;

            for (int i = detectorValue+1; i < particleData.Rows.Count; i++)
            {
                cellValue = Convert.ToDouble(particleData.Rows[i][columnToSerchValue].ToString());
                accumulated += cellValue;
            }
            return this.roundToTwoDecimals(accumulated);
        }

        private double roundToTwoDecimals(double number)
        {
            double auxiliarValue = Math.Pow(10, 2);
            return (Math.Truncate(number * auxiliarValue)/ auxiliarValue);
        }
        
    }
}
