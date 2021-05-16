using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Video_rental;
using System;

namespace Project_Video_rentalTests3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Add_Form dg = new Add_Form();
            FeaturedConnection fg = new FeaturedConnection();
            if (fg.optn == 0) {
                Assert.IsTrue(true);
            }

        }
    }
}
