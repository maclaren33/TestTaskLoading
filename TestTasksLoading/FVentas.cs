using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTasksLoading
{
    public partial class FVentas : Form
    {
        public FVentas()
        {
            InitializeComponent();
        }

        private void FVentas_Load(object sender, EventArgs e)
        {
           
        }

        public Task
       CargaDatos()
        {
           return Task.Delay(5000);
            
        }
    }
}
