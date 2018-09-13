<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
 <%@ page import="guestbook.service.DeleteMessageService" %>
<%@ page import="guestbook.service.InvalidPassowrdException" %>


		<div id="content">
            <div class="container">
                <div class="col-sm-6 col-sm-offset-3" id="error-page">
                    <div class="box">
                        <p class="text-center">
                            <a href="index.html">
                                <img src="img/logo.png" alt="Obaju template">
                            </a>
                        </p>
                        <h3>방명록 메시지를 수정하였습니다</h3>
                      	<a href="list.do">[목록 보기]</a>

                        <p class="buttons"><a href="list.do" class="btn btn-template-main"><i class="fa fa-home"></i> Go to GuestBook</a>
                        </p>
                    </div>


                </div>                <!-- /.col-sm-6 -->
            </div>            <!-- /.container -->
        </div>        <!-- /#content -->	