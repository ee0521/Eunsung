<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
 <%@ page import="guestbook.service.DeleteMessageService" %>
<%@ page import="guestbook.service.InvalidPassowrdException" %>

<%
	int messageId = Integer.parseInt(request.getParameter("messageId"));
	String m = Integer.toString(messageId);
	System.out.println(m);
	boolean invalidPassowrd = false;
	try {
		DeleteMessageService deleteService = 
				DeleteMessageService.getInstance();
		deleteService.deleteMessage(messageId);
	} catch(InvalidPassowrdException ex) {
		invalidPassowrd = true;
	}
	String deleteMessage="";
	
	if (!invalidPassowrd){
		deleteMessage="메시지를 삭제하였습니다.";
   } 
	else { 
		deleteMessage="입력한 암호가 올바르지 않습니다. 암호를 확인해주세요.";
   }

%>
		<div id="content">
            <div class="container">
                <div class="col-sm-6 col-sm-offset-3" id="error-page">
                    <div class="box">
                        <p class="text-center">
                            <a href="index.html">
                                <img src="img/logo.png" alt="Obaju template">
                            </a>
                        </p>
                        <h3>작업 처리 결과</h3>
                        <h4 class="text-muted"><%=deleteMessage%></h4>

                        <p class="buttons"><a href="list.do" class="btn btn-template-main"><i class="fa fa-home"></i> Go to GuestBook</a>
                        </p>
                    </div>


                </div>                <!-- /.col-sm-6 -->
            </div>            <!-- /.container -->
        </div>        <!-- /#content -->	