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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LlenarVentas();
        }

        private void LlenarVentas()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("IdVenta");
            dt.Columns.Add("Factura");
            dt.Rows.Add(1, "001-001-000000001");
            dt.Rows.Add(1, "001-001-000000002");
            dt.Rows.Add(1, "001-001-000000003");
            dgvVentas.DataSource = dt;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            SeleccionarAsync();
        }

        private async Task SeleccionarAsync()
        {
            var source = new CancellationTokenSource();
            // ... Get Token from source.
            var token = source.Token;

            Task.Run(() =>
            {
                //t = Thread.CurrentThread;
                FLoading oFloading = new FLoading(token);
                oFloading.ShowDialog();
            }, token);
            try
            {
                if (dgvVentas.RowCount > 0)
                {
                    if (dgvVentas.SelectedCells[0].RowIndex.ToString() != null)
                    {
                        FVentas ofVentas = new FVentas();
                        ofVentas.MdiParent = this.MdiParent;
                        ofVentas.Show();
                        ofVentas.Visible = false;
                        await ofVentas.CargaDatos();
                        ofVentas.Visible = true;
                    }
                }
                //mando la señal para terminar el task loading
                source.Cancel();
            }
            catch (Exception ex)
            {
                source.Cancel();
                MessageBox.Show(ex.Message, "Error duplex", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
