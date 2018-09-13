package induk.soft.cs2a.controller;

import java.awt.List;
import java.io.IOException;
import java.util.ArrayList;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import guestbook.service.GetMessageListService;
import induk.soft.cs2a.model.DAO;
import induk.soft.cs2a.model.MemberDAO;
import induk.soft.cs2a.model.MemberDAOImpl;
import induk.soft.cs2a.model.MemberDTO;
import induk.soft.cs2a.model.MemberRequestForm;
import induk.soft.cs2a.model.ProductDAOImpl;

/**
 * Servlet implementation class MemberController
 */
@WebServlet({"/MemberController", "/member-register.do", "/member-login.do", 
	"/member-list.do", "/member-update.do", "/member-unregister.do", "/member-logout.do", "/member-pwd.do", "/member-info.do", 
	"/admin-member-info.do", "/admin-member-delete.do"})
public class MemberController extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public MemberController() {
        super();
        // TODO Auto-generated constructor stub
    }
    /**
	 * @see HttpServlet#doProcess(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doProcess(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		request.setCharacterEncoding("utf-8");
		HttpSession session = request.getSession();
		
		String uri = request.getRequestURI();
		int lastIndex = uri.lastIndexOf('/');
		String action = uri.substring(lastIndex + 1);
		
		MemberDAO dao = new MemberDAOImpl();
		
		if(action.equals("member-update.do")) {
			// MemberRequestForm form = new MemberRequestForm(); // 占쏙옙占쏙옙 占쏙옙占싸되댐옙 占쏙옙체
			MemberDTO form = new MemberDTO(); // 占쏙옙占싱븝옙占� 占쏙옙占싸되댐옙 占쏙옙체占쏙옙 DAO 占싫울옙占쏙옙 처占쏙옙, 占쏙옙占쏙옙占쏙옙 占쏙옙占쏙옙 占쏙옙체, DTO 1占쏙옙 2占쏙옙
			form.setEmail((String)session.getAttribute("email1"));
			form.setName(request.getParameter("name"));
			form.setRegdate(Integer.parseInt(request.getParameter("regdate")));
			form.setZipcode(request.getParameter("zipcode"));
			form.setAddress(request.getParameter("address"));
			if(dao.update(form) > 0) {
				request.setAttribute("list", form.getName());
				request.setAttribute("message", "수정 실패");
		        request.getRequestDispatcher("index.jsp?pg=view-member-update.jsp").forward(request, response);
		        // 占쏙옙占쏙옙
			}
			else {
				request.setAttribute("message", "�쉶�썝 媛��엯 �떎�뙣");
				request.getRequestDispatcher("index.jsp?pg=error-register.jsp").forward(request, response);
			}
		}				
		else if(action.equals("member-register.do")) {
			// MemberRequestForm form = new MemberRequestForm(); // 占쏙옙占쏙옙 占쏙옙占싸되댐옙 占쏙옙체
			MemberDTO form = new MemberDTO(); // 占쏙옙占싱븝옙占� 占쏙옙占싸되댐옙 占쏙옙체占쏙옙 DAO 占싫울옙占쏙옙 처占쏙옙, 占쏙옙占쏙옙占쏙옙 占쏙옙占쏙옙 占쏙옙체, DTO 1占쏙옙 2占쏙옙
			form.setEmail(request.getParameter("email"));
			form.setName(request.getParameter("name"));
			form.setPw(request.getParameter("pw"));
			if(dao.insert(form) > 0) {
				request.setAttribute("list", request.getParameter("name")); 
		        request.getRequestDispatcher("index.jsp?pg=view-member-register.jsp").forward(request, response);
		        // 占쏙옙占쏙옙
			}
			else {
				request.setAttribute("message", "가입 실패");
				request.getRequestDispatcher("index.jsp?pg=error-register.jsp").forward(request, response);
			}
		}
		else if(action.equals("member-list.do")) {
			int mCountPage = 3;
			String pageNumberStr = request.getParameter("page");
            int pageNumber = 1;
            if (pageNumberStr != null) {
               pageNumber = Integer.parseInt(pageNumberStr);
            }
			int mCount = dao.count();		
			ArrayList<MemberDTO> memberList = null;
			int firstRow = 0;
			int endRow = 0;
			if (mCount > 0) {
				firstRow = (pageNumber - 1) * mCountPage + 1;
				endRow = firstRow + mCountPage - 1;
				memberList = dao.selectList(firstRow, endRow);
			}
			
			MemberListView mListView = new MemberListView(memberList,
						mCount, pageNumber, mCountPage, firstRow, endRow);

            
            request.setAttribute("viewData", mListView);
            request.getRequestDispatcher("index.jsp?pg=view-members.jsp").forward(request, response);
		}	
		else if(action.equals("member-login.do")) {
			MemberDTO dto = new MemberDTO();
			dto.setEmail(request.getParameter("email"));
			dto.setPw(request.getParameter("pw"));
			
			
			MemberDTO rdto = dao.select(dto);
			if(rdto != null) {
				session.setAttribute("email1", request.getParameter("email"));
				session.setAttribute("name1", rdto.getName());
				request.setAttribute("message1", "실패"); //dtoList);
				request.setAttribute("message2", "실패"); //dtoList);
		        request.getRequestDispatcher("index.jsp").forward(request, response);
			}
			else {
				request.setAttribute("message", "실패");
				request.getRequestDispatcher("index.jsp?pg=error-register.jsp").forward(request, response);
			}
		}
		else if(action.equals("member-logout.do")){
				session.removeAttribute("email1");
				request.getRequestDispatcher("index.jsp").forward(request, response);
		}
		
		else if(action.equals("member-pwd.do")){	
			MemberDTO dto = new MemberDTO();
			String email = (String)session.getAttribute("email1");
			dto.setEmail(email);
			dto.setPw(request.getParameter("password_old"));
			
			
			MemberDTO rdto = dao.select(dto);
			if(rdto != null) {
				if(request.getParameter("password_1").equals(request.getParameter("password_2")) ){
					rdto.setPw(request.getParameter("password_1"));
					dao.updatePw(rdto);
					request.getRequestDispatcher("index.jsp?pg=pw_update-message.jsp").forward(request, response);
				}
				else{
					request.setAttribute("message", "신규 비밀번호 변경 불일치로 인한 실패");
					request.getRequestDispatcher("index.jsp?pg=error-register.jsp").forward(request, response);
				}
				
			}
			else{
				request.setAttribute("message", "기존 비밀번호 불일치로 인한 실패");
				request.getRequestDispatcher("index.jsp?pg=error-register.jsp").forward(request, response);
			}
			
		}
		else if(action.equals("member-unregister.do")){
			MemberDTO dto = new MemberDTO();
			String email = (String)session.getAttribute("email1");

			dto.setEmail(email);
			dto.setPw(request.getParameter("password"));
			
			MemberDTO ddto = dao.select(dto);
			
			if(ddto != null) {
				dao.delete(ddto);
				session.removeAttribute("email1");
				request.getRequestDispatcher("index.jsp?pg=view-member-delete.jsp").forward(request, response);
			}
			else{
				request.setAttribute("message", "탈퇴 실패");
				request.getRequestDispatcher("index.jsp?pg=error-register.jsp").forward(request, response);
			}
			
		}
		else if(action.equals("admin-member-info.do")){
			//System.out.println(request.getParameter("emails"));
			MemberDTO dto = new MemberDTO();
			String email = request.getParameter("emails");
			dto.setEmail(email);
			
			MemberDTO idto = dao.selectInfo(dto);
			
			if(idto != null) {
				request.setAttribute("email", idto.getEmail());
				request.setAttribute("name", idto.getName()); 
				request.setAttribute("regdate", idto.getRegdate()); 
				request.setAttribute("zipcode", idto.getZipcode()); 
				request.setAttribute("address", idto.getAddress()); 
				request.getRequestDispatcher("index.jsp?pg=customer-detail.jsp").forward(request, response);
			}
			else{
				request.setAttribute("message", "정보조회 실패");
				request.getRequestDispatcher("index.jsp?pg=error-register.jsp").forward(request, response);
			}
			
		}
		
		else if(action.equals("member-info.do")){
			//System.out.println(request.getParameter("emails"));
			MemberDTO dto = new MemberDTO();
			String email = (String)session.getAttribute("email1");
			dto.setEmail(email);
			
			MemberDTO mdto = dao.selectInfo(dto);
			
			if(mdto != null) {
				request.setAttribute("email", mdto.getEmail());
				request.setAttribute("name", mdto.getName()); 
				request.setAttribute("regdate", mdto.getRegdate()); 
				request.setAttribute("zipcode", mdto.getZipcode()); 
				request.setAttribute("address", mdto.getAddress()); 
				request.getRequestDispatcher("index.jsp?pg=customer-update.jsp").forward(request, response);
			}
			else{
				request.setAttribute("message", "정보조회 실패");
				request.getRequestDispatcher("index.jsp?pg=error-register.jsp").forward(request, response);
			}
			
		}
		else if(action.equals("admin-member-delete.do")){
			MemberDTO dto = new MemberDTO();
			String email = request.getParameter("emails");
			System.out.println(email);
			dto.setEmail(email);
			
			MemberDTO ddto = dao.selectM(dto);
			
			if(ddto != null) {
				dao.delete(ddto);
				request.getRequestDispatcher("member-list.do").forward(request, response);
			}
			else{
				request.setAttribute("message", "멤버 삭제 실패");
				request.getRequestDispatcher("index.jsp?pg=error-register.jsp").forward(request, response);
			}
			
		}
		
		
		
	}
		

	/*
	protected void newProcess(DAO dao) {
		MemberDAOImpl mdao = (MemberDAOImpl) dao;		
	}
	
	protected void process(MemberDAOImpl dao) {
		
	}
	protected void process(ProductDAOImpl dao) {
		
	}
	*/
	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doProcess(request, response);
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doProcess(request, response);
	}

}
