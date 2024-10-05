using CustomerManagementSystem.MVC.Domain.Enumerations.Users;
using CustomerManagementSystem.MVC.Domain.IdentityEntities;
using Microsoft.AspNetCore.Identity;

namespace CustomerManagementSystem.MVC.Persistence.DataSeeding.Users
{
    public static class UsersDataSeeding
    {
        public static async Task InitializeUsersAsync(this UserManager<ApplicationUser> userManager)
        {
            var users = new List<ApplicationUser>()
            {
              new ApplicationUser()
              {
                UserName = "abdullah.kamal",
                Email = "abdullah.kamal@gmail.com",
                Name = "Abdullah Kamal",
                Code = Guid.NewGuid().ToString(),
              },
              new ApplicationUser()
              {
                UserName = "mdummett0",
                Email = "mdummett0@reverbnation.com",
                Name = "Morrie Dummett",
                Code = Guid.NewGuid().ToString(),
              },
              new ApplicationUser()
              {
                UserName = "giacovuzzi1",
                Email = "giacovuzzi1@infoseek.co.jp",
                Name = "Garwin Iacovuzzi",
                Code = Guid.NewGuid().ToString(),
              },
              new ApplicationUser()
              {
                UserName = "cbasey2",
                Email = "cbasey2@hc360.com",
                Name = "Cordy Basey",
                Code = Guid.NewGuid().ToString(),
              },
              new ApplicationUser()
              {
                UserName = "vredfield3",
                Email = "vredfield3@prlog.org",
                Name = "Valaria Redfield",
                Code = Guid.NewGuid().ToString(),
              },
              new ApplicationUser()
              {
                UserName = "amagor4",
                Email = "amagor4@bing.com",
                Name = "Arlan Magor",
                Code = Guid.NewGuid().ToString(),
              },
              new ApplicationUser()
              {
                UserName = "obraundt5",
                Email = "obraundt5@engadget.com",
                Name = "Odie Braundt",
                Code = Guid.NewGuid().ToString(),
              },
              new ApplicationUser()
              {
                UserName = "mgrigoryov6",
                Email = "mgrigoryov6@freewebs.com",
                Name = "Marleen Grigoryov",
                Code = Guid.NewGuid().ToString(),
              },
              new ApplicationUser()
              {
                UserName = "pgilbody7",
                Email = "pgilbody7@springer.com",
                Name = "Pen Gilbody",
                Code = Guid.NewGuid().ToString(),
              },
              new ApplicationUser()
              {
                UserName = "mbonnett8",
                Email = "mbonnett8@yahoo.com",
                Name = "Maurie Bonnett",
                Code = Guid.NewGuid().ToString(),
              },
              new ApplicationUser()
              {
                UserName = "cbrasner9",
                Email = "cbrasner9@theguardian.com",
                Name = "Cecelia Brasner",
                Code = Guid.NewGuid().ToString(),
              },
              new ApplicationUser()
              {
                UserName = "mbearfoota",
                Email = "mbearfoota@ftc.gov",
                Name = "Michel Bearfoot",
                Code = Guid.NewGuid().ToString(),
              },
              new ApplicationUser()
              {
                UserName = "dakettb",
                Email = "dakettb@people.com.cn",
                Name = "Diane Akett",
                Code = Guid.NewGuid().ToString(),
              },
              new ApplicationUser()
              {
                UserName = "dlehonc",
                Email = "dlehonc@wordpress.org",
                Name = "Donall Lehon",
                Code = Guid.NewGuid().ToString(),
              },
              new ApplicationUser()
              {
                UserName = "hburnessd",
                Email = "hburnessd@toplist.cz",
                Name = "Hastie Burness",
                Code = Guid.NewGuid().ToString(),
              },
              new ApplicationUser()
              {
                UserName = "tseamere",
                Email = "tseamere@posterous.com",
                Name = "Tania Seamer",
                Code = Guid.NewGuid().ToString(),
              },
              new ApplicationUser()
              {
                UserName = "dquestierf",
                Email = "dquestierf@github.com",
                Name = "Delilah Questier",
                Code = Guid.NewGuid().ToString(),
              },
              new ApplicationUser()
              {
                UserName = "amcveaghg",
                Email = "amcveaghg@cnbc.com",
                Name = "Alene McVeagh",
                Code = Guid.NewGuid().ToString(),
              },
              new ApplicationUser()
              {
                UserName = "lsainsburybrownh",
                Email = "lsainsburybrownh@ihg.com",
                Name = "Ludovico Sainsbury-Brown",
                Code = Guid.NewGuid().ToString(),
              },
              new ApplicationUser()
              {
                UserName = "mdevanyi",
                Email = "mdevanyi@symantec.com",
                Name = "Martina Devany",
                Code = Guid.NewGuid().ToString(),
              },
              new ApplicationUser()
              {
                UserName = "nbrimmj",
                Email = "nbrimmj@shareasale.com",
                Name = "Nowell Brimm",
                Code = Guid.NewGuid().ToString(),
              }
            };

            foreach (var user in users)
            {
                await userManager.CreateAsync(user, "P@ssw0rd");
                await userManager.AddToRoleAsync(user, nameof(UserRoles.Customer));
            }
        }
    }
}