package member.service;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;

import member.model.MemberDTO;

public class MemberFileWriter {

	FileWriter fw;

	public MemberFileWriter(File filename) throws IOException {
		fw = new FileWriter(filename);
	}

	public void saveMember(ArrayList<MemberDTO> memberList) throws IOException {
		for (MemberDTO m : memberList) {
			try {
				fw.write(m.getId() + "\t");
				fw.write(m.getPw() + "\t");
				fw.write(m.getName() + "\t");
				String email = m.getEmail();
				if(email.equals(""))
					email = "¹Ìµî·Ï";
				fw.write(email + "\t");
				fw.write(m.getAge() + "\t");
				fw.write(m.getGender() + "\t");
				fw.write(m.getVisit() + "\t");
				String memo = m.getAdmin();
				if(memo == null)
					memo = " ";
				fw.write(memo + "\n");
			} catch (IOException e) {
				e.printStackTrace();
			}
		}

		fw.close();
	}

}
