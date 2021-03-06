<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import="induk.soft.cs2a.controller.*"%>
		
        <div id="heading-breadcrumbs">
            <div class="container">
                <div class="row">
                    <div class="col-md-6">
                        <h1>Shopping cart</h1>
                    </div>
                    <div class="col-md-6">
                        <ul class="breadcrumb">
                            <li><a href="index.html">Home</a>
                            </li>
                            <li>Shopping cart</li>
                        </ul>

                    </div>
                </div>
            </div>
        </div>

        <div id="content">
            <div class="container">

                <div class="row">
                    <div class="col-md-12">
                        <p class="text-muted lead">You currently have 3 item(s) in your cart.</p>
                    </div>


                    <div class="col-md-9 clearfix" id="basket">

                        <div class="box">

                            <form method="post" action="shop-checkout1.html">

                                <div class="table-responsive">
                                    <table class="table">
                                        <thead>
                                            <tr>
                                                <th colspan="2" width="50%">EMAIL</th>
                                                <th colspan="2" width="30%">NAME</th>
                                                <th>CLUSTERID</th>
                                            </tr>
                                        </thead>
                                        <tbody>
							<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
							<c:forEach var="o" items="${requestScope.viewData.memberList}">
	                                         <tr>
	                                          <!--
                                                <td>
                                                    <a href="#">
                                                         <img src="img/detailsquare.jpg" alt="White Blouse Armani"> 
                                                    </a>
                                                </td>
                                                -->
                                                <td colspan="2"><a href="admin-member-info.do?emails=${o.email }">${o.email }</a>
                                                </td>
                                                <td colspan="2">  ${o.name} </td>

                                                <td><a href="admin-member-delete.do?emails=${o.email }"><i class="fa fa-trash-o"></i></a>
                                                </td>
                                            </tr>    
                            </c:forEach>                                       
                                        </tbody>
                            
                                    </table>
               <%
                      MemberListView m = (MemberListView)request.getAttribute("viewData");
	                  int pageNumber = m.getCurrentPageNumber();
	                  int pageTotal = m.getPageTotalCount();
                     int startPage = (pageNumber-1)/5*5 + 1;
                     int endPage = (pageNumber-1)/5*5 + 5 > pageTotal ? pageTotal : (pageNumber-1)/5*5 + 5;

                     int page_p = pageNumber - 5 < 1 ? 1 : pageNumber - 5;
                     int page_n = pageNumber + 5 > pageTotal ? pageTotal : pageNumber + 5;
                  %>
                  
                       <div class="col-md-12 center">
                       <center>
                           <ul class="pagination">
                               <li><a href="member-list.do?page=<%=page_p %>">&larr;</a>
                               </li>
                               <c:forEach var="pageNum" begin="<%=startPage %>" end="<%=endPage %>">
                               <c:choose>
                           <c:when test="${viewData.currentPageNumber == pageNum}">
                                     <li class="active">
                                 <a href="member-list.do?page=${pageNum}">${pageNum}</a> 
                              </li>
                           </c:when>
                           <c:otherwise>
                                     <li>
                                 <a href="member-list.do?page=${pageNum}">${pageNum}</a> 
                              </li>
                           </c:otherwise>
                        </c:choose>
                        </c:forEach>
                               <li><a href="member-list.do?page=<%=page_n %>">&rarr;</a>
                               </li>
                           </ul>
                	  </div>
                   
							</center>
                                </div>
                                <!-- /.table-responsive -->

                                <div class="box-footer">
                                    <div class="pull-left">
                                        <a href="shop-category.html" class="btn btn-default"><i class="fa fa-chevron-left"></i> Continue shopping</a>
                                    </div>
                                    <div class="pull-right">
                                        <button class="btn btn-default"><i class="fa fa-refresh"></i> Update cart</button>
                                        <button type="submit" class="btn btn-template-main">Proceed to checkout <i class="fa fa-chevron-right"></i>
                                        </button>
                                    </div>
                                </div>

                            </form>

                        </div>
                        <!-- /.box -->

                        <div class="row">
                            <div class="col-md-3">
                                <div class="box text-uppercase">
                                    <h3>You may also like these products</h3>
                                </div>
                            </div>

                            <div class="col-md-3">
                                <div class="product">
                                    <div class="image">
                                        <a href="shop-detail.html">
                                            <img src="img/product2.jpg" alt="" class="img-responsive image1">
                                        </a>
                                    </div>
                                    <div class="text">
                                        <h3><a href="shop-detail.html">Fur coat</a></h3>
                                        <p class="price">$143</p>

                                    </div>
                                </div>
                                <!-- /.product -->
                            </div>

                            <div class="col-md-3">
                                <div class="product">
                                    <div class="image">
                                        <a href="shop-detail.html">
                                            <img src="img/product3.jpg" alt="" class="img-responsive image1">
                                        </a>
                                    </div>
                                    <div class="text">
                                        <h3><a href="shop-detail.html">Fur coat</a></h3>
                                        <p class="price">$143</p>
                                    </div>
                                </div>
                                <!-- /.product -->
                            </div>

                            <div class="col-md-3">
                                <div class="product">
                                    <div class="image">
                                        <a href="shop-detail.html">
                                            <img src="img/product1.jpg" alt="" class="img-responsive image1">
                                        </a>
                                    </div>
                                    <div class="text">
                                        <h3><a href="shop-detail.html">Fur coat</a></h3>
                                        <p class="price">$143</p>
                                    </div>
                                </div>
                                <!-- /.product -->
                            </div>

                        </div>

                    </div>
                    <!-- /.col-md-9 -->

                    <div class="col-md-3">
                        <div class="box" id="order-summary">
                            <div class="box-header">
                                <h3>Order summary</h3>
                            </div>
                            <p class="text-muted">Shipping and additional costs are calculated based on the values you have entered.</p>

                            <div class="table-responsive">
                                <table class="table">
                                    <tbody>
                                        <tr>
                                            <td>Order subtotal</td>
                                            <th>$446.00</th>
                                        </tr>
                                        <tr>
                                            <td>Shipping and handling</td>
                                            <th>$10.00</th>
                                        </tr>
                                        <tr>
                                            <td>Tax</td>
                                            <th>$0.00</th>
                                        </tr>
                                        <tr class="total">
                                            <td>Total</td>
                                            <th>$456.00</th>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>

                        </div>


                        <div class="box">
                            <div class="box-header">
                                <h4>Coupon code</h4>
                            </div>
                            <p class="text-muted">If you have a coupon code, please enter it in the box below.</p>
                            <form>
                                <div class="input-group">

                                    <input type="text" class="form-control">

                                    <span class="input-group-btn">

					    <button class="btn btn-template-main" type="button"><i class="fa fa-gift"></i></button>

					</span>
                                </div>
                                <!-- /input-group -->
                            </form>
                        </div>

                    </div>
                    <!-- /.col-md-3 -->

                </div>

            </div>
            <!-- /.container -->
        </div>
        <!-- /#content -->