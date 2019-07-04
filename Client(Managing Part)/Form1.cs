using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TermProject_Manage
{
    public partial class Form1 : Form
    {
        TClient clientCalc1;
        TClient clientCalc2;

        string rbuff1;
        string rbuff2;

        List<int> NumPNOrg1 = new List<int>();
        List<int> NumPNOrg2 = new List<int>();

        List<int> NumPNTrm = new List<int>();

        bool IsPO1 = false;
        bool IsRO1 = false;
        bool IsDraw1 = false;

        bool IsPO2 = false;
        bool IsRO2 = false;
        bool IsDraw2 = false;

        DateTime stime2;

        List<bool> IsPrime = new List<bool>();
        List<int> NumPNOrg = new List<int>();

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtIP1.Text == "" || txtIP2.Text == "") return;

            string serverIP1 = txtIP1.Text;
            string serverIP2 = txtIP2.Text;
            string clientIP = "127.0.0.1";

            if (clientCalc1 == null) clientCalc1 = new TClient(GetDataArrived1);
            clientCalc1.ClientBeginConnect(serverIP1, 5000, clientIP);

            if (clientCalc2 == null) clientCalc2 = new TClient(GetDataArrived2);
            clientCalc2.ClientBeginConnect(serverIP2, 5001, clientIP);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (clientCalc1 == null || clientCalc2 == null)
            {
                MessageBox.Show("Objects are not initialized");
                return;
            }

            if (clientCalc1.ClientStatus() != csConnStatus.Connected || clientCalc2.ClientStatus() != csConnStatus.Connected)
            {
                MessageBox.Show("Servers are not available.");
                return;
            }

            stime2 = DateTime.Now;

            int width = picDraw.Width;
            int height = picDraw.Height;

            string st;

            //// Server1 Command
            st = TSocket.sSTX() + "PS" + Convert.ToString(width) + "," + Convert.ToString(height) + TSocket.sETX();
            clientCalc1.ClientSend(st);

            int RangeMin1 = 2;
            int RangeMax1 = 20000000;
            st = TSocket.sSTX() + "NR" + Convert.ToString(RangeMin1) + "," + Convert.ToString(RangeMax1) + TSocket.sETX();
            clientCalc1.ClientSend(st);

            st = TSocket.sSTX() + "RC" + TSocket.sETX();
            clientCalc1.ClientSend(st);

            // Server2 Command 
            st = TSocket.sSTX() + "PS" + Convert.ToString(width) + "," + Convert.ToString(height) + TSocket.sETX();
            clientCalc2.ClientSend(st);

            int RangeMin2 = 20000001;
            int RangeMax2 = 30000000;
            st = TSocket.sSTX() + "NR" + Convert.ToString(RangeMin2) + "," + Convert.ToString(RangeMax2) + TSocket.sETX();
            clientCalc2.ClientSend(st);

            st = TSocket.sSTX() + "RC" + TSocket.sETX();
            clientCalc2.ClientSend(st);

            //calculatePrimeNumber(2, 20000000);
            //foreach (int num in NumPNOrg)
            //{
            //    Console.Write("{0}\r\n", num.ToString());
            //}
        }

        //private void calculatePrimeNumber(int min, int max)
        //{
        //    // Recording Receiving Time
        //    DateTime stime1 = DateTime.Now;
        //    int cnt = 0;
        //    IsPrime.Clear();
        //    NumPNOrg.Clear();
        //    for (int i = min; i <= max; i++)
        //    {
        //        if (isPrimeNumber(i))
        //        {
        //            cnt++;
        //        }
        //        NumPNOrg.Add(cnt);
        //    }
        //    double dtime1 = Util.TimeInSeconds(stime1);
        //}

        //private bool isPrimeNumber(int n)
        //{
        //    int nchkmax = Convert.ToInt32(Math.Sqrt((double)n));
        //    bool isPrime = true;                //Initialize Prime Flag
        //    for (int i = 2; i <= nchkmax; i++)
        //    {
        //        if (n % i == 0)
        //        {
        //            isPrime = false;
        //            break;                      // the number is not prime number
        //        }
        //    }
        //    return isPrime;
        //}

        private void tmChk_Tick(object sender, EventArgs e)
        {
            if (clientCalc1 == null)
            {
                lblStat1.Text = "Status1: NULL";
                lblRsp1.Text = "Respond1: NULL";
            }
            else
            {
                csConnStatus conn = clientCalc1.ClientStatus();
                lblStat1.Text = "Status1 : " + conn.ToString();
            }

            if (clientCalc2 == null)
            {
                lblStat2.Text = "Status2: NULL";
                lblRsp2.Text = "Respond2: NULL";
            }
            else
            {
                csConnStatus conn = clientCalc2.ClientStatus();
                lblStat2.Text = "Status2 : " + conn.ToString();
            }
        }

        private void GetDataArrived1()
        {
            while (true)
            {
                rbuff1 += clientCalc1.GetRcvMsg();
                int idx1 = rbuff1.IndexOf(TSocket.sSTX());
                if (idx1 < 0) break;
                int idx2 = rbuff1.IndexOf(TSocket.sETX(), idx1);

                if (idx1 >= 0 && idx2 > idx1)
                {
                    string stReq = rbuff1.Substring(idx1 + 1, 2);
                    if (stReq == "PO")
                    {
                        IsPO1 = true;
                    }
                    else if (stReq == "RO")
                    {
                        IsRO1 = true;
                    }
                    else if (stReq == "CS")
                    {
                        lblRsp1.Text = "Respond1: Calculating";
                    }
                    else if (stReq == "CC")
                    {
                        lblRsp1.Text = "Respond1: End";
                        NumPNOrg1.Clear();
                    }
                    else if (stReq == "PN")
                    {
                        string stNum = rbuff1.Substring(idx1 + 3, idx2 - (idx1 + 3));
                        NumPNOrg1.Add(Convert.ToInt32(stNum));
                    }
                    else if (stReq == "TC")
                    {
                        IsDraw1 = true;
                    }
                    // Trim Rx Buffer1
                    rbuff1 = rbuff1.Substring(idx2 + 1);
                }
            }
        }

        private void GetDataArrived2()
        {
            while (true)
            {
                rbuff2 += clientCalc2.GetRcvMsg();
                int idx1 = rbuff2.IndexOf(TSocket.sSTX());
                if (idx1 < 0) break;
                int idx2 = rbuff2.IndexOf(TSocket.sETX(), idx1);

                if (idx1 >= 0 && idx2 > idx1)
                {
                    string stReq = rbuff2.Substring(idx1 + 1, 2);
                    if (stReq == "PO")
                    {
                        IsPO2 = true;
                    }
                    else if (stReq == "RO")
                    {
                        IsRO2 = true;
                    }
                    else if (stReq == "CS")
                    {
                        lblRsp2.Text = "Respond2: Calculating";
                    }
                    else if (stReq == "CC")
                    {
                        lblRsp2.Text = "Respond2: End";
                        NumPNOrg2.Clear();
                    }
                    else if (stReq == "PN")
                    {
                        string stNum = rbuff2.Substring(idx1 + 3, idx2 - (idx1 + 3));
                        NumPNOrg2.Add(Convert.ToInt32(stNum));
                    }
                    else if (stReq == "TC")
                    {
                        IsDraw2 = true;
                    }
                    // Trim Rx Buffer2
                    rbuff2 = rbuff2.Substring(idx2 + 1);
                }
            }
        }

        private void tmDraw_Tick(object sender, EventArgs e)
        {
            if (IsDraw1 && IsDraw2)
            {
                double dtime2 = Util.TimeInSeconds(stime2);
                listLog.Items.Add("Time:" + dtime2);

                IsDraw1 = false;
                IsDraw2 = false;

                // Drawing a plot
                Bitmap bmap = new Bitmap(picDraw.ClientSize.Width, picDraw.ClientSize.Height, PixelFormat.Format24bppRgb);
                Graphics g = Graphics.FromImage(bmap);
                g.Clear(Color.White);

                // Drawing figure using data from 1st server
                for (int i = 0; i < NumPNOrg1.Count - 1; i++)
                {
                    float y0 = AutoScaleY(NumPNOrg1[i], 2000000, picDraw.ClientSize.Height);
                    float y1 = AutoScaleY(NumPNOrg1[i + 1], 2000000, picDraw.ClientSize.Height);
                    g.DrawLine(Pens.Blue, i, y0, i + 1, y1);
                }
                // Drawing figure using data from 2nd server
                for (int i = 0; i < NumPNOrg2.Count - 1; i++)
                {
                    float y0 = AutoScaleY(NumPNOrg2[i] + NumPNOrg1[NumPNOrg1.Count - 1], 2000000, picDraw.ClientSize.Height);
                    float y1 = AutoScaleY(NumPNOrg2[i + 1] + NumPNOrg1[NumPNOrg1.Count - 1], 2000000, picDraw.ClientSize.Height);
                    g.DrawLine(Pens.Blue, i + NumPNOrg1.Count, y0, i + 1 + NumPNOrg1.Count, y1);
                }
                
                // Calculating Prime numbers using Riemann's Prime number theorem
                NumPNTrm.Clear();
                for (int i = 2; i <= 30000000; i++)
                {
                    int num = (int)(i / Math.Log(i));
                    NumPNTrm.Add(num);
                }
                // Drawing figure using Riemann's Prime number theorem
                int loopScale = (30000000 - 2) / picDraw.ClientSize.Width;
                int loopNumber = (30000000 - 2) / loopScale;
                for (int i = 0; i < loopNumber; i++)
                {
                    float x0 = AutoScaleX(i * loopScale, 30000000, picDraw.ClientSize.Width);
                    float y0 = AutoScaleY(NumPNTrm[i * loopScale], 2000000, picDraw.ClientSize.Height);
                    float x1 = AutoScaleX((i + 1) * loopScale, 30000000, picDraw.ClientSize.Width);
                    float y1 = AutoScaleY(NumPNTrm[i * loopScale + 1], 2000000, picDraw.ClientSize.Height);
                    g.DrawLine(Pens.Red, x0, y0, x1, y1);
                }

                picDraw.Image = bmap;
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
    }
}
