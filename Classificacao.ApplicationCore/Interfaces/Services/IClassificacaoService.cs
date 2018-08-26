using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Classificacao.ApplicationCore.Interfaces.Services
{
    public interface IClassificacaoService<T> where T : class
    {
        T Insert(T obj);
        void Update(T obj);
        void Delete(T obj);
        IList<T> ListAll();
        T GetById(int id);
        IList<T> ListWithPredicate(Expression<Func<T, bool>> predicate);
    }
}
