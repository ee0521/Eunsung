<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<body>

<%
%>
<table width="500" cellpadding="0" cellspacing="0" border="1">
<b>주문하기</b></br>
		<form action="product_view">
			<tr>
				<td> 제품명 </td>	
				<td> 가격 </td>
				<td> 수량 </td>	
			</tr>
			
			<tr>

			<td> ${product2.wname} </td>
			<td> ${product2.wprice} </td>
			<td> ${num} </td>
			</tr>
			
	  </form>
	  <form>
	  지불금액 : ${product2.wprice}
	  <input type="button" value="주문"/>
	  </form>
	  
</table>

</body>
</html>