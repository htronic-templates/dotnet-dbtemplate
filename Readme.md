# dotnet-htronic-dbtemplate

## Overview

This is just a collection of templates for small database libraries I use sometimes.
It's a small wrapper on top of the Dapper CSharp Library

  * Use Enum's as a lookup for connection strings
  * Extension method for returning a DataTable
  * Extension method for checking if a table exists

To give a quick example
```cs
// Get a connection 
var db = DBId.Example_Remote_SQL.GetConnection();
// Run a query that returns a datatable
var dt = conn.QueryDataTable("SELECT * FROM TestTable1");
// Do something with the datatable
dataGridView1.DataSource = dt;  
```

## Install

To install
```bash
# 1. Clone the repo that contains the template
git clone https://github.com/htronic-templates/dotnet-htronic-dbtemplate.git
# 2. Install the template from the local folder
dotnet new install ./dotnet-htronic-dbtemplate/src/Libs
```

## Usage

To use
```bash
# 1. To list installed templates
dotnet new list Htronic.DBTemplate
# 2. To create a new instance from the template
dotnet new htronic.data.mssql -n Myplatform.DB
```
