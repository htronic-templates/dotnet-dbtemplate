namespace Example.PgSql;

partial class Form1 {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        Update1Butt = new Button();
        tabControl1 = new TabControl();
        tabPage1 = new TabPage();
        Timespan1Butt = new Button();
        ExeScalar1Butt = new Button();
        TableExists1Butt = new Button();
        tabPage2 = new TabPage();
        QueryDataTableAsync_Butt = new Button();
        QueryDataTable_Butt = new Button();
        dataGridView1 = new DataGridView();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        tabPage2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // Update1Butt
        // 
        Update1Butt.Location = new Point(31, 28);
        Update1Butt.Margin = new Padding(4, 5, 4, 5);
        Update1Butt.Name = "Update1Butt";
        Update1Butt.Size = new Size(150, 38);
        Update1Butt.TabIndex = 0;
        Update1Butt.Text = "Update1";
        Update1Butt.UseVisualStyleBackColor = true;
        Update1Butt.Click += Update1Butt_Click;
        // 
        // tabControl1
        // 
        tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Location = new Point(17, 20);
        tabControl1.Margin = new Padding(4, 5, 4, 5);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(1109, 710);
        tabControl1.TabIndex = 1;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(Timespan1Butt);
        tabPage1.Controls.Add(ExeScalar1Butt);
        tabPage1.Controls.Add(TableExists1Butt);
        tabPage1.Controls.Add(Update1Butt);
        tabPage1.Location = new Point(4, 34);
        tabPage1.Margin = new Padding(4, 5, 4, 5);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(4, 5, 4, 5);
        tabPage1.Size = new Size(1101, 672);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Basic";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // Timespan1Butt
        // 
        Timespan1Butt.Location = new Point(31, 172);
        Timespan1Butt.Margin = new Padding(4, 5, 4, 5);
        Timespan1Butt.Name = "Timespan1Butt";
        Timespan1Butt.Size = new Size(150, 38);
        Timespan1Butt.TabIndex = 3;
        Timespan1Butt.Text = "Timsspan1";
        Timespan1Butt.UseVisualStyleBackColor = true;
        Timespan1Butt.Click += Timespan1Butt_Click;
        // 
        // ExeScalar1Butt
        // 
        ExeScalar1Butt.Location = new Point(31, 124);
        ExeScalar1Butt.Margin = new Padding(4, 5, 4, 5);
        ExeScalar1Butt.Name = "ExeScalar1Butt";
        ExeScalar1Butt.Size = new Size(150, 38);
        ExeScalar1Butt.TabIndex = 2;
        ExeScalar1Butt.Text = "Execute Scalar";
        ExeScalar1Butt.UseVisualStyleBackColor = true;
        ExeScalar1Butt.Click += ExeScalar1Butt_Click;
        // 
        // TableExists1Butt
        // 
        TableExists1Butt.Location = new Point(31, 76);
        TableExists1Butt.Margin = new Padding(4, 5, 4, 5);
        TableExists1Butt.Name = "TableExists1Butt";
        TableExists1Butt.Size = new Size(150, 38);
        TableExists1Butt.TabIndex = 1;
        TableExists1Butt.Text = "Table Exists1";
        TableExists1Butt.UseVisualStyleBackColor = true;
        TableExists1Butt.Click += TableExists1Butt_Click;
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(QueryDataTableAsync_Butt);
        tabPage2.Controls.Add(QueryDataTable_Butt);
        tabPage2.Controls.Add(dataGridView1);
        tabPage2.Location = new Point(4, 34);
        tabPage2.Margin = new Padding(4, 5, 4, 5);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(4, 5, 4, 5);
        tabPage2.Size = new Size(1101, 672);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "DataTable";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // QueryDataTableAsync_Butt
        // 
        QueryDataTableAsync_Butt.Location = new Point(242, 35);
        QueryDataTableAsync_Butt.Name = "QueryDataTableAsync_Butt";
        QueryDataTableAsync_Butt.Size = new Size(218, 36);
        QueryDataTableAsync_Butt.TabIndex = 2;
        QueryDataTableAsync_Butt.Text = "Query DataTable Async";
        QueryDataTableAsync_Butt.UseVisualStyleBackColor = true;
        QueryDataTableAsync_Butt.Click += QueryDataTableAsync_Butt_Click;
        // 
        // QueryDataTable_Butt
        // 
        QueryDataTable_Butt.Location = new Point(29, 33);
        QueryDataTable_Butt.Margin = new Padding(4, 5, 4, 5);
        QueryDataTable_Butt.Name = "QueryDataTable_Butt";
        QueryDataTable_Butt.Size = new Size(206, 38);
        QueryDataTable_Butt.TabIndex = 1;
        QueryDataTable_Butt.Text = "Query DataTable";
        QueryDataTable_Butt.UseVisualStyleBackColor = true;
        QueryDataTable_Butt.Click += QueryDataTable_Butt_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(29, 97);
        dataGridView1.Margin = new Padding(4, 5, 4, 5);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 62;
        dataGridView1.Size = new Size(1047, 557);
        dataGridView1.TabIndex = 0;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1143, 750);
        Controls.Add(tabControl1);
        Margin = new Padding(4, 5, 4, 5);
        Name = "Form1";
        Text = "Example PgSql";
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button Update1Butt;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private DataGridView dataGridView1;
    private Button QueryDataTable_Butt;
    private Button QueryDataTableAsync_Butt;
    private Button TableExists1Butt;
    private Button ExeScalar1Butt;
    private Button Timespan1Butt;
}
