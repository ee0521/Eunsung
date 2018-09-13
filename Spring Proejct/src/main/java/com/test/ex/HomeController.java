package com.test.ex;

import java.io.IOException;
import java.text.DateFormat;
import java.util.Date;
import java.util.Locale;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.context.support.AbstractApplicationContext;
import org.springframework.context.support.GenericXmlApplicationContext;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import com.test.command.Bcommand;
import com.test.command.Bcontentcommand;
import com.test.command.Bdeletecommand;
import com.test.command.Blistcommand;
import com.test.command.Bmodifycommand;
import com.test.command.Breplycommand;
import com.test.command.Breplyviewcommand;
import com.test.command.Bwritecommand;
import com.test.wCommand.Wcommand;
import com.test.wCommand.Wdeletecommand;
import com.test.wCommand.Wprouctcommand;
import com.test.wCommand.Wothercommand;
import com.test.wDAO.Company;


@Controller
public class HomeController {
	
	private static final Logger logger = LoggerFactory.getLogger(HomeController.class);
	Bcommand command;
	Wcommand command2;
	
	 
	 @RequestMapping("/login")
	 public String login(HttpServletRequest request){
		 String id = "member1";
		 String pw = "mempw1";
		 String id2 = "member2";
		 String pw2= "mempw2";
		 String id3 = "member3";
		 String pw3 = "mempw3";
		 String idvar = request.getParameter("memid");
		 String pwvar = request.getParameter("mempw");
		 
		 if(idvar.equals(id)){
			 if(pwvar.equals(pw)){
				// request.setAttribute("list", form.getName());
				request.setAttribute("message", "로그인 성공입니다");
			   
			 }
			 else{
				 request.setAttribute("message", "로그인 실패. 비밀번호 틀림");
			 }		 
		 }
		 else{
			 request.setAttribute("message", "로그인 실패. 등록된 아이디 없음");
		 }
		 
		 return "loginResult";
	 }
	 @RequestMapping("/login_view")
		public String login_view(Model model) {
			System.out.println("login_view()");
			return "login_view";
		} 
	@RequestMapping("/list")
	public String list(Model model) {
		
		System.out.println("list()");
		command = new Blistcommand();
		command.execute(model);		
		return "list";	
	}
	@RequestMapping("/write_view")
	public String write_view(Model model) {
		System.out.println("write_view"); 		
		return "write_view";  //write_view page�� �ѱ�
	}	
	@RequestMapping(value ="/write")
	public String write(HttpServletRequest request, Model model){
		System.out.println("write()");
	     command = new Bwritecommand();
	     model.addAttribute("request", request);//
	
		command.execute(model);		
		return "redirect:list";
	}
	
	@RequestMapping("/content_view")
	public String content_view(HttpServletRequest request, Model model) {
		System.out.println("content_view");
		model.addAttribute("request", request);
		command = new Bcontentcommand();	
		command.execute(model);		
		return "content_view";
	}
	
	@RequestMapping("/product_view")
	public String product_view(HttpServletRequest request, Model model) {
		System.out.println("product_view");
		model.addAttribute("request", request);
		command2 = new Wprouctcommand();	
		command2.execute(model);		
		return "product_view";
	}
	@RequestMapping("/modify")
	public String modify(HttpServletRequest request, Model model) {
		System.out.println("modify");
		model.addAttribute("request", request);
		command = new Bmodifycommand();		
		command.execute(model);		
		return "redirect:list";
	}		
	
	@RequestMapping("/other")
	public String other(HttpServletRequest request, Model model) {
		System.out.println("modify");
		model.addAttribute("request", request);
		command2 = new Wothercommand();		
		command2.execute(model);		
		return "other";
	}
	@RequestMapping("/delete")
	public String delete(HttpServletRequest request, Model model) {
		System.out.println("delete");
		model.addAttribute("request", request);
		command = new Bdeletecommand();		
		command.execute(model);		
		return "redirect:list";
	}	
	
	@RequestMapping("/delete2")
	public String delete2(HttpServletRequest request, Model model) {
		System.out.println("delete2");
		model.addAttribute("request", request);
		command2 = new Wdeletecommand();		
		command2.execute(model);		
		return "home";
	}
	@RequestMapping("/reply_view")
	public String replyview(HttpServletRequest request, Model model) {
		System.out.println("replyview()");
		model.addAttribute("request", request);
		command = new Breplyviewcommand();		
		command.execute(model);		
		return "redirect:reply_view";
	}	
	@RequestMapping("/reply")
	public String reply(HttpServletRequest request, Model model) {
		System.out.println("reply()");
		model.addAttribute("request", request);
		command = new Breplycommand();		
		command.execute(model);		
		return "redirect:list";
	}		
	@RequestMapping(value = "/", method = RequestMethod.GET)
	public String home(Locale locale, Model model) {
		String contextpath = "classpath:company.xml";
		AbstractApplicationContext ctx = new GenericXmlApplicationContext(contextpath);
		Company com1 = ctx.getBean("company", Company.class);
		System.out.println(com1.getAddress());
		model.addAttribute("comN", com1.getName());
		model.addAttribute("comT", com1.getTel());
		model.addAttribute("comF", com1.getFtel());
		model.addAttribute("comA", com1.getAddress());
		
		logger.info("Welcome home! The client locale is {}.", locale);
		
		Date date = new Date();
		DateFormat dateFormat = DateFormat.getDateTimeInstance(DateFormat.LONG, DateFormat.LONG, locale);
		String formattedDate = dateFormat.format(date);
		model.addAttribute("serverTime", formattedDate );		
	 	return "home";
	  }
	}
