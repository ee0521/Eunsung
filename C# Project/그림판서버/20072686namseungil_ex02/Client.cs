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

namespace PaintChat_Server
{
	// 유저 정보
	// 각 유저의 아이디 및 네트워크 통신 관련 스트림 변수들을 관리
	public class Client
	{
		private string id_;				// 클라이언트 아이디
		private TcpClient client_;		// TCP 네트워크 서비스에 대한 클라이언트 연결 제공
		private NetworkStream stream_;  // 네트워크 스트림
		private StreamReader reader_;	// 스트림 읽기
		private StreamWriter writer_;	// 스트림 쓰기
		private bool clientCon_;		// 클라이언트 시작
		private Thread receiveThread_;	// 데이터 받기 쓰레드
		private bool isMaster_;			// 문제 출제자 여부

		public Client(TcpClient client)
		{
			id_ = "Empty";
			client_ = client;
			stream_ = client_.GetStream();
			reader_ = new StreamReader(stream_);
			writer_ = new StreamWriter(stream_);
			clientCon_ = true;
			receiveThread_ = new Thread(receive);
			receiveThread_.Start();
			isMaster_ = false;
		}

		public string getID() { return id_; }				// 클라이언트 ID
		public bool isClientCon() { return clientCon_; }	// 클라이언트 접속 여부
		public void setMaster() { isMaster_ = true; }		// 문제 출제자 여부

		// 전송받은 스트림에서 데이터를 읽어들임.
		public string readData()
		{
			return reader_.ReadLine();	
		}

		// 데이터를 스트림에 작성하고, 보냄
		public void writeData(string value)	
		{
			writer_.WriteLine(value);	// 스트림에 데이터 작성
			writer_.Flush();			// 스트림 버퍼를 지우고, 스트림 버퍼에 존재한 데이터를 내부 스트림에 씀(전송)
		}

		// 접속 종료시 호출되는 콜백함수
		public void close()	
		{
			clientCon_ = false;			// 접속 여부를 비접속으로
			receiveThread_.Abort();		// 데이터 리시브 스레드 종료.
			receiveThread_ = null;

			if (reader_ != null)
				reader_.Close(); // StreamReader 클래스 개체 리소스 해제
			if (writer_ != null)
				writer_.Close(); // StreamWriter 클래스 개체 리소스 해제
			if (stream_ != null)
				stream_.Close(); // NetworkStream 클래스 개체 리소스 해제
		}

		// 스트림에서 데이터 읽기 가능 여부
		public bool CanRead()	
		{
			return stream_.CanRead;
		}

		// 서버 및 클라이언트 모드에서 myReader 스레드 개체에서 실행되는 메서드로 메시지를 받은 데이터를 화면에 출력하는 작업을 수행
		private void receive()
		{
			try
			{
				while (this.clientCon_)// 클라이언트의 연결이 종료될때까지 계속 실행
				{
					if (CanRead())// 스트림에서 데이터를 읽을 수 있는 경우
					{
						var msg = readData();// id&메세지&보낸날짜시간
						var Smsg = msg.Split('&');// &를 기준으로 메시지 구분
						if (Smsg[0] == "S001")// 첫 구분자가  "S001“인 경우
						{
						}
						else if (Smsg[0] == "S002")
						{
						}
						else if (Smsg[0] == "S003")
						{
						}
						else if (Smsg[0] == "S999") // 클라이언트 접속 종료.
						{
							Form1.instance.MessageView(Smsg[1] + " 접속 종료");
							Form1.instance.disconnectClient(this);
						}
						else if (Smsg[0] == "S998") // 클라이언트 접속.
						{
							id_ = Smsg[1];
							Form1.instance.MessageView("접속 ID : " + id_);	// 접속 클라이언트를 서버 메세지 창에 띄움.
						}
						else
						{
							if (msg.Length > 0)  // 읽은 메시지가 있는 경우 
							{
								Form1.instance.MessageView(Smsg[0] + " : " + Smsg[1]);	// 메세지 내용 서버에 출력.
								Form1.instance.Msg_Send_Clients(id_, msg);				// 만약 클라이언트에게 송신된 메세지라면, 다른 클라이언트에게도 똑같이 전송.
								Form1.instance.checkRightAnswer(id_, Smsg[1]);			// 게임이 시작되었고, 문제가 출제되었다면, 정답 확인.
							}
						}
					}
				}
			}
			catch { }
		}
	}
}
