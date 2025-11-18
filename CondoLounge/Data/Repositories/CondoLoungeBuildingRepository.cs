using CondoLounge.Data.Entities;

namespace CondoLounge.Data.Repositories
{
    public class CondoLoungeBuildingRepository : CondoLoungeGenericGenericRepository<Building>
    {
        public CondoLoungeBuildingRepository(ApplicationDbContext db, ILogger<CondoLoungeGenericGenericRepository<Building>> logger) : base(db, logger)
        {
        }
    }
}
