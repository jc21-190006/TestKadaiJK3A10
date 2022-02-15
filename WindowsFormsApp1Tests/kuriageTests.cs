using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Tests
{
    [TestClass()]
    public class kuriageTests
    {
        [TestMethod()]
        public void kuriage10Test()
        {
            //Assert.Fail();
            Assert.AreEqual(10, kuriage.kuriage10(6));
            Assert.AreEqual(20, kuriage.kuriage10(20));
            Assert.AreEqual(-20, kuriage.kuriage10(-18));
        }
    }
}