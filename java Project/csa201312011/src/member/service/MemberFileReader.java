package member.service;

import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Scanner;

import member.model.MemberDTO;

public class MemberFileReader {
	Scanner sc;	
	public MemberFileReader(File filename) throws IOException {
		sc = new Scanner(filename);
	}
	public ArrayList<MemberDTO> readMember() throws IOException {
		ArrayList<MemberDTO> memberList = new ArrayList<MemberDTO>();
		while(sc.hasNext()) {
			MemberDTO dto = new MemberDTO();
			String[] line = sc.nextLine().split("\t");
			dto.setId(line[0]);
			dto.setPw(line[1]);
			dto.setName(line[2]);
			dto.setEmail(line[3]);
			dto.setAge(Integer.parseInt(line[4]));
			dto.setGender(line[5].charAt(0));
			dto.setVisit(Integer.parseInt(line[6]));
			dto.setAdmin(line[7]);
			memberList.add(dto);	
		}		
		return memberList;
	}

}
