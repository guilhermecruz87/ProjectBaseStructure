using Classificacao.ApplicationCore.Entity;
using Classificacao.ApplicationCore.Interfaces.Repository;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace Classificacao.Infrastructure.Repository
{
    public class FilaRepository : SqlServerRepository, IFilaRepository
    {
        public void Delete(Fila obj)
        {
            string strQuery = @"DELETE FROM Fila WHERE Id = @IdFila";
            DataBaseClassificacao.Execute(strQuery, new { IdFila = obj.Id }, null, 500, CommandType.Text);
        }

        public Fila GetById(int id)
        {
            string strQuery = @"SELECT * FROM Fila WHERE Id = @IdFila";
            return DataBaseClassificacao.QueryFirstOrDefault<Fila>(strQuery, new { IdFila = id }, null, 500, CommandType.Text);
        }

        public Fila Insert(Fila obj)
        {
            string strQuery = @"INSERT INTO Fila (Nome) VALUES (@NomeFila)";
            return DataBaseClassificacao.QueryFirstOrDefault<Fila>(strQuery, new { NomeFila = obj.Nome }, null, 500, CommandType.Text);
        }

        public IList<Fila> ListAll()
        {
            string strQuery = @"SELECT IdFila AS Id, Nome FROM Fila";
            return DataBaseClassificacao.Query<Fila>(strQuery, null, null, true, 500, CommandType.Text).ToArray();
        }

        public void Update(Fila obj)
        {
            string strQuery = @"UPDATE Fila SET Nome = @NomeFila WHERE Id = @IdFila";
            DataBaseClassificacao.Execute(strQuery, new { IdFila = obj.Id, NomeFila = obj.Nome }, null, 500, CommandType.Text);
        }

        /// <summary>
        /// ISSO ERA PRA ENTITYFRAMEWORK
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IList<Fila> ListWithPredicate(Expression<Func<Fila, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
