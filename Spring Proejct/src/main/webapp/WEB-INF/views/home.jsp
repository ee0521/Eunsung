<%@ page session="false" language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>

<html>
<head>
	<title>Home</title>
	<meta charset="utf-8" />
</head>
<body><center>
<a href ="login_view" align="left">로그인</a>
<a href ="new_view" align="left">상품등록</a>
<hr width="600" color="blue" />
<h1 color ="red" width =600>
	induck 강아지 쇼핑몰
</h1>
<hr width="600" color="blue" />
<table border =1 cellspacing  =0 cellpadding =0 >
<tr>
	<td><a href="product_view?wid=2"><img src="resources/img3.jpg" /></a></td>
	<td><img src="resources/img2.jpg" /></td>
    <td><img src="resources/img1.jpg"/>
    </td><td><img src="resources/img4.jpg"/></td>
</tr>
<tr><td>.</td><td>.</td>
    <td>.</td><td>.</td>
</tr>
<tr><td>.</td><td>.</td>
    <td>.</td><td>.</td>
</tr>
</table>
<hr width="600" color="blue" />
    <h4  width =600>회사명:${comN}, 번호:${comT}, 팩스:${comF}, 주소:${comA}</h4>
<hr width="600" color="blue" />
</center>
</body>
</html>
