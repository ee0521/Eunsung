<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title></head>
<body><center>글작성<br><table  border =1 cellspacing =0 cellpadding =3 color ="blue">
<form action="write" method="post">
	<tr><td>이름 </td>
	    <td><input type="text" name="bname" /></td>
	</tr>
	<tr><td>제목</td>
	    <td><input type="text" name="btitle"  /></td>
	</tr>
	<tr><td>내용</td>
	    <td><textarea rows =7 name="bcontent" ></textarea></td>
	</tr>
	<tr>
	   <td colspan =2>
	   <input type="submit" value="등록" align="center" /></td>
	</tr>
</form>
</table></center>
</body>
</html>