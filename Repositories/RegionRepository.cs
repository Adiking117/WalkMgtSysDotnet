﻿using WalkManagementSystem.Models.Domain;

namespace WalkManagementSystem.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        public Task<Region> AddAsync(Region region)
        {
            throw new NotImplementedException();
        }

        public Task<Region> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Region>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Region> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Region> UpdateAsync(Guid id, Region region)
        {
            throw new NotImplementedException();
        }
    }
}
