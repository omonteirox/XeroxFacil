using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xeroxFacil.Controllers;
using xeroxFacil.Data;
using xeroxFacil.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace xeroxFacil.Test.Controllers
{
    [TestClass]
    [TestCategory("Xerox")]
    public class XeroxControllerTests
    {
        [TestMethod]
        public void ShouldBeReturn200OnCreated()
        {
            var xerox = new Xerox("Xerox de teste", 10, true);
            xerox.FinalDate = DateTime.Now.AddDays(-5);
            var context = new AppDataContext();
            var controller = new XeroxController();
            var result = controller.Create(xerox, context);
            Assert.AreEqual(result.Result.ToString(), "Microsoft.AspNetCore.Mvc.OkResult");
        }

        [TestMethod]
        public void ShouldReturnBadRequestOnFinalDateValidation()
        {
            var xerox = new Xerox("Xerox de teste", 10, true);
            xerox.FinalDate = DateTime.Now.AddDays(-5);
            var context = new AppDataContext();
            var controller = new XeroxController();
            var result = controller.Create(xerox, context);
            Assert.AreEqual(result.Result.ToString(), "Microsoft.AspNetCore.Mvc.BadRequestObjectResult");
        }
    }
}