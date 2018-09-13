<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import="guestbook.service.*"%>
<%@ page import="guestbook.model.*"%>
        <div id="heading-breadcrumbs">
            <div class="container">
                <div class="row">
                    <div class="col-md-7">
                        <h1>방명록</h1>
                    </div>
                    <div class="col-md-5">
                        <ul class="breadcrumb">
                            <li><a href="index.jsp">Home</a>
                            </li>
                            <li>GuestBook</li>
                        </ul>

                    </div>
                </div>
            </div>
        </div>

                <div id="content">
        
            <div class="container">
                <div class="row">
                    <!-- *** LEFT COLUMN ***
			 _________________________________________________________ -->
			 			<% 
			 			String email1 = (String)session.getAttribute("email1");
			 			
			 			if(email1 != null){
			 				
			 			%>
						<form action="index.jsp?pg=guestbook-insert.jsp" method="post" enctype="multipart/form-data">
							<input type="submit" class="btn btn-template-main" value="메시지 남기기" />
						</form>
						<%
			 			}
						%>
                        <div class="col-md-3 col-sm-offset-3">

                            <div class="panel-heading">
                                <h3 class="panel-title">이름검색</h3>
                            </div>

                            <div class="panel-body">
                                <form role="search" action="list.do">
                                    <div class="input-group">
                                        <input type="text" name="guestName" class="form-control" placeholder="Search" value="${guestname1 }">
                                        <span class="input-group-btn">

		   									 <button type="submit" class="btn btn-template-main"><i class="fa fa-search"></i></button>
											
										</span>
                                    </div>
                                </form>
                               
                                
                               
                            </div>

                        </div>

                    <div class="col-md-9" id="blog-listing-small">
                    
						

                        <div class="row">
						<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
							<c:forEach var="message" items="${viewData.messageList}">
                            <div class="col-md-4 col-sm-6">
                             <br>
                                <div class="box-image-text blog">
                                    <div class="top">
                                        <div class="image"height="20">
                                            <img src="egyou/${message.fileName }" alt="" class="img-responsive" >
                                        </div>
                                        <br>
                                        
                                    </div>
                                    <div class="content">
                                        <h4>${message.id}</a></h4>
                                        <p class="author-category">By <a href="#">${message.guestName}
                                        </p> 
                                        <p class="intro">${message.message}</p>
                                        </p>
                                        <%
                                        
                                        Message m = (Message)request.getAttribute("message");
                                       
                                        //String guestName = m.getGuestName();
                                         if(email1 != null){
                                        	 if(!(email1.equals("admin"))){
                                        	//if(((String)session.getAttribute("email1")).equals(guestName)){
                                        %>
                               				<c:if test="${message.guestName eq email1}">
                                        		<p class="read-more"><a href="edit.do?messageId=${message.id }" class="btn btn-template-main">수정하기 </a> </p>
                                        	</c:if>
                                        <%	
                                        	}
                               				 else{
                               			%>
										 		<a href="index.jsp?pg=view-guestbook-delete.jsp&messageId=${message.id}">[삭제하기]</a>
										<% 
											} 
                               			 }
                               			  %>
                                       
                                    </div>
                                </div>
                                <!-- /.box-image-text -->
                               
								
								 
									
								
								
                            </div>
							</c:forEach>
							
                        </div>
						 </div>		
                        	
                            
                  <%
	                  MessageListView m = (MessageListView)request.getAttribute("viewData");
	                  int pageNumber = m.getCurrentPageNumber();
	                  int pageTotal = m.getPageTotalCount();
                     int startPage = (pageNumber-1)/5*5 + 1;
                     int endPage = (pageNumber-1)/5*5 + 5 > pageTotal ? pageTotal : (pageNumber-1)/5*5 + 5;

                     int page_p = pageNumber - 5 < 1 ? 1 : pageNumber - 5;
                     int page_n = pageNumber + 5 > pageTotal ? pageTotal : pageNumber + 5;
                  %>
                  <center>
                       <div class="col-md-9 center">
                           <ul class="pagination">
                               <li><a href="list.do?page=<%=page_p %>">&larr;</a>
                               </li>
                               <c:forEach var="pageNum" begin="<%=startPage %>" end="<%=endPage %>">
                               <c:choose>
                           <c:when test="${viewData.currentPageNumber == pageNum}">
                                     <li class="active">
                                 <a href="list.do?page=${pageNum}">${pageNum}</a> 
                              </li>
                           </c:when>
                           <c:otherwise>
                                     <li>
                                 <a href="list.do?page=${pageNum}">${pageNum}</a> 
                              </li>
                           </c:otherwise>
                        </c:choose>
                        </c:forEach>
                               <li><a href="list.do?page=<%=page_n %>">&rarr;</a>
                               </li>
                           </ul>
                	  </div>
                   
							</center>
            



                    
                    <!-- /.col-md-9 -->

                    <!-- *** LEFT COLUMN END *** -->

                    <!-- *** RIGHT COLUMN ***
			 _________________________________________________________ -->

                    <div class="col-md-3">

                        <!-- *** MENUS AND WIDGETS ***
 _________________________________________________________ -->
                        <div class="panel panel-default sidebar-menu">

                            <div class="panel-heading">
                                <h3 class="panel-title">Text widget</h3>
                            </div>

                            <div class="panel-body text-widget">
                                <p>Improved own provided blessing may peculiar domestic. Sight house has sex never. No visited raising gravity outward subject my cottage mr be. Hold do at tore in park feet near my case.
                                </p>

                            </div>
                        </div>



                        <div class="panel panel-default sidebar-menu">

                            <div class="panel-heading">
                                <h3 class="panel-title">Categories</h3>
                            </div>

                            <div class="panel-body">
                                <ul class="nav nav-pills nav-stacked">
                                    <li><a href="blog.html">Webdesign</a>
                                    </li>
                                    <li class="active"><a href="blog.html">Tutorials</a>
                                    </li>
                                    <li><a href="blog.html">Print</a>
                                    </li>
                                    <li><a href="blog.html">Our tips</a>
                                    </li>
                                </ul>
                            </div>
                        </div>

                        <div class="panel sidebar-menu">
                            <div class="panel-heading">
                                <h3 class="panel-title">Tags</h3>
                            </div>

                            <div class="panel-body">
                                <ul class="tag-cloud">
                                    <li><a href="#"><i class="fa fa-tags"></i> html5</a> 
                                    </li>
                                    <li><a href="#"><i class="fa fa-tags"></i> css3</a> 
                                    </li>
                                    <li><a href="#"><i class="fa fa-tags"></i> jquery</a> 
                                    </li>
                                    <li><a href="#"><i class="fa fa-tags"></i> ajax</a> 
                                    </li>
                                    <li><a href="#"><i class="fa fa-tags"></i> php</a> 
                                    </li>
                                    <li><a href="#"><i class="fa fa-tags"></i> responsive</a> 
                                    </li>
                                    <li><a href="#"><i class="fa fa-tags"></i> visio</a> 
                                    </li>
                                    <li><a href="#"><i class="fa fa-tags"></i> bootstrap</a> 
                                    </li>
                                </ul>
                            </div>
                        </div>

                        <!-- *** MENUS AND FILTERS END *** -->

                    </div>
                    <!-- /.col-md-3 -->

                    <!-- *** RIGHT COLUMN END *** -->

                </div>
                <!-- /.row -->
            </div>
            <!-- /.container -->
        </div>

        <!-- /#content -->