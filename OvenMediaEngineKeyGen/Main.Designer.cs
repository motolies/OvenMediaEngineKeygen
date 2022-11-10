namespace OvenMediaEngineKeyGen
{
    partial class Main
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkRtmpStreamExpireUse = new System.Windows.Forms.CheckBox();
            this.dtRtmpStreamExpire = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.chkRtmpUrlActivateUse = new System.Windows.Forms.CheckBox();
            this.dtRtmpUrlActivate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.chkRtmpUrlExpireUse = new System.Windows.Forms.CheckBox();
            this.dtRtmpUrlExpire = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkWsStreamExpireUse = new System.Windows.Forms.CheckBox();
            this.dtWsStreamExpire = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.chkWsUrlActivateUse = new System.Windows.Forms.CheckBox();
            this.dtWsUrlActivate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.chkWsUrlExpireUse = new System.Windows.Forms.CheckBox();
            this.dtWsUrlExpire = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGen = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtWsResult = new OvenMediaEngineKeyGen.TextBoxEx();
            this.txtRtmpResult = new OvenMediaEngineKeyGen.TextBoxEx();
            this.txtWsUrl = new OvenMediaEngineKeyGen.TextBoxEx();
            this.txtWsInputUrl = new OvenMediaEngineKeyGen.TextBoxEx();
            this.txtRtmpUrl = new OvenMediaEngineKeyGen.TextBoxEx();
            this.txtStream = new OvenMediaEngineKeyGen.TextBoxEx();
            this.txtSecretKey = new OvenMediaEngineKeyGen.TextBoxEx();
            this.txtWebRTCResult = new OvenMediaEngineKeyGen.TextBoxEx();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStream);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSecretKey);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Common";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stream";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Secret Key";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtWsInputUrl);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.chkRtmpStreamExpireUse);
            this.groupBox2.Controls.Add(this.dtRtmpStreamExpire);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.chkRtmpUrlActivateUse);
            this.groupBox2.Controls.Add(this.dtRtmpUrlActivate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.chkRtmpUrlExpireUse);
            this.groupBox2.Controls.Add(this.dtRtmpUrlExpire);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtRtmpUrl);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 166);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RTMP";
            // 
            // chkRtmpStreamExpireUse
            // 
            this.chkRtmpStreamExpireUse.AutoSize = true;
            this.chkRtmpStreamExpireUse.Location = new System.Drawing.Point(158, 130);
            this.chkRtmpStreamExpireUse.Name = "chkRtmpStreamExpireUse";
            this.chkRtmpStreamExpireUse.Size = new System.Drawing.Size(46, 16);
            this.chkRtmpStreamExpireUse.TabIndex = 9;
            this.chkRtmpStreamExpireUse.Text = "Use";
            this.chkRtmpStreamExpireUse.UseVisualStyleBackColor = true;
            // 
            // dtRtmpStreamExpire
            // 
            this.dtRtmpStreamExpire.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtRtmpStreamExpire.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRtmpStreamExpire.Location = new System.Drawing.Point(210, 128);
            this.dtRtmpStreamExpire.Name = "dtRtmpStreamExpire";
            this.dtRtmpStreamExpire.Size = new System.Drawing.Size(357, 21);
            this.dtRtmpStreamExpire.TabIndex = 11;
            this.dtRtmpStreamExpire.Value = new System.DateTime(2022, 11, 11, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "stream_expire(KST)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkRtmpUrlActivateUse
            // 
            this.chkRtmpUrlActivateUse.AutoSize = true;
            this.chkRtmpUrlActivateUse.Location = new System.Drawing.Point(158, 103);
            this.chkRtmpUrlActivateUse.Name = "chkRtmpUrlActivateUse";
            this.chkRtmpUrlActivateUse.Size = new System.Drawing.Size(46, 16);
            this.chkRtmpUrlActivateUse.TabIndex = 6;
            this.chkRtmpUrlActivateUse.Text = "Use";
            this.chkRtmpUrlActivateUse.UseVisualStyleBackColor = true;
            // 
            // dtRtmpUrlActivate
            // 
            this.dtRtmpUrlActivate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtRtmpUrlActivate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRtmpUrlActivate.Location = new System.Drawing.Point(210, 101);
            this.dtRtmpUrlActivate.Name = "dtRtmpUrlActivate";
            this.dtRtmpUrlActivate.Size = new System.Drawing.Size(357, 21);
            this.dtRtmpUrlActivate.TabIndex = 8;
            this.dtRtmpUrlActivate.Value = new System.DateTime(2022, 11, 11, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "url_activate(KST)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkRtmpUrlExpireUse
            // 
            this.chkRtmpUrlExpireUse.AutoSize = true;
            this.chkRtmpUrlExpireUse.Checked = true;
            this.chkRtmpUrlExpireUse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRtmpUrlExpireUse.Enabled = false;
            this.chkRtmpUrlExpireUse.Location = new System.Drawing.Point(158, 76);
            this.chkRtmpUrlExpireUse.Name = "chkRtmpUrlExpireUse";
            this.chkRtmpUrlExpireUse.Size = new System.Drawing.Size(46, 16);
            this.chkRtmpUrlExpireUse.TabIndex = 2;
            this.chkRtmpUrlExpireUse.Text = "Use";
            this.chkRtmpUrlExpireUse.UseVisualStyleBackColor = true;
            // 
            // dtRtmpUrlExpire
            // 
            this.dtRtmpUrlExpire.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtRtmpUrlExpire.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRtmpUrlExpire.Location = new System.Drawing.Point(210, 74);
            this.dtRtmpUrlExpire.Name = "dtRtmpUrlExpire";
            this.dtRtmpUrlExpire.Size = new System.Drawing.Size(357, 21);
            this.dtRtmpUrlExpire.TabIndex = 5;
            this.dtRtmpUrlExpire.Value = new System.DateTime(2022, 11, 11, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "url_expire(KST)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Base Url";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkWsStreamExpireUse);
            this.groupBox3.Controls.Add(this.dtWsStreamExpire);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.chkWsUrlActivateUse);
            this.groupBox3.Controls.Add(this.dtWsUrlActivate);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.chkWsUrlExpireUse);
            this.groupBox3.Controls.Add(this.dtWsUrlExpire);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtWsUrl);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(12, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(593, 148);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "WebSocket";
            // 
            // chkWsStreamExpireUse
            // 
            this.chkWsStreamExpireUse.AutoSize = true;
            this.chkWsStreamExpireUse.Enabled = false;
            this.chkWsStreamExpireUse.Location = new System.Drawing.Point(158, 103);
            this.chkWsStreamExpireUse.Name = "chkWsStreamExpireUse";
            this.chkWsStreamExpireUse.Size = new System.Drawing.Size(46, 16);
            this.chkWsStreamExpireUse.TabIndex = 9;
            this.chkWsStreamExpireUse.Text = "Use";
            this.chkWsStreamExpireUse.UseVisualStyleBackColor = true;
            this.chkWsStreamExpireUse.Visible = false;
            // 
            // dtWsStreamExpire
            // 
            this.dtWsStreamExpire.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtWsStreamExpire.Enabled = false;
            this.dtWsStreamExpire.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtWsStreamExpire.Location = new System.Drawing.Point(210, 101);
            this.dtWsStreamExpire.Name = "dtWsStreamExpire";
            this.dtWsStreamExpire.Size = new System.Drawing.Size(357, 21);
            this.dtWsStreamExpire.TabIndex = 11;
            this.dtWsStreamExpire.Value = new System.DateTime(2022, 11, 11, 0, 0, 0, 0);
            this.dtWsStreamExpire.Visible = false;
            // 
            // label7
            // 
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(6, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "stream_expire(KST)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Visible = false;
            // 
            // chkWsUrlActivateUse
            // 
            this.chkWsUrlActivateUse.AutoSize = true;
            this.chkWsUrlActivateUse.Location = new System.Drawing.Point(158, 76);
            this.chkWsUrlActivateUse.Name = "chkWsUrlActivateUse";
            this.chkWsUrlActivateUse.Size = new System.Drawing.Size(46, 16);
            this.chkWsUrlActivateUse.TabIndex = 6;
            this.chkWsUrlActivateUse.Text = "Use";
            this.chkWsUrlActivateUse.UseVisualStyleBackColor = true;
            // 
            // dtWsUrlActivate
            // 
            this.dtWsUrlActivate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtWsUrlActivate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtWsUrlActivate.Location = new System.Drawing.Point(210, 74);
            this.dtWsUrlActivate.Name = "dtWsUrlActivate";
            this.dtWsUrlActivate.Size = new System.Drawing.Size(357, 21);
            this.dtWsUrlActivate.TabIndex = 8;
            this.dtWsUrlActivate.Value = new System.DateTime(2022, 11, 11, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "url_activate(KST)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkWsUrlExpireUse
            // 
            this.chkWsUrlExpireUse.AutoSize = true;
            this.chkWsUrlExpireUse.Checked = true;
            this.chkWsUrlExpireUse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWsUrlExpireUse.Enabled = false;
            this.chkWsUrlExpireUse.Location = new System.Drawing.Point(158, 49);
            this.chkWsUrlExpireUse.Name = "chkWsUrlExpireUse";
            this.chkWsUrlExpireUse.Size = new System.Drawing.Size(46, 16);
            this.chkWsUrlExpireUse.TabIndex = 2;
            this.chkWsUrlExpireUse.Text = "Use";
            this.chkWsUrlExpireUse.UseVisualStyleBackColor = true;
            // 
            // dtWsUrlExpire
            // 
            this.dtWsUrlExpire.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtWsUrlExpire.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtWsUrlExpire.Location = new System.Drawing.Point(210, 47);
            this.dtWsUrlExpire.Name = "dtWsUrlExpire";
            this.dtWsUrlExpire.Size = new System.Drawing.Size(357, 21);
            this.dtWsUrlExpire.TabIndex = 5;
            this.dtWsUrlExpire.Value = new System.DateTime(2022, 11, 11, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "url_expire(KST)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Base Url";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(12, 447);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(593, 33);
            this.btnGen.TabIndex = 13;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 18);
            this.label11.TabIndex = 12;
            this.label11.Text = "Base Url(WebRTC)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtWsResult
            // 
            this.txtWsResult.Location = new System.Drawing.Point(12, 653);
            this.txtWsResult.Multiline = true;
            this.txtWsResult.Name = "txtWsResult";
            this.txtWsResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWsResult.Size = new System.Drawing.Size(593, 73);
            this.txtWsResult.TabIndex = 15;
            // 
            // txtRtmpResult
            // 
            this.txtRtmpResult.Location = new System.Drawing.Point(12, 495);
            this.txtRtmpResult.Multiline = true;
            this.txtRtmpResult.Name = "txtRtmpResult";
            this.txtRtmpResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRtmpResult.Size = new System.Drawing.Size(593, 73);
            this.txtRtmpResult.TabIndex = 14;
            // 
            // txtWsUrl
            // 
            this.txtWsUrl.Location = new System.Drawing.Point(158, 20);
            this.txtWsUrl.Multiline = true;
            this.txtWsUrl.Name = "txtWsUrl";
            this.txtWsUrl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWsUrl.Size = new System.Drawing.Size(409, 21);
            this.txtWsUrl.TabIndex = 3;
            this.txtWsUrl.Text = "wss://video.4xtl.de:3334/app/";
            // 
            // txtWsInputUrl
            // 
            this.txtWsInputUrl.Location = new System.Drawing.Point(158, 47);
            this.txtWsInputUrl.Multiline = true;
            this.txtWsInputUrl.Name = "txtWsInputUrl";
            this.txtWsInputUrl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWsInputUrl.Size = new System.Drawing.Size(409, 21);
            this.txtWsInputUrl.TabIndex = 13;
            this.txtWsInputUrl.Text = "wss://rtmp.4xtl.de:3334/app/";
            // 
            // txtRtmpUrl
            // 
            this.txtRtmpUrl.Location = new System.Drawing.Point(158, 20);
            this.txtRtmpUrl.Multiline = true;
            this.txtRtmpUrl.Name = "txtRtmpUrl";
            this.txtRtmpUrl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRtmpUrl.Size = new System.Drawing.Size(409, 21);
            this.txtRtmpUrl.TabIndex = 3;
            this.txtRtmpUrl.Text = "rtmp://rtmp.4xtl.de:1935/app/";
            // 
            // txtStream
            // 
            this.txtStream.Location = new System.Drawing.Point(158, 50);
            this.txtStream.Multiline = true;
            this.txtStream.Name = "txtStream";
            this.txtStream.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStream.Size = new System.Drawing.Size(409, 21);
            this.txtStream.TabIndex = 5;
            this.txtStream.Text = "myStream";
            // 
            // txtSecretKey
            // 
            this.txtSecretKey.Location = new System.Drawing.Point(158, 23);
            this.txtSecretKey.Multiline = true;
            this.txtSecretKey.Name = "txtSecretKey";
            this.txtSecretKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSecretKey.Size = new System.Drawing.Size(409, 21);
            this.txtSecretKey.TabIndex = 1;
            this.txtSecretKey.Text = "4xtl.video#@#";
            // 
            // txtWebRTCResult
            // 
            this.txtWebRTCResult.Location = new System.Drawing.Point(12, 574);
            this.txtWebRTCResult.Multiline = true;
            this.txtWebRTCResult.Name = "txtWebRTCResult";
            this.txtWebRTCResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWebRTCResult.Size = new System.Drawing.Size(593, 73);
            this.txtWebRTCResult.TabIndex = 16;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 742);
            this.Controls.Add(this.txtWebRTCResult);
            this.Controls.Add(this.txtWsResult);
            this.Controls.Add(this.txtRtmpResult);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OvenMediaEngine Signed Policy Generator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private TextBoxEx txtSecretKey;
        private TextBoxEx txtStream;
        private System.Windows.Forms.Label label3;
        private TextBoxEx txtRtmpUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtRtmpUrlExpire;
        private System.Windows.Forms.CheckBox chkRtmpStreamExpireUse;
        private System.Windows.Forms.DateTimePicker dtRtmpStreamExpire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkRtmpUrlActivateUse;
        private System.Windows.Forms.DateTimePicker dtRtmpUrlActivate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkRtmpUrlExpireUse;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkWsStreamExpireUse;
        private System.Windows.Forms.DateTimePicker dtWsStreamExpire;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkWsUrlActivateUse;
        private System.Windows.Forms.DateTimePicker dtWsUrlActivate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkWsUrlExpireUse;
        private System.Windows.Forms.DateTimePicker dtWsUrlExpire;
        private System.Windows.Forms.Label label9;
        private TextBoxEx txtWsUrl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGen;
        private TextBoxEx txtRtmpResult;
        private TextBoxEx txtWsResult;
        private TextBoxEx txtWsInputUrl;
        private System.Windows.Forms.Label label11;
        private TextBoxEx txtWebRTCResult;
    }
}

