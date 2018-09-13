<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
        <div id="content">
            <div class="container">

                <div class="col-sm-6 col-sm-offset-3" id="error-page">

                    <div class="box">

                        <p class="text-center">
                            <a href="index.html">
                                <img src="img/logo.png" alt="Obaju template">
                            </a>
                        </p>
<%@ page import="java.util.*" %>
                        <h3>가입 정보</h3>
                        <h4 class="text-muted">${sessionScope.dream.cName }</h4>
                        <h4 class="text-muted">${sessionScope.dream.cEmail }</h4>
                        <h4 class="text-muted">
                        <%
                        	String email = (String) request.getAttribute("cEmail");
                        	HashMap<String, String> signUp = (HashMap) session.getAttribute(email);
                        	String cPw = signUp.get("cPw");
                        	out.println(cPw);
                        %></h4>
						<h4 class="text-muted">${requestScope.cEmail }</h4>
                        <p class="buttons"><a href="index.jsp" class="btn btn-template-main"><i class="fa fa-home"></i> Go to Homepage</a>
                        </p>
                    </div>


                </div>
                <!-- /.col-sm-6 -->
            </div>
            <!-- /.container -->
        </div>
        <!-- /#content -->