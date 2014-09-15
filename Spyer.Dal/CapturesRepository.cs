using Dapper;
using Spyer.Contracts;

namespace Spyer.Dal
{
    public class CapturesRepository : BaseRepository
    {
        public void Add(Capture capture)
        {
            using (var con = OpenConnection())
            {
                var sql = string.Format(@"INSERT INTO [{0}] ([Bytes], [CreationDate]) VALUES (@Bytes, @CreationDate)", Table);
                con.Query(sql, capture);
            }
        }

        protected override string Table
        {
            get { return "Captures"; }
        }
    }
}
