# AdventureWorks

##  Project Objectives
The goal of this project is to create a full-stack microservices-based application using ASP.NET Core, MS SQL Server, Docker, and Jenkins.

##  Technology Stack
The project utilizes the following technologies:

| Technology        | Description                                       |
|-------------------|-------------------------------------------------- |
| ASP.NET Core      | Backend framework for building the REST API.      |
| MS SQL Server     | Relational database for storing application data. |
| Docker            | Containerization of application services.         |
| Jenkins           | CI/CD pipeline automation tool.                   |
| GitHub            | Version control and code collaboration.           |

###  Setup Instructions
Follow these steps to set up and run the application on your local environment:

## Step 1: Version Control & Project Setup
1. Create a GitHub Repository.
2. Clone the Repository Locally.
3. Initialize Git for Version Control.
4. Commit Best Practices.
   
## Step 2: Database Integration
1. Set Up MS SQL Server.
2. Load Adventure Works Database.
3. REST API Project in Visual Studio.
4. Create Controllers and CRUD Operations.
   
## Step 3: Microservices Architecture with Docker
1. Set Up Docker.
2. Create Dockerfiles.
3. Set Up Docker Compose.
4. Build and Run Containers.
   
## Step 4: Set Up CI/CD Pipeline with Jenkins
1. Install Jenkins.
2. Integrate GitHub with Jenkins.
3. Jenkins Pipeline Setup.
   
## Step 5: Documentation
1. Document Architecture and Setup.
2. API Documentation.

### Architecture Overview
The microservices architecture of this project consists of:

## API Service:
1. Built using ASP.NET Core as a RESTful service that interfaces with the AdventureWorks database.
2. Contains endpoints for performing CRUD operations on various data models like Products, Customers, etc.

## Database Service:
1. Uses MS SQL Server to store data for the application.
2. The AdventureWorks sample database is used to simulate a real-world business scenario.
   
## Containerization:
The API and database services are containerized using Docker, allowing for isolated and consistent environments.

## CI/CD Pipeline:
Jenkins is used to automate the build, test, and deployment process whenever changes are pushed to the GitHub repository.
