using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace TaskManager.Presentation.Repositories
{
    public abstract class Repository
    {
        private readonly string _connectionString;
        private const string ConStrName = "TaskManager";

        protected Repository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings[ConStrName].ConnectionString;
        }

        protected Repository(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected string ConnectionString
        {
            get { return _connectionString; }
        }

        protected IEnumerable<TDataModel> ExecuteProcedure<TDataModel>(string procedureName, object parameters = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                return connection.Query<TDataModel>(procedureName, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        protected void ExecuteProcedure(string procedureName, object parameters = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                connection.Execute(procedureName, parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
