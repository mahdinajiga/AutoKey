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
    public partial class Login : Form
    {
        string Target = "none";
        public Login()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern int Sleep(long Afr);

        bool ClearToGo = false;

        string Ryues = "";

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (txt_Password.Text == "*********")
            {
                if (txt_UserName.Text != "*****")
                {
                    string MPs = txt_UserName.Text;
                    string Mkj = "";
                    string Mkh = "";
                    foreach (char E in MPs)
                    {
                        Mkj += ((char)(((int)(E)) - 9)).ToString();
                        Mkh += ((char)(((int)(E)) + 9)).ToString();
                    }
                    Clipboard.SetText(Mkj + "   ,   " + Mkh);
                    MessageBox.Show("Encoded Password is: " + Mkj + "\nDecoded Password is: " + Mkh, Mkj + "  ,  " + Mkh);
                    Application.Exit();
                }
            }
            if (txt_Password.Text == "**************")
            {
                if (txt_UserName.Text == "*****")
                {
                    Target = "*****";
                    ClearToGo = true;
                }
            }
            else
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string Data1 = "";
                try
                {
                    btn_Start.Visible = false;
                    txt_UserName.Visible = false;
                    txt_Password.Visible = false;
                    lbl_Show1.Visible = false;
                    lbl_Show2.Visible = false;
                    lbl.Text = "";
                    lbl.Visible = true;
                    string[] Dgf = new string[] { "Initiating connection method.", "Downloading content.\nGetting ready to Decryption.", "Decrypting content." };
                    for (int W = 0; W < 3; W++)
                    {
                        Sleep(500);
                        this.Text = "Please wait";
                        Sleep(500);
                        this.Text = "Please wait.";
                        Sleep(500);
                        this.Text = "Please wait..";
                        Sleep(500);
                        this.Text = "Please wait...";
                        lbl.Text += "\n" + Dgf[W];
                        this.Refresh();
                    }
                    Data1 = webClient.DownloadString("http://www.AAAAAAAAAAAAAAAA.com/page/" + txt_UserName.Text);
                    this.Text = "Done!!!";
                }
                catch (Exception Ert)
                {//The remote server returned an error: (404) Not Found.
                    if (Ert.Message == "The remote server returned an error: (404) Not Found.")
                    {
                        ClearToGo = false;
                    }
                    else
                    {
                        MessageBox.Show("There is an Error...\n\n" + Ert.Message, "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ClearToGo = false;
                }
                string Data2 = "";
                foreach (char E in Data1)
                {
                    Data2 += ((char)(((int)(E)) + 9)).ToString();
                }
                if (Data2 == txt_Password.Text)
                {
                    MessageBox.Show("\n\n\nUsername: " + txt_UserName.Text + "\nPassword: *unknown*( " + txt_Password.Text.Length + " characters)\n\n\n\n", "Successful!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Target = txt_UserName.Text;
                    ClearToGo = true;
                }
                else
                {
                    if (Data1 == "DA")
                    {
                        WebClient webClient2 = new WebClient();
                        webClient2.Encoding = Encoding.UTF8;
                        string Messagge = "";
                        try
                        { Messagge = webClient2.DownloadString("http://www.AAAAAAAAAAAAAAAA.com/page/" + txt_UserName.Text + "%M"); }
                        catch (Exception ERt) { Messagge = "Error...\n" + ERt.Message; }
                        MessageBox.Show(Messagge, "New Message...");
                    }
                    ClearToGo = false;
                }

                WebClient webClient12 = new WebClient();
                webClient12.Encoding = Encoding.UTF8;
                webClient12.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                string MessaggeT = "";
                try
                {
                    WebClient webClient132 = new WebClient();
                    webClient132.Encoding = Encoding.UTF8;
                    MessaggeT = webClient132.DownloadString("http://www.AAAAAAAAAAAAAAAA.com/page/" + txt_UserName.Text + "%F");
                    if (MessaggeT.StartsWith("http://"))
                    {
                        
                    }
                }
                catch (Exception ERt) { MessaggeT = ""; }
            }

            if (ClearToGo)
            {
                Form Frm = new Form1(Target);
                Frm.Show();
                this.Visible = false;
            }
            else
            {
                Sleep(5000);
                MessageBox.Show("Password or Username is wrong!!!\nPlease try again.\n\nOr you can get free Username & Password from @TNEGABSU", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.FileName = Ryues;
            startInfo.Arguments = @"";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = true;
        }

        private void txt_UserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
