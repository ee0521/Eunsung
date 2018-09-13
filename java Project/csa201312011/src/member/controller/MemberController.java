package member.controller;

import java.util.Arrays;
import java.util.Scanner;

import member.main.PrintMenu;
import member.main.DB;
import member.model.MemberDTO;

public class MemberController {
	private MemberDTO myinfo;

	public int login() {
		member.service.MemberServiceImpl ms = new member.service.MemberServiceImpl();
		ms.setMemberList(DB.memberlist);
		System.out.println("ID�� �Է��ϼ���");
		Scanner s = new Scanner(System.in);
		String id = s.next();
		System.out.println("��й�ȣ�� �Է��ϼ���");
		String pw = s.next();
		int result = ms.loginMember(id, pw);
		if (result > 0) {
			for (MemberDTO m : DB.memberlist) {
				if (m.getId().equals(id)) {
					if(!(m.getId().equals("root"))){
					int visit = m.getVisit();
					visit += 1;
					m.setVisit(visit);
					myinfo = m;
					break;
					}
					else
						myinfo = m;
					break;
				}
			}
		}
		return result;
	}

	public boolean memberMenual(int menu) {
		member.service.MemberServiceImpl ms = new member.service.MemberServiceImpl();
		MemberDTO dto;

		if (menu == 1) {
			System.out.println("ID �ߺ� �Ұ�, �ʼ��շ� ���Է� �� ���� �Ұ��Դϴ�.");

				ms.setMemberList(DB.memberlist);
				System.out.println("ID�� �Է��ϼ���");
				Scanner s = new Scanner(System.in);
				String id = s.nextLine();
				System.out.println("�н����带 �Է��ϼ���");
				String pw = s.nextLine();
				System.out.println("�̸��� �Է��ϼ���");
				String name = s.nextLine();
				System.out.println("�̸����� �Է��ϼ���");
				String email = s.nextLine();
				System.out.println("���̸� �Է��ϼ���");
				int age = s.nextInt();
				System.out.println("������ �Է��ϼ���(���� : m, ���� : f)");
				char gender = s.next().charAt(0);
				if (ms.newMember(id, pw, name, email, gender, age)) {
					System.out.println("ȸ������ ����!");
				}	
		}

		if (menu == 2) {
			System.out.println("���̵� : " + myinfo.getId());
			System.out.println("��й�ȣ : " + myinfo.getPw());
			System.out.println("�̸� : " + myinfo.getName());
			System.out.println("�̸��� : " + myinfo.getEmail());
			System.out.println("���� : " + myinfo.getAge());
			System.out.println("���� : " + myinfo.getGender());
			System.out.println("�湮 Ƚ�� : " + myinfo.getVisit());
			System.out.println("�޸� : " + myinfo.getAdmin());
		}

		if (menu == 3) {
			System.out.println("ȸ�� ���� �����ϱ�");
			System.out.println("ȸ�� ���̵� : "+myinfo.getId());
			System.out.println("�ű� ��й�ȣ�� �Է��ϼ���");
			Scanner s = new Scanner(System.in);
			String pw = s.next();
			myinfo.setPw(pw);
			System.out.println("������ �̸��� �Է��ϼ���");
			String name = s.next();
			myinfo.setName(name);
			System.out.println("������ �̸����� �Է��ϼ���");
			String email = s.next();
			myinfo.setEmail(email);
			System.out.println("������ ���̸� �Է��ϼ���");
			int age = s.nextInt();
			myinfo.setAge(age);
			System.out.println("������ ������ �Է��ϼ���");
			char gender = s.next().charAt(0);
			myinfo.setGender(gender);
			System.out.println("������ �Ϸ�Ǿ����ϴ�.");
			
		}

		if (menu == 4) {
			System.out.println("ȸ�� Ż�� �����ϼ̽��ϴ�. ��й�ȣ�� �Է��ϼ���");
			Scanner s = new Scanner(System.in);
			String pw = s.next();
			if (myinfo.getPw().equals(pw)){
				DB.memberlist.remove(myinfo);
				System.out.println("ȸ��Ż�� �޷�");
				return false;
			}
			else
				System.out.println("��й�ȣ�� Ʋ���ϴ�");

		}
		return true;
	}

	
	
	public void adminMenual(int menu) {
		member.service.MemberServiceImpl ms = new member.service.MemberServiceImpl();
		MemberDTO dto;

		if (menu == 2) {
			System.out.println("���̵� : " + myinfo.getId());
			System.out.println("��й�ȣ : " + myinfo.getPw());
			System.out.println("�̸� : " + myinfo.getName());
			System.out.println("�̸��� : " + myinfo.getEmail());
			System.out.println("���� : " + myinfo.getAge());
			System.out.println("���� : " + myinfo.getGender());
		}

		if (menu == 3) {
			ms.setMemberList(DB.memberlist);
			while (true) {
				System.out.println("�޸� �����, ȸ�� ID�� �Է��ϼ���");
				Scanner sc = new Scanner(System.in);
				String id = sc.next();
				dto = ms.findMember(id);
				if (dto != null) {
					System.out.println("���� �޸� �Է��ϼ���");
					String memo = sc.next();
					dto.setAdmin(memo);
					System.out.println(dto.getId() + "�Կ��� �޸� ������ϴ�.");
					break;
				}
				else
					System.out.println("�������� �ʴ� ���̵��Դϴ�.");
				break;
			}
		}
		
		if (menu == 4) {
			System.out.println("������ ���� �����ϱ�");
			System.out.println("������ ���̵� : "+myinfo.getId());
			System.out.println("�ű� ��й�ȣ�� �Է��ϼ���");
			Scanner s = new Scanner(System.in);
			String pw = s.next();
			myinfo.setPw(pw);
			System.out.println("������ �̸��� �Է��ϼ���");
			String name = s.next();
			myinfo.setName(name);
			System.out.println("������ �̸����� �Է��ϼ���");
			String email = s.next();
			myinfo.setEmail(email);
			System.out.println("������ ���̸� �Է��ϼ���");
			int age = s.nextInt();
			myinfo.setAge(age);
			System.out.println("������ ������ �Է��ϼ���");
			char gender = s.next().charAt(0);
			myinfo.setGender(gender);
			System.out.println("������ �Ϸ�Ǿ����ϴ�");
		}
		
		if (menu == 6){
			ms.setMemberList(DB.memberlist);
			ms.printmember();
		}
		
		if(menu == 7){
			ms.setMemberList(DB.memberlist);
			ms.printmember_name();

		}
		
		if(menu == 11){
			ms.setMemberList(DB.memberlist);
			ms.memberListmAge();
		}
		if(menu == 13){
			ms.setMemberList(DB.memberlist);
			ms.memberListAge();
		}
	}
}
