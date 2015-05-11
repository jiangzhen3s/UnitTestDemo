using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo
{
    /// <summary>
    /// 需要测试的类
    /// </summary>
    public class NeedTest
    {
        public string PublicWork()
        {
            throw new NotImplementedException();
        }


        private string PrivateWork()
        {
            throw new NotImplementedException();
        }

        public string CallPrivateWork()
        {
            return this.PrivateWork();
        }
    }
}
