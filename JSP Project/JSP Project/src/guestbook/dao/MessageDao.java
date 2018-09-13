package guestbook.dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

import guestbook.model.Message;
import jdbc.JdbcUtil;

public class MessageDao {
	private static MessageDao messageDao = new MessageDao();
	public static MessageDao getInstance() {
		return messageDao;
	}
	
	public MessageDao() {}
	
	public int insert(Connection conn, Message message) throws SQLException {
		PreparedStatement pstmt = null;
		try {
			pstmt = conn.prepareStatement(
					"insert into guest201312011 " + 
					"(message_id, guest_name, password, file_name, message) " +
					"values (message_id_seq.nextval, ?, ?, ?, ?)");
			pstmt.setString(1, message.getGuestName());
			pstmt.setString(2, message.getPassword());
			pstmt.setString(3, message.getFileName());
			pstmt.setString(4, message.getMessage());
			return pstmt.executeUpdate();
		} finally {
			JdbcUtil.close(pstmt);
		}
	}

	public Message select(Connection conn, int messageId) throws SQLException {
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		try {
			pstmt = conn.prepareStatement(
					"select * from guest201312011 where message_id = ?");
			pstmt.setInt(1, messageId);
			rs = pstmt.executeQuery();
			if (rs.next()) {
				return makeMessageFromResultSet(rs);
			} else {
				return null;
			}
		} finally {
			JdbcUtil.close(rs);
			JdbcUtil.close(pstmt);
		}
	}

	private Message makeMessageFromResultSet(ResultSet rs) throws SQLException {
		Message message = new Message();
		message.setId(rs.getInt("message_id"));
		message.setGuestName(rs.getString("guest_name"));
		message.setPassword(rs.getString("password"));
		message.setFileName(rs.getString("file_name"));
		message.setMessage(rs.getString("message"));
		return message;
	}

	public int selectCount(Connection conn) throws SQLException {
		Statement stmt = null;
		ResultSet rs = null;
		try {
			stmt = conn.createStatement();
			rs = stmt.executeQuery("select count(*) from guest201312011");
			rs.next();
			return rs.getInt(1);
		} finally {
			JdbcUtil.close(rs);
			JdbcUtil.close(stmt);
		}
	}
	
	public int serchCount(Connection conn, String guestName) throws SQLException {
	      PreparedStatement pstmt = null;
	      ResultSet rs = null;
	      try {
	         pstmt = conn.prepareStatement("select count(*) from guest201312011 where guest_name like ?");
	         pstmt.setString(1, "%"+guestName+"%");
	         rs = pstmt.executeQuery();
	         rs.next();
	         return rs.getInt(1);
	      } finally {
	         JdbcUtil.close(rs);
	         JdbcUtil.close(pstmt);
	      }
	   }

	public List<Message> selectList(Connection conn, int firstRow, int endRow) 
			throws SQLException {
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		try {
			pstmt = conn.prepareStatement("select message_id, guest_name, password, message, file_name from ( "
		               + "    select rownum rnum, message_id, guest_name, password, message, file_name from ( "
		               + "        select * from guest201312011 m order by m.message_id desc "
		               + "    ) where rownum <= ? "
		               + ") where rnum >= ?"); // limit ?, ?"); 
			pstmt.setInt(1, endRow);
			pstmt.setInt(2, firstRow);
			//pstmt.setInt(1, firstRow - 1);
			//pstmt.setInt(2, endRow - firstRow + 1);
			rs = pstmt.executeQuery();
			if (rs.next()) {
				List<Message> messageList = new ArrayList<Message>();
				do {
					messageList.add(makeMessageFromResultSet(rs));
				} while (rs.next());
				return messageList;
			} else {
				return Collections.emptyList();
			}
		} finally {
			JdbcUtil.close(rs);
			JdbcUtil.close(pstmt);
		}
	}
	
	public List<Message> serchList(Connection conn, String guestName, int firstRow, int endRow) throws SQLException {
	      PreparedStatement pstmt = null;
	      ResultSet rs = null;
	      try {
	         pstmt = conn.prepareStatement("select message_id, guest_name, password, message, file_name from ( "
	               + "    select rownum rnum, message_id, guest_name, password, message, file_name from ( "
	               + "        select * from guest201312011 m where guest_name like ? order by m.message_id desc "
	               + "    ) where rownum <= ? "
	               + ") where rnum >= ?");
	         pstmt.setString(1, "%"+guestName+"%"); // guestName이 문자열에 포함
	         pstmt.setInt(2, endRow);
	         pstmt.setInt(3, firstRow);
	         rs = pstmt.executeQuery();
	         if (rs.next()) {
	            List<Message> messageList = new ArrayList<Message>();
	            do {
	               messageList.add(makeMessageFromResultSet(rs));
	            } while (rs.next());
	            return messageList;
	         } else {
	            return Collections.emptyList();
	         }
	      } finally {
	         JdbcUtil.close(rs);
	         JdbcUtil.close(pstmt);
	      }
	   }

	public int delete(Connection conn, int messageId) throws SQLException {
		PreparedStatement pstmt = null;
		try {
			pstmt = conn.prepareStatement(
					"delete from guest201312011 where message_id = ?");
			pstmt.setInt(1, messageId);
			return pstmt.executeUpdate();
		} finally {
			JdbcUtil.close(pstmt);
		}
	}
	
	public int update(Connection conn, Message message) throws SQLException {
		PreparedStatement pstmt = null;
		try {
			pstmt = conn.prepareStatement(
					"update guest201312011 set " + 
					"guest_name = ?, password = ?, file_name = ?, message = ? " +
					"where message_id = ?");
			pstmt.setString(1, message.getGuestName());
			pstmt.setString(2, message.getPassword());
			pstmt.setString(3, message.getFileName());
			pstmt.setString(4, message.getMessage());
			pstmt.setInt(5, message.getId());
			return pstmt.executeUpdate();
		} finally {
			JdbcUtil.close(pstmt);
		}
	}
	
	
	   
	   

}
