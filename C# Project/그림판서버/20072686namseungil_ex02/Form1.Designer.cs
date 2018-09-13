namespace PaintChat_Server
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.종료FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.새로만들기NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.열기OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.종료XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.에디트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.그리기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.지우개ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.선굵기LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.굵기10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.굵기5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.굵기3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.굵기1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.선모양ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dashDotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.soildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.색변경CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.선LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.iDPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.문제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.출제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.IdLabel = new System.Windows.Forms.Label();
			this.PortLabel = new System.Windows.Forms.Label();
			this.textID = new System.Windows.Forms.TextBox();
			this.textPort = new System.Windows.Forms.TextBox();
			this.textMessage = new System.Windows.Forms.TextBox();
			this.SendMessageButton = new System.Windows.Forms.Button();
			this.LoginPanel = new System.Windows.Forms.Panel();
			this.SetCancleButton = new System.Windows.Forms.Button();
			this.SetButton = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.chatBox = new System.Windows.Forms.RichTextBox();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.LoginPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료FToolStripMenuItem,
            this.에디트ToolStripMenuItem,
            this.선굵기LToolStripMenuItem,
            this.선모양ToolStripMenuItem,
            this.색변경CToolStripMenuItem,
            this.설정ToolStripMenuItem,
            this.문제ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(708, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 종료FToolStripMenuItem
			// 
			this.종료FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기NToolStripMenuItem,
            this.열기OToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.종료XToolStripMenuItem});
			this.종료FToolStripMenuItem.Name = "종료FToolStripMenuItem";
			this.종료FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.종료FToolStripMenuItem.Text = "파일(&F)";
			// 
			// 새로만들기NToolStripMenuItem
			// 
			this.새로만들기NToolStripMenuItem.Name = "새로만들기NToolStripMenuItem";
			this.새로만들기NToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.새로만들기NToolStripMenuItem.Text = "새로 만들기(&N)";
			this.새로만들기NToolStripMenuItem.Click += new System.EventHandler(this.새로만들기NToolStripMenuItem_Click);
			// 
			// 열기OToolStripMenuItem
			// 
			this.열기OToolStripMenuItem.Name = "열기OToolStripMenuItem";
			this.열기OToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.열기OToolStripMenuItem.Text = "열기(&O)";
			this.열기OToolStripMenuItem.Click += new System.EventHandler(this.열기OToolStripMenuItem_Click);
			// 
			// 저장ToolStripMenuItem
			// 
			this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
			this.저장ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.저장ToolStripMenuItem.Text = "저장(&S)";
			this.저장ToolStripMenuItem.Click += new System.EventHandler(this.저장ToolStripMenuItem_Click);
			// 
			// 종료XToolStripMenuItem
			// 
			this.종료XToolStripMenuItem.Name = "종료XToolStripMenuItem";
			this.종료XToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.종료XToolStripMenuItem.Text = "종료(&X)";
			this.종료XToolStripMenuItem.Click += new System.EventHandler(this.종료XToolStripMenuItem_Click);
			// 
			// 에디트ToolStripMenuItem
			// 
			this.에디트ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.그리기ToolStripMenuItem,
            this.지우개ToolStripMenuItem});
			this.에디트ToolStripMenuItem.Name = "에디트ToolStripMenuItem";
			this.에디트ToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.에디트ToolStripMenuItem.Text = "에디트(&E)";
			// 
			// 그리기ToolStripMenuItem
			// 
			this.그리기ToolStripMenuItem.Name = "그리기ToolStripMenuItem";
			this.그리기ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
			this.그리기ToolStripMenuItem.Text = "그리기";
			this.그리기ToolStripMenuItem.Click += new System.EventHandler(this.그리기ToolStripMenuItem_Click);
			// 
			// 지우개ToolStripMenuItem
			// 
			this.지우개ToolStripMenuItem.Name = "지우개ToolStripMenuItem";
			this.지우개ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
			this.지우개ToolStripMenuItem.Text = "지우개";
			this.지우개ToolStripMenuItem.Click += new System.EventHandler(this.지우개ToolStripMenuItem_Click);
			// 
			// 선굵기LToolStripMenuItem
			// 
			this.선굵기LToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.굵기10ToolStripMenuItem,
            this.굵기5ToolStripMenuItem,
            this.굵기3ToolStripMenuItem,
            this.굵기1ToolStripMenuItem});
			this.선굵기LToolStripMenuItem.Name = "선굵기LToolStripMenuItem";
			this.선굵기LToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
			this.선굵기LToolStripMenuItem.Text = "선 굵기(&L)";
			// 
			// 굵기10ToolStripMenuItem
			// 
			this.굵기10ToolStripMenuItem.Name = "굵기10ToolStripMenuItem";
			this.굵기10ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.굵기10ToolStripMenuItem.Text = "굵기 10";
			this.굵기10ToolStripMenuItem.Click += new System.EventHandler(this.굵기10ToolStripMenuItem_Click);
			// 
			// 굵기5ToolStripMenuItem
			// 
			this.굵기5ToolStripMenuItem.Name = "굵기5ToolStripMenuItem";
			this.굵기5ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.굵기5ToolStripMenuItem.Text = "굵기 5";
			this.굵기5ToolStripMenuItem.Click += new System.EventHandler(this.굵기5ToolStripMenuItem_Click);
			// 
			// 굵기3ToolStripMenuItem
			// 
			this.굵기3ToolStripMenuItem.Name = "굵기3ToolStripMenuItem";
			this.굵기3ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.굵기3ToolStripMenuItem.Text = "굵기 3";
			this.굵기3ToolStripMenuItem.Click += new System.EventHandler(this.굵기3ToolStripMenuItem_Click);
			// 
			// 굵기1ToolStripMenuItem
			// 
			this.굵기1ToolStripMenuItem.Name = "굵기1ToolStripMenuItem";
			this.굵기1ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.굵기1ToolStripMenuItem.Text = "굵기 1";
			this.굵기1ToolStripMenuItem.Click += new System.EventHandler(this.굵기1ToolStripMenuItem_Click);
			// 
			// 선모양ToolStripMenuItem
			// 
			this.선모양ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dotToolStripMenuItem,
            this.dashDotToolStripMenuItem,
            this.soildToolStripMenuItem});
			this.선모양ToolStripMenuItem.Name = "선모양ToolStripMenuItem";
			this.선모양ToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
			this.선모양ToolStripMenuItem.Text = "선 모양(&S)";
			// 
			// dotToolStripMenuItem
			// 
			this.dotToolStripMenuItem.Name = "dotToolStripMenuItem";
			this.dotToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.dotToolStripMenuItem.Text = "Dot";
			this.dotToolStripMenuItem.Click += new System.EventHandler(this.dotToolStripMenuItem_Click);
			// 
			// dashDotToolStripMenuItem
			// 
			this.dashDotToolStripMenuItem.Name = "dashDotToolStripMenuItem";
			this.dashDotToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.dashDotToolStripMenuItem.Text = "DashDot";
			this.dashDotToolStripMenuItem.Click += new System.EventHandler(this.dashDotToolStripMenuItem_Click);
			// 
			// soildToolStripMenuItem
			// 
			this.soildToolStripMenuItem.Name = "soildToolStripMenuItem";
			this.soildToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.soildToolStripMenuItem.Text = "Soild";
			this.soildToolStripMenuItem.Click += new System.EventHandler(this.soildToolStripMenuItem_Click);
			// 
			// 색변경CToolStripMenuItem
			// 
			this.색변경CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.선LToolStripMenuItem});
			this.색변경CToolStripMenuItem.Name = "색변경CToolStripMenuItem";
			this.색변경CToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
			this.색변경CToolStripMenuItem.Text = "색 변경(&C)";
			// 
			// 선LToolStripMenuItem
			// 
			this.선LToolStripMenuItem.Name = "선LToolStripMenuItem";
			this.선LToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.선LToolStripMenuItem.Text = "선(&L)";
			this.선LToolStripMenuItem.Click += new System.EventHandler(this.선LToolStripMenuItem_Click);
			// 
			// 설정ToolStripMenuItem
			// 
			this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDPORTToolStripMenuItem,
            this.connectionToolStripMenuItem,
            this.disconnectToolStripMenuItem});
			this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
			this.설정ToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.설정ToolStripMenuItem.Text = "설정(&O)";
			// 
			// iDPORTToolStripMenuItem
			// 
			this.iDPORTToolStripMenuItem.Name = "iDPORTToolStripMenuItem";
			this.iDPORTToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.iDPORTToolStripMenuItem.Text = "ID/PORT";
			this.iDPORTToolStripMenuItem.Click += new System.EventHandler(this.iDPORTToolStripMenuItem_Click);
			// 
			// connectionToolStripMenuItem
			// 
			this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
			this.connectionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.connectionToolStripMenuItem.Text = "Connection";
			this.connectionToolStripMenuItem.Click += new System.EventHandler(this.connectionToolStripMenuItem_Click);
			// 
			// disconnectToolStripMenuItem
			// 
			this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
			this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.disconnectToolStripMenuItem.Text = "Disconnect";
			this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
			// 
			// 문제ToolStripMenuItem
			// 
			this.문제ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.출제ToolStripMenuItem});
			this.문제ToolStripMenuItem.Name = "문제ToolStripMenuItem";
			this.문제ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.문제ToolStripMenuItem.Text = "문제";
			// 
			// 출제ToolStripMenuItem
			// 
			this.출제ToolStripMenuItem.Name = "출제ToolStripMenuItem";
			this.출제ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.출제ToolStripMenuItem.Text = "출제";
			this.출제ToolStripMenuItem.Click += new System.EventHandler(this.출제ToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.statusStrip1);
			this.panel1.Location = new System.Drawing.Point(12, 47);
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
			this.statusStrip1.Text = "statusStrip1";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// IdLabel
			// 
			this.IdLabel.AutoSize = true;
			this.IdLabel.BackColor = System.Drawing.Color.White;
			this.IdLabel.Font = new System.Drawing.Font("HY중고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.IdLabel.Location = new System.Drawing.Point(21, 35);
			this.IdLabel.Name = "IdLabel";
			this.IdLabel.Size = new System.Drawing.Size(30, 13);
			this.IdLabel.TabIndex = 3;
			this.IdLabel.Text = "ID :";
			// 
			// PortLabel
			// 
			this.PortLabel.AutoSize = true;
			this.PortLabel.BackColor = System.Drawing.Color.White;
			this.PortLabel.Font = new System.Drawing.Font("HY중고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.PortLabel.Location = new System.Drawing.Point(13, 79);
			this.PortLabel.Name = "PortLabel";
			this.PortLabel.Size = new System.Drawing.Size(41, 13);
			this.PortLabel.TabIndex = 4;
			this.PortLabel.Text = "Port :";
			// 
			// textID
			// 
			this.textID.Location = new System.Drawing.Point(61, 33);
			this.textID.Name = "textID";
			this.textID.Size = new System.Drawing.Size(108, 21);
			this.textID.TabIndex = 5;
			// 
			// textPort
			// 
			this.textPort.Location = new System.Drawing.Point(63, 76);
			this.textPort.Name = "textPort";
			this.textPort.Size = new System.Drawing.Size(108, 21);
			this.textPort.TabIndex = 6;
			// 
			// textMessage
			// 
			this.textMessage.Location = new System.Drawing.Point(387, 459);
			this.textMessage.Name = "textMessage";
			this.textMessage.Size = new System.Drawing.Size(220, 21);
			this.textMessage.TabIndex = 7;
			this.textMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMessage_KeyPress);
			// 
			// SendMessageButton
			// 
			this.SendMessageButton.BackColor = System.Drawing.Color.White;
			this.SendMessageButton.Font = new System.Drawing.Font("HY중고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.SendMessageButton.Location = new System.Drawing.Point(613, 458);
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
			this.LoginPanel.Controls.Add(this.SetCancleButton);
			this.LoginPanel.Controls.Add(this.SetButton);
			this.LoginPanel.Controls.Add(this.textPort);
			this.LoginPanel.Controls.Add(this.PortLabel);
			this.LoginPanel.Controls.Add(this.textID);
			this.LoginPanel.Controls.Add(this.IdLabel);
			this.LoginPanel.Location = new System.Drawing.Point(435, 121);
			this.LoginPanel.Name = "LoginPanel";
			this.LoginPanel.Size = new System.Drawing.Size(187, 174);
			this.LoginPanel.TabIndex = 9;
			this.LoginPanel.Visible = false;
			// 
			// SetCancleButton
			// 
			this.SetCancleButton.BackColor = System.Drawing.Color.White;
			this.SetCancleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SetCancleButton.Font = new System.Drawing.Font("HY중고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.SetCancleButton.Location = new System.Drawing.Point(101, 128);
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
			this.SetButton.Location = new System.Drawing.Point(21, 128);
			this.SetButton.Name = "SetButton";
			this.SetButton.Size = new System.Drawing.Size(62, 24);
			this.SetButton.TabIndex = 0;
			this.SetButton.Text = "설 정";
			this.SetButton.UseVisualStyleBackColor = false;
			this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
			// 
			// panel2
			// 
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.Location = new System.Drawing.Point(380, 453);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(316, 33);
			this.panel2.TabIndex = 11;
			// 
			// chatBox
			// 
			this.chatBox.Location = new System.Drawing.Point(380, 47);
			this.chatBox.Name = "chatBox";
			this.chatBox.Size = new System.Drawing.Size(316, 391);
			this.chatBox.TabIndex = 12;
			this.chatBox.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(708, 505);
			this.Controls.Add(this.SendMessageButton);
			this.Controls.Add(this.textMessage);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.LoginPanel);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.chatBox);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "그림판_서버";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.LoginPanel.ResumeLayout(false);
			this.LoginPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 종료FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선굵기LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 굵기10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 굵기5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 굵기3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 굵기1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선모양ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashDotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 색변경CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선LToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 에디트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 지우개ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 그리기ToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Button SetCancleButton;
		private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iDPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
		private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem 출제ToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem 문제ToolStripMenuItem;
		private System.Windows.Forms.RichTextBox chatBox;
    }
}

