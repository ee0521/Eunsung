var http = require("http");  
  
http.createServer(function(request, response) {  
  response.writeHead(200, {"Content-Type": "text/plain"});  
  response.write("형 뭐해..?");  
  response.end();  
}).listen(3000);  
