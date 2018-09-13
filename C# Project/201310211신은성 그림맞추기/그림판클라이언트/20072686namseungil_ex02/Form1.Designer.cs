namespace PaintChat_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.asdfasdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.에디트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.그리기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.지우기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.굵기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.모양ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashDotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IdLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.textIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SetCancleButton = new System.Windows.Forms.Button();
            this.SetButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iDPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.menuStrip2);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 440);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusStrip1.BackgroundImage")));
            this.statusStrip1.Location = new System.Drawing.Point(0, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(328, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "모르고지움ㅎ";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Silver;
            this.menuStrip2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip2.BackgroundImage")));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdfasdfToolStripMenuItem,
            this.에디트ToolStripMenuItem,
            this.굵기ToolStripMenuItem,
            this.모양ToolStripMenuItem,
            this.색ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(328, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // asdfasdfToolStripMenuItem
            // 
            this.asdfasdfToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.asdfasdfToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("asdfasdfToolStripMenuItem.BackgroundImage")));
            this.asdfasdfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기ToolStripMenuItem,
            this.열기OToolStripMenuItem,
            this.저장SToolStripMenuItem});
            this.asdfasdfToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.asdfasdfToolStripMenuItem.Name = "asdfasdfToolStripMenuItem";
            this.asdfasdfToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.asdfasdfToolStripMenuItem.Text = "파일";
            this.asdfasdfToolStripMenuItem.Click += new System.EventHandler(this.asdfasdfToolStripMenuItem_Click);
            // 
            // 새로만들기ToolStripMenuItem
            // 
            this.새로만들기ToolStripMenuItem.Name = "새로만들기ToolStripMenuItem";
            this.새로만들기ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.새로만들기ToolStripMenuItem.Text = "새로만들기(&N)";
            this.새로만들기ToolStripMenuItem.Click += new System.EventHandler(this.새로만들기ToolStripMenuItem_Click);
            // 
            // 열기OToolStripMenuItem
            // 
            this.열기OToolStripMenuItem.Name = "열기OToolStripMenuItem";
            this.열기OToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.열기OToolStripMenuItem.Text = "열기(&O)";
            this.열기OToolStripMenuItem.Click += new System.EventHandler(this.열기OToolStripMenuItem_Click_1);
            // 
            // 저장SToolStripMenuItem
            // 
            this.저장SToolStripMenuItem.Name = "저장SToolStripMenuItem";
            this.저장SToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.저장SToolStripMenuItem.Text = "저장(&S)";
            this.저장SToolStripMenuItem.Click += new System.EventHandler(this.저장SToolStripMenuItem_Click);
            // 
            // 에디트ToolStripMenuItem
            // 
            this.에디트ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.그리기ToolStripMenuItem,
            this.지우기ToolStripMenuItem});
            this.에디트ToolStripMenuItem.Name = "에디트ToolStripMenuItem";
            this.에디트ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.에디트ToolStripMenuItem.Text = "에디트";
            // 
            // 그리기ToolStripMenuItem
            // 
            this.그리기ToolStripMenuItem.Name = "그리기ToolStripMenuItem";
            this.그리기ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.그리기ToolStripMenuItem.Text = "그리기";
            this.그리기ToolStripMenuItem.Click += new System.EventHandler(this.그리기ToolStripMenuItem_Click);
            // 
            // 지우기ToolStripMenuItem
            // 
            this.지우기ToolStripMenuItem.Name = "지우기ToolStripMenuItem";
            this.지우기ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.지우기ToolStripMenuItem.Text = "지우기";
            this.지우기ToolStripMenuItem.Click += new System.EventHandler(this.지우기ToolStripMenuItem_Click_1);
            // 
            // 굵기ToolStripMenuItem
            // 
            this.굵기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.굵기ToolStripMenuItem.Name = "굵기ToolStripMenuItem";
            this.굵기ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.굵기ToolStripMenuItem.Text = "굵기";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(88, 22);
            this.toolStripMenuItem2.Text = "10";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click_1);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(88, 22);
            this.toolStripMenuItem3.Text = "5";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click_1);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(88, 22);
            this.toolStripMenuItem4.Text = "3";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click_1);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(88, 22);
            this.toolStripMenuItem5.Text = "1";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click_1);
            // 
            // 모양ToolStripMenuItem
            // 
            this.모양ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dotToolStripMenuItem,
            this.dashDotToolStripMenuItem,
            this.soildToolStripMenuItem});
            this.모양ToolStripMenuItem.Name = "모양ToolStripMenuItem";
            this.모양ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.모양ToolStripMenuItem.Text = "모양";
            // 
            // dotToolStripMenuItem
            // 
            this.dotToolStripMenuItem.Name = "dotToolStripMenuItem";
            this.dotToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.dotToolStripMenuItem.Text = "Dot";
            this.dotToolStripMenuItem.Click += new System.EventHandler(this.dotToolStripMenuItem_Click_1);
            // 
            // dashDotToolStripMenuItem
            // 
            this.dashDotToolStripMenuItem.Name = "dashDotToolStripMenuItem";
            this.dashDotToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.dashDotToolStripMenuItem.Text = "DashDot";
            this.dashDotToolStripMenuItem.Click += new System.EventHandler(this.dashDotToolStripMenuItem_Click_1);
            // 
            // soildToolStripMenuItem
            // 
            this.soildToolStripMenuItem.Name = "soildToolStripMenuItem";
            this.soildToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.soildToolStripMenuItem.Text = "Soild";
            this.soildToolStripMenuItem.Click += new System.EventHandler(this.soildToolStripMenuItem_Click_1);
            // 
            // 색ToolStripMenuItem
            // 
            this.색ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.변경ToolStripMenuItem});
            this.색ToolStripMenuItem.Name = "색ToolStripMenuItem";
            this.색ToolStripMenuItem.Size = new System.Drawing.Size(31, 20);
            this.색ToolStripMenuItem.Text = "색";
            // 
            // 변경ToolStripMenuItem
            // 
            this.변경ToolStripMenuItem.Name = "변경ToolStripMenuItem";
            this.변경ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.변경ToolStripMenuItem.Text = "변경";
            this.변경ToolStripMenuItem.Click += new System.EventHandler(this.변경ToolStripMenuItem_Click_1);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.BackColor = System.Drawing.Color.White;
            this.IdLabel.Font = new System.Drawing.Font("HY중고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IdLabel.Location = new System.Drawing.Point(24, 29);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(27, 12);
            this.IdLabel.TabIndex = 3;
            this.IdLabel.Text = "ID :";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.BackColor = System.Drawing.Color.White;
            this.PortLabel.Font = new System.Drawing.Font("HY중고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PortLabel.Location = new System.Drawing.Point(15, 66);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(38, 12);
            this.PortLabel.TabIndex = 4;
            this.PortLabel.Text = "Port :";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(61, 25);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(108, 21);
            this.textID.TabIndex = 5;
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(61, 62);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(108, 21);
            this.textPort.TabIndex = 6;
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(384, 458);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(220, 21);
            this.textMessage.TabIndex = 7;
            this.textMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMessage_KeyPress);
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.BackColor = System.Drawing.Color.White;
            this.SendMessageButton.Font = new System.Drawing.Font("HY중고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SendMessageButton.Location = new System.Drawing.Point(232, 4);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(77, 23);
            this.SendMessageButton.TabIndex = 8;
            this.SendMessageButton.Text = "전  송";
            this.SendMessageButton.UseVisualStyleBackColor = false;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.OldLace;
            this.LoginPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginPanel.BackgroundImage")));
            this.LoginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginPanel.Controls.Add(this.textIP);
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Controls.Add(this.SetCancleButton);
            this.LoginPanel.Controls.Add(this.SetButton);
            this.LoginPanel.Controls.Add(this.textPort);
            this.LoginPanel.Controls.Add(this.PortLabel);
            this.LoginPanel.Controls.Add(this.textID);
            this.LoginPanel.Controls.Add(this.IdLabel);
            this.LoginPanel.Location = new System.Drawing.Point(440, 144);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(187, 174);
            this.LoginPanel.TabIndex = 9;
            this.LoginPanel.Visible = false;
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(63, 101);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(106, 21);
            this.textIP.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("HY중고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(26, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP :";
            // 
            // SetCancleButton
            // 
            this.SetCancleButton.BackColor = System.Drawing.Color.White;
            this.SetCancleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetCancleButton.Font = new System.Drawing.Font("HY중고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SetCancleButton.ForeColor = System.Drawing.Color.Black;
            this.SetCancleButton.Location = new System.Drawing.Point(100, 136);
            this.SetCancleButton.Name = "SetCancleButton";
            this.SetCancleButton.Size = new System.Drawing.Size(62, 24);
            this.SetCancleButton.TabIndex = 1;
            this.SetCancleButton.Text = "취 소";
            this.SetCancleButton.UseVisualStyleBackColor = false;
            this.SetCancleButton.Click += new System.EventHandler(this.SetCancleButton_Click);
            // 
            // SetButton
            // 
            this.SetButton.BackColor = System.Drawing.Color.White;
            this.SetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetButton.Font = new System.Drawing.Font("HY중고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SetButton.Location = new System.Drawing.Point(22, 136);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(64, 24);
            this.SetButton.TabIndex = 0;
            this.SetButton.Text = "설 정";
            this.SetButton.UseVisualStyleBackColor = false;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDPORTToolStripMenuItem,
            this.connectionToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.설정ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.설정ToolStripMenuItem.Text = "설정(&O)";
            // 
            // iDPORTToolStripMenuItem
            // 
            this.iDPORTToolStripMenuItem.Name = "iDPORTToolStripMenuItem";
            this.iDPORTToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.iDPORTToolStripMenuItem.Text = "ID/PORT";
            this.iDPORTToolStripMenuItem.Click += new System.EventHandler(this.iDPORTToolStripMenuItem_Click);
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.connectionToolStripMenuItem.Text = "Connection";
            this.connectionToolStripMenuItem.Click += new System.EventHandler(this.connectionToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.설정ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.SendMessageButton);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(378, 452);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 33);
            this.panel2.TabIndex = 11;
            // 
            // chatBox
            // 
            this.chatBox.Location = new System.Drawing.Point(377, 45);
            this.chatBox.Name = "chatBox";
            this.chatBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.chatBox.Size = new System.Drawing.Size(319, 391);
            this.chatBox.TabIndex = 12;
            this.chatBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(708, 505);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chatBox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "그림판_클라이언트";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Button SetCancleButton;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iDPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem asdfasdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 에디트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 그리기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 지우기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 굵기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모양ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem dotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashDotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 변경ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox chatBox;
    }
}

