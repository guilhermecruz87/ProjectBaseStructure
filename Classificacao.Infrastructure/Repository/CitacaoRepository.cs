using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using Classificacao.ApplicationCore.Entity;
using Classificacao.ApplicationCore.Interfaces.Repository;
using Dapper;

namespace Classificacao.Infrastructure.Repository
{
    public class CitacaoRepository : SqlServerRepository, ICitacaoRepository
    {
        public void Delete(Citacao obj)
        {
            throw new NotImplementedException();
        }

        public Citacao GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Citacao> GetCitacoesByIdFila(int idFila)
        {
            string strQuery = @"SELECT
                                	R.Id
                                   ,R.Client_id AS IdCliente
                                   ,R.Username AS Autor
                                   ,R.Date AS Data
                                   ,R.Text AS Texto
                                   ,R.Site AS Fonte
                                   ,R.Image AS UrlProfile
                                   ,R.Url AS LinkExterno
                                   ,R.Status
                                   ,R.Type
                                   ,R.Date_Capture AS DataCaptura
                                   ,R.Date_Classification AS DataClassificacao
                                FROM Results R
                                JOIN Clients C WITH (NOLOCK)
                                	ON R.Client_id = C.Id
                                JOIN Filas_clientes FC WITH (NOLOCK)
                                	ON C.Id = FC.idCliente
                                WHERE C.status <> 3
                                AND R.Status = 0
                                AND R.Type = 0
                                AND FC.idFila = @IdFila
                                ORDER BY R.Date DESC";
            return DataBaseClassificacao.Query<Citacao>(strQuery, new { IdFila = idFila }, null, true, 500, CommandType.Text).ToArray();
        }

        public Citacao Insert(Citacao obj)
        {
            throw new NotImplementedException();
        }

        public IList<Citacao> ListAll()
        {
            string strQuery = @"SELECT
                                	Id
                                   ,Client_id AS IdCliente
                                   ,Username AS Autor
                                   ,Date AS Data
                                   ,Text AS Texto
                                   ,Site AS Fonte
                                   ,Image AS UrlProfile
                                   ,Url AS LiknExterno
                                   ,Status
                                   ,Type
                                   ,Date_Capture AS DataCaptura
                                   ,Date_Classification AS DataClassificacao
                                FROM Results WHERE Client_id = 781 AND Date > '2016-01-01'";
            return DataBaseClassificacao.Query<Citacao>(strQuery, null, null, true, 500, CommandType.Text).ToArray();
        }

        public IList<Citacao> ListWithPredicate(Expression<Func<Citacao, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(Citacao obj)
        {
            throw new NotImplementedException();
        }
    }
}
