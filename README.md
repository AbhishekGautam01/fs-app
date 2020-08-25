

# Full Stack Test Appilication 

## Stack
### Backend: 
		-> ASP.NET CORE 3.1 WEB API
		-> ORM: Dappper
		-> Configuration: Default Config Provider
		-> Swagger Endpoint: /swagger/v1/index.html
		-> Packages
			Dapper 
			System.Data.SQLClient
			Swashbuckle.AspNetCore
			Microsoft.OpenApi
			Microsoft.Extensions.Configuration.Abstraction -> for reading App configuration in infra libraries
			Microsoft.Extensions.DependencyInjection.Abstraction -> for configuring IOC Conntainer
### UI
	-> Framework: Angular
	-> Styling: Angular Material Design, CSS

### Database
	-> Database Server: Azure SQL Server

## Deployment
		**UI URI**: [http://demo-ui.azurewebsites.net/]
			-> As Azure App Service 
			-> Running in Free tier plan
		**Backend URI**: [[https://demo-service.azurewebsites.net/swagger/index.html]]
			-> As Azure App Service 
			-> Running in Free tier Plan
		**Database** -> Hosted on Azure SQL Server.Standard Plan with 20 DTU

