using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170922_TheSupermarketQueue
{
    [TestClass]
    public class TheSupermarketQueueTests
    {
        [TestMethod]
        public void input_empty_array_and_1_tills()
        {
            QueueTimeShouldBe(0, new int[] { }, 1);
        }


        [TestMethod]
        public void input_1_2_array_and_1_tills()
        {
            QueueTimeShouldBe(3, new[] { 1, 2 }, 1);
        }

        [TestMethod]
        public void input_1_2_3_array_and_1_tills()
        {
            QueueTimeShouldBe(6, new[] { 1, 2, 3 }, 1);
        }

        [TestMethod]
        public void input_1_2_array_and_2_tills()
        {
            QueueTimeShouldBe(2, new[] { 1, 2 }, 2);
        }

        private static void QueueTimeShouldBe(int expected, int[] customers, int n)
        {
            var kata = new Kata();
            var actual = kata.QueueTime(customers, n);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public int QueueTime(int[] customers, int n)
        {
            if (n == 1)
            {
                return customers.Sum();
            }

            return customers[1];
        }
    }
}
