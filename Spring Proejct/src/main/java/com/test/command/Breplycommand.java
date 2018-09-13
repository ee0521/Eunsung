package com.test.command;

import java.util.Map;

import javax.servlet.http.HttpServletRequest;
import org.springframework.ui.Model;

import com.test.Bdao.Bdao;
public class Breplycommand implements Bcommand {
	@Override
	public void execute(Model model) {
		Map<String, Object> map = model.asMap();
		HttpServletRequest request
		    = (HttpServletRequest)map.get("request");
		
		String bid = request.getParameter("bid");
		String bname = request.getParameter("bname");
		String btitle = request.getParameter("btitle");
		String bcontent = request.getParameter("bcontent");
		String bgroup = request.getParameter("bgroup");
		String bstep = request.getParameter("bstep");
		String bindent = request.getParameter("bindent");
		
		Bdao dao = new Bdao();
		dao.reply(bid, bname, btitle, bcontent, bgroup, bstep, bindent);		
	}
}
