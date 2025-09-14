// Menu: todo.md

// []- Ado.net
-
- ADO.NET is a architecture that manages data access in .NET application, providing framework to interact with various data sources,
such as oracle, sql etc.
- There are 2 types connnected and disconnected architecture.
- Connected where you need to continuos connection with the database such as reading values.
- Disconnected where you need to write to the db. eg; you make a copy of the datatables in the memory and make some changes and write them back
by employing this you have less data redundancy.

- Core componets of,
1. Connection: Establishes a link between the application and the data source.
2. Command: Executes SQL statements or stored procedures.
3. DataReader: Provides fast, forward only, read only access to data.
4. DataAdapter: Acts as a bridge between the data source and the Dataset.
5. DataSet: Represents an in-memory cache of the data. It contains tables, relationships, etc

- Refer diagram -> ado-dot-net-architecture.jpg


// []- Connection string?
-
- Connection string is a string which specifies the information about how to  connect to a datasource. Typically contains server address, auth details(username, password).

// []- how do you establish connection to DB in .Net 

- Using EF Core we define DbContext class that represents a session with the database.
- Connection string is stored inside appsettings.json
- And registered in Program.cs with builder.Services.AddDbContext.
- EF automatically manages the SQL connection whenever we query.


// []- Jquery with DataTables
-
- Include DataTables library in your project.
- Initialize when the document is ready, the datatables in javascript code targetting the HTML table ID.
- Fetch data from server by providing an endpoint.
{

$(document).ready(function() {
    $('#example').DataTable({
        "processing": true,
        "serverSide": true,
        "ajax": {
            "url": "/YourController/GetData",
            "type": "POST",
            "datatype": "json"
        },
        "columns": [
            { "data": "Id" },
            { "data": "Name" },
            { "data": "Email" }
        ]
    });
});

}


// []- What’s the difference between .NET Framework and .NET Core?
-
- .NET is Windows-only whereas .NET core is cross-platform, Open source designed for modern application. 

- Which should we use today?
- .NET core because its cross platform.


// []- In Entity Framework Core, what’s the difference between Add(), Update(), and Attach()?
- 
- In EF Core, the difference comes down to how the entity is tracked:
1. Add() → Marks the entity as Added. On SaveChanges(), EF will always do an INSERT.
2. Update() → Marks the entity as Modified. On SaveChanges(), EF will generate an UPDATE for all properties, even if only one changed.
3. Attach() → Marks the entity as Unchanged. It just tells EF to start tracking it, but no SQL will run unless I later modify or delete it.


// []- Suppose you want to display job postings on your Job Listings platform. How would you fetch and display them using MVC pattern? Walk me through the flow.
-
- Model: I will create a JobPosting model class that represents the data like (id, name, salary, description).
- Controller: I will create index action that will fetch Job Postings from db and passes them to view. In list.
- View: The list controller sent, we will loop through it using razor and display job titles.
