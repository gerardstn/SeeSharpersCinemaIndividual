using Microsoft.AspNetCore.Mvc;
using Moq;
using SeeSharpersCinema.Models.Program;
using SeeSharpersCinema.Models.Repository;
using SeeSharpersCinema.Website.Controllers;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using System.Collections.Generic;

namespace SeeSharpersCinema.IntegrationTests
{
    public class PlayListControllerTests
    {
        //[Fact]
        //public void UsablePlayListRepo()
        //{
        //    // Arrange
        //    string uiTitle = "";
        //    string uiDate = "";
        //    string uiGenre = "";
        //    string uiViewIndication = "";

        //    var mock = new Mock<IPlayListRepository>();
        //    mock.As<IAsyncEnumerable<PlayList>>().Setup(m => m.GetAsyncEnumerator()).Returns(new T)

        //    HomeController controller = new HomeController(mock.Object);

        //    var result = controller.Index(uiTitle, uiDate, uiGenre, uiViewIndication).Result as IActionResult;
            
        //    Assert.NotNull(result);
            
            
        //}
    }
}
