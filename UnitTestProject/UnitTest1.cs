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
                UnitTestDemo.Fakes.ShimNeedTest.AllInstances.PublicWork = t => "xx";

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
                //PrivateWork 是私有方法，只要私有方法入参类型在此项目中都可访问那Fakes框架会自动生成shim
                //如果私有方法临时添加，那么需要重新编译一下
                ShimNeedTest.AllInstances.PrivateWork = t => "xx";
                NeedTest test = new NeedTest();
                Assert.AreEqual("xx", test.CallPrivateWork());
            }
        }
    }
}
