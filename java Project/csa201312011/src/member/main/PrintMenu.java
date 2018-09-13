package member.main;

public class PrintMenu {

	public void Menu() {
		System.out.println("0. 로그인");
		System.out.println("1. 회원가입");
		System.out.println("9. 프로그램 종료");
	}

	public void memberMenu() {
		System.out.println("2. 회원정보 조회");
		System.out.println("3. 회원정보 수정");
		System.out.println("4. 회원 탈퇴");
		System.out.println("5. 로그아웃");
	}

	public void adminMenu() {
		System.out.println("2. 관리자 정보 조회");
		System.out.println("3. 회원에게 메모");
		System.out.println("4. 관리자 정보 수정");
		System.out.println("5. 로그아웃");
		System.out.println("6. 회원목록 조회(등록순)");
		System.out.println("7. 회원목록 조회(이름순)");
		System.out.println("11. 회원목록 조회(남자 나이순)");
		System.out.println("13. 회원목록 조회(연령대별)");
	}
}
