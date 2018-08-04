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
            // this is my custom model created to hold information about what is happening.
            // I will new one up, add the info to the reporters and send that object back to the view later
            // using the progress.Report method below
            var report = new ProgressModel();

            for (int i = 0; i <= 10; i++)
            {
                await Task.Delay(1000);
                report.CurrentNumber = i;
                //                report.PercentageComplete = 10 / i;

                // this Report method sends back the updates to the progress created in the view layer
                progress.Report(report);
            }


        }

    }
}
