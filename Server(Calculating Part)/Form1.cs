using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TermProject_Calculate
{
    public partial class Form1 : Form
    {
        List<bool> IsPrime = new List<bool>();
        List<int> NumPNOrg = new List<int>();

        private TServer tcpServer;

        private string rbuff;

        private bool IsCalc = false;
        private bool IsNext = false;

        private int width, height;
        private int NumMin, NumMax;
        private int loopScale;
        private int loopNumber;

        string MyIP = "127.0.0.1";
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            lblMyIP.Text = "IP: " + MyIP;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            int port;
            if (!Int32.TryParse(comboBox1.Text, out port)) return;

            if (tcpServer == null) tcpServer = new TServer(GetCommandArrived);
            tcpServer.ServerStartListen(MyIP, port);

            comboBox1.Enabled = false;
            IsCalc = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (tcpServer != null) tcpServer.ServerClose();
            
            comboBox1.Enabled = true;
        }

        private void tmChk_Tick(object sender, EventArgs e)
        {
            if (tcpServer == null) { lblStat.Text = "Status: NULL"; }
            else
            {
                csConnStatus conn = tcpServer.ServerStatus();
                lblStat.Text = "Status: " + conn.ToString();
            }
        }

        private void tmCalc_Tick(object sender, EventArgs e)
        {
            if (IsCalc)
            {
                IsCalc = false;
                tmCalc.Enabled = false;

                lblCalc.Text = "IsCalc: Calculating";
                Application.DoEvents();

                string st = TSocket.sSTX() + "CS" + TSocket.sETX();
                tcpServer.ServerSend(st);

                calculatePrimeNumber(NumMin, NumMax);

                lblCalc.Text = "IsCalc: End";
                Application.DoEvents();

                st = TSocket.sSTX() + "CC" + TSocket.sETX();
                tcpServer.ServerSend(st);

                for (int i = 0; i < loopNumber; i++)
                {
                    IsNext = false;
                    if (i * loopScale + 2 < NumMin || i * loopScale + 2 > NumMax) continue;
                    else
                    {
                        if (NumMin <= 2)
                        {
                            st = TSocket.sSTX() + "PN" + Convert.ToString(NumPNOrg[i * loopScale]) + TSocket.sETX();
                        }
                        else if (NumMin > 2)
                        {
                            st = TSocket.sSTX() + "PN" + Convert.ToString(NumPNOrg[(i * loopScale) - NumMin]) + TSocket.sETX();
                        }
                        tcpServer.ServerSend(st);
                    }
                }

                st = TSocket.sSTX() + "TC" + TSocket.sETX();
                tcpServer.ServerSend(st);

                tmCalc.Enabled = true;
            }
        }

        private void calculatePrimeNumber(int min, int max)
        {
            // Recording Receiving Time
            DateTime stime1 = DateTime.Now;
            int cnt = 0;
            IsPrime.Clear();
            NumPNOrg.Clear();

            for (int i = min; i <= max; i++)
            {
                if (isPrimeNumber(i))
                {
                    cnt++;
                }
                NumPNOrg.Add(cnt);
            }
            double dtime1 = Util.TimeInSeconds(stime1);
        }

        private bool isPrimeNumber(int n)
        {
            int nchkmax = Convert.ToInt32(Math.Sqrt((double)n));
            bool isPrime = true;                //Initialize Prime Flag
            for (int i = 2; i <= nchkmax; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;                      // the number is not prime number
                }
            }
            return isPrime;
        }

        private void GetCommandArrived()
        {
            while (true)
            {
                rbuff += tcpServer.GetRcvMsg();
                int idx1 = rbuff.IndexOf(TSocket.sSTX());
                if (idx1 < 0) break;
                int idx2 = rbuff.IndexOf(TSocket.sETX(), idx1);

                if (idx1 >= 0 && idx2 > idx1)
                {
                    string stCom = rbuff.Substring(idx1 + 1, 2);
                    if (stCom == "PS")      // Picture Size
                    {
                        string stSize = rbuff.Substring(idx1 + 3, idx2 - (idx1 + 3));
                        string[] pic = stSize.Split(new char[] { ',' });
                        width = Convert.ToInt32(pic[0]);
                        height = Convert.ToInt32(pic[1]);

                        loopScale = (30000000 - 2) / width;
                        loopNumber = (30000000 - 2) / loopScale;

                        lblPic.Text = "Size: " + Convert.ToString(width) + ", " + Convert.ToString(height);
                        lblStep.Text = "Step: " + Convert.ToString(loopScale);
                    }
                    else if (stCom == "NR") // Number Range
                    {
                        string stRange = rbuff.Substring(idx1 + 3, idx2 - (idx1 + 3));
                        string[] range = stRange.Split(new char[] { ',' });
                        NumMin = Convert.ToInt32(range[0]);
                        NumMax = Convert.ToInt32(range[1]);

                        lblRange.Text = "Range: " + Convert.ToString(NumMin) + " ~ " + Convert.ToString(NumMax);
                    }
                    else if (stCom == "RC")  // Request Calculate
                    {
                        IsCalc = true;
                    }
                    rbuff = rbuff.Substring(idx2 + 1);
                }
                else
                    break;
            }
        }

        private float AutoScaleX(int i, int iMax, int width)
        {
            return (float)((i / (double)iMax) * (double)width);
        }

        private float AutoScaleY(int i, int iMax, int height)
        {
            return (float)(height - (i / (double)iMax) * (double)height);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            tcpServer.ServerSend("Test");
        }
    }
}
