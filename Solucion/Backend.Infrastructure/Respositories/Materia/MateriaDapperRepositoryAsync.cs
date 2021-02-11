using Backend.Core.Interfaces;
using System;

using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using Dapper;
using Backend.Core.Entities;

namespace Backend.Infrastructure.Respositories
{
    public class MateriaDapperRepositoryAsync : IMateriaDapperRepositoryAsync
    {
        private readonly IConfiguration _configuration;
        public MateriaDapperRepositoryAsync(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<object> GetMateriasBDAsync()
        {
            object result = null;
            try
            {
                using (IDbConnection con = GetConnection())
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    if (con.State == ConnectionState.Open)
                    {
                        var query = "SP_GETMATERIAS";
                        result = await SqlMapper.QueryAsync<Materia>(con, query, commandType: CommandType.StoredProcedure);
                    }
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            return result;
        }
        private IDbConnection GetConnection()
        {
            var connectionString = _configuration.GetConnectionString("OracleDBConnection");
            var conn = new SqlConnection(connectionString);
            return conn;
        }
    }
}
