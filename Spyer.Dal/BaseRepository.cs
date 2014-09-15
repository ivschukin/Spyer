using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Spyer.Dal
{
    public abstract class BaseRepository
    {
        protected abstract string Table { get; }

        protected static IDbConnection OpenConnection()
        {
            var conStr = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;
            var con = new SqlConnection(conStr);
            con.Open();

            return con;
        }
    }
}