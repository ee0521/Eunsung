namespace PaintChat_Server
{
    partial class Form2
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.QuetionBox = new System.Windows.Forms.TextBox();
			this.HintBox = new System.Windows.Forms.TextBox();
			this.GameStartButton = new System.Windows.Forms.Button();
			this.QuestionCancleButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "문제";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "힌트";
			// 
			// QuetionBox
			// 
			this.QuetionBox.Location = new System.Drawing.Point(47, 28);
			this.QuetionBox.Name = "QuetionBox";
			this.QuetionBox.Size = new System.Drawing.Size(189, 21);
			this.QuetionBox.TabIndex = 2;
			// 
			// HintBox
			// 
			this.HintBox.Location = new System.Drawing.Point(48, 73);
			this.HintBox.Multiline = true;
			this.HintBox.Name = "HintBox";
			this.HintBox.Size = new System.Drawing.Size(188, 99);
			this.HintBox.TabIndex = 3;
			// 
			// GameStartButton
			// 
			this.GameStartButton.Location = new System.Drawing.Point(16, 193);
			this.GameStartButton.Name = "GameStartButton";
			this.GameStartButton.Size = new System.Drawing.Size(96, 23);
			this.GameStartButton.TabIndex = 4;
			this.GameStartButton.Text = "게임 시작";
			this.GameStartButton.UseVisualStyleBackColor = true;
			this.GameStartButton.Click += new System.EventHandler(this.GameStartButton_Click);
			// 
			// QuestionCancleButton
			// 
			this.QuestionCancleButton.Location = new System.Drawing.Point(142, 193);
			this.QuestionCancleButton.Name = "QuestionCancleButton";
			this.QuestionCancleButton.Size = new System.Drawing.Size(92, 23);
			this.QuestionCancleButton.TabIndex = 5;
			this.QuestionCancleButton.Text = "취소";
			this.QuestionCancleButton.UseVisualStyleBackColor = true;
			this.QuestionCancleButton.Click += new System.EventHandler(this.QuestionCancleButton_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(246, 239);
			this.Controls.Add(this.QuestionCancleButton);
			this.Controls.Add(this.GameStartButton);
			this.Controls.Add(this.HintBox);
			this.Controls.Add(this.QuetionBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "문제";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox QuetionBox;
        private System.Windows.Forms.TextBox HintBox;
		private System.Windows.Forms.Button GameStartButton;
		private System.Windows.Forms.Button QuestionCancleButton;
    }
}