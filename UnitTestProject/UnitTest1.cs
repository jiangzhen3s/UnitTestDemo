using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo;
using UnitTestDemo.Fakes;
using Microsoft.QualityTools.Testing.Fakes;


namespace Fakes_UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPublicMethod()
        {
            using (ShimsContext.Create())
            {
                UnitTestDemo.Fakes.ShimTest.AllInstances.PublicWork = t => "xx";

                NeedTest test = new NeedTest();
                var ret = test.PublicWork();
                Assert.AreEqual("xx", ret);
            }
        }

        [TestMethod]
        public void TestPrivateMethod()
        {
            using (ShimsContext.Create())
            {
                ShimTest.AllInstances.PrivateWork = t => "xx";
                NeedTest test = new NeedTest();
                Assert.AreEqual("xx", test.CallPrivateWork());
            }
        }
    }
}
