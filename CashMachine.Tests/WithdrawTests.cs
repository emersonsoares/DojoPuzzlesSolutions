using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CashMachine.Tests
{
    [TestClass]
    public class WithdrawTests
    {
        [TestMethod]
        public void TestReturnOfNotes()
        {
            var withdraw = new Withdraw(1, 1, 1, 1);

            Assert.AreEqual(1, withdraw.TenNotes);
            Assert.AreEqual(1, withdraw.TwentyNotes);
            Assert.AreEqual(1, withdraw.FiftyNotes);
            Assert.AreEqual(1, withdraw.HundredNotes);
        }
    }
}
