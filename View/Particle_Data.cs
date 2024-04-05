using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleReader.View
{
    public partial class Particle_Data : UserControl
    {
        public Particle_Data(DataTable particleData)
        {
            InitializeComponent();
            Particle_DataGridView.DataSource = particleData;
        }
    }
}
