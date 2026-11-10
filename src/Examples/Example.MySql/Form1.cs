using Dapper;
using DBTemplate.Data.MySql;
using DBTemplate.Data.MySql.Extensions;

namespace Example.MySql;

public partial class Form1 : Form {
    public Form1() {
        InitializeComponent();
    }

    /// <summary> Try Updating a value </summary>
    /// <param name="sender"> </param>
    /// <param name="e"> </param>
    private void Update1Butt_Click(object sender, EventArgs e) {
        var db = DBId.Example_Remote_SQL;
        using var conn = db.GetConnection();
        conn.Execute("UPDATE test_table1 SET test_string = @strval WHERE idx = @idx", new { strval = "John", idx = 2 });
    }

    /// <summary> Test Querying via a DataTable </summary>
    /// <param name="sender"> </param>
    /// <param name="e"> </param>
    private void QueryDataTable_Butt_Click(object sender, EventArgs e) {
        var db = DBId.Example_Remote_SQL;
        using var conn = db.GetConnection();
        var dt = conn.QueryDataTable("SELECT * FROM test_table1");
        dataGridView1.DataSource = dt;
    }

    /// <summary> Test Querying via a DataTable Async </summary>
    /// <param name="sender"> </param>
    /// <param name="e"> </param>
    private async void QueryDataTableAsync_Butt_Click(object sender, EventArgs e) {
        var db = DBId.Example_Remote_SQL;
        using var conn = db.GetConnection();
        var dt = await conn.QueryDataTableAsync("SELECT * FROM test_table1");
        dataGridView1.DataSource = dt;
    }

    /// <summary> Test Table Exists </summary>
    /// <param name="sender"> </param>
    /// <param name="e"> </param>
    private void TableExists1Butt_Click(object sender, EventArgs e) {
        var db = DBId.Example_Remote_SQL;
        using var conn = db.GetConnection();
        var exists = conn.TableExists("test_table1");
        MessageBox.Show(exists.ToString());
    }

    /// <summary> Test Execute Scalar </summary>
    /// <param name="sender"> </param>
    /// <param name="e"> </param>
    private void ExeScalar1Butt_Click(object sender, EventArgs e) {
        var db = DBId.Example_Remote_SQL;
        using var conn = db.GetConnection();
        // returns the value of the first column of the first row of the result set
        var count = conn.ExecuteScalar<int>("SELECT COUNT(*) FROM test_table1");
        MessageBox.Show(count.ToString());
    }

    /// <summary> Test Timespan conversion </summary>
    /// <param name="sender"> </param>
    /// <param name="e"> </param>
    private void Timespan1Butt_Click(object sender, EventArgs e) {
        var db = DBId.Example_Remote_SQL;
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
}