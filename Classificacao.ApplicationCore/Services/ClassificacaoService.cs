using Classificacao.ApplicationCore.Interfaces.Repository;
using Classificacao.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Classificacao.ApplicationCore.Services
{
    public class ClassificacaoService<T> : IClassificacaoService<T> where T : class
    {
        private readonly IClassificacaoRepository<T> _classificacaoRepository;

        public ClassificacaoService(IClassificacaoRepository<T> repository)
        {
            _classificacaoRepository = repository;
        }

        public void Delete(T obj)
        {
            _classificacaoRepository.Delete(obj);
        }

        public T GetById(int id)
        {
            return _classificacaoRepository.GetById(id);
        }

        public T Insert(T obj)
        {
            return _classificacaoRepository.Insert(obj);
        }

        public IList<T> ListAll()
        {
            return _classificacaoRepository.ListAll();
        }

        public void Update(T obj)
        {
            _classificacaoRepository.Update(obj);
        }

        public IList<T> ListWithPredicate(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
