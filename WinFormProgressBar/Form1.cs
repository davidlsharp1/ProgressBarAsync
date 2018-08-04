using BusinessLogic;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Progress<ProgressModel> progress = new Progress<ProgressModel>();
            progress.ProgressChanged += Progress_ProgressChanged;
            await Logic.DoStuff(progress);
            MessageBox.Show("done");

        }

        private void Progress_ProgressChanged(object sender, ProgressModel e)
        {
            pbProgress.Value = e.CurrentNumber;
            label1.Text = e.CurrentNumber.ToString();
        }




    }
}
