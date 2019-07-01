namespace FPrintWin
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.chkAktiveKeyb = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkCheckStatus = new System.Windows.Forms.CheckBox();
            this.cbEcrModel = new System.Windows.Forms.ComboBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.btnGetSerial = new System.Windows.Forms.Button();
            this.btnPrintTestPage = new System.Windows.Forms.Button();
            this.btnCheckKey = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlConfig = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.pnlAdvanced = new System.Windows.Forms.Panel();
            this.lblHandShake = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWriteTimeOut = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWriteBuffer = new System.Windows.Forms.TextBox();
            this.txtReadbufferSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReadTimeOut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHandShake = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlConfig.SuspendLayout();
            this.pnlAdvanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(277, 297);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(269, 268);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Config";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.button4);
            this.pnlMain.Controls.Add(this.button1);
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Controls.Add(this.chkAktiveKeyb);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.chkCheckStatus);
            this.pnlMain.Controls.Add(this.cbEcrModel);
            this.pnlMain.Controls.Add(this.txtSerial);
            this.pnlMain.Controls.Add(this.btnGetSerial);
            this.pnlMain.Controls.Add(this.btnPrintTestPage);
            this.pnlMain.Controls.Add(this.btnCheckKey);
            this.pnlMain.Controls.Add(this.txtKey);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(3, 2);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(263, 264);
            this.pnlMain.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(90, 165);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 25);
            this.button4.TabIndex = 86;
            this.button4.Text = "Zhblloko";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(181, 162);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 28);
            this.button1.TabIndex = 85;
            this.button1.Text = "Ruaj";
            this.button1.Click += new System.EventHandler(this.mnuSaveConfig_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(4, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Aktive Keyboard";
            // 
            // chkAktiveKeyb
            // 
            this.chkAktiveKeyb.Checked = true;
            this.chkAktiveKeyb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAktiveKeyb.Location = new System.Drawing.Point(157, 65);
            this.chkAktiveKeyb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAktiveKeyb.Name = "chkAktiveKeyb";
            this.chkAktiveKeyb.Size = new System.Drawing.Size(20, 20);
            this.chkAktiveKeyb.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kontroll Status";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Modeli Kases";
            // 
            // chkCheckStatus
            // 
            this.chkCheckStatus.Checked = true;
            this.chkCheckStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCheckStatus.Location = new System.Drawing.Point(157, 39);
            this.chkCheckStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkCheckStatus.Name = "chkCheckStatus";
            this.chkCheckStatus.Size = new System.Drawing.Size(20, 20);
            this.chkCheckStatus.TabIndex = 8;
            // 
            // cbEcrModel
            // 
            this.cbEcrModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEcrModel.Items.AddRange(new object[] {
            "MP55L",
            "DP50",
            "DP25",
            "MP55B"});
            this.cbEcrModel.Location = new System.Drawing.Point(157, 6);
            this.cbEcrModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEcrModel.Name = "cbEcrModel";
            this.cbEcrModel.Size = new System.Drawing.Size(103, 24);
            this.cbEcrModel.TabIndex = 7;
            // 
            // txtSerial
            // 
            this.txtSerial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerial.Location = new System.Drawing.Point(3, 98);
            this.txtSerial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(171, 22);
            this.txtSerial.TabIndex = 1;
            // 
            // btnGetSerial
            // 
            this.btnGetSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetSerial.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetSerial.Location = new System.Drawing.Point(181, 98);
            this.btnGetSerial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetSerial.Name = "btnGetSerial";
            this.btnGetSerial.Size = new System.Drawing.Size(80, 25);
            this.btnGetSerial.TabIndex = 0;
            this.btnGetSerial.Text = "Get Serial";
            this.btnGetSerial.Click += new System.EventHandler(this.btnGetSerial_Click);
            // 
            // btnPrintTestPage
            // 
            this.btnPrintTestPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintTestPage.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintTestPage.Location = new System.Drawing.Point(5, 165);
            this.btnPrintTestPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrintTestPage.Name = "btnPrintTestPage";
            this.btnPrintTestPage.Size = new System.Drawing.Size(80, 25);
            this.btnPrintTestPage.TabIndex = 4;
            this.btnPrintTestPage.Text = "Print Test";
            this.btnPrintTestPage.Click += new System.EventHandler(this.btnPrintTestPage_Click);
            // 
            // btnCheckKey
            // 
            this.btnCheckKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckKey.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckKey.Location = new System.Drawing.Point(181, 130);
            this.btnCheckKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckKey.Name = "btnCheckKey";
            this.btnCheckKey.Size = new System.Drawing.Size(80, 25);
            this.btnCheckKey.TabIndex = 2;
            this.btnCheckKey.Text = "Verifiko";
            this.btnCheckKey.Click += new System.EventHandler(this.btnCheckKey_Click);
            // 
            // txtKey
            // 
            this.txtKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKey.Location = new System.Drawing.Point(4, 130);
            this.txtKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKey.MaxLength = 11;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(170, 22);
            this.txtKey.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlConfig);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(269, 268);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Com Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlConfig
            // 
            this.pnlConfig.Controls.Add(this.button3);
            this.pnlConfig.Controls.Add(this.button2);
            this.pnlConfig.Controls.Add(this.btnAdvanced);
            this.pnlConfig.Controls.Add(this.cbBaudRate);
            this.pnlConfig.Controls.Add(this.label5);
            this.pnlConfig.Controls.Add(this.cbPort);
            this.pnlConfig.Controls.Add(this.lblBaudRate);
            this.pnlConfig.Controls.Add(this.pnlAdvanced);
            this.pnlConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConfig.Location = new System.Drawing.Point(3, 2);
            this.pnlConfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(263, 264);
            this.pnlConfig.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(231, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 23);
            this.button3.TabIndex = 87;
            this.button3.Text = "R";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnRefreshComPorts_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(179, 62);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 28);
            this.button2.TabIndex = 86;
            this.button2.Text = "Ruaj Port";
            this.button2.Click += new System.EventHandler(this.mnuSaveConfig_Click);
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdvanced.Location = new System.Drawing.Point(51, 62);
            this.btnAdvanced.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(117, 28);
            this.btnAdvanced.TabIndex = 80;
            this.btnAdvanced.Text = "Advanced";
            this.btnAdvanced.Visible = false;
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(142, 34);
            this.cbBaudRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(119, 24);
            this.cbBaudRate.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 81;
            this.label5.Text = "Zgjidh Port";
            // 
            // cbPort
            // 
            this.cbPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPort.Location = new System.Drawing.Point(142, 6);
            this.cbPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(84, 24);
            this.cbPort.TabIndex = 52;
            this.cbPort.TabStop = false;
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.Location = new System.Drawing.Point(3, 37);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(100, 20);
            this.lblBaudRate.TabIndex = 82;
            this.lblBaudRate.Text = "Baud Rate";
            // 
            // pnlAdvanced
            // 
            this.pnlAdvanced.Controls.Add(this.lblHandShake);
            this.pnlAdvanced.Controls.Add(this.label6);
            this.pnlAdvanced.Controls.Add(this.txtWriteTimeOut);
            this.pnlAdvanced.Controls.Add(this.label7);
            this.pnlAdvanced.Controls.Add(this.txtWriteBuffer);
            this.pnlAdvanced.Controls.Add(this.txtReadbufferSize);
            this.pnlAdvanced.Controls.Add(this.label3);
            this.pnlAdvanced.Controls.Add(this.txtReadTimeOut);
            this.pnlAdvanced.Controls.Add(this.label2);
            this.pnlAdvanced.Controls.Add(this.cbHandShake);
            this.pnlAdvanced.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAdvanced.Location = new System.Drawing.Point(0, 118);
            this.pnlAdvanced.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAdvanced.Name = "pnlAdvanced";
            this.pnlAdvanced.Size = new System.Drawing.Size(263, 146);
            this.pnlAdvanced.TabIndex = 83;
            this.pnlAdvanced.Visible = false;
            // 
            // lblHandShake
            // 
            this.lblHandShake.Location = new System.Drawing.Point(3, 9);
            this.lblHandShake.Name = "lblHandShake";
            this.lblHandShake.Size = new System.Drawing.Size(100, 20);
            this.lblHandShake.TabIndex = 0;
            this.lblHandShake.Text = "Hand Shake";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Read Buffer Size";
            // 
            // txtWriteTimeOut
            // 
            this.txtWriteTimeOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWriteTimeOut.Location = new System.Drawing.Point(142, 116);
            this.txtWriteTimeOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWriteTimeOut.Name = "txtWriteTimeOut";
            this.txtWriteTimeOut.Size = new System.Drawing.Size(119, 22);
            this.txtWriteTimeOut.TabIndex = 58;
            this.txtWriteTimeOut.Text = "500";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 59;
            this.label7.Text = "Read TimeOut";
            // 
            // txtWriteBuffer
            // 
            this.txtWriteBuffer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWriteBuffer.Location = new System.Drawing.Point(142, 89);
            this.txtWriteBuffer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWriteBuffer.Name = "txtWriteBuffer";
            this.txtWriteBuffer.Size = new System.Drawing.Size(119, 22);
            this.txtWriteBuffer.TabIndex = 56;
            this.txtWriteBuffer.Text = "2048";
            // 
            // txtReadbufferSize
            // 
            this.txtReadbufferSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReadbufferSize.Location = new System.Drawing.Point(142, 34);
            this.txtReadbufferSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReadbufferSize.Name = "txtReadbufferSize";
            this.txtReadbufferSize.Size = new System.Drawing.Size(119, 22);
            this.txtReadbufferSize.TabIndex = 75;
            this.txtReadbufferSize.Text = "2048";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "Write TimeOut";
            // 
            // txtReadTimeOut
            // 
            this.txtReadTimeOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReadTimeOut.Location = new System.Drawing.Point(142, 62);
            this.txtReadTimeOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReadTimeOut.Name = "txtReadTimeOut";
            this.txtReadTimeOut.Size = new System.Drawing.Size(119, 22);
            this.txtReadTimeOut.TabIndex = 76;
            this.txtReadTimeOut.Text = "500";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 77;
            this.label2.Text = "Write Buffer Size";
            // 
            // cbHandShake
            // 
            this.cbHandShake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbHandShake.Items.AddRange(new object[] {
            "None",
            "XOnXOff",
            "RTS",
            "RTS XOnXOff"});
            this.cbHandShake.Location = new System.Drawing.Point(142, 5);
            this.cbHandShake.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbHandShake.Name = "cbHandShake";
            this.cbHandShake.Size = new System.Drawing.Size(119, 24);
            this.cbHandShake.TabIndex = 54;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 297);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Text = "FPrintWIN";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pnlConfig.ResumeLayout(false);
            this.pnlAdvanced.ResumeLayout(false);
            this.pnlAdvanced.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        internal System.Windows.Forms.Panel pnlConfig;
        private System.Windows.Forms.Button btnAdvanced;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Panel pnlAdvanced;
        private System.Windows.Forms.Label lblHandShake;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWriteTimeOut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWriteBuffer;
        private System.Windows.Forms.TextBox txtReadbufferSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReadTimeOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbHandShake;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkAktiveKeyb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkCheckStatus;
        private System.Windows.Forms.ComboBox cbEcrModel;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Button btnGetSerial;
        private System.Windows.Forms.Button btnPrintTestPage;
        private System.Windows.Forms.Button btnCheckKey;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}

