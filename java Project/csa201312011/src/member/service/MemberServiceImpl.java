package member.service;

import java.util.ArrayList;
import java.util.Arrays;

import member.model.MemberDTO;
import member.main.DB;

import java.io.File;
import java.io.IOException;

public class MemberServiceImpl implements MemberService {
	private ArrayList<MemberDTO> memberList = new ArrayList<MemberDTO>();

	@Override
	public int loginMember(String id, String pw) {

		for (MemberDTO m : memberList) {

			if (m.getId().equals(id) && m.getPw().equals(pw)) {
				System.out.println("로그인 성공!");
				if (id.equals("root")) {
					return 2;
				} else
					return 1;
			}
		}
		System.out.println("입력된 정보가 틀립니다");
		return 0;
	}

	@Override
	public void setMemberList(ArrayList<MemberDTO> memberlist) {
		this.memberList = memberlist;

	}

	@Override
	public boolean newMember(String id, String pw, String name, String email,
			char gender, int age) {
		// 아이디 중복 불가, 필수 합력 미입력시 가입 불가

		for (MemberDTO m : memberList) {
			if (m.getId().equals(id)) {
				System.out.println("이미 있는 ID 입니다. 다시 입력하세요");
				return false;
			}
		}

		if (id.equals("") || pw.equals("") || name.equals("")) {
			System.out.println("회원가입 실패, 필수 입력사항을 반드시 입력해주세요");
			return false;
		}

		else if (id.length() <= 2 || pw.length() <= 2 || name.length() <= 2) {
			System.out
					.println("회원가입 실패, 아이디,비밀번호, 이름은 2자 이하로 입력하셨습니다. 다시 입력해주세요");
			return false;
		}

		else if (gender != 'm' && gender != 'f') {
			System.out.println("회원가입 실패,성별을 확인하세요(남자 : m, 여자 : f)");
			return false;
		}

		else {
			MemberDTO dto = new MemberDTO();
			dto.setId(id);
			dto.setPw(pw);
			dto.setName(name);
			dto.setEmail(email);
			dto.setAge(age);
			dto.setGender(gender);
			memberList.add(dto);
			return true;
		}
	}

	@Override
	public MemberDTO findMember(String id) {
		for (MemberDTO m : memberList) {
			if (m.getId().equals(id)) {
				return m;
			}
		}
		return null;
	}

	@Override
	public void printmember() {
		int number = 1;
		for (MemberDTO m : DB.memberlist) {
			if (!(m.getId().equals("root"))) {
				System.out.println("[회원 " + number + "]");
				System.out.println("아이디 : " + m.getId());
				System.out.println("비밀번호 : " + m.getPw());
				System.out.println("이름 : " + m.getName());
				System.out.println("이메일 : " + m.getEmail());
				System.out.println("나이 : " + m.getAge());
				System.out.println("성별 : " + m.getGender());
				System.out.println("방문횟수 : " + m.getVisit());
				System.out.println("메모 : " + m.getAdmin());
				System.out.println(" ");
				number++;
			}
		}
	}

	@Override
	public void printmember_name() {
		String[] names = new String[memberList.size()];
		for (int i = 0; i < memberList.size(); i++)
			names[i] = memberList.get(i).getName();
		Arrays.sort(names);

		for (String n : names) {
			for (int order = 0; order < names.length; order++) {
				if (memberList.get(order).getName().equals(n)
						&& !(memberList.get(order).getId().equals("root"))) {
					System.out.println("[회원" + (order + 1) + "]");
					System.out
							.println("아이디 : " + memberList.get(order).getId());
					System.out.println("비밀번호 : "
							+ memberList.get(order).getPw());
					System.out.println("이름 : "
							+ memberList.get(order).getName());
					System.out.println("이메일 : "
							+ memberList.get(order).getEmail());
					System.out
							.println("나이 : " + memberList.get(order).getAge());
					System.out.println("방문횟수 : "
							+ memberList.get(order).getVisit());
					System.out.println("메모 : "
							+ memberList.get(order).getAdmin());
					System.out.println(" ");
				}
			}
		}
		/*
		 * // 가나다순 정렬. String[] names = new String[memberList.size()]; for (int
		 * index = 0; index < memberList.size(); ++index) { names[index] =
		 * memberList.get(index).getName(); } Arrays.sort(names);
		 * 
		 * // 정렬된 이름의 멤버를 찾아 인덱스만 기록. int[] order = new int[memberList.size()];
		 * for (int nameIndex = 0; nameIndex < names.length; ++nameIndex) { for
		 * (int memberIndex = 0; memberIndex < memberList.size(); ++memberIndex)
		 * { if (names[nameIndex].equals(memberList.get(memberIndex)
		 * .getName())) { order[nameIndex] = memberIndex; break; } } }
		 * 
		 * // 출력 for (int index = 0; index < memberList.size(); ++index) { if
		 * (!(memberList.get(order[index]).getId().equals("root"))) {
		 * System.out.println("아이디 : " + memberList.get(order[index]).getId());
		 * String password = ""; System.out.println("비밀번호 : " +
		 * memberList.get(order[index]).getId()); System.out.println("이름 : " +
		 * DB.memberlist.get(order[index]).getName());
		 * System.out.println("이메일 : " +
		 * memberList.get(order[index]).getEmail()); System.out.println("나이 : "
		 * + memberList.get(order[index]).getAge()); System.out.println("성별 : "
		 * + memberList.get(order[index]).getGender());
		 * System.out.println("방문횟수 : " +
		 * memberList.get(order[index]).getVisit()); System.out.println("메모 : "
		 * + memberList.get(order[index]).getAdmin()); System.out.println(" ");
		 * } }
		 */
	}

	@Override
	public void updateMember(MemberDTO dto) {
		// TODO Auto-generated method stub

	}

	@Override
	public void deleteMember() {
		// TODO Auto-generated method stub

	}

	@Override
	public void saveFile(String filename) {
		File file = new File(filename);
		MemberFileWriter mfw;
		try {
			mfw = new MemberFileWriter(file);
			mfw.saveMember(memberList);
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

	}

	@Override
	public void readFile(String filename) {
		// TODO Auto-generated method stub
		File file = new File(filename);
		MemberFileReader mfr;
		try {
			mfr = new MemberFileReader(file);
			DB.memberlist = mfr.readMember();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

	}

	@Override
	public ArrayList<MemberDTO> findMember_Name(String name) {
		ArrayList<MemberDTO> list = new ArrayList<MemberDTO>();

		return list;
	}

	public void memberListmAge() {
		int[] ages = new int[memberList.size()];
		for (int i = 0; i < memberList.size(); i++) {
			boolean b = false;
			for (int j = 0; j < ages.length; j++) {
				if (ages[j] == memberList.get(i).getAge()) {
					b = true;
					break;
				}
			}
			if (!b)
				ages[i] = memberList.get(i).getAge();
		}

		Arrays.sort(ages);
		reverseArrayInt(ages);
		for (int n : ages) {
			for (int order = 0; order < ages.length; ++order) {
				if (memberList.get(order).getAge() == n
						&& !(memberList.get(order).getId().equals("root"))
						&& memberList.get(order).getGender() == 'm') {
					System.out
							.println("나이 : " + memberList.get(order).getAge());
					System.out
							.println("아이디 : " + memberList.get(order).getId());
					System.out.println("비밀번호 : "
							+ memberList.get(order).getPw());
					System.out.println("이름 : "
							+ memberList.get(order).getName());
					System.out.println("이메일 : "
							+ memberList.get(order).getEmail());
					System.out.println("성별 : "
							+ memberList.get(order).getGender());
					System.out.println("방문횟수 : "
							+ memberList.get(order).getVisit());
					System.out.println("메모 : "
							+ memberList.get(order).getAdmin());
					System.out.println(" ");
				}
			}
		}

	}

	public static void reverseArrayInt(int[] array) {
		int temp;

		for (int i = 0; i < array.length / 2; i++) {
			temp = array[i];
			array[i] = array[(array.length - 1) - i];
			array[(array.length - 1) - i] = temp;
		}
	}

	@Override
	public void memberListAge() {
		int num10 = 0;
		int num20 = 0;
		int num30 = 0;
		int num40 = 0;
		int num50 = 0;
		int num60 = 0;
		int num70 = 0;
		int num80 = 0;
		int num90 = 0;
		int[] ages = new int[memberList.size()];
		for (int i = 0; i < memberList.size(); i++) {
			boolean b = false;
			for (int j = 0; j < ages.length; j++) {
				if (ages[j] == memberList.get(i).getAge()) {
					b = true;
					break;
				}
			}
			if (!b)
				ages[i] = memberList.get(i).getAge();
		}
		Arrays.sort(ages);
		for (int n : ages) {
			for (int order = 0; order < ages.length; order++) {
				if (memberList.get(order).getAge() == n
						&& !(memberList.get(order).getId().equals("root"))) {
					if (n >= 10 && n <= 19)
						num10 += 1;

					else if (n >= 20 && n <= 29)
						num20 += 1;
					else if (n >= 30 && n <= 39)
						num30 += 1;
					else if (n >= 40 && n <= 49)
						num40 += 1;
					else if (n >= 50 && n <= 59)
						num50 += 1;
					else if (n >= 60 && n <= 69)
						num60 += 1;
					else if (n >= 70 && n <= 79)
						num70 += 1;
					else if (n >= 80 && n <= 89)
						num80 += 1;
					else if (n >= 90 && n <= 99)
						num90 += 1;
				}
			}
		}
		System.out.println("10대 : " + num10 + "명");
		System.out.println("20대 : " + num20 + "명");
		System.out.println("30대 : " + num30 + "명");
		System.out.println("40대 : " + num40 + "명");
		System.out.println("50대 : " + num50 + "명");
		System.out.println("60대 : " + num60 + "명");
		System.out.println("70대 : " + num70 + "명");
		System.out.println("80대 : " + num80 + "명");
		System.out.println("90대 : " + num90 + "명");

	}
}
