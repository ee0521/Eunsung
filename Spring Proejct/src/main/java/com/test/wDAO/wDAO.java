package com.test.wDAO;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Timestamp;

import com.test.Bdto.Bdto;
import com.test.wDTO.wDTO;

public class wDAO {
	String sql;
	Connection conn;
	PreparedStatement pstmt = null;	
	ResultSet rs =null;
	public wDAO() {  //Db 연결
		String driver = "oracle.jdbc.driver.OracleDriver";
		String uid = "system";
		String upw = "cometrue";
		String url = "jdbc:oracle:thin:@localhost:1521:xe";		
		try {
			Class.forName(driver);
			conn = DriverManager.getConnection(url, uid, upw);
			System.out.println("db연동성공");
		} catch (ClassNotFoundException e) {e.printStackTrace(); } 
		  catch (SQLException e)           {e.printStackTrace(); }
	}
	
	public wDTO other(String wid){
		wDTO dto = null;
		try {	
	     	sql = "select * from web where wid =?";
	     	pstmt =conn.prepareStatement(sql);
	     	pstmt.setInt(1,Integer.parseInt(wid));
	     	rs =pstmt.executeQuery();
	     	  while(rs.next()){
	     		  dto = new wDTO();
	     		  dto.setWid(rs.getInt("wid"));
	     		  dto.setWprice(rs.getInt("wprice"));
	     		  dto.setWname(rs.getString("wname"));
	     	  }	     	
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} finally {
			try {
				if(pstmt != null) pstmt.close();
				if(conn != null) conn.close();
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
		return dto;
	}
	
	public wDTO select(String wid)  {
		wDTO dto =null;
		
		try {	
	     	sql = "select * from web where wid =?";
	     	pstmt =conn.prepareStatement(sql);
	     	pstmt.setInt(1,Integer.parseInt(wid));
	     	rs =pstmt.executeQuery();
	     	  while(rs.next()){
	     		  dto = new wDTO();
	     		  dto.setWid(rs.getInt("wid"));
	     		  dto.setWprice(rs.getInt("wprice"));
	     		  dto.setWname(rs.getString("wname"));
	     		  dto.setWfrom(rs.getString("wfrom"));
	     		  dto.setWcontent(rs.getString("wcontent"));
	     		  dto.setWgroup(rs.getString("wgroup"));
	     		  
	     		  System.out.println(rs.getString("wid"));
	     	  }	     	
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} finally {
			try {
				if(pstmt != null) pstmt.close();
				if(conn != null) conn.close();
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
		return dto;
	}
	
	public void delete(String wid) {		
		PreparedStatement pstmt = null;
		String sql = "delete from web where wid= ?";		
		try {
			pstmt = conn.prepareStatement(sql);
			pstmt.setString(1, wid);
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

}
