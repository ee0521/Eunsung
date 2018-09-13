package induk.soft.cs2a.model;

import java.util.ArrayList;

public interface MemberDAO extends DAO {
	int insert(MemberDTO dto); // create
	MemberDTO select(MemberDTO dto); // read one record
	ArrayList<MemberDTO> selectList(MemberDTO dto); // read multi record
	ArrayList<MemberDTO> selectList(int firstrow, int endrow); // read multi record
	int update(MemberDTO dto); // update 
	int delete(MemberDTO dto); // delete
	int updatePw(MemberDTO dto);
	int count();
	MemberDTO selectInfo(MemberDTO dto);
	MemberDTO selectM(MemberDTO dto);
}
