using System.Threading.Tasks;
using StudentsCrud.Models.TokenAuth;
using StudentsCrud.Web.Controllers;
using Shouldly;
using Xunit;

namespace StudentsCrud.Web.Tests.Controllers
{
    public class HomeController_Tests: StudentsCrudWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}