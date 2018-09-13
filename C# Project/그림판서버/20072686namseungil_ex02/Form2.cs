using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PaintChat_Server
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

		//문제 데이터를 초기화
		public void clearQustionData()
		{
			QuetionBox.Clear();
			HintBox.Clear();
		}

		//게임시작 버튼 이벤트 함수.
		private void GameStartButton_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			Form1.instance.gameStart(QuetionBox.Text, HintBox.Text);
			clearQustionData();
		}

		//문제 내기 취소 버튼 이벤트 함수.
		private void QuestionCancleButton_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			clearQustionData();
		}
    }
}
