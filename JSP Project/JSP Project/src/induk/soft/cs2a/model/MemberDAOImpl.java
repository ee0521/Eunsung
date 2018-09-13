package induk.soft.cs2a.model;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

import guestbook.model.Message;
import jdbc.JdbcUtil;

public class MemberDAOImpl extends BaseDAO implements MemberDAO {
	
	@Override
	public int insert(MemberDTO dto) {
		// TODO Auto-generated method stub
		int rows = 0;// 
        String email = dto.getEmail();
        String name = dto.getName();
        String pw = dto.getPw();            
        
        String sql = "insert into mem201312011(email, name, pw)" +  
        		"values('" + email + "', '" +
        		name + "', '" + pw + "')";
        connect(); // BaseDAO占쏙옙 占쏙옙達騁占쏙옙占�
        try {
        	stmt = conn.createStatement(); // conn, stmt는 BaseDAO에 정의
        	rows = stmt.executeUpdate(sql); // insert, update, delete문
        } catch(SQLException e) {
        	e.printStackTrace();
        } finally {        	
        	disconnect();
        }
		return rows;
	}

	@Override
	public MemberDTO select(MemberDTO dto) {
		// TODO Auto-generated method stub
		MemberDTO tdto = null;
		String email = dto.getEmail();
		String pw = dto.getPw();
		String sql = "select * from mem201312011 where email='" + email + "' and pw= '" + pw + "'";
		connect();
        try {
        	stmt = conn.createStatement();
        	rs = stmt.executeQuery(sql); // select 占쏙옙

        	if(rs.next()) {
        		tdto = new MemberDTO();
        		tdto.setEmail(rs.getString("email"));
        		tdto.setName(rs.getString("name"));
        		tdto.setPw(rs.getString("pw"));
        	}        	
        } catch(SQLException e) {
        	e.printStackTrace();
        } finally {        	
        	disconnect();
        }
		return tdto;
	}
	

	@Override
	public ArrayList<MemberDTO> selectList(MemberDTO dto) {
		// TODO Auto-generated method stub
		ArrayList<MemberDTO> dtoList = null;
		String sql = "select * from mem201312011 where email != 'admin'";
		connect();
        try {
        	stmt = conn.createStatement();
        	rs = stmt.executeQuery(sql); // select 占쏙옙
        	dtoList = new ArrayList<MemberDTO>(); 
        	while(rs.next()) {
        		MemberDTO tempdto = new MemberDTO();
        		tempdto.setEmail(rs.getString("email"));
        		tempdto.setName(rs.getString("name"));
        		tempdto.setPw(rs.getString("pw"));
        		dtoList.add(tempdto);
        	}        	
        } catch(SQLException e) {
        	e.printStackTrace();
        } finally {        	
        	disconnect();
        }
		return dtoList;
	}

	@Override
	public int update(MemberDTO dto) {
		int rows = -1;// 
        String email = dto.getEmail();
        String name = dto.getName();
        int regdate = dto.getRegdate();
        String zipcode = dto.getZipcode(); 
        String address = dto.getAddress();
        String sql = "update mem201312011 set name='" + name + 
        		"', regdate=" + regdate + 
        		", zipcode='" + zipcode + 
        		"', address='" + address + "' where email='" + email + "'";
        		
        connect(); // BaseDAO占쏙옙 占쏙옙達騁占쏙옙占�
        try {
        	stmt = conn.createStatement(); // conn, stmt는 BaseDAO
        	rows = stmt.executeUpdate(sql); // insert, update, delete
        } catch(SQLException e) {
        	e.printStackTrace();
        } finally {        	
        	disconnect();
        }
		return rows;
	}

	@Override
	public int delete(MemberDTO dto) {
		int rows = -1;
		String email = dto.getEmail();
		String sql = "delete from mem201312011 where email='" + email + "'";
		 connect(); 
	        try {
	        	stmt = conn.createStatement(); 
	        	rows = stmt.executeUpdate(sql); 
	        } catch(SQLException e) {
	        	e.printStackTrace();
	        } finally {        	
	        	disconnect();
	        }
			return rows;
	}

	@Override
	public int updatePw(MemberDTO dto) {
		int rows = -1;
        String pw = dto.getPw();
        String email = dto.getEmail();
        
        String sql = "update mem201312011 set pw ='" + pw + 
        		"' where email='" + email + "'";
        		
        connect(); 
        try {
        	stmt = conn.createStatement(); 
        	rows = stmt.executeUpdate(sql); 
        } catch(SQLException e) {
        	e.printStackTrace();
        } finally {        	
        	disconnect();
        }
		return rows;
	}

	@Override
	public MemberDTO selectInfo(MemberDTO dto) {
		MemberDTO idto = null;
		String email = dto.getEmail();	
		String sql = "select * from mem201312011 where email='" + email + "'";
		connect();
        try {
        	stmt = conn.createStatement();
        	rs = stmt.executeQuery(sql); // select문

        	if(rs.next()) {
        		idto = new MemberDTO();
        		idto.setEmail(rs.getString("email"));
        		idto.setName(rs.getString("name"));
        		idto.setRegdate(rs.getInt("regdate"));
        		idto.setZipcode(rs.getString("zipcode"));
        		idto.setAddress(rs.getString("address"));
        	}        	
        } catch(SQLException e) {
        	e.printStackTrace();
        } finally {        	
        	disconnect();
        }
		return idto;
	}

	@Override
	public MemberDTO selectM(MemberDTO dto) {
		MemberDTO tdto = null;
		String email = dto.getEmail();
		System.out.println(email);
		String sql = "select * from mem201312011 where email='" + email + "'";
		connect();
        try {
        	stmt = conn.createStatement();
        	rs = stmt.executeQuery(sql); // select문

        	if(rs.next()) {
        		tdto = new MemberDTO();
        		tdto.setEmail(rs.getString("email"));
        		tdto.setName(rs.getString("name"));
        		tdto.setPw(rs.getString("pw"));
        	}        	
        } catch(SQLException e) {
        	e.printStackTrace();
        } finally {        	
        	disconnect();
        }
		return tdto;
	}

	@Override
	public int count(){
		
		ArrayList<MemberDTO> dtoList = null;
		String sql = "select count(*) from mem201312011 where email != 'admin'";
		connect();
        try {
        	stmt = conn.createStatement();
        	rs = stmt.executeQuery(sql); // select 
        	rs.next();
        	return rs.getInt(1);
        	
        } catch(SQLException e) {
        	e.printStackTrace();
        } finally {        	
        	disconnect();
        }
        return 0;

	}

	@Override
	public ArrayList<MemberDTO> selectList(int firstrow, int endrow) {
		ArrayList<MemberDTO> dtoList = null ;
		try {
			stmt = conn.createStatement();
			String sql = 	"select email, name from ( "
               + "    select rownum rnum, email, name from ( "
               + "        select * from mem201312011 m where m.email != 'admin' order by m.email desc "
               + "    ) where rownum <= " + endrow 
               + ") where rnum >= "+ firstrow; 
			//pstmt.setInt(1, firstRow - 1);
			//pstmt.setInt(2, endRow - firstRow + 1);
			rs = stmt.executeQuery(sql);
			dtoList = new ArrayList<MemberDTO>(); 
        	while(rs.next()) {
        		MemberDTO tempdto = new MemberDTO();
        		tempdto.setEmail(rs.getString("email"));
        		tempdto.setName(rs.getString("name"));
        		dtoList.add(tempdto);
        	}   
		} catch(SQLException e) {
        	e.printStackTrace();
        } finally { 	
        	disconnect();
		}
		return dtoList;
	}
	
}
