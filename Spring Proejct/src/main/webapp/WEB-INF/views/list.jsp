<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib uri ="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8" />
<title>게시판</title>

</style>
</head>
<body><center>
<hr width =800 color ="blue" />
<h4 style="text-align: center;">게시판</h4>
<hr width =800 color ="blue" />
<table width =800 cellpadding =0 cellspacing =0 border=1>
	 
   <tr>
		<th align ="center" width =50>번호</th>
		<th align ="center" width =100>이름</th>
		<th align ="center" width =300>제목</th>
		<th align ="center"  width =300>날짜</th>
		<th align ="center"  width =50>조회</th>
   </tr>
   <!-- model.setAttribute("list", dtos); -->
   <c:forEach items="${list}" var="dtos">
		<tr>
			<td>${dtos.bid}</td>
			<td>${dtos.bname}</td>
			<td>
				<c:forEach begin="1" end ="${dtos.bindent }">-></c:forEach>
				<a href ="content_view?bid=${dtos.bid}">${dtos.btitle}</a>
			</td>
			<!-- 제목을 클릭하면 내용으로 연결하기 위해 -->
			<td>${dtos.bdate }</td>
			<td>${dtos.bhit}</td>
		</tr>
   </c:forEach>  
   <tr>
	    <td colspan="5" align ="center"><a href="write_view">글쓰기</a></td>
	</tr>  
</table></center>
</body>
</html>