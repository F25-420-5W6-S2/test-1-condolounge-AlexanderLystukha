using CondoLounge.Data.Entities;

namespace CondoLounge.Data.Interfaces
{
    public interface ICondoLoungeBuildingRepository : ICondoLoungeGenericRepository<Building>
    {
        public IEnumerable<Building> AllUsers();

        public IEnumerable<Condo> AllCondos();
    }
}
