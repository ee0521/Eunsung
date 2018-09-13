package com.test.command;

import java.sql.SQLException;
import java.util.Map;

import javax.servlet.http.HttpServletRequest;

import org.springframework.ui.Model;

import com.test.Bdao.Bdao;
import com.test.Bdto.Bdto;

public class Bcontentcommand implements Bcommand {
	@Override
	public void execute(Model model)  {
		Map<String, Object> map = model.asMap();
		HttpServletRequest request 
		       =(HttpServletRequest)map.get("request");
		String bid =request.getParameter("bid");
		Bdao dao = new Bdao(); 
		Bdto dto = dao.contentview(bid);
		model.addAttribute("content_view",dto);
	}

}
