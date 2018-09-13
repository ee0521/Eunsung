package induk.soft.cs2a.model;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;

public class BaseDAO implements DAO {
	Connection conn;
    Statement stmt;
    ResultSet rs;

	@Override
	public void connect() {
		// TODO Auto-generated method stub
		String DB_URL = "jdbc:oracle:thin:@localhost:1521:xe";
        String DB_USER = "cs201312011";
        String DB_PASSWORD= "pw201312011";
        try {
            Class.forName("oracle.jdbc.driver.OracleDriver");
            conn = DriverManager.getConnection(DB_URL, DB_USER, DB_PASSWORD);
            
        } catch(Exception e) {
        	e.printStackTrace();
        }
	}

	@Override
	public void disconnect() {
		// TODO Auto-generated method stub
		
	}

}
