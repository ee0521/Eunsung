<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
	<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta charset="utf-8">
    <meta name="robots" content="all,follow">
    <meta name="googlebot" content="index,follow,snippet,archive">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>Universal - All In 1 Template</title>

    <meta name="keywords" content="">
	<%@ include file="jscss.jsp" %>
</head>

<body>
    <div id="all">
    	<%-- include directive --%>		   	
		<%@ include file="headernav.jsp" %>
		
		<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %> 
 		<c:choose>
 		<c:when test="${param.pg != null && param.pg != ''}">
 			<c:set var="pg" value="${param.pg }"/>
 		</c:when>
 		<c:otherwise>
 			<c:set var="pg" value="content.jsp"/>
 		</c:otherwise>
 		</c:choose>
 		<jsp:include page="${pg }"/>
 		
		<%@ include file="footer.jsp" %>

    </div>
    <!-- /#all -->
</body>

</html>