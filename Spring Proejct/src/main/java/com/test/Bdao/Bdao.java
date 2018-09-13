package com.test.Bdao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Timestamp;
import java.util.ArrayList;

import com.test.Bdto.Bdto;
public class Bdao {
	Connection conn;
	public Bdao() {  //Db ����
		String driver = "oracle.jdbc.driver.OracleDriver";
		String uid = "system";
		String upw = "cometrue";
		String url = "jdbc:oracle:thin:@localhost:1521:xe";		
		try {
			Class.forName(driver);
			conn = DriverManager.getConnection(url, uid, upw);
			System.out.println("��񿬵�����");
		} catch (ClassNotFoundException e) {e.printStackTrace(); } 
		  catch (SQLException e)           {e.printStackTrace(); }
	}	
	public ArrayList<Bdto> list() { 
		ArrayList<Bdto> dtos = new ArrayList<Bdto>();
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		
        String sql = "select bid, bname, btitle, bcontent, bdate, bhit, bgroup, bstep, bindent"
				      + " from board order by bgroup desc, bstep asc";
		try {
			pstmt = conn.prepareStatement(sql);
			rs = pstmt.executeQuery();//select
			
			while(rs.next()) {
				Bdto dto = new Bdto();				
				dto.setBid(rs.getInt("bid"));
				dto.setBname(rs.getString("bname"));
				dto.setBtitle(rs.getString("btitle"));
				dto.setBcontent(rs.getString("bcontent"));
				dto.setBdate(rs.getTimestamp("bdate"));
				dto.setBhit(rs.getInt("bhit"));
				dto.setBgroup(rs.getInt("bgroup"));
				dto.setBstep(rs.getInt("bstep"));
				dto.setBindent(rs.getInt("bindent"));				
				dtos.add(dto);
			}
		} catch (SQLException e) {	e.printStackTrace(); } 
		  finally { try {
			  if(rs != null) rs.close();
			  if(pstmt != null) pstmt.close();				
			  if(conn != null) conn.close();
			} catch (SQLException e) {	e.printStackTrace(); }
		}
		return dtos;
	} 
	
	public void write(String bname, String btitle, String bcontent) { 		
			PreparedStatement pstmt = null;	
			try {					
		String sql = "insert into board (bid, bname, btitle, bcontent, bhit, bgroup, bstep, bindent)"
			+ " values (boardseq.nextval, ?, ?, ?, 0, boardseq.currval, 0, 0)";
			pstmt = conn.prepareStatement(sql);
			pstmt.setString(1, bname);
			pstmt.setString(2, btitle);
			pstmt.setString(3, bcontent);
		    int n=pstmt.executeUpdate();        //insert�� executeUpdate�� ��
			
		} catch (SQLException e) {	e.printStackTrace(); 	} 
		  finally {  
			    try {//�ڿ�����
				     if(pstmt != null) pstmt.close();
				     if(conn != null) conn.close();
			        } catch (SQLException e) {  e.printStackTrace(); }
		}
	}
	public Bdto contentview(String bbid)  {
		Bdto dto =null;
		PreparedStatement pstmt = null;	
		String sql = "update board set  bhit =bhit+1 where bid=?"; 
		ResultSet rs =null;
		try {
			pstmt=conn.prepareStatement(sql);
			pstmt.setString(1, bbid);		    
	     	int n = pstmt.executeUpdate();
	     	sql = "select * from board where bid =?";
	     	pstmt =conn.prepareStatement(sql);
	     	pstmt.setInt(1,Integer.parseInt(bbid));
	     	rs =pstmt.executeQuery();
	     	  if(rs.next()){
	     		  int bid =rs.getInt("bid");
	     		  String bname =rs.getString("bname");
	     		  String btitle = rs.getString("btitle");
	     		  String bcontent = rs.getString("bcontent");
	     		  Timestamp bdate =rs.getTimestamp("bdate");
	     		  int bhit =rs.getInt("bhit");
	     		  int bgroup =rs.getInt("bgroup");
	     		  int bstep =rs.getInt("bstep");
	     		  int bindent = rs.getInt("bindent");
	     		  dto =new Bdto(bid, bname,btitle,bcontent,bdate,bhit,bgroup,bstep,bindent);	     		  
	     	  }	     	
		} catch (SQLException e) {			
			e.printStackTrace();
		}	finally {
			try {
				if(pstmt != null) pstmt.close();
				if(rs  != null) rs.close();
				if(conn != null) conn.close();
			} catch (SQLException e) {	e.printStackTrace(); }	
		return dto;		
	   }
	}
	public void modify(String bid, String bname, String btitle, String bcontent) {		
		PreparedStatement pstmt = null;
		String sql = "update board set bname=?, btitle=?, bcontent=? where bid=?";		
		try {
			pstmt = conn.prepareStatement(sql);
			pstmt.setString(1, bname);
			pstmt.setString(2, btitle);
			pstmt.setString(3, bcontent);
			pstmt.setInt(4, Integer.parseInt(bid));
			int n =pstmt.executeUpdate();  //�Ѱ���ȯ
		} catch (SQLException e) {			
			e.printStackTrace();
		} finally {
			try {
				if(pstmt != null) pstmt.close();
				if(conn != null) conn.close();
			} catch (SQLException e) {				
				e.printStackTrace();
			}
		}
	}
	public void delete(String bid) {		
		PreparedStatement pstmt = null;
		String sql = "delete from board where bid= ?";		
		try {
			pstmt = conn.prepareStatement(sql);
			pstmt.setString(1, bid);
			pstmt.executeUpdate();
		} catch (SQLException e) {	
			e.printStackTrace();
		} finally {
			try {
				if(pstmt != null) pstmt.close();
				if(conn != null) conn.close();
			} catch (SQLException e) {	e.printStackTrace(); }
		}
	}
	
	public Bdto replyview(String bbid) {
		PreparedStatement pstmt = null;	
		Bdto dto = new Bdto();
		ResultSet rs =null;
		String sql ="select * from board where bid=?";
		try {
			pstmt=conn.prepareStatement(sql);
			pstmt.setInt(1, Integer.parseInt(bbid));
			rs =pstmt.executeQuery();
	     	  if(rs.next()){
	     		  int bid =rs.getInt("bid");
	     		  String bname =rs.getString("bname");
	     		  String btitle = rs.getString("btitle");
	     		  String bcontent = rs.getString("bcontent");
	     		  Timestamp bdate =rs.getTimestamp("bdate");
	     		  int bhit =rs.getInt("bhit");
	     		  int bgroup =rs.getInt("bgroup");
	     		  int bstep =rs.getInt("bstep");
	     		  int bindent = rs.getInt("bindent");
	     		  dto =new Bdto(bid, bname,btitle,bcontent,bdate,bhit,bgroup,bstep,bindent);	     		  
	     	  }	     	
		} catch (SQLException e) {			
			e.printStackTrace();
		}	
		 finally {
				try {
					if(pstmt != null) pstmt.close();
					if(conn != null) conn.close();
				} catch (SQLException e) {	e.printStackTrace(); }
		}
		return dto;
	}
	public void replyplus(String bgroup, String bstep){
		        PreparedStatement pstmt = null;	 
		    	
		    	String sql = "update board set bstep = bstep + 1 where bgroup = ? and bstep > ?";			
		    	try {
		    		pstmt=conn.prepareStatement(sql);
					pstmt.setInt(1, Integer.parseInt(bgroup));
					pstmt.setInt(2, Integer.parseInt(bstep));
				     int n =pstmt.executeUpdate();	
				} catch (NumberFormatException e) {					
					e.printStackTrace();
				} catch (SQLException e) {					
					e.printStackTrace();
				}finally {
					try {
						if(pstmt != null) pstmt.close();					
						if(conn != null) conn.close();
					} catch (SQLException e) {	e.printStackTrace(); }				
				}			    	
		    
	}
	public void reply(String bid, String bname, String btitle, String bcontent,
			String bgroup, String bstep,String bindent) {
		    PreparedStatement pstmt = null;	
	    try {	
	    	 replyplus(bgroup,bstep);
	    	pstmt.setInt(1, Integer.parseInt(bgroup));
	    	pstmt.setInt(2, Integer.parseInt(bstep));
			int n =pstmt.executeUpdate();	
           
		    String sql = "insert into board (bid, bname, btitle, bcontent, bgroup, bstep, bindent) values (boardseq.nextval, ?, ?, ?, ? ,? ,?)";
		 		pstmt=conn.prepareStatement(sql);
				pstmt.setString(1, bname);
				pstmt.setString(2, btitle);
				pstmt.setString(3, bcontent);
				pstmt.setInt(4, Integer.parseInt(bgroup));
				pstmt.setInt(5, Integer.parseInt(bstep) + 1);
				pstmt.setInt(6, Integer.parseInt(bindent) + 1);
				pstmt.executeUpdate();
			} catch (SQLException e) {				
				e.printStackTrace();
			}finally {
				try {
					if(pstmt != null) pstmt.close();					
					if(conn != null) conn.close();
				} catch (SQLException e) {	e.printStackTrace(); }				
			}		
	}
}
	
	

