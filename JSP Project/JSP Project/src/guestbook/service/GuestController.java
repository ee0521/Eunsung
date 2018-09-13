package guestbook.service;

import java.io.File;
import java.io.IOException;
import java.sql.Connection;
import java.sql.SQLException;
import java.util.Collection;

import javax.servlet.ServletException;
import javax.servlet.annotation.MultipartConfig;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import javax.servlet.http.Part;

import guestbook.dao.MessageDao;
import guestbook.model.Message;
import jdbc.JdbcUtil;
import jdbc.connection.ConnectionProvider;

/**
 * Servlet implementation class GuestController
 */
@WebServlet({ "/GuestController", "/upload.do", "/list.do", "/edit.do", "/update.do" })
@MultipartConfig(fileSizeThreshold=1024*1024, maxFileSize=1024*1024*5, maxRequestSize=1024*1024*5*5)
public class GuestController extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public GuestController() {
        super();
        // TODO Auto-generated constructor stub
    }

    private String partName;
    private String partValue;
    private String getFileName(Part part) { // 파일 이름 추출하여서 DBMS 추가할 때 사용
    	String contentDispositionHeader = part.getHeader("content-disposition");
    	String[] splitedContentDisposition = contentDispositionHeader.split(";");
    	for (String cd : splitedContentDisposition ) {
	    	if (cd.trim().startsWith("filename")) {
	    		return cd.substring(cd.indexOf('=') + 1).trim().replace("\"", "");
	    	}
    	}
    	return null;
    }
    protected void doProcess(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
    	request.setCharacterEncoding("utf-8");
		HttpSession session = request.getSession();
		
		String uri = request.getRequestURI();
		int lastIndex = uri.lastIndexOf('/');
		String action = uri.substring(lastIndex + 1);
		
		if(action.equals("list.do")){
			 if (request.getParameter("guestName") == null) {
		            String pageNumberStr = request.getParameter("page");
		            int pageNumber = 1;
		            if (pageNumberStr != null) {
		               pageNumber = Integer.parseInt(pageNumberStr);
		            }
		   
		            GetMessageListService messageListService = 
		                  GetMessageListService.getInstance();
		            MessageListView viewData = 
		                  messageListService.getMessageList(pageNumber);
		            
		            
		            request.setAttribute("viewData", viewData);
		            request.getRequestDispatcher("index.jsp?pg=gb_list.jsp").forward(request, response);
		         } 
			 else {
		            String pageNumberStr = request.getParameter("page");
		            String guestName = request.getParameter("guestName");
		            int pageNumber = 1;
		            if (pageNumberStr != null) {
		               pageNumber = Integer.parseInt(pageNumberStr);
		            }

		            GetMessageListService messageListService = 
		                  GetMessageListService.getInstance();
		            MessageListView viewData = 
		                  messageListService.getMessageSerchList(pageNumber, guestName);
		            
		            session.setAttribute("guestname1", request.getParameter("guestName"));
		            request.setAttribute("viewData", viewData);
		            request.getRequestDispatcher("index.jsp?pg=gb_list.jsp").forward(request, response);
		      }


		}
		if(action.equals("upload.do")){
			Collection<Part> parts = request.getParts(); 
			for(Part part : parts) {
				partName = part.getName();
				if(part.getContentType() != null) { // 파일 업로드 처리
					partValue = getFileName(part);
					if (partValue != null && ! partValue.isEmpty()) {
						String absolutePath = getServletContext().getRealPath("/egyou");
						part.write(absolutePath + File.separator + partValue);
					}
				}
				else { // 파일 외 다른 유형의 요청 처리
					partValue = request.getParameter(partName);
				}
				request.setAttribute(partName, partValue);
			} // DBMS 처리되지 않고 있음
			
			Message message1 = new Message();
			message1.setGuestName(request.getParameter("guestName"));
			message1.setPassword(request.getParameter("password"));
			message1.setFileName((String) request.getAttribute("fileName"));
			message1.setMessage((String) request.getAttribute("message"));

			WriteMessageService writeService = WriteMessageService.getInstance();
			writeService.write(message1);
			
			request.getRequestDispatcher("index.jsp?pg=view-guestbook-insert.jsp").forward(request, response);

		}
		if(action.equals("update.do")){
			Collection<Part> parts = request.getParts(); 
			for(Part part : parts) {
				partName = part.getName();
				if(part.getContentType() != null) { // 파일 업로드 처리
					partValue = getFileName(part);
					if (partValue != null && ! partValue.isEmpty()) {
						String absolutePath = getServletContext().getRealPath("/egyou");
						part.write(absolutePath + File.separator + partValue);
					}
				}
				else { // 파일 외 다른 유형의 요청 처리
					partValue = request.getParameter(partName);
				}
				request.setAttribute(partName, partValue);
			} // DBMS 처리되지 않고 있음
			
			Message message2 = new Message();
			message2.setGuestName(request.getParameter("guestName"));
			message2.setPassword(request.getParameter("password"));
			message2.setFileName((String) request.getAttribute("fileName"));
			message2.setMessage((String) request.getAttribute("message"));
			message2.setId(Integer.parseInt(request.getParameter("messageId")));

			WriteMessageService writeService = WriteMessageService.getInstance();
			writeService.update(message2);
			
			request.getRequestDispatcher("index.jsp?pg=view-guestbook-update.jsp").forward(request, response);

		}
		
		if(action.equals("edit.do")){
			int messageId = Integer.parseInt(request.getParameter("messageId"));
			Connection conn = null;
			
			try {
				conn = ConnectionProvider.getConnection();
				conn.setAutoCommit(false);

				MessageDao messageDao = MessageDao.getInstance();
				Message message = messageDao.select(conn, messageId);
				

				
				request.setAttribute("name",message.getGuestName());
				request.setAttribute("message",message.getMessage());
				request.setAttribute("filename",message.getFileName());
				request.setAttribute("m_password",message.getPassword());
				request.setAttribute("messageId", messageId);
				request.getRequestDispatcher("index.jsp?pg=guestbook-update.jsp").forward(request, response);

				conn.commit();
			} catch (SQLException ex) {
				JdbcUtil.rollback(conn);
				throw new ServiceException("실패:" + ex.getMessage(), ex);
			} catch (InvalidPassowrdException | MessageNotFoundException ex) {
				JdbcUtil.rollback(conn);
				throw ex;
			} finally {
				JdbcUtil.close(conn);
			}
			

		}
	} 
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
