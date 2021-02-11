using Backend.Core.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using Dapper;
using Backend.Core.Entities;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Backend.Infrastructure.Respositories
{
    public class EstudianteDapperRepositoryAsync : IEstudianteDapperRepositoryAsync
    {
        private readonly IConfiguration _configuration;
        public EstudianteDapperRepositoryAsync(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<object> GetEstudiantesBDAsync()
        {
            object result = null;
            try
            {
                // var dyParam = new OracleDynamicParameters();
                // dyParam.Add("PERCURSOR", OracleDbType.RefCursor, 
                //   ParameterDirection.Output);

                using (IDbConnection con = GetConnection())
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    if (con.State == ConnectionState.Open)
                    {
                        //var query = "Select * from PERSONA";
                        var query = "SP_GETESTUDIANTES";
                        result = await SqlMapper.QueryAsync<Estudiante>(con, query, commandType: CommandType.StoredProcedure);
                        //result = await SqlMapper.QueryAsync<Estudiante>(con, query);
                    }
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            return result;
        }

      
        public async Task<bool> AddEstudianteAsync(Estudiante persona)
        {
            object result = null;
            try
            {
                var dyParam = new DynamicParameters();
                dyParam.Add("@nombre", persona.Nombres, (DbType?)SqlDbType.VarChar, ParameterDirection.Input);
                dyParam.Add("@apellidos", persona.Apellidos, (DbType?)SqlDbType.VarChar, ParameterDirection.Input);
                dyParam.Add("@ci", persona.Ci, (DbType?)SqlDbType.VarChar, ParameterDirection.Input);
                dyParam.Add("@fecha_nacimiento", persona.FechaNacimiento, (DbType?)SqlDbType.Date, ParameterDirection.Input);

                using (IDbConnection conn = GetConnection())
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    if (conn.State == ConnectionState.Open)
                    {
                        var query = "SP_INSERTPERSONA";
                        result = await SqlMapper.ExecuteAsync(conn, query, param: dyParam, commandType: CommandType.StoredProcedure);
                    }
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            return true;
        }

        private IDbConnection GetConnection()
        {
            var connectionString = _configuration.GetConnectionString("OracleDBConnection");
            var conn = new SqlConnection(connectionString);
            return conn;
        }
    }
}
