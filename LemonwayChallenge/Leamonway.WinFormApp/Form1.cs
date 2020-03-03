using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leamonway.WinFormApp
{
    public partial class Form1 : Form
    {
        public int FibonacciResult { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += this.RunFibonacci;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.RunWorkerAsync();
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(FibonacciResult.ToString());
        }
        private void RunFibonacci(object sender, DoWorkEventArgs e)
        {
            try
            {
                FibonacciServiceReference.FibonacciWebServiceSoapClient client = new FibonacciServiceReference.FibonacciWebServiceSoapClient();
                FibonacciResult = client.Fibonacci(10);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
