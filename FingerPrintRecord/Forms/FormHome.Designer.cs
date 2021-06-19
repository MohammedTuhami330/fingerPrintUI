
namespace FingerPrintRecord.Forms
{
    partial class FormHome
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
            this.btnIsTFT = new System.Windows.Forms.Button();
            this.btnDisWithTimeOut = new System.Windows.Forms.Button();
            this.chkEnable = new System.Windows.Forms.CheckBox();
            this.btnUnlockDoor = new System.Windows.Forms.Button();
            this.txtDeviceNo = new System.Windows.Forms.TextBox();
            this.lblDeviceNo = new System.Windows.Forms.Label();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.txtCommPort = new System.Windows.Forms.TextBox();
            this.txtCommKey = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIPAdd = new System.Windows.Forms.TextBox();
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.lblDelay = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblCommPort = new System.Windows.Forms.Label();
            this.lblCommKey = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIPAdd = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnAdvance = new System.Windows.Forms.Button();
            this.btnSetComm = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.rBtnUSB = new System.Windows.Forms.RadioButton();
            this.rBtnCOM = new System.Windows.Forms.RadioButton();
            this.rBtnIP = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.List1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnIsTFT
            // 
            this.btnIsTFT.Location = new System.Drawing.Point(229, 175);
            this.btnIsTFT.Name = "btnIsTFT";
            this.btnIsTFT.Size = new System.Drawing.Size(89, 25);
            this.btnIsTFT.TabIndex = 168;
            this.btnIsTFT.Text = "Is TFT";
            this.btnIsTFT.UseVisualStyleBackColor = false;
            // 
            // btnDisWithTimeOut
            // 
            this.btnDisWithTimeOut.Location = new System.Drawing.Point(188, 277);
            this.btnDisWithTimeOut.Name = "btnDisWithTimeOut";
            this.btnDisWithTimeOut.Size = new System.Drawing.Size(162, 25);
            this.btnDisWithTimeOut.TabIndex = 167;
            this.btnDisWithTimeOut.Text = "Disable Device with Timeout";
            this.btnDisWithTimeOut.UseVisualStyleBackColor = false;
            // 
            // chkEnable
            // 
            this.chkEnable.Location = new System.Drawing.Point(282, 234);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Size = new System.Drawing.Size(74, 37);
            this.chkEnable.TabIndex = 141;
            this.chkEnable.Text = "Enable / Disable";
            this.chkEnable.UseVisualStyleBackColor = true;
            // 
            // btnUnlockDoor
            // 
            this.btnUnlockDoor.Location = new System.Drawing.Point(188, 241);
            this.btnUnlockDoor.Name = "btnUnlockDoor";
            this.btnUnlockDoor.Size = new System.Drawing.Size(89, 25);
            this.btnUnlockDoor.TabIndex = 155;
            this.btnUnlockDoor.Text = "Unlock Door";
            this.btnUnlockDoor.UseVisualStyleBackColor = false;
            // 
            // txtDeviceNo
            // 
            this.txtDeviceNo.AcceptsReturn = true;
            this.txtDeviceNo.Location = new System.Drawing.Point(282, 208);
            this.txtDeviceNo.MaxLength = 0;
            this.txtDeviceNo.Name = "txtDeviceNo";
            this.txtDeviceNo.Size = new System.Drawing.Size(81, 20);
            this.txtDeviceNo.TabIndex = 147;
            this.txtDeviceNo.Text = "1";
            // 
            // lblDeviceNo
            // 
            this.lblDeviceNo.Location = new System.Drawing.Point(196, 211);
            this.lblDeviceNo.Name = "lblDeviceNo";
            this.lblDeviceNo.Size = new System.Drawing.Size(65, 17);
            this.lblDeviceNo.TabIndex = 159;
            this.lblDeviceNo.Text = "Device No";
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.AcceptsReturn = true;
            this.txtTimeOut.Location = new System.Drawing.Point(90, 264);
            this.txtTimeOut.MaxLength = 0;
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(81, 20);
            this.txtTimeOut.TabIndex = 166;
            this.txtTimeOut.Text = "10";
            // 
            // txtDelay
            // 
            this.txtDelay.AcceptsReturn = true;
            this.txtDelay.Location = new System.Drawing.Point(90, 238);
            this.txtDelay.MaxLength = 0;
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(81, 20);
            this.txtDelay.TabIndex = 156;
            this.txtDelay.Text = "1000";
            // 
            // txtModel
            // 
            this.txtModel.AcceptsReturn = true;
            this.txtModel.Location = new System.Drawing.Point(90, 208);
            this.txtModel.MaxLength = 0;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(81, 20);
            this.txtModel.TabIndex = 145;
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.AcceptsReturn = true;
            this.txtBaudRate.Location = new System.Drawing.Point(90, 178);
            this.txtBaudRate.MaxLength = 0;
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(81, 20);
            this.txtBaudRate.TabIndex = 150;
            this.txtBaudRate.Text = "115200";
            // 
            // txtCommPort
            // 
            this.txtCommPort.AcceptsReturn = true;
            this.txtCommPort.Location = new System.Drawing.Point(90, 146);
            this.txtCommPort.MaxLength = 0;
            this.txtCommPort.Name = "txtCommPort";
            this.txtCommPort.Size = new System.Drawing.Size(81, 20);
            this.txtCommPort.TabIndex = 140;
            this.txtCommPort.Text = "1";
            // 
            // txtCommKey
            // 
            this.txtCommKey.AcceptsReturn = true;
            this.txtCommKey.Location = new System.Drawing.Point(90, 110);
            this.txtCommKey.MaxLength = 0;
            this.txtCommKey.Name = "txtCommKey";
            this.txtCommKey.Size = new System.Drawing.Size(81, 20);
            this.txtCommKey.TabIndex = 148;
            this.txtCommKey.Text = "0";
            // 
            // txtPort
            // 
            this.txtPort.AcceptsReturn = true;
            this.txtPort.Location = new System.Drawing.Point(90, 78);
            this.txtPort.MaxLength = 0;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(81, 20);
            this.txtPort.TabIndex = 152;
            this.txtPort.Text = "4370";
            // 
            // txtIPAdd
            // 
            this.txtIPAdd.AcceptsReturn = true;
            this.txtIPAdd.Location = new System.Drawing.Point(90, 47);
            this.txtIPAdd.MaxLength = 0;
            this.txtIPAdd.Name = "txtIPAdd";
            this.txtIPAdd.Size = new System.Drawing.Size(81, 20);
            this.txtIPAdd.TabIndex = 154;
            this.txtIPAdd.Text = "192.168.1.201";
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.Location = new System.Drawing.Point(9, 272);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(65, 17);
            this.lblTimeOut.TabIndex = 165;
            this.lblTimeOut.Text = "Time Out (s)";
            // 
            // lblDelay
            // 
            this.lblDelay.Location = new System.Drawing.Point(9, 241);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(65, 17);
            this.lblDelay.TabIndex = 157;
            this.lblDelay.Text = "Delay (ms)";
            // 
            // lblModel
            // 
            this.lblModel.Location = new System.Drawing.Point(12, 208);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(65, 17);
            this.lblModel.TabIndex = 158;
            this.lblModel.Text = "Model";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.Location = new System.Drawing.Point(12, 181);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(65, 17);
            this.lblBaudRate.TabIndex = 161;
            this.lblBaudRate.Text = "Baud Rate";
            // 
            // lblCommPort
            // 
            this.lblCommPort.Location = new System.Drawing.Point(12, 146);
            this.lblCommPort.Name = "lblCommPort";
            this.lblCommPort.Size = new System.Drawing.Size(65, 17);
            this.lblCommPort.TabIndex = 164;
            this.lblCommPort.Text = "Comm Port";
            // 
            // lblCommKey
            // 
            this.lblCommKey.Location = new System.Drawing.Point(9, 113);
            this.lblCommKey.Name = "lblCommKey";
            this.lblCommKey.Size = new System.Drawing.Size(65, 17);
            this.lblCommKey.TabIndex = 160;
            this.lblCommKey.Text = "Comm Key";
            // 
            // lblPort
            // 
            this.lblPort.Location = new System.Drawing.Point(12, 81);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(65, 17);
            this.lblPort.TabIndex = 162;
            this.lblPort.Text = "Port";
            // 
            // lblIPAdd
            // 
            this.lblIPAdd.Location = new System.Drawing.Point(9, 47);
            this.lblIPAdd.Name = "lblIPAdd";
            this.lblIPAdd.Size = new System.Drawing.Size(65, 17);
            this.lblIPAdd.TabIndex = 163;
            this.lblIPAdd.Text = "IP Address  ";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(229, 146);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(89, 25);
            this.btnRestart.TabIndex = 153;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            // 
            // btnAdvance
            // 
            this.btnAdvance.Location = new System.Drawing.Point(229, 113);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(89, 25);
            this.btnAdvance.TabIndex = 151;
            this.btnAdvance.Text = "Advance";
            this.btnAdvance.UseVisualStyleBackColor = false;
            // 
            // btnSetComm
            // 
            this.btnSetComm.Location = new System.Drawing.Point(229, 73);
            this.btnSetComm.Name = "btnSetComm";
            this.btnSetComm.Size = new System.Drawing.Size(89, 25);
            this.btnSetComm.TabIndex = 149;
            this.btnSetComm.Text = "Set Comm Key";
            this.btnSetComm.UseVisualStyleBackColor = false;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(229, 42);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(89, 25);
            this.btnDisconnect.TabIndex = 146;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(229, 8);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(89, 25);
            this.btnConnect.TabIndex = 143;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // rBtnUSB
            // 
            this.rBtnUSB.AutoSize = true;
            this.rBtnUSB.Location = new System.Drawing.Point(137, 12);
            this.rBtnUSB.Name = "rBtnUSB";
            this.rBtnUSB.Size = new System.Drawing.Size(86, 17);
            this.rBtnUSB.TabIndex = 144;
            this.rBtnUSB.TabStop = true;
            this.rBtnUSB.Text = "USB Client    ";
            this.rBtnUSB.UseVisualStyleBackColor = true;
            // 
            // rBtnCOM
            // 
            this.rBtnCOM.AutoSize = true;
            this.rBtnCOM.Location = new System.Drawing.Point(65, 12);
            this.rBtnCOM.Name = "rBtnCOM";
            this.rBtnCOM.Size = new System.Drawing.Size(57, 17);
            this.rBtnCOM.TabIndex = 142;
            this.rBtnCOM.TabStop = true;
            this.rBtnCOM.Text = "COM   ";
            this.rBtnCOM.UseVisualStyleBackColor = true;
            // 
            // rBtnIP
            // 
            this.rBtnIP.AutoSize = true;
            this.rBtnIP.Location = new System.Drawing.Point(12, 12);
            this.rBtnIP.Name = "rBtnIP";
            this.rBtnIP.Size = new System.Drawing.Size(47, 17);
            this.rBtnIP.TabIndex = 139;
            this.rBtnIP.TabStop = true;
            this.rBtnIP.Text = "IP    ";
            this.rBtnIP.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 170;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // List1
            // 
            this.List1.ForeColor = System.Drawing.Color.Red;
            this.List1.IntegralHeight = false;
            this.List1.Location = new System.Drawing.Point(15, 308);
            this.List1.Name = "List1";
            this.List1.Size = new System.Drawing.Size(625, 165);
            this.List1.TabIndex = 169;
            this.List1.TabStop = false;
            this.List1.SelectedIndexChanged += new System.EventHandler(this.List1_SelectedIndexChanged);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.List1);
            this.Controls.Add(this.btnIsTFT);
            this.Controls.Add(this.btnDisWithTimeOut);
            this.Controls.Add(this.chkEnable);
            this.Controls.Add(this.btnUnlockDoor);
            this.Controls.Add(this.txtDeviceNo);
            this.Controls.Add(this.lblDeviceNo);
            this.Controls.Add(this.txtTimeOut);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtBaudRate);
            this.Controls.Add(this.txtCommPort);
            this.Controls.Add(this.txtCommKey);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIPAdd);
            this.Controls.Add(this.lblTimeOut);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblBaudRate);
            this.Controls.Add(this.lblCommPort);
            this.Controls.Add(this.lblCommKey);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblIPAdd);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnAdvance);
            this.Controls.Add(this.btnSetComm);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.rBtnUSB);
            this.Controls.Add(this.rBtnCOM);
            this.Controls.Add(this.rBtnIP);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnIsTFT;
        public System.Windows.Forms.Button btnDisWithTimeOut;
        private System.Windows.Forms.CheckBox chkEnable;
        public System.Windows.Forms.Button btnUnlockDoor;
        public System.Windows.Forms.TextBox txtDeviceNo;
        public System.Windows.Forms.Label lblDeviceNo;
        public System.Windows.Forms.TextBox txtTimeOut;
        public System.Windows.Forms.TextBox txtDelay;
        public System.Windows.Forms.TextBox txtModel;
        public System.Windows.Forms.TextBox txtBaudRate;
        public System.Windows.Forms.TextBox txtCommPort;
        public System.Windows.Forms.TextBox txtCommKey;
        public System.Windows.Forms.TextBox txtPort;
        public System.Windows.Forms.TextBox txtIPAdd;
        public System.Windows.Forms.Label lblTimeOut;
        public System.Windows.Forms.Label lblDelay;
        public System.Windows.Forms.Label lblModel;
        public System.Windows.Forms.Label lblBaudRate;
        public System.Windows.Forms.Label lblCommPort;
        public System.Windows.Forms.Label lblCommKey;
        public System.Windows.Forms.Label lblPort;
        public System.Windows.Forms.Label lblIPAdd;
        public System.Windows.Forms.Button btnRestart;
        public System.Windows.Forms.Button btnAdvance;
        public System.Windows.Forms.Button btnSetComm;
        public System.Windows.Forms.Button btnDisconnect;
        public System.Windows.Forms.Button btnConnect;
        public System.Windows.Forms.RadioButton rBtnUSB;
        public System.Windows.Forms.RadioButton rBtnCOM;
        public System.Windows.Forms.RadioButton rBtnIP;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox List1;
    }
}