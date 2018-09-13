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
		System.out.println("ID를 입력하세요");
		Scanner s = new Scanner(System.in);
		String id = s.next();
		System.out.println("비밀번호를 입력하세요");
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
			System.out.println("ID 중복 불가, 필수합력 미입력 시 가입 불가입니다.");

				ms.setMemberList(DB.memberlist);
				System.out.println("ID를 입력하세요");
				Scanner s = new Scanner(System.in);
				String id = s.nextLine();
				System.out.println("패스워드를 입력하세요");
				String pw = s.nextLine();
				System.out.println("이름을 입력하세요");
				String name = s.nextLine();
				System.out.println("이메일을 입력하세요");
				String email = s.nextLine();
				System.out.println("나이를 입력하세요");
				int age = s.nextInt();
				System.out.println("성별을 입력하세요(남자 : m, 여자 : f)");
				char gender = s.next().charAt(0);
				if (ms.newMember(id, pw, name, email, gender, age)) {
					System.out.println("회원가입 성공!");
				}	
		}

		if (menu == 2) {
			System.out.println("아이디 : " + myinfo.getId());
			System.out.println("비밀번호 : " + myinfo.getPw());
			System.out.println("이름 : " + myinfo.getName());
			System.out.println("이메일 : " + myinfo.getEmail());
			System.out.println("나이 : " + myinfo.getAge());
			System.out.println("성별 : " + myinfo.getGender());
			System.out.println("방문 횟수 : " + myinfo.getVisit());
			System.out.println("메모 : " + myinfo.getAdmin());
		}

		if (menu == 3) {
			System.out.println("회원 정보 수정하기");
			System.out.println("회원 아이디 : "+myinfo.getId());
			System.out.println("신규 비밀번호를 입력하세요");
			Scanner s = new Scanner(System.in);
			String pw = s.next();
			myinfo.setPw(pw);
			System.out.println("수정할 이름을 입력하세요");
			String name = s.next();
			myinfo.setName(name);
			System.out.println("수정할 이메일을 입력하세요");
			String email = s.next();
			myinfo.setEmail(email);
			System.out.println("수정할 나이를 입력하세요");
			int age = s.nextInt();
			myinfo.setAge(age);
			System.out.println("수정할 성별을 입력하세요");
			char gender = s.next().charAt(0);
			myinfo.setGender(gender);
			System.out.println("수정이 완료되었습니다.");
			
		}

		if (menu == 4) {
			System.out.println("회원 탈퇴를 선택하셨습니다. 비밀번호를 입력하세요");
			Scanner s = new Scanner(System.in);
			String pw = s.next();
			if (myinfo.getPw().equals(pw)){
				DB.memberlist.remove(myinfo);
				System.out.println("회원탈퇴 왼료");
				return false;
			}
			else
				System.out.println("비밀번호가 틀립니다");

		}
		return true;
	}

	
	
	public void adminMenual(int menu) {
		member.service.MemberServiceImpl ms = new member.service.MemberServiceImpl();
		MemberDTO dto;

		if (menu == 2) {
			System.out.println("아이디 : " + myinfo.getId());
			System.out.println("비밀번호 : " + myinfo.getPw());
			System.out.println("이름 : " + myinfo.getName());
			System.out.println("이메일 : " + myinfo.getEmail());
			System.out.println("나이 : " + myinfo.getAge());
			System.out.println("성별 : " + myinfo.getGender());
		}

		if (menu == 3) {
			ms.setMemberList(DB.memberlist);
			while (true) {
				System.out.println("메모 남기기, 회원 ID를 입력하세요");
				Scanner sc = new Scanner(System.in);
				String id = sc.next();
				dto = ms.findMember(id);
				if (dto != null) {
					System.out.println("남길 메모를 입력하세요");
					String memo = sc.next();
					dto.setAdmin(memo);
					System.out.println(dto.getId() + "님에게 메모를 남겼습니다.");
					break;
				}
				else
					System.out.println("존재하지 않는 아이디입니다.");
				break;
			}
		}
		
		if (menu == 4) {
			System.out.println("관리자 정보 수정하기");
			System.out.println("관리자 아이디 : "+myinfo.getId());
			System.out.println("신규 비밀번호를 입력하세요");
			Scanner s = new Scanner(System.in);
			String pw = s.next();
			myinfo.setPw(pw);
			System.out.println("수정할 이름을 입력하세요");
			String name = s.next();
			myinfo.setName(name);
			System.out.println("수정할 이메일을 입력하세요");
			String email = s.next();
			myinfo.setEmail(email);
			System.out.println("수정할 나이를 입력하세요");
			int age = s.nextInt();
			myinfo.setAge(age);
			System.out.println("수정할 성별을 입력하세요");
			char gender = s.next().charAt(0);
			myinfo.setGender(gender);
			System.out.println("수정이 완료되었습니다");
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
