using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class Logic
    {

        public static async Task DoStuff(IProgress<ProgressModel> progress)
        {
            var report = new ProgressModel();

            for (int i = 0; i <= 10; i++)
            {
                await Task.Delay(1000);
                report.CurrentNumber = i;
                //                report.PercentageComplete = 10 / i;
                progress.Report(report);
            }


        }

    }
}
