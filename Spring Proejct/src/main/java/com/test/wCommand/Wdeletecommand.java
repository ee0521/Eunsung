package com.test.wCommand;

import java.util.Map;

import javax.servlet.http.HttpServletRequest;

import org.springframework.ui.Model;

import com.test.Bdao.Bdao;
import com.test.wDAO.wDAO;
import com.test.wDTO.wDTO;

public class Wdeletecommand implements Wcommand {
	@Override
	public void execute(Model model) {
		Map<String, Object> map = model.asMap();
		HttpServletRequest request 
		   = (HttpServletRequest) map.get("request");
		
		String wid = request.getParameter("wid");
		wDAO dao = new wDAO(); 
		dao.delete(wid);
		
	}
}
