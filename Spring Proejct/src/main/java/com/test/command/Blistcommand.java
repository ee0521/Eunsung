package com.test.command;

import java.util.ArrayList;
import org.springframework.ui.Model;
import com.test.Bdao.Bdao;
import com.test.Bdto.Bdto;
public class Blistcommand implements Bcommand {
	@Override
	public void execute(Model model) {		
		Bdao dao = new Bdao(); 
		ArrayList<Bdto> dtos = dao.list();		
		model.addAttribute("list", dtos);
	}
}
