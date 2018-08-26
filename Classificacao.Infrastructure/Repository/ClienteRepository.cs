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
    public class ClienteRepository : SqlServerRepository, IClienteRepository
    {
        public void Delete(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public Cliente GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Cliente> GetClientesByIdFila(int idFila)
        {
            throw new NotImplementedException();
        }

        public Cliente Insert(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public IList<Cliente> ListAll()
        {
            string strQuery = @"SELECT
                                	Id
                                   ,Name
                                   ,Status
                                   ,group_id AS GroupId
                                   ,Guid
                                   ,UF
                                   ,Cidade
                                   ,Macrorregiao
                                FROM Clients";
            return DataBaseClassificacao.Query<Cliente>(strQuery, null, null, true, 500, CommandType.Text).ToArray();
        }

        public IList<Cliente> ListWithPredicate(Expression<Func<Cliente, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(Cliente obj)
        {
            throw new NotImplementedException();
        }
    }
}
