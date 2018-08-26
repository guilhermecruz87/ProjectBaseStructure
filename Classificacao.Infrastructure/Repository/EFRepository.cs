using Classificacao.ApplicationCore.Interfaces.Repository;
using Classificacao.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Classificacao.Infrastructure.Repository
{
    public class EFRepository<T> : IClassificacaoRepository<T> where T : class
    {
        protected readonly ClassificacaoContext _classificacaoContext;
        private readonly DbSet<T> _dbSetClassificacaoContext;

        public EFRepository(ClassificacaoContext classificacaoContext)
        {
            _classificacaoContext = classificacaoContext;
            _dbSetClassificacaoContext = _classificacaoContext.Set<T>();
        }

        public void Delete(T obj)
        {
            _dbSetClassificacaoContext.Remove(obj);
            _classificacaoContext.SaveChanges();
        }
        public T GetById(int id)
        {
            return _dbSetClassificacaoContext.Find(id);
        }
        public virtual T Insert(T obj)
        {
            _dbSetClassificacaoContext.Add(obj);
            _classificacaoContext.SaveChanges();
            return obj;
        }
        public IList<T> ListAll()
        {
            return _dbSetClassificacaoContext.ToArray<T>();
        }
        public IList<T> ListWithPredicate(Expression<Func<T, bool>> predicate)
        {
            return _dbSetClassificacaoContext.Where(predicate).ToArray<T>();
        }
        public virtual void Update(T obj)
        {
            _classificacaoContext.Entry(obj).State = EntityState.Modified;
            _classificacaoContext.SaveChanges();
        }
    }
}
