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

            // this is saying anything the event ProgressChanged happens run this method.
            progress.ProgressChanged += Progress_ProgressChanged;  
            await Logic.DoStuff(progress);
            MessageBox.Show("done");
        }

        private void Progress_ProgressChanged(object sender, ProgressModel e)  // this is an event that gets triggered anytime the progress changes
        {
            pbProgress.Value = e.CurrentNumber;
            label1.Text = e.CurrentNumber.ToString();
        }

        private void pbProgress_Click(object sender, EventArgs e)
        {

        }
    }
}
