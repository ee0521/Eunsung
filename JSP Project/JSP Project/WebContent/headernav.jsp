<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>

        <header>

            <!-- *** TOP ***
_________________________________________________________ -->
           <div id="top">
                <div class="container">
                    <div class="row">
                        <div class="col-xs-5 contact">
                            <p class="hidden-sm hidden-xs">Contact us on +420 777 555 333 or hello@universal.com.</p>
                            <p class="hidden-md hidden-lg"><a href="#" data-animate-hover="pulse"><i class="fa fa-phone"></i></a>  <a href="#" data-animate-hover="pulse"><i class="fa fa-envelope"></i></a>
                            </p>
                        </div>
                        <div class="col-xs-7">
                            <div class="social">
                                <a href="#" class="external facebook" data-animate-hover="pulse"><i class="fa fa-facebook"></i></a>
                                <a href="#" class="external gplus" data-animate-hover="pulse"><i class="fa fa-google-plus"></i></a>
                                <a href="#" class="external twitter" data-animate-hover="pulse"><i class="fa fa-twitter"></i></a>
                                <a href="#" class="email" data-animate-hover="pulse"><i class="fa fa-envelope"></i></a>
                            </div>

                            <div class="login">
                            <%
                            	String email = (String)session.getAttribute("email1");       
                                  if(email != null){
                                 %>
                            	 <a href="member-logout.do"><i class="fa fa-sign-in"></i> Sign Out</a>
                                 <a href="member-info.do"><i class="fa fa-user"></i> <span class="hidden-xs text-uppercase">My Page</span></a>
      
                            	<% 
                            	}
                                  else{
                            	%>

                                <a href="index.jsp?pg=#" data-toggle="modal" data-target="#login-modal"><i class="fa fa-sign-in"></i> <span class="hidden-xs text-uppercase">Sign in</span></a>
                                <a href="index.jsp?pg=customer-register.jsp"><i class="fa fa-user"></i> <span class="hidden-xs text-uppercase">Sign up</span></a>
                          		 <% }%>
                            </div>

                        </div>
                    </div>
                </div>
            </div>

            <!-- *** TOP END *** -->

            <!-- *** NAVBAR ***
    _________________________________________________________ -->

            <div class="navbar-affixed-top" data-spy="affix" data-offset-top="200">

                <div class="navbar navbar-default yamm" role="navigation" id="navbar">

                    <div class="container">
                        <div class="navbar-header">

                            <a class="navbar-brand home" href="index.jsp">
                                <img src="img/logo1.png" alt="Universal logo" class="hidden-xs hidden-sm">
                                <img src="img/logo-small1.png" alt="Universal logo" class="visible-xs visible-sm"><span class="sr-only">Universal - go to homepage</span>
                            </a>
                            <div class="navbar-buttons">
                                <button type="button" class="navbar-toggle btn-template-main" data-toggle="collapse" data-target="#navigation">
                                    <span class="sr-only">Toggle navigation</span>
                                    <i class="fa fa-align-justify"></i>
                                </button>
                            </div>
                        </div>
                        <!--/.navbar-header -->

                        <div class="navbar-collapse collapse" id="navigation">

                            <ul class="nav navbar-nav navbar-right">
                                <li class="dropdown active">
                                    <a href="index.jsp?pg=javascript: void(0)" class="dropdown-toggle" data-toggle="dropdown">Home <b class="caret"></b></a>
                                    <ul class="dropdown-menu">
                                        <li><a href="index.jsp">Option 1: Default Page</a>
                                        </li>
                                        <li><a href="index.jsp?pg=index2.jsp">Option 2: Application</a>
                                        </li>
                                        <li><a href="index.jsp?pg=index3.jsp">Option 3: Startup</a>
                                        </li>
                                        <li><a href="index.jsp?pg=index4.jsp">Option 4: Agency</a>
                                        </li>
                                        <li><a href="index.jsp?pg=index5.jsp">Option 5: Portfolio</a>
                                        </li>
                                    </ul>
                                </li>
                                <li class="dropdown use-yamm yamm-fw">
                                    <a href="index.jsp?pg=#" class="dropdown-toggle" data-toggle="dropdown">Features<b class="caret"></b></a>
                                    <ul class="dropdown-menu">
                                        <li>
                                            <div class="yamm-content">
                                                <div class="row">
                                                    <div class="col-sm-6">
                                                        <img src="img/template-easy-customize.png" class="img-responsive hidden-xs" alt="">
                                                    </div>
                                                    <div class="col-sm-3">
                                                        <h5>Shortcodes</h5>
                                                        <ul>
                                                            <li><a href="index.jsp?pg=template-accordions.jsp">Accordions</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=template-alerts.jsp">Alerts</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=template-buttons.jsp">Buttons</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=template-content-boxes.jsp">Content boxes</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=template-blocks.jsp">Horizontal blocks</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=template-pagination.jsp">Pagination</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=template-tabs.jsp">Tabs</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=template-typography.jsp">Typography</a>
                                                            </li>
                                                        </ul>
                                                    </div>
                                                    <div class="col-sm-3">
                                                        <h5>Header variations</h5>
                                                        <ul>
                                                            <li><a href="index.jsp?pg=template-header-default.jsp">Default sticky header</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=template-header-nosticky.jsp">No sticky header</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=template-header-light.jsp">Light header</a>
                                                            </li>
                                                        </ul>
                                                    </div>
                                                </div>
                                            </div>
                                        </li>
                                    </ul>
                                </li>
                                <li class="dropdown use-yamm yamm-fw">
                                    <a href="index.jsp?pg=#" class="dropdown-toggle" data-toggle="dropdown">Project<b class="caret"></b></a>
                                    <ul class="dropdown-menu">
                                        <li>
                                            <div class="yamm-content">
                                                <div class="row">
                                                    <div class="col-sm-6">
                                                        <img src="img/template-easy-customize.png" class="img-responsive hidden-xs" alt="">
                                                    </div>
                                                    <div class="col-sm-3">
                                                        <h5>Shortcodes</h5>

                                                        <ul>
                                                        <% 
                                                        if(email != null && !(email.equals("admin"))){
                                                       %>
                                                       		<li><a href="index.jsp?pg=customer-pwd.jsp">비밀번호 변경</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=customer-delete.jsp">회원 탈퇴</a>
                                                            </li>
                                                       <%
                                                        }
                                                        else if(email != null && (email.equals("admin"))){
                                                       	%>
                                                       		<li><a href="member-list.do">회원목록 조회</a>
                                                            </li>        
    												   <% 
    												    }
                                                       	%>
                                                        
                                                       	                                                  
                                                            
                                                            
                                                            <li><a href="list.do">방명록 조회</a>
                                                            </li>
                                                            
                                                            <li><a href="index.jsp?pg=template-blocks.jsp">Horizontal blocks</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=template-pagination.jsp">Pagination</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=template-tabs.jsp">Tabs</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=template-typography.jsp">Typography</a>
                                                            </li>
                                                        </ul>
                                                    </div>
                                                    <div class="col-sm-3">
                                                        <h5>Header variations</h5>
                                                        <ul>
                                                            <li><a href="index.jsp?pg=template-header-default.jsp">Default sticky header</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=template-header-nosticky.jsp">No sticky header</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=template-header-light.jsp">Light header</a>
                                                            </li>
                                                        </ul>
                                                    </div>
                                                </div>
                                            </div>
                                        </li>
                                    </ul>
                                </li>
                                <li class="dropdown use-yamm yamm-fw">
                                    <a href="index.jsp?pg=#" class="dropdown-toggle" data-toggle="dropdown">Portfolio <b class="caret"></b></a>
                                    <ul class="dropdown-menu">
                                        <li>
                                            <div class="yamm-content">
                                                <div class="row">
                                                    <div class="col-sm-6">
                                                        <img src="img/template-homepage.png" class="img-responsive hidden-xs" alt="">
                                                    </div>
                                                    <div class="col-sm-3">
                                                        <h5>Portfolio</h5>
                                                        <ul>
                                                            <li><a href="index.jsp?pg=portfolio-2.jsp">2 columns</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=portfolio-no-space-2.jsp">2 columns with negative space</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=portfolio-3.jsp">3 columns</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=portfolio-no-space-3.jsp">3 columns with negative space</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=portfolio-4.jsp">4 columns</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=portfolio-no-space-4.jsp">4 columns with negative space</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=portfolio-detail.jsp">Portfolio - detail</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=portfolio-detail-2.jsp">Portfolio - detail 2</a>
                                                            </li>
                                                        </ul>
                                                    </div>
                                                    <div class="col-sm-3">
                                                        <h5>About</h5>
                                                        <ul>
                                                            <li><a href="index.jsp?pg=about.jsp">About us</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=team.jsp">Our team</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=team-member.jsp">Team member</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=services.jsp">Services</a>
                                                            </li>
                                                        </ul>
                                                        <h5>Marketing</h5>
                                                        <ul>
                                                            <li><a href="index.jsp?pg=packages.jsp">Packages</a>
                                                            </li>
                                                        </ul>
                                                    </div>
                                                </div>
                                            </div>
                                        </li>
                                    </ul>
                                </li>
                                <!-- ========== FULL WIDTH MEGAMENU ================== -->
                                <li class="dropdown use-yamm yamm-fw">
                                    <a href="index.jsp?pg=#" class="dropdown-toggle" data-toggle="dropdown" data-hover="dropdown" data-delay="200">All Pages <b class="caret"></b></a>
                                    <ul class="dropdown-menu">
                                        <li>
                                            <div class="yamm-content">
                                                <div class="row">
                                                    <div class="col-sm-3">
                                                        <h5>Home</h5>
                                                        <ul>
                                                            <li><a href="index.jsp">Option 1: Default Page</a>
                                                            </li>
                                                            <li><a href="index2.jsp">Option 2: Application</a>
                                                            </li>
                                                            <li><a href="index3.jsp">Option 3: Startup</a>
                                                            </li>
                                                            <li><a href="index4.jsp">Option 4: Agency</a>
                                                            </li>
                                                            <li><a href="index5.jsp">Option 5: Portfolio</a>
                                                            </li>
                                                        </ul>
                                                        <h5>About</h5>
                                                        <ul>
                                                            <li><a href="index.jsp?pg=about.jsp">About us</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=team.jsp">Our team</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=team-member.jsp">Team member</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=services.jsp">Services</a>
                                                            </li>
                                                        </ul>
                                                        <h5>Marketing</h5>
                                                        <ul>
                                                            <li><a href="index.jsp?pg=packages.jsp">Packages</a>
                                                            </li>
                                                        </ul>
                                                    </div>
                                                    <div class="col-sm-3">
                                                        <h5>Portfolio</h5>
                                                        <ul>
                                                            <li><a href="index.jsp?pg=portfolio-2.jsp">2 columns</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=portfolio-no-space-2.jsp">2 columns with negative space</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=portfolio-3.jsp">3 columns</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=portfolio-no-space-3.jsp">3 columns with negative space</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=portfolio-4.jsp">4 columns</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=portfolio-no-space-4.jsp">4 columns with negative space</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=portfolio-detail.jsp">Portfolio - detail</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=portfolio-detail-2.jsp">Portfolio - detail 2</a>
                                                            </li>
                                                        </ul>
                                                        <h5>User pages</h5>
                                                        <ul>
                                                            <li><a href="index.jsp?pg=customer-register.jsp">Register / login</a>
                                                            </li>
                                                            <li><a href="member-list.do">Orders history</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=customer-order.jsp">Order history detail</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=customer-wishlist.jsp">Wishlist</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=customer-detail.jsp">Customer account / change password</a>
                                                            </li>
                                                        </ul>
                                                    </div>
                                                    <div class="col-sm-3">
                                                        <h5>Shop</h5>
                                                        <ul>
                                                            <li><a href="index.jsp?pg=shop-category.jsp">Category - sidebar right</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=shop-category-left.jsp">Category - sidebar left</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=shop-category-full.jsp">Category - full width</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=shop-detail.jsp">Product detail</a>
                                                            </li>
                                                        </ul>
                                                        <h5>Shop - order process</h5>
                                                        <ul>
                                                            <li><a href="index.jsp?pg=shop-basket.jsp">Shopping cart</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=shop-checkout1.jsp">Checkout - step 1</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=shop-checkout2.jsp">Checkout - step 2</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=shop-checkout3.jsp">Checkout - step 3</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=shop-checkout4.jsp">Checkout - step 4</a>
                                                            </li>
                                                        </ul>
                                                    </div>
                                                    <div class="col-sm-3">
                                                        <h5>Contact</h5>
                                                        <ul>
                                                            <li><a href="index.jsp?pg=contact.jsp">Contact</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=contact2.jsp">Contact - version 2</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=contact3.jsp">Contact - version 3</a>
                                                            </li>
                                                        </ul>
                                                        <h5>Pages</h5>
                                                        <ul>
                                                            <li><a href="index.jsp?pg=text.jsp">Text page</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=text-left.jsp">Text page - left sidebar</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=text-full.jsp">Text page - full width</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=faq.jsp">FAQ</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=404.jsp">404 page</a>
                                                            </li>
                                                        </ul>
                                                        <h5>Blog</h5>
                                                        <ul>
                                                            <li><a href="index.jsp?pg=blog.jsp">Blog listing big</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=blog-medium.jsp">Blog listing medium</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=blog-small.jsp">Blog listing small</a>
                                                            </li>
                                                            <li><a href="index.jsp?pg=blog-post.jsp">Blog Post</a>
                                                            </li>
                                                        </ul>
                                                    </div>
                                                </div>
                                            </div>
                                            <!-- /.yamm-content -->
                                        </li>
                                    </ul>
                                </li>
                                <!-- ========== FULL WIDTH MEGAMENU END ================== -->

                                <li class="dropdown">
                                    <a href="index.jsp?pg=javascript: void(0)" class="dropdown-toggle" data-toggle="dropdown">Contact <b class="caret"></b></a>
                                    <ul class="dropdown-menu">
                                        <li><a href="index.jsp?pg=contact.jsp">Contact option 1</a>
                                        </li>
                                        <li><a href="index.jsp?pg=contact2.jsp">Contact option 2</a>
                                        </li>
                                        <li><a href="index.jsp?pg=contact3.jsp">Contact option 3</a>
                                        </li>

                                    </ul>
                                </li>
                            </ul>

                        </div>
                        <!--/.nav-collapse -->



                        <div class="collapse clearfix" id="search">

                            <form class="navbar-form" role="search">
                                <div class="input-group">
                                    <input type="text" class="form-control" placeholder="Search">
                                    <span class="input-group-btn">

                    <button type="submit" class="btn btn-template-main"><i class="fa fa-search"></i></button>

                </span>
                                </div>
                            </form>

                        </div>
                        <!--/.nav-collapse -->

                    </div>


                </div>
                <!-- /#navbar -->

            </div>

            <!-- *** NAVBAR END *** -->

        </header>

        <!-- *** LOGIN MODAL ***
_________________________________________________________ -->

        <div class="modal fade" id="login-modal" tabindex="-1" role="dialog" aria-labelledby="Login" aria-hidden="true">
            <div class="modal-dialog modal-sm">

                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                        <h4 class="modal-title" id="Login">Customer login</h4>
                    </div>
                    <div class="modal-body">
                        <form action="member-login.do" method="post">
                            <div class="form-group">
                                <input type="text" class="form-control" id="email_modal" placeholder="email" name="email">
                            </div>
                            <div class="form-group">
                                <input type="password" class="form-control" id="password_modal" placeholder="password" name="pw">
                            </div>

                            <p class="text-center">
                                <button class="btn btn-template-main"><i class="fa fa-sign-in"></i> Log in</button>
                            </p>

                        </form>

                        <p class="text-center text-muted">Not registered yet?</p>
                        <p class="text-center text-muted"><a href="index.jsp?pg=customer-register.jsp"><strong>Register now</strong></a>! It is easy and done in 1&nbsp;minute and gives you access to special discounts and much more!</p>

                    </div>
                </div>
            </div>
        </div>

        <!-- *** LOGIN MODAL END *** -->
