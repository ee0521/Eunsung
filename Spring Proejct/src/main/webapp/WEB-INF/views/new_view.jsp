<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<body>
<table width="500" cellpadding="0" cellspacing="0" border="1">
		<form action="new">
			<input type="hidden" name="wid" value="${product.wid}">
			<tr>
				<td> 번호 </td>
				<td> ${product.wid} </td>
			</tr>

			<tr>
				<td> 분류 </td>
				<td> ${product.wgroup} </td>
			</tr>
			
			<tr>
				<td> 제조국 </td>
				<td> ${product.wfrom} </td>
			</tr>
			<tr>
				<td> 제품명 </td>
				<td> ${product.wname} </td>
			</tr>
			<tr>
				<td> 가격 </td>
				<td> ${product.wprice} </td>
			</tr>
			<tr>
				<td> 수량 </td>
				<td><input type="text" name="num" value="1"/> </td>
			</tr>
			<tr>
				<td> 내용 </td>
				<td> ${product.wcontent} </td>
			</tr>
			
			
			<tr >
				<td colspan="2"> <input type="submit" value="주문">
				  <a href="home">목록보기</a> 
				  <a href="delete?bid=${product.wid}">삭제</a>
				  <!-- <a href="reply_view?bid=${content_view.bid}">답변</a> --></td>
			</tr>
		</form>
	</table>
</body>
</html>