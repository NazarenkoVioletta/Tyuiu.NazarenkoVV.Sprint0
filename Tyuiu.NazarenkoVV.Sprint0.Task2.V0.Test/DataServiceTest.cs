using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NazarenkoVV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.NazarenkoVV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private const string V = "Виолетта";

        [TestMethod]
        public void CheckGetMessageValid()
        {

            var name = "Виолетта";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет..., Виолетта", res);

        }
    }
}