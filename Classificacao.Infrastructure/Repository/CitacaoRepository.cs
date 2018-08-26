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
