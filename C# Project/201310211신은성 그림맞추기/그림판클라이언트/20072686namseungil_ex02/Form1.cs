using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace PaintChat_Client
{
    public partial class Form1 : Form
    {
        
		// Winform 동작에 필요한 데이터.
		private bool isDrag = false;			// 현재 드래그 중인지
		private int setTool = 0;				// 펜 사이즈
		private int setStrip = 0;				// 펜 스타일
		private int setColor = 0;				// 펜 색상
		private ColorDialog clg;				// 펜 색상을 결정하는 다이얼로그

		private bool isRemoveMode_ = false;		// 그리기/지우개 여부
		private Pen currentPen;					// 현재 활성화 된 펜
		private Graphics currentGraphics_;		// 그림판의 그래픽 접근 변수
		private Point previousPoint;			// 이전 포지션
		private Point currentPoint_;			// 현재 포지션

        // 네트워크 관련.
        private TcpClient client;				// TCP 네트워크 서비스에 대한 클라이언트 연결 제공
        private NetworkStream myStream;			// 네트워크 스트림
        private StreamReader myRead;			// 스트림 읽기
        private StreamWriter myWrite;			// 스트림 쓰기
        private Boolean ClientCon = false;		// 클라이언트 시작
        private int myPort;						// 포트
        private string myName;					// 별칭
        private Thread myReader;				// 스레드
        private Boolean TextChange = false;		// 입력 컨트롤의 데이터입력 체크

        public Form1()
        {
            InitializeComponent();

            currentPen = new Pen(Color.Black);
            currentGraphics_ = panel1.CreateGraphics();
        }
  

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            if (this.textMessage.Text == "")
            {
                this.textMessage.Focus();
            }
            else
            {
                Msg_send(); // Msg_send()함수 호출
            }
        }

        private void Msg_send()
        {
            try
            {
                var dt = Convert.ToString(DateTime.Now);
                // 아이디 & 메시지 & 날짜시간을 보냄
                myWrite.WriteLine(this.myName + "&" + this.textMessage.Text + "&" + dt);
                myWrite.Flush();
                // 서버의 rtbText(채팅창)에 id와 메시지 출력
                MessageView(this.myName + ": " + this.textMessage.Text);
                this.textMessage.Clear();
            }
            catch
            {
                MessageView("데이터를 보내는 동안 오류가 발생하였습니다.");
                this.textMessage.Clear();
            }
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = false;
        }

        private void SetCancleButton_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = false;
        }

        private void iDPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = true;
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addr = new IPAddress(0);				// IPAddress 클래스의 개체를 초기화, 매개변수가 0->로컬단말의 아이피 가져옴
            this.myName = textID.Text;
            this.myPort = Convert.ToInt32(this.textPort.Text);
            if (!(this.ClientCon))
            {
                ClientConnection();						// ClientConnection() 함수 호출
            }
            else
            {
                this.textMessage.Enabled = false;
                this.SendMessageButton.Enabled = false;
                Disconnection();						// 함수 호출
            }
        }

        private void ClientConnection()
        {
            try
            {
				// 접속되었다면, 데이터들을 적용 및 초기화함
                client = new TcpClient(this.textIP.Text, this.myPort);
                MessageView("서버에 접속 했습니다.");
                myStream = client.GetStream();
                myRead = new StreamReader(myStream);
                myWrite = new StreamWriter(myStream);
                this.ClientCon = true;
                this.connectionToolStripMenuItem.Enabled = false;
                this.disconnectToolStripMenuItem.Enabled = true;
                this.textMessage.Enabled = true;
                this.SendMessageButton.Enabled = true;
                this.textMessage.Focus();

				// 접속이 성공했음을 서버에 알림
				myWrite.WriteLine("S998&" + this.myName);
				myWrite.Flush();

				// 서버로부터 데이터를 전송받을 리시브 스레드를 생성함
                myReader = new Thread(Receive);
                myReader.Start();
            }
            catch
            {
                this.ClientCon = false;
                MessageView("서버에 접속하지 못 했습니다.   ");
            }
        }

        private void MessageView(string strText, Color color = default(Color))
        {
			if (color == default(Color))
				color = Color.Black;

			// 지정된 문구만 컬러 설정.
			string text = strText + "\r\n";
			int currentLength = this.chatBox.TextLength;	// 현재까지 채팅박스에 기록된 모든 텍스트의 길이
			this.chatBox.AppendText(text);					// 입력한 텍스트와 엔터키추가
			this.chatBox.SelectionStart = currentLength;	// 최종 텍스트의 길이부터 선택 시작
			this.chatBox.SelectionLength = text.Length;		// 현재 작성하려고 하는 메세지의 길이만큼 선택을 종료
			this.chatBox.SelectionColor = color;			// 선택된 메세지만 색상을 적용함
			
			this.chatBox.Focus();							// 초점이동
            this.chatBox.ScrollToCaret();					// 컨트롤의 내용을 현재 캐럿 위치까지 스크롤
            this.textMessage.Focus();						// 초점이동
        }

        
        private void Disconnection()
        {
            this.ClientCon = false;
            this.textMessage.Enabled = false;
            this.textMessage.Clear();
            this.SendMessageButton.Enabled = false;
            this.connectionToolStripMenuItem.Enabled = true;
            this.disconnectToolStripMenuItem.Enabled = false;
            try
            {
				myWrite.WriteLine("S999&" + this.myName);
				myWrite.Flush();

                if (!(myRead == null))
                {
                    myRead.Close(); // StreamReader 클래스 개체 리소스 해제
                }
                if (!(myWrite == null))
                {
                    myWrite.Close(); // StreamWriter 클래스 개체 리소스 해제
                }

                if (!(myStream == null))
                {
                    myStream.Close(); // NetworkStream 클래스 개체 리소스 해제
                }
                if (!(client == null))
                {
                    client.Close(); // TcpClient 클래스 개체 리소스 해제
                }
                if (!(myReader == null))
                {
                    myReader.Abort(); // 외부 스레드 종료
                }
                MessageView("연결이 끊어졌습니다.   ");
            }
            catch
            {
                return;
            }
        }

        // 서버 및 클라이언트 모드에서 myReader 스레드 개체에서 실행되는 메서드로 메시지를 받은 데이터를 화면에 출력하는 작업을 수행
        private void Receive()
        {
            try
            {
                while (this.ClientCon) // 클라이언트의 연결이 종료될때까지 계속 실행
                {
                    if (myStream.CanRead) // 스트림에서 데이터를 읽을 수 있는 경우
                    {
                        var msg = myRead.ReadLine();
                        var Smsg = msg.Split('&'); // &를 기준으로 메시지 구분
                        if (Smsg[0] == "S001") // 첫 구분자가  "S001“인 경우
                        {
							// currentPoint
							var cp = Smsg[1].Split(',');
							currentPoint_.X = panel1.Location.X + Convert.ToInt32((cp[0]));
							currentPoint_.Y = panel1.Location.Y + Convert.ToInt32((cp[1]));

							// previousPoint
							var pp = Smsg[2].Split(',');
							previousPoint.X = panel1.Location.X + Convert.ToInt32((pp[0]));
							previousPoint.Y = panel1.Location.Y + Convert.ToInt32((pp[1]));
							
							// Pen color
							var pc = Smsg[3].Split(',');
							currentPen.Color = Color.FromArgb(Convert.ToInt32(pc[3]), // A
								Convert.ToInt32(pc[0]),		// R
								Convert.ToInt32(pc[1]),		// G
								Convert.ToInt32(pc[2]));	// B
							
							// Pen size
							var ps = Smsg[4];
							currentPen.Width = Convert.ToInt32((ps));

							// Pen style
							var pst = Smsg[5];
							setStrip = Convert.ToInt32((pst));
							if (setStrip == 0)
								currentPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
							else if (setStrip == 1)
								currentPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
							else if (setStrip == 2)
								currentPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;

							// 전송받아 적용된 데이터를 이용하여 그림을 그려줌
							currentGraphics_.DrawLine(currentPen, previousPoint, currentPoint_);
                        }
                        else if (Smsg[0] == "S002")	// 새로 만들기
                        {
							var newFile = Smsg[1];
							if (newFile.Equals("New"))
								panel1.Invalidate();
                        }
                        else if (Smsg[0] == "S003")
                        {
                        }
						else if (Smsg[0] == "S998")	// 서버 종료
						{
							MessageView(Smsg[1]);
							Disconnection();
						}
                        else
                        {
                            if (msg.Length > 0)  // 읽은 메시지가 있는 경우 
                            {
								string computeMessage = Smsg[0] + " : " + Smsg[1];
								
								// 특정 메세지는 색상 변경을 적용함
								Color color = Color.Black;
								if (Smsg[0].Equals("Server"))
								{
									color = Color.Blue;
								}
								else if (Smsg[0].Equals("[게임 시작]") ||
										 Smsg[0].Equals("[Hint]"))
								{
									computeMessage = Smsg[0] + Smsg[1];
									color = Color.Red;
								}
								MessageView(computeMessage, color);
                            }
                        }
                    }
                }
            }
            catch { }

        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.client.Connected) // 연결중인 상태
                {
                    var dt = Convert.ToString(DateTime.Now);
                    myWrite.WriteLine(this.myName + "&" + "채팅 APP가 종료되었습니다." + "&" + dt);
                    myWrite.Flush();
                }
            }
            catch { }
            Disconnection();//클라이언트종료
            this.iDPORTToolStripMenuItem.Enabled = true;
            this.connectionToolStripMenuItem.Enabled = true;
        }

        private void textMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // 엔터 키를 누를때
            {
                e.Handled = true; // 소리 없앰
                if (this.textMessage.Text == "")
                {
                    this.textMessage.Focus();
                }
                else
                {
                    Msg_send(); // Msg_send()함수 호출
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnection(); // 클라이언트종료
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
        }
        

        private void 변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clg = new ColorDialog();
            clg.ShowDialog();
            setColor = 1;
            // Set the initial color of the dialog to the current text color
        }

        private void asdfasdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 그리기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isRemoveMode_ = false;
        }

        private void 지우기ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            isRemoveMode_ = true;
        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void 열기OToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openPanel = new OpenFileDialog();
            openPanel.InitialDirectory = @"C:\";
            openPanel.Filter = "PNG (*.png)|*.png| All files (*.*)|(*.*)";
            if (openPanel.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(openPanel.FileName);
                Graphics g = panel1.CreateGraphics();
                g.DrawImage(bitmap, 0, 0);
            }
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(panel1.Width, panel1.Height);
            Graphics g = Graphics.FromImage(bitmap);

            Size size = panel1.Size;
            g.CopyFromScreen(
                PointToScreen(new Point(panel1.Location.X, panel1.Location.Y)),
                new Point(0, 0),
                size);

            SaveFileDialog savePanel = new SaveFileDialog();
            savePanel.InitialDirectory = @"C:\";
            savePanel.Filter = "PNG (*.png)|*.png| All files (*.*)|(*.*)";
            if (savePanel.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(savePanel.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            setTool = 1;
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            setTool = 2;
        }

        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            setTool = 3;
        }

        private void toolStripMenuItem5_Click_1(object sender, EventArgs e)
        {
            setTool = 0;
        }

        private void dotToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            setStrip = 1;
        }

        private void dashDotToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            setStrip = 2;
        }

        private void soildToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            setStrip = 0;
        }

        private void 변경ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            clg = new ColorDialog();
            clg.ShowDialog();
            setColor = 1;
            // Set the initial color of the dialog to the current text color
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip2.Visible = false;
        }
    }
}
