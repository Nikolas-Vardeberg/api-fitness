# .NET API with Docker and PostgreSQL

This project is a basic .NET Web API that allows for creating and retrieving users from a PostgreSQL database. The API is containerized using Docker, making it easy to set up and run in any environment.

Before you begin, ensure you have the following installed:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download)
- [Docker](https://docs.docker.com/get-docker/)
- [PostgreSQL](https://www.postgresql.org/) (optional, if running locally outside Docker)

### Clone the Repository

```bash
git clone https://github.com/nikolas-vardeberg/api-fitness.git
cd dotnet-api-with-docker
```


### Api Endpoints

## API Endpoints

### Create a User

**Endpoint:** `POST /api/user/create`

Creates a new user in the database.

**Request body:**

```json
{
  "Username": "John Doe",
  "Password": "mysecretpassword",
  "Email": "johndoe@example.com"
}


