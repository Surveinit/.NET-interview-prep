// Menu: todo.md

// []- What’s the difference between GET and POST in HTTP?
- 
- GET -> fetch data, getting animal pictures from server
- POST -> send data, posting animal pictures to the server.

// []- What are common HTTP status codes?
- 
- 200 -> OK
- 404 -> Not found
- 500 -> Internal server error.

// []- What is a REST API?
- 
- REST ie (Representational State Transfer) is a set of guidelines for building web services.
- Its stateless, resource based and uses standard HTTP methods like GET, POST, PUT & DELETE. 
- for eg;
1. GET /books -> Gets all books.
1. GET /books/1 -> Get book with id=1;


// []- How do you call an API in .NET?
- 
- In .NET, we call APIs using HttpClient class.
- for eg; GetAsync() to fetch data.
- PostAsync() to send data.
- response.Content.ReadAsStringAsync() to read response.
