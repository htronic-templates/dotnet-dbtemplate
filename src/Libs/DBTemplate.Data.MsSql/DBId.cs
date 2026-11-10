namespace DBTemplate.Data.MsSql;

/// <summary> Represents different database connection identifiers. </summary>
public enum DBId {
    /// <summary> Example of a LocalHost Connection. </summary>
    Example_Local,

    /// <summary> Example of a remote connection using SQL Auth. </summary>
    Example_Remote_SQL,

    /// <summary> Example of a remote connection using Windows Auth. </summary>
    Example_Remote_Win
}