using CondoLounge.Data.Entities;

namespace CondoLounge.Data.Interfaces
{
    public interface ICondoLoungeBuildingRepository : ICondoLoungeGenericRepository<Building>
    {
        public List<ApplicationUser> AllUsers();

        public List<Condo> AllCondos();
    }
}
