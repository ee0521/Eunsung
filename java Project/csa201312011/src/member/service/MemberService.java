package member.service;

import java.util.ArrayList;
import member.model.MemberDTO;
import java.io.File;

public interface MemberService {
	
	public int loginMember(String id, String pw);
	public void setMemberList(ArrayList<MemberDTO> memberList);
	public boolean newMember(String id, String pw, String name, String email, char gender, int age);
	public MemberDTO findMember(String id);
	public ArrayList<MemberDTO> findMember_Name(String name);
	public void printmember();
	public void printmember_name();
	public void updateMember(MemberDTO dto);
	public void deleteMember();
	public void saveFile(String filename);
	public void readFile(String filename);
	public void memberListmAge();
	public void memberListAge();
	

}
