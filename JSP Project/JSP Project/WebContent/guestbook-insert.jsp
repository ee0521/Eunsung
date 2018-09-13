<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
 <%@ page import="guestbook.service.DeleteMessageService" %>
<%@ page import="guestbook.service.InvalidPassowrdException" %>

	<div id="content" class="clearfix">

            <div class="container">

                <div class="row">
 
                    <!-- *** LEFT COLUMN ***
			 _________________________________________________________ -->

                    <div class="col-md-9 clearfix" id="customer-account">

                        <div class="box clearfix">
                            <div class="heading">
                                <h3 class="text-uppercase">작성</h3>
                            </div>

                            <form action="upload.do" method="post" enctype="multipart/form-data">
                                <div class="row">
                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <label for="firstname">Name</label>
                                            <input type="text" readonly class="form-control" id="guestName" name="guestName" value="${name1}">
                                        </div>
                                    </div>
                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <label for="lastname">비밀번호</label>
                                            <input type="text" class="form-control" id="lastname" name="password" >
                                        </div>
                                    </div>
                                    
                                    
                                    <div class="col-sm-6">
	                                    <div class="form-group">
											 파일  <input type="file" class="form-control" id="lastname" name="fileName"><br>
										</div>
									</div>
									<div class="col-sm-6">
										<br>
										<div class="form-group">
										<label for="lastname">비밀번호</label>
										<textarea name="message" class="form-control" cols="30" rows="3"></textarea> <br>
										</div>
									</div>
									
                                </div>
                                <!-- /.row -->



                                <div class="row">
                                    

                                    <div class="col-sm-12 text-center">
                                        <button type="submit" class="btn btn-template-main"><i clas=""></i> 쓰기 </button>

                                    </div>

                                </div>

                            </form>

                        </div>

                    </div>

                    <div class="col-md-3">
                      

                        </div>
                        
                    </div>
                </div>
             

	</div>

		<div id="content">
            <div class="container">
                <div class="col-sm-6 col-sm-offset-3" id="error-page">
                    <div class="box">
                        <p class="text-center">
                            <a href="index.jsp">
                                <img src="img/logo1.png" alt="Obaju template">
                            </a>
                        </p>
                       

                        <p class="buttons"><a href="list.do" class="btn btn-template-main"><i class="fa fa-home"></i> Go to GuestBook</a>
                        </p>
                    </div>


                </div>                <!-- /.col-sm-6 -->
            </div>            <!-- /.container -->
        </div>        <!-- /#content -->	