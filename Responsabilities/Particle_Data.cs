using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleReader.Responsabilities
{
    public class Particle_Data
    {
        private readonly DataTable particleData;

        public Particle_Data(DataTable particleData) {
            this.particleData = particleData;
        }

        public int serchDetectorNumber(double particleSizeToSerch)
        {
            try
            {
                int columnWithDetectorNumber = this.defineColumnWithDetectorNumber(particleData);
                int detectorNumber = 0;
                for (int i = 1; i < particleData.Rows.Count; i++)
                {
                    double particleSize = Convert.ToDouble(particleData.Rows[i][0]);
                    if (particleSize > particleSizeToSerch && (particleSize - particleSizeToSerch) > 0.9990)
                    {
                        break;
                    }
                    detectorNumber = Convert.ToInt32(particleData.Rows[i][columnWithDetectorNumber]);
                }
                return detectorNumber;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
                return 0;
            }
        }

        private int defineColumnWithDetectorNumber(DataTable particleData)
        {
            int numberOfRuns = this.checkNumberOfRuns(particleData);
            switch (numberOfRuns)
            {
                case 1:
                    return 4;
                case 2:
                    return 5;
                case 3:
                    return 6;
                default: return 4;
            }
        }

        public int checkNumberOfRuns(DataTable data)
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



    }
}
