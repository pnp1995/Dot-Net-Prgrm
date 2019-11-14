using Common.NotesModel;
using FundooApi.Controllers;
using FundooManager.Interface;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestFundoo
{
   public class NotesTesting
   {
        [Fact]
        public void AddNotes()
        {
            var service = new Mock<INotes>();
            var controller = new NotesController(service.Object);
            var Add = new NotesModel()
            {

                Email = "pnp5657@gmail.com",
                Id = 12,
                Title = "pnp",
                Descriiption = "TUVY",
                Reminder = "2",
                Colour = "Green",
             
            };
            var data = controller.Add(Add);
            Assert.NotNull(data);
        }
        [Fact]
        public void DeleteNotes()
        {
            var service = new Mock<INotes>();
            var controller = new NotesController(service.Object);
            //var notes = new NotesModel()
            //{

            //    Email = "pnp5657@gmail.com",
            //    Id = 12,
               
            //};
            var data = controller.Delete(6);
            Assert.NotNull(data);
        }
        [Fact]
        public void UpdateNotes()
        {
            var service = new Mock<INotes>();
            var controller = new NotesController(service.Object);
            var Add = new NotesModel()
            {
                Email = "pnp5657@gmail.com",
                Id = 12,
                Descriiption = "TUVY",
                Reminder = "2",
                Colour = "Green",
            };
            var data = controller.Update(Add);
            Assert.NotNull(data);
        }
    }
}
