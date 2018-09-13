package member.main;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;
import java.io.*;

import member.controller.MemberController;
import member.model.MemberDTO;
import member.service.MemberServiceImpl;
import member.service.MemberFileWriter;
import member.service.MemberFileReader;

public class MemberMain {

	public static void main(String[] args) {
		PrintMenu pm = new PrintMenu();
		int menuindex = 0;
		boolean exit = false;
		MemberController mc = new MemberController();

		try {
			File readfile = new File("C:\\cs2a.txt");
			MemberFileReader reader = new MemberFileReader(readfile);
			DB.memberlist = reader.readMember();
		} catch (Exception ex) {
		}
		
		while (true) {

			if (menuindex == 0) {
				pm.Menu();
				Scanner s = new Scanner(System.in);
				int menu = s.nextInt();

				switch (menu) {
				case 0:
					menuindex = mc.login();
					break;
				case 1:
					mc.memberMenual(1);
					break;
				case 9:
					exit = true;
					try {
						File writerFile = new File("C:\\cs2a.txt");
						MemberFileWriter writer = new MemberFileWriter(writerFile);
						writer.saveMember(DB.memberlist);
					} catch (Exception ex) {
					}
					break;
				default:
					System.out.println("없는 메뉴입니다. 다시 입력하세요");
					break;
				}
				if (exit) {
					s.close();
					break;
				}
			}

			else if (menuindex == 1) {
				pm.memberMenu();
				Scanner s = new Scanner(System.in);
				int menu = s.nextInt();
				switch (menu) {
				case 2:
					mc.memberMenual(2);
					break;
				case 3:
					mc.memberMenual(3);
					break;
				case 4:
					if(mc.memberMenual(4) == false)
						menuindex = 0;
					break;
				case 5:
					menuindex = 0;
					break;
				default:
					System.out.println("없는 메뉴입니다. 다시 입력하세요");
					break;
				}
			}

			else {
				pm.adminMenu();
				Scanner s = new Scanner(System.in);
				int menu = s.nextInt();
				switch (menu) {
				case 2:
					mc.adminMenual(2);
					break;
				case 3:
					mc.adminMenual(3);
					break;
				case 4:
					mc.adminMenual(4);
					break;
				case 5:
					menuindex = 0;
					break;
				case 6:
					mc.adminMenual(6);
					break;
				case 7:
					mc.adminMenual(7);
					break;
				case 11:
					mc.adminMenual(11);
					break;
				case 13:
					mc.adminMenual(13);
					break;
				default:
					System.out.println("없는 메뉴입니다. 다시 입력하세요");
				}
			}
		}

	}
}
