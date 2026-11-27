---
icon: lucide/rocket
---

# Getting Started

!!! note "Install the template"

    ```bash
    # 1. Clone the repo that contains the template
    git clone https://github.com/htronic-templates/dotnet-tpl-database.git
    # 2. Install the template from the local folder
    dotnet new install ./dotnet-tpl-database/src/Libs
    ```

!!! abstract "Create a new project"

    ```bash
    # 1. To list installed templates
    dotnet new list Htronic.DBTemplate
    # 2. To create a new instance from the template
    dotnet new htronic.data.mssql -n Myplatform.DB
    ```

!!! tip "Quick Example"

    ```cs
    // Get a connection 
    var db = DBId.Example_Remote_SQL.GetConnection();
    // Run a query that returns a datatable
    var dt = conn.QueryDataTable("SELECT * FROM TestTable1");
    // Do something with the datatable
    dataGridView1.DataSource = dt;  
    ```
