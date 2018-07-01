using SQLite;

namespace LocalDatabaseDS.SQLite
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}