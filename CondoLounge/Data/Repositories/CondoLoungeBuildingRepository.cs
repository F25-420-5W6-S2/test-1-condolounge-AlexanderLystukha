using CondoLounge.Data.Entities;
using CondoLounge.Data.Interfaces;

namespace CondoLounge.Data.Repositories
{
    public class CondoLoungeBuildingRepository : CondoLoungeGenericGenericRepository<Building>, ICondoLoungeBuildingRepository
    {
        public CondoLoungeBuildingRepository(ApplicationDbContext db, ILogger<CondoLoungeGenericGenericRepository<Building>> logger) : base(db, logger)
        {
        }

        public List<Condo> AllCondos(int buildingId)
        {
            return _dbSet.Where(b => b.Id == buildingId).Select(b => b.Condos).ToList();
        }

        public List<ApplicationUser> AllUsers(int buildingId)
        {
            IEnumerable<Condo> condos = _dbSet.Where(b => b.Id == buildingId).Select(b => b.Condos).ToList();
        }
    }
}
