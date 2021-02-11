using Backend.Core.Entities;
using Backend.Core.Interfaces;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Backend.Infrastructure.Respositories
{
    public class InscripcionDapperRepositoryAsync : IInscripcionDapperRepositoryAsync
    {
        private readonly IConfiguration _configuration;
        public InscripcionDapperRepositoryAsync(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public async Task<object> GetInscripcionesBDAsync()
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
                        var query = "SP_GETINSCRIPCIONES";
                        result = await SqlMapper.QueryAsync<Inscripcion>(con, query, commandType: CommandType.StoredProcedure);
                    }
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            return result;
        }

        public async Task<bool> AddInscripcionesAsync(Inscripcion inscripcion)
        {
            object result = null;
            try
            {
                var dyParam = new DynamicParameters();
                var SQL = new SqlParameter();

                dyParam.Add("@ID_MATERIA", inscripcion.IdMateria, (DbType?)SqlDbType.Int, ParameterDirection.Input);
                dyParam.Add("@ID_ESTUDIANTE", inscripcion.IdEstudiante, (DbType?)SqlDbType.Int, ParameterDirection.Input);
                dyParam.Add("@DESCRIPCION", inscripcion.Descripcion, (DbType?)SqlDbType.VarChar, ParameterDirection.Input);
                dyParam.Add("@MONTO", inscripcion.Monto, (DbType?)SqlDbType.Decimal, ParameterDirection.Input);
                dyParam.Add("@FECHA", inscripcion.Fecha, (DbType?)SqlDbType.Date, ParameterDirection.Input);

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
