# Minimalism
Minimalistic C# approach of writing API based on FastEndpoints library.

Characteristics of the project:
- Opinionated directory structure
- Expressive naming which clearly describe intents
- Single responsibility principle

Ideal for:
- Microservices
- Quick project bootstrapping
- Fast prototyping

Built with:
- .net6
- FastEndpoints ( https://fast-endpoints.com/ )
- FluentValidation
- EntityFramework

Written with:
- JetBrains Rider 2021.3.3

With examples of using:
- Unit Of work and Repository pattern
- Value objects
- Value objects with Entity Framework ( avoiding primitive obsession )
- Domain Driven Design
- Rich domain models
- SQLite and migrations

## How to start
If EF tools are not installed

    dotnet tool install --global dotnet-ef

Run create database

    dotnet ef database update



dotnet tool install --global dotnet-ef

Project is put into solution as a sub directory due to the possibility of creating other connected APIs and Domain libraries.
