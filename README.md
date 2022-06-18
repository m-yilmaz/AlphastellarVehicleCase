# AlphastellarVehicleCase ASP.NET CORE 6 WEB API

## Project Structere

```
/src
- ApplicationCore
- Infrastructure
- WebAPI

```
## Packages

```
/ApplicationCore
Install-Package Ardalis.Specification -v 6.3.1

/Infrastructure
Install-Package Microsoft.EntityFrameworkCore -v 6.0.6
Install-Package Npgsql.EntityFrameworkCore.SqlServer -v 6.0.6
Install-Package Ardalis.Specification.EntityFrameworkCore  -v 6.0.6
Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore  -v 6.0.6

```
## Migrations
```
/Infrastructure
Add-Migration InitialCreate -OutputDir Data/Migrations
Update-Database
```
