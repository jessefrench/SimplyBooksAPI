<h1 align="center" style="font-weight: bold;">SimplyBooksAPI 📖</h1>

<p align="center">
<a href="#technologies">Technologies</a>
<a href="#getting-started">Getting Started</a>
<a href="#api-endpoints">API Endpoints</a>
<a href="#postman-documentation"> Postman Documentation</a>
</p>

<p align="center">SimplyBooksAPI is a REST (Representational State Transfer) API that allows users to perform basic CRUD (Create, Read, Update, Delete) operations on their book and author collections.</p>

<h2 id="technologies">💻 Technologies</h2>

- C#
- .NET
- Entity Framework Core
- PostgreSQL
- pgAdmin
- Swagger
- Postman

<h2 id="getting-started">🚀 Getting started</h2>

<h3>Prerequisites</h3>

For this project to run successfully, you'll need the following:

- [Visual Studio](https://visualstudio.microsoft.com)
- [.NET](https://dotnet.microsoft.com/en-us)
- [pgAdmin](https://www.pgadmin.org)

<h3>1. Clone the Repo</h3>

Clone this repo using this command in your terminal:

```bash
git clone https://github.com/jessefrench/SimplyBooksAPI.git
```

<h3>2. Install Required Packages</h3>

Once the repository is cloned, navigate to the project directory in your terminal (within Visual Studio) and run the following commands to install necessary packages:

```bash
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 6.0
dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0
```

<h3>3. Set Up Secrets for PostgreSQL Connection</h3>

To store sensitive connection details, initialize the secret storage with:

```bash
dotnet user-secrets init
```

Then, set the connection string for your PostgreSQL database (replace with your actual PostgreSQL password):

```bash
dotnet user-secrets set "SimplyBooksDbConnectionString" "Host=localhost;Port=5432;Username=postgres;Password=<your_postgresql_password>;Database=SimplyBooks"
```

<h3>4. Apply Migrations to the Database</h3>

Run the following command to apply the database migrations:

```bash
dotnet ef database update
```

This will create the necessary tables and schema in your PostgreSQL database.

<h3>5. Run the Solution</h3>

Launch the solution in Visual Studio. Swagger should automatically launch and provide you with the API documentation.

<h2 id="api-endpoints">📍 API Endpoints</h2>

| Route               | Description                                          
|----------------------|-----------------------------------------------------
| <kbd>GET /books</kbd>     | Retrieve a list of all books
| <kbd>GET /books/users/{userId}</kbd>     | Retrieve a list of all books in a user's collection
| <kbd>GET /books/{bookId}</kbd>     | Retrieve the details of a book
| <kbd>POST /books</kbd>     | Add a book
| <kbd>PUT /books/{bookId}</kbd>     | Update the details of a book
| <kbd>DELETE /books/{bookId}</kbd>     | Delete a book
| <kbd>GET /authors</kbd>     | Retrieve a list of all authors
| <kbd>GET /authors/users/{userId}</kbd>     | Retrieve a list of all authors in a user's collection
| <kbd>GET /authors/{authorId}</kbd>     | Retrieve the details of an author
| <kbd>POST /authors</kbd>     | Add an author
| <kbd>PUT /authors/{authorId}</kbd>     | Update the details of an author
| <kbd>DELETE /authors/{authorId}</kbd>     | Delete an author

<h2 id="postman-documentation">📄 Postman Documentation</h2>

You can also check out the [SimplyBooksAPI Postman Documentation](https://documenter.getpostman.com/view/21397951/2sAXxMgu1p) to learn more about the API routes and see examples of how each request and response should look.
