using System.Data;
using System.Diagnostics;
using Dapper;

namespace DBTemplate.Data.MsSql.Extensions;

/// <summary> Additional Dapper Extension Methods. </summary>
public static class DapperExtensions {
    /// <summary> Queries the database and returns the results as a DataTable. </summary>
    /// <param name="connection"> The database connection. </param>
    /// <param name="sql"> The SQL query. </param>
    /// <param name="param"> The parameters for the SQL query. </param>
    /// <param name="transaction"> The transaction to use. </param>
    /// <param name="commandTimeout"> The command timeout. </param>
    /// <param name="commandType"> The command type. </param>
    /// <returns> The DataTable containing the query results. </returns>
    [DebuggerStepThrough]
    public static DataTable QueryDataTable(this IDbConnection connection, string sql,
        object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null,
        CommandType? commandType = null) {
        using var reader = connection.ExecuteReader(sql, param, transaction, commandTimeout, commandType);
        var table = new DataTable();
        table.Load(reader);
        return table;
    }

    /// <summary> Queries the database asynchronously and returns the results as a DataTable. </summary>
    /// <param name="connection"> The database connection. </param>
    /// <param name="sql"> The SQL query. </param>
    /// <param name="param"> The parameters for the SQL query. </param>
    /// <param name="transaction"> The transaction to use. </param>
    /// <param name="commandTimeout"> The command timeout. </param>
    /// <param name="commandType"> The command type. </param>
    /// <param name="cancellationToken"> The cancellation token. </param>
    /// <returns> The DataTable containing the query results. </returns>
    [DebuggerStepThrough]
    public static async Task<DataTable> QueryDataTableAsync(this IDbConnection connection, string sql,
        object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null,
        CommandType? commandType = null, CancellationToken cancellationToken = default) {
        var command = new CommandDefinition(sql, param, transaction, commandTimeout, commandType,
            cancellationToken: cancellationToken);
        using var reader = await connection.ExecuteReaderAsync(command);
        var table = new DataTable();
        table.Load(reader);
        return table;
    }

    /// <summary> Checks if a table exists in the database. </summary>
    /// <param name="connection"> The database connection. </param>
    /// <param name="table_name"> The name of the table to check. </param>
    /// <returns> true if the table exists, false otherwise. </returns>
    [DebuggerStepThrough]
    public static bool TableExists(this IDbConnection connection, string tableName) {
        var sql = "SELECT CASE WHEN EXISTS";
        sql += "(SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = @tableName)";
        sql += "THEN 1 ELSE 0 END";
        var exists = connection.ExecuteScalar<bool>(sql, new { tableName });
        return exists;
    }
}