using Common.LabelModel;
using FundooApi.Controllers;
using FundooManager.Interface;
using Moq;
using Xunit;

namespace XUnitTestFundoo
{
    public  class LabelTesting
    {
        [Fact]
        public void Addlabel()
        {
            var service = new Mock<ILabel>();
            var controller = new LabelController(service.Object);
            var Add = new LabelModels()
            {
                
                Email = "pnp5657@gmail.com",
                Id = 12,
                Label = "pnp"
            };
            var data = controller.Addlabel(Add);
            Assert.NotNull(data);
        }
        [Fact]
        public void Updatelabel()
        {
            var service = new Mock<ILabel>();
            var controller = new LabelController(service.Object);
            var Update = new LabelModels()
            {

                Email = "pnp5657@gmail.com",
                Id = 12,
                Label = "pnp"
            };
            var data = controller.Delete(Update);
            Assert.NotNull(data);
        }
        [Fact]
        public void Deletelabel()
        {
            var service = new Mock<ILabel>();
            var controller = new LabelController(service.Object);
            var Delete = new LabelModels()
            {             
                Id = 12,
                Label = "pnp"
            };
            var data = controller.Delete(Delete);
            Assert.NotNull(data);
        }
       
    }
}
