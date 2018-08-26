using Classificacao.ApplicationCore.Interfaces.Repository;
using Classificacao.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Dapper;

namespace Classificacao.Infrastructure.Repository
{
    public class DapperRepository<T> : IClassificacaoRepository<T> where T : class
    {
        protected readonly ClassificacaoContext _classificacaoContext;

        public void Delete(T obj)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T Insert(T obj)
        {
            throw new NotImplementedException();
        }

        public IList<T> ListAll()
        {
            throw new NotImplementedException();
        }

        public IList<T> ListWithPredicate(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
