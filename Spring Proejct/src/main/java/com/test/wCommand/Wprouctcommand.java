package com.test.wCommand;

import javax.servlet.http.HttpServletRequest;
import java.sql.SQLException;
import org.springframework.ui.Model;
import java.util.Map;


import com.test.wCommand.Wcommand;
import com.test.wDAO.wDAO;
import com.test.wDTO.wDTO;

public class Wprouctcommand implements Wcommand {

	@Override
	public void execute(Model model) {
		wDTO dto = new wDTO();
		wDAO dao = new wDAO();
		Map<String, Object> map = model.asMap();
		HttpServletRequest request 
		       =(HttpServletRequest)map.get("request");
		String wid =request.getParameter("wid");
		dto = dao.select(wid);
		model.addAttribute("product",dto);
		
	}
	
	

}
