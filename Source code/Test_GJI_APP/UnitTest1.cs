using App_GJI_prac;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;



namespace testsAPPGJI
{
    [TestClass]
    public class TestClassForTestingMainFunction
    {
        [TestMethod]
        public void TestValidUserInAvtorization()
        {
            AvtorizationForm avtorizationForm = new AvtorizationForm();

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestValidUserInAvtorizationIsNoValidUser()
        {
            AvtorizationForm avtorizationForm = new AvtorizationForm();

            Assert.IsTrue(avtorizationForm.ValidateUser("NoUser", "TestPassword", out string fio, out string role, out bool isAdmin));
        }

        [TestMethod]
        public void TestLoadInformationAbountReportsInTable()
        {
            FormReports formReports = new FormReports("fio", "role", true, "userName");

            Assert.IsTrue(formReports.LoadData());
        }

        [TestMethod]
        public void TestLoadInformationAbountUsersInTable()
        {
            FormReports formReports = new FormReports("fio", "role", true, "userName");

            Assert.IsTrue(formReports.LoadUsersData());
        }

        [TestMethod]
        public void TestDeleteReport()
        {
            FormReports formReports = new FormReports("fio", "role", true, "userName");

            Assert.IsTrue(formReports.DeleteRow("NoExistsReport"));
        }
    }
}
