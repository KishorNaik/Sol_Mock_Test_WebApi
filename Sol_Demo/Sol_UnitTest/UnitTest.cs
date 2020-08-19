using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Sol_Api;
using Sol_Api.Controllers;
using System.Threading.Tasks;

namespace Sol_UnitTest
{
    [TestClass]
    public class UnitTest
    {
        //[TestMethod]
        //public async Task Test1()
        //{
        //    var userRepositoryMock = new Mock<IUserRepository>();
        //    userRepositoryMock.Setup(x => x.GetNameById(1)).ReturnsAsync("Eshaan");

        //    UserController userController = new UserController(userRepositoryMock?.Object);
        //    var data = await userController?.GetNameById(1);

        //    Assert.AreEqual("Kishor", data);
        //}

        [TestMethod]
        public async Task Test2()
        {
            var userRepositoryMock = new Mock<IUserRepository>();
            var usedDbContextMock = new Mock<IUserDbContextMock>();

            userRepositoryMock.Setup(x => x.GetInfo(1)).ReturnsAsync(true);
            usedDbContextMock.Setup(d => d.GetInfo(1)).ReturnsAsync(false);

            IUserContext userContext = new UserContext(userRepositoryMock.Object, usedDbContextMock.Object);
            var data = await userContext?.GetInfo(1);

            Assert.IsTrue(data);
        }
    }
}