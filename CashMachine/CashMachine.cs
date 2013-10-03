using System;

namespace CashMachine
{
    public class CashMachine
    {
        private CashMachine()
        { }

        public static CashMachine New()
        {
            return new CashMachine();
        }

        public Withdraw Get(int value)
        {
            int hundredRest;
            var hundredNotes = Math.DivRem(value, 100, out hundredRest);

            int fiftyRest;
            var fiftyNotes = Math.DivRem(hundredRest, 50, out fiftyRest);

            int twentyRest;
            var twentyNotes = Math.DivRem(fiftyRest, 20, out twentyRest);

            int tenRest;
            var tenNotes = Math.DivRem(twentyRest, 10, out tenRest);

            return new Withdraw(tenNotes, twentyNotes, fiftyNotes, hundredNotes);
        }
    }
}
