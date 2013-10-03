using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CashMachine.Tests
{
    [TestClass]
    public class CashMachineTests
    {
        [TestMethod]
        public void WithdrawOfThirtyShouldBeReturnOneTenNoteAndTwoTwentyNotes()
        {
            var cashMachine = CashMachine.New();
            var withdraw = cashMachine.Get(30);

            var expectedWithdraw = new Withdraw(1, 1, 0, 0);

            Assert.AreEqual(expectedWithdraw, withdraw);
        }

        [TestMethod]
        public void WithdrawOfEightyShouldBeReturnOneTenNoteAndOneTwentyNotesAndOneFiftyNote()
        {
            var cashMachine = CashMachine.New();
            var withdraw = cashMachine.Get(80);

            var expectedWithdraw = new Withdraw(1, 1, 1, 0);

            Assert.AreEqual(expectedWithdraw, withdraw);
        }

        [TestMethod]
        public void WithdrawOfOneHundredEightyShouldBeReturnOneTenNoteAndOneTwentyNotesAndOneFiftyNoteAndOneHundredNote()
        {
            var cashMachine = CashMachine.New();
            var withdraw = cashMachine.Get(180);

            var expectedWithdraw = new Withdraw(1, 1, 1, 1);

            Assert.AreEqual(expectedWithdraw, withdraw);
        }
    }
}
