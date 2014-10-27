using System.Collections.Generic;
using DotNetNuke.Collections;
using DotNetNuke.Data;

namespace CompanyName.ModuleName.Components.Data
{
    public abstract class RepositoryImpl<T> : IRepository<T> where T : class
    {


        private IDataContext _localContext = DataContext.Instance();
        public void SetDataContext(string connectionStringName)
        {
            _localContext = DataContext.Instance(connectionStringName);
        }

        public IDataContext GetDataContext()
        {
            return _localContext;
        }

        public virtual void Delete(T item)
        {
            using (IDataContext db = _localContext)
            {
                dynamic repo = db.GetRepository<T>();
                repo.Delete(item);
            }
        }

        public virtual void Delete(string sqlCondition, params object[] args)
        {
            using (IDataContext db = _localContext)
            {
                dynamic repo = db.GetRepository<T>();
                repo.Delete(sqlCondition, args);
            }
        }

        public virtual IEnumerable<T> Find(string sqlCondition, params object[] args)
        {
            IEnumerable<T> list = default(IEnumerable<T>);
            using (IDataContext db = _localContext)
            {
                dynamic repo = db.GetRepository<T>();
                list = repo.Find(sqlCondition, args);
            }
            return list;
        }

        public virtual IPagedList<T> Find(int pageIndex, int pageSize, string sqlCondition, params object[] args)
        {
            IPagedList<T> list = default(IPagedList<T>);
            using (IDataContext db = _localContext)
            {
                dynamic repo = db.GetRepository<T>();
                list = repo.Find(pageIndex, pageSize, sqlCondition, args);
            }
            return list;
        }

        public virtual IEnumerable<T> Get()
        {
            IEnumerable<T> list = default(IEnumerable<T>);
            using (IDataContext db = _localContext)
            {
                dynamic repo = db.GetRepository<T>();
                list = repo.Get();
            }
            return list;
        }

        public virtual IEnumerable<T> Get<TScopeType>(TScopeType scopeValue)
        {
            IEnumerable<T> list = default(IEnumerable<T>);
            using (IDataContext db = _localContext)
            {
                dynamic repo = db.GetRepository<T>();
                list = repo.Get<TScopeType>(scopeValue);
            }
            return list;
        }

        public virtual T GetById<TProperty>(TProperty id)
        {
            T item = default(T);
            using (IDataContext db = _localContext)
            {
                dynamic repo = db.GetRepository<T>();
                item = repo.GetById<TProperty>(id);
            }
            return item;
        }

        public virtual T GetById<TProperty, TScopeType>(TProperty id, TScopeType scopeValue)
        {
            T item = default(T);
            using (IDataContext db = _localContext)
            {
                dynamic repo = db.GetRepository<T>();
                item = repo.GetById<TProperty, TScopeType>(id, scopeValue);
            }
            return item;
        }

        public virtual IPagedList<T> GetPage(int pageIndex, int pageSize)
        {
            IPagedList<T> list = default(IPagedList<T>);
            using (IDataContext db = _localContext)
            {
                dynamic repo = db.GetRepository<T>();
                list = repo.GetPage(pageIndex, pageSize);
            }
            return list;
        }

        public virtual IPagedList<T> GetPage<TScopeType>(TScopeType scopeValue, int pageIndex, int pageSize)
        {
            IPagedList<T> list = default(IPagedList<T>);
            using (IDataContext db = _localContext)
            {
                dynamic repo = db.GetRepository<T>();
                list = repo.GetPage<TScopeType>(scopeValue, pageIndex, pageSize);
            }
            return list;
        }

        public virtual void Insert(T item)
        {
            using (IDataContext db = _localContext)
            {
                dynamic repo = db.GetRepository<T>();
                repo.Insert(item);
            }
        }

        public virtual void Update(T item)
        {
            using (IDataContext db = _localContext)
            {
                dynamic repo = db.GetRepository<T>();
                repo.Update(item);
            }
        }

        public virtual void Update(string sqlCondition, params object[] args)
        {
            using (IDataContext db = _localContext)
            {
                dynamic repo = db.GetRepository<T>();
                repo.Update(sqlCondition, args);
            }
        }
    }
}