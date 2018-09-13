<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
 <%@ page import="guestbook.service.DeleteMessageService" %>
<%@ page import="guestbook.service.InvalidPassowrdException" %>
<script>
	window.onload = function () {
		var a=document.getElementsByTagName('textarea');
		a['message'].value = "${message}";
	}
 </script>
<%
		int messageId = Integer.parseInt(request.getParameter("messageId"));
%>
		<div id="content">
            <div class="container">
                <div class="col-sm-6 col-sm-offset-3" id="error-page">
                    <div class="box">
                        <p class="text-center">
                            <a href="index.jsp">
                                <img src="img/logo1.png" alt="Obaju template">
                            </a>
                        </p>
                        <form action="update.do" method="post" enctype="multipart/form-data">
                        <input type="hidden" class="form-control" name="messageId" value="<%=messageId%>">
						이름: <input type="text" class="form-control" name="guestName" readonly value="${name}"> <br>
						암호: <input type="password" class="form-control" name="password" value="${m_password}"> <br>
						<center>
						 파일 : <input type="file" class="form-control" name="fileName" value="${filename}"><br>
						</center>
						메시지: <textarea name="message" class="form-control" cols="30" rows="3"></textarea> <br>
						<input type="submit" class="btn btn-template-main" value="수정하기" />
						</form>

                        
                    </div>


                </div>                <!-- /.col-sm-6 -->
            </div>            <!-- /.container -->
        </div>        <!-- /#content -->	