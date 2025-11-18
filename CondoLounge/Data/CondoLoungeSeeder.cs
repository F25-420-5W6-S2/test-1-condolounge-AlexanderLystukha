using CondoLounge.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System.Text.Json;

namespace CondoLounge.Data
{
    public class CondoLoungeSeeder
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _hosting;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public CondoLoungeSeeder(ApplicationDbContext context,
                IWebHostEnvironment hosting,
                UserManager<ApplicationUser> userManager,
                RoleManager<IdentityRole<int>> roleManager)
        {
            _db = context;
            _hosting = hosting;     //will be used to find the full path of the project 
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task Seed()
        {
            //Verify that the database exists. Hover over the method and read the documentation. 
            _db.Database.EnsureCreated();

            if (!_roleManager.Roles.Any())
            {
                await _roleManager.CreateAsync(new IdentityRole<int>("Admin"));
                await _roleManager.CreateAsync(new IdentityRole<int>("Normal"));
            }

            //If there are no products then create the sample data from art.json
            if (!_db.Buildings.Any())
            {
                var building = new Building()
                {
                    Condos = new List<Condo>() {
                        new Condo()
                        {
                            Condo_Number = 1,
                            Address = "NYC"
                        }
                    }
                };


                _db.Buildings.Add(building);

                _db.SaveChanges();  //commit changes to the database (make permanent) 
            }


            if (!_userManager.Users.Any())
            {
                var user = new ApplicationUser()
                {
                    UserName = "admin@email.com",
                    Email = "admin@email.com",
                    Buildings = new List<Building>()
                    {
                        _db.Buildings.First()
                    },
                    Condos = new List<Condo>()
                    {
                        _db.Condos.First()
                    }
                };
                await _userManager.CreateAsync(user, "VerySecureAdmin45%");
                await _userManager.AddToRoleAsync(user, "Admin");
            }


        }
    }
}
