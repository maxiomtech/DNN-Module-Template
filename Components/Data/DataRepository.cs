using System;
using CompanyName.ModuleName.Components.Entities;
using DotNetNuke.Data;
using DotNetNuke.Services.Exceptions;

namespace CompanyName.ModuleName.Components.Data
{
    public interface IDataRepository : IRepository<TestEntity>
    {
        //Add Custom Interface Methods
        bool TransactionPatternExample();

    }

    public class DataRepository : RepositoryImpl<TestEntity>, IDataRepository
    {
       //Implement Custom Methods
        public bool TransactionPatternExample()
        {
            using (IDataContext db = GetDataContext())
            {

                try
                {
                    var repo = db.GetRepository<TestEntity>();                    
                    db.BeginTransaction();

                    //repo.Insert();
                    //repo.Update();
                    //repo.Delete();

                    db.Commit();
                    return true;

                }
                catch (Exception ex)
                {
                    db.RollbackTransaction();
                    Exceptions.LogException(ex);
                    
                }

                return false;
            }
        }
    }
}