using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using studentLibrary;

namespace UnitTestProject2
{
    [TestClass]
    public class TestTeacher
    {
        private Teacher _teacher;
        [TestInitialize]
        public void BeforeTest()
        {
            _teacher = new Teacher("Peter", 200.3);
            _teacher.Address = "Rafteager 4";
        }

        [TestMethod]
        public void CheckName()
        {
            Assert.AreEqual("Peter", _teacher.FirstName);
            _teacher.FirstName = "Anders";
            Assert.AreEqual("Anders", _teacher.FirstName);

        }

        [TestMethod]
        public void TestSalary()
        {
            Assert.AreEqual(200.3, _teacher.Salary,0.0001);
            _teacher.Salary = 100.3;
            Assert.AreEqual(100.3,_teacher.Salary, 0.01);
        }

        [TestMethod]
        public void testAddress()
        {
            Assert.AreEqual("Rafteager 4", _teacher.Address);
            _teacher.Address = "Færøvej 10";
            Assert.AreEqual("Færøvej 10", _teacher.Address);
        }
       
    }
}
