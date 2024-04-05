using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleReader.Responsabilities
{
    public class Differential
    {
        private readonly DataTable accumulatedValues;

        public Differential(DataTable accumulatedValues) {
            this.accumulatedValues = accumulatedValues;          
        }

        public DataTable getDifferentialTable()
        {
            DataTable differentialValues = new DataTable();
            int numberOfRuns = this.checkNumberOfRuns();
            if(numberOfRuns == 1 )
            {
                differentialValues = this.fillDifferentialValuesRunOne();
            }
            if (numberOfRuns == 2)
            {
                differentialValues = this.fillDifferentialValuesRunOne();

                differentialValues.Columns.Add("Differential Run 2", typeof(double));
                differentialValues = this.fillDifferentialValuesRunTwo(differentialValues);
            }
            if (numberOfRuns == 3)
            {
                differentialValues = this.fillDifferentialValuesRunOne();

                differentialValues.Columns.Add("Differential Run 2", typeof(double));
                differentialValues = this.fillDifferentialValuesRunTwo(differentialValues);

                differentialValues.Columns.Add("Differential Run 3", typeof(double));
                differentialValues = this.fillDifferentialValuesRunThree(differentialValues);
            }

            return differentialValues;
        }

        public DataTable fillDifferentialValuesRunOne()
        {
            DataTable differential = new DataTable();
            differential.Columns.Add(new DataColumn("Mesh"));
            differential.Columns.Add(new DataColumn("Differential Run 1"));
            differential.Rows.Add();
            differential.Rows[0][0] = 999;
            for (int i = 1; i < accumulatedValues.Rows.Count; i++)
            {
                differential.Rows.Add();
                differential.Rows[i][0] = accumulatedValues.Rows[i][1];
            }

            for(int i = 0; i < accumulatedValues.Rows.Count; i++)
            {
                if (i + 1 == accumulatedValues.Rows.Count)
                {
                    break;
                }
                double firstValue = Convert.ToDouble(accumulatedValues.Rows[i]["Run_1 Cumulatives <"].ToString());
                double secondValue = Convert.ToDouble(accumulatedValues.Rows[i + 1]["Run_1 Cumulatives <"].ToString());
                double result = secondValue - firstValue;
                differential.Rows[i][1] = Math.Round(result,2);
                
            }
            differential.Rows[differential.Rows.Count - 1]["Differential Run 1"] = Math.Round(Convert.ToDouble(accumulatedValues.Rows[accumulatedValues.Rows.Count - 1]["Run_1 Cumulatives >"].ToString()),2);
            return differential;
        }

        public DataTable fillDifferentialValuesRunTwo(DataTable differential)
        {
            for (int i = 0; i < accumulatedValues.Rows.Count; i++)
            {
                if (i + 1 == accumulatedValues.Rows.Count)
                {
                    break;
                }
                double firstValue = Convert.ToDouble(accumulatedValues.Rows[i][3].ToString());
                double secondValue = Convert.ToDouble(accumulatedValues.Rows[i + 1][3].ToString());
                double result = secondValue - firstValue;
                differential.Rows[i][2] = Math.Round(result, 2);               
            }
            differential.Rows[differential.Rows.Count - 1]["Differential Run 2"] = Math.Round(Convert.ToDouble(accumulatedValues.Rows[accumulatedValues.Rows.Count - 1]["Run_2 Cumulatives >"].ToString()), 2);
            return differential;
        }

        public DataTable fillDifferentialValuesRunThree(DataTable differential)
        {
            for (int i = 0; i < accumulatedValues.Rows.Count; i++)
            {
                if (i + 1 == accumulatedValues.Rows.Count)
                {
                    break;
                }
                double firstValue = Convert.ToDouble(accumulatedValues.Rows[i]["Run_3 Cumulatives <"].ToString());
                double secondValue = Convert.ToDouble(accumulatedValues.Rows[i + 1]["Run_3 Cumulatives <"].ToString());
                double result = secondValue - firstValue;
                differential.Rows[i][3] = Math.Round(result, 2);              
            }
            differential.Rows[differential.Rows.Count - 1]["Differential Run 3"] = Math.Round(Convert.ToDouble(accumulatedValues.Rows[accumulatedValues.Rows.Count - 1]["Run_3 Cumulatives >"].ToString()), 2);
            return differential;
        }

        private int checkNumberOfRuns()
        {
            int numberOfRuns = 0;
            int columns = accumulatedValues.Columns.Count;
            switch (columns)
            {
                case 4:
                    numberOfRuns = 1;
                    break;
                case 6: 
                    numberOfRuns = 2;
                    break;
                case 8:
                    numberOfRuns = 3;
                    break;
            }
            return numberOfRuns;
        }
    }
}
