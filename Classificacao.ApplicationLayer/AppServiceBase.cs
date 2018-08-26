using Classificacao.ApplicationCore.Interfaces.Services;
using Classificacao.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Classificacao.ApplicationLayer.Interface;

namespace Classificacao.ApplicationLayer
{
    public class AppServiceBase<T> : IAppServiceBase<T> where T : class
    {
        private readonly IClassificacaoService<T> _classificacaoService;

        public AppServiceBase(IClassificacaoService<T> service)
        {
            _classificacaoService = service;
        }

        public void Delete(T obj)
        {
            _classificacaoService.Delete(obj);
        }

        public T GetById(int id)
        {
            return _classificacaoService.GetById(id);
        }

        public T Insert(T obj)
        {
            return _classificacaoService.Insert(obj);
        }

        public IList<T> ListAll()
        {
            return _classificacaoService.ListAll();
        }

        public IList<T> ListWithPredicate(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            _classificacaoService.Update(obj);
        }
    }
}
