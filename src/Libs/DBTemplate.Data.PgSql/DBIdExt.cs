using System.Data;
using System.Data.Common;
using System.Diagnostics;
using Npgsql;

namespace DBTemplate.Data.PgSql;

/// <summary> Provides extension methods for looking up the connection string. </summary>
public static class DBIdentExtensions {
    /// <summary> Gets the connection string for the specified identifier. </summary>
    /// <param name="ident"> Database Identifier </param>
    /// <returns> Connection string for the database </returns>
    /// <exception cref="ArgumentOutOfRangeException"> </exception>
    [DebuggerStepThrough]
    public static string GetConnectionString(this DBId ident) {
        return ident switch {
            DBId.Example_Local =>
                "Host=localhost;Port=5432;Database=dbtest;Username=postgres;Password=%DemoPassword1234;Trust Server Certificate=true;",
            DBId.Example_Remote_SQL =>
                "Host=192.168.111.65;Port=5432;Database=dbtest;Username=pgadmin;Password=%DemoPassword1234;Trust Server Certificate=true;",
            DBId.Example_Remote_Win =>
                "Host=192.168.111.65;Port=5432;Database=dbtest;Integrated Security=true;Trust Server Certificate=true;",
            _ => throw new ArgumentOutOfRangeException(nameof(ident))
        };
    }

    /// <summary> Gets the database connection for the specified identifier. </summary>
    /// <param name="ident"> Database Identifier </param>
    /// <returns> Connection to the Database </returns>
    [DebuggerStepThrough]
    public static DbConnection GetConnection(this DBId ident) {
        return ident switch {
            DBId.Example_Local => new NpgsqlConnection(ident.GetConnectionString()),
            DBId.Example_Remote_SQL => new NpgsqlConnection(ident.GetConnectionString()),
            DBId.Example_Remote_Win => new NpgsqlConnection(ident.GetConnectionString()),
            _ => throw new ArgumentOutOfRangeException(nameof(ident))
        };
    }

    /// <summary> WithConnection helper method. </summary>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="db"> The database identifier. </param>
    /// <param name="action"> The action to execute. </param>
    /// <returns> The result of the action. </returns>
    [DebuggerStepThrough]
    public static TResult WithConnection<TResult>(this DBId db, Func<IDbConnection, TResult> action) {
        using var conn = db.GetConnection();
        return action(conn);
    }
}