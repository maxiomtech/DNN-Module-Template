using CompanyName.ModuleName.Components.Entities;
using DotNetNuke.Data;

namespace CompanyName.ModuleName.Components.Data
{
    public interface IDataRepository : IRepository<TestEntity>
    {
        //Add Custom Interface Methods
    }

    public class VotingRepository : RepositoryImpl<TestEntity>, IDataRepository
    {
       //Implement Custom Methods
    }
}