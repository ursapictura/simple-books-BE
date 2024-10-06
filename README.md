
<h1 align="center" style="font-weight: bold;">Simply Books BE 💻</h1>

<p align="center">
<a href="#tech">Technologies</a>
<a href="#started">Getting Started</a>
<a href="#routes">API Endpoints</a>
<a href="#docs"> Documentation</a>
</p>


<p align="center">Simply Books is a API that allows logged-in users to CRUD on their book and author collections. Books must be given an author at the time if their creation, so make sure you create the author entity first!

User's also assign prices for each book, select if a book or author is their favorite, and elect to put books on sale.
</p>



<h2 id="tech">💻 Technologies</h2>

- C#
- .NET
- EF Core
- pgAdmin
- SQL
- Postman

<h2 id="started">🚀 Getting Started</h2>

<h3>Prerequisites</h3>

For this project to run successfully, you'll need the following tools:

- [Visual Studio](https://visualstudio.microsoft.com//)
- [.NET](https://dotnet.microsoft.com/en-us/)
- [pgAdmin](https://www.pgadmin.org/)

<h3>Cloning</h3>

How to clone your project

```bash
git clone your-project-url-in-github
```

<h3>After Cloning</h3>
How to start your project

```bash
cd project-name

dotnet new gitignore

dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 6.0

dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0

dotnet user-secrets init

dotnet user-secrets set "SimplyBooksDbConnectionString" "Host=localhost;Port=5432;Username=postgres;Password=<your_postgresql_password>;Database=SimplyBooks"
```

<h2 id="routes">📍 API Endpoints</h2>

Here you can list the main routes of your API, and what are their expected request bodies.
​
| route               | description                                          
|----------------------|-----------------------------------------------------
| <kbd>GET /books/users/{userId}</kbd>     | retrieves all books created by specific user
| <kbd>GET /books/{bookId}</kbd>     | Retrieve one book's details
| <kbd>DELETE /books/{bookId}</kbd>     | Delete specific book from database
| <kbd>POST /books</kbd>     | Add a book to database
| <kbd>PUT /books/{bookId}</kbd>     | Update specific book's details
| <kbd>GET /authors/users/{userId}</kbd>     | retrieves all authors created by specific user
| <kbd>GET /authors/{authorId}</kbd>     | Retrieve one author's details
| <kbd>DELETE /authors/{authorId}</kbd>     | Delete specific author from database
| <kbd>POST /authors</kbd>     | Add an author to database
| <kbd>PUT /authors/{authorId}</kbd>     | Update specific author's details

Visit the [API Postman Documentation](https://documenter.getpostman.com/view/31905233/2sAXxMftVX) to learn more about the API routes and examples of how each request and response should look.

<h2 id="docs">📝 Helpful Documentation</h2>

[Simply Books BE: API Documentation in Postman](https://documenter.getpostman.com/view/31905233/2sAXxMftVX)

[How to create a Pull Request](https://www.atlassian.com/br/git/tutorials/making-a-pull-request)
