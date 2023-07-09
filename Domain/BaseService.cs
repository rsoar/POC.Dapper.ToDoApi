using System.Data.SqlClient;

namespace POC.Dapper.ToDoApi.Domain
{
    public class BaseService
    {
        public IConfiguration Configuration { get; }
        public SqlConnection Connection { get; }

        public BaseService(IConfiguration configuration, SqlConnection connection)
        {
            Configuration = configuration;
            Connection = connection;
        }
    }
}
