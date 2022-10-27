using Ispan.DockTrade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispan.StockTradeTest
{
    internal class TaiwainStockUtilityTest
    {
        [TestCase("2022,10,21 10:00", true)]
        [TestCase("2022,10,22 10:00", false)]
        [TestCase("2022,10,23 10:00", false)]
        [TestCase("2022,10,24 10:00", true)]
        public void IsTradingTime_周末是否為false(DateTime dt, bool actual )
        {
            var obj = new TaiwainStockUtility();
            var isTradingTime = obj.IsTradingTime(dt);
            Assert.AreEqual(actual, isTradingTime);

        }

        [TestCase("2022,10,24 8:59", false)]
        [TestCase("2022,10,24 9:00", true)]
        [TestCase("2022,10,24 13:30", true )]
        [TestCase("2022,10,24 13:31", false)]
        public void IsTradingTime_時間是否在時間內為true(DateTime dt, bool actual)
        {
            var obj = new TaiwainStockUtility();
            var isTradingTime = obj.IsTradingTime(dt);
            Assert.AreEqual(actual, isTradingTime);

        }
    }
}
