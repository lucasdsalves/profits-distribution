# Profits Distribution API
Distribute profits by employee based on admission time weight, occupational area weight and salary weight.

# Technologies
* .NET 5
* REST API
* Firebase Realtime Database
* Swagger
* XUnit
* Moq, Bogus
* AutoMapper
* Clean Code
* Clean Architecture

# Installation / Configuration
Prerequisites: .NET 5 Runtime, Visual Studio / Visual Studio Code

    $ git clone https://github.com/lucasdsalves/profits-distribution.git
	cd profits-distribution
	profits-distribution.sln

# Database
It's already created and available to use through Firebase Realtime Database. <br />
This API is already connected to it. <br />
Although, connection settings are available on <i>appsettings.json</i>

# Architecture
<b>API:</b> RESTful communication layer; <br />
<b>CrossCutting:</b> Funcionalities for the entire application, such as Dependency Injection config; <br />
<b>Domain:</b> Core entities layer; <br />
<b>Infra:</b> Data persistence layer; <br />
<b>Service:</b> Application business rules layer; <br />
<b>Tests:</b> Tests layer using XUnit, Moq, Bogus. 

# Get All Employees

<b><i>EmployeeController.cs </b></i>

```csharp
        [HttpGet("get-all")]
        [SwaggerOperation(
            Summary = "Get users collection from Firebase realtime database."
        )]
        public async Task<IActionResult> GetAllEmployees()
        {
            return Ok(await _employeeService.GetAllEmployeesAsync());
        }
```

# Distribute Profits

<b><i>ProfitsDistributionController.cs </b></i>

```csharp
        [HttpGet("get-all")]
        [SwaggerOperation(
            Summary = "Get users collection from Firebase realtime database."
        )]
        public async Task<IActionResult> GetAllEmployees()
        {
            return Ok(await _employeeService.GetAllEmployeesAsync());
        }
```		