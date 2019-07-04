namespace TermProject_Calculate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPic = new System.Windows.Forms.Label();
            this.lblStep = new System.Windows.Forms.Label();
            this.lblRange = new System.Windows.Forms.Label();
            this.lblCalc = new System.Windows.Forms.Label();
            this.lblStat = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblMyIP = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tmChk = new System.Windows.Forms.Timer(this.components);
            this.tmCalc = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPic);
            this.groupBox1.Controls.Add(this.lblStep);
            this.groupBox1.Controls.Add(this.lblRange);
            this.groupBox1.Controls.Add(this.lblCalc);
            this.groupBox1.Controls.Add(this.lblStat);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblPort);
            this.groupBox1.Controls.Add(this.lblMyIP);
            this.groupBox1.Location = new System.Drawing.Point(20, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(239, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // lblPic
            // 
            this.lblPic.AutoSize = true;
            this.lblPic.Location = new System.Drawing.Point(18, 204);
            this.lblPic.Name = "lblPic";
            this.lblPic.Size = new System.Drawing.Size(43, 17);
            this.lblPic.TabIndex = 7;
            this.lblPic.Text = "Size: ";
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Location = new System.Drawing.Point(18, 284);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(45, 17);
            this.lblStep.TabIndex = 6;
            this.lblStep.Text = "Step: ";
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(18, 247);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(58, 17);
            this.lblRange.TabIndex = 5;
            this.lblRange.Text = "Range: ";
            // 
            // lblCalc
            // 
            this.lblCalc.AutoSize = true;
            this.lblCalc.Location = new System.Drawing.Point(18, 167);
            this.lblCalc.Name = "lblCalc";
            this.lblCalc.Size = new System.Drawing.Size(62, 17);
            this.lblCalc.TabIndex = 4;
            this.lblCalc.Text = "IsCalc: X";
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.Location = new System.Drawing.Point(18, 124);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(56, 17);
            this.lblStat.TabIndex = 3;
            this.lblStat.Text = "Status: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "5000",
            "5001"});
            this.comboBox1.Location = new System.Drawing.Point(61, 73);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(74, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(18, 77);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(38, 17);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "Port:";
            // 
            // lblMyIP
            // 
            this.lblMyIP.AutoSize = true;
            this.lblMyIP.Location = new System.Drawing.Point(18, 37);
            this.lblMyIP.Name = "lblMyIP";
            this.lblMyIP.Size = new System.Drawing.Size(28, 17);
            this.lblMyIP.TabIndex = 0;
            this.lblMyIP.Text = "IP: ";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(313, 70);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(136, 63);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open Server";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(313, 197);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(136, 63);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close Server";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tmChk
            // 
            this.tmChk.Enabled = true;
            this.tmChk.Interval = 200;
            this.tmChk.Tick += new System.EventHandler(this.tmChk_Tick);
            // 
            // tmCalc
            // 
            this.tmCalc.Enabled = true;
            this.tmCalc.Tick += new System.EventHandler(this.tmCalc_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 347);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Distibuted Computing Project: Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblMyIP;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.Label lblCalc;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer tmChk;
        private System.Windows.Forms.Timer tmCalc;
        private System.Windows.Forms.Label lblPic;
    }
}

