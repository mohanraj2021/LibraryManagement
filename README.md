# Library Management System

## Frontend Technologies

* HTML 5
* CSS 3
* Javascript
    * AngularJS
    * Bootstrap
* NodeJS
* Gulp

### Single Page Application

#### Books Management Module
* Book Creation Form
* Books List with Edit and Delete Option

#### Books Dispatch

## Backend Technologies

* dotnet core

### Dependencies

* "mongocsharpdriver": "2.3.0"

## Database

* MongoDB

### Mongodb Terminologies

* Document means single row or record
* Collection means table with similar records

## Development Tools
1. Visual Studio Code - Done
2. dotnet core - Done
3. MongoDB - Done
4. RoboMongo 3T
5. Cmd
6. PostMan -- For testing HTTP endpoints
 APIs
7. Git 

## REST API

### GET /api/books
For retrieving list of all books.

#### Sample Response
```javascript
[
    {
        "id": 1,
        "name": "Da vinci code",
        "author": "xyz",
        "publishedOn": "2016-03-20",
        "publishedBy": "abc",
        "bookImage": "url",
        "qty": 5
    },
    {
        "id": 2,
        "name": "Life of pi",
        "author": "abc",
        "publishedOn": "2016-03-20",
        "publishedBy": "xyz",
        "qty": 3,
        "txn": {
            "availableQty": 2,
            "orders": [
                {
                    "customerId": 1,
                    "providedDate": "--",
                    "returnDate": "--"
                }
            ]
        }
    },
    ...
]
```

### GET /api/books/(id)
For rerieving specific book.

#### Sample Response
 ```javascript
 {
    "id": 1,
    "name": "Da vinci code",
    "author": "xyz",
    "publishedOn": "2016-03-20",
    "publishedBy": "abc",
    "qty": 3,
    "txn": {
        "availableQty": 2,
        "orders": [
            {
                "customerId": 1,
                "providedDate": "--",
                "returnDate": "--"
            }
        ]
    }
}
```


### POST /api/book
For creating new book in db.

#### Headers
* Content-Type: application/json

#### Body
```javascript
{
    "name": "Da vinci code",
    "author": "xyz",
    "publishedOn": "2016-03-20",
    "publishedBy": "abc",
    "qty": 3
}
```

#### Sample Response
```javascript
{
    "status": "SUCCESS", // SUCCESS|ERROR
    "createdId": 1,
    "message": "Book added successfully"
}
```

### PUT /api/book/(id)
For updating the existing book in db.

#### Headers
* Content-Type: application/json

#### Body
```javascript
{
    "id": 1,
    "name": "Da vinci code",
    "author": "xyz",
    "publishedOn": "2016-03-20",
    "publishedBy": "abc",
    "qty": 3
}
```

## dotnet commands help

### For creating the new project using dotnet cli
```script
dotnet new webapi -n LibraryManagement
```

### For running the project
```script
dotnet run
```

### For building the project
```script
dotnet build
```

### For adding new dependencies or package in the project
```script
dotnet add package mongocsharpdriver
dotnet add package Newtonsoft.Json
```

### For starting the mongodb server
```script
mongod
```


## Git Commands
```script
git --bare init
git remote add origin https://github.com/mohanraj2021/LibraryManagement.git
```

## References

* http://www.dotnetcurry.com/aspnet-mvc/1267/using-mongodb-nosql-database-with-aspnet-webapi-core
* 




