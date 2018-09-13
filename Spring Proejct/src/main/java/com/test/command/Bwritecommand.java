package com.test.command;
import java.util.Map;

import javax.servlet.http.HttpServletRequest;
import org.springframework.ui.Model;
import com.test.Bdao.Bdao;


public class Bwritecommand implements Bcommand {
	@Override
	public void execute(Model model) {		
		Map<String, Object> map = model.asMap();
		HttpServletRequest request 
		       =(HttpServletRequest)map.get("request");
		Bdao dao = new Bdao(); 
		String bname = request.getParameter("bname");
		String btitle = request.getParameter("btitle");
		String bcontent = request.getParameter("bcontent");		
		
		dao.write(bname, btitle, bcontent);
	}
}
