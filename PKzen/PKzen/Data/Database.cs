using Microsoft.Data.Sqlite;

namespace PKzen.Data;

public sealed class Database {
    private const string CONNECTION_STRING = "Data Source=K:\\Temporalis\\RiderProjects\\PKzen\\Resources\\PKzenDB"; // TODO: Cambiar la ruta mas adelante
    private static readonly Lazy<Database> _instance = new(() => new Database());

    private Database() {
        Connection = new SqliteConnection(CONNECTION_STRING);
        Connection.Open();
    }

    public static Database Instance => _instance.Value;

    public SqliteConnection Connection { get; }
}
