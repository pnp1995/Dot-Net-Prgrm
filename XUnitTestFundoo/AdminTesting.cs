using Common.AdminModel;
using FundooApi.Controllers;
using FundooManager.Interface;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestFundoo
{
   public class AdminTesting
   {
        [Fact]
        public void AddAdmin()
        {
            var service = new Mock<IAdmin>();
            var controller = new AdminController(service.Object);
            var Add = new AdminLoginModel()
            {
               Email = "pnp5657@gmail.com",
               FirstName = "Pritam",
               LastName = "Yadav",
               Password = "12345"
            };
            var data = controller.AddAdmin(Add);
            Assert.NotNull(data);
        }
    }
}
