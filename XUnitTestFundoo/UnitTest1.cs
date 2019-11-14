using Common.Models;
using FundooApi.Controllers;
using FundooManager.Interface;
using Moq;
using System;
using Xunit;

namespace XUnitTestFundoo
{
    public class UnitTest1
    {
        [Fact]
        public void Registration()
        {
            var service = new Mock<IAccount>();
            var controller = new AccountController(service.Object);
            var Add = new UserModel()
            {
                FirstName = "Pritam",
                LastName = "Yadav",
                Emailid = "pnp5657@gmail.com",
                Password = "pnp"
            };
            var data = controller.Registration(Add);
            Assert.NotNull(data);
        }
    }
}
