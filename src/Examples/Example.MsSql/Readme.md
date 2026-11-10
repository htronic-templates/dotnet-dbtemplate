# Readme

Example of accessing a MSSQL Database

## Docker Compose Image

Example docker compose file `compose.yml`
```
services:
  sqlserver:
    image: mcr.microsoft.com/mssql/server:2025-latest
    container_name: sqlserver1
    environment:
      ACCEPT_EULA: "Y"
      MSSQL_PID: "Developer"
      MSSQL_SA_PASSWORD: "%DemoPassword1234"
    ports:
      - "1433:1433"
    volumes:
      - sqlserverdata:/var/opt/mssql
    mem_limit: 4g

volumes:
  sqlserverdata:
```

## Bringing the docker container up

To bring the container up / down
```sh
# To bring the docker contaner up and run it in daemon mode
docker compose up -d
# To bring the docker container down / delete any stored volumes
docker compose down -v
```

## Create the Database

```sql
-- To create a new database
IF DB_ID('dbtest') IS NULL
    CREATE DATABASE dbtest;

-- To switch to the database
USE dbtest;
```

## Create Test Table

Create Table
```sql
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TestTable1](
	[idx] [int] IDENTITY(1,1) NOT NULL,
	[TestInteger] [int] NOT NULL,
	[TestString] [NVARCHAR](1024) NOT NULL,
    [TestDateTime] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idx] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
```

Insert some values
```sql
INSERT INTO TestTable1 (TestInteger, TestString, TestDateTime) VALUES (2, 'Hello World', '2026-09-13T15:30:00');
INSERT INTO TestTable1 (TestInteger, TestString, TestDateTime) VALUES (3, 'Hello World2', '2026-10-13T15:30:00');
```
