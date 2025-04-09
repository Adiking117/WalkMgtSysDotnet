using WalkManagementSystem.Models.Domain;

namespace WalkManagementSystem.Repositories
{
    public class WalkRepository : IWalkRepository
    {
        public Task<Walk> AddAsync(Walk walk)
        {
            throw new NotImplementedException();
        }

        public Task<Walk> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Walk>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Walk> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Walk> UpdateAsync(Guid id, Walk walk)
        {
            throw new NotImplementedException();
        }
    }
}
