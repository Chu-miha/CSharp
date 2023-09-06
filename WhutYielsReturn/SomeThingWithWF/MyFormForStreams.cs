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
using Streams;

namespace SomeThingWithWF
{
    public partial class MyFormForStreams : Form
    {
        //Потоки в WF
        Label label;
        Button button;
        ProgressBar progressBar;
        public MyFormForStreams()
        {
            InitializeComponent();
            label = new Label { Size = new Size(ClientSize.Width, 30) };
            button = new Button
            {
                Location = new Point(0, label.Bottom),
                Size = label.Size,
                Text = "Start"
            };
            progressBar = new ProgressBar
            {
                Location = new Point(0, button.Bottom),
                Size = label.Size
            };

            button.Click += MakeWorks;
            Controls.Add(label);
            Controls.Add(button);
            Controls.Add(progressBar);
        }

        Task<string> MakeWorkInThread()
        {
            var task = new Task<string>(
                () => { Thread.Sleep(5000); return "Completed"; }
                );
            task.Start();
            return task;
            //BeginInvoke(new Action(() => label.Text = "Complete"));
        }

      async void MakeWork(object sender, EventArgs e)
        {
            //new Action(MakeWorkInThread).BeginInvoke(null, null);
            //var task = MakeWorkInThread();
            //task.ContinueWith(
            //    z => label.Text = z.Result,
            //    TaskScheduler.FromCurrentSynchronizationContext());
            var labelText = await MakeWorkInThread();
            label.Text = labelText;
        }

        void MakeWorks(object sender, EventArgs e)
        {
            var worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += (s, a) => label.Text = "Completed";
            worker.ProgressChanged += (s, a) => progressBar.Value = a.ProgressPercentage;
            worker.RunWorkerAsync();
        }

        void worker_DoWork (object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(50);
                ((BackgroundWorker)sender).ReportProgress(i);
            }
        }

    }
}
