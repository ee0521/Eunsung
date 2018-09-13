package com.test.wCommand;

import java.util.Map;

import javax.servlet.http.HttpServletRequest;

import org.springframework.ui.Model;

import com.test.wDAO.wDAO;
import com.test.wDTO.wDTO;

public class Wothercommand implements Wcommand{
	@Override
	public void execute(Model model) {
		wDTO dto = new wDTO();
		wDAO dao = new wDAO();
		Map<String, Object> map = model.asMap();
		HttpServletRequest request 
		       =(HttpServletRequest)map.get("request");
		String wid =request.getParameter("wid");
		int num = Integer.parseInt(request.getParameter("num"));
		dto = dao.select(wid);
		request.setAttribute("num1",num);
		request.setAttribute("price1", dto.getWprice());
		model.addAttribute("product2",dto);
		model.addAttribute("num", num);
		
	}
}
