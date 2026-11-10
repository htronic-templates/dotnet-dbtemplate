using Dapper;
using DBTemplate.Data.Sqlite;
using DBTemplate.Data.Sqlite.Extensions;

namespace Example.Sqlite;

public partial class Form1 : Form {
    public Form1() {
        InitializeComponent();
    }

    /// <summary> Try Updating a value </summary>
    /// <param name="sender"> </param>
    /// <param name="e"> </param>
    private void Update1Butt_Click(object sender, EventArgs e) {
        var db = DBId.Example_Local;
        using var conn = db.GetConnection();
        conn.Execute("UPDATE test_table1 SET test_string = @strval WHERE idx = @idx", new { strval = "John", idx = 2 });
    }

    /// <summary> Test Querying via a DataTable </summary>
    /// <param name="sender"> </param>
    /// <param name="e"> </param>
    private void QueryDataTable_Butt_Click(object sender, EventArgs e) {
        var db = DBId.Example_Local;
        using var conn = db.GetConnection();
        var dt = conn.QueryDataTable("SELECT * FROM test_table1");
        dataGridView1.DataSource = dt;
    }

    /// <summary> Test Querying via a DataTable Async </summary>
    /// <param name="sender"> </param>
    /// <param name="e"> </param>
    private async void QueryDataTableAsync_Butt_Click(object sender, EventArgs e) {
        var db = DBId.Example_Local;
        using var conn = db.GetConnection();
        var dt = await conn.QueryDataTableAsync("SELECT * FROM test_table1");
        dataGridView1.DataSource = dt;
    }

    /// <summary> Test Table Exists </summary>
    /// <param name="sender"> </param>
    /// <param name="e"> </param>
    private void TableExists1Butt_Click(object sender, EventArgs e) {
        var db = DBId.Example_Local;
        using var conn = db.GetConnection();
        var exists = conn.TableExists("test_table1");
        MessageBox.Show(exists.ToString());
    }

    /// <summary> Test Execute Scalar </summary>
    /// <param name="sender"> </param>
    /// <param name="e"> </param>
    private void ExeScalar1Butt_Click(object sender, EventArgs e) {
        var db = DBId.Example_Local;
        using var conn = db.GetConnection();
        // returns the value of the first column of the first row of the result set
        var count = conn.ExecuteScalar<int>("SELECT COUNT(*) FROM test_table1");
        MessageBox.Show(count.ToString());
    }

    /// <summary> Test Timespan conversion </summary>
    /// <param name="sender"> </param>
    /// <param name="e"> </param>
    private void Timespan1Butt_Click(object sender, EventArgs e) {
        var db = DBId.Example_Local;
        using var conn = db.GetConnection();

        var ts = TimeSpan.FromHours(1.5);
        var dt = ts.ToDbDate();
        conn.Execute("UPDATE test_table1 SET test_datetime = @dt WHERE idx = @idx", new { dt, idx = 1 });
        MessageBox.Show(ts.ToString());

        var dt2 = conn.ExecuteScalar<DateTime>("SELECT test_datetime FROM test_table1 WHERE idx = @idx",
            new { idx = 1 });
        var ts2 = dt2.ToDbTimespan();
        MessageBox.Show(ts2.ToString());
    }

    /// <summary> Create the Database File / Table </summary>
    /// <param name="sender"> </param>
    /// <param name="e"> </param>
    private async void CreateButt_Click(object sender, EventArgs e) {
        var db = DBId.Example_Local;
        using var conn = db.GetConnection();

        // Create the database file if it doesn't exist
        await conn.OpenAsync();

        if (!conn.TableExists("test_table1")) {
            // Create the table
            await conn.ExecuteAsync("""
                                    CREATE TABLE test_table1 (
                                        idx INTEGER PRIMARY KEY AUTOINCREMENT,
                                        test_integer INTEGER NOT NULL,
                                        test_string TEXT NOT NULL,
                                        test_datetime TEXT NOT NULL
                                    );
                                    """);
            // Insert some rows
            await conn.ExecuteAsync("""
                                        INSERT INTO test_table1 (test_integer, test_string, test_datetime) VALUES (2, 'Hello World', '2026-09-13T15:30:00');
                                        INSERT INTO test_table1 (test_integer, test_string, test_datetime) VALUES (3, 'Hello World2', '2026-10-13T15:30:00');
                                    """);
        }
    }
}