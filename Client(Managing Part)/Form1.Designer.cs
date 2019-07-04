namespace TermProject_Manage
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picDraw = new System.Windows.Forms.PictureBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.listLog = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPort1 = new System.Windows.Forms.Label();
            this.lblPort2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIP2 = new System.Windows.Forms.TextBox();
            this.lblRsp2 = new System.Windows.Forms.Label();
            this.txtIP1 = new System.Windows.Forms.TextBox();
            this.lblRsp1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRng2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRng1 = new System.Windows.Forms.Label();
            this.lblStat2 = new System.Windows.Forms.Label();
            this.lblStat1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tmChk = new System.Windows.Forms.Timer(this.components);
            this.tmDraw = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picDraw
            // 
            this.picDraw.BackColor = System.Drawing.Color.White;
            this.picDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDraw.Location = new System.Drawing.Point(14, 16);
            this.picDraw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picDraw.Name = "picDraw";
            this.picDraw.Size = new System.Drawing.Size(800, 399);
            this.picDraw.TabIndex = 0;
            this.picDraw.TabStop = false;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(883, 495);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(103, 44);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Command Calculating";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // listLog
            // 
            this.listLog.FormattingEnabled = true;
            this.listLog.HorizontalScrollbar = true;
            this.listLog.ItemHeight = 16;
            this.listLog.Location = new System.Drawing.Point(821, 16);
            this.listLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listLog.Name = "listLog";
            this.listLog.ScrollAlwaysVisible = true;
            this.listLog.Size = new System.Drawing.Size(165, 404);
            this.listLog.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "2,000,000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(731, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "30,000,000";
            // 
            // lblPort1
            // 
            this.lblPort1.AutoSize = true;
            this.lblPort1.Location = new System.Drawing.Point(10, 31);
            this.lblPort1.Name = "lblPort1";
            this.lblPort1.Size = new System.Drawing.Size(82, 17);
            this.lblPort1.TabIndex = 9;
            this.lblPort1.Text = "Port1: 5000";
            // 
            // lblPort2
            // 
            this.lblPort2.AutoSize = true;
            this.lblPort2.Location = new System.Drawing.Point(10, 65);
            this.lblPort2.Name = "lblPort2";
            this.lblPort2.Size = new System.Drawing.Size(82, 17);
            this.lblPort2.TabIndex = 10;
            this.lblPort2.Text = "Port2: 5001";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIP2);
            this.groupBox1.Controls.Add(this.lblRsp2);
            this.groupBox1.Controls.Add(this.txtIP1);
            this.groupBox1.Controls.Add(this.lblRsp1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblRng2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblRng1);
            this.groupBox1.Controls.Add(this.lblStat2);
            this.groupBox1.Controls.Add(this.lblStat1);
            this.groupBox1.Controls.Add(this.lblPort1);
            this.groupBox1.Controls.Add(this.lblPort2);
            this.groupBox1.Location = new System.Drawing.Point(14, 440);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(863, 99);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // txtIP2
            // 
            this.txtIP2.Location = new System.Drawing.Point(697, 61);
            this.txtIP2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIP2.Name = "txtIP2";
            this.txtIP2.Size = new System.Drawing.Size(135, 22);
            this.txtIP2.TabIndex = 16;
            this.txtIP2.Text = "127.0.0.1";
            // 
            // lblRsp2
            // 
            this.lblRsp2.AutoSize = true;
            this.lblRsp2.Location = new System.Drawing.Point(501, 65);
            this.lblRsp2.Name = "lblRsp2";
            this.lblRsp2.Size = new System.Drawing.Size(117, 17);
            this.lblRsp2.TabIndex = 18;
            this.lblRsp2.Text = "Respond2: NULL";
            // 
            // txtIP1
            // 
            this.txtIP1.Location = new System.Drawing.Point(697, 25);
            this.txtIP1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIP1.Name = "txtIP1";
            this.txtIP1.Size = new System.Drawing.Size(135, 22);
            this.txtIP1.TabIndex = 15;
            this.txtIP1.Text = "127.0.0.1";
            // 
            // lblRsp1
            // 
            this.lblRsp1.AutoSize = true;
            this.lblRsp1.Location = new System.Drawing.Point(501, 31);
            this.lblRsp1.Name = "lblRsp1";
            this.lblRsp1.Size = new System.Drawing.Size(117, 17);
            this.lblRsp1.TabIndex = 17;
            this.lblRsp1.Text = "Respond1: NULL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(665, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "IP2:";
            // 
            // lblRng2
            // 
            this.lblRng2.AutoSize = true;
            this.lblRng2.Location = new System.Drawing.Point(267, 65);
            this.lblRng2.Name = "lblRng2";
            this.lblRng2.Size = new System.Drawing.Size(226, 17);
            this.lblRng2.TabIndex = 16;
            this.lblRng2.Text = "Range2: 20,000,001 ~ 30,000,000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "IP1:";
            // 
            // lblRng1
            // 
            this.lblRng1.AutoSize = true;
            this.lblRng1.Location = new System.Drawing.Point(267, 31);
            this.lblRng1.Name = "lblRng1";
            this.lblRng1.Size = new System.Drawing.Size(162, 17);
            this.lblRng1.TabIndex = 15;
            this.lblRng1.Text = "Range1: 2 ~ 20,000,000";
            // 
            // lblStat2
            // 
            this.lblStat2.AutoSize = true;
            this.lblStat2.Location = new System.Drawing.Point(110, 65);
            this.lblStat2.Name = "lblStat2";
            this.lblStat2.Size = new System.Drawing.Size(100, 17);
            this.lblStat2.TabIndex = 12;
            this.lblStat2.Text = "Status2: NULL";
            // 
            // lblStat1
            // 
            this.lblStat1.AutoSize = true;
            this.lblStat1.Location = new System.Drawing.Point(110, 31);
            this.lblStat1.Name = "lblStat1";
            this.lblStat1.Size = new System.Drawing.Size(100, 17);
            this.lblStat1.TabIndex = 11;
            this.lblStat1.Text = "Status1: NULL";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(883, 447);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(103, 40);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tmChk
            // 
            this.tmChk.Enabled = true;
            this.tmChk.Interval = 200;
            this.tmChk.Tick += new System.EventHandler(this.tmChk_Tick);
            // 
            // tmDraw
            // 
            this.tmDraw.Enabled = true;
            this.tmDraw.Tick += new System.EventHandler(this.tmDraw_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(24, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Line Red: Riemann\'s Prime Number Theorem";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(24, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(281, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Line Blue: Actual Prime Number Calculation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 555);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listLog);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.picDraw);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Distributed Computing Project: Client";
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDraw;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPort1;
        private System.Windows.Forms.Label lblPort2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStat2;
        private System.Windows.Forms.Label lblStat1;
        private System.Windows.Forms.Label lblRng2;
        private System.Windows.Forms.Label lblRng1;
        private System.Windows.Forms.Label lblRsp2;
        private System.Windows.Forms.Label lblRsp1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Timer tmChk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIP1;
        private System.Windows.Forms.TextBox txtIP2;
        private System.Windows.Forms.Timer tmDraw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

