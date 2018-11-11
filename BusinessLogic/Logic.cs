using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class Logic
    {

        public static async Task DoStuff(IProgress<ProgressModel> progress, CancellationToken cancellationToken)
        {
            // "report" below is newing up a custom model I created to hold data about the progress.
            // I will new one up, add the info to the new report object and send that object back to the view later
            // using the progress.Report method below
            var report = new ProgressModel();

            for (int i = 0; i <= 10; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();

                await Task.Delay(1000);
                report.CurrentNumber = i;
                //                report.PercentageComplete = 10 / i;

                // this Report method sends back the updates to the progress created in the view layer
                progress.Report(report);
            }


        }

    }
}
