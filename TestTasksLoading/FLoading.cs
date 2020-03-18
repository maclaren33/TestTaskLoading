using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTasksLoading
{
    public partial class FLoading : Form
    {
        CancellationToken token;

        public FLoading(CancellationToken t)
        {
            token = t;
            InitializeComponent();
        }

        private async void FLoading_LoadAsync(object sender, EventArgs e)
        {
            //Para colocar el loading en la mitad
            this.PctLoading.Location = new Point(this.Width / 2 - PctLoading.Width / 2, this.Height / 2 - PctLoading.Height / 2);
            await VerificaCierre();
            this.Close();
        }

        private Task VerificaCierre()
        {
            var a = Task.Factory.StartNew(() =>
            {
                while (!token.IsCancellationRequested)
                {

                    //esta aqui hasta que de forma externa le digo que el token esta cancelado
                }
            });

            return a;
        }
    }
}
