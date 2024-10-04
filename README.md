# .NET API with Docker and PostgreSQL

This project is a basic .NET Web API that allows for creating and retrieving users from a PostgreSQL database. The API is containerized using Docker, making it easy to set up and run in any environment.

Before you begin, ensure you have the following installed:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download)
- [Docker](https://docs.docker.com/get-docker/)
- [PostgreSQL](https://www.postgresql.org/) (optional, if running locally outside Docker)

### Clone the Repository

```bash
git clone https://github.com/nikolas-vardeberg/api-fitness.git
cd fitness
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
```

**Response with status 200**

```json
{
  "id": "c8a6as.8162131.cada612",
  "Username": "John Doe",
  "Password": "mysecretpassword",
  "Email": "johndoe@example.com"
}
```

**Response with status 400**

When a user attempts to create an account but fails to meet validation criteria, the API will return a 400 Bad Request response. The structure of the response will include specific error messages for each field that failed validation.

```json
{
    "statusCode": 400,
    "message": "One or more errors occurred!",
    "errors": {
        "username": [
            "Your username is too short."
        ],
        "email": [
            "'email' er ikke en gyldig e-postadresse."
        ],
        "password": [
            "Your password is too short."
        ]
    }
}
```


### Getting users in the database

**Endpoint:** `GET /api/user/`

**Response**

```json
{
    "users": [
        {
            "id": "02453677-857a-4574-b1d3-6ffba8f36405",
            "email": "nikolas@gmail.com",
            "password": "1234",
            "username": "Nikolas"
        }
    ]
}
```





