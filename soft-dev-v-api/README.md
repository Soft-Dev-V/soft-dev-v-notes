# Soft Dev V API

Welcome to the Soft Dev V API project!

## Prerequisites

Before running the API, make sure you have the following installed:
- [.NET SDK or .NET Runtime](https://learn.microsoft.com/en-us/dotnet/core/install/linux-ubuntu-install?tabs=dotnet8&pivots=os-linux-ubuntu-2404) (version 8.0)
- [Entity Framework Core CLI](https://docs.microsoft.com/en-us/ef/core/cli/dotnet) (for running migrations)
- [Docker](https://www.docker.com/get-started) (for containerization)
- [Visual Studio Code](https://code.visualstudio.com/) (optional but recommended)

## Getting Started

1. **Clone the Repository:**
   ```sh
   git clone .
   cd soft-dev-v-api
   dotnet build
   dotnet run

2. **Run Migrations with Entity Framework:**
   ```sh
   dotnet ef migrations add InitialMigrations -c BaseContext

3. **Build and Run with Docker:**
   ```sh
   cd api
   docker compose up
