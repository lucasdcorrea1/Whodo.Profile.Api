using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Whodo.Profile.CrossCutting.Base.DapperBase
{
    public class DapperBaseRepository<TEntity>
    {
        private SqlConnection Create()
        {
            return new SqlConnection("");
        }

        public async Task<int> ExecuteAsync(string query, object parameters = null)
        {
            int ret;
            using (var cn = Create())
            {
                cn.Open();
                ret = await cn.ExecuteAsync(query, parameters);
                cn.Close();
                cn.Dispose();
            }

            return ret;
        }

        public async Task<IEnumerable<TEntity>> QueryAsync(string query, object parameters = null)
        {
            IEnumerable<TEntity> items;
            using (var cn = Create())
            {
                cn.Open();
                items = await cn.QueryAsync<TEntity>(query, parameters);
                cn.Close();
                cn.Dispose();
            }

            return items;
        }

        public async Task<TEntity> QueryFirstOrDefaultAsync(string query, object parameters = null)
        {
            TEntity item;
            using (var cn = Create())
            {
                cn.Open();
                item = await cn.QueryFirstOrDefaultAsync<TEntity>(query, parameters);
                cn.Close();
                cn.Dispose();
            }

            return item;
        }
    }
}
